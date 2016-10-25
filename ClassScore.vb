Public Class ClassScore
#Region "declaration"
    Inherits Form
    Private buttoncloseimage As Image
    Private buttonsaveimage As Image
    Friend WithEvents player As System.Windows.Forms.Label
    Friend WithEvents Labelchrononumber As System.Windows.Forms.Label
    Friend WithEvents Labelchronoletters As System.Windows.Forms.Label
    Friend WithEvents chrononumber As System.Windows.Forms.Label
    Friend WithEvents chronoletters As System.Windows.Forms.Label
    Friend WithEvents Labelptspc As System.Windows.Forms.Label
    Friend WithEvents Labelptsplayer As System.Windows.Forms.Label
    Friend WithEvents ptspc As System.Windows.Forms.Label
    Friend WithEvents ptsplayer As System.Windows.Forms.Label
    Friend WithEvents Buttonclose As System.Windows.Forms.Button
    Friend WithEvents Labelnameplayer As System.Windows.Forms.Label
    Friend WithEvents Buttonsave As System.Windows.Forms.Button
    Friend WithEvents Labelsurname As System.Windows.Forms.Label
    Friend WithEvents Buttonabbort As System.Windows.Forms.Button
    Friend WithEvents Buttonvalid As System.Windows.Forms.Button
    Friend WithEvents TextBoxsurname As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxname As System.Windows.Forms.TextBox
    Friend WithEvents LabelName As System.Windows.Forms.Label
    Friend WithEvents Labeltitle As System.Windows.Forms.Label
    Private Sub InitializeComponent()
        Me.Labeltitle = New System.Windows.Forms.Label()
        Me.Labelnameplayer = New System.Windows.Forms.Label()
        Me.player = New System.Windows.Forms.Label()
        Me.Labelchrononumber = New System.Windows.Forms.Label()
        Me.Labelchronoletters = New System.Windows.Forms.Label()
        Me.chrononumber = New System.Windows.Forms.Label()
        Me.chronoletters = New System.Windows.Forms.Label()
        Me.Labelptspc = New System.Windows.Forms.Label()
        Me.Labelptsplayer = New System.Windows.Forms.Label()
        Me.ptspc = New System.Windows.Forms.Label()
        Me.ptsplayer = New System.Windows.Forms.Label()
        Me.Buttonclose = New System.Windows.Forms.Button()
        Me.Buttonsave = New System.Windows.Forms.Button()
        Me.Labelsurname = New System.Windows.Forms.Label()
        Me.Buttonabbort = New System.Windows.Forms.Button()
        Me.Buttonvalid = New System.Windows.Forms.Button()
        Me.TextBoxsurname = New System.Windows.Forms.TextBox()
        Me.TextBoxname = New System.Windows.Forms.TextBox()
        Me.LabelName = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Labeltitle
        '
        Me.Labeltitle.AutoSize = True
        Me.Labeltitle.BackColor = System.Drawing.Color.Transparent
        Me.Labeltitle.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labeltitle.ForeColor = System.Drawing.Color.Black
        Me.Labeltitle.Location = New System.Drawing.Point(0, 0)
        Me.Labeltitle.Name = "Labeltitle"
        Me.Labeltitle.Size = New System.Drawing.Size(100, 23)
        Me.Labeltitle.TabIndex = 0
        Me.Labeltitle.Text = "La partie est terminée" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  Voici le résultat"
        '
        'Labelnameplayer
        '
        Me.Labelnameplayer.AutoSize = True
        Me.Labelnameplayer.BackColor = System.Drawing.Color.Transparent
        Me.Labelnameplayer.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelnameplayer.Location = New System.Drawing.Point(0, 0)
        Me.Labelnameplayer.Name = "Labelnameplayer"
        Me.Labelnameplayer.Size = New System.Drawing.Size(100, 23)
        Me.Labelnameplayer.TabIndex = 0
        Me.Labelnameplayer.Text = "Nom du joueur"
        '
        'player
        '
        Me.player.AutoSize = True
        Me.player.BackColor = System.Drawing.Color.Transparent
        Me.player.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.player.ForeColor = System.Drawing.Color.Ivory
        Me.player.Location = New System.Drawing.Point(0, 0)
        Me.player.Name = "player"
        Me.player.Size = New System.Drawing.Size(100, 23)
        Me.player.TabIndex = 0
        '
        'Labelchrononumber
        '
        Me.Labelchrononumber.AutoSize = True
        Me.Labelchrononumber.BackColor = System.Drawing.Color.Transparent
        Me.Labelchrononumber.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelchrononumber.Location = New System.Drawing.Point(0, 0)
        Me.Labelchrononumber.Name = "Labelchrononumber"
        Me.Labelchrononumber.Size = New System.Drawing.Size(100, 23)
        Me.Labelchrononumber.TabIndex = 0
        Me.Labelchrononumber.Text = "chrono chiffres"
        '
        'Labelchronoletters
        '
        Me.Labelchronoletters.AutoSize = True
        Me.Labelchronoletters.BackColor = System.Drawing.Color.Transparent
        Me.Labelchronoletters.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelchronoletters.Location = New System.Drawing.Point(0, 0)
        Me.Labelchronoletters.Name = "Labelchronoletters"
        Me.Labelchronoletters.Size = New System.Drawing.Size(100, 23)
        Me.Labelchronoletters.TabIndex = 0
        Me.Labelchronoletters.Text = "chrono lettres"
        '
        'chrononumber
        '
        Me.chrononumber.AutoSize = True
        Me.chrononumber.BackColor = System.Drawing.Color.Transparent
        Me.chrononumber.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chrononumber.ForeColor = System.Drawing.Color.Ivory
        Me.chrononumber.Location = New System.Drawing.Point(0, 0)
        Me.chrononumber.Name = "chrononumber"
        Me.chrononumber.Size = New System.Drawing.Size(100, 23)
        Me.chrononumber.TabIndex = 0
        '
        'chronoletters
        '
        Me.chronoletters.AutoSize = True
        Me.chronoletters.BackColor = System.Drawing.Color.Transparent
        Me.chronoletters.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chronoletters.ForeColor = System.Drawing.Color.Ivory
        Me.chronoletters.Location = New System.Drawing.Point(0, 0)
        Me.chronoletters.Name = "chronoletters"
        Me.chronoletters.Size = New System.Drawing.Size(100, 23)
        Me.chronoletters.TabIndex = 0
        '
        'Labelptspc
        '
        Me.Labelptspc.AutoSize = True
        Me.Labelptspc.BackColor = System.Drawing.Color.Transparent
        Me.Labelptspc.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelptspc.Location = New System.Drawing.Point(0, 0)
        Me.Labelptspc.Name = "Labelptspc"
        Me.Labelptspc.Size = New System.Drawing.Size(100, 23)
        Me.Labelptspc.TabIndex = 0
        Me.Labelptspc.Text = "Points ordinateur"
        '
        'Labelptsplayer
        '
        Me.Labelptsplayer.AutoSize = True
        Me.Labelptsplayer.BackColor = System.Drawing.Color.Transparent
        Me.Labelptsplayer.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelptsplayer.Location = New System.Drawing.Point(0, 0)
        Me.Labelptsplayer.Name = "Labelptsplayer"
        Me.Labelptsplayer.Size = New System.Drawing.Size(100, 23)
        Me.Labelptsplayer.TabIndex = 0
        Me.Labelptsplayer.Text = "Points joueur"
        '
        'ptspc
        '
        Me.ptspc.AutoSize = True
        Me.ptspc.BackColor = System.Drawing.Color.Transparent
        Me.ptspc.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ptspc.ForeColor = System.Drawing.Color.Ivory
        Me.ptspc.Location = New System.Drawing.Point(0, 0)
        Me.ptspc.Name = "ptspc"
        Me.ptspc.Size = New System.Drawing.Size(100, 23)
        Me.ptspc.TabIndex = 0
        '
        'ptsplayer
        '
        Me.ptsplayer.AutoSize = True
        Me.ptsplayer.BackColor = System.Drawing.Color.Transparent
        Me.ptsplayer.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ptsplayer.ForeColor = System.Drawing.Color.Ivory
        Me.ptsplayer.Location = New System.Drawing.Point(0, 0)
        Me.ptsplayer.Name = "ptsplayer"
        Me.ptsplayer.Size = New System.Drawing.Size(100, 23)
        Me.ptsplayer.TabIndex = 0
        '
        'Buttonclose
        '
        Me.Buttonclose.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Buttonclose.Image = Global.DesChiffresEtDesLettres.My.Resources.buttonclose_fw
        Me.Buttonclose.Location = New System.Drawing.Point(0, 0)
        Me.Buttonclose.Margin = New System.Windows.Forms.Padding(0)
        Me.Buttonclose.Name = "Buttonclose"
        Me.Buttonclose.Size = New System.Drawing.Size(4, 4)
        Me.Buttonclose.TabIndex = 0
        Me.Buttonclose.UseVisualStyleBackColor = False
        '
        'Buttonsave
        '
        Me.Buttonsave.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Buttonsave.Location = New System.Drawing.Point(0, 0)
        Me.Buttonsave.Margin = New System.Windows.Forms.Padding(0)
        Me.Buttonsave.Name = "Buttonsave"
        Me.Buttonsave.Size = New System.Drawing.Size(5, 4)
        Me.Buttonsave.TabIndex = 0
        Me.Buttonsave.UseVisualStyleBackColor = True
        '
        'Labelsurname
        '
        Me.Labelsurname.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Labelsurname.BackColor = System.Drawing.Color.LightBlue
        Me.Labelsurname.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Labelsurname.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelsurname.Location = New System.Drawing.Point(901, 174)
        Me.Labelsurname.Name = "Labelsurname"
        Me.Labelsurname.Size = New System.Drawing.Size(82, 25)
        Me.Labelsurname.TabIndex = 1
        Me.Labelsurname.Text = "Prénom"
        Me.Labelsurname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Buttonabbort
        '
        Me.Buttonabbort.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Buttonabbort.BackColor = System.Drawing.Color.Transparent
        Me.Buttonabbort.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buttonabbort.Image = Global.DesChiffresEtDesLettres.My.Resources.abort_fw
        Me.Buttonabbort.Location = New System.Drawing.Point(905, 275)
        Me.Buttonabbort.Margin = New System.Windows.Forms.Padding(0)
        Me.Buttonabbort.Name = "Buttonabbort"
        Me.Buttonabbort.Size = New System.Drawing.Size(90, 30)
        Me.Buttonabbort.TabIndex = 5
        Me.Buttonabbort.UseVisualStyleBackColor = False
        '
        'Buttonvalid
        '
        Me.Buttonvalid.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Buttonvalid.BackColor = System.Drawing.Color.Transparent
        Me.Buttonvalid.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buttonvalid.Image = Global.DesChiffresEtDesLettres.My.Resources.Resources.valid_fw
        Me.Buttonvalid.Location = New System.Drawing.Point(813, 275)
        Me.Buttonvalid.Margin = New System.Windows.Forms.Padding(0)
        Me.Buttonvalid.Name = "Buttonvalid"
        Me.Buttonvalid.Size = New System.Drawing.Size(80, 30)
        Me.Buttonvalid.TabIndex = 4
        Me.Buttonvalid.UseVisualStyleBackColor = False
        '
        'TextBoxsurname
        '
        Me.TextBoxsurname.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBoxsurname.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxsurname.Location = New System.Drawing.Point(813, 243)
        Me.TextBoxsurname.MaxLength = 16
        Me.TextBoxsurname.Name = "TextBoxsurname"
        Me.TextBoxsurname.Size = New System.Drawing.Size(129, 26)
        Me.TextBoxsurname.TabIndex = 3
        '
        'TextBoxname
        '
        Me.TextBoxname.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBoxname.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxname.Location = New System.Drawing.Point(813, 211)
        Me.TextBoxname.MaxLength = 12
        Me.TextBoxname.Name = "TextBoxname"
        Me.TextBoxname.Size = New System.Drawing.Size(129, 26)
        Me.TextBoxname.TabIndex = 2
        '
        'LabelName
        '
        Me.LabelName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelName.BackColor = System.Drawing.Color.LightBlue
        Me.LabelName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelName.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelName.Location = New System.Drawing.Point(813, 174)
        Me.LabelName.Name = "LabelName"
        Me.LabelName.Size = New System.Drawing.Size(82, 25)
        Me.LabelName.TabIndex = 0
        Me.LabelName.Text = "Nom"
        Me.LabelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ClassScore
        '
        Me.BackgroundImage = Global.DesChiffresEtDesLettres.My.Resources.Resources.backgroundscore_fw
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(289, 261)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "ClassScore"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.ResumeLayout(False)

    End Sub
    Public Sub New(ByVal nameplayer As String, ByVal timernumber As Integer, ByVal timerletter As Integer, ByVal pointspc As Integer, ByVal pointsplayer As Integer)
        InitializeComponent()
        buttoncloseimage = CType(My.Resources.ResourceManager.GetObject("buttonclose_fw"), Bitmap)
        buttonsaveimage = CType(My.Resources.ResourceManager.GetObject("save_fw"), Bitmap)
        Me.Buttonclose.Image = buttoncloseimage
        Me.Buttonclose.Size = buttoncloseimage.Size
        Me.Buttonsave.Image = buttonsaveimage
        Me.Buttonsave.Size = buttonsaveimage.Size
        Controls.Add(Labelchrononumber)
        Controls.Add(Labelchronoletters)
        Controls.Add(Labelnameplayer)
        Controls.Add(Labelptspc)
        Controls.Add(Labelptsplayer)
        Controls.Add(Labeltitle)
        Controls.Add(ptspc)
        Controls.Add(ptsplayer)
        Controls.Add(player)
        Controls.Add(chronoletters)
        Controls.Add(chrononumber)
        Controls.Add(Buttonclose)
        Controls.Add(Buttonsave)
        Controls.Add(Me.Buttonabbort)
        Controls.Add(Me.TextBoxname)
        Controls.Add(Me.TextBoxsurname)
        Controls.Add(Me.Buttonvalid)
        Controls.Add(Me.Labelsurname)
        Controls.Add(Me.LabelName)
        player.Text = nameplayer
        chrononumber.Text = timernumber.ToString
        chronoletters.Text = timerletter.ToString
        ptspc.Text = pointspc.ToString
        ptsplayer.Text = pointsplayer.ToString
        db.Init()
    End Sub
#End Region

#Region "design"
    Public Sub DisplayResult()
        Me.Width = 300
        Me.Height = 300
        Me.Labeltitle.Text = "La partie est terminée" & Environment.NewLine & "Voici le résultat"
        Me.Buttonclose.Location = New Point(Me.Width \ 2 - (Buttonclose.Width + Buttonsave.Width + 6) \ 2, Me.Height - Buttonclose.Height - 6)
        Me.Buttonsave.Location = New Point(Buttonclose.Right + 6, Me.Height - Buttonsave.Height - 6)
        Me.Labeltitle.Location = New Point(Me.Width \ 2 - Labeltitle.Width \ 2, 6)
        Me.Labelnameplayer.Location = New Point(12, Labeltitle.Bottom + 6)
        Me.player.Location = New Point(Labelnameplayer.Right + 2, Labelnameplayer.Top)
        Me.Labelchrononumber.Location = New Point(12, Labelnameplayer.Bottom + 3)
        Me.chrononumber.Location = New Point(Labelchrononumber.Right + 2, Labelchrononumber.Top)
        Me.Labelchronoletters.Location = New Point(12, Labelchrononumber.Bottom + 3)
        Me.chronoletters.Location = New Point(Labelchronoletters.Right + 2, Labelchronoletters.Top)
        Me.Labelptspc.Location = New Point(12, Labelchronoletters.Bottom + 3)
        Me.ptspc.Location = New Point(Labelptspc.Right + 2, Labelptspc.Top)
        Me.Labelptsplayer.Location = New Point(12, Labelptspc.Bottom + 3)
        Me.ptsplayer.Location = New Point(Labelptspc.Right + 2, Labelptsplayer.Top)
        Me.TextBoxname.Visible = False
        Me.TextBoxsurname.Visible = False
        Me.Buttonvalid.Visible = False
        Me.Buttonabbort.Visible = False
        Me.Buttonclose.Visible = True
        Me.Buttonsave.Visible = True
        Me.Labeltitle.Visible = True
        Me.Labelnameplayer.Visible = True
        Me.player.Visible = True
        Me.Labelchrononumber.Visible = True
        Me.chrononumber.Visible = True
        Me.Labelchronoletters.Visible = True
        Me.chronoletters.Visible = True
        Me.Labelptspc.Visible = True
        Me.ptspc.Visible = True
        Me.Labelptsplayer.Visible = True
        Me.ptsplayer.Visible = True
    End Sub
    Private Sub DisplayGetName()
        Me.Width = 300
        Me.Height = 200
        Me.Buttonabbort.Location = New Point(Me.Width \ 2 - (Buttonabbort.Width + Buttonvalid.Width + 6) \ 2, Me.Height - Buttonvalid.Height - 6)
        Me.Buttonvalid.Location = New Point(Buttonabbort.Right + 6, Me.Height - Buttonabbort.Height - 6)
        Me.Labeltitle.Text = "Modifier nom et prénom du joueur"
        Me.Labeltitle.Location = New Point(Me.Width \ 2 - Labeltitle.Width \ 2, 6)
        Me.LabelName.Location = New Point(12, Me.Labeltitle.Bottom + 12)
        Me.TextBoxname.Location = New Point(LabelName.Right + 3, LabelName.Top)
        Me.Labelsurname.Location = New Point(12, Me.TextBoxname.Bottom + 6)
        Me.TextBoxsurname.Location = New Point(Labelsurname.Right + 3, Labelsurname.Top)
        Me.TextBoxname.Visible = True
        Me.TextBoxsurname.Visible = True
        Me.Buttonvalid.Visible = True
        Me.Buttonvalid.Enabled = False
        Me.Buttonabbort.Visible = True
        Me.Labeltitle.Visible = True
        Me.Buttonclose.Visible = False
        Me.Buttonsave.Visible = False

        Me.Labelnameplayer.Visible = False
        Me.player.Visible = False
        Me.Labelchrononumber.Visible = False
        Me.chrononumber.Visible = False
        Me.Labelchronoletters.Visible = False
        Me.chronoletters.Visible = False
        Me.Labelptspc.Visible = False
        Me.ptspc.Visible = False
        Me.Labelptsplayer.Visible = False
        Me.ptsplayer.Visible = False
    End Sub

#End Region

#Region "events"
    Private Sub Buttonclose_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Buttonclose.MouseClick
        db.CloseConnection()
        Me.Dispose()
       End Sub

    Private Sub Buttonclose_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Buttonclose.MouseEnter
        DirectCast(sender, Button).Cursor = Cursors.Hand
    End Sub

    Private Sub Buttonclose_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Buttonclose.MouseLeave
        DirectCast(sender, Button).Cursor = Cursors.Default
    End Sub

    Private Sub Buttonsave_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Buttonsave.MouseClick
        Dim result As DialogResult
        result = MessageBox.Show("Conserver le meme nom et prénom ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        If result = Windows.Forms.DialogResult.Yes Then
            db.InsertResult(score.nameplayer, score.surnameplayer, score.playerpoints, score.pcpoints, Dirigepartie.limittimechiffre, Dirigepartie.limittimelettre, Date.Now)
            db.CloseConnection()
            Me.Dispose()
        Else
            DisplayGetName()
        End If
    End Sub

    Private Sub Buttonsave_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Buttonsave.MouseEnter
        DirectCast(sender, Button).Cursor = Cursors.Hand
    End Sub

    Private Sub Buttonsave_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Buttonsave.MouseLeave
        DirectCast(sender, Button).Cursor = Cursors.Default
    End Sub

    Private Sub TextBoxname_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBoxname.KeyUp
        If DirectCast(sender, TextBox).Text <> String.Empty And TextBoxsurname.Text <> String.Empty Then
            Buttonvalid.Enabled = True
        Else
            Buttonvalid.Enabled = False
        End If
        If e.KeyCode = Keys.Enter Then
            TextBoxsurname.Focus()
        End If
    End Sub

    Private Sub TextBoxsurname_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBoxsurname.KeyUp
        If DirectCast(sender, TextBox).Text <> String.Empty And TextBoxname.Text <> String.Empty Then
            Buttonvalid.Enabled = True
        Else
            Buttonvalid.Enabled = False
        End If
        If e.KeyCode = Keys.Enter Then
            TextBoxname.Focus()
        End If

    End Sub

    Private Sub TextBoxname_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If DirectCast(sender, TextBox).Text <> String.Empty And TextBoxsurname.Text <> String.Empty Then
            Buttonvalid.Enabled = True
        Else
            Buttonvalid.Enabled = False
        End If
    End Sub

    Private Sub TextBoxsurname_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If DirectCast(sender, TextBox).Text <> String.Empty And TextBoxname.Text <> String.Empty Then
            Buttonvalid.Enabled = True
        Else
            Buttonvalid.Enabled = False
        End If
    End Sub
    Private Sub Buttonabbort_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Buttonabbort.MouseClick
        db.InsertResult(score.nameplayer, score.surnameplayer, score.playerpoints, score.pcpoints, Dirigepartie.limittimechiffre, Dirigepartie.limittimelettre, Date.Now)
        db.CloseConnection()
        Me.Dispose()
    End Sub
    Private Sub Buttonvalid_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Buttonvalid.MouseClick
        db.UpdateNamePlayer(TextBoxname.Text, TextBoxsurname.Text)
        score.nameplayer = TextBoxname.Text
        score.surnameplayer = TextBoxsurname.Text
        My.Settings.Nameplayer = TextBoxname.Text
        My.Settings.Surnameplayer = TextBoxsurname.Text
        My.Settings.Save()
        db.InsertResult(score.nameplayer, score.surnameplayer, score.playerpoints, score.pcpoints, Dirigepartie.limittimechiffre, Dirigepartie.limittimelettre, Date.Now)
        db.CloseConnection()
        Me.Dispose()
    End Sub
#End Region
   
   

End Class
