<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormParametres
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pnlToolbar = New System.Windows.Forms.Panel()
        Me.btnNouvelUser = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlGauche = New System.Windows.Forms.Panel()
        Me.dgvUtilisateurs = New System.Windows.Forms.DataGridView()
        Me.colLogin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRole = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colActionsUser = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnlDroit = New System.Windows.Forms.Panel()
        Me.pnlInstitut = New System.Windows.Forms.Panel()
        Me.btnSauverInstitut = New System.Windows.Forms.Button()
        Me.txtAnneeScolaire = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtAdresseInstitut = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtNomInstitut = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.pnlFicheUser = New System.Windows.Forms.Panel()
        Me.txtMdpConfirm = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnSauverUser = New System.Windows.Forms.Button()
        Me.btnSupprimerUser = New System.Windows.Forms.Button()
        Me.txtMdpUser = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtLoginUser = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnRetour = New System.Windows.Forms.Button()
        Me.pnlToolbar.SuspendLayout()
        Me.pnlGauche.SuspendLayout()
        CType(Me.dgvUtilisateurs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDroit.SuspendLayout()
        Me.pnlInstitut.SuspendLayout()
        Me.pnlFicheUser.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlToolbar
        '
        Me.pnlToolbar.BackColor = System.Drawing.Color.White
        Me.pnlToolbar.Controls.Add(Me.btnRetour)
        Me.pnlToolbar.Controls.Add(Me.btnNouvelUser)
        Me.pnlToolbar.Controls.Add(Me.Label1)
        Me.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlToolbar.Location = New System.Drawing.Point(0, 0)
        Me.pnlToolbar.Name = "pnlToolbar"
        Me.pnlToolbar.Size = New System.Drawing.Size(670, 44)
        Me.pnlToolbar.TabIndex = 0
        '
        'btnNouvelUser
        '
        Me.btnNouvelUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNouvelUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnNouvelUser.FlatAppearance.BorderSize = 0
        Me.btnNouvelUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNouvelUser.ForeColor = System.Drawing.Color.White
        Me.btnNouvelUser.Location = New System.Drawing.Point(509, 8)
        Me.btnNouvelUser.Name = "btnNouvelUser"
        Me.btnNouvelUser.Size = New System.Drawing.Size(150, 28)
        Me.btnNouvelUser.TabIndex = 1
        Me.btnNouvelUser.Text = "+ Nouvel Utilisateur "
        Me.btnNouvelUser.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(105, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(225, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Paramètres - Administration"
        '
        'pnlGauche
        '
        Me.pnlGauche.BackColor = System.Drawing.Color.White
        Me.pnlGauche.Controls.Add(Me.dgvUtilisateurs)
        Me.pnlGauche.Controls.Add(Me.Label2)
        Me.pnlGauche.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlGauche.Location = New System.Drawing.Point(0, 44)
        Me.pnlGauche.Name = "pnlGauche"
        Me.pnlGauche.Padding = New System.Windows.Forms.Padding(12)
        Me.pnlGauche.Size = New System.Drawing.Size(260, 508)
        Me.pnlGauche.TabIndex = 1
        '
        'dgvUtilisateurs
        '
        Me.dgvUtilisateurs.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvUtilisateurs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvUtilisateurs.BackgroundColor = System.Drawing.Color.White
        Me.dgvUtilisateurs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvUtilisateurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUtilisateurs.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colLogin, Me.colRole, Me.colActionsUser})
        Me.dgvUtilisateurs.Location = New System.Drawing.Point(12, 36)
        Me.dgvUtilisateurs.Name = "dgvUtilisateurs"
        Me.dgvUtilisateurs.ReadOnly = True
        Me.dgvUtilisateurs.RowHeadersVisible = False
        Me.dgvUtilisateurs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvUtilisateurs.ShowRowErrors = False
        Me.dgvUtilisateurs.Size = New System.Drawing.Size(236, 235)
        Me.dgvUtilisateurs.TabIndex = 1
        '
        'colLogin
        '
        Me.colLogin.HeaderText = "Login"
        Me.colLogin.Name = "colLogin"
        Me.colLogin.ReadOnly = True
        '
        'colRole
        '
        Me.colRole.HeaderText = "Rôle"
        Me.colRole.Name = "colRole"
        Me.colRole.ReadOnly = True
        '
        'colActionsUser
        '
        Me.colActionsUser.HeaderText = "Actions"
        Me.colActionsUser.Name = "colActionsUser"
        Me.colActionsUser.ReadOnly = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(12, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Utilisateurs"
        '
        'pnlDroit
        '
        Me.pnlDroit.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.pnlDroit.Controls.Add(Me.pnlInstitut)
        Me.pnlDroit.Controls.Add(Me.pnlFicheUser)
        Me.pnlDroit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDroit.Location = New System.Drawing.Point(260, 44)
        Me.pnlDroit.Name = "pnlDroit"
        Me.pnlDroit.Padding = New System.Windows.Forms.Padding(10)
        Me.pnlDroit.Size = New System.Drawing.Size(410, 508)
        Me.pnlDroit.TabIndex = 2
        '
        'pnlInstitut
        '
        Me.pnlInstitut.BackColor = System.Drawing.Color.White
        Me.pnlInstitut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlInstitut.Controls.Add(Me.btnSauverInstitut)
        Me.pnlInstitut.Controls.Add(Me.txtAnneeScolaire)
        Me.pnlInstitut.Controls.Add(Me.Label11)
        Me.pnlInstitut.Controls.Add(Me.txtAdresseInstitut)
        Me.pnlInstitut.Controls.Add(Me.Label10)
        Me.pnlInstitut.Controls.Add(Me.txtNomInstitut)
        Me.pnlInstitut.Controls.Add(Me.Label9)
        Me.pnlInstitut.Controls.Add(Me.Label8)
        Me.pnlInstitut.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlInstitut.Location = New System.Drawing.Point(10, 273)
        Me.pnlInstitut.Name = "pnlInstitut"
        Me.pnlInstitut.Size = New System.Drawing.Size(390, 225)
        Me.pnlInstitut.TabIndex = 3
        '
        'btnSauverInstitut
        '
        Me.btnSauverInstitut.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.btnSauverInstitut.FlatAppearance.BorderSize = 0
        Me.btnSauverInstitut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSauverInstitut.ForeColor = System.Drawing.Color.White
        Me.btnSauverInstitut.Location = New System.Drawing.Point(15, 176)
        Me.btnSauverInstitut.Name = "btnSauverInstitut"
        Me.btnSauverInstitut.Size = New System.Drawing.Size(361, 32)
        Me.btnSauverInstitut.TabIndex = 4
        Me.btnSauverInstitut.Text = "Enregistrer"
        Me.btnSauverInstitut.UseVisualStyleBackColor = False
        '
        'txtAnneeScolaire
        '
        Me.txtAnneeScolaire.Location = New System.Drawing.Point(16, 146)
        Me.txtAnneeScolaire.Name = "txtAnneeScolaire"
        Me.txtAnneeScolaire.Size = New System.Drawing.Size(360, 23)
        Me.txtAnneeScolaire.TabIndex = 6
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(13, 128)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(133, 15)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Année Scolaire en cours"
        '
        'txtAdresseInstitut
        '
        Me.txtAdresseInstitut.Location = New System.Drawing.Point(16, 102)
        Me.txtAdresseInstitut.Name = "txtAdresseInstitut"
        Me.txtAdresseInstitut.Size = New System.Drawing.Size(360, 23)
        Me.txtAdresseInstitut.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 83)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(98, 15)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Adresse /Contact"
        '
        'txtNomInstitut
        '
        Me.txtNomInstitut.Location = New System.Drawing.Point(16, 55)
        Me.txtNomInstitut.Name = "txtNomInstitut"
        Me.txtNomInstitut.Size = New System.Drawing.Size(360, 23)
        Me.txtNomInstitut.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 36)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 15)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Nom de l'institut"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(13, 15)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(184, 15)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Informations de l'établissement"
        '
        'pnlFicheUser
        '
        Me.pnlFicheUser.BackColor = System.Drawing.Color.White
        Me.pnlFicheUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlFicheUser.Controls.Add(Me.txtMdpConfirm)
        Me.pnlFicheUser.Controls.Add(Me.Label7)
        Me.pnlFicheUser.Controls.Add(Me.btnSauverUser)
        Me.pnlFicheUser.Controls.Add(Me.btnSupprimerUser)
        Me.pnlFicheUser.Controls.Add(Me.txtMdpUser)
        Me.pnlFicheUser.Controls.Add(Me.Label6)
        Me.pnlFicheUser.Controls.Add(Me.ComboBox1)
        Me.pnlFicheUser.Controls.Add(Me.Label5)
        Me.pnlFicheUser.Controls.Add(Me.txtLoginUser)
        Me.pnlFicheUser.Controls.Add(Me.Label4)
        Me.pnlFicheUser.Controls.Add(Me.Label3)
        Me.pnlFicheUser.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlFicheUser.Location = New System.Drawing.Point(10, 10)
        Me.pnlFicheUser.Name = "pnlFicheUser"
        Me.pnlFicheUser.Size = New System.Drawing.Size(390, 263)
        Me.pnlFicheUser.TabIndex = 0
        '
        'txtMdpConfirm
        '
        Me.txtMdpConfirm.Location = New System.Drawing.Point(12, 187)
        Me.txtMdpConfirm.Name = "txtMdpConfirm"
        Me.txtMdpConfirm.Size = New System.Drawing.Size(360, 23)
        Me.txtMdpConfirm.TabIndex = 8
        Me.txtMdpConfirm.UseSystemPasswordChar = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 169)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(134, 15)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Confirmer mot de passe"
        '
        'btnSauverUser
        '
        Me.btnSauverUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.btnSauverUser.FlatAppearance.BorderSize = 0
        Me.btnSauverUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSauverUser.ForeColor = System.Drawing.Color.White
        Me.btnSauverUser.Location = New System.Drawing.Point(13, 216)
        Me.btnSauverUser.Name = "btnSauverUser"
        Me.btnSauverUser.Size = New System.Drawing.Size(176, 32)
        Me.btnSauverUser.TabIndex = 1
        Me.btnSauverUser.Text = "Enregistrer"
        Me.btnSauverUser.UseVisualStyleBackColor = False
        '
        'btnSupprimerUser
        '
        Me.btnSupprimerUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnSupprimerUser.FlatAppearance.BorderSize = 0
        Me.btnSupprimerUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSupprimerUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnSupprimerUser.Location = New System.Drawing.Point(197, 216)
        Me.btnSupprimerUser.Name = "btnSupprimerUser"
        Me.btnSupprimerUser.Size = New System.Drawing.Size(176, 32)
        Me.btnSupprimerUser.TabIndex = 2
        Me.btnSupprimerUser.Text = "Supprimer"
        Me.btnSupprimerUser.UseVisualStyleBackColor = False
        '
        'txtMdpUser
        '
        Me.txtMdpUser.Location = New System.Drawing.Point(13, 137)
        Me.txtMdpUser.Name = "txtMdpUser"
        Me.txtMdpUser.Size = New System.Drawing.Size(360, 23)
        Me.txtMdpUser.TabIndex = 6
        Me.txtMdpUser.UseSystemPasswordChar = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 121)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(128, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Nouveau mot de passe"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Administrateur", "Secrétaire"})
        Me.ComboBox1.Location = New System.Drawing.Point(13, 97)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(360, 23)
        Me.ComboBox1.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 15)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Rôle"
        '
        'txtLoginUser
        '
        Me.txtLoginUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLoginUser.Location = New System.Drawing.Point(13, 41)
        Me.txtLoginUser.Name = "txtLoginUser"
        Me.txtLoginUser.Size = New System.Drawing.Size(360, 23)
        Me.txtLoginUser.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 15)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Login"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(12, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Fiche utilisateur"
        '
        'btnRetour
        '
        Me.btnRetour.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnRetour.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRetour.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.btnRetour.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRetour.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.btnRetour.Location = New System.Drawing.Point(8, 8)
        Me.btnRetour.Name = "btnRetour"
        Me.btnRetour.Size = New System.Drawing.Size(90, 28)
        Me.btnRetour.TabIndex = 4
        Me.btnRetour.Text = "← Retour"
        Me.btnRetour.UseVisualStyleBackColor = False
        '
        'FormParametres
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(670, 552)
        Me.Controls.Add(Me.pnlDroit)
        Me.Controls.Add(Me.pnlGauche)
        Me.Controls.Add(Me.pnlToolbar)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.Name = "FormParametres"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Paramètres"
        Me.pnlToolbar.ResumeLayout(False)
        Me.pnlToolbar.PerformLayout()
        Me.pnlGauche.ResumeLayout(False)
        Me.pnlGauche.PerformLayout()
        CType(Me.dgvUtilisateurs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDroit.ResumeLayout(False)
        Me.pnlInstitut.ResumeLayout(False)
        Me.pnlInstitut.PerformLayout()
        Me.pnlFicheUser.ResumeLayout(False)
        Me.pnlFicheUser.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlToolbar As Panel
    Friend WithEvents btnNouvelUser As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlGauche As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvUtilisateurs As DataGridView
    Friend WithEvents colLogin As DataGridViewTextBoxColumn
    Friend WithEvents colRole As DataGridViewTextBoxColumn
    Friend WithEvents colActionsUser As DataGridViewTextBoxColumn
    Friend WithEvents pnlDroit As Panel
    Friend WithEvents pnlFicheUser As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtLoginUser As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents txtMdpConfirm As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtMdpUser As TextBox
    Friend WithEvents btnSupprimerUser As Button
    Friend WithEvents btnSauverUser As Button
    Friend WithEvents pnlInstitut As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents txtAdresseInstitut As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtNomInstitut As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents btnSauverInstitut As Button
    Friend WithEvents txtAnneeScolaire As TextBox
    Friend WithEvents btnRetour As Button
End Class
