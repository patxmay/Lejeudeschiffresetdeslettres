<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formchiffre
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Formchiffre))
        Me.PanelMath = New System.Windows.Forms.Panel()
        Me.Groupchiffres = New System.Windows.Forms.GroupBox()
        Me.nombre4 = New System.Windows.Forms.Button()
        Me.nombre5 = New System.Windows.Forms.Button()
        Me.nombre6 = New System.Windows.Forms.Button()
        Me.nombre3 = New System.Windows.Forms.Button()
        Me.nombre1 = New System.Windows.Forms.Button()
        Me.nombre2 = New System.Windows.Forms.Button()
        Me.GroupBoxequation = New System.Windows.Forms.GroupBox()
        Me.Grouptool = New System.Windows.Forms.GroupBox()
        Me.Buttonerase = New System.Windows.Forms.Button()
        Me.Buttonreset = New System.Windows.Forms.Button()
        Me.Groupoperators = New System.Windows.Forms.GroupBox()
        Me.Buttonoperatorsub = New System.Windows.Forms.Button()
        Me.Buttonoperatormult = New System.Windows.Forms.Button()
        Me.Buttonoperatoradd = New System.Windows.Forms.Button()
        Me.Buttonoperatordiv = New System.Windows.Forms.Button()
        Me.ButtonTirage = New System.Windows.Forms.Button()
        Me.ListBoxresult = New System.Windows.Forms.ListBox()
        Me.panelscore = New System.Windows.Forms.Panel()
        Me.ptsplayer = New System.Windows.Forms.Label()
        Me.ptspc = New System.Windows.Forms.Label()
        Me.Labelplayer = New System.Windows.Forms.Label()
        Me.Labelpc = New System.Windows.Forms.Label()
        Me.PanelSevenseg = New System.Windows.Forms.Panel()
        Me.unitpic = New System.Windows.Forms.PictureBox()
        Me.hundredpic = New System.Windows.Forms.PictureBox()
        Me.tenpic = New System.Windows.Forms.PictureBox()
        Me.Timerhundred = New System.Windows.Forms.Timer(Me.components)
        Me.Timerten = New System.Windows.Forms.Timer(Me.components)
        Me.Timerunit = New System.Windows.Forms.Timer(Me.components)
        Me.Timertirage = New System.Windows.Forms.Timer(Me.components)
        Me.Timerfree = New System.Windows.Forms.Timer(Me.components)
        Me.Timerprogressbar = New System.Windows.Forms.Timer(Me.components)
        Me.Buttonnextgame = New System.Windows.Forms.Button()
        Me.Groupchrono = New System.Windows.Forms.GroupBox()
        Me.Combosec = New System.Windows.Forms.ComboBox()
        Me.Labelsec = New System.Windows.Forms.Label()
        Me.nochrono = New System.Windows.Forms.RadioButton()
        Me.chrono = New System.Windows.Forms.RadioButton()
        Me.Paneltimer = New System.Windows.Forms.Panel()
        Me.colonpic = New System.Windows.Forms.PictureBox()
        Me.unitminpic = New System.Windows.Forms.PictureBox()
        Me.unitsecpic = New System.Windows.Forms.PictureBox()
        Me.tensecpic = New System.Windows.Forms.PictureBox()
        Me.ToolStripButtonChrono = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButtonNew = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButtonHelp = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButtonMainMenu = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButtonQuit = New System.Windows.Forms.ToolStripButton()
        Me.Labelstatus = New System.Windows.Forms.Label()
        Me.ToolStripchiffres = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButtonSolution = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButtonOral = New System.Windows.Forms.ToolStripButton()
        Me.Panelsolution = New System.Windows.Forms.Panel()
        Me.Buttonclose = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PanelMath.SuspendLayout()
        Me.Groupchiffres.SuspendLayout()
        Me.Grouptool.SuspendLayout()
        Me.Groupoperators.SuspendLayout()
        Me.panelscore.SuspendLayout()
        Me.PanelSevenseg.SuspendLayout()
        CType(Me.unitpic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hundredpic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tenpic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Groupchrono.SuspendLayout()
        Me.Paneltimer.SuspendLayout()
        CType(Me.colonpic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.unitminpic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.unitsecpic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tensecpic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStripchiffres.SuspendLayout()
        Me.Panelsolution.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelMath
        '
        Me.PanelMath.BackColor = System.Drawing.Color.SeaGreen
        Me.PanelMath.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelMath.Controls.Add(Me.Groupchiffres)
        Me.PanelMath.Controls.Add(Me.GroupBoxequation)
        Me.PanelMath.Controls.Add(Me.Grouptool)
        Me.PanelMath.Controls.Add(Me.Groupoperators)
        Me.PanelMath.Controls.Add(Me.ButtonTirage)
        Me.PanelMath.Location = New System.Drawing.Point(12, 157)
        Me.PanelMath.Name = "PanelMath"
        Me.PanelMath.Size = New System.Drawing.Size(704, 370)
        Me.PanelMath.TabIndex = 0
        '
        'Groupchiffres
        '
        Me.Groupchiffres.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.Groupchiffres.Controls.Add(Me.nombre4)
        Me.Groupchiffres.Controls.Add(Me.nombre5)
        Me.Groupchiffres.Controls.Add(Me.nombre6)
        Me.Groupchiffres.Controls.Add(Me.nombre3)
        Me.Groupchiffres.Controls.Add(Me.nombre1)
        Me.Groupchiffres.Controls.Add(Me.nombre2)
        Me.Groupchiffres.Location = New System.Drawing.Point(93, 14)
        Me.Groupchiffres.Name = "Groupchiffres"
        Me.Groupchiffres.Size = New System.Drawing.Size(554, 90)
        Me.Groupchiffres.TabIndex = 39
        Me.Groupchiffres.TabStop = False
        '
        'nombre4
        '
        Me.nombre4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.nombre4.Font = New System.Drawing.Font("Arial", 26.25!, System.Drawing.FontStyle.Bold)
        Me.nombre4.Location = New System.Drawing.Point(274, 4)
        Me.nombre4.Margin = New System.Windows.Forms.Padding(0)
        Me.nombre4.Name = "nombre4"
        Me.nombre4.Size = New System.Drawing.Size(86, 76)
        Me.nombre4.TabIndex = 3
        Me.nombre4.Text = "100"
        Me.nombre4.UseVisualStyleBackColor = False
        '
        'nombre5
        '
        Me.nombre5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.nombre5.Font = New System.Drawing.Font("Arial", 26.25!, System.Drawing.FontStyle.Bold)
        Me.nombre5.Location = New System.Drawing.Point(364, 4)
        Me.nombre5.Margin = New System.Windows.Forms.Padding(0)
        Me.nombre5.Name = "nombre5"
        Me.nombre5.Size = New System.Drawing.Size(86, 76)
        Me.nombre5.TabIndex = 4
        Me.nombre5.Text = "100"
        Me.nombre5.UseVisualStyleBackColor = False
        '
        'nombre6
        '
        Me.nombre6.BackColor = System.Drawing.Color.WhiteSmoke
        Me.nombre6.Font = New System.Drawing.Font("Arial", 26.25!, System.Drawing.FontStyle.Bold)
        Me.nombre6.Location = New System.Drawing.Point(454, 4)
        Me.nombre6.Margin = New System.Windows.Forms.Padding(0)
        Me.nombre6.Name = "nombre6"
        Me.nombre6.Size = New System.Drawing.Size(86, 76)
        Me.nombre6.TabIndex = 5
        Me.nombre6.Text = "100"
        Me.nombre6.UseVisualStyleBackColor = False
        '
        'nombre3
        '
        Me.nombre3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.nombre3.Font = New System.Drawing.Font("Arial", 26.25!, System.Drawing.FontStyle.Bold)
        Me.nombre3.Location = New System.Drawing.Point(184, 4)
        Me.nombre3.Margin = New System.Windows.Forms.Padding(0)
        Me.nombre3.Name = "nombre3"
        Me.nombre3.Size = New System.Drawing.Size(86, 76)
        Me.nombre3.TabIndex = 2
        Me.nombre3.Text = "100"
        Me.nombre3.UseVisualStyleBackColor = False
        '
        'nombre1
        '
        Me.nombre1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.nombre1.Font = New System.Drawing.Font("Arial", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nombre1.Location = New System.Drawing.Point(4, 4)
        Me.nombre1.Margin = New System.Windows.Forms.Padding(0)
        Me.nombre1.Name = "nombre1"
        Me.nombre1.Size = New System.Drawing.Size(86, 76)
        Me.nombre1.TabIndex = 0
        Me.nombre1.Text = "100"
        Me.nombre1.UseVisualStyleBackColor = False
        '
        'nombre2
        '
        Me.nombre2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.nombre2.Font = New System.Drawing.Font("Arial", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nombre2.Location = New System.Drawing.Point(94, 4)
        Me.nombre2.Margin = New System.Windows.Forms.Padding(0)
        Me.nombre2.Name = "nombre2"
        Me.nombre2.Size = New System.Drawing.Size(86, 76)
        Me.nombre2.TabIndex = 1
        Me.nombre2.Text = "100"
        Me.nombre2.UseVisualStyleBackColor = False
        '
        'GroupBoxequation
        '
        Me.GroupBoxequation.Location = New System.Drawing.Point(209, 226)
        Me.GroupBoxequation.Name = "GroupBoxequation"
        Me.GroupBoxequation.Size = New System.Drawing.Size(220, 108)
        Me.GroupBoxequation.TabIndex = 38
        Me.GroupBoxequation.TabStop = False
        '
        'Grouptool
        '
        Me.Grouptool.BackColor = System.Drawing.Color.LemonChiffon
        Me.Grouptool.Controls.Add(Me.Buttonerase)
        Me.Grouptool.Controls.Add(Me.Buttonreset)
        Me.Grouptool.Location = New System.Drawing.Point(322, 107)
        Me.Grouptool.Name = "Grouptool"
        Me.Grouptool.Size = New System.Drawing.Size(231, 52)
        Me.Grouptool.TabIndex = 37
        Me.Grouptool.TabStop = False
        '
        'Buttonerase
        '
        Me.Buttonerase.BackColor = System.Drawing.Color.Transparent
        Me.Buttonerase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Buttonerase.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buttonerase.Image = Global.DesChiffresEtDesLettres.My.Resources.Resources.eraser
        Me.Buttonerase.Location = New System.Drawing.Point(88, 10)
        Me.Buttonerase.Margin = New System.Windows.Forms.Padding(0)
        Me.Buttonerase.Name = "Buttonerase"
        Me.Buttonerase.Size = New System.Drawing.Size(136, 36)
        Me.Buttonerase.TabIndex = 2
        Me.Buttonerase.UseVisualStyleBackColor = True
        '
        'Buttonreset
        '
        Me.Buttonreset.BackColor = System.Drawing.Color.Transparent
        Me.Buttonreset.Enabled = False
        Me.Buttonreset.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buttonreset.Image = Global.DesChiffresEtDesLettres.My.Resources.Resources.RAZ
        Me.Buttonreset.Location = New System.Drawing.Point(3, 10)
        Me.Buttonreset.Margin = New System.Windows.Forms.Padding(0)
        Me.Buttonreset.Name = "Buttonreset"
        Me.Buttonreset.Size = New System.Drawing.Size(76, 36)
        Me.Buttonreset.TabIndex = 1
        Me.Buttonreset.UseVisualStyleBackColor = False
        '
        'Groupoperators
        '
        Me.Groupoperators.BackColor = System.Drawing.Color.LemonChiffon
        Me.Groupoperators.Controls.Add(Me.Buttonoperatorsub)
        Me.Groupoperators.Controls.Add(Me.Buttonoperatormult)
        Me.Groupoperators.Controls.Add(Me.Buttonoperatoradd)
        Me.Groupoperators.Controls.Add(Me.Buttonoperatordiv)
        Me.Groupoperators.Location = New System.Drawing.Point(93, 107)
        Me.Groupoperators.Margin = New System.Windows.Forms.Padding(0)
        Me.Groupoperators.Name = "Groupoperators"
        Me.Groupoperators.Padding = New System.Windows.Forms.Padding(0)
        Me.Groupoperators.Size = New System.Drawing.Size(196, 52)
        Me.Groupoperators.TabIndex = 36
        Me.Groupoperators.TabStop = False
        '
        'Buttonoperatorsub
        '
        Me.Buttonoperatorsub.BackColor = System.Drawing.Color.Navy
        Me.Buttonoperatorsub.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buttonoperatorsub.ForeColor = System.Drawing.Color.Yellow
        Me.Buttonoperatorsub.Image = Global.DesChiffresEtDesLettres.My.Resources.Resources._sub
        Me.Buttonoperatorsub.Location = New System.Drawing.Point(145, 4)
        Me.Buttonoperatorsub.Margin = New System.Windows.Forms.Padding(0)
        Me.Buttonoperatorsub.Name = "Buttonoperatorsub"
        Me.Buttonoperatorsub.Size = New System.Drawing.Size(48, 48)
        Me.Buttonoperatorsub.TabIndex = 10
        Me.Buttonoperatorsub.UseVisualStyleBackColor = False
        '
        'Buttonoperatormult
        '
        Me.Buttonoperatormult.BackColor = System.Drawing.Color.Navy
        Me.Buttonoperatormult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Buttonoperatormult.ForeColor = System.Drawing.Color.Yellow
        Me.Buttonoperatormult.Image = Global.DesChiffresEtDesLettres.My.Resources.Resources.mult
        Me.Buttonoperatormult.Location = New System.Drawing.Point(0, 3)
        Me.Buttonoperatormult.Margin = New System.Windows.Forms.Padding(0)
        Me.Buttonoperatormult.Name = "Buttonoperatormult"
        Me.Buttonoperatormult.Size = New System.Drawing.Size(48, 48)
        Me.Buttonoperatormult.TabIndex = 40
        Me.Buttonoperatormult.UseVisualStyleBackColor = False
        '
        'Buttonoperatoradd
        '
        Me.Buttonoperatoradd.BackColor = System.Drawing.Color.Navy
        Me.Buttonoperatoradd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Buttonoperatoradd.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buttonoperatoradd.ForeColor = System.Drawing.Color.Yellow
        Me.Buttonoperatoradd.Image = Global.DesChiffresEtDesLettres.My.Resources.Resources.add
        Me.Buttonoperatoradd.Location = New System.Drawing.Point(97, 3)
        Me.Buttonoperatoradd.Margin = New System.Windows.Forms.Padding(0)
        Me.Buttonoperatoradd.Name = "Buttonoperatoradd"
        Me.Buttonoperatoradd.Size = New System.Drawing.Size(48, 48)
        Me.Buttonoperatoradd.TabIndex = 9
        Me.Buttonoperatoradd.UseVisualStyleBackColor = False
        '
        'Buttonoperatordiv
        '
        Me.Buttonoperatordiv.BackColor = System.Drawing.Color.Navy
        Me.Buttonoperatordiv.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buttonoperatordiv.ForeColor = System.Drawing.Color.Yellow
        Me.Buttonoperatordiv.Image = Global.DesChiffresEtDesLettres.My.Resources.Resources.div
        Me.Buttonoperatordiv.Location = New System.Drawing.Point(48, 4)
        Me.Buttonoperatordiv.Margin = New System.Windows.Forms.Padding(0)
        Me.Buttonoperatordiv.Name = "Buttonoperatordiv"
        Me.Buttonoperatordiv.Size = New System.Drawing.Size(48, 48)
        Me.Buttonoperatordiv.TabIndex = 8
        Me.Buttonoperatordiv.UseVisualStyleBackColor = False
        '
        'ButtonTirage
        '
        Me.ButtonTirage.BackColor = System.Drawing.Color.Navy
        Me.ButtonTirage.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonTirage.ForeColor = System.Drawing.Color.Transparent
        Me.ButtonTirage.Location = New System.Drawing.Point(12, 14)
        Me.ButtonTirage.Name = "ButtonTirage"
        Me.ButtonTirage.Size = New System.Drawing.Size(75, 40)
        Me.ButtonTirage.TabIndex = 6
        Me.ButtonTirage.Text = "Tirage"
        Me.ButtonTirage.UseVisualStyleBackColor = False
        '
        'ListBoxresult
        '
        Me.ListBoxresult.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ListBoxresult.BackColor = System.Drawing.Color.LemonChiffon
        Me.ListBoxresult.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxresult.FormattingEnabled = True
        Me.ListBoxresult.ItemHeight = 19
        Me.ListBoxresult.Location = New System.Drawing.Point(11, 42)
        Me.ListBoxresult.Name = "ListBoxresult"
        Me.ListBoxresult.Size = New System.Drawing.Size(52, 156)
        Me.ListBoxresult.TabIndex = 62
        '
        'panelscore
        '
        Me.panelscore.BackColor = System.Drawing.Color.Cornsilk
        Me.panelscore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panelscore.Controls.Add(Me.ptsplayer)
        Me.panelscore.Controls.Add(Me.ptspc)
        Me.panelscore.Controls.Add(Me.Labelplayer)
        Me.panelscore.Controls.Add(Me.Labelpc)
        Me.panelscore.Location = New System.Drawing.Point(212, 72)
        Me.panelscore.Name = "panelscore"
        Me.panelscore.Size = New System.Drawing.Size(229, 80)
        Me.panelscore.TabIndex = 43
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
        Me.Labelpc.Name = "Labelpc"
        Me.Labelpc.Size = New System.Drawing.Size(160, 30)
        Me.Labelpc.TabIndex = 0
        Me.Labelpc.Text = "ordinateur"
        Me.Labelpc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Labelpc.UseCompatibleTextRendering = True
        '
        'PanelSevenseg
        '
        Me.PanelSevenseg.BackColor = System.Drawing.Color.Transparent
        Me.PanelSevenseg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelSevenseg.Controls.Add(Me.unitpic)
        Me.PanelSevenseg.Controls.Add(Me.hundredpic)
        Me.PanelSevenseg.Controls.Add(Me.tenpic)
        Me.PanelSevenseg.Location = New System.Drawing.Point(774, 39)
        Me.PanelSevenseg.Name = "PanelSevenseg"
        Me.PanelSevenseg.Size = New System.Drawing.Size(164, 64)
        Me.PanelSevenseg.TabIndex = 9
        '
        'unitpic
        '
        Me.unitpic.BackColor = System.Drawing.Color.MintCream
        Me.unitpic.Location = New System.Drawing.Point(88, 9)
        Me.unitpic.Name = "unitpic"
        Me.unitpic.Size = New System.Drawing.Size(68, 43)
        Me.unitpic.TabIndex = 8
        Me.unitpic.TabStop = False
        '
        'hundredpic
        '
        Me.hundredpic.BackColor = System.Drawing.Color.MintCream
        Me.hundredpic.Location = New System.Drawing.Point(3, 4)
        Me.hundredpic.Name = "hundredpic"
        Me.hundredpic.Size = New System.Drawing.Size(36, 49)
        Me.hundredpic.TabIndex = 6
        Me.hundredpic.TabStop = False
        '
        'tenpic
        '
        Me.tenpic.BackColor = System.Drawing.Color.MintCream
        Me.tenpic.Location = New System.Drawing.Point(45, 3)
        Me.tenpic.Name = "tenpic"
        Me.tenpic.Size = New System.Drawing.Size(37, 54)
        Me.tenpic.TabIndex = 7
        Me.tenpic.TabStop = False
        '
        'Timerhundred
        '
        '
        'Timerten
        '
        '
        'Timerunit
        '
        '
        'Timertirage
        '
        '
        'Timerfree
        '
        '
        'Timerprogressbar
        '
        '
        'Buttonnextgame
        '
        Me.Buttonnextgame.BackColor = System.Drawing.Color.MidnightBlue
        Me.Buttonnextgame.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buttonnextgame.ForeColor = System.Drawing.Color.Gold
        Me.Buttonnextgame.Location = New System.Drawing.Point(77, 50)
        Me.Buttonnextgame.Name = "Buttonnextgame"
        Me.Buttonnextgame.Size = New System.Drawing.Size(119, 45)
        Me.Buttonnextgame.TabIndex = 44
        Me.Buttonnextgame.Text = "Continuez"
        Me.Buttonnextgame.UseVisualStyleBackColor = False
        '
        'Groupchrono
        '
        Me.Groupchrono.BackColor = System.Drawing.Color.Cornsilk
        Me.Groupchrono.Controls.Add(Me.Combosec)
        Me.Groupchrono.Controls.Add(Me.Labelsec)
        Me.Groupchrono.Controls.Add(Me.nochrono)
        Me.Groupchrono.Controls.Add(Me.chrono)
        Me.Groupchrono.Location = New System.Drawing.Point(509, 44)
        Me.Groupchrono.Name = "Groupchrono"
        Me.Groupchrono.Size = New System.Drawing.Size(152, 85)
        Me.Groupchrono.TabIndex = 46
        Me.Groupchrono.TabStop = False
        '
        'Combosec
        '
        Me.Combosec.DropDownHeight = 80
        Me.Combosec.DropDownWidth = 10
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
        Me.Labelsec.Location = New System.Drawing.Point(65, 7)
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
        Me.nochrono.Location = New System.Drawing.Point(5, 39)
        Me.nochrono.Margin = New System.Windows.Forms.Padding(0)
        Me.nochrono.Name = "nochrono"
        Me.nochrono.Size = New System.Drawing.Size(53, 45)
        Me.nochrono.TabIndex = 46
        Me.nochrono.TabStop = True
        Me.nochrono.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.nochrono.UseVisualStyleBackColor = False
        '
        'chrono
        '
        Me.chrono.BackColor = System.Drawing.Color.Transparent
        Me.chrono.Checked = True
        Me.chrono.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chrono.Image = Global.DesChiffresEtDesLettres.My.Resources.Resources.chronometer
        Me.chrono.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chrono.Location = New System.Drawing.Point(6, 4)
        Me.chrono.Name = "chrono"
        Me.chrono.Size = New System.Drawing.Size(53, 45)
        Me.chrono.TabIndex = 45
        Me.chrono.TabStop = True
        Me.chrono.UseVisualStyleBackColor = False
        '
        'Paneltimer
        '
        Me.Paneltimer.BackColor = System.Drawing.Color.Transparent
        Me.Paneltimer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Paneltimer.Controls.Add(Me.colonpic)
        Me.Paneltimer.Controls.Add(Me.unitminpic)
        Me.Paneltimer.Controls.Add(Me.unitsecpic)
        Me.Paneltimer.Controls.Add(Me.tensecpic)
        Me.Paneltimer.Location = New System.Drawing.Point(787, 189)
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
        'ToolStripButtonChrono
        '
        Me.ToolStripButtonChrono.AutoSize = False
        Me.ToolStripButtonChrono.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripButtonChrono.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonChrono.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButtonChrono.Image = Global.DesChiffresEtDesLettres.My.Resources.Resources.chrono_fw
        Me.ToolStripButtonChrono.ImageAlign = System.Drawing.ContentAlignment.TopLeft
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
        Me.ToolStripButtonNew.Text = "Nouveau"
        Me.ToolStripButtonNew.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.AutoSize = False
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(1, 35)
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
        'Labelstatus
        '
        Me.Labelstatus.BackColor = System.Drawing.Color.Transparent
        Me.Labelstatus.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelstatus.Location = New System.Drawing.Point(8, 50)
        Me.Labelstatus.Name = "Labelstatus"
        Me.Labelstatus.Size = New System.Drawing.Size(60, 19)
        Me.Labelstatus.TabIndex = 60
        '
        'ToolStripchiffres
        '
        Me.ToolStripchiffres.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ToolStripchiffres.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButtonChrono, Me.ToolStripSeparator2, Me.ToolStripButtonNew, Me.ToolStripSeparator1, Me.ToolStripButtonSolution, Me.ToolStripSeparator5, Me.ToolStripButtonOral, Me.ToolStripSeparator3, Me.ToolStripButtonHelp, Me.ToolStripSeparator4, Me.ToolStripButtonMainMenu, Me.ToolStripSeparator6, Me.ToolStripButtonQuit})
        Me.ToolStripchiffres.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripchiffres.Name = "ToolStripchiffres"
        Me.ToolStripchiffres.Size = New System.Drawing.Size(1008, 38)
        Me.ToolStripchiffres.TabIndex = 59
        Me.ToolStripchiffres.Text = "ToolStrip1"
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
        'ToolStripButtonOral
        '
        Me.ToolStripButtonOral.AutoSize = False
        Me.ToolStripButtonOral.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripButtonOral.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonOral.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButtonOral.Image = Global.DesChiffresEtDesLettres.My.Resources.Resources.listen_fw
        Me.ToolStripButtonOral.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButtonOral.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonOral.Name = "ToolStripButtonOral"
        Me.ToolStripButtonOral.Size = New System.Drawing.Size(93, 35)
        Me.ToolStripButtonOral.Text = "Ecouter"
        '
        'Panelsolution
        '
        Me.Panelsolution.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panelsolution.BackColor = System.Drawing.Color.LemonChiffon
        Me.Panelsolution.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panelsolution.Controls.Add(Me.Buttonclose)
        Me.Panelsolution.Controls.Add(Me.ListBoxresult)
        Me.Panelsolution.Location = New System.Drawing.Point(741, 341)
        Me.Panelsolution.Name = "Panelsolution"
        Me.Panelsolution.Size = New System.Drawing.Size(116, 210)
        Me.Panelsolution.TabIndex = 63
        '
        'Buttonclose
        '
        Me.Buttonclose.BackColor = System.Drawing.Color.Transparent
        Me.Buttonclose.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buttonclose.Image = Global.DesChiffresEtDesLettres.My.Resources.Resources.buttonclose_fw
        Me.Buttonclose.Location = New System.Drawing.Point(3, 3)
        Me.Buttonclose.Margin = New System.Windows.Forms.Padding(0)
        Me.Buttonclose.Name = "Buttonclose"
        Me.Buttonclose.Size = New System.Drawing.Size(80, 30)
        Me.Buttonclose.TabIndex = 63
        Me.Buttonclose.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gainsboro
        Me.Button1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Button1.Location = New System.Drawing.Point(98, 566)
        Me.Button1.Margin = New System.Windows.Forms.Padding(0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 36)
        Me.Button1.TabIndex = 64
        Me.Button1.Text = "1234567"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Formchiffre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1008, 691)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panelsolution)
        Me.Controls.Add(Me.Labelstatus)
        Me.Controls.Add(Me.ToolStripchiffres)
        Me.Controls.Add(Me.Paneltimer)
        Me.Controls.Add(Me.panelscore)
        Me.Controls.Add(Me.Buttonnextgame)
        Me.Controls.Add(Me.Groupchrono)
        Me.Controls.Add(Me.PanelMath)
        Me.Controls.Add(Me.PanelSevenseg)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1024, 730)
        Me.Name = "Formchiffre"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.PanelMath.ResumeLayout(False)
        Me.Groupchiffres.ResumeLayout(False)
        Me.Grouptool.ResumeLayout(False)
        Me.Groupoperators.ResumeLayout(False)
        Me.panelscore.ResumeLayout(False)
        Me.PanelSevenseg.ResumeLayout(False)
        CType(Me.unitpic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hundredpic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tenpic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Groupchrono.ResumeLayout(False)
        Me.Paneltimer.ResumeLayout(False)
        CType(Me.colonpic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.unitminpic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.unitsecpic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tensecpic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStripchiffres.ResumeLayout(False)
        Me.ToolStripchiffres.PerformLayout()
        Me.Panelsolution.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PanelMath As System.Windows.Forms.Panel
    Friend WithEvents nombre1 As System.Windows.Forms.Button
    Friend WithEvents nombre6 As System.Windows.Forms.Button
    Friend WithEvents nombre5 As System.Windows.Forms.Button
    Friend WithEvents nombre4 As System.Windows.Forms.Button
    Friend WithEvents nombre3 As System.Windows.Forms.Button
    Friend WithEvents nombre2 As System.Windows.Forms.Button
    Friend WithEvents PanelSevenseg As System.Windows.Forms.Panel
    Friend WithEvents unitpic As System.Windows.Forms.PictureBox
    Friend WithEvents hundredpic As System.Windows.Forms.PictureBox
    Friend WithEvents tenpic As System.Windows.Forms.PictureBox
    Friend WithEvents Timerhundred As System.Windows.Forms.Timer
    Friend WithEvents Timerten As System.Windows.Forms.Timer
    Friend WithEvents Timerunit As System.Windows.Forms.Timer
    Friend WithEvents ButtonTirage As System.Windows.Forms.Button
    Friend WithEvents Timertirage As System.Windows.Forms.Timer
    Friend WithEvents Timerfree As System.Windows.Forms.Timer
    Friend WithEvents Buttonoperatorsub As System.Windows.Forms.Button
    Friend WithEvents Buttonoperatoradd As System.Windows.Forms.Button
    Friend WithEvents Buttonoperatordiv As System.Windows.Forms.Button
    Friend WithEvents Groupoperators As System.Windows.Forms.GroupBox
    Friend WithEvents Grouptool As System.Windows.Forms.GroupBox
    Friend WithEvents Buttonreset As System.Windows.Forms.Button
    Friend WithEvents GroupBoxequation As System.Windows.Forms.GroupBox
    Friend WithEvents Groupchiffres As System.Windows.Forms.GroupBox
    Friend WithEvents Buttonerase As System.Windows.Forms.Button
    Friend WithEvents Timerprogressbar As System.Windows.Forms.Timer
    Friend WithEvents panelscore As System.Windows.Forms.Panel
    Friend WithEvents Labelplayer As System.Windows.Forms.Label
    Friend WithEvents Labelpc As System.Windows.Forms.Label
    Friend WithEvents ptsplayer As System.Windows.Forms.Label
    Friend WithEvents ptspc As System.Windows.Forms.Label
    Friend WithEvents Buttonnextgame As System.Windows.Forms.Button
    Friend WithEvents Groupchrono As System.Windows.Forms.GroupBox
    Friend WithEvents nochrono As System.Windows.Forms.RadioButton
    Friend WithEvents chrono As System.Windows.Forms.RadioButton
    Friend WithEvents Combosec As System.Windows.Forms.ComboBox
    Friend WithEvents Labelsec As System.Windows.Forms.Label
    Friend WithEvents Paneltimer As System.Windows.Forms.Panel
    Friend WithEvents colonpic As System.Windows.Forms.PictureBox
    Friend WithEvents unitminpic As System.Windows.Forms.PictureBox
    Friend WithEvents unitsecpic As System.Windows.Forms.PictureBox
    Friend WithEvents tensecpic As System.Windows.Forms.PictureBox
    Friend WithEvents ToolStripButtonChrono As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButtonHelp As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButtonMainMenu As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonQuit As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Labelstatus As System.Windows.Forms.Label
    Friend WithEvents ListBoxresult As System.Windows.Forms.ListBox
    Friend WithEvents ToolStripchiffres As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButtonSolution As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButtonOral As System.Windows.Forms.ToolStripButton
    Friend WithEvents Panelsolution As System.Windows.Forms.Panel
    Friend WithEvents Buttonclose As System.Windows.Forms.Button
    Friend WithEvents Buttonoperatormult As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
