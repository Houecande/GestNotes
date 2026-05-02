<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormClasses
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
        Me.btnNouvelleMatiere = New System.Windows.Forms.Button()
        Me.btnNouvelleClasse = New System.Windows.Forms.Button()
        Me.lblTitre = New System.Windows.Forms.Label()
        Me.splitPrincipal = New System.Windows.Forms.SplitContainer()
        Me.pnlFormClasse = New System.Windows.Forms.Panel()
        Me.txtFiliereClasse = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLibelleClasse = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCodeClasse = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTitreFormClasse = New System.Windows.Forms.Label()
        Me.dgvClasses = New System.Windows.Forms.DataGridView()
        Me.colCodeClasse = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLibelleClasse = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFiliereClasse = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colActionsClasse = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblTitreClasses = New System.Windows.Forms.Label()
        Me.pnlFormMatiere = New System.Windows.Forms.Panel()
        Me.nudCoefficient = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtLibelleMatiere = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCodeMatiere = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblTitreFormMatiere = New System.Windows.Forms.Label()
        Me.dgvMatieres = New System.Windows.Forms.DataGridView()
        Me.colCodeMatiere = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLibelleMatiere = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCoef = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colActionsMatiere = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblTitreMatieres = New System.Windows.Forms.Label()
        Me.btnEnregistrerClasse = New System.Windows.Forms.Button()
        Me.btnSupprimerClasse = New System.Windows.Forms.Button()
        Me.btnEnregistrerMatiere = New System.Windows.Forms.Button()
        Me.btnSupprimerMatiere = New System.Windows.Forms.Button()
        Me.pnlBoutonsClasse = New System.Windows.Forms.Panel()
        Me.pnlBoutonsMatiere = New System.Windows.Forms.Panel()
        Me.btnRetour = New System.Windows.Forms.Button()
        Me.pnlToolbar.SuspendLayout()
        CType(Me.splitPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitPrincipal.Panel1.SuspendLayout()
        Me.splitPrincipal.Panel2.SuspendLayout()
        Me.splitPrincipal.SuspendLayout()
        Me.pnlFormClasse.SuspendLayout()
        CType(Me.dgvClasses, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFormMatiere.SuspendLayout()
        CType(Me.nudCoefficient, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvMatieres, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBoutonsClasse.SuspendLayout()
        Me.pnlBoutonsMatiere.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlToolbar
        '
        Me.pnlToolbar.BackColor = System.Drawing.Color.White
        Me.pnlToolbar.Controls.Add(Me.btnRetour)
        Me.pnlToolbar.Controls.Add(Me.btnNouvelleMatiere)
        Me.pnlToolbar.Controls.Add(Me.btnNouvelleClasse)
        Me.pnlToolbar.Controls.Add(Me.lblTitre)
        Me.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlToolbar.Location = New System.Drawing.Point(0, 0)
        Me.pnlToolbar.Name = "pnlToolbar"
        Me.pnlToolbar.Size = New System.Drawing.Size(933, 44)
        Me.pnlToolbar.TabIndex = 0
        '
        'btnNouvelleMatiere
        '
        Me.btnNouvelleMatiere.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNouvelleMatiere.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btnNouvelleMatiere.FlatAppearance.BorderSize = 0
        Me.btnNouvelleMatiere.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNouvelleMatiere.ForeColor = System.Drawing.Color.White
        Me.btnNouvelleMatiere.Location = New System.Drawing.Point(791, 8)
        Me.btnNouvelleMatiere.Name = "btnNouvelleMatiere"
        Me.btnNouvelleMatiere.Size = New System.Drawing.Size(90, 28)
        Me.btnNouvelleMatiere.TabIndex = 2
        Me.btnNouvelleMatiere.Text = "+ Matière"
        Me.btnNouvelleMatiere.UseVisualStyleBackColor = False
        '
        'btnNouvelleClasse
        '
        Me.btnNouvelleClasse.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNouvelleClasse.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.btnNouvelleClasse.FlatAppearance.BorderSize = 0
        Me.btnNouvelleClasse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNouvelleClasse.ForeColor = System.Drawing.Color.White
        Me.btnNouvelleClasse.Location = New System.Drawing.Point(695, 8)
        Me.btnNouvelleClasse.Name = "btnNouvelleClasse"
        Me.btnNouvelleClasse.Size = New System.Drawing.Size(90, 28)
        Me.btnNouvelleClasse.TabIndex = 1
        Me.btnNouvelleClasse.Text = "+ Classe"
        Me.btnNouvelleClasse.UseVisualStyleBackColor = False
        '
        'lblTitre
        '
        Me.lblTitre.AutoSize = True
        Me.lblTitre.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.lblTitre.Location = New System.Drawing.Point(106, 10)
        Me.lblTitre.Name = "lblTitre"
        Me.lblTitre.Size = New System.Drawing.Size(138, 21)
        Me.lblTitre.TabIndex = 0
        Me.lblTitre.Text = "Classes & Matières"
        '
        'splitPrincipal
        '
        Me.splitPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitPrincipal.Location = New System.Drawing.Point(0, 44)
        Me.splitPrincipal.Name = "splitPrincipal"
        '
        'splitPrincipal.Panel1
        '
        Me.splitPrincipal.Panel1.Controls.Add(Me.pnlBoutonsClasse)
        Me.splitPrincipal.Panel1.Controls.Add(Me.pnlFormClasse)
        Me.splitPrincipal.Panel1.Controls.Add(Me.dgvClasses)
        Me.splitPrincipal.Panel1.Controls.Add(Me.lblTitreClasses)
        '
        'splitPrincipal.Panel2
        '
        Me.splitPrincipal.Panel2.Controls.Add(Me.pnlBoutonsMatiere)
        Me.splitPrincipal.Panel2.Controls.Add(Me.pnlFormMatiere)
        Me.splitPrincipal.Panel2.Controls.Add(Me.dgvMatieres)
        Me.splitPrincipal.Panel2.Controls.Add(Me.lblTitreMatieres)
        Me.splitPrincipal.Size = New System.Drawing.Size(933, 475)
        Me.splitPrincipal.SplitterDistance = 447
        Me.splitPrincipal.TabIndex = 1
        '
        'pnlFormClasse
        '
        Me.pnlFormClasse.BackColor = System.Drawing.Color.White
        Me.pnlFormClasse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlFormClasse.Controls.Add(Me.txtFiliereClasse)
        Me.pnlFormClasse.Controls.Add(Me.Label3)
        Me.pnlFormClasse.Controls.Add(Me.txtLibelleClasse)
        Me.pnlFormClasse.Controls.Add(Me.Label2)
        Me.pnlFormClasse.Controls.Add(Me.txtCodeClasse)
        Me.pnlFormClasse.Controls.Add(Me.Label1)
        Me.pnlFormClasse.Controls.Add(Me.lblTitreFormClasse)
        Me.pnlFormClasse.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlFormClasse.Location = New System.Drawing.Point(0, 265)
        Me.pnlFormClasse.Name = "pnlFormClasse"
        Me.pnlFormClasse.Size = New System.Drawing.Size(447, 210)
        Me.pnlFormClasse.TabIndex = 2
        '
        'txtFiliereClasse
        '
        Me.txtFiliereClasse.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFiliereClasse.Location = New System.Drawing.Point(10, 144)
        Me.txtFiliereClasse.Name = "txtFiliereClasse"
        Me.txtFiliereClasse.Size = New System.Drawing.Size(290, 23)
        Me.txtFiliereClasse.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Filière"
        '
        'txtLibelleClasse
        '
        Me.txtLibelleClasse.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLibelleClasse.Location = New System.Drawing.Point(10, 96)
        Me.txtLibelleClasse.Name = "txtLibelleClasse"
        Me.txtLibelleClasse.Size = New System.Drawing.Size(290, 23)
        Me.txtLibelleClasse.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Libellé"
        '
        'txtCodeClasse
        '
        Me.txtCodeClasse.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCodeClasse.Location = New System.Drawing.Point(11, 48)
        Me.txtCodeClasse.Name = "txtCodeClasse"
        Me.txtCodeClasse.Size = New System.Drawing.Size(289, 23)
        Me.txtCodeClasse.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Code Classe"
        '
        'lblTitreFormClasse
        '
        Me.lblTitreFormClasse.AutoSize = True
        Me.lblTitreFormClasse.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitreFormClasse.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.lblTitreFormClasse.Location = New System.Drawing.Point(10, 8)
        Me.lblTitreFormClasse.Name = "lblTitreFormClasse"
        Me.lblTitreFormClasse.Size = New System.Drawing.Size(92, 15)
        Me.lblTitreFormClasse.TabIndex = 0
        Me.lblTitreFormClasse.Text = "Nouvelle classe"
        '
        'dgvClasses
        '
        Me.dgvClasses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvClasses.BackgroundColor = System.Drawing.Color.White
        Me.dgvClasses.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClasses.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colCodeClasse, Me.colLibelleClasse, Me.colFiliereClasse, Me.colActionsClasse})
        Me.dgvClasses.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvClasses.Location = New System.Drawing.Point(0, 17)
        Me.dgvClasses.MultiSelect = False
        Me.dgvClasses.Name = "dgvClasses"
        Me.dgvClasses.ReadOnly = True
        Me.dgvClasses.RowHeadersVisible = False
        Me.dgvClasses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvClasses.Size = New System.Drawing.Size(447, 458)
        Me.dgvClasses.TabIndex = 1
        '
        'colCodeClasse
        '
        Me.colCodeClasse.FillWeight = 30.0!
        Me.colCodeClasse.HeaderText = "Code"
        Me.colCodeClasse.Name = "colCodeClasse"
        Me.colCodeClasse.ReadOnly = True
        '
        'colLibelleClasse
        '
        Me.colLibelleClasse.FillWeight = 50.0!
        Me.colLibelleClasse.HeaderText = "Libellé"
        Me.colLibelleClasse.Name = "colLibelleClasse"
        Me.colLibelleClasse.ReadOnly = True
        '
        'colFiliereClasse
        '
        Me.colFiliereClasse.FillWeight = 40.0!
        Me.colFiliereClasse.HeaderText = "Filière"
        Me.colFiliereClasse.Name = "colFiliereClasse"
        Me.colFiliereClasse.ReadOnly = True
        '
        'colActionsClasse
        '
        Me.colActionsClasse.FillWeight = 30.0!
        Me.colActionsClasse.HeaderText = "Actions"
        Me.colActionsClasse.Name = "colActionsClasse"
        Me.colActionsClasse.ReadOnly = True
        '
        'lblTitreClasses
        '
        Me.lblTitreClasses.AutoSize = True
        Me.lblTitreClasses.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitreClasses.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitreClasses.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.lblTitreClasses.Location = New System.Drawing.Point(0, 0)
        Me.lblTitreClasses.Name = "lblTitreClasses"
        Me.lblTitreClasses.Size = New System.Drawing.Size(75, 17)
        Me.lblTitreClasses.TabIndex = 0
        Me.lblTitreClasses.Text = "📚 Classes"
        '
        'pnlFormMatiere
        '
        Me.pnlFormMatiere.BackColor = System.Drawing.Color.White
        Me.pnlFormMatiere.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlFormMatiere.Controls.Add(Me.nudCoefficient)
        Me.pnlFormMatiere.Controls.Add(Me.Label6)
        Me.pnlFormMatiere.Controls.Add(Me.txtLibelleMatiere)
        Me.pnlFormMatiere.Controls.Add(Me.Label5)
        Me.pnlFormMatiere.Controls.Add(Me.txtCodeMatiere)
        Me.pnlFormMatiere.Controls.Add(Me.Label4)
        Me.pnlFormMatiere.Controls.Add(Me.lblTitreFormMatiere)
        Me.pnlFormMatiere.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlFormMatiere.Location = New System.Drawing.Point(0, 265)
        Me.pnlFormMatiere.Name = "pnlFormMatiere"
        Me.pnlFormMatiere.Size = New System.Drawing.Size(482, 210)
        Me.pnlFormMatiere.TabIndex = 3
        '
        'nudCoefficient
        '
        Me.nudCoefficient.Location = New System.Drawing.Point(10, 144)
        Me.nudCoefficient.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudCoefficient.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudCoefficient.Name = "nudCoefficient"
        Me.nudCoefficient.Size = New System.Drawing.Size(80, 23)
        Me.nudCoefficient.TabIndex = 8
        Me.nudCoefficient.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 128)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 15)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Coefficient"
        '
        'txtLibelleMatiere
        '
        Me.txtLibelleMatiere.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLibelleMatiere.Location = New System.Drawing.Point(10, 96)
        Me.txtLibelleMatiere.Name = "txtLibelleMatiere"
        Me.txtLibelleMatiere.Size = New System.Drawing.Size(270, 23)
        Me.txtLibelleMatiere.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 15)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Libellé matière"
        '
        'txtCodeMatiere
        '
        Me.txtCodeMatiere.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCodeMatiere.Location = New System.Drawing.Point(10, 48)
        Me.txtCodeMatiere.Name = "txtCodeMatiere"
        Me.txtCodeMatiere.Size = New System.Drawing.Size(120, 23)
        Me.txtCodeMatiere.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Code matière"
        '
        'lblTitreFormMatiere
        '
        Me.lblTitreFormMatiere.AutoSize = True
        Me.lblTitreFormMatiere.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitreFormMatiere.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.lblTitreFormMatiere.Location = New System.Drawing.Point(10, 8)
        Me.lblTitreFormMatiere.Name = "lblTitreFormMatiere"
        Me.lblTitreFormMatiere.Size = New System.Drawing.Size(104, 15)
        Me.lblTitreFormMatiere.TabIndex = 2
        Me.lblTitreFormMatiere.Text = "Nouvelle matière"
        '
        'dgvMatieres
        '
        Me.dgvMatieres.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvMatieres.BackgroundColor = System.Drawing.Color.White
        Me.dgvMatieres.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvMatieres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMatieres.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colCodeMatiere, Me.colLibelleMatiere, Me.colCoef, Me.colActionsMatiere})
        Me.dgvMatieres.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvMatieres.Location = New System.Drawing.Point(0, 17)
        Me.dgvMatieres.MultiSelect = False
        Me.dgvMatieres.Name = "dgvMatieres"
        Me.dgvMatieres.ReadOnly = True
        Me.dgvMatieres.RowHeadersVisible = False
        Me.dgvMatieres.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMatieres.Size = New System.Drawing.Size(482, 458)
        Me.dgvMatieres.TabIndex = 1
        '
        'colCodeMatiere
        '
        Me.colCodeMatiere.FillWeight = 25.0!
        Me.colCodeMatiere.HeaderText = "Code"
        Me.colCodeMatiere.Name = "colCodeMatiere"
        Me.colCodeMatiere.ReadOnly = True
        '
        'colLibelleMatiere
        '
        Me.colLibelleMatiere.FillWeight = 45.0!
        Me.colLibelleMatiere.HeaderText = "Matière"
        Me.colLibelleMatiere.Name = "colLibelleMatiere"
        Me.colLibelleMatiere.ReadOnly = True
        '
        'colCoef
        '
        Me.colCoef.FillWeight = 20.0!
        Me.colCoef.HeaderText = "Coef."
        Me.colCoef.Name = "colCoef"
        Me.colCoef.ReadOnly = True
        '
        'colActionsMatiere
        '
        Me.colActionsMatiere.FillWeight = 30.0!
        Me.colActionsMatiere.HeaderText = "Actions"
        Me.colActionsMatiere.Name = "colActionsMatiere"
        Me.colActionsMatiere.ReadOnly = True
        '
        'lblTitreMatieres
        '
        Me.lblTitreMatieres.AutoSize = True
        Me.lblTitreMatieres.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitreMatieres.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitreMatieres.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.lblTitreMatieres.Location = New System.Drawing.Point(0, 0)
        Me.lblTitreMatieres.Name = "lblTitreMatieres"
        Me.lblTitreMatieres.Size = New System.Drawing.Size(268, 17)
        Me.lblTitreMatieres.TabIndex = 0
        Me.lblTitreMatieres.Text = "📖 Matières de : (sélectionnez une classe)"
        '
        'btnEnregistrerClasse
        '
        Me.btnEnregistrerClasse.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.btnEnregistrerClasse.FlatAppearance.BorderSize = 0
        Me.btnEnregistrerClasse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnregistrerClasse.ForeColor = System.Drawing.Color.White
        Me.btnEnregistrerClasse.Location = New System.Drawing.Point(10, 6)
        Me.btnEnregistrerClasse.Name = "btnEnregistrerClasse"
        Me.btnEnregistrerClasse.Size = New System.Drawing.Size(130, 30)
        Me.btnEnregistrerClasse.TabIndex = 5
        Me.btnEnregistrerClasse.Text = "Enregistrer"
        Me.btnEnregistrerClasse.UseVisualStyleBackColor = False
        '
        'btnSupprimerClasse
        '
        Me.btnSupprimerClasse.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnSupprimerClasse.FlatAppearance.BorderSize = 0
        Me.btnSupprimerClasse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSupprimerClasse.ForeColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnSupprimerClasse.Location = New System.Drawing.Point(154, 6)
        Me.btnSupprimerClasse.Name = "btnSupprimerClasse"
        Me.btnSupprimerClasse.Size = New System.Drawing.Size(130, 30)
        Me.btnSupprimerClasse.TabIndex = 6
        Me.btnSupprimerClasse.Text = "Supprimer"
        Me.btnSupprimerClasse.UseVisualStyleBackColor = False
        '
        'btnEnregistrerMatiere
        '
        Me.btnEnregistrerMatiere.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.btnEnregistrerMatiere.FlatAppearance.BorderSize = 0
        Me.btnEnregistrerMatiere.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnregistrerMatiere.ForeColor = System.Drawing.Color.White
        Me.btnEnregistrerMatiere.Location = New System.Drawing.Point(10, 6)
        Me.btnEnregistrerMatiere.Name = "btnEnregistrerMatiere"
        Me.btnEnregistrerMatiere.Size = New System.Drawing.Size(130, 30)
        Me.btnEnregistrerMatiere.TabIndex = 6
        Me.btnEnregistrerMatiere.Text = "Enregistrer"
        Me.btnEnregistrerMatiere.UseVisualStyleBackColor = False
        '
        'btnSupprimerMatiere
        '
        Me.btnSupprimerMatiere.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnSupprimerMatiere.FlatAppearance.BorderSize = 0
        Me.btnSupprimerMatiere.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSupprimerMatiere.ForeColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnSupprimerMatiere.Location = New System.Drawing.Point(154, 6)
        Me.btnSupprimerMatiere.Name = "btnSupprimerMatiere"
        Me.btnSupprimerMatiere.Size = New System.Drawing.Size(130, 30)
        Me.btnSupprimerMatiere.TabIndex = 7
        Me.btnSupprimerMatiere.Text = "Supprimer"
        Me.btnSupprimerMatiere.UseVisualStyleBackColor = False
        '
        'pnlBoutonsClasse
        '
        Me.pnlBoutonsClasse.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.pnlBoutonsClasse.Controls.Add(Me.btnEnregistrerClasse)
        Me.pnlBoutonsClasse.Controls.Add(Me.btnSupprimerClasse)
        Me.pnlBoutonsClasse.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBoutonsClasse.Location = New System.Drawing.Point(0, 221)
        Me.pnlBoutonsClasse.Name = "pnlBoutonsClasse"
        Me.pnlBoutonsClasse.Size = New System.Drawing.Size(447, 44)
        Me.pnlBoutonsClasse.TabIndex = 7
        '
        'pnlBoutonsMatiere
        '
        Me.pnlBoutonsMatiere.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.pnlBoutonsMatiere.Controls.Add(Me.btnEnregistrerMatiere)
        Me.pnlBoutonsMatiere.Controls.Add(Me.btnSupprimerMatiere)
        Me.pnlBoutonsMatiere.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBoutonsMatiere.Location = New System.Drawing.Point(0, 221)
        Me.pnlBoutonsMatiere.Name = "pnlBoutonsMatiere"
        Me.pnlBoutonsMatiere.Size = New System.Drawing.Size(482, 44)
        Me.pnlBoutonsMatiere.TabIndex = 8
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
        'FormClasses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(933, 519)
        Me.Controls.Add(Me.splitPrincipal)
        Me.Controls.Add(Me.pnlToolbar)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "FormClasses"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Classes & Matières"
        Me.pnlToolbar.ResumeLayout(False)
        Me.pnlToolbar.PerformLayout()
        Me.splitPrincipal.Panel1.ResumeLayout(False)
        Me.splitPrincipal.Panel1.PerformLayout()
        Me.splitPrincipal.Panel2.ResumeLayout(False)
        Me.splitPrincipal.Panel2.PerformLayout()
        CType(Me.splitPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitPrincipal.ResumeLayout(False)
        Me.pnlFormClasse.ResumeLayout(False)
        Me.pnlFormClasse.PerformLayout()
        CType(Me.dgvClasses, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFormMatiere.ResumeLayout(False)
        Me.pnlFormMatiere.PerformLayout()
        CType(Me.nudCoefficient, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvMatieres, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBoutonsClasse.ResumeLayout(False)
        Me.pnlBoutonsMatiere.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlToolbar As Panel
    Friend WithEvents lblTitre As Label
    Friend WithEvents btnNouvelleClasse As Button
    Friend WithEvents btnNouvelleMatiere As Button
    Friend WithEvents splitPrincipal As SplitContainer
    Friend WithEvents lblTitreClasses As Label
    Friend WithEvents dgvClasses As DataGridView
    Friend WithEvents colCodeClasse As DataGridViewTextBoxColumn
    Friend WithEvents colLibelleClasse As DataGridViewTextBoxColumn
    Friend WithEvents colFiliereClasse As DataGridViewTextBoxColumn
    Friend WithEvents colActionsClasse As DataGridViewTextBoxColumn
    Friend WithEvents pnlFormClasse As Panel
    Friend WithEvents lblTitreFormClasse As Label
    Friend WithEvents txtCodeClasse As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtLibelleClasse As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtFiliereClasse As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dgvMatieres As DataGridView
    Friend WithEvents lblTitreMatieres As Label
    Friend WithEvents lblTitreFormMatiere As Label
    Friend WithEvents colCodeMatiere As DataGridViewTextBoxColumn
    Friend WithEvents colLibelleMatiere As DataGridViewTextBoxColumn
    Friend WithEvents colCoef As DataGridViewTextBoxColumn
    Friend WithEvents colActionsMatiere As DataGridViewTextBoxColumn
    Friend WithEvents pnlFormMatiere As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCodeMatiere As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtLibelleMatiere As TextBox
    Friend WithEvents nudCoefficient As NumericUpDown
    Friend WithEvents btnSupprimerClasse As Button
    Friend WithEvents btnEnregistrerClasse As Button
    Friend WithEvents btnSupprimerMatiere As Button
    Friend WithEvents btnEnregistrerMatiere As Button
    Friend WithEvents pnlBoutonsClasse As Panel
    Friend WithEvents pnlBoutonsMatiere As Panel
    Friend WithEvents btnRetour As Button
End Class
