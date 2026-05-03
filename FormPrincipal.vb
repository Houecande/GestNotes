Public Class FormPrincipal

    Private ReadOnly ColorMenuActif As Color = Color.FromArgb(24, 95, 165)
    Private ReadOnly ColorMenuInactif As Color = Color.FromArgb(12, 68, 124)
    Private ReadOnly ColorTexteActif As Color = Color.FromArgb(230, 241, 251)
    Private ReadOnly ColorTexteInactif As Color = Color.FromArgb(181, 212, 244)
    Private BoutonActif As Button = Nothing

    ' Chargement 
    Private Sub FormPrincipal_Load(sender As Object, e As EventArgs) _
        Handles MyBase.Load

        ' Infos utilisateur connecté
        lblUtilisateur.Text = ModuleSession.LoginUtilisateur
        lblRole.Text = If(ModuleSession.EstAdmin,
                          "Accès complet", "Secrétaire")

        ' Masquer Paramètres si pas admin
        btnMenuParametres.Visible = ModuleSession.EstAdmin
        lblSectAdmin.Visible = ModuleSession.EstAdmin

        ' Dashboard par défaut
        ActiverBouton(btnMenuDashboard)
        AfficherDashboard()
    End Sub

    ' Activer un bouton du menu 
    Private Sub ActiverBouton(btn As Button)
        ' Remettre tous les boutons en inactif
        For Each ctrl As Control In pnlSidebar.Controls
            If TypeOf ctrl Is Button Then
                Dim b = CType(ctrl, Button)
                b.BackColor = ColorMenuInactif
                b.ForeColor = ColorTexteInactif
            End If
        Next
        ' Activer le bouton choisi
        btn.BackColor = ColorMenuActif
        btn.ForeColor = ColorTexteActif
        BoutonActif = btn
    End Sub

    ' Afficher le tableau de bord 
    Private Sub AfficherDashboard()
        lblPageTitle.Text = "Tableau de bord"
        pnlContenu.Controls.Clear()

        ' Statistiques depuis la BDD
        Try
            Dim nbEtudiants = ModuleBDD.GetValeur(
                "SELECT COUNT(*) FROM Etudiant")
            Dim nbMatieres = ModuleBDD.GetValeur(
                "SELECT COUNT(*) FROM Matiere")
            Dim nbNotes = ModuleBDD.GetValeur(
                "SELECT COUNT(*) FROM Note")

            lblValEtudiants.Text = If(nbEtudiants IsNot Nothing,
                                      nbEtudiants.ToString(), "0")
            lblValMatieres.Text = If(nbMatieres IsNot Nothing,
                                     nbMatieres.ToString(), "0")
            lblValNotes.Text = If(nbNotes IsNot Nothing,
                                  nbNotes.ToString(), "0")
            lblValBulletins.Text = "0"
        Catch
            lblValEtudiants.Text = "0"
            lblValMatieres.Text = "0"
            lblValNotes.Text = "0"
            lblValBulletins.Text = "0"
        End Try
    End Sub

    ' Méthode publique appelée par les sous-formulaires 
    Public Sub RetourDashboard()
        ActiverBouton(btnMenuDashboard)
        lblPageTitle.Text = "Tableau de bord"
        pnlContenu.Controls.Clear()
        AfficherDashboard()
    End Sub

    ' Ouvrir un formulaire dans pnlContenu 
    Private Sub OuvrirDansContenu(frm As Form)
        pnlContenu.Controls.Clear()
        frm.TopLevel = False
        frm.FormBorderStyle = FormBorderStyle.None
        frm.Dock = DockStyle.Fill
        pnlContenu.Controls.Add(frm)
        frm.Show()
    End Sub

    ' Boutons de navigation 
    Private Sub btnMenuDashboard_Click(sender As Object, e As EventArgs) _
        Handles btnMenuDashboard.Click
        ActiverBouton(btnMenuDashboard)
        AfficherDashboard()
    End Sub

    Private Sub btnMenuEtudiants_Click(sender As Object, e As EventArgs) _
        Handles btnMenuEtudiants.Click
        ActiverBouton(btnMenuEtudiants)
        lblPageTitle.Text = "Gestion des étudiants"
        OuvrirDansContenu(New FormEtudiants())
    End Sub

    Private Sub btnMenuClasses_Click(sender As Object, e As EventArgs) _
        Handles btnMenuClasses.Click
        ActiverBouton(btnMenuClasses)
        lblPageTitle.Text = "Classes & Matières"
        OuvrirDansContenu(New FormClasses())
    End Sub

    Private Sub btnMenuNotes_Click(sender As Object, e As EventArgs) _
        Handles btnMenuNotes.Click
        ActiverBouton(btnMenuNotes)
        lblPageTitle.Text = "Saisie des notes"
        OuvrirDansContenu(New FormNotes())
    End Sub

    Private Sub btnMenuImpressions_Click(sender As Object, e As EventArgs) _
        Handles btnMenuImpressions.Click
        ActiverBouton(btnMenuImpressions)
        lblPageTitle.Text = "Impressions"
        OuvrirDansContenu(New FormImpressions())
    End Sub

    Private Sub btnMenuParametres_Click(sender As Object, e As EventArgs) _
        Handles btnMenuParametres.Click
        If Not ModuleSession.EstAdmin Then
            MsgBox("Accès réservé à l'administrateur.",
                   MsgBoxStyle.Exclamation, "Accès refusé")
            Exit Sub
        End If
        ActiverBouton(btnMenuParametres)
        lblPageTitle.Text = "Paramètres"
        OuvrirDansContenu(New FormParametres())
    End Sub

    ' Déconnexion 
    Private Sub btnDeconnexion_Click(sender As Object, e As EventArgs) _
        Handles btnDeconnexion.Click
        Dim rep = MsgBox("Voulez-vous vraiment vous déconnecter ?",
                         MsgBoxStyle.YesNo + MsgBoxStyle.Question,
                         "Déconnexion")
        If rep = MsgBoxResult.Yes Then
            ModuleSession.Profil = ""
            ModuleSession.LoginUtilisateur = ""
            Dim fLogin As New FormConnexion()
            fLogin.Show()
            Me.Close()
        End If
    End Sub

End Class