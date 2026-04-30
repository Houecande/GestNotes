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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnNouvelUser = New System.Windows.Forms.Button()
        Me.pnlGauche = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvUtilisateurs = New System.Windows.Forms.DataGridView()
        Me.colLogin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRole = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colActionsUser = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlDroit = New System.Windows.Forms.Panel()
        Me.pnlToolbar.SuspendLayout()
        Me.pnlGauche.SuspendLayout()
        CType(Me.dgvUtilisateurs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlToolbar
        '
        Me.pnlToolbar.BackColor = System.Drawing.Color.White
        Me.pnlToolbar.Controls.Add(Me.btnNouvelUser)
        Me.pnlToolbar.Controls.Add(Me.Label1)
        Me.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlToolbar.Location = New System.Drawing.Point(0, 0)
        Me.pnlToolbar.Name = "pnlToolbar"
        Me.pnlToolbar.Size = New System.Drawing.Size(933, 44)
        Me.pnlToolbar.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(225, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Paramètres - Administration"
        '
        'btnNouvelUser
        '
        Me.btnNouvelUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNouvelUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnNouvelUser.FlatAppearance.BorderSize = 0
        Me.btnNouvelUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNouvelUser.ForeColor = System.Drawing.Color.White
        Me.btnNouvelUser.Location = New System.Drawing.Point(754, 8)
        Me.btnNouvelUser.Name = "btnNouvelUser"
        Me.btnNouvelUser.Size = New System.Drawing.Size(150, 28)
        Me.btnNouvelUser.TabIndex = 1
        Me.btnNouvelUser.Text = "+ Nouvel Utilisateur "
        Me.btnNouvelUser.UseVisualStyleBackColor = False
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
        Me.pnlGauche.Size = New System.Drawing.Size(200, 475)
        Me.pnlGauche.TabIndex = 1
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
        Me.dgvUtilisateurs.Size = New System.Drawing.Size(236, 360)
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
        'pnlDroit
        '
        Me.pnlDroit.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.pnlDroit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDroit.Location = New System.Drawing.Point(200, 44)
        Me.pnlDroit.Name = "pnlDroit"
        Me.pnlDroit.Padding = New System.Windows.Forms.Padding(10)
        Me.pnlDroit.Size = New System.Drawing.Size(733, 475)
        Me.pnlDroit.TabIndex = 2
        '
        'FormParametres
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(933, 519)
        Me.Controls.Add(Me.pnlDroit)
        Me.Controls.Add(Me.pnlGauche)
        Me.Controls.Add(Me.pnlToolbar)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "FormParametres"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Paramètres"
        Me.pnlToolbar.ResumeLayout(False)
        Me.pnlToolbar.PerformLayout()
        Me.pnlGauche.ResumeLayout(False)
        Me.pnlGauche.PerformLayout()
        CType(Me.dgvUtilisateurs, System.ComponentModel.ISupportInitialize).EndInit()
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
End Class
