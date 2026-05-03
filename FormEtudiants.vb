Imports System.Data.OleDb

Public Class FormEtudiants

    Private ModeFiche As String = ""
    Private MatriculeSelectionne As String = ""

    ' Chargement du formulaire
    Private Sub FormEtudiants_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ChargerComboClasses()
        ChargerGrille()
        ViderFiche()
    End Sub

    ' Charger les classes dans les ComboBox 
    Private Sub ChargerComboClasses()
        Dim dt = ModuleBDD.GetDataTable(
            "SELECT code_classe, libelle_classe FROM Classe ORDER BY libelle_classe")

        ' ComboBox filtre (barre de recherche)
        cmbFiltreClasse.Items.Clear()
        cmbFiltreClasse.Items.Add("Toutes les classes")
        For Each row As DataRow In dt.Rows
            cmbFiltreClasse.Items.Add(row("code_classe").ToString())
        Next
        cmbFiltreClasse.SelectedIndex = 0

        ' ComboBox fiche étudiant
        cmbClasse.Items.Clear()
        For Each row As DataRow In dt.Rows
            cmbClasse.Items.Add(row("code_classe").ToString())
        Next
    End Sub

    ' Charger la grille des étudiants 
    Private Sub ChargerGrille()
        Dim motCle = txtRecherche.Text.Trim().ToLower()
        Dim classeFiltre = If(cmbFiltreClasse.SelectedIndex <= 0, "",
                              cmbFiltreClasse.SelectedItem.ToString())

        Dim sql = "SELECT num_matricule, nom_prenom, sexe, code_classe " &
                  "FROM Etudiant WHERE 1=1"
        Dim params As New List(Of OleDbParameter)

        If Not String.IsNullOrEmpty(motCle) Then
            sql &= " AND (LCase(nom_prenom) LIKE ? OR LCase(num_matricule) LIKE ?)"
            params.Add(New OleDbParameter("@nom", "%" & motCle & "%"))
            params.Add(New OleDbParameter("@mat", "%" & motCle & "%"))
        End If

        If Not String.IsNullOrEmpty(classeFiltre) Then
            sql &= " AND code_classe = ?"
            params.Add(New OleDbParameter("@classe", classeFiltre))
        End If

        sql &= " ORDER BY nom_prenom"

        Dim dt = ModuleBDD.GetDataTable(sql, params.ToArray())
        dgvEtudiants.Rows.Clear()

        For Each row As DataRow In dt.Rows
            dgvEtudiants.Rows.Add(
                row("num_matricule").ToString(),
                row("nom_prenom").ToString(),
                row("sexe").ToString(),
                row("code_classe").ToString(),
                "✏️ Modifier",
                "🗑️ Suppr.")
        Next

        ' Mettre à jour le compteur dans le tableau de bord
        MettreAJourStatEtudiants(dt.Rows.Count)
    End Sub

    ' Mettre à jour la stat dans FormPrincipal 
    Private Sub MettreAJourStatEtudiants(nb As Integer)
        Dim fPrincipal As FormPrincipal = TryCast(Me.ParentForm, FormPrincipal)
        If fPrincipal IsNot Nothing Then
            fPrincipal.lblValEtudiants.Text = nb.ToString()
        End If
    End Sub

    ' Vider la fiche de droite 
    Private Sub ViderFiche()
        txtMatricule.Clear()
        txtNomPrenom.Clear()
        cmbSexe.SelectedIndex = -1
        dtpDateNaiss.Value = DateTime.Now.AddYears(-20)
        txtLieuNaiss.Clear()
        cmbClasse.SelectedIndex = -1
        ModeFiche = ""
        MatriculeSelectionne = ""
        btnSupprimer.Enabled = False
        txtMatricule.ReadOnly = False
    End Sub

    ' Remplir la fiche avec un étudiant 
    Private Sub RemplirFiche(matricule As String)
        Dim sql = "SELECT * FROM Etudiant WHERE num_matricule = ?"
        Dim dt = ModuleBDD.GetDataTable(sql,
            New OleDbParameter("@mat", matricule))

        If dt.Rows.Count = 0 Then Exit Sub

        Dim row = dt.Rows(0)
        txtMatricule.Text = row("num_matricule").ToString()
        txtNomPrenom.Text = row("nom_prenom").ToString()
        cmbSexe.SelectedItem = row("sexe").ToString()
        Try
            dtpDateNaiss.Value = CDate(row("date_naissance"))
        Catch
            dtpDateNaiss.Value = DateTime.Now.AddYears(-20)
        End Try
        txtLieuNaiss.Text = row("lieu_naissance").ToString()
        cmbClasse.SelectedItem = row("code_classe").ToString()

        MatriculeSelectionne = matricule
        ModeFiche = "Modifier"
        txtMatricule.ReadOnly = True
        btnSupprimer.Enabled = ModuleSession.EstAdmin
    End Sub

    ' Clic sur le DataGridView 
    Private Sub dgvEtudiants_CellClick(sender As Object, e As DataGridViewCellEventArgs) _
        Handles dgvEtudiants.CellClick

        If e.RowIndex < 0 Then Exit Sub

        Dim matricule = dgvEtudiants.Rows(e.RowIndex).Cells(0).Value?.ToString()
        If String.IsNullOrEmpty(matricule) Then Exit Sub

        If e.ColumnIndex = 5 Then ' Colonne Supprimer
            SupprimerEtudiant(matricule)
        Else ' Toute autre colonne = remplir fiche
            RemplirFiche(matricule)
        End If
    End Sub

    ' Bouton Nouvel étudiant
    Private Sub btnNouvelEtudiant_Click(sender As Object, e As EventArgs) _
        Handles btnNouvelEtudiant.Click
        ViderFiche()
        ModeFiche = "Nouveau"
        txtMatricule.Focus()
    End Sub

    ' Bouton Enregistrer 
    Private Sub btnEnregistrer_Click(sender As Object, e As EventArgs) _
        Handles btnEnregistrer.Click

        ' Validation 
        If String.IsNullOrWhiteSpace(txtMatricule.Text) Then
            MsgBox("Le matricule est obligatoire.",
                   MsgBoxStyle.Exclamation, "Champ requis")
            txtMatricule.Focus() : Exit Sub
        End If
        If String.IsNullOrWhiteSpace(txtNomPrenom.Text) Then
            MsgBox("Le nom et prénom sont obligatoires.",
                   MsgBoxStyle.Exclamation, "Champ requis")
            txtNomPrenom.Focus() : Exit Sub
        End If
        If cmbSexe.SelectedIndex = -1 Then
            MsgBox("Veuillez sélectionner le sexe.",
                   MsgBoxStyle.Exclamation, "Champ requis")
            cmbSexe.Focus() : Exit Sub
        End If
        If cmbClasse.SelectedIndex = -1 Then
            MsgBox("Veuillez sélectionner la classe.",
                   MsgBoxStyle.Exclamation, "Champ requis")
            cmbClasse.Focus() : Exit Sub
        End If

        If ModeFiche = "Nouveau" Then
            InsererEtudiant()
        ElseIf ModeFiche = "Modifier" Then
            ModifierEtudiant()
        End If
    End Sub

    ' Insérer un nouvel étudiant 
    Private Sub InsererEtudiant()
        ' Vérifier doublon matricule
        Dim existe = ModuleBDD.GetValeur(
            "SELECT COUNT(*) FROM Etudiant WHERE num_matricule = ?",
            New OleDbParameter("@mat", txtMatricule.Text.Trim().ToUpper()))

        If CInt(existe) > 0 Then
            MsgBox("Ce numéro matricule existe déjà.",
                   MsgBoxStyle.Exclamation, "Doublon")
            Exit Sub
        End If

        Dim sql = "INSERT INTO Etudiant " &
                  "(num_matricule, nom_prenom, sexe, date_naissance, " &
                  "lieu_naissance, code_classe) " &
                  "VALUES (?, ?, ?, ?, ?, ?)"

        Dim params() As OleDbParameter = {
            New OleDbParameter("@mat",
                txtMatricule.Text.Trim().ToUpper()),
            New OleDbParameter("@nom",
                txtNomPrenom.Text.Trim().ToUpper()),
            New OleDbParameter("@sexe",
                cmbSexe.SelectedItem.ToString()),
            New OleDbParameter("@dtn",
                dtpDateNaiss.Value.Date),
            New OleDbParameter("@lieu",
                txtLieuNaiss.Text.Trim()),
            New OleDbParameter("@classe",
                cmbClasse.SelectedItem.ToString())
        }

        If ModuleBDD.ExecuterRequete(sql, params) Then
            MsgBox("Étudiant ajouté avec succès.",
                   MsgBoxStyle.Information, "Succès")
            ChargerGrille()
            ViderFiche()
        End If
    End Sub

    ' Modifier un étudiant 
    Private Sub ModifierEtudiant()
        If Not ModuleSession.EstAdmin Then
            Dim rep = MsgBox("Confirmer la modification de cet étudiant ?",
                             MsgBoxStyle.YesNo + MsgBoxStyle.Question,
                             "Confirmation")
            If rep = MsgBoxResult.No Then Exit Sub
        End If

        Dim sql = "UPDATE Etudiant SET " &
                  "nom_prenom = ?, sexe = ?, date_naissance = ?, " &
                  "lieu_naissance = ?, code_classe = ? " &
                  "WHERE num_matricule = ?"

        Dim params() As OleDbParameter = {
            New OleDbParameter("@nom",
                txtNomPrenom.Text.Trim().ToUpper()),
            New OleDbParameter("@sexe",
                cmbSexe.SelectedItem.ToString()),
            New OleDbParameter("@dtn",
                dtpDateNaiss.Value.Date),
            New OleDbParameter("@lieu",
                txtLieuNaiss.Text.Trim()),
            New OleDbParameter("@classe",
                cmbClasse.SelectedItem.ToString()),
            New OleDbParameter("@mat",
                MatriculeSelectionne)
        }

        If ModuleBDD.ExecuterRequete(sql, params) Then
            MsgBox("Étudiant modifié avec succès.",
                   MsgBoxStyle.Information, "Succès")
            ChargerGrille()
            ViderFiche()
        End If
    End Sub

    ' Supprimer un étudiant 
    Private Sub SupprimerEtudiant(matricule As String)
        If Not ModuleSession.EstAdmin Then
            MsgBox("Seul l'administrateur peut supprimer un étudiant.",
                   MsgBoxStyle.Exclamation, "Accès refusé")
            Exit Sub
        End If

        ' Vérifier si l'étudiant a des notes
        Dim nbNotes = CInt(ModuleBDD.GetValeur(
            "SELECT COUNT(*) FROM Note WHERE num_matricule = ?",
            New OleDbParameter("@mat", matricule)))

        If nbNotes > 0 Then
            Dim rep2 = MsgBox("Cet étudiant a " & nbNotes &
                              " note(s) enregistrée(s)." & vbCrLf &
                              "La suppression effacera aussi ses notes." &
                              vbCrLf & vbCrLf &
                              "Confirmer quand même la suppression ?",
                              MsgBoxStyle.YesNo + MsgBoxStyle.Critical,
                              "Attention — Notes existantes")
            If rep2 = MsgBoxResult.No Then Exit Sub

            ' Supprimer d'abord les notes
            ModuleBDD.ExecuterRequete(
                "DELETE FROM Note WHERE num_matricule = ?",
                New OleDbParameter("@mat", matricule))
        Else
            Dim rep = MsgBox("Supprimer l'étudiant " &
                             matricule & " ?" & vbCrLf &
                             "Cette action est irréversible.",
                             MsgBoxStyle.YesNo + MsgBoxStyle.Critical,
                             "Confirmation de suppression")
            If rep = MsgBoxResult.No Then Exit Sub
        End If

        If ModuleBDD.ExecuterRequete(
            "DELETE FROM Etudiant WHERE num_matricule = ?",
            New OleDbParameter("@mat", matricule)) Then
            MsgBox("Étudiant supprimé avec succès.",
                   MsgBoxStyle.Information, "Supprimé")
            ChargerGrille()
            ViderFiche()
        End If
    End Sub

    Private Sub btnSupprimer_Click(sender As Object, e As EventArgs) _
        Handles btnSupprimer.Click
        If Not String.IsNullOrEmpty(MatriculeSelectionne) Then
            SupprimerEtudiant(MatriculeSelectionne)
        End If
    End Sub

    ' Bouton Annuler 
    Private Sub btnAnnuler_Click(sender As Object, e As EventArgs) _
        Handles btnAnnuler.Click
        ViderFiche()
    End Sub

    ' Recherche en temps réel 
    Private Sub txtRecherche_TextChanged(sender As Object, e As EventArgs) _
        Handles txtRecherche.TextChanged
        ChargerGrille()
    End Sub

    Private Sub cmbFiltreClasse_SelectedIndexChanged(
        sender As Object, e As EventArgs) _
        Handles cmbFiltreClasse.SelectedIndexChanged
        ChargerGrille()
    End Sub

End Class