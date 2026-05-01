<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormNotes
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
        Me.cmbClasse = New System.Windows.Forms.ComboBox()
        Me.cmbMatiere = New System.Windows.Forms.ComboBox()
        Me.btnCalculer = New System.Windows.Forms.Button()
        Me.btnEnregistrer = New System.Windows.Forms.Button()
        Me.pnlCorps = New System.Windows.Forms.Panel()
        Me.pnlInfo = New System.Windows.Forms.Panel()
        Me.lblInfoClasse = New System.Windows.Forms.Label()
        Me.lblInfoMatiere = New System.Windows.Forms.Label()
        Me.lblInfoFormule = New System.Windows.Forms.Label()
        Me.lblInfoSaisies = New System.Windows.Forms.Label()
        Me.dgvNotes = New System.Windows.Forms.DataGridView()
        Me.colNumero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNomEtudiant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colInterro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDevoir = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMoyenne = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlStats = New System.Windows.Forms.Panel()
        Me.pnlStatMoyClasse = New System.Windows.Forms.Panel()
        Me.pnlStatMin = New System.Windows.Forms.Panel()
        Me.pnlStatMax = New System.Windows.Forms.Panel()
        Me.pnlStatSaisies = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.pnlToolbar.SuspendLayout()
        Me.pnlCorps.SuspendLayout()
        Me.pnlInfo.SuspendLayout()
        CType(Me.dgvNotes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlStats.SuspendLayout()
        Me.pnlStatMoyClasse.SuspendLayout()
        Me.pnlStatMin.SuspendLayout()
        Me.pnlStatMax.SuspendLayout()
        Me.pnlStatSaisies.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlToolbar
        '
        Me.pnlToolbar.BackColor = System.Drawing.Color.White
        Me.pnlToolbar.Controls.Add(Me.btnEnregistrer)
        Me.pnlToolbar.Controls.Add(Me.btnCalculer)
        Me.pnlToolbar.Controls.Add(Me.cmbMatiere)
        Me.pnlToolbar.Controls.Add(Me.cmbClasse)
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
        Me.lblTitre.Size = New System.Drawing.Size(130, 21)
        Me.lblTitre.TabIndex = 0
        Me.lblTitre.Text = "Saisie des notes"
        '
        'cmbClasse
        '
        Me.cmbClasse.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbClasse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbClasse.FormattingEnabled = True
        Me.cmbClasse.Location = New System.Drawing.Point(148, 8)
        Me.cmbClasse.Name = "cmbClasse"
        Me.cmbClasse.Size = New System.Drawing.Size(150, 23)
        Me.cmbClasse.TabIndex = 1
        '
        'cmbMatiere
        '
        Me.cmbMatiere.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbMatiere.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMatiere.FormattingEnabled = True
        Me.cmbMatiere.Location = New System.Drawing.Point(304, 8)
        Me.cmbMatiere.Name = "cmbMatiere"
        Me.cmbMatiere.Size = New System.Drawing.Size(200, 23)
        Me.cmbMatiere.TabIndex = 2
        '
        'btnCalculer
        '
        Me.btnCalculer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCalculer.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnCalculer.FlatAppearance.BorderSize = 0
        Me.btnCalculer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalculer.ForeColor = System.Drawing.Color.White
        Me.btnCalculer.Location = New System.Drawing.Point(716, 8)
        Me.btnCalculer.Name = "btnCalculer"
        Me.btnCalculer.Size = New System.Drawing.Size(90, 28)
        Me.btnCalculer.TabIndex = 3
        Me.btnCalculer.Text = "⚡ Calculer"
        Me.btnCalculer.UseVisualStyleBackColor = False
        '
        'btnEnregistrer
        '
        Me.btnEnregistrer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEnregistrer.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.btnEnregistrer.FlatAppearance.BorderSize = 0
        Me.btnEnregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnregistrer.ForeColor = System.Drawing.Color.White
        Me.btnEnregistrer.Location = New System.Drawing.Point(812, 8)
        Me.btnEnregistrer.Name = "btnEnregistrer"
        Me.btnEnregistrer.Size = New System.Drawing.Size(110, 28)
        Me.btnEnregistrer.TabIndex = 4
        Me.btnEnregistrer.Text = "💾 Enregistrer"
        Me.btnEnregistrer.UseVisualStyleBackColor = False
        '
        'pnlCorps
        '
        Me.pnlCorps.Controls.Add(Me.pnlStats)
        Me.pnlCorps.Controls.Add(Me.dgvNotes)
        Me.pnlCorps.Controls.Add(Me.pnlInfo)
        Me.pnlCorps.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlCorps.Location = New System.Drawing.Point(0, 44)
        Me.pnlCorps.Name = "pnlCorps"
        Me.pnlCorps.Padding = New System.Windows.Forms.Padding(10)
        Me.pnlCorps.Size = New System.Drawing.Size(933, 475)
        Me.pnlCorps.TabIndex = 1
        '
        'pnlInfo
        '
        Me.pnlInfo.BackColor = System.Drawing.Color.White
        Me.pnlInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlInfo.Controls.Add(Me.lblInfoSaisies)
        Me.pnlInfo.Controls.Add(Me.lblInfoMatiere)
        Me.pnlInfo.Controls.Add(Me.lblInfoFormule)
        Me.pnlInfo.Controls.Add(Me.lblInfoClasse)
        Me.pnlInfo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlInfo.Location = New System.Drawing.Point(10, 10)
        Me.pnlInfo.Name = "pnlInfo"
        Me.pnlInfo.Size = New System.Drawing.Size(913, 36)
        Me.pnlInfo.TabIndex = 0
        '
        'lblInfoClasse
        '
        Me.lblInfoClasse.AutoSize = True
        Me.lblInfoClasse.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.lblInfoClasse.Location = New System.Drawing.Point(10, 10)
        Me.lblInfoClasse.Name = "lblInfoClasse"
        Me.lblInfoClasse.Size = New System.Drawing.Size(61, 15)
        Me.lblInfoClasse.TabIndex = 0
        Me.lblInfoClasse.Text = "Classe : —"
        '
        'lblInfoMatiere
        '
        Me.lblInfoMatiere.AutoSize = True
        Me.lblInfoMatiere.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.lblInfoMatiere.Location = New System.Drawing.Point(160, 10)
        Me.lblInfoMatiere.Name = "lblInfoMatiere"
        Me.lblInfoMatiere.Size = New System.Drawing.Size(68, 15)
        Me.lblInfoMatiere.TabIndex = 1
        Me.lblInfoMatiere.Text = "Matière : —"
        '
        'lblInfoFormule
        '
        Me.lblInfoFormule.AutoSize = True
        Me.lblInfoFormule.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblInfoFormule.Location = New System.Drawing.Point(309, 10)
        Me.lblInfoFormule.Name = "lblInfoFormule"
        Me.lblInfoFormule.Size = New System.Drawing.Size(241, 15)
        Me.lblInfoFormule.TabIndex = 1
        Me.lblInfoFormule.Text = "Formule : Moy = 30%×Interro + 70%×Devoir"
        '
        'lblInfoSaisies
        '
        Me.lblInfoSaisies.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblInfoSaisies.AutoSize = True
        Me.lblInfoSaisies.ForeColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.lblInfoSaisies.Location = New System.Drawing.Point(660, 10)
        Me.lblInfoSaisies.Name = "lblInfoSaisies"
        Me.lblInfoSaisies.Size = New System.Drawing.Size(60, 15)
        Me.lblInfoSaisies.TabIndex = 2
        Me.lblInfoSaisies.Text = "0/0 saisies"
        '
        'dgvNotes
        '
        Me.dgvNotes.AllowUserToAddRows = False
        Me.dgvNotes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvNotes.BackgroundColor = System.Drawing.Color.White
        Me.dgvNotes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvNotes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colNumero, Me.colNomEtudiant, Me.colInterro, Me.colDevoir, Me.colMoyenne})
        Me.dgvNotes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvNotes.Location = New System.Drawing.Point(10, 46)
        Me.dgvNotes.MultiSelect = False
        Me.dgvNotes.Name = "dgvNotes"
        Me.dgvNotes.RowHeadersVisible = False
        Me.dgvNotes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvNotes.Size = New System.Drawing.Size(913, 419)
        Me.dgvNotes.TabIndex = 2
        '
        'colNumero
        '
        Me.colNumero.FillWeight = 8.0!
        Me.colNumero.HeaderText = "N°"
        Me.colNumero.Name = "colNumero"
        Me.colNumero.ReadOnly = True
        '
        'colNomEtudiant
        '
        Me.colNomEtudiant.FillWeight = 35.0!
        Me.colNomEtudiant.HeaderText = "Nom & Prénom"
        Me.colNomEtudiant.Name = "colNomEtudiant"
        Me.colNomEtudiant.ReadOnly = True
        '
        'colInterro
        '
        Me.colInterro.FillWeight = 20.0!
        Me.colInterro.HeaderText = "Interro /20"
        Me.colInterro.Name = "colInterro"
        '
        'colDevoir
        '
        Me.colDevoir.FillWeight = 20.0!
        Me.colDevoir.HeaderText = "Devoir /20"
        Me.colDevoir.Name = "colDevoir"
        '
        'colMoyenne
        '
        Me.colMoyenne.FillWeight = 17.0!
        Me.colMoyenne.HeaderText = "Moyenne"
        Me.colMoyenne.Name = "colMoyenne"
        Me.colMoyenne.ReadOnly = True
        '
        'pnlStats
        '
        Me.pnlStats.Controls.Add(Me.pnlStatMax)
        Me.pnlStats.Controls.Add(Me.pnlStatSaisies)
        Me.pnlStats.Controls.Add(Me.pnlStatMin)
        Me.pnlStats.Controls.Add(Me.pnlStatMoyClasse)
        Me.pnlStats.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlStats.Location = New System.Drawing.Point(10, 385)
        Me.pnlStats.Name = "pnlStats"
        Me.pnlStats.Size = New System.Drawing.Size(913, 80)
        Me.pnlStats.TabIndex = 3
        '
        'pnlStatMoyClasse
        '
        Me.pnlStatMoyClasse.BackColor = System.Drawing.Color.White
        Me.pnlStatMoyClasse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlStatMoyClasse.Controls.Add(Me.Label2)
        Me.pnlStatMoyClasse.Controls.Add(Me.Label1)
        Me.pnlStatMoyClasse.Location = New System.Drawing.Point(70, 12)
        Me.pnlStatMoyClasse.Name = "pnlStatMoyClasse"
        Me.pnlStatMoyClasse.Size = New System.Drawing.Size(140, 58)
        Me.pnlStatMoyClasse.TabIndex = 0
        '
        'pnlStatMin
        '
        Me.pnlStatMin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlStatMin.BackColor = System.Drawing.Color.White
        Me.pnlStatMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlStatMin.Controls.Add(Me.Label6)
        Me.pnlStatMin.Controls.Add(Me.Label5)
        Me.pnlStatMin.Location = New System.Drawing.Point(490, 12)
        Me.pnlStatMin.Name = "pnlStatMin"
        Me.pnlStatMin.Size = New System.Drawing.Size(140, 58)
        Me.pnlStatMin.TabIndex = 1
        '
        'pnlStatMax
        '
        Me.pnlStatMax.BackColor = System.Drawing.Color.White
        Me.pnlStatMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlStatMax.Controls.Add(Me.Label4)
        Me.pnlStatMax.Controls.Add(Me.Label3)
        Me.pnlStatMax.Location = New System.Drawing.Point(280, 12)
        Me.pnlStatMax.Name = "pnlStatMax"
        Me.pnlStatMax.Size = New System.Drawing.Size(140, 58)
        Me.pnlStatMax.TabIndex = 1
        '
        'pnlStatSaisies
        '
        Me.pnlStatSaisies.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlStatSaisies.BackColor = System.Drawing.Color.White
        Me.pnlStatSaisies.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlStatSaisies.Controls.Add(Me.Label8)
        Me.pnlStatSaisies.Controls.Add(Me.Label7)
        Me.pnlStatSaisies.Location = New System.Drawing.Point(700, 12)
        Me.pnlStatSaisies.Name = "pnlStatSaisies"
        Me.pnlStatSaisies.Size = New System.Drawing.Size(140, 58)
        Me.pnlStatSaisies.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(94, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(42, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 30)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(54, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Label4"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(33, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 30)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Label5"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(57, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Label6"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(37, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 30)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Label7"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(57, 29)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Label8"
        '
        'FormNotes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(933, 519)
        Me.Controls.Add(Me.pnlCorps)
        Me.Controls.Add(Me.pnlToolbar)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "FormNotes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Saisie des notes"
        Me.pnlToolbar.ResumeLayout(False)
        Me.pnlToolbar.PerformLayout()
        Me.pnlCorps.ResumeLayout(False)
        Me.pnlInfo.ResumeLayout(False)
        Me.pnlInfo.PerformLayout()
        CType(Me.dgvNotes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlStats.ResumeLayout(False)
        Me.pnlStatMoyClasse.ResumeLayout(False)
        Me.pnlStatMoyClasse.PerformLayout()
        Me.pnlStatMin.ResumeLayout(False)
        Me.pnlStatMin.PerformLayout()
        Me.pnlStatMax.ResumeLayout(False)
        Me.pnlStatMax.PerformLayout()
        Me.pnlStatSaisies.ResumeLayout(False)
        Me.pnlStatSaisies.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlToolbar As Panel
    Friend WithEvents cmbClasse As ComboBox
    Friend WithEvents lblTitre As Label
    Friend WithEvents btnCalculer As Button
    Friend WithEvents cmbMatiere As ComboBox
    Friend WithEvents btnEnregistrer As Button
    Friend WithEvents pnlCorps As Panel
    Friend WithEvents pnlInfo As Panel
    Friend WithEvents lblInfoClasse As Label
    Friend WithEvents lblInfoMatiere As Label
    Friend WithEvents lblInfoSaisies As Label
    Friend WithEvents lblInfoFormule As Label
    Friend WithEvents dgvNotes As DataGridView
    Friend WithEvents colNumero As DataGridViewTextBoxColumn
    Friend WithEvents colNomEtudiant As DataGridViewTextBoxColumn
    Friend WithEvents colInterro As DataGridViewTextBoxColumn
    Friend WithEvents colDevoir As DataGridViewTextBoxColumn
    Friend WithEvents colMoyenne As DataGridViewTextBoxColumn
    Friend WithEvents pnlStats As Panel
    Friend WithEvents pnlStatMoyClasse As Panel
    Friend WithEvents pnlStatMax As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents pnlStatSaisies As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents pnlStatMin As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
