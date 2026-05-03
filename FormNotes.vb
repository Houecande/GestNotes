Imports System.Data.OleDb

Public Class FormNotes

    Private ClasseSelectionnee As String = ""
    Private CodeMatiereSelectionne As String = ""

    Private Sub FormNotes_Load(sender As Object, e As EventArgs) _
        Handles MyBase.Load
        ChargerComboClasses()
        ConfigurerGrille()
        btnCalculer.Enabled = False
        btnEnregistrer.Enabled = False
    End Sub

    Private Sub ConfigurerGrille()
        dgvNotes.DefaultCellStyle.Font = New Font("Segoe UI", 9)
        dgvNotes.ColumnHeadersDefaultCellStyle.BackColor =
            Color.FromArgb(230, 241, 251)
        dgvNotes.ColumnHeadersDefaultCellStyle.ForeColor =
            Color.FromArgb(12, 68, 124)
        dgvNotes.ColumnHeadersDefaultCellStyle.Font =
            New Font("Segoe UI", 9, FontStyle.Bold)
        dgvNotes.EnableHeadersVisualStyles = False
        dgvNotes.GridColor = Color.FromArgb(240, 244, 248)
        dgvNotes.AlternatingRowsDefaultCellStyle.BackColor =
            Color.FromArgb(250, 252, 255)
    End Sub

    Private Sub ChargerComboClasses()
        Dim dt = ModuleBDD.GetDataTable(
            "SELECT code_classe, libelle_classe " &
            "FROM Classe ORDER BY libelle_classe")
        cmbClasse.Items.Clear()
        For Each row As DataRow In dt.Rows
            cmbClasse.Items.Add(row("code_classe").ToString())
        Next
        cmbClasse.SelectedIndex = -1
    End Sub

    Private Sub cmbClasse_SelectedIndexChanged(
        sender As Object, e As EventArgs) _
        Handles cmbClasse.SelectedIndexChanged

        cmbMatiere.Items.Clear()
        cmbMatiere.SelectedIndex = -1
        dgvNotes.Rows.Clear()
        ClasseSelectionnee = ""
        CodeMatiereSelectionne = ""
        lblInfoClasse.Text = "Classe : —"
        lblInfoMatiere.Text = "Matière : —"
        lblInfoSaisies.Text = "0/0 saisies"
        btnCalculer.Enabled = False
        btnEnregistrer.Enabled = False
        MettreAZeroStats()

        If cmbClasse.SelectedIndex < 0 Then Exit Sub

        ClasseSelectionnee = cmbClasse.SelectedItem.ToString()
        lblInfoClasse.Text = "Classe : " & ClasseSelectionnee

        Dim dt = ModuleBDD.GetDataTable(
            "SELECT code_matiere, libelle_matiere, coefficient " &
            "FROM Matiere WHERE code_classe = ? " &
            "ORDER BY libelle_matiere",
            New OleDbParameter("@classe", ClasseSelectionnee))

        For Each row As DataRow In dt.Rows
            cmbMatiere.Items.Add(
                row("code_matiere").ToString() & " — " &
                row("libelle_matiere").ToString() &
                " (coef." & row("coefficient").ToString() & ")")
        Next
    End Sub

    Private Sub cmbMatiere_SelectedIndexChanged(
        sender As Object, e As EventArgs) _
        Handles cmbMatiere.SelectedIndexChanged

        If cmbMatiere.SelectedIndex < 0 Then Exit Sub

        Dim item = cmbMatiere.SelectedItem.ToString()
        CodeMatiereSelectionne = item.Split("—"c)(0).Trim()
        lblInfoMatiere.Text = "Matière : " & item
        ChargerNotesEtudiants()
        btnCalculer.Enabled = True
        btnEnregistrer.Enabled = True
    End Sub

    Private Sub ChargerNotesEtudiants()
        dgvNotes.Rows.Clear()

        Dim dtEtudiants = ModuleBDD.GetDataTable(
        "SELECT num_matricule, nom_prenom " &
        "FROM Etudiant WHERE code_classe = ? " &
        "ORDER BY nom_prenom",
        New OleDbParameter("@classe", ClasseSelectionnee))

        Dim matricules As New List(Of String)
        Dim num As Integer = 1

        For Each row As DataRow In dtEtudiants.Rows
            Dim matricule = row("num_matricule").ToString()
            Dim nom = row("nom_prenom").ToString()
            matricules.Add(matricule)

            Dim dtNote = ModuleBDD.GetDataTable(
            "SELECT note_interro, note_devoir, " &
            "moyenne_matiere FROM [Note] " &
            "WHERE num_matricule = ? AND code_matiere = ?",
            New OleDbParameter("@mat", matricule),
            New OleDbParameter("@code", CodeMatiereSelectionne))

            If dtNote.Rows.Count > 0 Then
                Dim noteRow = dtNote.Rows(0)
                Dim interro As Double = 0
                Dim devoir As Double = 0
                Double.TryParse(
                noteRow("note_interro").ToString().Replace(",", "."),
                interro)
                Double.TryParse(
                noteRow("note_devoir").ToString().Replace(",", "."),
                devoir)

                ' Recalculer la moyenne correctement
                Dim moy = Math.Round(0.3 * interro + 0.7 * devoir, 2)

                Dim rowIdx = dgvNotes.Rows.Add(
                num, nom,
                interro.ToString("F2"),
                devoir.ToString("F2"),
                moy.ToString("F2"))
                ColorierMoyenne(rowIdx, moy)
            Else
                dgvNotes.Rows.Add(num, nom, "", "", "—")
            End If
            num += 1
        Next

        dgvNotes.Tag = matricules
        MettreAJourStats()
    End Sub

    Private Sub dgvNotes_CellEndEdit(sender As Object,
        e As DataGridViewCellEventArgs) _
        Handles dgvNotes.CellEndEdit

        Dim row = e.RowIndex
        Dim col = e.ColumnIndex
        If row < 0 OrElse (col <> 2 AndAlso col <> 3) Then Exit Sub

        Dim valeur = dgvNotes.Rows(row).Cells(col).
            Value?.ToString().Trim()

        Dim note As Double = -1
        If Not String.IsNullOrEmpty(valeur) Then
            If Not Double.TryParse(
                valeur.Replace(",", "."), note) OrElse
               note < 0 OrElse note > 20 Then
                MsgBox("La note doit être entre 0 et 20.",
                       MsgBoxStyle.Exclamation, "Valeur invalide")
                dgvNotes.Rows(row).Cells(col).Value = ""
                Exit Sub
            End If
        End If

        Dim valInterro = dgvNotes.Rows(row).Cells(2).
            Value?.ToString().Trim()
        Dim valDevoir = dgvNotes.Rows(row).Cells(3).
            Value?.ToString().Trim()

        If Not String.IsNullOrEmpty(valInterro) AndAlso
           Not String.IsNullOrEmpty(valDevoir) Then
            Dim interro As Double
            Dim devoir As Double
            If Double.TryParse(
                valInterro.Replace(",", "."), interro) AndAlso
               Double.TryParse(
                valDevoir.Replace(",", "."), devoir) Then
                Dim moy = Math.Round(
                    0.3 * interro + 0.7 * devoir, 2)
                dgvNotes.Rows(row).Cells(4).Value =
                    moy.ToString("F2")
                ColorierMoyenne(row, moy)
            End If
        End If

        MettreAJourStats()
    End Sub

    Private Sub ColorierMoyenne(rowIndex As Integer, moy As Double)
        Dim cell = dgvNotes.Rows(rowIndex).Cells(4)
        If moy < 0 Then Exit Sub
        If moy >= 14 Then
            cell.Style.BackColor = Color.FromArgb(209, 250, 229)
            cell.Style.ForeColor = Color.FromArgb(6, 95, 70)
        ElseIf moy >= 10 Then
            cell.Style.BackColor = Color.FromArgb(225, 245, 238)
            cell.Style.ForeColor = Color.FromArgb(8, 80, 65)
        ElseIf moy >= 7 Then
            cell.Style.BackColor = Color.FromArgb(250, 238, 218)
            cell.Style.ForeColor = Color.FromArgb(99, 56, 6)
        Else
            cell.Style.BackColor = Color.FromArgb(252, 235, 235)
            cell.Style.ForeColor = Color.FromArgb(121, 31, 31)
        End If
    End Sub

    Private Sub btnCalculer_Click(sender As Object,
        e As EventArgs) Handles btnCalculer.Click
        Dim nbCalcules As Integer = 0
        For i As Integer = 0 To dgvNotes.Rows.Count - 1
            Dim valInterro = dgvNotes.Rows(i).Cells(2).
                Value?.ToString().Trim()
            Dim valDevoir = dgvNotes.Rows(i).Cells(3).
                Value?.ToString().Trim()
            If Not String.IsNullOrEmpty(valInterro) AndAlso
               Not String.IsNullOrEmpty(valDevoir) Then
                Dim interro As Double
                Dim devoir As Double
                If Double.TryParse(
                    valInterro.Replace(",", "."), interro) AndAlso
                   Double.TryParse(
                    valDevoir.Replace(",", "."), devoir) Then
                    Dim moy = Math.Round(
                        0.3 * interro + 0.7 * devoir, 2)
                    dgvNotes.Rows(i).Cells(4).Value =
                        moy.ToString("F2")
                    ColorierMoyenne(i, moy)
                    nbCalcules += 1
                End If
            End If
        Next
        MettreAJourStats()
        MsgBox(nbCalcules & " moyenne(s) calculée(s).",
               MsgBoxStyle.Information, "Calcul terminé")
    End Sub

    Private Sub btnEnregistrer_Click(sender As Object,
    e As EventArgs) Handles btnEnregistrer.Click

        If String.IsNullOrEmpty(ClasseSelectionnee) OrElse
       String.IsNullOrEmpty(CodeMatiereSelectionne) Then
            MsgBox("Sélectionnez une classe et une matière.",
               MsgBoxStyle.Exclamation, "Sélection requise")
            Exit Sub
        End If

        Dim matricules As List(Of String) =
        TryCast(dgvNotes.Tag, List(Of String))
        If matricules Is Nothing Then Exit Sub

        Dim nbEnregistres As Integer = 0
        Dim nbErreurs As Integer = 0

        For i As Integer = 0 To dgvNotes.Rows.Count - 1
            Dim valInterro = dgvNotes.Rows(i).Cells(2).
            Value?.ToString().Trim()
            Dim valDevoir = dgvNotes.Rows(i).Cells(3).
            Value?.ToString().Trim()

            ' Ne sauvegarder que si au moins une note est saisie
            If String.IsNullOrEmpty(valInterro) AndAlso
           String.IsNullOrEmpty(valDevoir) Then
                Continue For
            End If

            Dim interro As Double = 0
            Dim devoir As Double = 0

            If Not String.IsNullOrEmpty(valInterro) Then
                Double.TryParse(
                valInterro.Replace(",", "."), interro)
            End If
            If Not String.IsNullOrEmpty(valDevoir) Then
                Double.TryParse(
                valDevoir.Replace(",", "."), devoir)
            End If

            ' ── Calcul correct de la moyenne ──────────────────
            Dim moy As Double = 0
            If Not String.IsNullOrEmpty(valInterro) AndAlso
           Not String.IsNullOrEmpty(valDevoir) Then
                moy = Math.Round(0.3 * interro + 0.7 * devoir, 2)
                ' Mettre à jour la cellule moyenne dans la grille
                dgvNotes.Rows(i).Cells(4).Value = moy.ToString("F2")
                ColorierMoyenne(i, moy)
            End If

            Dim matricule = matricules(i)

            Dim existe = CInt(ModuleBDD.GetValeur(
            "SELECT COUNT(*) FROM [Note] " &
            "WHERE num_matricule = ? AND code_matiere = ?",
            New OleDbParameter("@mat", matricule),
            New OleDbParameter("@code", CodeMatiereSelectionne)))

            Dim ok As Boolean
            If existe > 0 Then
                Dim sql = "UPDATE [Note] SET " &
                      "note_interro = ?, note_devoir = ?, " &
                      "moyenne_matiere = ? " &
                      "WHERE num_matricule = ? " &
                      "AND code_matiere = ?"
                Dim params() As OleDbParameter = {
                New OleDbParameter("@interro", interro),
                New OleDbParameter("@devoir", devoir),
                New OleDbParameter("@moy", moy),
                New OleDbParameter("@mat", matricule),
                New OleDbParameter("@code", CodeMatiereSelectionne)
            }
                ok = ModuleBDD.ExecuterRequete(sql, params)
            Else
                Dim sql = "INSERT INTO [Note] " &
                      "(num_matricule, code_matiere, " &
                      "note_interro, note_devoir, moyenne_matiere) " &
                      "VALUES (?, ?, ?, ?, ?)"
                Dim params() As OleDbParameter = {
                New OleDbParameter("@mat", matricule),
                New OleDbParameter("@code", CodeMatiereSelectionne),
                New OleDbParameter("@interro", interro),
                New OleDbParameter("@devoir", devoir),
                New OleDbParameter("@moy", moy)
            }
                ok = ModuleBDD.ExecuterRequete(sql, params)
            End If

            If ok Then nbEnregistres += 1 Else nbErreurs += 1
        Next

        ' Recalculer les stats après enregistrement
        MettreAJourStats()

        If nbErreurs = 0 Then
            MsgBox(nbEnregistres &
               " note(s) enregistrée(s) avec succès.",
               MsgBoxStyle.Information, "Succès")
        Else
            MsgBox(nbEnregistres & " note(s) enregistrée(s)." &
               vbCrLf & nbErreurs & " erreur(s).",
               MsgBoxStyle.Exclamation, "Partiel")
        End If

        ' Rafraîchir stat dashboard
        Dim fPrincipal As FormPrincipal =
        TryCast(Me.ParentForm, FormPrincipal)
        If fPrincipal IsNot Nothing Then
            Dim total = CInt(ModuleBDD.GetValeur(
            "SELECT COUNT(*) FROM [Note]"))
            fPrincipal.lblValNotes.Text = total.ToString()
        End If
    End Sub

    Private Sub MettreAJourStats()
        Dim moyennes As New List(Of Double)
        Dim nbSaisies As Integer = 0
        Dim total = dgvNotes.Rows.Count

        For Each row As DataGridViewRow In dgvNotes.Rows
            Dim valMoy = row.Cells(4).Value?.ToString()
            If Not String.IsNullOrEmpty(valMoy) AndAlso
               valMoy <> "—" Then
                Dim moy As Double
                If Double.TryParse(
                    valMoy.Replace(",", "."), moy) Then
                    moyennes.Add(moy)
                    nbSaisies += 1
                End If
            End If
        Next

        lblInfoSaisies.Text = nbSaisies & "/" & total & " saisies"
        lblValSaisies.Text = nbSaisies & "/" & total

        If moyennes.Count = 0 Then
            MettreAZeroStats()
            Exit Sub
        End If

        lblValMoyClasse.Text = Math.Round(
            moyennes.Average(), 2).ToString("F2")
        lblValMax.Text = moyennes.Max().ToString("F2")
        lblValMin.Text = moyennes.Min().ToString("F2")
    End Sub

    Private Sub MettreAZeroStats()
        lblValMoyClasse.Text = "—"
        lblValMax.Text = "—"
        lblValMin.Text = "—"
        lblValSaisies.Text = "0/0"
    End Sub

End Class