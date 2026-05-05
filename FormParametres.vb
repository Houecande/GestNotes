Imports System.Data.OleDb

Public Class FormParametres

    Private ModeUser As String = ""
    Private IdUserSelectionne As Integer = -1
    Private LoginUserSelectionne As String = ""

    ' Chargement 
    Private Sub FormParametres_Load(sender As Object, e As EventArgs) _
        Handles MyBase.Load

        ' Vérification sécurité
        If Not ModuleSession.EstAdmin Then
            MsgBox("Accès réservé à l'administrateur.",
                   MsgBoxStyle.Critical, "Accès refusé")
            Me.Close()
            Exit Sub
        End If

        ' Rôles disponibles
        cmbRoleUser.Items.Clear()
        cmbRoleUser.Items.Add("Administrateur")
        cmbRoleUser.Items.Add("Secrétaire")

        ChargerGrilleUsers()
        ChargerParametresInstitut()
        ViderFicheUser()
        btnSupprimerUser.Enabled = False
    End Sub

    '  SECTION UTILISATEURS

    Private Sub ChargerGrilleUsers()
        Dim dt = ModuleBDD.GetDataTable(
            "SELECT id_utilisateur, login, role " &
            "FROM Utilisateurs ORDER BY login")

        dgvUtilisateurs.Rows.Clear()
        For Each row As DataRow In dt.Rows
            dgvUtilisateurs.Rows.Add(
                row("id_utilisateur").ToString(),
                row("login").ToString(),
                row("role").ToString())
        Next
    End Sub

    Private Sub ViderFicheUser()
        txtLoginUser.Clear()
        txtMdpUser.Clear()
        txtMdpConfirm.Clear()
        cmbRoleUser.SelectedIndex = -1
        ModeUser = ""
        IdUserSelectionne = -1
        LoginUserSelectionne = ""
        btnSupprimerUser.Enabled = False
        txtLoginUser.ReadOnly = False
    End Sub

    ' Clic sur la grille utilisateurs 
    Private Sub dgvUtilisateurs_CellClick(
        sender As Object,
        e As DataGridViewCellEventArgs) _
        Handles dgvUtilisateurs.CellClick

        If e.RowIndex < 0 Then Exit Sub

        Dim id = CInt(dgvUtilisateurs.Rows(e.RowIndex).
            Cells(0).Value)
        Dim login = dgvUtilisateurs.Rows(e.RowIndex).
            Cells(1).Value.ToString()
        Dim role = dgvUtilisateurs.Rows(e.RowIndex).
            Cells(2).Value.ToString()

        txtLoginUser.Text = login
        cmbRoleUser.SelectedItem = role
        txtMdpUser.Clear()
        txtMdpConfirm.Clear()

        ModeUser = "Modifier"
        IdUserSelectionne = id
        LoginUserSelectionne = login
        txtLoginUser.ReadOnly = True

        ' Ne peut pas supprimer le compte admin connecté
        btnSupprimerUser.Enabled =
            (login <> ModuleSession.LoginUtilisateur)
    End Sub

    ' Bouton Nouvel utilisateur 
    Private Sub btnNouvelUser_Click(sender As Object,
        e As EventArgs) Handles btnNouvelUser.Click
        ViderFicheUser()
        ModeUser = "Nouveau"
        txtLoginUser.Focus()
    End Sub

    ' Enregistrer utilisateur
    Private Sub btnSauverUser_Click(sender As Object,
        e As EventArgs) Handles btnSauverUser.Click

        ' Validation
        If String.IsNullOrWhiteSpace(txtLoginUser.Text) Then
            MsgBox("Le login est obligatoire.",
                   MsgBoxStyle.Exclamation, "Champ requis")
            txtLoginUser.Focus() : Exit Sub
        End If
        If cmbRoleUser.SelectedIndex = -1 Then
            MsgBox("Sélectionnez un rôle.",
                   MsgBoxStyle.Exclamation, "Champ requis")
            cmbRoleUser.Focus() : Exit Sub
        End If

        ' Vérification mot de passe
        If ModeUser = "Nouveau" OrElse
           Not String.IsNullOrEmpty(txtMdpUser.Text) Then

            If String.IsNullOrEmpty(txtMdpUser.Text) Then
                MsgBox("Le mot de passe est obligatoire " &
                       "pour un nouvel utilisateur.",
                       MsgBoxStyle.Exclamation,
                       "Mot de passe requis")
                txtMdpUser.Focus() : Exit Sub
            End If
            If txtMdpUser.Text.Length < 4 Then
                MsgBox("Le mot de passe doit contenir " &
                       "au moins 4 caractères.",
                       MsgBoxStyle.Exclamation,
                       "Mot de passe trop court")
                txtMdpUser.Focus() : Exit Sub
            End If
            If txtMdpUser.Text <> txtMdpConfirm.Text Then
                MsgBox("Les mots de passe ne correspondent pas.",
                       MsgBoxStyle.Exclamation,
                       "Confirmation incorrecte")
                txtMdpConfirm.Clear()
                txtMdpConfirm.Focus() : Exit Sub
            End If
        End If

        If ModeUser = "Nouveau" Then
            InsererUtilisateur()
        ElseIf ModeUser = "Modifier" Then
            ModifierUtilisateur()
        End If
    End Sub

    Private Sub InsererUtilisateur()
        ' Vérifier doublon login
        Dim existe = CInt(ModuleBDD.GetValeur(
            "SELECT COUNT(*) FROM Utilisateurs " &
            "WHERE login = ?",
            New OleDbParameter("@login",
                txtLoginUser.Text.Trim().ToLower())))

        If existe > 0 Then
            MsgBox("Ce login existe déjà.",
                   MsgBoxStyle.Exclamation, "Doublon")
            Exit Sub
        End If

        Dim sql = "INSERT INTO Utilisateurs " &
                  "(login, mot_de_passe, role) " &
                  "VALUES (?, ?, ?)"

        Dim params() As OleDbParameter = {
            New OleDbParameter("@login",
                txtLoginUser.Text.Trim().ToLower()),
            New OleDbParameter("@mdp",
                txtMdpUser.Text),
            New OleDbParameter("@role",
                cmbRoleUser.SelectedItem.ToString())
        }

        If ModuleBDD.ExecuterRequete(sql, params) Then
            MsgBox("Utilisateur créé avec succès.",
                   MsgBoxStyle.Information, "Succès")
            ChargerGrilleUsers()
            ViderFicheUser()
        End If
    End Sub

    Private Sub ModifierUtilisateur()
        If MsgBox("Confirmer la modification de """ &
                  LoginUserSelectionne & """ ?",
                  MsgBoxStyle.YesNo + MsgBoxStyle.Question,
                  "Confirmation") = MsgBoxResult.No Then
            Exit Sub
        End If

        Dim sql As String
        Dim params() As OleDbParameter

        If Not String.IsNullOrEmpty(txtMdpUser.Text) Then
            ' Modifier avec nouveau mot de passe
            sql = "UPDATE Utilisateurs SET " &
                  "role = ?, mot_de_passe = ? " &
                  "WHERE id_utilisateur = ?"
            params = {
                New OleDbParameter("@role",
                    cmbRoleUser.SelectedItem.ToString()),
                New OleDbParameter("@mdp",
                    txtMdpUser.Text),
                New OleDbParameter("@id",
                    IdUserSelectionne)
            }
        Else
            ' Modifier sans changer le mot de passe
            sql = "UPDATE Utilisateurs SET role = ? " &
                  "WHERE id_utilisateur = ?"
            params = {
                New OleDbParameter("@role",
                    cmbRoleUser.SelectedItem.ToString()),
                New OleDbParameter("@id",
                    IdUserSelectionne)
            }
        End If

        If ModuleBDD.ExecuterRequete(sql, params) Then
            MsgBox("Utilisateur modifié avec succès.",
                   MsgBoxStyle.Information, "Succès")
            ChargerGrilleUsers()
            ViderFicheUser()
        End If
    End Sub

    ' Supprimer utilisateur 
    Private Sub btnSupprimerUser_Click(sender As Object,
        e As EventArgs) Handles btnSupprimerUser.Click

        If IdUserSelectionne = -1 Then Exit Sub

        ' Ne pas supprimer son propre compte
        If LoginUserSelectionne = ModuleSession.LoginUtilisateur Then
            MsgBox("Vous ne pouvez pas supprimer " &
                   "votre propre compte.",
                   MsgBoxStyle.Exclamation,
                   "Suppression interdite")
            Exit Sub
        End If

        If MsgBox("Supprimer l'utilisateur """ &
                  LoginUserSelectionne & """ ?" & vbCrLf &
                  "Cette action est irréversible.",
                  MsgBoxStyle.YesNo + MsgBoxStyle.Critical,
                  "Confirmation") = MsgBoxResult.Yes Then

            If ModuleBDD.ExecuterRequete(
                "DELETE FROM Utilisateurs " &
                "WHERE id_utilisateur = ?",
                New OleDbParameter("@id",
                    IdUserSelectionne)) Then
                MsgBox("Utilisateur supprimé.",
                       MsgBoxStyle.Information, "Supprimé")
                ChargerGrilleUsers()
                ViderFicheUser()
            End If
        End If
    End Sub

    '  SECTION INFORMATIONS ÉTABLISSEMENT

    Private Sub ChargerParametresInstitut()
        Dim dt = ModuleBDD.GetDataTable(
            "SELECT * FROM Parametres")

        If dt.Rows.Count > 0 Then
            Dim row = dt.Rows(0)
            txtNomInstitut.Text =
                row("nom_institut").ToString()
            txtAdresseInstitut.Text =
                row("adresse").ToString()
            txtAnneeScolaireParam.Text =
                row("annee_scolaire").ToString()
        Else
            ' Aucun paramètre → insérer une ligne vide
            ModuleBDD.ExecuterRequete(
                "INSERT INTO Parametres " &
                "(nom_institut, adresse, annee_scolaire) " &
                "VALUES ('', '', '')")
        End If
    End Sub

    Private Sub btnSauverInstitut_Click(sender As Object,
        e As EventArgs) Handles btnSauverInstitut.Click

        If String.IsNullOrWhiteSpace(txtNomInstitut.Text) Then
            MsgBox("Le nom de l'institut est obligatoire.",
                   MsgBoxStyle.Exclamation, "Champ requis")
            txtNomInstitut.Focus() : Exit Sub
        End If

        ' Vérifier si une ligne existe déjà
        Dim nb = CInt(ModuleBDD.GetValeur(
            "SELECT COUNT(*) FROM Parametres"))

        Dim ok As Boolean
        If nb > 0 Then
            ' UPDATE
            Dim sql = "UPDATE Parametres SET " &
                      "nom_institut = ?, " &
                      "adresse = ?, " &
                      "annee_scolaire = ?"
            Dim params() As OleDbParameter = {
                New OleDbParameter("@nom",
                    txtNomInstitut.Text.Trim()),
                New OleDbParameter("@adr",
                    txtAdresseInstitut.Text.Trim()),
                New OleDbParameter("@annee",
                    txtAnneeScolaireParam.Text.Trim())
            }
            ok = ModuleBDD.ExecuterRequete(sql, params)
        Else
            ' INSERT
            Dim sql = "INSERT INTO Parametres " &
                      "(nom_institut, adresse, annee_scolaire) " &
                      "VALUES (?, ?, ?)"
            Dim params() As OleDbParameter = {
                New OleDbParameter("@nom",
                    txtNomInstitut.Text.Trim()),
                New OleDbParameter("@adr",
                    txtAdresseInstitut.Text.Trim()),
                New OleDbParameter("@annee",
                    txtAnneeScolaireParam.Text.Trim())
            }
            ok = ModuleBDD.ExecuterRequete(sql, params)
        End If

        If ok Then
            MsgBox("Paramètres sauvegardés avec succès.",
                   MsgBoxStyle.Information, "Succès")
        End If
    End Sub

End Class