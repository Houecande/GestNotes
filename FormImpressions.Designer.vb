<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormImpressions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormImpressions))
        Me.pnlToolbar = New System.Windows.Forms.Panel()
        Me.cmbTypeDoc = New System.Windows.Forms.ComboBox()
        Me.lblTitre = New System.Windows.Forms.Label()
        Me.pnlFiltres = New System.Windows.Forms.Panel()
        Me.pnlInfoNote = New System.Windows.Forms.Panel()
        Me.btnExporterPDF = New System.Windows.Forms.Button()
        Me.btnImprimer = New System.Windows.Forms.Button()
        Me.btnApercu = New System.Windows.Forms.Button()
        Me.lblSectActions = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtAnneeScolaire = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbClasseImp = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblSectFiltres = New System.Windows.Forms.Label()
        Me.pnlApercu = New System.Windows.Forms.Panel()
        Me.rbtApercu = New System.Windows.Forms.RichTextBox()
        Me.btnRetour = New System.Windows.Forms.Button()
        Me.sepRetour = New System.Windows.Forms.Panel()
        Me.pnlToolbar.SuspendLayout()
        Me.pnlFiltres.SuspendLayout()
        Me.pnlApercu.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlToolbar
        '
        Me.pnlToolbar.BackColor = System.Drawing.Color.White
        Me.pnlToolbar.Controls.Add(Me.sepRetour)
        Me.pnlToolbar.Controls.Add(Me.btnRetour)
        Me.pnlToolbar.Controls.Add(Me.cmbTypeDoc)
        Me.pnlToolbar.Controls.Add(Me.lblTitre)
        Me.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlToolbar.Location = New System.Drawing.Point(0, 0)
        Me.pnlToolbar.Name = "pnlToolbar"
        Me.pnlToolbar.Size = New System.Drawing.Size(933, 44)
        Me.pnlToolbar.TabIndex = 0
        '
        'cmbTypeDoc
        '
        Me.cmbTypeDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTypeDoc.FormattingEnabled = True
        Me.cmbTypeDoc.Items.AddRange(New Object() {"Bulletins individuels ", "Relevé collectif (ordre de mérite)"})
        Me.cmbTypeDoc.Location = New System.Drawing.Point(213, 8)
        Me.cmbTypeDoc.Name = "cmbTypeDoc"
        Me.cmbTypeDoc.Size = New System.Drawing.Size(200, 23)
        Me.cmbTypeDoc.TabIndex = 1
        '
        'lblTitre
        '
        Me.lblTitre.AutoSize = True
        Me.lblTitre.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.lblTitre.Location = New System.Drawing.Point(106, 10)
        Me.lblTitre.Name = "lblTitre"
        Me.lblTitre.Size = New System.Drawing.Size(101, 21)
        Me.lblTitre.TabIndex = 0
        Me.lblTitre.Text = "Impressions"
        '
        'pnlFiltres
        '
        Me.pnlFiltres.BackColor = System.Drawing.Color.White
        Me.pnlFiltres.Controls.Add(Me.pnlInfoNote)
        Me.pnlFiltres.Controls.Add(Me.btnExporterPDF)
        Me.pnlFiltres.Controls.Add(Me.btnImprimer)
        Me.pnlFiltres.Controls.Add(Me.btnApercu)
        Me.pnlFiltres.Controls.Add(Me.lblSectActions)
        Me.pnlFiltres.Controls.Add(Me.Panel2)
        Me.pnlFiltres.Controls.Add(Me.txtAnneeScolaire)
        Me.pnlFiltres.Controls.Add(Me.Label3)
        Me.pnlFiltres.Controls.Add(Me.ComboBox1)
        Me.pnlFiltres.Controls.Add(Me.Label2)
        Me.pnlFiltres.Controls.Add(Me.cmbClasseImp)
        Me.pnlFiltres.Controls.Add(Me.Label1)
        Me.pnlFiltres.Controls.Add(Me.Panel1)
        Me.pnlFiltres.Controls.Add(Me.lblSectFiltres)
        Me.pnlFiltres.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlFiltres.Location = New System.Drawing.Point(0, 44)
        Me.pnlFiltres.Name = "pnlFiltres"
        Me.pnlFiltres.Padding = New System.Windows.Forms.Padding(12)
        Me.pnlFiltres.Size = New System.Drawing.Size(235, 475)
        Me.pnlFiltres.TabIndex = 1
        '
        'pnlInfoNote
        '
        Me.pnlInfoNote.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.pnlInfoNote.Location = New System.Drawing.Point(12, 370)
        Me.pnlInfoNote.Name = "pnlInfoNote"
        Me.pnlInfoNote.Size = New System.Drawing.Size(200, 100)
        Me.pnlInfoNote.TabIndex = 13
        '
        'btnExporterPDF
        '
        Me.btnExporterPDF.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnExporterPDF.FlatAppearance.BorderSize = 0
        Me.btnExporterPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExporterPDF.ForeColor = System.Drawing.Color.White
        Me.btnExporterPDF.Location = New System.Drawing.Point(12, 308)
        Me.btnExporterPDF.Name = "btnExporterPDF"
        Me.btnExporterPDF.Size = New System.Drawing.Size(196, 34)
        Me.btnExporterPDF.TabIndex = 12
        Me.btnExporterPDF.Text = "📄 Exporter PDF"
        Me.btnExporterPDF.UseVisualStyleBackColor = False
        '
        'btnImprimer
        '
        Me.btnImprimer.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btnImprimer.FlatAppearance.BorderSize = 0
        Me.btnImprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimer.ForeColor = System.Drawing.Color.White
        Me.btnImprimer.Location = New System.Drawing.Point(12, 268)
        Me.btnImprimer.Name = "btnImprimer"
        Me.btnImprimer.Size = New System.Drawing.Size(196, 34)
        Me.btnImprimer.TabIndex = 11
        Me.btnImprimer.Text = "🖨️ Imprimer"
        Me.btnImprimer.UseVisualStyleBackColor = False
        '
        'btnApercu
        '
        Me.btnApercu.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.btnApercu.FlatAppearance.BorderSize = 0
        Me.btnApercu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApercu.ForeColor = System.Drawing.Color.White
        Me.btnApercu.Location = New System.Drawing.Point(12, 228)
        Me.btnApercu.Name = "btnApercu"
        Me.btnApercu.Size = New System.Drawing.Size(196, 34)
        Me.btnApercu.TabIndex = 10
        Me.btnApercu.Text = "👁️ Aperçu"
        Me.btnApercu.UseVisualStyleBackColor = False
        '
        'lblSectActions
        '
        Me.lblSectActions.AutoSize = True
        Me.lblSectActions.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSectActions.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.lblSectActions.Location = New System.Drawing.Point(12, 200)
        Me.lblSectActions.Name = "lblSectActions"
        Me.lblSectActions.Size = New System.Drawing.Size(48, 15)
        Me.lblSectActions.TabIndex = 9
        Me.lblSectActions.Text = "Actions"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(12, 218)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(196, 1)
        Me.Panel2.TabIndex = 8
        '
        'txtAnneeScolaire
        '
        Me.txtAnneeScolaire.Location = New System.Drawing.Point(13, 159)
        Me.txtAnneeScolaire.Name = "txtAnneeScolaire"
        Me.txtAnneeScolaire.Size = New System.Drawing.Size(196, 23)
        Me.txtAnneeScolaire.TabIndex = 7
        Me.txtAnneeScolaire.Text = "2025-2026"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Année scolaire"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(12, 106)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(196, 23)
        Me.ComboBox1.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Étudiant"
        '
        'cmbClasseImp
        '
        Me.cmbClasseImp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbClasseImp.FormattingEnabled = True
        Me.cmbClasseImp.Location = New System.Drawing.Point(12, 56)
        Me.cmbClasseImp.Name = "cmbClasseImp"
        Me.cmbClasseImp.Size = New System.Drawing.Size(196, 23)
        Me.cmbClasseImp.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Classe"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(12, 30)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(196, 1)
        Me.Panel1.TabIndex = 1
        '
        'lblSectFiltres
        '
        Me.lblSectFiltres.AutoSize = True
        Me.lblSectFiltres.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSectFiltres.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.lblSectFiltres.Location = New System.Drawing.Point(12, 12)
        Me.lblSectFiltres.Name = "lblSectFiltres"
        Me.lblSectFiltres.Size = New System.Drawing.Size(41, 15)
        Me.lblSectFiltres.TabIndex = 0
        Me.lblSectFiltres.Text = "Filtres"
        '
        'pnlApercu
        '
        Me.pnlApercu.Controls.Add(Me.rbtApercu)
        Me.pnlApercu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlApercu.Location = New System.Drawing.Point(235, 44)
        Me.pnlApercu.Name = "pnlApercu"
        Me.pnlApercu.Padding = New System.Windows.Forms.Padding(16)
        Me.pnlApercu.Size = New System.Drawing.Size(698, 475)
        Me.pnlApercu.TabIndex = 2
        '
        'rbtApercu
        '
        Me.rbtApercu.BackColor = System.Drawing.Color.White
        Me.rbtApercu.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rbtApercu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rbtApercu.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtApercu.Location = New System.Drawing.Point(16, 16)
        Me.rbtApercu.Name = "rbtApercu"
        Me.rbtApercu.ReadOnly = True
        Me.rbtApercu.Size = New System.Drawing.Size(666, 443)
        Me.rbtApercu.TabIndex = 0
        Me.rbtApercu.Text = ""
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
        Me.btnRetour.TabIndex = 2
        Me.btnRetour.Text = "← Retour"
        Me.btnRetour.UseVisualStyleBackColor = False
        '
        'sepRetour
        '
        Me.sepRetour.BackColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.sepRetour.Location = New System.Drawing.Point(104, 8)
        Me.sepRetour.Name = "sepRetour"
        Me.sepRetour.Size = New System.Drawing.Size(1, 28)
        Me.sepRetour.TabIndex = 6
        '
        'FormImpressions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(933, 519)
        Me.Controls.Add(Me.pnlApercu)
        Me.Controls.Add(Me.pnlFiltres)
        Me.Controls.Add(Me.pnlToolbar)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "FormImpressions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Impressions"
        Me.pnlToolbar.ResumeLayout(False)
        Me.pnlToolbar.PerformLayout()
        Me.pnlFiltres.ResumeLayout(False)
        Me.pnlFiltres.PerformLayout()
        Me.pnlApercu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlToolbar As Panel
    Friend WithEvents lblTitre As Label
    Friend WithEvents cmbTypeDoc As ComboBox
    Friend WithEvents pnlFiltres As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblSectFiltres As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbClasseImp As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtAnneeScolaire As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnApercu As Button
    Friend WithEvents lblSectActions As Label
    Friend WithEvents pnlInfoNote As Panel
    Friend WithEvents btnExporterPDF As Button
    Friend WithEvents btnImprimer As Button
    Friend WithEvents pnlApercu As Panel
    Friend WithEvents rbtApercu As RichTextBox
    Friend WithEvents btnRetour As Button
    Friend WithEvents sepRetour As Panel
End Class
