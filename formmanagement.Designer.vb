<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formmanagement
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formmanagement))
        Me.DataGridresult = New System.Windows.Forms.DataGridView()
        Me.Labeltitlegrid = New System.Windows.Forms.Label()
        Me.ToolStripmanagement = New System.Windows.Forms.ToolStrip()
        Me.ToolStripDropDownmanage = New System.Windows.Forms.ToolStripDropDownButton()
        Me.Deleteanyresult = New System.Windows.Forms.ToolStripMenuItem()
        Me.Deleteallresults = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripDropDownstatistic = New System.Windows.Forms.ToolStripDropDownButton()
        Me.Privateresult = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButtonHelp = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButtonMainMenu = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButtonQuit = New System.Windows.Forms.ToolStripButton()
        CType(Me.DataGridresult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStripmanagement.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridresult
        '
        Me.DataGridresult.AllowUserToResizeColumns = False
        Me.DataGridresult.AllowUserToResizeRows = False
        Me.DataGridresult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.DataGridresult.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.DataGridresult.BackgroundColor = System.Drawing.Color.LightGoldenrodYellow
        Me.DataGridresult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridresult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridresult.GridColor = System.Drawing.Color.PowderBlue
        Me.DataGridresult.Location = New System.Drawing.Point(513, 167)
        Me.DataGridresult.Name = "DataGridresult"
        Me.DataGridresult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridresult.Size = New System.Drawing.Size(307, 137)
        Me.DataGridresult.TabIndex = 0
        '
        'Labeltitlegrid
        '
        Me.Labeltitlegrid.AutoSize = True
        Me.Labeltitlegrid.BackColor = System.Drawing.Color.Transparent
        Me.Labeltitlegrid.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labeltitlegrid.Location = New System.Drawing.Point(330, 102)
        Me.Labeltitlegrid.Name = "Labeltitlegrid"
        Me.Labeltitlegrid.Size = New System.Drawing.Size(60, 19)
        Me.Labeltitlegrid.TabIndex = 1
        Me.Labeltitlegrid.Text = "Label1"
        '
        'ToolStripmanagement
        '
        Me.ToolStripmanagement.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ToolStripmanagement.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownmanage, Me.ToolStripSeparator1, Me.ToolStripDropDownstatistic, Me.ToolStripSeparator4, Me.ToolStripButtonHelp, Me.ToolStripSeparator3, Me.ToolStripButtonMainMenu, Me.ToolStripSeparator6, Me.ToolStripButtonQuit})
        Me.ToolStripmanagement.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripmanagement.Name = "ToolStripmanagement"
        Me.ToolStripmanagement.Size = New System.Drawing.Size(1008, 35)
        Me.ToolStripmanagement.TabIndex = 68
        Me.ToolStripmanagement.Text = "ToolStrip1"
        '
        'ToolStripDropDownmanage
        '
        Me.ToolStripDropDownmanage.AutoSize = False
        Me.ToolStripDropDownmanage.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripDropDownmanage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownmanage.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Deleteanyresult, Me.Deleteallresults})
        Me.ToolStripDropDownmanage.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripDropDownmanage.Image = Global.DesChiffresEtDesLettres.My.Resources.Resources.datamanager_fw
        Me.ToolStripDropDownmanage.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.ToolStripDropDownmanage.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripDropDownmanage.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownmanage.Margin = New System.Windows.Forms.Padding(0)
        Me.ToolStripDropDownmanage.MergeIndex = 0
        Me.ToolStripDropDownmanage.Name = "ToolStripDropDownmanage"
        Me.ToolStripDropDownmanage.Size = New System.Drawing.Size(194, 35)
        Me.ToolStripDropDownmanage.Text = "Gestion de données"
        Me.ToolStripDropDownmanage.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        '
        'Deleteanyresult
        '
        Me.Deleteanyresult.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Deleteanyresult.Name = "Deleteanyresult"
        Me.Deleteanyresult.Size = New System.Drawing.Size(324, 24)
        Me.Deleteanyresult.Text = "Supprimer un résultat personnel"
        '
        'Deleteallresults
        '
        Me.Deleteallresults.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Deleteallresults.Name = "Deleteallresults"
        Me.Deleteallresults.Size = New System.Drawing.Size(324, 24)
        Me.Deleteallresults.Text = "Supprimer tous ses résultats"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.AutoSize = False
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(1, 35)
        '
        'ToolStripDropDownstatistic
        '
        Me.ToolStripDropDownstatistic.AutoSize = False
        Me.ToolStripDropDownstatistic.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripDropDownstatistic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownstatistic.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Privateresult})
        Me.ToolStripDropDownstatistic.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripDropDownstatistic.Image = Global.DesChiffresEtDesLettres.My.Resources.Resources.statistics_fw
        Me.ToolStripDropDownstatistic.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.ToolStripDropDownstatistic.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripDropDownstatistic.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownstatistic.Margin = New System.Windows.Forms.Padding(0)
        Me.ToolStripDropDownstatistic.Name = "ToolStripDropDownstatistic"
        Me.ToolStripDropDownstatistic.Size = New System.Drawing.Size(156, 35)
        Me.ToolStripDropDownstatistic.Text = "Les statistiques"
        '
        'Privateresult
        '
        Me.Privateresult.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Privateresult.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Privateresult.Name = "Privateresult"
        Me.Privateresult.Size = New System.Drawing.Size(222, 24)
        Me.Privateresult.Text = "Résultat personnel"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.AutoSize = False
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(1, 35)
        '
        'ToolStripButtonHelp
        '
        Me.ToolStripButtonHelp.AutoSize = False
        Me.ToolStripButtonHelp.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripButtonHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonHelp.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButtonHelp.Image = Global.DesChiffresEtDesLettres.My.Resources.Resources.help_fw
        Me.ToolStripButtonHelp.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButtonHelp.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonHelp.Margin = New System.Windows.Forms.Padding(0)
        Me.ToolStripButtonHelp.Name = "ToolStripButtonHelp"
        Me.ToolStripButtonHelp.Size = New System.Drawing.Size(73, 35)
        Me.ToolStripButtonHelp.Text = "Aide"
        Me.ToolStripButtonHelp.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.AutoSize = False
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(1, 35)
        '
        'ToolStripButtonMainMenu
        '
        Me.ToolStripButtonMainMenu.AutoSize = False
        Me.ToolStripButtonMainMenu.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripButtonMainMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonMainMenu.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButtonMainMenu.Image = Global.DesChiffresEtDesLettres.My.Resources.Resources.menu_fw
        Me.ToolStripButtonMainMenu.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.ToolStripButtonMainMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButtonMainMenu.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonMainMenu.Margin = New System.Windows.Forms.Padding(0)
        Me.ToolStripButtonMainMenu.Name = "ToolStripButtonMainMenu"
        Me.ToolStripButtonMainMenu.Size = New System.Drawing.Size(93, 35)
        Me.ToolStripButtonMainMenu.Text = "Menu principal"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.AutoSize = False
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(1, 35)
        '
        'ToolStripButtonQuit
        '
        Me.ToolStripButtonQuit.AutoSize = False
        Me.ToolStripButtonQuit.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripButtonQuit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonQuit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButtonQuit.Image = Global.DesChiffresEtDesLettres.My.Resources.Resources.exit_fw
        Me.ToolStripButtonQuit.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.ToolStripButtonQuit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButtonQuit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonQuit.Margin = New System.Windows.Forms.Padding(0)
        Me.ToolStripButtonQuit.Name = "ToolStripButtonQuit"
        Me.ToolStripButtonQuit.Size = New System.Drawing.Size(93, 35)
        Me.ToolStripButtonQuit.Text = "Quitter"
        '
        'formmanagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1008, 691)
        Me.Controls.Add(Me.DataGridresult)
        Me.Controls.Add(Me.Labeltitlegrid)
        Me.Controls.Add(Me.ToolStripmanagement)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1024, 730)
        Me.Name = "formmanagement"
        CType(Me.DataGridresult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStripmanagement.ResumeLayout(False)
        Me.ToolStripmanagement.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Labeltitlegrid As System.Windows.Forms.Label
    Friend WithEvents DataGridresult As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStripmanagement As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButtonHelp As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButtonMainMenu As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButtonQuit As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripDropDownmanage As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents Deleteanyresult As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Deleteallresults As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripDropDownstatistic As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Privateresult As System.Windows.Forms.ToolStripMenuItem
End Class
