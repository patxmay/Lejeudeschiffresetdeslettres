<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formpreface
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Formpreface))
        Me.Toolbarmenu = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButtonchiffres = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButtonlettres = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButtongame = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButtonChooseNumbers = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButtonChooseLetter = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButtonmanager = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButtonexit = New System.Windows.Forms.ToolStripButton()
        Me.video = New System.Windows.Forms.WebBrowser()
        Me.Toolbarmenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Toolbarmenu
        '
        Me.Toolbarmenu.BackColor = System.Drawing.Color.LightBlue
        Me.Toolbarmenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButtonchiffres, Me.ToolStripSeparator3, Me.ToolStripButtonlettres, Me.ToolStripSeparator4, Me.ToolStripButtongame, Me.ToolStripSeparator5, Me.ToolStripButtonChooseNumbers, Me.ToolStripSeparator6, Me.ToolStripButtonChooseLetter, Me.ToolStripSeparator7, Me.ToolStripButtonmanager, Me.ToolStripSeparator10, Me.ToolStripButtonexit})
        Me.Toolbarmenu.Location = New System.Drawing.Point(0, 0)
        Me.Toolbarmenu.Name = "Toolbarmenu"
        Me.Toolbarmenu.Size = New System.Drawing.Size(1018, 38)
        Me.Toolbarmenu.TabIndex = 13
        '
        'ToolStripButtonchiffres
        '
        Me.ToolStripButtonchiffres.AutoSize = False
        Me.ToolStripButtonchiffres.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripButtonchiffres.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonchiffres.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButtonchiffres.Image = Global.DesChiffresEtDesLettres.My.Resources.Resources.numbers_fw
        Me.ToolStripButtonchiffres.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButtonchiffres.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonchiffres.Margin = New System.Windows.Forms.Padding(0)
        Me.ToolStripButtonchiffres.MergeIndex = 0
        Me.ToolStripButtonchiffres.Name = "ToolStripButtonchiffres"
        Me.ToolStripButtonchiffres.Size = New System.Drawing.Size(119, 35)
        Me.ToolStripButtonchiffres.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.AutoSize = False
        Me.ToolStripSeparator3.MergeIndex = 0
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(1, 35)
        '
        'ToolStripButtonlettres
        '
        Me.ToolStripButtonlettres.AutoSize = False
        Me.ToolStripButtonlettres.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripButtonlettres.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonlettres.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButtonlettres.Image = Global.DesChiffresEtDesLettres.My.Resources.Resources.letters_fw
        Me.ToolStripButtonlettres.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButtonlettres.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonlettres.Name = "ToolStripButtonlettres"
        Me.ToolStripButtonlettres.Size = New System.Drawing.Size(104, 35)
        Me.ToolStripButtonlettres.Text = "Les lettres"
        Me.ToolStripButtonlettres.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.AutoSize = False
        Me.ToolStripSeparator4.MergeIndex = 0
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(1, 35)
        '
        'ToolStripButtongame
        '
        Me.ToolStripButtongame.AutoSize = False
        Me.ToolStripButtongame.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripButtongame.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtongame.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButtongame.Image = Global.DesChiffresEtDesLettres.My.Resources.Resources.playgame_fw
        Me.ToolStripButtongame.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.ToolStripButtongame.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButtongame.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtongame.Margin = New System.Windows.Forms.Padding(0)
        Me.ToolStripButtongame.MergeIndex = 0
        Me.ToolStripButtongame.Name = "ToolStripButtongame"
        Me.ToolStripButtongame.Size = New System.Drawing.Size(162, 35)
        Me.ToolStripButtongame.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.AutoSize = False
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(1, 35)
        '
        'ToolStripButtonChooseNumbers
        '
        Me.ToolStripButtonChooseNumbers.AutoSize = False
        Me.ToolStripButtonChooseNumbers.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripButtonChooseNumbers.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonChooseNumbers.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButtonChooseNumbers.Image = Global.DesChiffresEtDesLettres.My.Resources.Resources.choosennums_fw
        Me.ToolStripButtonChooseNumbers.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButtonChooseNumbers.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonChooseNumbers.Margin = New System.Windows.Forms.Padding(0)
        Me.ToolStripButtonChooseNumbers.MergeIndex = 0
        Me.ToolStripButtonChooseNumbers.Name = "ToolStripButtonChooseNumbers"
        Me.ToolStripButtonChooseNumbers.Size = New System.Drawing.Size(196, 35)
        Me.ToolStripButtonChooseNumbers.Text = "Proposer les chiffres"
        Me.ToolStripButtonChooseNumbers.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.ToolStripButtonChooseNumbers.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.AutoSize = False
        Me.ToolStripSeparator6.MergeIndex = 0
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(1, 35)
        '
        'ToolStripButtonChooseLetter
        '
        Me.ToolStripButtonChooseLetter.AutoSize = False
        Me.ToolStripButtonChooseLetter.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripButtonChooseLetter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonChooseLetter.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButtonChooseLetter.Image = Global.DesChiffresEtDesLettres.My.Resources.Resources.chooseletters_fw
        Me.ToolStripButtonChooseLetter.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.ToolStripButtonChooseLetter.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButtonChooseLetter.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonChooseLetter.Margin = New System.Windows.Forms.Padding(0)
        Me.ToolStripButtonChooseLetter.MergeIndex = 0
        Me.ToolStripButtonChooseLetter.Name = "ToolStripButtonChooseLetter"
        Me.ToolStripButtonChooseLetter.RightToLeftAutoMirrorImage = True
        Me.ToolStripButtonChooseLetter.Size = New System.Drawing.Size(180, 35)
        Me.ToolStripButtonChooseLetter.Text = "Proposer les lettres"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.AutoSize = False
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(1, 35)
        '
        'ToolStripButtonmanager
        '
        Me.ToolStripButtonmanager.AutoSize = False
        Me.ToolStripButtonmanager.AutoToolTip = False
        Me.ToolStripButtonmanager.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripButtonmanager.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonmanager.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButtonmanager.Image = Global.DesChiffresEtDesLettres.My.Resources.Resources.manage_fw
        Me.ToolStripButtonmanager.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.ToolStripButtonmanager.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButtonmanager.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonmanager.Margin = New System.Windows.Forms.Padding(0)
        Me.ToolStripButtonmanager.Name = "ToolStripButtonmanager"
        Me.ToolStripButtonmanager.Size = New System.Drawing.Size(90, 35)
        Me.ToolStripButtonmanager.Text = "Gestion de données"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.AutoSize = False
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(1, 35)
        '
        'ToolStripButtonexit
        '
        Me.ToolStripButtonexit.AutoSize = False
        Me.ToolStripButtonexit.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripButtonexit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonexit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButtonexit.Image = Global.DesChiffresEtDesLettres.My.Resources.Resources.exit_fw
        Me.ToolStripButtonexit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButtonexit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonexit.Margin = New System.Windows.Forms.Padding(0)
        Me.ToolStripButtonexit.Name = "ToolStripButtonexit"
        Me.ToolStripButtonexit.Size = New System.Drawing.Size(90, 35)
        Me.ToolStripButtonexit.Text = "Quitter"
        Me.ToolStripButtonexit.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'video
        '
        Me.video.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.video.Location = New System.Drawing.Point(433, 144)
        Me.video.Margin = New System.Windows.Forms.Padding(0)
        Me.video.MinimumSize = New System.Drawing.Size(20, 20)
        Me.video.Name = "video"
        Me.video.ScrollBarsEnabled = False
        Me.video.Size = New System.Drawing.Size(151, 129)
        Me.video.TabIndex = 15
        '
        'Formpreface
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1018, 701)
        Me.Controls.Add(Me.video)
        Me.Controls.Add(Me.Toolbarmenu)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1024, 730)
        Me.Name = "Formpreface"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Toolbarmenu.ResumeLayout(False)
        Me.Toolbarmenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Toolbarmenu As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButtonlettres As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButtongame As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButtonChooseNumbers As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButtonChooseLetter As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButtonmanager As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButtonexit As System.Windows.Forms.ToolStripButton
    Private WithEvents ToolStripButtonchiffres As System.Windows.Forms.ToolStripButton
    Friend WithEvents video As System.Windows.Forms.WebBrowser

End Class
