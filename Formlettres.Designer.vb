<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formlettres
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Formlettres))
        Me.Buttonnextgame = New System.Windows.Forms.Button()
        Me.PanelLettres = New System.Windows.Forms.Panel()
        Me.Timerprogressbar = New System.Windows.Forms.Timer(Me.components)
        Me.Paneltimer = New System.Windows.Forms.Panel()
        Me.colonpic = New System.Windows.Forms.PictureBox()
        Me.unitminpic = New System.Windows.Forms.PictureBox()
        Me.unitsecpic = New System.Windows.Forms.PictureBox()
        Me.tensecpic = New System.Windows.Forms.PictureBox()
        Me.panelscore = New System.Windows.Forms.Panel()
        Me.ptsplayer = New System.Windows.Forms.Label()
        Me.ptspc = New System.Windows.Forms.Label()
        Me.Labelplayer = New System.Windows.Forms.Label()
        Me.Labelpc = New System.Windows.Forms.Label()
        Me.CheckInsert = New System.Windows.Forms.CheckBox()
        Me.Groupchrono = New System.Windows.Forms.GroupBox()
        Me.Combosec = New System.Windows.Forms.ComboBox()
        Me.Labelsec = New System.Windows.Forms.Label()
        Me.nochrono = New System.Windows.Forms.RadioButton()
        Me.chrono = New System.Windows.Forms.RadioButton()
        Me.ToolStriplettres = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButtonChrono = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButtonNew = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButtonSolution = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButtonHelp = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButtonMainMenu = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButtonQuit = New System.Windows.Forms.ToolStripButton()
        Me.support = New System.Windows.Forms.Panel()
        Me.Panelsolution = New System.Windows.Forms.Panel()
        Me.Buttonclose = New System.Windows.Forms.Button()
        Me.ListBoxresult = New System.Windows.Forms.ListBox()
        Me.Timeranimation = New System.Windows.Forms.Timer(Me.components)
        Me.Labelstatus = New System.Windows.Forms.Label()
        Me.Timerdelay = New System.Windows.Forms.Timer(Me.components)
        Me.Buttonconsonne = New System.Windows.Forms.Button()
        Me.Buttonvoyelle = New System.Windows.Forms.Button()
        Me.Buttonerase = New System.Windows.Forms.Button()
        Me.Paneltimer.SuspendLayout()
        CType(Me.colonpic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.unitminpic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.unitsecpic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tensecpic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelscore.SuspendLayout()
        Me.Groupchrono.SuspendLayout()
        Me.ToolStriplettres.SuspendLayout()
        Me.Panelsolution.SuspendLayout()
        Me.SuspendLayout()
        '
        'Buttonnextgame
        '
        Me.Buttonnextgame.AutoSize = True
        Me.Buttonnextgame.BackColor = System.Drawing.Color.MidnightBlue
        Me.Buttonnextgame.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buttonnextgame.ForeColor = System.Drawing.Color.Gold
        Me.Buttonnextgame.Location = New System.Drawing.Point(23, 125)
        Me.Buttonnextgame.Name = "Buttonnextgame"
        Me.Buttonnextgame.Size = New System.Drawing.Size(119, 52)
        Me.Buttonnextgame.TabIndex = 55
        Me.Buttonnextgame.Text = "Continuez"
        Me.Buttonnextgame.UseVisualStyleBackColor = False
        '
        'PanelLettres
        '
        Me.PanelLettres.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PanelLettres.BackColor = System.Drawing.Color.SeaGreen
        Me.PanelLettres.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelLettres.Location = New System.Drawing.Point(153, 202)
        Me.PanelLettres.Name = "PanelLettres"
        Me.PanelLettres.Size = New System.Drawing.Size(617, 169)
        Me.PanelLettres.TabIndex = 51
        '
        'Timerprogressbar
        '
        '
        'Paneltimer
        '
        Me.Paneltimer.BackColor = System.Drawing.Color.Transparent
        Me.Paneltimer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Paneltimer.Controls.Add(Me.colonpic)
        Me.Paneltimer.Controls.Add(Me.unitminpic)
        Me.Paneltimer.Controls.Add(Me.unitsecpic)
        Me.Paneltimer.Controls.Add(Me.tensecpic)
        Me.Paneltimer.Location = New System.Drawing.Point(846, 389)
        Me.Paneltimer.Name = "Paneltimer"
        Me.Paneltimer.Size = New System.Drawing.Size(162, 91)
        Me.Paneltimer.TabIndex = 56
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
        'panelscore
        '
        Me.panelscore.BackColor = System.Drawing.Color.Cornsilk
        Me.panelscore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panelscore.Controls.Add(Me.ptsplayer)
        Me.panelscore.Controls.Add(Me.ptspc)
        Me.panelscore.Controls.Add(Me.Labelplayer)
        Me.panelscore.Controls.Add(Me.Labelpc)
        Me.panelscore.Location = New System.Drawing.Point(527, 81)
        Me.panelscore.Name = "panelscore"
        Me.panelscore.Size = New System.Drawing.Size(229, 80)
        Me.panelscore.TabIndex = 60
        '
        'ptsplayer
        '
        Me.ptsplayer.BackColor = System.Drawing.Color.White
        Me.ptsplayer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ptsplayer.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ptsplayer.Location = New System.Drawing.Point(175, 43)
        Me.ptsplayer.Margin = New System.Windows.Forms.Padding(0)
        Me.ptsplayer.Name = "ptsplayer"
        Me.ptsplayer.Size = New System.Drawing.Size(41, 30)
        Me.ptsplayer.TabIndex = 3
        Me.ptsplayer.Text = "0     "
        Me.ptsplayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ptspc
        '
        Me.ptspc.BackColor = System.Drawing.Color.White
        Me.ptspc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ptspc.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ptspc.Location = New System.Drawing.Point(175, 7)
        Me.ptspc.Margin = New System.Windows.Forms.Padding(0)
        Me.ptspc.Name = "ptspc"
        Me.ptspc.Size = New System.Drawing.Size(41, 30)
        Me.ptspc.TabIndex = 2
        Me.ptspc.Text = "0      "
        Me.ptspc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Labelplayer
        '
        Me.Labelplayer.BackColor = System.Drawing.Color.PowderBlue
        Me.Labelplayer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Labelplayer.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelplayer.Location = New System.Drawing.Point(9, 43)
        Me.Labelplayer.Margin = New System.Windows.Forms.Padding(0)
        Me.Labelplayer.Name = "Labelplayer"
        Me.Labelplayer.Size = New System.Drawing.Size(160, 30)
        Me.Labelplayer.TabIndex = 1
        Me.Labelplayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Labelplayer.UseCompatibleTextRendering = True
        '
        'Labelpc
        '
        Me.Labelpc.BackColor = System.Drawing.Color.PowderBlue
        Me.Labelpc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Labelpc.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelpc.Location = New System.Drawing.Point(9, 7)
        Me.Labelpc.Margin = New System.Windows.Forms.Padding(0)
        Me.Labelpc.Name = "Labelpc"
        Me.Labelpc.Size = New System.Drawing.Size(160, 30)
        Me.Labelpc.TabIndex = 0
        Me.Labelpc.Text = "ordinateur"
        Me.Labelpc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Labelpc.UseCompatibleTextRendering = True
        '
        'CheckInsert
        '
        Me.CheckInsert.BackColor = System.Drawing.Color.Transparent
        Me.CheckInsert.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.CheckInsert.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.CheckInsert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.CheckInsert.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckInsert.Image = Global.DesChiffresEtDesLettres.My.Resources.Resources.insert
        Me.CheckInsert.Location = New System.Drawing.Point(34, 256)
        Me.CheckInsert.Name = "CheckInsert"
        Me.CheckInsert.Size = New System.Drawing.Size(82, 35)
        Me.CheckInsert.TabIndex = 62
        Me.CheckInsert.UseVisualStyleBackColor = False
        '
        'Groupchrono
        '
        Me.Groupchrono.BackColor = System.Drawing.Color.Cornsilk
        Me.Groupchrono.Controls.Add(Me.Combosec)
        Me.Groupchrono.Controls.Add(Me.Labelsec)
        Me.Groupchrono.Controls.Add(Me.nochrono)
        Me.Groupchrono.Controls.Add(Me.chrono)
        Me.Groupchrono.Location = New System.Drawing.Point(224, 81)
        Me.Groupchrono.Name = "Groupchrono"
        Me.Groupchrono.Size = New System.Drawing.Size(152, 85)
        Me.Groupchrono.TabIndex = 64
        Me.Groupchrono.TabStop = False
        '
        'Combosec
        '
        Me.Combosec.DropDownHeight = 80
        Me.Combosec.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Combosec.FormattingEnabled = True
        Me.Combosec.IntegralHeight = False
        Me.Combosec.Location = New System.Drawing.Point(76, 44)
        Me.Combosec.Name = "Combosec"
        Me.Combosec.Size = New System.Drawing.Size(54, 24)
        Me.Combosec.TabIndex = 0
        '
        'Labelsec
        '
        Me.Labelsec.BackColor = System.Drawing.Color.PowderBlue
        Me.Labelsec.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Labelsec.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Labelsec.Location = New System.Drawing.Point(76, 16)
        Me.Labelsec.Name = "Labelsec"
        Me.Labelsec.Size = New System.Drawing.Size(70, 18)
        Me.Labelsec.TabIndex = 2
        Me.Labelsec.Text = "secondes"
        Me.Labelsec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'nochrono
        '
        Me.nochrono.BackColor = System.Drawing.Color.Transparent
        Me.nochrono.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nochrono.Image = Global.DesChiffresEtDesLettres.My.Resources.Resources.nochronometer
        Me.nochrono.Location = New System.Drawing.Point(6, 44)
        Me.nochrono.Margin = New System.Windows.Forms.Padding(0)
        Me.nochrono.Name = "nochrono"
        Me.nochrono.Size = New System.Drawing.Size(53, 45)
        Me.nochrono.TabIndex = 46
        Me.nochrono.TabStop = True
        Me.nochrono.UseVisualStyleBackColor = False
        '
        'chrono
        '
        Me.chrono.BackColor = System.Drawing.Color.Transparent
        Me.chrono.Checked = True
        Me.chrono.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chrono.Image = Global.DesChiffresEtDesLettres.My.Resources.Resources.chronometer
        Me.chrono.Location = New System.Drawing.Point(6, 5)
        Me.chrono.Name = "chrono"
        Me.chrono.Size = New System.Drawing.Size(53, 45)
        Me.chrono.TabIndex = 45
        Me.chrono.TabStop = True
        Me.chrono.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chrono.UseVisualStyleBackColor = False
        '
        'ToolStriplettres
        '
        Me.ToolStriplettres.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ToolStriplettres.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButtonChrono, Me.ToolStripSeparator2, Me.ToolStripButtonNew, Me.ToolStripSeparator1, Me.ToolStripButtonSolution, Me.ToolStripSeparator3, Me.ToolStripButtonHelp, Me.ToolStripSeparator4, Me.ToolStripButtonMainMenu, Me.ToolStripSeparator6, Me.ToolStripButtonQuit})
        Me.ToolStriplettres.Location = New System.Drawing.Point(0, 0)
        Me.ToolStriplettres.Name = "ToolStriplettres"
        Me.ToolStriplettres.Size = New System.Drawing.Size(1008, 35)
        Me.ToolStriplettres.TabIndex = 65
        Me.ToolStriplettres.Text = "ToolStrip1"
        '
        'ToolStripButtonChrono
        '
        Me.ToolStripButtonChrono.AutoSize = False
        Me.ToolStripButtonChrono.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripButtonChrono.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ToolStripButtonChrono.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonChrono.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButtonChrono.Image = Global.DesChiffresEtDesLettres.My.Resources.Resources.chrono_fw
        Me.ToolStripButtonChrono.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButtonChrono.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonChrono.Margin = New System.Windows.Forms.Padding(0)
        Me.ToolStripButtonChrono.Name = "ToolStripButtonChrono"
        Me.ToolStripButtonChrono.Size = New System.Drawing.Size(93, 35)
        Me.ToolStripButtonChrono.Text = "Chrono"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.AutoSize = False
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(1, 35)
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
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.AutoSize = False
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(1, 35)
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
        Me.ToolStripButtonHelp.MergeIndex = 0
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
        '
        'support
        '
        Me.support.BackColor = System.Drawing.Color.Transparent
        Me.support.Location = New System.Drawing.Point(315, 442)
        Me.support.Name = "support"
        Me.support.Size = New System.Drawing.Size(407, 84)
        Me.support.TabIndex = 67
        '
        'Panelsolution
        '
        Me.Panelsolution.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panelsolution.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Panelsolution.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panelsolution.Controls.Add(Me.Buttonclose)
        Me.Panelsolution.Controls.Add(Me.ListBoxresult)
        Me.Panelsolution.Location = New System.Drawing.Point(800, 53)
        Me.Panelsolution.Name = "Panelsolution"
        Me.Panelsolution.Size = New System.Drawing.Size(184, 185)
        Me.Panelsolution.TabIndex = 69
        '
        'Buttonclose
        '
        Me.Buttonclose.BackColor = System.Drawing.Color.Transparent
        Me.Buttonclose.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buttonclose.Image = Global.DesChiffresEtDesLettres.My.Resources.Resources.buttonclose_fw
        Me.Buttonclose.Location = New System.Drawing.Point(10, 14)
        Me.Buttonclose.Margin = New System.Windows.Forms.Padding(0)
        Me.Buttonclose.Name = "Buttonclose"
        Me.Buttonclose.Size = New System.Drawing.Size(86, 30)
        Me.Buttonclose.TabIndex = 63
        Me.Buttonclose.UseVisualStyleBackColor = False
        '
        'ListBoxresult
        '
        Me.ListBoxresult.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ListBoxresult.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.ListBoxresult.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxresult.FormattingEnabled = True
        Me.ListBoxresult.ItemHeight = 19
        Me.ListBoxresult.Location = New System.Drawing.Point(10, 60)
        Me.ListBoxresult.Name = "ListBoxresult"
        Me.ListBoxresult.Size = New System.Drawing.Size(132, 80)
        Me.ListBoxresult.TabIndex = 62
        '
        'Timeranimation
        '
        '
        'Labelstatus
        '
        Me.Labelstatus.Location = New System.Drawing.Point(25, 63)
        Me.Labelstatus.Name = "Labelstatus"
        Me.Labelstatus.Size = New System.Drawing.Size(39, 13)
        Me.Labelstatus.TabIndex = 70
        '
        'Timerdelay
        '
        Me.Timerdelay.Interval = 1000
        '
        'Buttonconsonne
        '
        Me.Buttonconsonne.Image = Global.DesChiffresEtDesLettres.My.Resources.Resources.consonne
        Me.Buttonconsonne.Location = New System.Drawing.Point(153, 379)
        Me.Buttonconsonne.Name = "Buttonconsonne"
        Me.Buttonconsonne.Size = New System.Drawing.Size(164, 57)
        Me.Buttonconsonne.TabIndex = 71
        Me.Buttonconsonne.UseVisualStyleBackColor = True
        '
        'Buttonvoyelle
        '
        Me.Buttonvoyelle.Image = Global.DesChiffresEtDesLettres.My.Resources.Resources.voyelle
        Me.Buttonvoyelle.Location = New System.Drawing.Point(392, 377)
        Me.Buttonvoyelle.Name = "Buttonvoyelle"
        Me.Buttonvoyelle.Size = New System.Drawing.Size(129, 53)
        Me.Buttonvoyelle.TabIndex = 72
        Me.Buttonvoyelle.UseVisualStyleBackColor = True
        '
        'Buttonerase
        '
        Me.Buttonerase.Image = Global.DesChiffresEtDesLettres.My.Resources.Resources.effacer
        Me.Buttonerase.Location = New System.Drawing.Point(556, 382)
        Me.Buttonerase.Name = "Buttonerase"
        Me.Buttonerase.Size = New System.Drawing.Size(109, 47)
        Me.Buttonerase.TabIndex = 73
        Me.Buttonerase.UseVisualStyleBackColor = True
        '
        'Formlettres
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1008, 691)
        Me.Controls.Add(Me.CheckInsert)
        Me.Controls.Add(Me.Buttonerase)
        Me.Controls.Add(Me.Buttonvoyelle)
        Me.Controls.Add(Me.Buttonconsonne)
        Me.Controls.Add(Me.Labelstatus)
        Me.Controls.Add(Me.Panelsolution)
        Me.Controls.Add(Me.Paneltimer)
        Me.Controls.Add(Me.ToolStriplettres)
        Me.Controls.Add(Me.Groupchrono)
        Me.Controls.Add(Me.panelscore)
        Me.Controls.Add(Me.Buttonnextgame)
        Me.Controls.Add(Me.PanelLettres)
        Me.Controls.Add(Me.support)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1024, 730)
        Me.Name = "Formlettres"
        Me.Paneltimer.ResumeLayout(False)
        CType(Me.colonpic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.unitminpic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.unitsecpic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tensecpic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelscore.ResumeLayout(False)
        Me.Groupchrono.ResumeLayout(False)
        Me.ToolStriplettres.ResumeLayout(False)
        Me.ToolStriplettres.PerformLayout()
        Me.Panelsolution.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Buttonnextgame As System.Windows.Forms.Button
    Friend WithEvents PanelLettres As System.Windows.Forms.Panel
    Friend WithEvents Timerprogressbar As System.Windows.Forms.Timer
    Friend WithEvents Paneltimer As System.Windows.Forms.Panel
    Friend WithEvents colonpic As System.Windows.Forms.PictureBox
    Friend WithEvents unitminpic As System.Windows.Forms.PictureBox
    Friend WithEvents unitsecpic As System.Windows.Forms.PictureBox
    Friend WithEvents tensecpic As System.Windows.Forms.PictureBox
    Friend WithEvents panelscore As System.Windows.Forms.Panel
    Friend WithEvents ptsplayer As System.Windows.Forms.Label
    Friend WithEvents ptspc As System.Windows.Forms.Label
    Friend WithEvents Labelplayer As System.Windows.Forms.Label
    Friend WithEvents Labelpc As System.Windows.Forms.Label
    Friend WithEvents CheckInsert As System.Windows.Forms.CheckBox
    Friend WithEvents Groupchrono As System.Windows.Forms.GroupBox
    Friend WithEvents Combosec As System.Windows.Forms.ComboBox
    Friend WithEvents Labelsec As System.Windows.Forms.Label
    Friend WithEvents nochrono As System.Windows.Forms.RadioButton
    Friend WithEvents chrono As System.Windows.Forms.RadioButton
    Friend WithEvents ToolStriplettres As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButtonChrono As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButtonNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButtonSolution As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButtonHelp As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButtonMainMenu As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButtonQuit As System.Windows.Forms.ToolStripButton
    Friend WithEvents support As System.Windows.Forms.Panel
    Friend WithEvents Panelsolution As System.Windows.Forms.Panel
    Friend WithEvents Buttonclose As System.Windows.Forms.Button
    Friend WithEvents ListBoxresult As System.Windows.Forms.ListBox
    Friend WithEvents Timeranimation As System.Windows.Forms.Timer
    Friend WithEvents Labelstatus As System.Windows.Forms.Label
    Friend WithEvents Timerdelay As System.Windows.Forms.Timer
    Friend WithEvents Buttonconsonne As System.Windows.Forms.Button
    Friend WithEvents Buttonvoyelle As System.Windows.Forms.Button
    Friend WithEvents Buttonerase As System.Windows.Forms.Button
End Class
