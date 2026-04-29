<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormConnexion
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblAppNom = New System.Windows.Forms.Label()
        Me.lblSousTitre = New System.Windows.Forms.Label()
        Me.pnlCarte = New System.Windows.Forms.Panel()
        Me.btnQuitter = New System.Windows.Forms.Button()
        Me.btnConnecter = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.lblMdp = New System.Windows.Forms.Label()
        Me.txtLogin = New System.Windows.Forms.TextBox()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.lblProfil = New System.Windows.Forms.Label()
        Me.cmbProfil = New System.Windows.Forms.ComboBox()
        Me.pnlLogo = New System.Windows.Forms.Panel()
        Me.lblLogoText = New System.Windows.Forms.Label()
        Me.pnlCarte.SuspendLayout()
        Me.pnlLogo.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblAppNom
        '
        Me.lblAppNom.AutoSize = True
        Me.lblAppNom.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAppNom.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.lblAppNom.Location = New System.Drawing.Point(118, 89)
        Me.lblAppNom.Name = "lblAppNom"
        Me.lblAppNom.Size = New System.Drawing.Size(164, 25)
        Me.lblAppNom.TabIndex = 0
        Me.lblAppNom.Text = "Gestion de Notes"
        Me.lblAppNom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSousTitre
        '
        Me.lblSousTitre.AutoSize = True
        Me.lblSousTitre.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSousTitre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.lblSousTitre.Location = New System.Drawing.Point(97, 124)
        Me.lblSousTitre.Name = "lblSousTitre"
        Me.lblSousTitre.Size = New System.Drawing.Size(211, 13)
        Me.lblSousTitre.TabIndex = 1
        Me.lblSousTitre.Text = "Système de gestion des notes étudiants"
        Me.lblSousTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlCarte
        '
        Me.pnlCarte.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.pnlCarte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlCarte.Controls.Add(Me.btnQuitter)
        Me.pnlCarte.Controls.Add(Me.btnConnecter)
        Me.pnlCarte.Controls.Add(Me.TextBox2)
        Me.pnlCarte.Controls.Add(Me.lblMdp)
        Me.pnlCarte.Controls.Add(Me.txtLogin)
        Me.pnlCarte.Controls.Add(Me.lblLogin)
        Me.pnlCarte.Controls.Add(Me.lblProfil)
        Me.pnlCarte.Controls.Add(Me.cmbProfil)
        Me.pnlCarte.Location = New System.Drawing.Point(37, 150)
        Me.pnlCarte.Name = "pnlCarte"
        Me.pnlCarte.Size = New System.Drawing.Size(340, 265)
        Me.pnlCarte.TabIndex = 2
        '
        'btnQuitter
        '
        Me.btnQuitter.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnQuitter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnQuitter.FlatAppearance.BorderSize = 0
        Me.btnQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuitter.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuitter.ForeColor = System.Drawing.Color.White
        Me.btnQuitter.Location = New System.Drawing.Point(16, 222)
        Me.btnQuitter.Name = "btnQuitter"
        Me.btnQuitter.Size = New System.Drawing.Size(306, 28)
        Me.btnQuitter.TabIndex = 7
        Me.btnQuitter.Text = "Quitter"
        Me.btnQuitter.UseVisualStyleBackColor = False
        '
        'btnConnecter
        '
        Me.btnConnecter.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.btnConnecter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConnecter.FlatAppearance.BorderSize = 0
        Me.btnConnecter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConnecter.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConnecter.ForeColor = System.Drawing.Color.White
        Me.btnConnecter.Location = New System.Drawing.Point(16, 188)
        Me.btnConnecter.Name = "btnConnecter"
        Me.btnConnecter.Size = New System.Drawing.Size(306, 28)
        Me.btnConnecter.TabIndex = 6
        Me.btnConnecter.Text = "Se Connecter"
        Me.btnConnecter.UseVisualStyleBackColor = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(16, 146)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(306, 23)
        Me.TextBox2.TabIndex = 5
        Me.TextBox2.UseSystemPasswordChar = True
        '
        'lblMdp
        '
        Me.lblMdp.AutoSize = True
        Me.lblMdp.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMdp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.lblMdp.Location = New System.Drawing.Point(16, 128)
        Me.lblMdp.Name = "lblMdp"
        Me.lblMdp.Size = New System.Drawing.Size(76, 13)
        Me.lblMdp.TabIndex = 4
        Me.lblMdp.Text = "Mot de passe"
        '
        'txtLogin
        '
        Me.txtLogin.Location = New System.Drawing.Point(16, 90)
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.Size = New System.Drawing.Size(306, 23)
        Me.txtLogin.TabIndex = 3
        '
        'lblLogin
        '
        Me.lblLogin.AutoSize = True
        Me.lblLogin.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.lblLogin.Location = New System.Drawing.Point(16, 72)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(61, 13)
        Me.lblLogin.TabIndex = 2
        Me.lblLogin.Text = "Identifiant"
        '
        'lblProfil
        '
        Me.lblProfil.AutoSize = True
        Me.lblProfil.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProfil.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.lblProfil.Location = New System.Drawing.Point(16, 16)
        Me.lblProfil.Name = "lblProfil"
        Me.lblProfil.Size = New System.Drawing.Size(89, 13)
        Me.lblProfil.TabIndex = 1
        Me.lblProfil.Text = "Profil utilisateur"
        '
        'cmbProfil
        '
        Me.cmbProfil.FormattingEnabled = True
        Me.cmbProfil.Items.AddRange(New Object() {"  Administrateur", "  Secrétaire"})
        Me.cmbProfil.Location = New System.Drawing.Point(16, 34)
        Me.cmbProfil.Name = "cmbProfil"
        Me.cmbProfil.Size = New System.Drawing.Size(306, 23)
        Me.cmbProfil.TabIndex = 0
        '
        'pnlLogo
        '
        Me.pnlLogo.AutoSize = True
        Me.pnlLogo.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.pnlLogo.Controls.Add(Me.lblLogoText)
        Me.pnlLogo.Location = New System.Drawing.Point(173, 30)
        Me.pnlLogo.Name = "pnlLogo"
        Me.pnlLogo.Size = New System.Drawing.Size(56, 56)
        Me.pnlLogo.TabIndex = 3
        '
        'lblLogoText
        '
        Me.lblLogoText.AutoSize = True
        Me.lblLogoText.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogoText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.lblLogoText.Location = New System.Drawing.Point(8, 15)
        Me.lblLogoText.Name = "lblLogoText"
        Me.lblLogoText.Size = New System.Drawing.Size(41, 25)
        Me.lblLogoText.TabIndex = 4
        Me.lblLogoText.Text = "GN"
        '
        'FormConnexion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(404, 441)
        Me.Controls.Add(Me.pnlLogo)
        Me.Controls.Add(Me.pnlCarte)
        Me.Controls.Add(Me.lblSousTitre)
        Me.Controls.Add(Me.lblAppNom)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormConnexion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GestNotes — Connexion"
        Me.pnlCarte.ResumeLayout(False)
        Me.pnlCarte.PerformLayout()
        Me.pnlLogo.ResumeLayout(False)
        Me.pnlLogo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAppNom As Label
    Friend WithEvents lblSousTitre As Label
    Friend WithEvents pnlCarte As Panel
    Friend WithEvents lblProfil As Label
    Friend WithEvents cmbProfil As ComboBox
    Friend WithEvents lblLogin As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents lblMdp As Label
    Friend WithEvents txtLogin As TextBox
    Friend WithEvents btnConnecter As Button
    Friend WithEvents btnQuitter As Button
    Friend WithEvents pnlLogo As Panel
    Friend WithEvents lblLogoText As Label
End Class
