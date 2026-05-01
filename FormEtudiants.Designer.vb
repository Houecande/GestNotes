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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlToolbar = New System.Windows.Forms.Panel()
        Me.btnNouvelEtudiant = New System.Windows.Forms.Button()
        Me.lblTitre = New System.Windows.Forms.Label()
        Me.pnlFiche = New System.Windows.Forms.Panel()
        Me.btnSupprimer = New System.Windows.Forms.Button()
        Me.btnAnnuler = New System.Windows.Forms.Button()
        Me.btnEnregistrer = New System.Windows.Forms.Button()
        Me.cmbClasse = New System.Windows.Forms.ComboBox()
        Me.lblClasse = New System.Windows.Forms.Label()
        Me.lblLieuNaiss = New System.Windows.Forms.Label()
        Me.dtpDateNaiss = New System.Windows.Forms.DateTimePicker()
        Me.txtLieuNaiss = New System.Windows.Forms.TextBox()
        Me.lblDateNaiss = New System.Windows.Forms.Label()
        Me.cmbSexe = New System.Windows.Forms.ComboBox()
        Me.lblSexe = New System.Windows.Forms.Label()
        Me.txtNomPrenom = New System.Windows.Forms.TextBox()
        Me.lblNomPrenom = New System.Windows.Forms.Label()
        Me.txtMatricule = New System.Windows.Forms.TextBox()
        Me.lblMatricule = New System.Windows.Forms.Label()
        Me.sepFiche = New System.Windows.Forms.Panel()
        Me.lblFicheTitre = New System.Windows.Forms.Label()
        Me.pnlListe = New System.Windows.Forms.Panel()
        Me.dgvEtudiants = New System.Windows.Forms.DataGridView()
        Me.colMatricule = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSexe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colClasse = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colModifier = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSupprimer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmbFiltreClasse = New System.Windows.Forms.ComboBox()
        Me.txtRecherche = New System.Windows.Forms.TextBox()
        Me.pnlToolbar.SuspendLayout()
        Me.pnlFiche.SuspendLayout()
        Me.pnlListe.SuspendLayout()
        CType(Me.dgvEtudiants, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'pnlFiche
        '
        Me.pnlFiche.BackColor = System.Drawing.Color.White
        Me.pnlFiche.Controls.Add(Me.btnSupprimer)
        Me.pnlFiche.Controls.Add(Me.btnAnnuler)
        Me.pnlFiche.Controls.Add(Me.btnEnregistrer)
        Me.pnlFiche.Controls.Add(Me.cmbClasse)
        Me.pnlFiche.Controls.Add(Me.lblClasse)
        Me.pnlFiche.Controls.Add(Me.lblLieuNaiss)
        Me.pnlFiche.Controls.Add(Me.dtpDateNaiss)
        Me.pnlFiche.Controls.Add(Me.txtLieuNaiss)
        Me.pnlFiche.Controls.Add(Me.lblDateNaiss)
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
        'btnSupprimer
        '
        Me.btnSupprimer.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnSupprimer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSupprimer.FlatAppearance.BorderSize = 0
        Me.btnSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSupprimer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnSupprimer.Location = New System.Drawing.Point(12, 378)
        Me.btnSupprimer.Name = "btnSupprimer"
        Me.btnSupprimer.Size = New System.Drawing.Size(223, 32)
        Me.btnSupprimer.TabIndex = 16
        Me.btnSupprimer.Text = "Supprimer"
        Me.btnSupprimer.UseVisualStyleBackColor = False
        '
        'btnAnnuler
        '
        Me.btnAnnuler.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnAnnuler.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAnnuler.FlatAppearance.BorderSize = 0
        Me.btnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnnuler.ForeColor = System.Drawing.Color.Brown
        Me.btnAnnuler.Location = New System.Drawing.Point(129, 340)
        Me.btnAnnuler.Name = "btnAnnuler"
        Me.btnAnnuler.Size = New System.Drawing.Size(110, 32)
        Me.btnAnnuler.TabIndex = 15
        Me.btnAnnuler.Text = "Annuler"
        Me.btnAnnuler.UseVisualStyleBackColor = False
        '
        'btnEnregistrer
        '
        Me.btnEnregistrer.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.btnEnregistrer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEnregistrer.FlatAppearance.BorderSize = 0
        Me.btnEnregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnregistrer.ForeColor = System.Drawing.Color.White
        Me.btnEnregistrer.Location = New System.Drawing.Point(12, 340)
        Me.btnEnregistrer.Name = "btnEnregistrer"
        Me.btnEnregistrer.Size = New System.Drawing.Size(110, 32)
        Me.btnEnregistrer.TabIndex = 14
        Me.btnEnregistrer.Text = "Enregistrer"
        Me.btnEnregistrer.UseVisualStyleBackColor = False
        '
        'cmbClasse
        '
        Me.cmbClasse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbClasse.FormattingEnabled = True
        Me.cmbClasse.Location = New System.Drawing.Point(12, 300)
        Me.cmbClasse.Name = "cmbClasse"
        Me.cmbClasse.Size = New System.Drawing.Size(226, 23)
        Me.cmbClasse.TabIndex = 13
        '
        'lblClasse
        '
        Me.lblClasse.AutoSize = True
        Me.lblClasse.Location = New System.Drawing.Point(12, 284)
        Me.lblClasse.Name = "lblClasse"
        Me.lblClasse.Size = New System.Drawing.Size(40, 15)
        Me.lblClasse.TabIndex = 12
        Me.lblClasse.Text = "Classe"
        '
        'lblLieuNaiss
        '
        Me.lblLieuNaiss.AutoSize = True
        Me.lblLieuNaiss.Location = New System.Drawing.Point(12, 236)
        Me.lblLieuNaiss.Name = "lblLieuNaiss"
        Me.lblLieuNaiss.Size = New System.Drawing.Size(99, 15)
        Me.lblLieuNaiss.TabIndex = 11
        Me.lblLieuNaiss.Text = "Lieu de naissance"
        '
        'dtpDateNaiss
        '
        Me.dtpDateNaiss.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDateNaiss.Location = New System.Drawing.Point(12, 204)
        Me.dtpDateNaiss.Name = "dtpDateNaiss"
        Me.dtpDateNaiss.Size = New System.Drawing.Size(226, 23)
        Me.dtpDateNaiss.TabIndex = 10
        '
        'txtLieuNaiss
        '
        Me.txtLieuNaiss.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLieuNaiss.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLieuNaiss.Location = New System.Drawing.Point(12, 252)
        Me.txtLieuNaiss.Name = "txtLieuNaiss"
        Me.txtLieuNaiss.Size = New System.Drawing.Size(226, 23)
        Me.txtLieuNaiss.TabIndex = 9
        '
        'lblDateNaiss
        '
        Me.lblDateNaiss.AutoSize = True
        Me.lblDateNaiss.Location = New System.Drawing.Point(12, 188)
        Me.lblDateNaiss.Name = "lblDateNaiss"
        Me.lblDateNaiss.Size = New System.Drawing.Size(101, 15)
        Me.lblDateNaiss.TabIndex = 8
        Me.lblDateNaiss.Text = "Date de naissance"
        '
        'cmbSexe
        '
        Me.cmbSexe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSexe.FormattingEnabled = True
        Me.cmbSexe.Items.AddRange(New Object() {"Masculin ", "Féminin"})
        Me.cmbSexe.Location = New System.Drawing.Point(12, 156)
        Me.cmbSexe.Name = "cmbSexe"
        Me.cmbSexe.Size = New System.Drawing.Size(226, 23)
        Me.cmbSexe.TabIndex = 7
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
        'txtNomPrenom
        '
        Me.txtNomPrenom.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNomPrenom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNomPrenom.Location = New System.Drawing.Point(12, 108)
        Me.txtNomPrenom.Name = "txtNomPrenom"
        Me.txtNomPrenom.Size = New System.Drawing.Size(226, 23)
        Me.txtNomPrenom.TabIndex = 5
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
        'txtMatricule
        '
        Me.txtMatricule.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMatricule.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMatricule.Location = New System.Drawing.Point(12, 60)
        Me.txtMatricule.Name = "txtMatricule"
        Me.txtMatricule.Size = New System.Drawing.Size(226, 23)
        Me.txtMatricule.TabIndex = 3
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
        'sepFiche
        '
        Me.sepFiche.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.sepFiche.Location = New System.Drawing.Point(12, 34)
        Me.sepFiche.Name = "sepFiche"
        Me.sepFiche.Size = New System.Drawing.Size(226, 1)
        Me.sepFiche.TabIndex = 1
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
        'pnlListe
        '
        Me.pnlListe.Controls.Add(Me.dgvEtudiants)
        Me.pnlListe.Controls.Add(Me.cmbFiltreClasse)
        Me.pnlListe.Controls.Add(Me.txtRecherche)
        Me.pnlListe.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlListe.Location = New System.Drawing.Point(0, 44)
        Me.pnlListe.Name = "pnlListe"
        Me.pnlListe.Padding = New System.Windows.Forms.Padding(10)
        Me.pnlListe.Size = New System.Drawing.Size(683, 475)
        Me.pnlListe.TabIndex = 2
        '
        'dgvEtudiants
        '
        Me.dgvEtudiants.AllowUserToAddRows = False
        Me.dgvEtudiants.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvEtudiants.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvEtudiants.BackgroundColor = System.Drawing.Color.White
        Me.dgvEtudiants.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(251, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(124, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvEtudiants.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvEtudiants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEtudiants.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colMatricule, Me.colNom, Me.colSexe, Me.colClasse, Me.colModifier, Me.colSupprimer})
        Me.dgvEtudiants.Location = New System.Drawing.Point(12, 29)
        Me.dgvEtudiants.MultiSelect = False
        Me.dgvEtudiants.Name = "dgvEtudiants"
        Me.dgvEtudiants.ReadOnly = True
        Me.dgvEtudiants.RowHeadersVisible = False
        Me.dgvEtudiants.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEtudiants.Size = New System.Drawing.Size(658, 446)
        Me.dgvEtudiants.TabIndex = 2
        '
        'colMatricule
        '
        Me.colMatricule.FillWeight = 274.1117!
        Me.colMatricule.HeaderText = "Matricule"
        Me.colMatricule.MinimumWidth = 90
        Me.colMatricule.Name = "colMatricule"
        Me.colMatricule.ReadOnly = True
        '
        'colNom
        '
        Me.colNom.FillWeight = 27.05372!
        Me.colNom.HeaderText = "Nom & Prénom"
        Me.colNom.MinimumWidth = 180
        Me.colNom.Name = "colNom"
        Me.colNom.ReadOnly = True
        '
        'colSexe
        '
        Me.colSexe.FillWeight = 35.82862!
        Me.colSexe.HeaderText = "Sexe"
        Me.colSexe.MinimumWidth = 50
        Me.colSexe.Name = "colSexe"
        Me.colSexe.ReadOnly = True
        '
        'colClasse
        '
        Me.colClasse.FillWeight = 136.3047!
        Me.colClasse.HeaderText = "Classe"
        Me.colClasse.MinimumWidth = 100
        Me.colClasse.Name = "colClasse"
        Me.colClasse.ReadOnly = True
        '
        'colModifier
        '
        Me.colModifier.FillWeight = 114.2187!
        Me.colModifier.HeaderText = "Modifier"
        Me.colModifier.MinimumWidth = 60
        Me.colModifier.Name = "colModifier"
        Me.colModifier.ReadOnly = True
        '
        'colSupprimer
        '
        Me.colSupprimer.FillWeight = 12.48256!
        Me.colSupprimer.HeaderText = "Supprimer"
        Me.colSupprimer.MinimumWidth = 65
        Me.colSupprimer.Name = "colSupprimer"
        Me.colSupprimer.ReadOnly = True
        '
        'cmbFiltreClasse
        '
        Me.cmbFiltreClasse.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbFiltreClasse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFiltreClasse.FormattingEnabled = True
        Me.cmbFiltreClasse.Items.AddRange(New Object() {"Toutes les classes"})
        Me.cmbFiltreClasse.Location = New System.Drawing.Point(320, 0)
        Me.cmbFiltreClasse.Name = "cmbFiltreClasse"
        Me.cmbFiltreClasse.Size = New System.Drawing.Size(160, 23)
        Me.cmbFiltreClasse.TabIndex = 1
        '
        'txtRecherche
        '
        Me.txtRecherche.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRecherche.BackColor = System.Drawing.Color.White
        Me.txtRecherche.Location = New System.Drawing.Point(13, 0)
        Me.txtRecherche.Name = "txtRecherche"
        Me.txtRecherche.Size = New System.Drawing.Size(300, 23)
        Me.txtRecherche.TabIndex = 0
        '
        'FormEtudiants
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(933, 519)
        Me.Controls.Add(Me.pnlListe)
        Me.Controls.Add(Me.pnlFiche)
        Me.Controls.Add(Me.pnlToolbar)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "FormEtudiants"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestion des étudiants"
        Me.pnlToolbar.ResumeLayout(False)
        Me.pnlToolbar.PerformLayout()
        Me.pnlFiche.ResumeLayout(False)
        Me.pnlFiche.PerformLayout()
        Me.pnlListe.ResumeLayout(False)
        Me.pnlListe.PerformLayout()
        CType(Me.dgvEtudiants, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txtLieuNaiss As TextBox
    Friend WithEvents lblDateNaiss As Label
    Friend WithEvents lblLieuNaiss As Label
    Friend WithEvents dtpDateNaiss As DateTimePicker
    Friend WithEvents cmbClasse As ComboBox
    Friend WithEvents lblClasse As Label
    Friend WithEvents btnEnregistrer As Button
    Friend WithEvents btnAnnuler As Button
    Friend WithEvents btnSupprimer As Button
    Friend WithEvents pnlListe As Panel
    Friend WithEvents txtRecherche As TextBox
    Friend WithEvents cmbFiltreClasse As ComboBox
    Friend WithEvents dgvEtudiants As DataGridView
    Friend WithEvents colMatricule As DataGridViewTextBoxColumn
    Friend WithEvents colNom As DataGridViewTextBoxColumn
    Friend WithEvents colSexe As DataGridViewTextBoxColumn
    Friend WithEvents colClasse As DataGridViewTextBoxColumn
    Friend WithEvents colModifier As DataGridViewTextBoxColumn
    Friend WithEvents colSupprimer As DataGridViewTextBoxColumn
End Class
