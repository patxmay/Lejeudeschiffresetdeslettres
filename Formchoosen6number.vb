Imports System.Drawing.Drawing2D

Public Class Formchoosen6number
#Region "declaration"
    Private flagnumber As Boolean
    Private listnumber As New List(Of Int64)
    Private flagquit As Boolean = True
    Private flagckickX As Boolean = True
    Private findnumber As Int64
    Private listsolution As New List(Of List(Of String))
    Const SEGMENTTIMER As Integer = 22
    Private tensec, unitsec, unitmin As Integer
    Private digitsecunitobj As Classsevensegment
    Private digitsectenobj As Classsevensegment
    Private digitminunitobj As Classsevensegment
    Private colonminuteobj As Classsevensegment
    Private thesolution As MathSolution
    Private countertime As Integer
    Private thetimespan As New TimeSpan
    Private starttime As New DateTime
    Private oralsolution As New ClassVoice()
    Private imagechoosenumber As Image
    Private WithEvents backgroundWorker1 As New System.ComponentModel.BackgroundWorker
    Delegate Function ButtonSolutionToTrue() As Boolean
    Private ModifyButton As ButtonSolutionToTrue = New ButtonSolutionToTrue(AddressOf ChangeTrueButton)
    Private helpmenu As New Classhelp("help6nombres.txt")
#End Region
#Region "events"

    Private Sub Formchoosen6number_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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
    Private Sub Formchoosen6number_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Location = New Point(0, 0)
        backgroundWorker1.WorkerSupportsCancellation = True
        Reset()
        InitPanelTimer()
        InitSizeListboxResult()
        Me.Controls.Add(oralsolution)
    End Sub
   
   
    Private Sub TextBoxnumber1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBoxnumber1.KeyUp
        Dim res As Int64
       
        If Int64.TryParse(DirectCast(sender, TextBox).Text, res) Then
            If res = 0 Then
                MessageBox.Show("chiffre supérieur à 0 seulement", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            If Not (e.KeyCode = Keys.Back Or e.KeyCode = Keys.Delete) Then
                MessageBox.Show("chiffre seulement", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

        End If
        If enablebutton() Then
            Buttonvalid.Enabled = True
        Else
            Buttonvalid.Enabled = False
        End If
        If e.KeyCode = Keys.Enter Then
            TextBoxnumber2.Focus()
        End If

    End Sub
    Private Sub TextBoxnumber2_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBoxnumber2.KeyUp
        Dim res As Int64
        If Int64.TryParse(DirectCast(sender, TextBox).Text, res) Then
            If res = 0 Then
                MessageBox.Show("chiffre supérieur à 0 seulement", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            If Not (e.KeyCode = Keys.Back Or e.KeyCode = Keys.Delete) Then
                MessageBox.Show("chiffre seulement", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
        If enablebutton() Then
            Buttonvalid.Enabled = True
        Else
            Buttonvalid.Enabled = False
        End If
        If e.KeyCode = Keys.Enter Then
            TextBoxnumber3.Focus()
        End If
    End Sub
    Private Sub TextBoxnumber3_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBoxnumber3.KeyUp
        Dim res As Int64
        If Int64.TryParse(DirectCast(sender, TextBox).Text, res) Then
            If res = 0 Then
                MessageBox.Show("chiffre supérieur à 0 seulement", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            If Not (e.KeyCode = Keys.Back Or e.KeyCode = Keys.Delete) Then
                MessageBox.Show("chiffre seulement", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
        If enablebutton() Then
            Buttonvalid.Enabled = True
        Else
            Buttonvalid.Enabled = False
        End If
        If e.KeyCode = Keys.Enter Then
            TextBoxnumber4.Focus()
        End If
    End Sub
    Private Sub TextBoxnumber4_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBoxnumber4.KeyUp
        Dim res As Int64
       
        If Int64.TryParse(DirectCast(sender, TextBox).Text, res) Then
            If res = 0 Then
                MessageBox.Show("chiffre supérieur à 0 seulement", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            If Not (e.KeyCode = Keys.Back Or e.KeyCode = Keys.Delete) Then
                MessageBox.Show("chiffre seulement", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
        If enablebutton() Then
            Buttonvalid.Enabled = True
        Else
            Buttonvalid.Enabled = False
        End If
        If e.KeyCode = Keys.Enter Then
            TextBoxnumber5.Focus()
        End If
    End Sub
    Private Sub TextBoxnumber5_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBoxnumber5.KeyUp
        Dim res As Int64
        If Int64.TryParse(DirectCast(sender, TextBox).Text, res) Then
            If res = 0 Then
                MessageBox.Show("chiffre supérieur à 0 seulement", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            If Not (e.KeyCode = Keys.Back Or e.KeyCode = Keys.Delete) Then
                MessageBox.Show("chiffre seulement", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
        If enablebutton() Then
            Buttonvalid.Enabled = True
        Else
            Buttonvalid.Enabled = False
        End If
        If e.KeyCode = Keys.Enter Then
            TextBoxnumber6.Focus()
        End If
    End Sub
    Private Sub TextBoxnumber6_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBoxnumber6.KeyUp
        Dim res As Int64
        If Int64.TryParse(DirectCast(sender, TextBox).Text, res) Then
            If res = 0 Then
                MessageBox.Show("chiffre supérieur à 0 seulement", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            If Not (e.KeyCode = Keys.Back Or e.KeyCode = Keys.Delete) Then
                MessageBox.Show("chiffre seulement", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
        If enablebutton() Then
            Buttonvalid.Enabled = True
        Else
            Buttonvalid.Enabled = False
        End If
        If e.KeyCode = Keys.Enter Then
            TextBoxnumbertofind.Focus()
        End If
    End Sub
    Private Sub TextBoxnumbertofind_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBoxnumbertofind.KeyUp
        Dim res As Int64
        If Int64.TryParse(DirectCast(sender, TextBox).Text, res) Then
            If res = 0 Then
                MessageBox.Show("chiffre supérieur à 0 seulement", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            If Not (e.KeyCode = Keys.Back Or e.KeyCode = Keys.Delete) Then
                MessageBox.Show("chiffre seulement", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
        If enablebutton() Then
            Buttonvalid.Enabled = True
        Else
            Buttonvalid.Enabled = False
        End If
        
    End Sub
    Private Sub Buttonvalid_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Buttonvalid.MouseClick
        listnumber.Clear()
        For Each ctrl As Control In Group6nombres.Controls
            If TypeOf ctrl Is TextBox Then
                If DirectCast(ctrl, TextBox).Name = "TextBoxnumbertofind" Then
                    findnumber = Convert.ToInt64(DirectCast(ctrl, TextBox).Text)

                Else
                    listnumber.Add(Convert.ToInt64(DirectCast(ctrl, TextBox).Text))
                End If
                DirectCast(ctrl, TextBox).Enabled = False
            End If
        Next
        starttime = DateTime.Now
        Timerdigitclock.Interval = 1000
        Timerdigitclock.Start()
        DirectCast(sender, Button).Enabled = False

        If Not backgroundWorker1.IsBusy Then
            backgroundWorker1.RunWorkerAsync()
        End If


    End Sub
    Private Sub ToolStripButtonSolution_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ToolStripButtonSolution.MouseDown
        ShowChiffresResult()
        ToolStripButtonNew.Enabled = True
        DirectCast(sender, ToolStripButton).Enabled = False
    End Sub

    Private Sub ToolStripButtonMainMenu_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ToolStripButtonMainMenu.MouseDown
        If backgroundWorker1.IsBusy Then
            backgroundWorker1.CancelAsync()
        End If

        Formpreface.Show()
        flagckickX = False
        flagquit = False
        Me.Close()
    End Sub
    Private Sub ToolStripButtonHelp_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ToolStripButtonHelp.MouseDown
        If helpmenu.IsDisposed Then
            helpmenu = New Classhelp("help6nombre.txt")
        End If
        Me.Controls.Add(helpmenu)
        helpmenu.Location = New Point(6, ToolStrip6numbers.Height * 2)
        helpmenu.BringToFront()
        helpmenu.showhelp()
    End Sub
    Private Sub ToolStripButtonNew_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ToolStripButtonNew.MouseDown
        Reset()
        If backgroundWorker1.IsBusy Then
            backgroundWorker1.CancelAsync()
        End If
        If Not oralsolution.IsDisposed Then
            oralsolution.Dispose()
        End If
    End Sub
    Private Sub ToolStripButtonOral_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ToolStripButtonOral.MouseDown
        If oralsolution.IsDisposed Then
            oralsolution = New ClassVoice
            Me.Controls.Add(oralsolution)
        End If
        oralsolution.Location = New Point(ListBoxresult.Right + 10, ListBoxresult.Top)
        oralsolution.BringToFront()
        oralsolution.Visible = True
        oralsolution.thelistnumber = listnumber
        oralsolution.TexttoSpeech = listsolution
        DirectCast(sender, ToolStripButton).Enabled = False
    End Sub
    Private Sub ToolStripButtonQuit_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ToolStripButtonQuit.MouseDown
        If backgroundWorker1.IsBusy Then
            backgroundWorker1.CancelAsync()
        End If
        Dim result As DialogResult
        result = MessageBox.Show("Voulez vous quitter ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        If result = Windows.Forms.DialogResult.Yes Then
            flagckickX = False
            Me.Close()
        Else
            TextBoxnumber1.Focus()
        End If

    End Sub

    Private Sub Formchoosen6number_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Try
            e.Graphics.DrawImage(imagechoosenumber, ClientSize.Width \ 2 - imagechoosenumber.Width \ 2, ToolStrip6numbers.Bottom + 12)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub Timerdigitclock_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timerdigitclock.Tick
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

    Private Sub backgroundWorker1_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles backgroundWorker1.DoWork


        Dim number As Int64
        number = findnumber
        If backgroundWorker1.CancellationPending Then
            e.Cancel = True
        End If
        thesolution = New MathSolution(listnumber, number)
        listsolution = thesolution.FindSolution(Function() backgroundWorker1.CancellationPending, number, Function() isflagchrono())
        Try
            If listsolution.Count > 0 Then
                Invoke(ModifyButton)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub colonpic_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles colonpic.Paint
        colonminuteobj.DrawDrawColon(e.Graphics)
    End Sub

    Private Sub tensecpic_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles tensecpic.Paint
        digitsectenobj.DrawDigit(e.Graphics, tensec)
    End Sub


    Private Sub unitminpic_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles unitminpic.Paint
        digitminunitobj.DrawDigit(e.Graphics, unitmin)
    End Sub

    Private Sub unitsecpic_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles unitsecpic.Paint
        digitsecunitobj.DrawDigit(e.Graphics, unitsec)
    End Sub

#End Region
#Region "design and process"
    Private Function isflagchrono() As Boolean
        Return False
    End Function
    Private Sub InitPanelTimer()
        Dim brushseg As System.Drawing.Brush = Brushes.Black
        Dim brushbox As System.Drawing.Brush = Brushes.MintCream
        unitmin = 0
        tensec = 0
        unitsec = 0
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

    End Sub
    Private Sub InitSizeListboxResult()
        Dim gr As System.Drawing.Graphics
        gr = ListBoxresult.CreateGraphics
        Dim thefont As New Font(ListBoxresult.Font.Name, ListBoxresult.Font.Size, ListBoxresult.Font.Style)
        Dim fmt As StringFormat = New StringFormat(StringFormat.GenericTypographic)
        fmt.FormatFlags = StringFormatFlags.MeasureTrailingSpaces
        Dim size As SizeF
        Group6nombres.Location = New Point(6, ToolStrip6numbers.Bottom + imagechoosenumber.Height * 2)
        Paneltimer.Location = New Point(Group6nombres.Left + Group6nombres.Width \ 2 - Paneltimer.Width \ 2, Group6nombres.Bottom + 10)
        size = gr.MeasureString("88888888 * 888888 =888888888888", thefont, 0, fmt)
        ListBoxresult.Width = Convert.ToInt32(size.Width)
        ListBoxresult.Height = Group6nombres.Height
        ListBoxresult.Location = New Point(Group6nombres.Right + 6, Group6nombres.Top)
        ListBoxresult.Visible = False
    End Sub
    Private Sub ShowChiffresResult()
        Dim iter As Integer
        ListBoxresult.Items.Clear()
        iter = 1
        ListBoxresult.Items.Add("nombre à trouver : " & findnumber.ToString)
        For Each item In listsolution
            ListBoxresult.Items.Add("solution" & " " & iter)
            ListBoxresult.Items.AddRange(item.ToArray)
            ListBoxresult.Items.Add(Environment.NewLine)
            iter += 1
        Next

        ListBoxresult.Visible = True
    End Sub



    Private Sub Reset()
        For Each ctrl In Group6nombres.Controls
            If TypeOf ctrl Is TextBox Then
                DirectCast(ctrl, TextBox).Text = String.Empty
                DirectCast(ctrl, TextBox).Enabled = True
            End If
        Next
        flagnumber = True
        ListBoxresult.Visible = False
        Buttonvalid.Enabled = False
        ToolStripButtonSolution.Enabled = False
        ToolStripButtonNew.Enabled = True
        ListBoxresult.Items.Clear()
        Timerdigitclock.Stop()
        countertime = 0
        tensec = 0
        unitsec = 0
        unitmin = 0

        backgroundWorker1.WorkerSupportsCancellation = True
        backgroundWorker1.CancelAsync()
        ToolStripButtonOral.Enabled = False
        unitsecpic.Invalidate()
        tensecpic.Invalidate()
        unitminpic.Invalidate()
        TextBoxnumber1.Focus()
    End Sub
    Private Function enablebutton() As Boolean
        Dim res As Int64
        For Each ctrl In Group6nombres.Controls
            If TypeOf ctrl Is TextBox Then
                If Int64.TryParse(DirectCast(ctrl, TextBox).Text, res) Then
                    If res = 0 Then
                        Return False
                    End If
                Else
                    Return False
                End If
            End If
        Next
        Return True
    End Function

    Private Function ChangeTrueButton() As Boolean
        ToolStripButtonSolution.Enabled = True
        ToolStripButtonOral.Enabled = True
        Return True
    End Function
    Private Sub ShowResult()
        Dim iter As Integer
        ListBoxresult.Items.Clear()
        For Each item In listnumber
            ListBoxresult.Items.Add(item.ToString & ",")
        Next
        iter = 1
        ListBoxresult.Items.Add("nombre à trouver : " & findnumber.ToString)
        For Each item In listsolution
            ListBoxresult.Items.Add("solution" & iter)
            ListBoxresult.Items.AddRange(item.ToArray)
            ListBoxresult.Items.Add(Environment.NewLine)
            iter += 1
        Next

    End Sub
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        Try
            imagechoosenumber = CType(My.Resources.ResourceManager.GetObject("choosenumber"), Bitmap)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        ' Add any initialization after the InitializeComponent() call.

    End Sub
#End Region



    
End Class