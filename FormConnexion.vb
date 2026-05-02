Imports System.Data.OleDb

Public Class FormConnexion

    Private Sub FormConnexion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbProfil.Items.Clear()
        cmbProfil.Items.Add("-- Sélectionner un profil --")
        cmbProfil.Items.Add("Administrateur")
        cmbProfil.Items.Add("Secrétaire")
        cmbProfil.SelectedIndex = 0
        txtLogin.Focus()
    End Sub

    Private Sub btnConnecter_Click(sender As Object, e As EventArgs) Handles btnConnecter.Click

        ' ── Vérifications des champs ──────────────────────────
        If cmbProfil.SelectedIndex = 0 Then
            MsgBox("Veuillez sélectionner un profil.",
                   MsgBoxStyle.Exclamation, "Champ requis")
            cmbProfil.Focus() : Exit Sub
        End If

        If String.IsNullOrWhiteSpace(txtLogin.Text) Then
            MsgBox("Veuillez saisir votre identifiant.",
                   MsgBoxStyle.Exclamation, "Champ requis")
            txtLogin.Focus() : Exit Sub
        End If

        If String.IsNullOrWhiteSpace(txtMdp.Text) Then
            MsgBox("Veuillez saisir votre mot de passe.",
                   MsgBoxStyle.Exclamation, "Champ requis")
            txtMdp.Focus() : Exit Sub
        End If

        ' ── Vérification en base de données ──────────────────
        Try
            Dim sql = "SELECT role FROM Utilisateurs " &
                      "WHERE login = ? AND mot_de_passe = ?"

            Dim params() As OleDbParameter = {
                New OleDbParameter("@login", txtLogin.Text.Trim().ToLower()),
                New OleDbParameter("@mdp", txtMdp.Text)
            }

            Dim dt = ModuleBDD.GetDataTable(sql, params)

            If dt.Rows.Count > 0 Then
                Dim roleEnBDD = dt.Rows(0)("role").ToString()
                Dim roleChoisi = cmbProfil.SelectedItem.ToString()

                ' Vérifier que le rôle correspond au profil choisi
                If roleEnBDD <> roleChoisi Then
                    MsgBox("Le profil sélectionné ne correspond pas à ce compte." &
                           vbCrLf & "Vérifiez votre profil et réessayez.",
                           MsgBoxStyle.Exclamation, "Profil incorrect")
                    cmbProfil.Focus()
                    Exit Sub
                End If

                ' ── Connexion réussie ─────────────────────────
                ModuleSession.Profil = roleEnBDD
                ModuleSession.LoginUtilisateur = txtLogin.Text.Trim()

                Dim fPrincipal As New FormPrincipal()
                fPrincipal.Show()
                Me.Hide()

            Else
                ' Identifiants incorrects
                MsgBox("Identifiant ou mot de passe incorrect." & vbCrLf &
                       "Vérifiez vos informations et réessayez.",
                       MsgBoxStyle.Critical, "Échec de connexion")
                txtMdp.Clear()
                txtMdp.Focus()
            End If

        Catch ex As Exception
            MsgBox("Erreur de connexion à la base de données :" &
                   vbCrLf & ex.Message,
                   MsgBoxStyle.Critical, "Erreur BDD")
        End Try

    End Sub

    ' ── Touche Entrée sur le mot de passe = Se connecter ─────
    Private Sub txtMdp_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMdp.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnConnecter_Click(sender, e)
        End If
    End Sub

    ' ── Bouton Quitter ────────────────────────────────────────
    Private Sub btnQuitter_Click(sender As Object, e As EventArgs) Handles btnQuitter.Click
        Dim rep = MsgBox("Voulez-vous vraiment quitter l'application ?",
                         MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Quitter")
        If rep = MsgBoxResult.Yes Then
            Application.Exit()
        End If
    End Sub

    ' ── Fermeture de la fenêtre = quitter proprement ─────────
    Private Sub FormConnexion_FormClosing(sender As Object, e As FormClosingEventArgs) _
        Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            Application.Exit()
        End If
    End Sub

End Class