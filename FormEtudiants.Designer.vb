<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEtudiants
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
        Me.lblTitre = New System.Windows.Forms.Label()
        Me.btnNouvelEtudiant = New System.Windows.Forms.Button()
        Me.pnlFiche = New System.Windows.Forms.Panel()
        Me.lblFicheTitre = New System.Windows.Forms.Label()
        Me.sepFiche = New System.Windows.Forms.Panel()
        Me.lblMatricule = New System.Windows.Forms.Label()
        Me.txtMatricule = New System.Windows.Forms.TextBox()
        Me.lblNomPrenom = New System.Windows.Forms.Label()
        Me.txtNomPrenom = New System.Windows.Forms.TextBox()
        Me.lblSexe = New System.Windows.Forms.Label()
        Me.cmbSexe = New System.Windows.Forms.ComboBox()
        Me.pnlToolbar.SuspendLayout()
        Me.pnlFiche.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlToolbar
        '
        Me.pnlToolbar.BackColor = System.Drawing.Color.White
        Me.pnlToolbar.Controls.Add(Me.btnNouvelEtudiant)
        Me.pnlToolbar.Controls.Add(Me.lblTitre)
        Me.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlToolbar.Location = New System.Drawing.Point(0, 0)
        Me.pnlToolbar.Name = "pnlToolbar"
        Me.pnlToolbar.Size = New System.Drawing.Size(933, 44)
        Me.pnlToolbar.TabIndex = 0
        '
        'lblTitre
        '
        Me.lblTitre.AutoSize = True
        Me.lblTitre.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.lblTitre.Location = New System.Drawing.Point(12, 10)
        Me.lblTitre.Name = "lblTitre"
        Me.lblTitre.Size = New System.Drawing.Size(174, 21)
        Me.lblTitre.TabIndex = 0
        Me.lblTitre.Text = "Gestion des étudiants"
        '
        'btnNouvelEtudiant
        '
        Me.btnNouvelEtudiant.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNouvelEtudiant.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.btnNouvelEtudiant.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNouvelEtudiant.FlatAppearance.BorderSize = 0
        Me.btnNouvelEtudiant.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNouvelEtudiant.ForeColor = System.Drawing.Color.White
        Me.btnNouvelEtudiant.Location = New System.Drawing.Point(791, 8)
        Me.btnNouvelEtudiant.Name = "btnNouvelEtudiant"
        Me.btnNouvelEtudiant.Size = New System.Drawing.Size(130, 28)
        Me.btnNouvelEtudiant.TabIndex = 1
        Me.btnNouvelEtudiant.Text = "+ Nouvel étudiant"
        Me.btnNouvelEtudiant.UseVisualStyleBackColor = False
        '
        'pnlFiche
        '
        Me.pnlFiche.BackColor = System.Drawing.Color.White
        Me.pnlFiche.Controls.Add(Me.cmbSexe)
        Me.pnlFiche.Controls.Add(Me.lblSexe)
        Me.pnlFiche.Controls.Add(Me.txtNomPrenom)
        Me.pnlFiche.Controls.Add(Me.lblNomPrenom)
        Me.pnlFiche.Controls.Add(Me.txtMatricule)
        Me.pnlFiche.Controls.Add(Me.lblMatricule)
        Me.pnlFiche.Controls.Add(Me.sepFiche)
        Me.pnlFiche.Controls.Add(Me.lblFicheTitre)
        Me.pnlFiche.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlFiche.Location = New System.Drawing.Point(683, 44)
        Me.pnlFiche.Name = "pnlFiche"
        Me.pnlFiche.Padding = New System.Windows.Forms.Padding(12)
        Me.pnlFiche.Size = New System.Drawing.Size(250, 475)
        Me.pnlFiche.TabIndex = 1
        '
        'lblFicheTitre
        '
        Me.lblFicheTitre.AutoSize = True
        Me.lblFicheTitre.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFicheTitre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.lblFicheTitre.Location = New System.Drawing.Point(12, 12)
        Me.lblFicheTitre.Name = "lblFicheTitre"
        Me.lblFicheTitre.Size = New System.Drawing.Size(86, 15)
        Me.lblFicheTitre.TabIndex = 0
        Me.lblFicheTitre.Text = "Fiche étudiant"
        '
        'sepFiche
        '
        Me.sepFiche.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.sepFiche.Location = New System.Drawing.Point(12, 34)
        Me.sepFiche.Name = "sepFiche"
        Me.sepFiche.Size = New System.Drawing.Size(226, 1)
        Me.sepFiche.TabIndex = 1
        '
        'lblMatricule
        '
        Me.lblMatricule.AutoSize = True
        Me.lblMatricule.Location = New System.Drawing.Point(12, 44)
        Me.lblMatricule.Name = "lblMatricule"
        Me.lblMatricule.Size = New System.Drawing.Size(104, 15)
        Me.lblMatricule.TabIndex = 2
        Me.lblMatricule.Text = "Numéro matricule"
        '
        'txtMatricule
        '
        Me.txtMatricule.Location = New System.Drawing.Point(12, 60)
        Me.txtMatricule.Name = "txtMatricule"
        Me.txtMatricule.Size = New System.Drawing.Size(226, 23)
        Me.txtMatricule.TabIndex = 3
        '
        'lblNomPrenom
        '
        Me.lblNomPrenom.AutoSize = True
        Me.lblNomPrenom.Location = New System.Drawing.Point(12, 92)
        Me.lblNomPrenom.Name = "lblNomPrenom"
        Me.lblNomPrenom.Size = New System.Drawing.Size(82, 15)
        Me.lblNomPrenom.TabIndex = 4
        Me.lblNomPrenom.Text = "Nom & Prénom"
        '
        'txtNomPrenom
        '
        Me.txtNomPrenom.Location = New System.Drawing.Point(12, 108)
        Me.txtNomPrenom.Name = "txtNomPrenom"
        Me.txtNomPrenom.Size = New System.Drawing.Size(226, 23)
        Me.txtNomPrenom.TabIndex = 5
        '
        'lblSexe
        '
        Me.lblSexe.AutoSize = True
        Me.lblSexe.Location = New System.Drawing.Point(12, 140)
        Me.lblSexe.Name = "lblSexe"
        Me.lblSexe.Size = New System.Drawing.Size(31, 15)
        Me.lblSexe.TabIndex = 6
        Me.lblSexe.Text = "Sexe"
        '
        'cmbSexe
        '
        Me.cmbSexe.FormattingEnabled = True
        Me.cmbSexe.Items.AddRange(New Object() {"Masculin ", "Féminin"})
        Me.cmbSexe.Location = New System.Drawing.Point(12, 156)
        Me.cmbSexe.Name = "cmbSexe"
        Me.cmbSexe.Size = New System.Drawing.Size(226, 23)
        Me.cmbSexe.TabIndex = 7
        '
        'FormEtudiants
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(933, 519)
        Me.Controls.Add(Me.pnlFiche)
        Me.Controls.Add(Me.pnlToolbar)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "FormEtudiants"
        Me.Text = "Gestion des étudiants"
        Me.pnlToolbar.ResumeLayout(False)
        Me.pnlToolbar.PerformLayout()
        Me.pnlFiche.ResumeLayout(False)
        Me.pnlFiche.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlToolbar As Panel
    Friend WithEvents btnNouvelEtudiant As Button
    Friend WithEvents lblTitre As Label
    Friend WithEvents pnlFiche As Panel
    Friend WithEvents sepFiche As Panel
    Friend WithEvents lblFicheTitre As Label
    Friend WithEvents txtMatricule As TextBox
    Friend WithEvents lblMatricule As Label
    Friend WithEvents lblSexe As Label
    Friend WithEvents txtNomPrenom As TextBox
    Friend WithEvents lblNomPrenom As Label
    Friend WithEvents cmbSexe As ComboBox
End Class
