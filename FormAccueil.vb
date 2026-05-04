Public Class FormAccueil

    Private Sub FormAccueil_Load(sender As Object, e As EventArgs) _
        Handles MyBase.Load

        ' Style du formulaire
        Me.FormBorderStyle = FormBorderStyle.FixedSingle  ' ← bordure avec X
        Me.ControlBox = True                               ' ← bouton X activé
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Size = New Size(949, 558)
        Me.BackColor = Color.FromArgb(12, 68, 124)
        Me.Text = "GestNotes — Chargement"

        ' Logo / Initiales (sur UNE seule ligne) 
        Dim lblLogo As New Label()
        lblLogo.Text = "GN"
        lblLogo.Font = New Font("Segoe UI", 32, FontStyle.Bold)
        lblLogo.ForeColor = Color.White
        lblLogo.BackColor = Color.FromArgb(24, 95, 165)
        lblLogo.Size = New Size(100, 100)
        lblLogo.TextAlign = ContentAlignment.MiddleCenter
        lblLogo.Location = New Point((Me.ClientSize.Width - 100) \ 2, 110)

        AddHandler lblLogo.Paint, Sub(s, pe)
                                      Dim path As New Drawing2D.GraphicsPath()
                                      path.AddArc(0, 0, 24, 24, 180, 90)
                                      path.AddArc(lblLogo.Width - 24, 0, 24, 24, 270, 90)
                                      path.AddArc(lblLogo.Width - 24, lblLogo.Height - 24, 24, 24, 0, 90)
                                      path.AddArc(0, lblLogo.Height - 24, 24, 24, 90, 90)
                                      path.CloseAllFigures()
                                      pe.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
                                      pe.Graphics.FillPath(
                                          New SolidBrush(Color.FromArgb(24, 95, 165)), path)
                                      Dim sf As New StringFormat()
                                      sf.Alignment = StringAlignment.Center
                                      sf.LineAlignment = StringAlignment.Center
                                      pe.Graphics.DrawString("GN",
                                          New Font("Segoe UI", 32, FontStyle.Bold),
                                          Brushes.White,
                                          New RectangleF(0, 0, lblLogo.Width, lblLogo.Height), sf)
                                  End Sub

        ' Empêcher fermeture au clic sur le logo
        AddHandler lblLogo.Click, Sub(s, ev) ' ne rien faire
                                  End Sub

        Me.Controls.Add(lblLogo)

        ' Nom application 
        Dim lblNom As New Label()
        lblNom.Text = "Gestion des Notes"
        lblNom.Font = New Font("Segoe UI", 22, FontStyle.Bold)
        lblNom.ForeColor = Color.White
        lblNom.AutoSize = True
        lblNom.BackColor = Color.Transparent
        lblNom.Location = New Point((Me.ClientSize.Width - 280) \ 2, 225)
        Me.Controls.Add(lblNom)

        ' Sous-titre 
        Dim lblSub As New Label()
        lblSub.Text = "Système de gestion des notes étudiants"
        lblSub.Font = New Font("Segoe UI", 11)
        lblSub.ForeColor = Color.FromArgb(180, 210, 240)
        lblSub.AutoSize = True
        lblSub.BackColor = Color.Transparent
        lblSub.Location = New Point((Me.ClientSize.Width - 240) \ 2, 265)
        Me.Controls.Add(lblSub)

        ' Barre fond 
        Dim pnlBarreFond As New Panel()
        pnlBarreFond.Size = New Size(700, 8)
        pnlBarreFond.BackColor = Color.FromArgb(40, 255, 255, 255)
        pnlBarreFond.Location = New Point(
            (Me.ClientSize.Width - 700) \ 2, 420)
        pnlBarreFond.Cursor = Cursors.Default
        Me.Controls.Add(pnlBarreFond)

        ' Barre remplissage
        Dim pnlBarre As New Panel()
        pnlBarre.Size = New Size(0, 8)
        pnlBarre.BackColor = Color.FromArgb(100, 180, 255)
        pnlBarre.Location = New Point(
            (Me.ClientSize.Width - 700) \ 2, 420)
        pnlBarre.Cursor = Cursors.Default
        Me.Controls.Add(pnlBarre)

        ' Label statut 
        Dim lblStatut As New Label()
        lblStatut.Text = "Initialisation..."
        lblStatut.Font = New Font("Segoe UI", 9)
        lblStatut.ForeColor = Color.FromArgb(160, 200, 240)
        lblStatut.AutoSize = True
        lblStatut.BackColor = Color.Transparent
        lblStatut.Location = New Point(
            (Me.ClientSize.Width - 700) \ 2, 436)
        Me.Controls.Add(lblStatut)

        ' Version 
        Dim lblVer As New Label()
        lblVer.Text = "v1.0.0"
        lblVer.Font = New Font("Segoe UI", 9)
        lblVer.ForeColor = Color.FromArgb(120, 180, 220)
        lblVer.AutoSize = True
        lblVer.BackColor = Color.Transparent
        lblVer.Location = New Point(Me.ClientSize.Width - 70, 500)
        Me.Controls.Add(lblVer)

        '  Timer 5 secondes 
        Dim etapes() As String = {
            "Initialisation...",
            "Chargement de la base de données...",
            "Vérification des paramètres...",
            "Chargement des modules...",
            "Démarrage en cours..."
        }

        Dim tick As Integer = 0
        Dim totalTicks As Integer = 250  ' 250 × 20ms = 5s

        Dim tmr As New Timer()
        tmr.Interval = 20
        AddHandler tmr.Tick, Sub(s, ev)
                                 tick += 1
                                 pnlBarre.Width = Math.Min(
                                     CInt(tick * 700 / totalTicks), 700)
                                 Dim idx = Math.Min(
                                     CInt(tick / totalTicks * (etapes.Length - 1)),
                                     etapes.Length - 1)
                                 lblStatut.Text = etapes(idx)

                                 If tick >= totalTicks Then
                                     tmr.Stop()
                                     Dim fMain As New FormConnexion()
                                     fMain.Show()
                                     Me.Hide() ' ← On cache au lieu de Me.Close()
                                 End If
                             End Sub
        tmr.Start()
    End Sub
End Class