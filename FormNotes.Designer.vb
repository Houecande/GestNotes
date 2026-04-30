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
        Me.pnlToolbar.SuspendLayout()
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
        Me.btnCalculer.Location = New System.Drawing.Point(695, 8)
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
        Me.btnEnregistrer.Location = New System.Drawing.Point(791, 8)
        Me.btnEnregistrer.Name = "btnEnregistrer"
        Me.btnEnregistrer.Size = New System.Drawing.Size(110, 28)
        Me.btnEnregistrer.TabIndex = 4
        Me.btnEnregistrer.Text = "💾 Enregistrer"
        Me.btnEnregistrer.UseVisualStyleBackColor = False
        '
        'pnlCorps
        '
        Me.pnlCorps.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlCorps.Location = New System.Drawing.Point(0, 44)
        Me.pnlCorps.Name = "pnlCorps"
        Me.pnlCorps.Padding = New System.Windows.Forms.Padding(10)
        Me.pnlCorps.Size = New System.Drawing.Size(933, 475)
        Me.pnlCorps.TabIndex = 1
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
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlToolbar As Panel
    Friend WithEvents cmbClasse As ComboBox
    Friend WithEvents lblTitre As Label
    Friend WithEvents btnCalculer As Button
    Friend WithEvents cmbMatiere As ComboBox
    Friend WithEvents btnEnregistrer As Button
    Friend WithEvents pnlCorps As Panel
End Class
