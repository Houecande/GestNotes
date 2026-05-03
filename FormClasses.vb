Imports System.Data.OleDb

Public Class FormClasses
    Private ModeClasse As String = ""
    Private ModeMatiere As String = ""
    Private CodeClasseSelectionne As String = ""
    Private CodeMatiereSelectionne As String = ""

    ' Chargement 
    Private Sub FormClasses_Load(sender As Object, e As EventArgs) _
        Handles MyBase.Load
        ChargerGrilleClasses()
        ViderFormClasse()
        ViderFormMatiere()
        btnSupprimerClasse.Enabled = False
        btnSupprimerMatiere.Enabled = False
        btnNouvelleMatiere.Enabled = False
        dgvMatieres.Rows.Clear()
    End Sub

    '  SECTION CLASSES

    Private Sub ChargerGrilleClasses()
        Dim dt = ModuleBDD.GetDataTable(
            "SELECT code_classe, libelle_classe, filiere " &
            "FROM Classe ORDER BY code_classe")

        dgvClasses.Rows.Clear()
        For Each row As DataRow In dt.Rows
            dgvClasses.Rows.Add(
                row("code_classe").ToString(),
                row("libelle_classe").ToString(),
                row("filiere").ToString(),
                "✏️  🗑️")
        Next
    End Sub

    Private Sub ViderFormClasse()
        txtCodeClasse.Clear()
        txtLibelleClasse.Clear()
        txtFiliereClasse.Clear()
        lblTitreFormClasse.Text = "Nouvelle classe"
        ModeClasse = ""
        CodeClasseSelectionne = ""
        btnSupprimerClasse.Enabled = False
        txtCodeClasse.ReadOnly = False
    End Sub

    ' Clic sur la grille Classes 
    Private Sub dgvClasses_CellClick(sender As Object, e As DataGridViewCellEventArgs) _
        Handles dgvClasses.CellClick
        If e.RowIndex < 0 Then Exit Sub

        Dim code = dgvClasses.Rows(e.RowIndex).Cells(0).Value?.ToString()
        If String.IsNullOrEmpty(code) Then Exit Sub

        ' Remplir le formulaire classe
        Dim dt = ModuleBDD.GetDataTable(
            "SELECT * FROM Classe WHERE code_classe = ?",
            New OleDbParameter("@code", code))

        If dt.Rows.Count = 0 Then Exit Sub
        Dim row = dt.Rows(0)

        txtCodeClasse.Text = row("code_classe").ToString()
        txtLibelleClasse.Text = row("libelle_classe").ToString()
        txtFiliereClasse.Text = row("filiere").ToString()
        lblTitreFormClasse.Text = "Modifier classe"
        ModeClasse = "Modifier"
        CodeClasseSelectionne = code
        txtCodeClasse.ReadOnly = True
        btnSupprimerClasse.Enabled = ModuleSession.EstAdmin

        ' Charger les matières de cette classe
        lblTitreMatieres.Text = "📖 Matières de : " &
                                row("libelle_classe").ToString()
        ChargerGrilleMatieres(code)
        btnNouvelleMatiere.Enabled = True
        ViderFormMatiere()
    End Sub

    ' Bouton + Classe 
    Private Sub btnNouvelleClasse_Click(sender As Object, e As EventArgs) _
        Handles btnNouvelleClasse.Click
        ViderFormClasse()
        ModeClasse = "Nouveau"
        txtCodeClasse.Focus()
    End Sub

    ' Enregistrer Classe 
    Private Sub btnEnregistrerClasse_Click(sender As Object, e As EventArgs) _
        Handles btnEnregistrerClasse.Click

        ' Validation
        If String.IsNullOrWhiteSpace(txtCodeClasse.Text) Then
            MsgBox("Le code classe est obligatoire.",
                   MsgBoxStyle.Exclamation, "Champ requis")
            txtCodeClasse.Focus() : Exit Sub
        End If
        If String.IsNullOrWhiteSpace(txtLibelleClasse.Text) Then
            MsgBox("Le libellé est obligatoire.",
                   MsgBoxStyle.Exclamation, "Champ requis")
            txtLibelleClasse.Focus() : Exit Sub
        End If

        If ModeClasse = "Nouveau" Then
            ' Vérifier doublon
            Dim existe = CInt(ModuleBDD.GetValeur(
                "SELECT COUNT(*) FROM Classe WHERE code_classe = ?",
                New OleDbParameter("@code",
                    txtCodeClasse.Text.Trim().ToUpper())))

            If existe > 0 Then
                MsgBox("Ce code classe existe déjà.",
                       MsgBoxStyle.Exclamation, "Doublon")
                Exit Sub
            End If

            ' Insertion
            Dim sql = "INSERT INTO Classe " &
                      "(code_classe, libelle_classe, filiere) " &
                      "VALUES (?, ?, ?)"
            Dim params() As OleDbParameter = {
                New OleDbParameter("@code",
                    txtCodeClasse.Text.Trim().ToUpper()),
                New OleDbParameter("@lib",
                    txtLibelleClasse.Text.Trim()),
                New OleDbParameter("@fil",
                    txtFiliereClasse.Text.Trim())
            }
            If ModuleBDD.ExecuterRequete(sql, params) Then
                MsgBox("Classe ajoutée avec succès.",
                       MsgBoxStyle.Information, "Succès")
                ChargerGrilleClasses()
                ViderFormClasse()
            End If

        ElseIf ModeClasse = "Modifier" Then
            If Not ModuleSession.EstAdmin Then
                If MsgBox("Confirmer la modification ?",
                          MsgBoxStyle.YesNo + MsgBoxStyle.Question,
                          "Confirmation") = MsgBoxResult.No Then
                    Exit Sub
                End If
            End If

            Dim sql = "UPDATE Classe SET " &
                      "libelle_classe = ?, filiere = ? " &
                      "WHERE code_classe = ?"
            Dim params() As OleDbParameter = {
                New OleDbParameter("@lib",
                    txtLibelleClasse.Text.Trim()),
                New OleDbParameter("@fil",
                    txtFiliereClasse.Text.Trim()),
                New OleDbParameter("@code",
                    CodeClasseSelectionne)
            }
            If ModuleBDD.ExecuterRequete(sql, params) Then
                MsgBox("Classe modifiée avec succès.",
                       MsgBoxStyle.Information, "Succès")
                ChargerGrilleClasses()
                ViderFormClasse()
            End If
        End If
    End Sub

    ' Supprimer Classe
    Private Sub btnSupprimerClasse_Click(sender As Object, e As EventArgs) _
        Handles btnSupprimerClasse.Click

        If Not ModuleSession.EstAdmin Then
            MsgBox("Seul l'administrateur peut supprimer.",
                   MsgBoxStyle.Exclamation, "Accès refusé")
            Exit Sub
        End If
        If String.IsNullOrEmpty(CodeClasseSelectionne) Then Exit Sub

        ' Vérifier s'il y a des matières liées
        Dim nbMatieres = CInt(ModuleBDD.GetValeur(
            "SELECT COUNT(*) FROM Matiere WHERE code_classe = ?",
            New OleDbParameter("@code", CodeClasseSelectionne)))

        If nbMatieres > 0 Then
            MsgBox("Impossible de supprimer : cette classe contient " &
                   nbMatieres & " matière(s)." & vbCrLf &
                   "Supprimez d'abord les matières.",
                   MsgBoxStyle.Exclamation, "Suppression impossible")
            Exit Sub
        End If

        ' Vérifier s'il y a des étudiants liés
        Dim nbEtudiants = CInt(ModuleBDD.GetValeur(
            "SELECT COUNT(*) FROM Etudiant WHERE code_classe = ?",
            New OleDbParameter("@code", CodeClasseSelectionne)))

        If nbEtudiants > 0 Then
            MsgBox("Impossible de supprimer : " & nbEtudiants &
                   " étudiant(s) appartiennent à cette classe." & vbCrLf &
                   "Changez d'abord leur classe.",
                   MsgBoxStyle.Exclamation, "Suppression impossible")
            Exit Sub
        End If

        If MsgBox("Supprimer la classe """ &
                  CodeClasseSelectionne & """ ?" & vbCrLf &
                  "Cette action est irréversible.",
                  MsgBoxStyle.YesNo + MsgBoxStyle.Critical,
                  "Confirmation") = MsgBoxResult.Yes Then

            If ModuleBDD.ExecuterRequete(
                "DELETE FROM Classe WHERE code_classe = ?",
                New OleDbParameter("@code",
                    CodeClasseSelectionne)) Then
                MsgBox("Classe supprimée avec succès.",
                       MsgBoxStyle.Information, "Supprimé")
                ChargerGrilleClasses()
                ViderFormClasse()
                dgvMatieres.Rows.Clear()
                lblTitreMatieres.Text =
                    "📖 Matières de : (sélectionnez une classe)"
                btnNouvelleMatiere.Enabled = False
            End If
        End If
    End Sub

    '  SECTION MATIÈRES

    Private Sub ChargerGrilleMatieres(codeClasse As String)
        Dim dt = ModuleBDD.GetDataTable(
            "SELECT code_matiere, libelle_matiere, coefficient " &
            "FROM Matiere WHERE code_classe = ? " &
            "ORDER BY libelle_matiere",
            New OleDbParameter("@code", codeClasse))

        dgvMatieres.Rows.Clear()
        For Each row As DataRow In dt.Rows
            dgvMatieres.Rows.Add(
                row("code_matiere").ToString(),
                row("libelle_matiere").ToString(),
                row("coefficient").ToString(),
                "✏️  🗑️")
        Next

        ' Mettre à jour stat matières dans dashboard
        Dim total = CInt(ModuleBDD.GetValeur(
            "SELECT COUNT(*) FROM Matiere"))
        Dim fPrincipal As FormPrincipal =
            TryCast(Me.ParentForm, FormPrincipal)
        If fPrincipal IsNot Nothing Then
            fPrincipal.lblValMatieres.Text = total.ToString()
        End If
    End Sub

    Private Sub ViderFormMatiere()
        txtCodeMatiere.Clear()
        txtLibelleMatiere.Clear()
        nudCoefficient.Value = 1
        lblTitreFormMatiere.Text = "Nouvelle matière"
        ModeMatiere = ""
        CodeMatiereSelectionne = ""
        btnSupprimerMatiere.Enabled = False
        txtCodeMatiere.ReadOnly = False
    End Sub

    ' Clic sur la grille Matières
    Private Sub dgvMatieres_CellClick(sender As Object, e As DataGridViewCellEventArgs) _
        Handles dgvMatieres.CellClick
        If e.RowIndex < 0 Then Exit Sub

        Dim code = dgvMatieres.Rows(e.RowIndex).Cells(0).Value?.ToString()
        If String.IsNullOrEmpty(code) Then Exit Sub

        Dim dt = ModuleBDD.GetDataTable(
            "SELECT * FROM Matiere WHERE code_matiere = ?",
            New OleDbParameter("@code", code))

        If dt.Rows.Count = 0 Then Exit Sub
        Dim row = dt.Rows(0)

        txtCodeMatiere.Text = row("code_matiere").ToString()
        txtLibelleMatiere.Text = row("libelle_matiere").ToString()
        nudCoefficient.Value = CInt(row("coefficient"))
        lblTitreFormMatiere.Text = "Modifier matière"
        ModeMatiere = "Modifier"
        CodeMatiereSelectionne = code
        txtCodeMatiere.ReadOnly = True
        btnSupprimerMatiere.Enabled = ModuleSession.EstAdmin
    End Sub

    ' Bouton + Matière 
    Private Sub btnNouvelleMatiere_Click(sender As Object, e As EventArgs) _
        Handles btnNouvelleMatiere.Click
        If String.IsNullOrEmpty(CodeClasseSelectionne) Then
            MsgBox("Sélectionnez d'abord une classe.",
                   MsgBoxStyle.Exclamation, "Classe requise")
            Exit Sub
        End If
        ViderFormMatiere()
        ModeMatiere = "Nouveau"
        txtCodeMatiere.Focus()
    End Sub

    ' Enregistrer Matière 
    Private Sub btnEnregistrerMatiere_Click(sender As Object, e As EventArgs) _
        Handles btnEnregistrerMatiere.Click

        If String.IsNullOrEmpty(CodeClasseSelectionne) Then
            MsgBox("Sélectionnez d'abord une classe.",
                   MsgBoxStyle.Exclamation, "Classe requise")
            Exit Sub
        End If
        If String.IsNullOrWhiteSpace(txtCodeMatiere.Text) Then
            MsgBox("Le code matière est obligatoire.",
                   MsgBoxStyle.Exclamation, "Champ requis")
            txtCodeMatiere.Focus() : Exit Sub
        End If
        If String.IsNullOrWhiteSpace(txtLibelleMatiere.Text) Then
            MsgBox("Le libellé est obligatoire.",
                   MsgBoxStyle.Exclamation, "Champ requis")
            txtLibelleMatiere.Focus() : Exit Sub
        End If

        If ModeMatiere = "Nouveau" Then
            ' Vérifier doublon
            Dim existe = CInt(ModuleBDD.GetValeur(
                "SELECT COUNT(*) FROM Matiere " &
                "WHERE code_matiere = ? AND code_classe = ?",
                New OleDbParameter("@code",
                    txtCodeMatiere.Text.Trim().ToUpper()),
                New OleDbParameter("@classe",
                    CodeClasseSelectionne)))

            If existe > 0 Then
                MsgBox("Ce code matière existe déjà dans cette classe.",
                       MsgBoxStyle.Exclamation, "Doublon")
                Exit Sub
            End If

            Dim sql = "INSERT INTO Matiere " &
                      "(code_matiere, libelle_matiere, " &
                      "coefficient, code_classe) " &
                      "VALUES (?, ?, ?, ?)"
            Dim params() As OleDbParameter = {
                New OleDbParameter("@code",
                    txtCodeMatiere.Text.Trim().ToUpper()),
                New OleDbParameter("@lib",
                    txtLibelleMatiere.Text.Trim()),
                New OleDbParameter("@coef",
                    CInt(nudCoefficient.Value)),
                New OleDbParameter("@classe",
                    CodeClasseSelectionne)
            }
            If ModuleBDD.ExecuterRequete(sql, params) Then
                MsgBox("Matière ajoutée avec succès.",
                       MsgBoxStyle.Information, "Succès")
                ChargerGrilleMatieres(CodeClasseSelectionne)
                ViderFormMatiere()
            End If

        ElseIf ModeMatiere = "Modifier" Then
            If Not ModuleSession.EstAdmin Then
                If MsgBox("Confirmer la modification ?",
                          MsgBoxStyle.YesNo + MsgBoxStyle.Question,
                          "Confirmation") = MsgBoxResult.No Then
                    Exit Sub
                End If
            End If

            Dim sql = "UPDATE Matiere SET " &
                      "libelle_matiere = ?, coefficient = ? " &
                      "WHERE code_matiere = ? AND code_classe = ?"
            Dim params() As OleDbParameter = {
                New OleDbParameter("@lib",
                    txtLibelleMatiere.Text.Trim()),
                New OleDbParameter("@coef",
                    CInt(nudCoefficient.Value)),
                New OleDbParameter("@code",
                    CodeMatiereSelectionne),
                New OleDbParameter("@classe",
                    CodeClasseSelectionne)
            }
            If ModuleBDD.ExecuterRequete(sql, params) Then
                MsgBox("Matière modifiée avec succès.",
                       MsgBoxStyle.Information, "Succès")
                ChargerGrilleMatieres(CodeClasseSelectionne)
                ViderFormMatiere()
            End If
        End If
    End Sub

    ' Supprimer Matière 
    Private Sub btnSupprimerMatiere_Click(sender As Object, e As EventArgs) _
        Handles btnSupprimerMatiere.Click

        If Not ModuleSession.EstAdmin Then
            MsgBox("Seul l'administrateur peut supprimer.",
                   MsgBoxStyle.Exclamation, "Accès refusé")
            Exit Sub
        End If
        If String.IsNullOrEmpty(CodeMatiereSelectionne) Then Exit Sub

        ' Vérifier si des notes existent pour cette matière
        Dim nbNotes = CInt(ModuleBDD.GetValeur(
            "SELECT COUNT(*) FROM [Note] WHERE code_matiere = ?",
            New OleDbParameter("@code", CodeMatiereSelectionne)))

        If nbNotes > 0 Then
            If MsgBox("Cette matière a " & nbNotes &
                      " note(s) enregistrée(s)." & vbCrLf &
                      "La suppression effacera aussi ces notes." &
                      vbCrLf & "Confirmer ?",
                      MsgBoxStyle.YesNo + MsgBoxStyle.Critical,
                      "Attention") = MsgBoxResult.No Then
                Exit Sub
            End If
            ModuleBDD.ExecuterRequete(
                "DELETE FROM [Note] WHERE code_matiere = ?",
                New OleDbParameter("@code", CodeMatiereSelectionne))
        Else
            If MsgBox("Supprimer la matière """ &
                      CodeMatiereSelectionne & """ ?",
                      MsgBoxStyle.YesNo + MsgBoxStyle.Critical,
                      "Confirmation") = MsgBoxResult.No Then
                Exit Sub
            End If
        End If

        If ModuleBDD.ExecuterRequete(
            "DELETE FROM Matiere WHERE code_matiere = ?",
            New OleDbParameter("@code",
                CodeMatiereSelectionne)) Then
            MsgBox("Matière supprimée avec succès.",
                   MsgBoxStyle.Information, "Supprimé")
            ChargerGrilleMatieres(CodeClasseSelectionne)
            ViderFormMatiere()
        End If
    End Sub
End Class