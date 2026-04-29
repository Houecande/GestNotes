<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPrincipal
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlSidebar = New System.Windows.Forms.Panel()
        Me.btnDeconnexion = New System.Windows.Forms.Button()
        Me.btnMenuParametres = New System.Windows.Forms.Button()
        Me.lblSectAdmin = New System.Windows.Forms.Label()
        Me.btnMenuImpressions = New System.Windows.Forms.Button()
        Me.lblSectEdition = New System.Windows.Forms.Label()
        Me.btnMenuNotes = New System.Windows.Forms.Button()
        Me.lblSectSaisie = New System.Windows.Forms.Label()
        Me.btnMenuClasses = New System.Windows.Forms.Button()
        Me.lblSectGestion = New System.Windows.Forms.Label()
        Me.btnMenuEtudiants = New System.Windows.Forms.Button()
        Me.btnMenuDashboard = New System.Windows.Forms.Button()
        Me.sep2 = New System.Windows.Forms.Panel()
        Me.lblRole = New System.Windows.Forms.Label()
        Me.lblUtilisateur = New System.Windows.Forms.Label()
        Me.plvAvatar = New System.Windows.Forms.Panel()
        Me.sep1 = New System.Windows.Forms.Panel()
        Me.lblAnnee = New System.Windows.Forms.Label()
        Me.lblAppNom = New System.Windows.Forms.Label()
        Me.pnlLogo = New System.Windows.Forms.Panel()
        Me.lblLogoText = New System.Windows.Forms.Label()
        Me.pnlTopBar = New System.Windows.Forms.Panel()
        Me.lblInfoConnexion = New System.Windows.Forms.Label()
        Me.lblPageTitle = New System.Windows.Forms.Label()
        Me.pnlContenu = New System.Windows.Forms.Panel()
        Me.dgvDerniersSaisies = New System.Windows.Forms.DataGridView()
        Me.flpStats = New System.Windows.Forms.FlowLayoutPanel()
        Me.pnlStatEtudiants = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlStatMatieres = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pnlStatNotes = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pnlStatBulletins = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.pnlSidebar.SuspendLayout()
        Me.pnlLogo.SuspendLayout()
        Me.pnlTopBar.SuspendLayout()
        Me.pnlContenu.SuspendLayout()
        CType(Me.dgvDerniersSaisies, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.flpStats.SuspendLayout()
        Me.pnlStatEtudiants.SuspendLayout()
        Me.pnlStatMatieres.SuspendLayout()
        Me.pnlStatNotes.SuspendLayout()
        Me.pnlStatBulletins.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlSidebar
        '
        Me.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.pnlSidebar.Controls.Add(Me.btnDeconnexion)
        Me.pnlSidebar.Controls.Add(Me.btnMenuParametres)
        Me.pnlSidebar.Controls.Add(Me.lblSectAdmin)
        Me.pnlSidebar.Controls.Add(Me.btnMenuImpressions)
        Me.pnlSidebar.Controls.Add(Me.lblSectEdition)
        Me.pnlSidebar.Controls.Add(Me.btnMenuNotes)
        Me.pnlSidebar.Controls.Add(Me.lblSectSaisie)
        Me.pnlSidebar.Controls.Add(Me.btnMenuClasses)
        Me.pnlSidebar.Controls.Add(Me.lblSectGestion)
        Me.pnlSidebar.Controls.Add(Me.btnMenuEtudiants)
        Me.pnlSidebar.Controls.Add(Me.btnMenuDashboard)
        Me.pnlSidebar.Controls.Add(Me.sep2)
        Me.pnlSidebar.Controls.Add(Me.lblRole)
        Me.pnlSidebar.Controls.Add(Me.lblUtilisateur)
        Me.pnlSidebar.Controls.Add(Me.plvAvatar)
        Me.pnlSidebar.Controls.Add(Me.sep1)
        Me.pnlSidebar.Controls.Add(Me.lblAnnee)
        Me.pnlSidebar.Controls.Add(Me.lblAppNom)
        Me.pnlSidebar.Controls.Add(Me.pnlLogo)
        Me.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSidebar.Location = New System.Drawing.Point(0, 0)
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Size = New System.Drawing.Size(200, 705)
        Me.pnlSidebar.TabIndex = 0
        '
        'btnDeconnexion
        '
        Me.btnDeconnexion.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnDeconnexion.FlatAppearance.BorderSize = 0
        Me.btnDeconnexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeconnexion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(133, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnDeconnexion.Location = New System.Drawing.Point(0, 669)
        Me.btnDeconnexion.Name = "btnDeconnexion"
        Me.btnDeconnexion.Size = New System.Drawing.Size(200, 36)
        Me.btnDeconnexion.TabIndex = 16
        Me.btnDeconnexion.Text = "Deconnexion"
        Me.btnDeconnexion.UseVisualStyleBackColor = True
        '
        'btnMenuParametres
        '
        Me.btnMenuParametres.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMenuParametres.FlatAppearance.BorderSize = 0
        Me.btnMenuParametres.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenuParametres.Location = New System.Drawing.Point(0, 416)
        Me.btnMenuParametres.Name = "btnMenuParametres"
        Me.btnMenuParametres.Size = New System.Drawing.Size(200, 38)
        Me.btnMenuParametres.TabIndex = 15
        Me.btnMenuParametres.Text = "⚙️  Paramètres"
        Me.btnMenuParametres.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMenuParametres.UseVisualStyleBackColor = True
        '
        'lblSectAdmin
        '
        Me.lblSectAdmin.AutoSize = True
        Me.lblSectAdmin.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSectAdmin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(133, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.lblSectAdmin.Location = New System.Drawing.Point(0, 396)
        Me.lblSectAdmin.Name = "lblSectAdmin"
        Me.lblSectAdmin.Size = New System.Drawing.Size(34, 12)
        Me.lblSectAdmin.TabIndex = 14
        Me.lblSectAdmin.Text = "ADMIN"
        '
        'btnMenuImpressions
        '
        Me.btnMenuImpressions.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMenuImpressions.FlatAppearance.BorderSize = 0
        Me.btnMenuImpressions.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenuImpressions.Location = New System.Drawing.Point(0, 352)
        Me.btnMenuImpressions.Name = "btnMenuImpressions"
        Me.btnMenuImpressions.Size = New System.Drawing.Size(200, 38)
        Me.btnMenuImpressions.TabIndex = 13
        Me.btnMenuImpressions.Text = "🖨️  Impressions"
        Me.btnMenuImpressions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMenuImpressions.UseVisualStyleBackColor = True
        '
        'lblSectEdition
        '
        Me.lblSectEdition.AutoSize = True
        Me.lblSectEdition.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSectEdition.ForeColor = System.Drawing.Color.FromArgb(CType(CType(133, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.lblSectEdition.Location = New System.Drawing.Point(0, 332)
        Me.lblSectEdition.Name = "lblSectEdition"
        Me.lblSectEdition.Size = New System.Drawing.Size(39, 12)
        Me.lblSectEdition.TabIndex = 12
        Me.lblSectEdition.Text = "ÉDITION"
        '
        'btnMenuNotes
        '
        Me.btnMenuNotes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMenuNotes.FlatAppearance.BorderSize = 0
        Me.btnMenuNotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenuNotes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMenuNotes.Location = New System.Drawing.Point(0, 288)
        Me.btnMenuNotes.Name = "btnMenuNotes"
        Me.btnMenuNotes.Size = New System.Drawing.Size(200, 38)
        Me.btnMenuNotes.TabIndex = 11
        Me.btnMenuNotes.Text = "📝  Notes"
        Me.btnMenuNotes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMenuNotes.UseVisualStyleBackColor = True
        '
        'lblSectSaisie
        '
        Me.lblSectSaisie.AutoSize = True
        Me.lblSectSaisie.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSectSaisie.ForeColor = System.Drawing.Color.FromArgb(CType(CType(133, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.lblSectSaisie.Location = New System.Drawing.Point(0, 268)
        Me.lblSectSaisie.Name = "lblSectSaisie"
        Me.lblSectSaisie.Size = New System.Drawing.Size(30, 12)
        Me.lblSectSaisie.TabIndex = 1
        Me.lblSectSaisie.Text = "SAISIE"
        '
        'btnMenuClasses
        '
        Me.btnMenuClasses.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMenuClasses.FlatAppearance.BorderSize = 0
        Me.btnMenuClasses.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenuClasses.Location = New System.Drawing.Point(0, 224)
        Me.btnMenuClasses.Name = "btnMenuClasses"
        Me.btnMenuClasses.Size = New System.Drawing.Size(200, 38)
        Me.btnMenuClasses.TabIndex = 10
        Me.btnMenuClasses.Text = "🏫  Classes / Matières"
        Me.btnMenuClasses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMenuClasses.UseVisualStyleBackColor = True
        '
        'lblSectGestion
        '
        Me.lblSectGestion.AutoSize = True
        Me.lblSectGestion.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSectGestion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(133, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.lblSectGestion.Location = New System.Drawing.Point(0, 162)
        Me.lblSectGestion.Name = "lblSectGestion"
        Me.lblSectGestion.Size = New System.Drawing.Size(42, 12)
        Me.lblSectGestion.TabIndex = 9
        Me.lblSectGestion.Text = "GESTION"
        Me.lblSectGestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnMenuEtudiants
        '
        Me.btnMenuEtudiants.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMenuEtudiants.FlatAppearance.BorderSize = 0
        Me.btnMenuEtudiants.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenuEtudiants.Location = New System.Drawing.Point(0, 182)
        Me.btnMenuEtudiants.Name = "btnMenuEtudiants"
        Me.btnMenuEtudiants.Size = New System.Drawing.Size(200, 38)
        Me.btnMenuEtudiants.TabIndex = 8
        Me.btnMenuEtudiants.Text = "👤  Étudiants"
        Me.btnMenuEtudiants.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMenuEtudiants.UseVisualStyleBackColor = True
        '
        'btnMenuDashboard
        '
        Me.btnMenuDashboard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMenuDashboard.FlatAppearance.BorderSize = 0
        Me.btnMenuDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenuDashboard.Location = New System.Drawing.Point(0, 118)
        Me.btnMenuDashboard.Name = "btnMenuDashboard"
        Me.btnMenuDashboard.Size = New System.Drawing.Size(200, 38)
        Me.btnMenuDashboard.TabIndex = 7
        Me.btnMenuDashboard.Text = "📊  Tableau de bord"
        Me.btnMenuDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMenuDashboard.UseVisualStyleBackColor = True
        '
        'sep2
        '
        Me.sep2.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.sep2.Location = New System.Drawing.Point(0, 108)
        Me.sep2.Name = "sep2"
        Me.sep2.Size = New System.Drawing.Size(200, 1)
        Me.sep2.TabIndex = 6
        '
        'lblRole
        '
        Me.lblRole.AutoSize = True
        Me.lblRole.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRole.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.lblRole.Location = New System.Drawing.Point(46, 88)
        Me.lblRole.Name = "lblRole"
        Me.lblRole.Size = New System.Drawing.Size(79, 13)
        Me.lblRole.TabIndex = 5
        Me.lblRole.Text = "Accès complet"
        '
        'lblUtilisateur
        '
        Me.lblUtilisateur.AutoSize = True
        Me.lblUtilisateur.ForeColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.lblUtilisateur.Location = New System.Drawing.Point(46, 72)
        Me.lblUtilisateur.Name = "lblUtilisateur"
        Me.lblUtilisateur.Size = New System.Drawing.Size(86, 15)
        Me.lblUtilisateur.TabIndex = 4
        Me.lblUtilisateur.Text = "Administrateur"
        '
        'plvAvatar
        '
        Me.plvAvatar.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.plvAvatar.Location = New System.Drawing.Point(10, 72)
        Me.plvAvatar.Name = "plvAvatar"
        Me.plvAvatar.Size = New System.Drawing.Size(28, 28)
        Me.plvAvatar.TabIndex = 3
        '
        'sep1
        '
        Me.sep1.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.sep1.Location = New System.Drawing.Point(0, 62)
        Me.sep1.Name = "sep1"
        Me.sep1.Size = New System.Drawing.Size(200, 1)
        Me.sep1.TabIndex = 2
        '
        'lblAnnee
        '
        Me.lblAnnee.AutoSize = True
        Me.lblAnnee.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnnee.ForeColor = System.Drawing.Color.FromArgb(CType(CType(133, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.lblAnnee.Location = New System.Drawing.Point(54, 34)
        Me.lblAnnee.Name = "lblAnnee"
        Me.lblAnnee.Size = New System.Drawing.Size(59, 13)
        Me.lblAnnee.TabIndex = 1
        Me.lblAnnee.Text = "2025-2026"
        '
        'lblAppNom
        '
        Me.lblAppNom.AutoSize = True
        Me.lblAppNom.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAppNom.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.lblAppNom.Location = New System.Drawing.Point(54, 14)
        Me.lblAppNom.Name = "lblAppNom"
        Me.lblAppNom.Size = New System.Drawing.Size(137, 20)
        Me.lblAppNom.TabIndex = 1
        Me.lblAppNom.Text = "Gestion des Notes"
        '
        'pnlLogo
        '
        Me.pnlLogo.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.pnlLogo.Controls.Add(Me.lblLogoText)
        Me.pnlLogo.Location = New System.Drawing.Point(10, 14)
        Me.pnlLogo.Name = "pnlLogo"
        Me.pnlLogo.Size = New System.Drawing.Size(36, 36)
        Me.pnlLogo.TabIndex = 0
        '
        'lblLogoText
        '
        Me.lblLogoText.AutoSize = True
        Me.lblLogoText.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogoText.ForeColor = System.Drawing.Color.White
        Me.lblLogoText.Location = New System.Drawing.Point(3, 8)
        Me.lblLogoText.Name = "lblLogoText"
        Me.lblLogoText.Size = New System.Drawing.Size(32, 20)
        Me.lblLogoText.TabIndex = 1
        Me.lblLogoText.Text = "GN"
        '
        'pnlTopBar
        '
        Me.pnlTopBar.BackColor = System.Drawing.Color.White
        Me.pnlTopBar.Controls.Add(Me.lblInfoConnexion)
        Me.pnlTopBar.Controls.Add(Me.lblPageTitle)
        Me.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTopBar.Location = New System.Drawing.Point(200, 0)
        Me.pnlTopBar.Name = "pnlTopBar"
        Me.pnlTopBar.Size = New System.Drawing.Size(976, 44)
        Me.pnlTopBar.TabIndex = 1
        '
        'lblInfoConnexion
        '
        Me.lblInfoConnexion.AutoSize = True
        Me.lblInfoConnexion.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblInfoConnexion.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfoConnexion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblInfoConnexion.Location = New System.Drawing.Point(823, 0)
        Me.lblInfoConnexion.Name = "lblInfoConnexion"
        Me.lblInfoConnexion.Padding = New System.Windows.Forms.Padding(0, 0, 12, 0)
        Me.lblInfoConnexion.Size = New System.Drawing.Size(153, 13)
        Me.lblInfoConnexion.TabIndex = 1
        Me.lblInfoConnexion.Text = "Connecté : Administrateur"
        Me.lblInfoConnexion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPageTitle
        '
        Me.lblPageTitle.AutoSize = True
        Me.lblPageTitle.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPageTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.lblPageTitle.Location = New System.Drawing.Point(16, 10)
        Me.lblPageTitle.Name = "lblPageTitle"
        Me.lblPageTitle.Size = New System.Drawing.Size(141, 23)
        Me.lblPageTitle.TabIndex = 0
        Me.lblPageTitle.Text = "Tableau de bord"
        '
        'pnlContenu
        '
        Me.pnlContenu.BackColor = System.Drawing.Color.Transparent
        Me.pnlContenu.Controls.Add(Me.dgvDerniersSaisies)
        Me.pnlContenu.Controls.Add(Me.flpStats)
        Me.pnlContenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContenu.Location = New System.Drawing.Point(200, 44)
        Me.pnlContenu.Name = "pnlContenu"
        Me.pnlContenu.Padding = New System.Windows.Forms.Padding(14)
        Me.pnlContenu.Size = New System.Drawing.Size(976, 661)
        Me.pnlContenu.TabIndex = 2
        '
        'dgvDerniersSaisies
        '
        Me.dgvDerniersSaisies.AllowUserToAddRows = False
        Me.dgvDerniersSaisies.BackgroundColor = System.Drawing.Color.White
        Me.dgvDerniersSaisies.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(251, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDerniersSaisies.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDerniersSaisies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDerniersSaisies.Location = New System.Drawing.Point(0, 100)
        Me.dgvDerniersSaisies.Name = "dgvDerniersSaisies"
        Me.dgvDerniersSaisies.RowHeadersVisible = False
        Me.dgvDerniersSaisies.Size = New System.Drawing.Size(680, 200)
        Me.dgvDerniersSaisies.TabIndex = 1
        '
        'flpStats
        '
        Me.flpStats.Controls.Add(Me.pnlStatEtudiants)
        Me.flpStats.Controls.Add(Me.pnlStatMatieres)
        Me.flpStats.Controls.Add(Me.pnlStatNotes)
        Me.flpStats.Controls.Add(Me.pnlStatBulletins)
        Me.flpStats.Location = New System.Drawing.Point(0, 0)
        Me.flpStats.Name = "flpStats"
        Me.flpStats.Size = New System.Drawing.Size(680, 90)
        Me.flpStats.TabIndex = 0
        Me.flpStats.WrapContents = False
        '
        'pnlStatEtudiants
        '
        Me.pnlStatEtudiants.BackColor = System.Drawing.Color.White
        Me.pnlStatEtudiants.Controls.Add(Me.Label2)
        Me.pnlStatEtudiants.Controls.Add(Me.Label1)
        Me.pnlStatEtudiants.Location = New System.Drawing.Point(0, 0)
        Me.pnlStatEtudiants.Margin = New System.Windows.Forms.Padding(0, 0, 8, 0)
        Me.pnlStatEtudiants.Name = "pnlStatEtudiants"
        Me.pnlStatEtudiants.Padding = New System.Windows.Forms.Padding(10)
        Me.pnlStatEtudiants.Size = New System.Drawing.Size(160, 78)
        Me.pnlStatEtudiants.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(56, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Label2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(28, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1"
        '
        'pnlStatMatieres
        '
        Me.pnlStatMatieres.BackColor = System.Drawing.Color.White
        Me.pnlStatMatieres.Controls.Add(Me.Label3)
        Me.pnlStatMatieres.Controls.Add(Me.Label4)
        Me.pnlStatMatieres.Location = New System.Drawing.Point(168, 0)
        Me.pnlStatMatieres.Margin = New System.Windows.Forms.Padding(0, 0, 8, 0)
        Me.pnlStatMatieres.Name = "pnlStatMatieres"
        Me.pnlStatMatieres.Padding = New System.Windows.Forms.Padding(10)
        Me.pnlStatMatieres.Size = New System.Drawing.Size(160, 78)
        Me.pnlStatMatieres.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(56, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(28, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 32)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Label4"
        '
        'pnlStatNotes
        '
        Me.pnlStatNotes.BackColor = System.Drawing.Color.White
        Me.pnlStatNotes.Controls.Add(Me.Label5)
        Me.pnlStatNotes.Controls.Add(Me.Label6)
        Me.pnlStatNotes.Location = New System.Drawing.Point(336, 0)
        Me.pnlStatNotes.Margin = New System.Windows.Forms.Padding(0, 0, 8, 0)
        Me.pnlStatNotes.Name = "pnlStatNotes"
        Me.pnlStatNotes.Padding = New System.Windows.Forms.Padding(10)
        Me.pnlStatNotes.Size = New System.Drawing.Size(160, 78)
        Me.pnlStatNotes.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(56, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Label5"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(28, 3)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 32)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Label6"
        '
        'pnlStatBulletins
        '
        Me.pnlStatBulletins.BackColor = System.Drawing.Color.White
        Me.pnlStatBulletins.Controls.Add(Me.Label7)
        Me.pnlStatBulletins.Controls.Add(Me.Label8)
        Me.pnlStatBulletins.Location = New System.Drawing.Point(504, 0)
        Me.pnlStatBulletins.Margin = New System.Windows.Forms.Padding(0, 0, 8, 0)
        Me.pnlStatBulletins.Name = "pnlStatBulletins"
        Me.pnlStatBulletins.Padding = New System.Windows.Forms.Padding(10)
        Me.pnlStatBulletins.Size = New System.Drawing.Size(160, 78)
        Me.pnlStatBulletins.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(56, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Label7"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(28, 3)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 32)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Label8"
        '
        'FormPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1176, 705)
        Me.Controls.Add(Me.pnlContenu)
        Me.Controls.Add(Me.pnlTopBar)
        Me.Controls.Add(Me.pnlSidebar)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MinimumSize = New System.Drawing.Size(1047, 686)
        Me.Name = "FormPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GestNotes — Tableau de bord"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlSidebar.ResumeLayout(False)
        Me.pnlSidebar.PerformLayout()
        Me.pnlLogo.ResumeLayout(False)
        Me.pnlLogo.PerformLayout()
        Me.pnlTopBar.ResumeLayout(False)
        Me.pnlTopBar.PerformLayout()
        Me.pnlContenu.ResumeLayout(False)
        CType(Me.dgvDerniersSaisies, System.ComponentModel.ISupportInitialize).EndInit()
        Me.flpStats.ResumeLayout(False)
        Me.pnlStatEtudiants.ResumeLayout(False)
        Me.pnlStatEtudiants.PerformLayout()
        Me.pnlStatMatieres.ResumeLayout(False)
        Me.pnlStatMatieres.PerformLayout()
        Me.pnlStatNotes.ResumeLayout(False)
        Me.pnlStatNotes.PerformLayout()
        Me.pnlStatBulletins.ResumeLayout(False)
        Me.pnlStatBulletins.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents pnlLogo As Panel
    Friend WithEvents lblLogoText As Label
    Friend WithEvents lblAppNom As Label
    Friend WithEvents lblAnnee As Label
    Friend WithEvents sep1 As Panel
    Friend WithEvents plvAvatar As Panel
    Friend WithEvents lblRole As Label
    Friend WithEvents lblUtilisateur As Label
    Friend WithEvents btnMenuDashboard As Button
    Friend WithEvents sep2 As Panel
    Friend WithEvents btnMenuEtudiants As Button
    Friend WithEvents lblSectSaisie As Label
    Friend WithEvents btnMenuClasses As Button
    Friend WithEvents lblSectGestion As Label
    Friend WithEvents btnMenuParametres As Button
    Friend WithEvents lblSectAdmin As Label
    Friend WithEvents btnMenuImpressions As Button
    Friend WithEvents lblSectEdition As Label
    Friend WithEvents btnMenuNotes As Button
    Friend WithEvents btnDeconnexion As Button
    Friend WithEvents pnlTopBar As Panel
    Friend WithEvents lblPageTitle As Label
    Friend WithEvents lblInfoConnexion As Label
    Friend WithEvents pnlContenu As Panel
    Friend WithEvents flpStats As FlowLayoutPanel
    Friend WithEvents pnlStatEtudiants As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents pnlStatMatieres As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents pnlStatNotes As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents pnlStatBulletins As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents dgvDerniersSaisies As DataGridView
End Class
