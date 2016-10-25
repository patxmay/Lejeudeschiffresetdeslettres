<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formchoosenletter
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
        Me.components = New System.ComponentModel.Container()
        Me.Paneltimer = New System.Windows.Forms.Panel()
        Me.colonpic = New System.Windows.Forms.PictureBox()
        Me.unitminpic = New System.Windows.Forms.PictureBox()
        Me.unitsecpic = New System.Windows.Forms.PictureBox()
        Me.tensecpic = New System.Windows.Forms.PictureBox()
        Me.Timerprogressbar = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStripChoosenLetters = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButtonNew = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButtonSolution = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButtonHelp = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButtonMainMenu = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButtonQuit = New System.Windows.Forms.ToolStripButton()
        Me.PanelLettres = New System.Windows.Forms.Panel()
        Me.support = New System.Windows.Forms.Panel()
        Me.Buttonvalid = New System.Windows.Forms.Button()
        Me.ListBoxresult = New System.Windows.Forms.ListBox()
        Me.Labelcloud = New System.Windows.Forms.Label()
        Me.Paneltimer.SuspendLayout()
        CType(Me.colonpic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.unitminpic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.unitsecpic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tensecpic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStripChoosenLetters.SuspendLayout()
        Me.SuspendLayout()
        '
        'Paneltimer
        '
        Me.Paneltimer.BackColor = System.Drawing.Color.Transparent
        Me.Paneltimer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Paneltimer.Controls.Add(Me.colonpic)
        Me.Paneltimer.Controls.Add(Me.unitminpic)
        Me.Paneltimer.Controls.Add(Me.unitsecpic)
        Me.Paneltimer.Controls.Add(Me.tensecpic)
        Me.Paneltimer.Location = New System.Drawing.Point(691, 353)
        Me.Paneltimer.Name = "Paneltimer"
        Me.Paneltimer.Size = New System.Drawing.Size(162, 91)
        Me.Paneltimer.TabIndex = 57
        '
        'colonpic
        '
        Me.colonpic.BackColor = System.Drawing.Color.MintCream
        Me.colonpic.Location = New System.Drawing.Point(37, 13)
        Me.colonpic.Name = "colonpic"
        Me.colonpic.Size = New System.Drawing.Size(31, 41)
        Me.colonpic.TabIndex = 11
        Me.colonpic.TabStop = False
        '
        'unitminpic
        '
        Me.unitminpic.BackColor = System.Drawing.Color.MintCream
        Me.unitminpic.Location = New System.Drawing.Point(3, 13)
        Me.unitminpic.Name = "unitminpic"
        Me.unitminpic.Size = New System.Drawing.Size(31, 41)
        Me.unitminpic.TabIndex = 10
        Me.unitminpic.TabStop = False
        '
        'unitsecpic
        '
        Me.unitsecpic.BackColor = System.Drawing.Color.MintCream
        Me.unitsecpic.Location = New System.Drawing.Point(118, 13)
        Me.unitsecpic.Name = "unitsecpic"
        Me.unitsecpic.Size = New System.Drawing.Size(31, 41)
        Me.unitsecpic.TabIndex = 8
        Me.unitsecpic.TabStop = False
        '
        'tensecpic
        '
        Me.tensecpic.BackColor = System.Drawing.Color.MintCream
        Me.tensecpic.Location = New System.Drawing.Point(80, 13)
        Me.tensecpic.Name = "tensecpic"
        Me.tensecpic.Size = New System.Drawing.Size(32, 41)
        Me.tensecpic.TabIndex = 7
        Me.tensecpic.TabStop = False
        '
        'Timerprogressbar
        '
        '
        'ToolStripChoosenLetters
        '
        Me.ToolStripChoosenLetters.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ToolStripChoosenLetters.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButtonNew, Me.ToolStripSeparator1, Me.ToolStripButtonSolution, Me.ToolStripSeparator5, Me.ToolStripButtonHelp, Me.ToolStripSeparator4, Me.ToolStripButtonMainMenu, Me.ToolStripSeparator6, Me.ToolStripButtonQuit})
        Me.ToolStripChoosenLetters.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripChoosenLetters.Name = "ToolStripChoosenLetters"
        Me.ToolStripChoosenLetters.Size = New System.Drawing.Size(1008, 35)
        Me.ToolStripChoosenLetters.TabIndex = 67
        Me.ToolStripChoosenLetters.Text = "ToolStrip1"
        '
        'ToolStripButtonNew
        '
        Me.ToolStripButtonNew.AutoSize = False
        Me.ToolStripButtonNew.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripButtonNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonNew.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButtonNew.Image = Global.DesChiffresEtDesLettres.My.Resources.Resources.new_fw
        Me.ToolStripButtonNew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButtonNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonNew.Margin = New System.Windows.Forms.Padding(0)
        Me.ToolStripButtonNew.Name = "ToolStripButtonNew"
        Me.ToolStripButtonNew.Size = New System.Drawing.Size(93, 35)
        Me.ToolStripButtonNew.Text = "Nouveau"
        Me.ToolStripButtonNew.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.AutoSize = False
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(1, 35)
        '
        'ToolStripButtonSolution
        '
        Me.ToolStripButtonSolution.AutoSize = False
        Me.ToolStripButtonSolution.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripButtonSolution.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonSolution.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButtonSolution.Image = Global.DesChiffresEtDesLettres.My.Resources.Resources.solution_fw
        Me.ToolStripButtonSolution.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButtonSolution.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonSolution.Margin = New System.Windows.Forms.Padding(0)
        Me.ToolStripButtonSolution.Name = "ToolStripButtonSolution"
        Me.ToolStripButtonSolution.Size = New System.Drawing.Size(93, 35)
        Me.ToolStripButtonSolution.Text = "Solution"
        Me.ToolStripButtonSolution.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.AutoSize = False
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(1, 35)
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
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.AutoSize = False
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(1, 35)
        '
        'ToolStripButtonMainMenu
        '
        Me.ToolStripButtonMainMenu.AutoSize = False
        Me.ToolStripButtonMainMenu.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripButtonMainMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonMainMenu.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButtonMainMenu.Image = Global.DesChiffresEtDesLettres.My.Resources.Resources.menu_fw
        Me.ToolStripButtonMainMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButtonMainMenu.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonMainMenu.Margin = New System.Windows.Forms.Padding(0)
        Me.ToolStripButtonMainMenu.Name = "ToolStripButtonMainMenu"
        Me.ToolStripButtonMainMenu.Size = New System.Drawing.Size(93, 35)
        Me.ToolStripButtonMainMenu.Text = "Menu principal"
        Me.ToolStripButtonMainMenu.TextAlign = System.Drawing.ContentAlignment.TopLeft
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
        Me.ToolStripButtonQuit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButtonQuit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonQuit.Margin = New System.Windows.Forms.Padding(0)
        Me.ToolStripButtonQuit.Name = "ToolStripButtonQuit"
        Me.ToolStripButtonQuit.Size = New System.Drawing.Size(93, 35)
        Me.ToolStripButtonQuit.Text = "Quitter"
        Me.ToolStripButtonQuit.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'PanelLettres
        '
        Me.PanelLettres.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PanelLettres.BackColor = System.Drawing.Color.SeaGreen
        Me.PanelLettres.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelLettres.Location = New System.Drawing.Point(93, 156)
        Me.PanelLettres.Name = "PanelLettres"
        Me.PanelLettres.Size = New System.Drawing.Size(617, 105)
        Me.PanelLettres.TabIndex = 68
        '
        'support
        '
        Me.support.Location = New System.Drawing.Point(93, 308)
        Me.support.Name = "support"
        Me.support.Size = New System.Drawing.Size(407, 84)
        Me.support.TabIndex = 69
        '
        'Buttonvalid
        '
        Me.Buttonvalid.BackColor = System.Drawing.Color.Transparent
        Me.Buttonvalid.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buttonvalid.Image = Global.DesChiffresEtDesLettres.My.Resources.Resources.valid_fw
        Me.Buttonvalid.Location = New System.Drawing.Point(773, 288)
        Me.Buttonvalid.Margin = New System.Windows.Forms.Padding(0)
        Me.Buttonvalid.Name = "Buttonvalid"
        Me.Buttonvalid.Size = New System.Drawing.Size(90, 30)
        Me.Buttonvalid.TabIndex = 70
        Me.Buttonvalid.UseVisualStyleBackColor = False
        '
        'ListBoxresult
        '
        Me.ListBoxresult.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ListBoxresult.BackColor = System.Drawing.Color.LemonChiffon
        Me.ListBoxresult.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxresult.FormattingEnabled = True
        Me.ListBoxresult.ItemHeight = 19
        Me.ListBoxresult.Location = New System.Drawing.Point(773, 76)
        Me.ListBoxresult.Name = "ListBoxresult"
        Me.ListBoxresult.Size = New System.Drawing.Size(162, 156)
        Me.ListBoxresult.TabIndex = 71
        '
        'Labelcloud
        '
        Me.Labelcloud.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Labelcloud.Image = Global.DesChiffresEtDesLettres.My.Resources.Resources.cloud
        Me.Labelcloud.Location = New System.Drawing.Point(12, 31)
        Me.Labelcloud.Name = "Labelcloud"
        Me.Labelcloud.Size = New System.Drawing.Size(222, 122)
        Me.Labelcloud.TabIndex = 72
        '
        'Formchoosenletter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1008, 691)
        Me.Controls.Add(Me.Labelcloud)
        Me.Controls.Add(Me.ListBoxresult)
        Me.Controls.Add(Me.Buttonvalid)
        Me.Controls.Add(Me.support)
        Me.Controls.Add(Me.PanelLettres)
        Me.Controls.Add(Me.ToolStripChoosenLetters)
        Me.Controls.Add(Me.Paneltimer)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1024, 730)
        Me.Name = "Formchoosenletter"
        Me.Paneltimer.ResumeLayout(False)
        CType(Me.colonpic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.unitminpic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.unitsecpic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tensecpic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStripChoosenLetters.ResumeLayout(False)
        Me.ToolStripChoosenLetters.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Paneltimer As System.Windows.Forms.Panel
    Friend WithEvents colonpic As System.Windows.Forms.PictureBox
    Friend WithEvents unitminpic As System.Windows.Forms.PictureBox
    Friend WithEvents unitsecpic As System.Windows.Forms.PictureBox
    Friend WithEvents tensecpic As System.Windows.Forms.PictureBox
    Friend WithEvents Timerprogressbar As System.Windows.Forms.Timer
    Friend WithEvents ToolStripChoosenLetters As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButtonNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButtonSolution As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButtonHelp As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButtonMainMenu As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButtonQuit As System.Windows.Forms.ToolStripButton
    Friend WithEvents PanelLettres As System.Windows.Forms.Panel
    Friend WithEvents support As System.Windows.Forms.Panel
    Friend WithEvents Buttonvalid As System.Windows.Forms.Button
    Friend WithEvents ListBoxresult As System.Windows.Forms.ListBox
    Friend WithEvents Labelcloud As System.Windows.Forms.Label
End Class
