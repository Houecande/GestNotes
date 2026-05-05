Imports System.Data.OleDb

Public Class FormPrincipal

    Private ReadOnly ColorMenuActif As Color =
        Color.FromArgb(24, 95, 165)
    Private ReadOnly ColorMenuInactif As Color =
        Color.FromArgb(12, 68, 124)
    Private ReadOnly ColorTexteActif As Color =
        Color.FromArgb(230, 241, 251)
    Private ReadOnly ColorTexteInactif As Color =
        Color.FromArgb(181, 212, 244)
    Private BoutonActif As Button = Nothing

    ' Chargement 
    Private Sub FormPrincipal_Load(sender As Object,
        e As EventArgs) Handles MyBase.Load

        lblUtilisateur.Text = ModuleSession.LoginUtilisateur
        lblRole.Text = If(ModuleSession.EstAdmin,
                          "Accès complet", "Secrétaire")
        lblInfoConnexion.Text = "Connecté : " &
                                ModuleSession.LoginUtilisateur

        btnMenuParametres.Visible = ModuleSession.EstAdmin
        lblSectAdmin.Visible = ModuleSession.EstAdmin

        ActiverBouton(btnMenuDashboard)
        AfficherDashboard()
    End Sub

    ' Activer un bouton du menu 
    Private Sub ActiverBouton(btn As Button)
        For Each ctrl As Control In pnlSidebar.Controls
            If TypeOf ctrl Is Button Then
                Dim b = CType(ctrl, Button)
                b.BackColor = ColorMenuInactif
                b.ForeColor = ColorTexteInactif
            End If
        Next
        btn.BackColor = ColorMenuActif
        btn.ForeColor = ColorTexteActif
        BoutonActif = btn
    End Sub

    'Afficher le tableau de bord 
    Public Sub AfficherDashboard()
        lblPageTitle.Text = "Tableau de bord"
        pnlContenu.Controls.Clear()
        ConstruireDashboard()
    End Sub

    '  Retour Dashboard 
    Public Sub RetourDashboard()
        ActiverBouton(btnMenuDashboard)
        lblPageTitle.Text = "Tableau de bord"
        pnlContenu.Controls.Clear()
        ConstruireDashboard()
    End Sub

    ' Construire le dashboard dynamiquement
    Private Sub ConstruireDashboard()
        ' Panel principal
        Dim pnlDash As New Panel()
        pnlDash.Dock = DockStyle.Fill
        pnlDash.BackColor = Color.FromArgb(240, 244, 248)
        pnlDash.Padding = New Padding(16)

        ' Récupérer les stats BDD
        Dim nbEtudiants As String = "0"
        Dim nbMatieres As String = "0"
        Dim nbNotes As String = "0"
        Dim nbClasses As String = "0"

        Try
            Dim v1 = ModuleBDD.GetValeur(
                "SELECT COUNT(*) FROM Etudiant")
            If v1 IsNot Nothing Then
                nbEtudiants = v1.ToString()
            End If

            Dim v2 = ModuleBDD.GetValeur(
                "SELECT COUNT(*) FROM Matiere")
            If v2 IsNot Nothing Then
                nbMatieres = v2.ToString()
            End If

            Dim v3 = ModuleBDD.GetValeur(
                "SELECT COUNT(*) FROM [Note]")
            If v3 IsNot Nothing Then
                nbNotes = v3.ToString()
            End If

            Dim v4 = ModuleBDD.GetValeur(
                "SELECT COUNT(*) FROM Classe")
            If v4 IsNot Nothing Then
                nbClasses = v4.ToString()
            End If
        Catch : End Try

        ' FlowLayoutPanel des cartes 
        Dim flp As New FlowLayoutPanel()
        flp.Height = 90
        flp.Dock = DockStyle.Top
        flp.BackColor = Color.Transparent
        flp.FlowDirection = FlowDirection.LeftToRight
        flp.WrapContents = False
        flp.Padding = New Padding(0)

        flp.Controls.Add(CreerCarte(
            nbEtudiants, "Étudiants",
            Color.FromArgb(24, 95, 165)))
        flp.Controls.Add(CreerCarte(
            nbMatieres, "Matières",
            Color.FromArgb(15, 110, 86)))
        flp.Controls.Add(CreerCarte(
            nbNotes, "Notes saisies",
            Color.FromArgb(83, 74, 183)))
        flp.Controls.Add(CreerCarte(
            nbClasses, "Classes",
            Color.FromArgb(133, 79, 11)))

        ' Label titre section 
        Dim lblTitre As New Label()
        lblTitre.Text = "Aperçu général"
        lblTitre.Font = New Font(
            "Segoe UI", 11, FontStyle.Bold)
        lblTitre.ForeColor = Color.FromArgb(12, 68, 124)
        lblTitre.Height = 40
        lblTitre.Dock = DockStyle.Top
        lblTitre.TextAlign = ContentAlignment.BottomLeft
        lblTitre.Padding = New Padding(0, 10, 0, 0)
        lblTitre.BackColor = Color.Transparent

        ' ── Panel info / statistiques détaillées ─────────────────
        Dim pnlInfo As New Panel()
        pnlInfo.Dock = DockStyle.Fill
        pnlInfo.BackColor = Color.White
        pnlInfo.Padding = New Padding(20)

        ' Récupérer des stats supplémentaires
        Dim nbAdmis As String = "—"
        Dim nbAjournes As String = "—"
        Dim moyGenerale As String = "—"

        Try
            ' Nombre d'étudiants avec moyenne >= 10
            Dim dtMoy = ModuleBDD.GetDataTable(
                "SELECT e.num_matricule, " &
                "SUM(n.moyenne_matiere * m.coefficient) / " &
                "SUM(m.coefficient) AS moy_gen " &
                "FROM (Etudiant e INNER JOIN [Note] n " &
                "ON e.num_matricule = n.num_matricule) " &
                "INNER JOIN Matiere m " &
                "ON n.code_matiere = m.code_matiere " &
                "GROUP BY e.num_matricule")

            Dim admis As Integer = 0
            Dim ajournes As Integer = 0
            Dim totalMoy As Double = 0

            For Each row As DataRow In dtMoy.Rows
                Dim moy As Double = 0
                Double.TryParse(
            row("moy_gen").ToString().Replace(",", "."),
            System.Globalization.NumberStyles.Any,
            System.Globalization.CultureInfo.InvariantCulture,
            moy)
                If moy >= 10 Then admis += 1 Else ajournes += 1
                totalMoy += moy
            Next

            If dtMoy.Rows.Count > 0 Then
                nbAdmis = admis.ToString()
                nbAjournes = ajournes.ToString()
                moyGenerale = Math.Round(
            totalMoy / dtMoy.Rows.Count, 2).
            ToString("F2")
            End If
        Catch : End Try

        ' Grille de stats détaillées
        Dim flpDetail As New FlowLayoutPanel()
        flpDetail.Dock = DockStyle.Top
        flpDetail.Height = 100
        flpDetail.FlowDirection = FlowDirection.LeftToRight
        flpDetail.WrapContents = False
        flpDetail.BackColor = Color.Transparent
        flpDetail.Padding = New Padding(0, 0, 0, 10)

        flpDetail.Controls.Add(CreerCarteDetail(
        "✓ Admis", nbAdmis,
        Color.FromArgb(5, 150, 105),
        Color.FromArgb(209, 250, 229)))
        flpDetail.Controls.Add(CreerCarteDetail(
        "✗ Ajournés", nbAjournes,
        Color.FromArgb(220, 38, 38),
        Color.FromArgb(254, 226, 226)))
        flpDetail.Controls.Add(CreerCarteDetail(
        "Moy. générale", moyGenerale & "/20",
        Color.FromArgb(24, 95, 165),
        Color.FromArgb(230, 241, 251)))

        ' Message bienvenue
        Dim lblBienvenue As New Label()
        lblBienvenue.Text = "Connecté en tant que : " &
        ModuleSession.LoginUtilisateur &
        "  |  Rôle : " & ModuleSession.Profil &
        "  |  " & DateTime.Now.ToString(
        "dddd dd MMMM yyyy",
    New System.Globalization.CultureInfo("fr-FR"))
        lblBienvenue.Font = New Font("Segoe UI", 9)
        lblBienvenue.ForeColor = Color.FromArgb(136, 135, 128)
        lblBienvenue.Dock = DockStyle.Bottom
        lblBienvenue.Height = 28
        lblBienvenue.TextAlign = ContentAlignment.MiddleLeft

        pnlInfo.Controls.Add(flpDetail)
        pnlInfo.Controls.Add(lblBienvenue)

        ' Ordre d'ajout (important pour Dock)
        ' Fill en premier dans la liste mais ajouté en dernier
        pnlDash.Controls.Add(pnlInfo)
        pnlDash.Controls.Add(lblTitre)
        pnlDash.Controls.Add(flp)

        pnlContenu.Controls.Add(pnlDash)
    End Sub

    ' Créer une carte statistique 
    Private Function CreerCarte(valeur As String,
        libelle As String,
        couleur As Color) As Panel

        Dim carte As New Panel()
        carte.Size = New Size(165, 78)
        carte.BackColor = Color.White
        carte.Margin = New Padding(0, 0, 10, 0)

        ' Bordure colorée en haut
        Dim bordure As New Panel()
        bordure.Height = 4
        bordure.Dock = DockStyle.Top
        bordure.BackColor = couleur

        ' Valeur
        Dim lblVal As New Label()
        lblVal.Text = valeur
        lblVal.Font = New Font(
            "Segoe UI", 18, FontStyle.Bold)
        lblVal.ForeColor = couleur
        lblVal.AutoSize = False
        lblVal.Size = New Size(141, 36)
        lblVal.Location = New Point(12, 10)
        lblVal.TextAlign =
            ContentAlignment.MiddleLeft

        ' Libellé
        Dim lblLib As New Label()
        lblLib.Text = libelle
        lblLib.Font = New Font("Segoe UI", 8)
        lblLib.ForeColor =
            Color.FromArgb(136, 135, 128)
        lblLib.AutoSize = False
        lblLib.Size = New Size(141, 18)
        lblLib.Location = New Point(12, 50)
        lblLib.TextAlign =
            ContentAlignment.MiddleLeft

        carte.Controls.Add(bordure)
        carte.Controls.Add(lblVal)
        carte.Controls.Add(lblLib)

        Return carte
    End Function

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
    Private Sub btnMenuDashboard_Click(
        sender As Object, e As EventArgs) _
        Handles btnMenuDashboard.Click
        ActiverBouton(btnMenuDashboard)
        AfficherDashboard()
    End Sub

    Private Sub btnMenuEtudiants_Click(
        sender As Object, e As EventArgs) _
        Handles btnMenuEtudiants.Click
        ActiverBouton(btnMenuEtudiants)
        lblPageTitle.Text = "Gestion des étudiants"
        OuvrirDansContenu(New FormEtudiants())
    End Sub

    Private Sub btnMenuClasses_Click(
        sender As Object, e As EventArgs) _
        Handles btnMenuClasses.Click
        ActiverBouton(btnMenuClasses)
        lblPageTitle.Text = "Classes & Matières"
        OuvrirDansContenu(New FormClasses())
    End Sub

    Private Sub btnMenuNotes_Click(
        sender As Object, e As EventArgs) _
        Handles btnMenuNotes.Click
        ActiverBouton(btnMenuNotes)
        lblPageTitle.Text = "Saisie des notes"
        OuvrirDansContenu(New FormNotes())
    End Sub

    Private Sub btnMenuImpressions_Click(
        sender As Object, e As EventArgs) _
        Handles btnMenuImpressions.Click
        ActiverBouton(btnMenuImpressions)
        lblPageTitle.Text = "Impressions"
        OuvrirDansContenu(New FormImpressions())
    End Sub

    Private Sub btnMenuParametres_Click(
        sender As Object, e As EventArgs) _
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
    Private Sub btnDeconnexion_Click(
        sender As Object, e As EventArgs) _
        Handles btnDeconnexion.Click
        Dim rep = MsgBox(
            "Voulez-vous vraiment vous déconnecter ?",
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
    Private Function CreerCarteDetail(
    libelle As String,
    valeur As String,
    couleurTexte As Color,
    couleurFond As Color) As Panel

        Dim carte As New Panel()
        carte.Size = New Size(165, 80)
        carte.BackColor = couleurFond
        carte.Margin = New Padding(0, 0, 10, 0)
        carte.Padding = New Padding(12)

        Dim lblLib As New Label()
        lblLib.Text = libelle
        lblLib.Font = New Font("Segoe UI", 8)
        lblLib.ForeColor = couleurTexte
        lblLib.AutoSize = False
        lblLib.Size = New Size(141, 18)
        lblLib.Location = New Point(12, 10)
        lblLib.TextAlign = ContentAlignment.MiddleLeft

        Dim lblVal As New Label()
        lblVal.Text = valeur
        lblVal.Font = New Font("Segoe UI", 18, FontStyle.Bold)
        lblVal.ForeColor = couleurTexte
        lblVal.AutoSize = False
        lblVal.Size = New Size(141, 36)
        lblVal.Location = New Point(12, 32)
        lblVal.TextAlign = ContentAlignment.MiddleLeft

        carte.Controls.Add(lblLib)
        carte.Controls.Add(lblVal)
        Return carte
    End Function

End Class