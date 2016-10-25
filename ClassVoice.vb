Imports System.Speech
Imports System.Speech.Synthesis
Public Class ClassVoice
    Inherits Panel
#Region "declaration"
    Private Class choosennumber
        Public number As Int64
        Public choosen As Boolean
    End Class

    Private listchoosennumber As New List(Of choosennumber)
    Private Function findnumber(ByVal number As Integer) As Integer
        For iter As Integer = 0 To listchoosennumber.Count - 1
            If listchoosennumber(iter).number = number AndAlso Not listchoosennumber(iter).choosen Then
                listchoosennumber(iter).choosen = True
                Return iter
            End If
        Next
        Return -1
    End Function
    Private flagop1 As Boolean

    Private BufferredGraphic As BufferedGraphics
    Private CurrentContext As BufferedGraphicsContext
    Private lastprompt As String
    Private feuille As Bitmap
    Private readingtext As Prompt
    Private listterms As New List(Of String)
    Private terms As String = String.Empty
    Private pos As Integer = 0
    Private indexsolution As Integer = 0
    Private synth As SpeechSynthesizer
    Private listsolution As New List(Of List(Of String))
    Private listnum As New List(Of Int64)
    Friend WithEvents ToolStripButtonLast As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator11 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButtonFirst As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButtonBack As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButtonNext As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButtonStop As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButtonplay As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripComboBoxsolution As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripOral As System.Windows.Forms.ToolStrip

    Private Sub InitializeComponent()
        Me.ToolStripOral = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButtonplay = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButtonNext = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButtonBack = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButtonFirst = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButtonLast = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripComboBoxsolution = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButtonStop = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripOral.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStripOral
        '
        Me.ToolStripOral.BackColor = System.Drawing.Color.Navy
        Me.ToolStripOral.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButtonplay, Me.ToolStripSeparator8, Me.ToolStripButtonNext, Me.ToolStripSeparator9, Me.ToolStripButtonBack, Me.ToolStripSeparator10, Me.ToolStripButtonFirst, Me.ToolStripSeparator11, Me.ToolStripButtonLast, Me.ToolStripSeparator7, Me.ToolStripComboBoxsolution, Me.ToolStripSeparator1, Me.ToolStripButtonStop})
        Me.ToolStripOral.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripOral.Name = "ToolStripOral"
        Me.ToolStripOral.Size = New System.Drawing.Size(290, 32)
        Me.ToolStripOral.TabIndex = 0
        Me.ToolStripOral.Text = "ToolStrip1"
        '
        'ToolStripButtonplay
        '
        Me.ToolStripButtonplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ToolStripButtonplay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonplay.Image = Global.DesChiffresEtDesLettres.My.Resources.Resources.button_black_play
        Me.ToolStripButtonplay.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButtonplay.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonplay.Name = "ToolStripButtonplay"
        Me.ToolStripButtonplay.Size = New System.Drawing.Size(44, 29)
        Me.ToolStripButtonplay.ToolTipText = "PLAY"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 32)
        '
        'ToolStripButtonNext
        '
        Me.ToolStripButtonNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonNext.Image = Global.DesChiffresEtDesLettres.My.Resources.Resources.button_black_next
        Me.ToolStripButtonNext.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButtonNext.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonNext.Name = "ToolStripButtonNext"
        Me.ToolStripButtonNext.Size = New System.Drawing.Size(44, 29)
        Me.ToolStripButtonNext.ToolTipText = "SUIVANT"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 32)
        '
        'ToolStripButtonBack
        '
        Me.ToolStripButtonBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonBack.Enabled = False
        Me.ToolStripButtonBack.Image = Global.DesChiffresEtDesLettres.My.Resources.Resources.button_black_back
        Me.ToolStripButtonBack.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButtonBack.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonBack.Name = "ToolStripButtonBack"
        Me.ToolStripButtonBack.Size = New System.Drawing.Size(44, 29)
        Me.ToolStripButtonBack.ToolTipText = "PRECEDENT"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(6, 32)
        '
        'ToolStripButtonFirst
        '
        Me.ToolStripButtonFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonFirst.Enabled = False
        Me.ToolStripButtonFirst.Image = Global.DesChiffresEtDesLettres.My.Resources.Resources.button_black_first
        Me.ToolStripButtonFirst.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButtonFirst.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonFirst.Name = "ToolStripButtonFirst"
        Me.ToolStripButtonFirst.Size = New System.Drawing.Size(44, 29)
        Me.ToolStripButtonFirst.ToolTipText = "PREMIER"
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(6, 32)
        '
        'ToolStripButtonLast
        '
        Me.ToolStripButtonLast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ToolStripButtonLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonLast.Image = Global.DesChiffresEtDesLettres.My.Resources.Resources.button_black_last
        Me.ToolStripButtonLast.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButtonLast.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonLast.Name = "ToolStripButtonLast"
        Me.ToolStripButtonLast.Size = New System.Drawing.Size(44, 29)
        Me.ToolStripButtonLast.ToolTipText = "DERNIER"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 32)
        '
        'ToolStripComboBoxsolution
        '
        Me.ToolStripComboBoxsolution.AutoSize = False
        Me.ToolStripComboBoxsolution.AutoToolTip = True
        Me.ToolStripComboBoxsolution.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.ToolStripComboBoxsolution.DropDownHeight = 80
        Me.ToolStripComboBoxsolution.DropDownWidth = 5
        Me.ToolStripComboBoxsolution.Font = New System.Drawing.Font("Arial Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripComboBoxsolution.IntegralHeight = False
        Me.ToolStripComboBoxsolution.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.ToolStripComboBoxsolution.Name = "ToolStripComboBoxsolution"
        Me.ToolStripComboBoxsolution.Size = New System.Drawing.Size(60, 30)
        Me.ToolStripComboBoxsolution.Text = "1"
        '    Me.ToolStripComboBoxsolution.ToolTipText = "choisir une solution"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'ToolStripButtonStop
        '
        Me.ToolStripButtonStop.BackColor = System.Drawing.Color.LightGray
        Me.ToolStripButtonStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonStop.Image = Global.DesChiffresEtDesLettres.My.Resources.Resources.button_black_stop
        Me.ToolStripButtonStop.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButtonStop.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonStop.Name = "ToolStripButtonStop"
        Me.ToolStripButtonStop.Size = New System.Drawing.Size(44, 29)
        Me.ToolStripButtonStop.ToolTipText = "Fermer"
        '
        'ClassVoice
        '
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ToolStripOral.ResumeLayout(False)
        Me.ToolStripOral.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Property TexttoSpeech() As List(Of List(Of String))
        Get
            Return listsolution
        End Get
        Set(ByVal value As List(Of List(Of String)))
            listsolution = value
            If value.Count = 1 Then
                ToolStripButtonFirst.Enabled = False
                ToolStripButtonLast.Enabled = False
                ToolStripButtonNext.Enabled = False
                ToolStripButtonBack.Enabled = False
                ToolStripButtonStop.Enabled = True
                ToolStripButtonplay.Enabled = True
            End If
            ToolStripComboBoxsolution.Items.Clear()
            For iter = 0 To listsolution.Count - 1
                ToolStripComboBoxsolution.Items.Add(iter + 1)
            Next

            BufferredGraphic.Graphics.DrawImage(Me.BackgroundImage, Me.DisplayRectangle)
        End Set
    End Property
    Property thelistnumber() As List(Of Int64)
        Get
            Return listnum
        End Get
        Set(ByVal value As List(Of Int64))
            listnum = value

        End Set
    End Property
    Public Sub New()
        feuille = CType(My.Resources.ResourceManager.GetObject("feuille"), Bitmap)
        Me.BackgroundImage = feuille
        InitializeComponent()
        Controls.Add(ToolStripOral)
        Me.Size = feuille.Size
        CurrentContext = BufferedGraphicsManager.Current
        Me.Visible = False
        BufferredGraphic = Me.CurrentContext.Allocate(Me.CreateGraphics(), Me.DisplayRectangle)
        BufferredGraphic.Graphics.SmoothingMode = Drawing2D.SmoothingMode.HighQuality

    End Sub

   
#End Region

#Region "processing"
    Private Sub ConvertOperatorToWord()
        For Each item In listsolution(indexsolution)
            item = item.Replace("*", "fois")

        Next
    End Sub
    Private Sub PlayText()
        InitListChoosenNumber()
        Dim readingstr As String
        BufferredGraphic.Graphics.DrawImage(Me.BackgroundImage, Me.DisplayRectangle)
        ConvertOperatorToWord()
        synth = New SpeechSynthesizer
        synth.SetOutputToDefaultAudioDevice()
        synth.SelectVoice("ScanSoft Virginie_Dri40_16kHz")
        ' synth.SelectVoice("Microsoft Server Speech Text to Speech Voice (fr-fr, Hortense)")
        synth.Rate = 0
        lastprompt = String.Empty
        AddHandler synth.SpeakCompleted, AddressOf synth_SpeakCompleted
        AddHandler synth.SpeakProgress, AddressOf synth_Speakprogress
        Try
            synth.Speak("Solution " & (indexsolution + 1).ToString)
            For iter As Integer = 0 To listsolution(indexsolution).Count - 1
                readingstr = listsolution(indexsolution).ElementAt(iter)
                readingstr = readingstr.Replace("*", "fois")
                readingstr = readingstr.Replace("-", "moins")
                readingstr = readingstr.Replace("/", "divisé par")
                readingstr = readingstr.Replace("=", "égale")
                readingtext = New Prompt(readingstr)

                synth.SpeakAsync(readingtext)
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub synth_SpeakCompleted(ByVal sender As Object, ByVal e As SpeakCompletedEventArgs)

        If readingtext.IsCompleted Then
            ToolStripButtonplay.Enabled = True
            pos = 0
            listterms.Clear()
            terms = String.Empty
            ' synth.Dispose()
            ToolStripButtonplay.Enabled = True
            If indexsolution = listsolution.Count - 1 Then
                ToolStripButtonNext.Enabled = False
                ToolStripButtonLast.Enabled = False
                If indexsolution = 0 Then
                    ToolStripButtonFirst.Enabled = False
                    ToolStripButtonBack.Enabled = False
                Else
                    ToolStripButtonFirst.Enabled = True
                    ToolStripButtonBack.Enabled = True
                End If

            ElseIf indexsolution = 0 Then
                ToolStripButtonNext.Enabled = True
                ToolStripButtonLast.Enabled = True
                ToolStripButtonFirst.Enabled = False
                ToolStripButtonBack.Enabled = False
            Else
                ToolStripButtonNext.Enabled = True
                ToolStripButtonLast.Enabled = True
                ToolStripButtonFirst.Enabled = True
                ToolStripButtonBack.Enabled = True
            End If
        End If
    End Sub

    Private Sub synth_Speakprogress(ByVal sender As Object, ByVal e As SpeakProgressEventArgs)
        Dim vectorsplit() As String
        Dim readingstr As String

        If pos >= listsolution(indexsolution).Count Or e.Text = "divisé" Then
            Exit Sub
        End If
        readingstr = e.Text
        readingstr = readingstr.Replace("fois", "*")
        readingstr = readingstr.Replace("moins", "-")
        readingstr = readingstr.Replace("par", "/")
        readingstr = readingstr.Replace("égale", "=")
        vectorsplit = listsolution(indexsolution).ElementAt(pos).Split(New Char() {}, StringSplitOptions.RemoveEmptyEntries)
        If readingstr.Contains("Solution") Then
            lastprompt = readingstr
            Exit Sub
        End If

        If terms.EndsWith(Environment.NewLine) Then
            terms = String.Empty
        End If

        If lastprompt = readingstr AndAlso (terms <> String.Empty) Then
            Exit Sub
        Else
            lastprompt = readingstr
        End If

        If terms = String.Empty And readingstr <> vectorsplit(0) And Not (readingstr.Contains("*") Or readingstr.Contains("/") Or readingstr.Contains("+") Or readingstr.Contains("-")) Then
            terms = vectorsplit(0) & " "
        ElseIf (terms.Trim.Length = readingstr.Trim.Length) And (readingstr.Trim = terms.Trim) Then
            terms = readingstr & " "
        ElseIf Not (readingstr.Contains("*") Or readingstr.Contains("/") Or readingstr.Contains("+") Or readingstr.Contains("-")) Or readingstr.Length = 1 Then
            terms &= readingstr & " "
        Else
            terms = readingstr & " "
        End If

        If listterms.Count > 0 Then
            If Not listterms(listterms.Count - 1).Contains("=") Then
                listterms.RemoveAt(listterms.Count - 1)
            ElseIf (terms.IndexOf("=") > 0) AndAlso (terms.Length - terms.IndexOf("=")) > 0 Then
                listterms.RemoveAt(listterms.Count - 1)

            End If

        End If

        listterms.Add(terms)
       
        Dim x As Integer
        x = terms.IndexOf("=")
        If x > 0 Then
            flagop1 = True

            If terms.Substring(x + 1).Trim <> String.Empty Then
                pos += 1
                terms &= Environment.NewLine
            End If
        End If

        showstring()
        ClassVoice_Paint(Me, New PaintEventArgs(Me.BufferredGraphic.Graphics, Me.DisplayRectangle))



    End Sub
    Private Sub InitListChoosenNumber()
        Dim choosennum As choosennumber
        listchoosennumber.Clear()
        For Each item In listnum
            choosennum = New choosennumber
            choosennum.number = item
            choosennum.choosen = False
            listchoosennumber.Add(choosennum)
        Next
    End Sub
    Private Sub showstring()
        Dim space As Single = 0
        Dim size As SizeF
        Dim res As Integer
        Dim numbers() As String
        Dim listcoordnumber As New List(Of PointF)
        Dim dy As Integer
        Dim thefont As New Font("arial", 12, FontStyle.Bold)
        Dim fmt As StringFormat = New StringFormat(StringFormat.GenericDefault)
        fmt.FormatFlags = StringFormatFlags.MeasureTrailingSpaces
        BufferredGraphic.Graphics.DrawImage(Me.BackgroundImage, Me.DisplayRectangle)
        For iter = 0 To listnum.Count - 1
            If iter > 0 Then
                size = BufferredGraphic.Graphics.MeasureString(listnum(iter - 1).ToString & "   ", thefont, 0, fmt)
                space += size.Width
            End If
            dy = ToolStripOral.Bottom + 6
            BufferredGraphic.Graphics.DrawString(listnum(iter).ToString, thefont, Brushes.Blue, 66 + space, dy)
            Dim coords As New PointF(60 + space, dy)
            listcoordnumber.Add(coords)
        Next
        size = BufferredGraphic.Graphics.MeasureString("8", thefont, 0, fmt)
        dy += 12
        space = Convert.ToInt32(size.Height * 1) + dy

        For iter = 0 To listterms.Count - 1
            size = BufferredGraphic.Graphics.MeasureString(listterms(iter), thefont, 0, fmt)
            BufferredGraphic.Graphics.DrawString(listterms(iter), thefont, Brushes.Black, 66, space + size.Height * iter)
            space += 12
            numbers = listterms(iter).Split()

            If (numbers.Count = 2) AndAlso flagop1 Then
                Integer.TryParse(numbers(0), res)
                flagop1 = False
            End If
            If numbers.Count = 4 Then
                Integer.TryParse(numbers(2), res)
            End If
            Dim indexnum As Int32 = -1
            indexnum = findnumber(res)

        Next
        Dim mypen As New Pen(Color.Red, 2)
        dy = ToolStripOral.Bottom + 6
        For iter As Integer = 0 To listchoosennumber.Count - 1
            If listchoosennumber(iter).choosen = True Then
                BufferredGraphic.Graphics.DrawLine(mypen, listcoordnumber(iter).X, listcoordnumber(iter).Y, listcoordnumber(iter).X + 25, listcoordnumber(iter).Y + 25)
            End If

        Next

    End Sub
#End Region


#Region "events"
    Private Sub ToolStripButtonplay_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ToolStripButtonplay.MouseDown
        DirectCast(sender, ToolStripButton).Enabled = False
        flagop1 = True

        If indexsolution = listsolution.Count Then
            Exit Sub
        Else
            PlayText()
        End If
        ToolStripButtonFirst.Enabled = False
        ToolStripButtonLast.Enabled = False
        ToolStripButtonNext.Enabled = False
        ToolStripButtonBack.Enabled = False
        ToolStripButtonStop.Enabled = True
    End Sub
    Private Sub ToolStripButtonNext_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ToolStripButtonNext.MouseDown
        indexsolution += 1
        If indexsolution = listsolution.Count - 1 Then
            DirectCast(sender, ToolStripButton).Enabled = False
            ToolStripButtonFirst.Enabled = True
            ToolStripButtonLast.Enabled = False
        Else
            ToolStripButtonFirst.Enabled = True
            ToolStripButtonBack.Enabled = True
            ToolStripButtonplay.Enabled = True

        End If

    End Sub
    Private Sub ToolStripButtonBack_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ToolStripButtonBack.MouseDown
        indexsolution -= 1
        ToolStripButtonplay.Enabled = True
        If indexsolution = 0 Then
            DirectCast(sender, ToolStripButton).Enabled = False
            ToolStripButtonFirst.Enabled = False
            ToolStripButtonNext.Enabled = True
            ToolStripButtonLast.Enabled = True
        ElseIf indexsolution < 0 Then
            DirectCast(sender, ToolStripButton).Enabled = False
            ToolStripButtonFirst.Enabled = False

            ToolStripButtonNext.Enabled = True
            ToolStripButtonLast.Enabled = True
        ElseIf indexsolution < listsolution.Count Then
            ToolStripButtonFirst.Enabled = True

            ToolStripButtonNext.Enabled = True
            DirectCast(sender, ToolStripButton).Enabled = True
        End If

    End Sub

    Private Sub ClassVoice_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        '    If terms <> String.Empty Then
        Try
            BufferredGraphic.Render()
        Catch ex As Exception
            synth.Dispose()
        End Try

        '  End If

    End Sub
    Private Sub ToolStripButtonLast_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ToolStripButtonLast.MouseDown
        indexsolution = listsolution.Count - 1
        DirectCast(sender, ToolStripButton).Enabled = False
        ToolStripButtonNext.Enabled = False
        ToolStripButtonFirst.Enabled = True
        ToolStripButtonBack.Enabled = True
        ToolStripButtonplay.Enabled = True
    End Sub

    Private Sub ToolStripButtonFirst_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ToolStripButtonFirst.MouseDown
        indexsolution = 0
        DirectCast(sender, ToolStripButton).Enabled = False
        ToolStripButtonBack.Enabled = False
        ToolStripButtonplay.Enabled = True
        ToolStripButtonNext.Enabled = True
        ToolStripButtonLast.Enabled = True
    End Sub
    Private Sub ToolStripButtonStop_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ToolStripButtonStop.MouseDown
        If Not synth Is Nothing Then
            synth.Dispose()
        End If
        If Not Formchiffre Is Nothing Then
            Formchiffre.ToolStripButtonOral.Enabled = True
        End If
        If Not Formchoosen6number Is Nothing Then
            Formchoosen6number.ToolStripButtonOral.Enabled = True
        End If
        Me.Dispose()

    End Sub

    Private Sub ToolStripComboBoxsolution_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripComboBoxsolution.SelectedIndexChanged
        indexsolution = Convert.ToInt32(DirectCast(sender, ToolStripComboBox).SelectedItem) - 1
    End Sub
#End Region


   
   
End Class
