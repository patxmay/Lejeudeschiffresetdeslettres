Public Class Formchoosenletter
#Region "declaration"
    Private Class classletterdata
        Public used As Boolean
        Public value As String
        Public pic As PictureBox
    End Class
    Private indexletter As Integer
    Private flagckickX As Boolean = True
    Private flagquit As Boolean = True
    Private listcaseorigine As New List(Of Point)
    Private listcasetarget As New List(Of Point)
    Private imagesupport As Image
    Private imagepanelletters As Image
    Private listlettre As New List(Of classletterdata)
    Private listsolution As New List(Of String)
    Private Const NUMBERLETTERS As Integer = 10
    Private Const WIDTHCARD As Integer = 86
    Private Const HEIGHTCARD As Integer = 86
    Private solutionlettre As LettreSolution
    Private lettre As String
    Public Shared t As Integer
    Public Shared limittime As Integer
    Private insidegroupchrono As Boolean
    Private flagdel As Boolean
    Const SEGMENTTIMER As Integer = 20
    Private tensec, unitsec, unitmin As Integer
    Private digitsecunitobj As Classsevensegment
    Private digitsectenobj As Classsevensegment
    Private digitminunitobj As Classsevensegment
    Private colonminuteobj As Classsevensegment
    Private countertime As Integer
    Private countervoyelle As Integer
    Private flagresult As Boolean
    Private wordplayer(NUMBERLETTERS - 1) As Char
    Private thetimespan As New TimeSpan
    Private lastmouselocation As New Point
    Private starttime As New DateTime
    Private imagechoosenletters As Image
    Private stringofletters As String

    Private WithEvents backgroundWorker1 As New System.ComponentModel.BackgroundWorker
    Delegate Function ButtonSolutionToTrue() As Boolean
    Private ModifyButton As ButtonSolutionToTrue = New ButtonSolutionToTrue(AddressOf ChangeTrueButton)
    Private helpmenu As New Classhelp("help10lettres.txt")
    Private WithEvents keyboard As New Classkeyboard
#End Region

#Region "initialize"
    Private Sub InitListCaseOrigine()
        Dim origine As Point
        Dim top, left As Integer
        top = 10 + support.Top
        left = 20 + support.Left
        listcaseorigine.Clear()
        For iter = 0 To 9
            origine = New Point(left, top)
            listcaseorigine.Add(origine)
            left += WIDTHCARD
        Next
    End Sub
    Private Sub InitListCaseTarget()
        Dim origine As Point
        Dim top, left As Integer
         top = 10
        left = 20
        listcasetarget.Clear()
        For iter = 0 To 9
            origine = New Point(left, top)
            listcasetarget.Add(origine)
            left += WIDTHCARD
        Next
    End Sub

    Private Sub InitPanelJeu()
        Dim left, top As Integer
      
        top = 20

        For x As Integer = 0 To 9
            Controls.RemoveByKey("lettres" & x.ToString)
        Next
        indexletter = 0
        InitListCaseOrigine()
        InitListCaseTarget()
        listlettre.Clear()
        For iter = 0 To NUMBERLETTERS - 1
            Dim letterdata As New classletterdata
            Dim picletter As New PictureBox
            With letterdata
                .used = False
                .value = String.Empty
                '  .index = iter
                With picletter
                    .BackColor = Color.LightGoldenrodYellow
                    .Width = WIDTHCARD
                    .Height = HEIGHTCARD
                    .Name = "lettres" & iter.ToString
                    .Enabled = False
                    .BorderStyle = BorderStyle.Fixed3D
                    .Location = New Point(listcaseorigine(iter).X, listcaseorigine(iter).Y)
                    .Tag = iter
                End With
                .pic = picletter
                listlettre.Add(letterdata)
                Me.Controls.Add(listlettre(iter).pic)
                listlettre(iter).pic.BringToFront()
            End With
            AddHandler listlettre(iter).pic.Paint, AddressOf thepicPaint
            left += picletter.Width
        Next
        With PanelLettres
            .BackColor = Color.Transparent
            .BorderStyle = BorderStyle.None
            .BackgroundImage = imagepanelletters
            .BackgroundImageLayout = ImageLayout.None
            .Size = imagepanelletters.Size
            .Top = support.Bottom + 10
            .Left = support.Left
        End With
        Paneltimer.Location = New Point(ClientSize.Width \ 2 - Paneltimer.Width \ 2, PanelLettres.Bottom + 6)
    End Sub

    

    Private Sub InitPanelTimer()
        Dim brushseg As System.Drawing.Brush = Brushes.Black
        Dim brushbox As System.Drawing.Brush = Brushes.MintCream
        digitsecunitobj = New Classsevensegment(SEGMENTTIMER, brushseg, brushbox)
        digitsectenobj = New Classsevensegment(SEGMENTTIMER, brushseg, brushbox)
        digitminunitobj = New Classsevensegment(SEGMENTTIMER, brushseg, brushbox)
        colonminuteobj = New Classsevensegment(SEGMENTTIMER, brushseg, brushbox)
        unitminpic.Width = digitminunitobj.GetwidthBox
        unitminpic.Height = digitminunitobj.GetHeightBox
        unitminpic.Location = New Point(1, 1)
        colonpic.Width = colonminuteobj.GetwidthBox
        colonpic.Height = colonminuteobj.GetHeightBox
        colonpic.Location = New Point(unitminpic.Right, unitminpic.Top)
        tensecpic.Height = digitsectenobj.GetHeightBox
        tensecpic.Width = digitsectenobj.GetwidthBox
        tensecpic.Location = New Point(colonpic.Right, unitminpic.Top)
        unitsecpic.Width = digitsecunitobj.GetwidthBox
        unitsecpic.Height = digitsecunitobj.GetHeightBox
        unitsecpic.Location = New Point(tensecpic.Right, tensecpic.Top)
        Paneltimer.Width = unitsecpic.Width * 4 + 4
        Paneltimer.Height = unitsecpic.Height + 3
        unitmin = limittime \ 60
        tensec = (limittime Mod 60) \ 10
        unitsec = (limittime Mod 60) Mod 10
    End Sub

#End Region
   

#Region "process"
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        imagechoosenletters = CType(My.Resources.ResourceManager.GetObject("choosenletters"), Bitmap)
        imagesupport = CType(My.Resources.ResourceManager.GetObject("support"), Bitmap)
        imagepanelletters = CType(My.Resources.ResourceManager.GetObject("panelletters"), Bitmap)
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Function ChangeTrueButton() As Boolean
        If listsolution.Count >= 0 Then
            ToolStripButtonSolution.Enabled = True
            Return True
        
        End If
       
    End Function

    Private Sub ShowAllLetters(ByVal gr As System.Drawing.Graphics, ByVal thepic As PictureBox)
        Dim myfont As New Font("arial", 34, FontStyle.Bold, GraphicsUnit.Pixel)

        Dim mesure As New SizeF
        Dim index As Integer
        Try
            index = Convert.ToInt32(thepic.Tag.ToString.Substring(0, 1))
            If index > stringofletters.Length - 1 Then
                Exit Sub
            End If
           
            mesure = gr.MeasureString(stringofletters(index), myfont)
            gr.DrawString(stringofletters(index), myfont, Brushes.Black, (thepic.Width - mesure.Width) / 2, (thepic.Height - mesure.Height) / 2)
            thepic.Tag = thepic.Tag.ToString & stringofletters(index)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        If Not flagdel Then
            indexletter += 1
        End If

    End Sub
    Private Sub ShowLettresResult()
        If listsolution.Count = 0 Then
            MessageBox.Show("Aucune solution", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        ListBoxresult.Items.Clear()

        ' ListBoxresult.Items.Add(listsolution(0).Length.ToString & " LETTRES")
        'ListBoxresult.Items.Add(Environment.NewLine)
        For Each item In listsolution
            ListBoxresult.Items.Add(item)
            ' ListBoxresult.Items.Add(Environment.NewLine)
        Next
        Labelcloud.Visible = True
        ListBoxresult.Visible = True
    End Sub

    Private Sub InitSizeListboxResult()
        Dim gr As System.Drawing.Graphics
        gr = ListBoxresult.CreateGraphics
        Dim thefont As New Font(ListBoxresult.Font.Name, ListBoxresult.Font.Size, ListBoxresult.Font.Style)
        Dim fmt As StringFormat = New StringFormat(StringFormat.GenericTypographic)
        fmt.FormatFlags = StringFormatFlags.MeasureTrailingSpaces
        Dim size As SizeF
        size = gr.MeasureString(" MMMMMMMMMMM", thefont, 0, fmt)
        Labelcloud.Location = New Point(3, ToolStripChoosenLetters.Bottom + 10)
        ListBoxresult.Width = Convert.ToInt32(size.Width)
        ListBoxresult.Height = support.Top - Labelcloud.Bottom - 6

        ListBoxresult.Location = New Point(3, Labelcloud.Bottom + 3)
        ListBoxresult.Visible = False
        Labelcloud.Visible = False
    End Sub
#End Region

#Region "events"


    Private Sub getkey() Handles keyboard.akeypress
        'si on clique sur une touche du keyboard virtuel de la class classkeyboard
        Buttonvalid.Enabled = False
        If (indexletter = NUMBERLETTERS) AndAlso keyboard.getkey <> "8"c Then
            Buttonvalid.Enabled = True
            Exit Sub
        End If
        If (indexletter = NUMBERLETTERS - 1) AndAlso keyboard.getkey <> "8"c Then
            Buttonvalid.Enabled = True
            listlettre(indexletter).value = keyboard.getkey
        End If
        If (indexletter = 0) AndAlso keyboard.getkey = "8"c Then
            Exit Sub
        End If
        If keyboard.getkey <> "8"c Then
            stringofletters &= keyboard.getkey
            listlettre(indexletter).value = keyboard.getkey
            flagdel = False
        Else
            stringofletters = stringofletters.Substring(0, stringofletters.Length - 1)
            flagdel = True
            indexletter -= 1
        End If


        listlettre(indexletter).pic.Invalidate()

    End Sub

    Private Sub Formchoosenletter_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim result As DialogResult
        If Not flagquit Then
            Exit Sub
        End If
        If flagckickX Then
            result = MessageBox.Show("Voulez vous quitter ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            If result = Windows.Forms.DialogResult.Yes Then
                MessageBox.Show("Aurevoir et merci", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                e.Cancel = False
            Else
                e.Cancel = True
            End If
        Else
            MessageBox.Show("Aurevoir et merci", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub Formchoosenletter_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        indexletter = 0
    End Sub
    Private Sub Formchoosenletter_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        backgroundWorker1.WorkerSupportsCancellation = True
        Me.Location = New Point(0, 0)
        support.BackgroundImage = imagesupport
        support.Size = imagesupport.Size
        Buttonvalid.Enabled = False
        support.Location = New Point(ClientSize.Width \ 2 - support.Width \ 2, Buttonvalid.Bottom + 6)
        ListBoxresult.Visible = False
        Timerprogressbar.Stop()
        InitPanelTimer()
        InitPanelJeu()
        ToolStripButtonSolution.Enabled = False
        InitSizeListboxResult()
        Me.Controls.Add(keyboard)
        keyboard.Location = New Point(ClientSize.Width \ 2 - keyboard.Width \ 2, ToolStripChoosenLetters.Bottom + Convert.ToInt32(2.5 * imagechoosenletters.Height))
        Buttonvalid.Location = New Point(ClientSize.Width \ 2 - Buttonvalid.Width \ 2, keyboard.Bottom + 3)

    End Sub


    Private Sub thepicPaint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs)

        If stringofletters <> String.Empty Then
            ShowAllLetters(e.Graphics, DirectCast(sender, PictureBox))
        End If

    End Sub
   
    Private Sub unitminpic_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles unitminpic.Paint
        digitminunitobj.DrawDigit(e.Graphics, unitmin)

    End Sub

    Private Sub tensecpic_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles tensecpic.Paint
        digitsectenobj.DrawDigit(e.Graphics, tensec)
    End Sub

    Private Sub unitsecpic_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles unitsecpic.Paint
        digitsecunitobj.DrawDigit(e.Graphics, unitsec)
    End Sub

    Private Sub colonpic_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles colonpic.Paint
        colonminuteobj.DrawDrawColon(e.Graphics)
    End Sub
    Private Sub Formchoosenletter_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Try
            e.Graphics.DrawImage(imagechoosenletters, ClientSize.Width \ 2 - imagechoosenletters.Width \ 2, ToolStripChoosenLetters.Bottom + imagechoosenletters.Height)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ToolStripButtonQuit_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ToolStripButtonQuit.MouseDown
        Dim result As DialogResult
        result = MessageBox.Show("Voulez vous quitter ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        If result = Windows.Forms.DialogResult.Yes Then
            flagckickX = False
            Me.Close()

        End If
    End Sub

    Private Sub ToolStripButtonMainMenu_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ToolStripButtonMainMenu.MouseDown
        flagreturn = False
        If backgroundWorker1.IsBusy Then
            backgroundWorker1.CancelAsync()
        End If
        Formpreface.Show()
        flagckickX = False
        flagquit = False
        Me.Close()
    End Sub

    Private Sub Buttonvalid_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Buttonvalid.MouseClick
        DirectCast(sender, Button).Enabled = False
        keyboard.Enabled = False
        starttime = DateTime.Now
        Timerprogressbar.Interval = 1000
        Timerprogressbar.Start()
        If Not backgroundWorker1.IsBusy Then
            backgroundWorker1.RunWorkerAsync()
        End If
    End Sub

    Private Sub backgroundWorker1_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles backgroundWorker1.DoWork
        solutionlettre = New LettreSolution(NUMBERLETTERS, stringofletters)
        listsolution.Clear()
        listsolution = solutionlettre.GetSolution(Function() backgroundWorker1.CancellationPending)
        Try
            Invoke(ModifyButton)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ToolStripButtonSolution_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ToolStripButtonSolution.MouseDown
        ShowLettresResult()
        DirectCast(sender, ToolStripButton).Enabled = False
    End Sub
    Private Sub ToolStripButtonNew_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ToolStripButtonNew.MouseDown
        If backgroundWorker1.IsBusy Then
            backgroundWorker1.CancelAsync()
        End If
        keyboard.Enabled = True
        Labelcloud.Visible = False
        ToolStripButtonSolution.Enabled = False
        Timerprogressbar.Stop()
        ListBoxresult.Visible = False
        countertime = 0
        tensec = 0
        unitsec = 0
        unitmin = 0
        Dim index As Integer
        'on remet les lettres à leur position d'origine
        For Each item As classletterdata In listlettre
            item.used = False
            item.pic.Location = New Point(listcaseorigine(index).X, listcaseorigine(index).Y)
            index += 1
            item.value = String.Empty
        Next
        While indexletter > 0
            stringofletters = stringofletters.Substring(0, stringofletters.Length - 1)
            flagdel = True
            indexletter -= 1
            listlettre(indexletter).pic.Invalidate()
        End While
        unitsecpic.Invalidate()
        tensecpic.Invalidate()
        unitminpic.Invalidate()
    End Sub
    Private Sub Timerprogressbar_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timerprogressbar.Tick
        If ToolStripButtonSolution.Enabled = True Then
            DirectCast(sender, Timer).Stop()
        End If
        thetimespan = DateTime.Now - starttime
        countertime += 1
        unitsec = (countertime Mod 60) Mod 10
        tensec = (countertime Mod 60) \ 10
        unitmin = (countertime \ 60)
        unitsecpic.Invalidate()
        tensecpic.Invalidate()
        unitminpic.Invalidate()
    End Sub
    Private Sub ToolStripButtonHelp_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ToolStripButtonHelp.MouseDown
        If helpmenu.IsDisposed Then
            helpmenu = New Classhelp("help10lettres.txt")
        End If
        Me.Controls.Add(helpmenu)
        helpmenu.Location = New Point(6, ToolStripChoosenLetters.Height * 2)
        helpmenu.BringToFront()
        helpmenu.showhelp()
    End Sub
#End Region

  
   
   Private Sub ListBoxresult_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBoxresult.SelectedIndexChanged
        Dim word() As Char
        Dim index As Integer = 0
        word = DirectCast(sender, ListBox).SelectedItem.ToString.ToCharArray
        'on remet les lettres à leur position d'origine
        For Each item As classletterdata In listlettre
            item.used = False
            item.pic.Location = New Point(listcaseorigine(index).X, listcaseorigine(index).Y)
            index += 1

        Next
        
        'on affiche les lettres du mot selectionné dans le PanelLettres
        index = 0
        For Each item In word
            For Each data As classletterdata In listlettre
                If Not data.used AndAlso data.value = item Then
                    data.pic.Location = New Point(listcasetarget(index).X + PanelLettres.Left, listcasetarget(index).Y + PanelLettres.Top)
                    data.used = True
                    index += 1
                    Exit For
                End If
            Next
           
        Next


    End Sub

   
End Class