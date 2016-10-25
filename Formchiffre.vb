Imports System.Drawing.Drawing2D
Imports System.Threading
'Imports Microsoft.Speech.Synthesis
Imports System.Speech
Imports System.Speech.Synthesis
Public Class Formchiffre

#Region "declaration"
    Private Declare Unicode Function LoadCursorFromFile Lib "user32.dll" Alias "LoadCursorFromFileW" (ByVal filename As String) As IntPtr

    Const SEGMENTWIDTH As Integer = 32
    Const SEGMENTTIMER As Integer = 20
    Private flagquit As Boolean = True
    Private flagckickX As Boolean = True
    Private synth As SpeechSynthesizer
    Private hundred, ten, unit, tensec, unitsec, unitmin As Integer
    Private digithundredobj As Classsevensegment
    Private digittenobj As Classsevensegment
    Private digitunitobj As Classsevensegment
    Private digitsecunitobj As Classsevensegment
    Private digitsectenobj As Classsevensegment
    Private digitminunitobj As Classsevensegment
    Private colonminuteobj As Classsevensegment
    Private imageeraser As Image
    Private imagecanceleraser As Image
    Private insidegroupchrono As Boolean
    Private countertime As Integer
    Private numero As Integer
    Private numbertofind As Int64
    Private starttime As DateTime
    Private thetimespan As New TimeSpan
    Private limittime As Integer
    Private t As Integer
    Private flagchrono As Boolean
    Private indexlabel As Integer
    Private flagoperand As Boolean
    Private flagsecondoperand As Boolean
    Private flagdelete As Boolean
    Private flagresult As Boolean
    Private indexchiffre As Integer
    Private resultplayer As Integer
    Private actualoperator As String
    Private leftoperand As Integer
    Private rightoperand As Integer
    Private imageleschiffres As Image
    Private trainingimage As Image
    Private gamegimage As Image
    Private listnum As New List(Of Int64)
    Private arraylabelnumber(19) As Label
    Private arrayresult(4) As Button
    Private thelistnumber As New List(Of Int64)
    Private thesolution As MathSolution
    Private listsolution As New List(Of List(Of String))
    Private WithEvents backgroundWorker1 As New System.ComponentModel.BackgroundWorker
    Delegate Function ButtonSolutionToTrue() As Boolean
    Private ModifyButton As ButtonSolutionToTrue = New ButtonSolutionToTrue(AddressOf ChangeTrueButton)
    Private oralsolution As New ClassVoice()
    Private distribute As ClassDistribution
    Private helpmenu As New Classhelp("HelpChiffre.txt")

    Private Class termsequation
        'structure d'une equation 
        Public leftoperand As String
        Public theoperator As String
        Public rightoperand As String
        Public result As String
        Public startindex As Integer
    End Class
    Private Class resultlabel
        Public indexlabel As Integer
        Public indexresult As Integer
    End Class
    Private listresultlabel As New List(Of resultlabel)
    Private listsource As New List(Of String)
    Private listequations As New List(Of termsequation)
    Private actualtermsequation As New termsequation
#End Region


#Region "initialize"
    Private Sub InitPanelSevenseg()
        hundred = 1
        ten = 0
        unit = 0
        Timerhundred.Interval = 12
        Timerhundred.Stop()
        Timerten.Interval = 37
        Timerten.Stop()
        Timerunit.Interval = 17
        Timerunit.Stop()

        Timertirage.Stop()
        Timerfree.Stop()
    End Sub
    Private Sub InitChronoOption()
        chrono.Checked = True
        insidegroupchrono = False
        flagchrono = True
        Groupchrono.Location = New Point(ToolStripchiffres.Left + 12, ToolStripchiffres.Bottom + 8)
        Groupchrono.Visible = False
    End Sub
    Private Sub InitComboSec()
        Dim iter As Integer
        For iter = 1 To 180
            Combosec.Items.Add(iter.ToString)
        Next
        Combosec.Text = My.Settings.numbertime.ToString
        limittime = My.Settings.numbertime
        countertime = limittime

    End Sub

    Private Sub InitPanelScore()

        panelscore.Top = ToolStripchiffres.Bottom + 12 + Convert.ToInt32(Convert.ToInt32(imageleschiffres.Height * 100 / imageleschiffres.VerticalResolution))
        panelscore.Left = Me.Width \ 2 - panelscore.Width \ 2
        Labelstatus.Location = New Point(panelscore.Left - Labelstatus.Width - 6, panelscore.Top + (panelscore.Bottom - panelscore.Top - Labelstatus.Height) \ 2)
        Labelplayer.Text = nameplayer & " " & surnameplayer
        If Not flagame Then
            pcpoints = 0
            playerpoints = 0
            Buttonnextgame.Visible = False
        Else
            ToolStripButtonNew.Enabled = False
            Buttonnextgame.Visible = True
            Buttonnextgame.Enabled = False
        End If
        ptspc.Text = pcpoints.ToString
        ptsplayer.Text = playerpoints.ToString

    End Sub
    Private Sub InitPanelRandomNumber()
        Dim brushseg As System.Drawing.Brush = Brushes.Black
        Dim brushbox As System.Drawing.Brush = Brushes.MintCream
        digithundredobj = New Classsevensegment(SEGMENTWIDTH, brushseg, brushbox)
        digittenobj = New Classsevensegment(SEGMENTWIDTH, brushseg, brushbox)
        digitunitobj = New Classsevensegment(SEGMENTWIDTH, brushseg, brushbox)
        digitsecunitobj = New Classsevensegment(SEGMENTTIMER, brushseg, brushbox)
        digitsectenobj = New Classsevensegment(SEGMENTTIMER, brushseg, brushbox)
        hundredpic.Width = digithundredobj.GetwidthBox
        hundredpic.Height = digithundredobj.GetHeightBox
        hundredpic.Location = New Point(1, 1)
        tenpic.Width = digittenobj.GetwidthBox
        tenpic.Height = digittenobj.GetHeightBox
        tenpic.Location = New Point(hundredpic.Right, hundredpic.Top)
        unitpic.Width = digitunitobj.GetwidthBox
        unitpic.Height = digitunitobj.GetHeightBox
        unitpic.Location = New Point(tenpic.Right, hundredpic.Top)
        PanelSevenseg.Width = unitpic.Width * 3 + 4
        PanelSevenseg.Height = unitpic.Height + 4

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
        ' unitmin = limittime \ 60
        ' tensec = (limittime Mod 60) \ 10
        'unitsec = (limittime Mod 60) Mod 10
    End Sub


    Private Sub InitGroupoperators()
        ButtonTirage.Text = "Tirage"
        ButtonTirage.Enabled = True
        Buttonoperatorsub.Tag = "-"
        Buttonoperatormult.Tag = "x"
        Buttonoperatordiv.Tag = "/"
        Buttonoperatoradd.Tag = "+"

        FreezeOperator(True)
        PanelMath.Top = panelscore.Bottom + 12
        PanelMath.Left = Me.Width \ 2 - PanelMath.Width \ 2 - 30
        Buttonnextgame.Left = PanelMath.Left - 3 - Buttonnextgame.Width
        Buttonnextgame.Top = PanelMath.Top
       
        InitSizeListboxResult()


    End Sub
    Private Sub InitSizeListboxResult()
        Dim gr As System.Drawing.Graphics
        gr = ListBoxresult.CreateGraphics
        Dim thefont As New Font(ListBoxresult.Font.Name, ListBoxresult.Font.Size, ListBoxresult.Font.Style)
        Dim fmt As StringFormat = New StringFormat(StringFormat.GenericTypographic)
        fmt.FormatFlags = StringFormatFlags.MeasureTrailingSpaces
        Dim size As SizeF
        size = gr.MeasureString("   8888888 * 88888 = 8888888    ", thefont, 0, fmt)
        ListBoxresult.Width = Convert.ToInt32(size.Width)
        ListBoxresult.Height = PanelMath.Height
        Panelsolution.Width = ListBoxresult.Width + 3
        Panelsolution.Height = ListBoxresult.Height + 3 + Buttonclose.Height
        Buttonclose.Location = New Point(1, 1)
        ListBoxresult.Location = New Point(1, Buttonclose.Bottom + 2)
        Panelsolution.Location = New Point(1, PanelMath.Top)
        Panelsolution.Visible = False
    End Sub

    Private Sub InitGroupchiffre()
        Dim width As Integer = 0
        For Each ctrl As Control In Groupchiffres.Controls
            If TypeOf ctrl Is Button Then
                DirectCast(ctrl, Button).BackColor = Color.Ivory
                DirectCast(ctrl, Button).TextAlign = ContentAlignment.MiddleCenter
                DirectCast(ctrl, Button).Text = String.Empty
                DirectCast(ctrl, Button).Tag = "unused"
                width += DirectCast(ctrl, Button).Width
            End If
        Next
        Width += 7 * 4
        Groupchiffres.Width = Width
    End Sub
    Private Sub InitControlsGroupequation()
        Dim iter As Integer
        Dim xp, yp, spaceline As Integer
        xp = 6
        yp = 10
        spaceline = 10
        For iter = 0 To arraylabelnumber.Length - 1
            arraylabelnumber(iter) = New Label
            With arraylabelnumber(iter)
                .Text = String.Empty
                .AutoSize = False
                .Size = New Size(76, 36)
                .Font = New Font("arial", 14, FontStyle.Bold)
                .BackColor = Color.Ivory
                .ForeColor = Color.Black
                .TextAlign = ContentAlignment.MiddleLeft
                .Tag = iter
                .Enabled = False
                If (iter Mod 4 = 0) And (iter > 0) Then
                    yp += arraylabelnumber(iter - 4).Height + spaceline
                    xp = 6
                End If
                .Location = New Point(xp, yp)
                xp += arraylabelnumber(iter).Width + spaceline
                AddHandler .MouseClick, AddressOf mouselabelclick
            End With
            GroupBoxequation.Controls.Add(arraylabelnumber(iter))
        Next
        xp = arraylabelnumber(3).Right + spaceline


        For iter = 0 To arrayresult.Length - 1
            arrayresult(iter) = New Button
            With arrayresult(iter)
                .BackColor = Color.Ivory
                .AutoSize = False
                .Size = New Size(96, 36)
                .Enabled = False
                .Font = New Font("arial", 14, FontStyle.Bold)
                .TextAlign = ContentAlignment.MiddleLeft
                .Text = String.Empty
                .Tag = "unused" & iter.ToString
                yp = arraylabelnumber(iter * 4).Top
                .Location = New Point(xp, yp)
                AddHandler .MouseClick, AddressOf mousebuttonresultclick
            End With
            GroupBoxequation.Controls.Add(arrayresult(iter))
        Next

        GroupBoxequation.Width = arraylabelnumber(0).Width * 4 + spaceline * 6 + arrayresult(0).Width
        GroupBoxequation.Height = arraylabelnumber(0).Height * 5 + spaceline * 6
        GroupBoxequation.Location = New Point(Groupoperators.Left, Groupoperators.Bottom + 6)
        PanelMath.Height = Groupoperators.Height + Groupchiffres.Height + 5 * spaceline + GroupBoxequation.Height
        PanelSevenseg.Location = New Point(PanelMath.Right + 6, PanelMath.Top)
        PanelSevenseg.BringToFront()
        Paneltimer.Location = New Point(Me.Width \ 2 - Paneltimer.Width \ 2, PanelMath.Bottom + 2)
        Buttonerase.Enabled = False
        ToolStripButtonSolution.Enabled = False
        ToolStripButtonOral.Enabled = False
        flagchrono = True
        flagdelete = False
    End Sub
    
#End Region
#Region "graphics"



#End Region

#Region "processing"
    Private Function isflagchrono() As Boolean
        Return flagchrono
    End Function
    Private Function gettime() As Integer
        Return t
    End Function
    Private Function getlimittime() As Integer
        Return limittime
    End Function
    Private Sub Reset()
        For Each ctrl As Control In GroupBoxequation.Controls
            If TypeOf ctrl Is Label Then
                DirectCast(ctrl, Label).Text = String.Empty
            End If
            If TypeOf ctrl Is Button Then
                DirectCast(ctrl, Button).Text = String.Empty
                If DirectCast(ctrl, Button).Tag.ToString.Substring(0, 2) = "us" Then
                    DirectCast(ctrl, Button).Tag = DirectCast(ctrl, Button).Tag.ToString.Replace("used", "unused")
                End If
                DirectCast(ctrl, Button).BackColor = Color.Ivory
                DirectCast(ctrl, Button).Enabled = False
            End If
        Next
        For Each ctrl As Control In Groupchiffres.Controls
            If TypeOf ctrl Is Button Then
                DirectCast(ctrl, Button).Tag = "unused"
                DirectCast(ctrl, Button).BackColor = Color.Ivory
                DirectCast(ctrl, Button).Enabled = True
            End If
        Next
        indexlabel = 0
        Buttonerase.Image = imageeraser
        GroupBoxequation.Cursor = Cursors.Default
        flagdelete = False
        Buttonerase.Enabled = False
        Buttonreset.Enabled = False
        listequations.Clear()
        listresultlabel.Clear()
        listsource.Clear()
        ToolStripButtonSolution.Enabled = False
        ToolStripButtonOral.Enabled = False
        Panelsolution.Visible = False
        ButtonTirage.Enabled = True
        Combosec.Enabled = True



    End Sub

    Private Sub FreezeOperator(ByVal flag As Boolean)
        For Each ctrl As Control In Groupoperators.Controls
            If TypeOf ctrl Is Button Then
                DirectCast(ctrl, Button).Enabled = Not flag
            End If
        Next

    End Sub
    Private Sub ReleaseLabel()
        For iter = 0 To arraylabelnumber.Length - 1
            arraylabelnumber(iter).Enabled = True
        Next
    End Sub
    Private Sub FreezeAll()
        FreezeOperator(True)
        For Each ctrl As Control In Groupchiffres.Controls
            If TypeOf ctrl Is Button Then
                DirectCast(ctrl, Button).Enabled = False
            End If
        Next
        For Each ctrl As Control In GroupBoxequation.Controls
            If TypeOf ctrl Is Button Then
                DirectCast(ctrl, Button).Enabled = False
            End If
        Next
        For Each ctrl As Control In GroupBoxequation.Controls
            If TypeOf ctrl Is Label Then
                DirectCast(ctrl, Label).Enabled = False
            End If
        Next
    End Sub
    Private Sub FreezeOperand(ByVal flag As Boolean)
        For Each ctrl As Control In Groupchiffres.Controls
            If TypeOf ctrl Is Button Then
                If DirectCast(ctrl, Button).Tag.ToString = "unused" Then
                    DirectCast(ctrl, Button).Enabled = Not flag
                End If
            End If
        Next
        For Each ctrl As Control In GroupBoxequation.Controls
            If TypeOf ctrl Is Button Then
                If DirectCast(ctrl, Button).Tag.ToString.Substring(0, 2) = "un" Then
                    DirectCast(ctrl, Button).Enabled = Not flag
                End If
                If DirectCast(ctrl, Button).Text = String.Empty Then
                    DirectCast(ctrl, Button).Enabled = False
                End If
            End If
        Next
    End Sub

    Private Sub EraseFromLabel(ByVal labelindex As Integer)
        'efface tous labels chiffres à partir du label "cliqué"
        ' libère les chiffres et annule les résultats intermédiaires 
        Dim index As Integer
        Dim iter As Integer

        'efface les labels à partir du label cliqué jusqu'au dernier
        For iter = labelindex To arraylabelnumber.Length - 1
            If arraylabelnumber(iter).Text <> String.Empty Then
                arraylabelnumber(iter).Text = String.Empty
            End If
            For Each item In listresultlabel
                If item.indexlabel = iter Then
                    arrayresult(item.indexresult).BackColor = Color.Ivory
                    arrayresult(item.indexresult).Enabled = True
                End If
            Next
        Next
        If labelindex Mod 4 = 0 Then
            index = labelindex \ 4
        ElseIf labelindex Mod 4 = 1 Then
            index = (labelindex - 1) \ 4
        Else
            index = (labelindex - 2) \ 4
        End If


        'efface les résultats 
        For iter = index To arrayresult.Length - 1
            arrayresult(iter).Text = String.Empty
            arrayresult(iter).BackColor = Color.Ivory
            arrayresult(iter).Enabled = True
        Next

        index = (labelindex \ 4) * 3 + labelindex Mod 4
        iter = index
        Dim list1 As New List(Of String)
        Dim listr As New List(Of resultlabel)
        For iter = 0 To index - 1
            list1.Add(listsource(iter))
            If listsource(iter) = "res" Then
                For Each item In listresultlabel
                    If item.indexlabel = (iter \ 3) * 4 + iter Mod 3 Then
                        arrayresult(item.indexresult).Enabled = False
                        listr.Add(item)
                        Exit For
                    End If
                Next
            End If
        Next
        'update listresult
        listresultlabel.Clear()
        listresultlabel = listr


        For iter = index To listsource.Count - 1
            'libere les chiffres
            If listsource(iter) <> "res" And listsource(iter) <> "op" Then
                For Each ctrl As Control In Groupchiffres.Controls
                    If TypeOf ctrl Is Button Then
                        If DirectCast(ctrl, Button).Name = listsource(iter) Then
                            DirectCast(ctrl, Button).BackColor = Color.Ivory
                            DirectCast(ctrl, Button).Enabled = True
                            DirectCast(ctrl, Button).Tag = "unused"
                            Exit For
                        End If
                    End If
                Next
            End If
        Next
        listsource.Clear()
        listsource = list1
        If labelindex Mod 4 = 0 Then
            index = labelindex
        ElseIf labelindex Mod 4 = 1 Then
            index = labelindex - 1
        Else
            index = labelindex - 2
        End If

        If labelindex Mod 4 = 0 Then
            index = labelindex
            actualtermsequation.startindex = index
            actualtermsequation.leftoperand = String.Empty
            actualtermsequation.theoperator = String.Empty
            actualtermsequation.rightoperand = String.Empty
            actualtermsequation.result = String.Empty
        ElseIf labelindex Mod 4 = 1 Then
            index = labelindex - 1
            actualtermsequation.startindex = index
            actualtermsequation.leftoperand = arraylabelnumber(index).Text
            actualtermsequation.theoperator = String.Empty
            actualtermsequation.rightoperand = String.Empty
            actualtermsequation.result = String.Empty
        Else
            index = labelindex - 2
            actualtermsequation.startindex = index
            actualtermsequation.leftoperand = arraylabelnumber(index).Text
            actualtermsequation.theoperator = arraylabelnumber(index + 1).Text
            actualtermsequation.rightoperand = String.Empty
            actualtermsequation.result = String.Empty
        End If
        actualoperator = actualtermsequation.theoperator
        Dim liste As New List(Of termsequation)
        Dim terms As New termsequation
        For iter = 0 To (index - 4) \ 4
            terms = listequations(iter)
            liste.Add(terms)
        Next

        listequations.Clear()
        listequations = liste
        indexlabel = labelindex
        If labelindex Mod 4 = 1 Then
            FreezeOperand(True)
            FreezeOperator(False)
        Else
            FreezeOperand(False)
            FreezeOperator(True)
        End If
    End Sub
    Private Sub ReleaseNumberButton(ByVal namebutton As String)
        ' débloque le chiffre choisi auparavant
        For Each ctrl As Control In Groupchiffres.Controls
            If TypeOf ctrl Is Button Then
                If DirectCast(ctrl, Button).Name = namebutton Then
                    DirectCast(ctrl, Button).BackColor = Color.Ivory
                    DirectCast(ctrl, Button).Enabled = True
                    Exit For
                End If
            End If
        Next
    End Sub
    Private Sub AddToListEquation(ByVal thetermsequation As termsequation)
        'ajoute les equations à la liste des équations
        Select Case thetermsequation.theoperator
            Case "x"
                thetermsequation.result = (System.Convert.ToInt32(thetermsequation.leftoperand) * System.Convert.ToInt32(thetermsequation.rightoperand)).ToString
            Case "/"
                thetermsequation.result = (System.Convert.ToInt32(thetermsequation.leftoperand) \ System.Convert.ToInt32(thetermsequation.rightoperand)).ToString
            Case "+"
                thetermsequation.result = (System.Convert.ToInt32(thetermsequation.leftoperand) + System.Convert.ToInt32(thetermsequation.rightoperand)).ToString
            Case "-"
                thetermsequation.result = (System.Convert.ToInt32(thetermsequation.leftoperand) - System.Convert.ToInt32(thetermsequation.rightoperand)).ToString
        End Select
        listequations.Add(thetermsequation)


    End Sub


    Private Sub DisplayResult()
        For Each item As termsequation In listequations
            If item.result <> String.Empty Then
                arrayresult(item.startindex \ 4).TextAlign = ContentAlignment.TopCenter
                arrayresult(item.startindex \ 4).Text = item.result
                '  arrayresult(item.startindex \ 4).Enabled = True
                resultplayer = System.Convert.ToInt32(item.result)

            End If
        Next

    End Sub

    Private Function GetListNumber() As List(Of Int64)
        Dim listnumbers As New List(Of Int64)
        For Each ctrl As Control In Groupchiffres.Controls
            If TypeOf ctrl Is Button Then
                listnumbers.Add(System.Convert.ToInt64(DirectCast(ctrl, Button).Text))
            End If
        Next

        Return listnumbers
    End Function
    Private Sub ShowChiffresResult()
        Dim iter As Integer

        iter = 1
        ListBoxresult.Items.Clear()

        ListBoxresult.Items.Add("nombre à trouver : " & numbertofind.ToString)
        For Each item In listsolution
            ListBoxresult.Items.Add("solution" & " " & iter)
            ListBoxresult.Items.AddRange(item.ToArray)
            ListBoxresult.Items.Add(Environment.NewLine)
            iter += 1
        Next
        ptspc.Text = pcpoints.ToString
        Panelsolution.Visible = True
    End Sub
#End Region

#Region "events"

    Private Sub Formchiffre_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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


    Private Sub Formchiffre_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
      
        Me.Location = New Point(0, 0)
        backgroundWorker1.WorkerSupportsCancellation = True
        If flagame Then
            Labelstatus.Image = gamegimage
            Labelstatus.Size = gamegimage.Size
            nochrono.Enabled = False
            ToolStripButtonNew.Enabled = False
            If flagstartchiffre Then
                Combosec.Enabled = False
            End If
        Else
            Labelstatus.Image = trainingimage
            Labelstatus.Size = trainingimage.Size
            nochrono.Enabled = True
            ToolStripButtonNew.Enabled = True
        End If

        InitComboSec()
        InitPanelRandomNumber()
        InitPanelTimer()
        InitPanelScore()
        InitGroupoperators()

        InitGroupchiffre()
        InitControlsGroupequation()
        Timerprogressbar.Stop()
        indexlabel = 0
        t = 0
        InitPanelSevenseg()
        InitChronoOption()
        Me.Controls.Add(oralsolution)
        FreezeAll()
    End Sub
    Private Sub Formchiffre_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Try
            e.Graphics.DrawImage(imageleschiffres, ClientSize.Width \ 2 - Convert.ToInt32(imageleschiffres.Width * 100 / imageleschiffres.HorizontalResolution) \ 2, ToolStripchiffres.Bottom + 6)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Formchiffre_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseEnter
        If insidegroupchrono Then
            Groupchrono.Visible = False
            insidegroupchrono = False
        End If

    End Sub

    Private Sub hundredpic_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles hundredpic.Paint

        digithundredobj.DrawDigit(e.Graphics, hundred)
    End Sub

    Private Sub tenpic_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles tenpic.Paint

        digittenobj.DrawDigit(e.Graphics, ten)

    End Sub

    Private Sub unitpic_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles unitpic.Paint

        digitunitobj.DrawDigit(e.Graphics, unit)

    End Sub

    Private Sub Timerhundred_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timerhundred.Tick
        hundred += 1
        If hundred = 9 Then
            hundred = 1
        End If
        hundredpic.Invalidate()
    End Sub

    Private Sub Timerten_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timerten.Tick
        ten += 1
        If ten = 9 Then
            ten = 0
        End If

        tenpic.Invalidate()
    End Sub

    Private Sub Timerunit_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timerunit.Tick
        If unit = 0 And ten = 0 And hundred = 1 Then
            unit = 1
        Else
            If unit = 9 Then
                unit = 0
            Else
                unit += 1
            End If
        End If


        unitpic.Invalidate()
    End Sub

    Private Sub ButtonTirage_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ButtonTirage.MouseClick
        distribute = New ClassDistribution

        listnum = distribute.RandomChooseNumber
        If flagame Then
            ToolStripButtonNew.Enabled = False
        Else
            ToolStripButtonNew.Enabled = True
        End If

        numero = 1

        DirectCast(sender, Button).Enabled = False
        Timertirage.Interval = 1
        Timertirage.Start()
    End Sub

    Private Sub Timertirage_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timertirage.Tick
        synth = New SpeechSynthesizer
        synth.SelectVoice("ScanSoft Virginie_Dri40_16kHz")
        synth.Rate = 0
        For Each ctrl As Control In Groupchiffres.Controls
            If TypeOf (ctrl) Is Button Then
                If DirectCast(ctrl, Button).Name = "nombre" & numero.ToString Then
                    DirectCast(ctrl, Button).Text = listnum(numero - 1).ToString

                End If
            End If
        Next
        synth.SpeakAsync(listnum(numero - 1).ToString)
        Timertirage.Interval = 1500
        numero += 1
        If numero = 7 Then
            ButtonTirage.Enabled = False
            Timertirage.Stop()
            Timerfree.Interval = 1
            starttime = DateTime.Now
            Timerfree.Start()

        End If
    End Sub

    Private Sub Timerfree_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timerfree.Tick

        Timerhundred.Start()
        Timerten.Start()
        Timerunit.Start()

        Dim now As DateTime
        now = DateTime.Now
        If Math.Abs(now.Second - starttime.Second) > 1 Then
            Timerfree.Stop()
            Timerhundred.Stop()
            Timerten.Stop()
            Timerunit.Stop()
            numbertofind = hundred * 100 + ten * 10 + unit
            synth = New SpeechSynthesizer
            synth.SelectVoice("ScanSoft Virginie_Dri40_16kHz")
            synth.Rate = 0
            synth.SpeakAsync(numbertofind.ToString)
            Thread.Sleep(1000)
            FreezeOperator(True)
            FreezeOperand(False)
            ReleaseLabel()
            If flagchrono Then
                Combosec.Enabled = False
                Timerprogressbar.Interval = 1000
                Timerprogressbar.Start()
                now = DateTime.Now
                starttime = now
            Else
                Combosec.Enabled = True
                Timerprogressbar.Stop()
            End If
            thelistnumber = GetListNumber()

            If Not backgroundWorker1.IsBusy Then
                backgroundWorker1.RunWorkerAsync()
            End If
        End If

    End Sub
    Private Sub mouselabelclick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If Not flagdelete Then
            Exit Sub
        End If
        If TypeOf sender Is Label Then
            If DirectCast(sender, Label).Text <> String.Empty Then
                EraseFromLabel(System.Convert.ToInt32(DirectCast(sender, Label).Tag))
                indexlabel = System.Convert.ToInt32(DirectCast(sender, Label).Tag)
                flagdelete = False
                GroupBoxequation.Cursor = Cursors.Default
            End If

        End If

    End Sub
    Private Sub mousebuttonresultclick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Dim index As Integer
        Dim theresultlabel As New resultlabel

        If TypeOf sender Is Button Then

            DirectCast(sender, Button).Enabled = False
            DirectCast(sender, Button).Tag = DirectCast(sender, Button).Tag.ToString.Replace("unused", "used")
            flagresult = True
            If indexlabel Mod 4 = 0 Then
                flagsecondoperand = False
                flagoperand = True
                DirectCast(sender, Button).BackColor = Color.Coral
                arraylabelnumber(indexlabel).Text = DirectCast(sender, Button).Text
                leftoperand = System.Convert.ToInt32(DirectCast(sender, Button).Text)
                listsource.Add("res")
                index = System.Convert.ToInt32(DirectCast(sender, Button).Tag.ToString.Substring("used".Length))

                theresultlabel.indexlabel = indexlabel
                theresultlabel.indexresult = index
                listresultlabel.Add(theresultlabel)
                actualtermsequation.startindex = indexlabel
                actualtermsequation.leftoperand = DirectCast(sender, Button).Text
                indexlabel += 1
                FreezeOperand(True)
                FreezeOperator(False)
            End If
            If indexlabel Mod 4 = 2 Then
                rightoperand = System.Convert.ToInt32(DirectCast(sender, Button).Text)
                If actualoperator = "/"c Then
                    If rightoperand = 0 Then
                        DirectCast(sender, Button).Enabled = True
                        FreezeOperand(False)
                        Exit Sub
                    End If
                    If leftoperand Mod rightoperand <> 0 Then
                        DirectCast(sender, Button).Enabled = True
                        FreezeOperand(False)
                        Exit Sub
                    End If
                End If
                actualtermsequation.theoperator = actualoperator

                DirectCast(sender, Button).BackColor = Color.Coral
                arraylabelnumber(indexlabel).Text = DirectCast(sender, Button).Text
                index = System.Convert.ToInt32(DirectCast(sender, Button).Tag.ToString.Substring("used".Length))
                listsource.Add("res")
                actualtermsequation.rightoperand = DirectCast(sender, Button).Text
                theresultlabel.indexlabel = indexlabel
                theresultlabel.indexresult = index
                listresultlabel.Add(theresultlabel)
                indexlabel += 1
            End If
            If indexlabel Mod 4 = 3 Then
                arraylabelnumber(indexlabel).TextAlign = ContentAlignment.MiddleCenter
                arraylabelnumber(indexlabel).Text = "="
                arraylabelnumber(indexlabel).Enabled = False
                AddToListEquation(actualtermsequation)
                DisplayResult()
                arrayresult((indexlabel - 3) \ 4).Enabled = True
                indexlabel += 1
                flagsecondoperand = True
                flagoperand = False
            End If

        End If
    End Sub



    Private Sub nombre1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles nombre1.MouseClick, nombre2.MouseClick, nombre3.MouseClick, nombre4.MouseClick, nombre5.MouseClick, nombre6.MouseClick

        If TypeOf sender Is Button Then
            flagresult = False
            DirectCast(sender, Button).Enabled = False
            DirectCast(sender, Button).Tag = "used"
            'selon le indexlabel on sait quel label il faut utiliser 
            ' indexlabel 0 4 8 12 16 correspond au nombre à gauche de l'opérateur
            ' indexlabel 1 5 9 13 17 correspond à l'opérateur
            ' indexlabel 2 6 10 14 18 correspond au nombre à droite de l'opérateur
            'indexlabel  3 7 11 15 19 correspond  à l'opérateur =
            Buttonerase.Enabled = True
            If indexlabel Mod 4 = 0 Then
                flagsecondoperand = False
                flagoperand = True
                DirectCast(sender, Button).BackColor = Color.Coral
                arraylabelnumber(indexlabel).Text = DirectCast(sender, Button).Text
                leftoperand = System.Convert.ToInt32(DirectCast(sender, Button).Text)
                actualtermsequation.startindex = indexlabel
                actualtermsequation.leftoperand = DirectCast(sender, Button).Text
                listsource.Add(DirectCast(sender, Button).Name)
                indexlabel += 1
                FreezeOperand(True)
                FreezeOperator(False)

            End If

            If indexlabel Mod 4 = 2 Then
                If actualoperator = "/"c Then
                    rightoperand = System.Convert.ToInt32(DirectCast(sender, Button).Text)
                    If rightoperand = 0 Then
                        DirectCast(sender, Button).Enabled = True
                        DirectCast(sender, Button).Tag = "unused"
                        FreezeOperand(False)
                        Exit Sub
                    End If
                    If (leftoperand Mod rightoperand <> 0) Then
                        DirectCast(sender, Button).Enabled = True
                        DirectCast(sender, Button).Tag = "unused"
                        FreezeOperand(False)
                        Exit Sub
                    End If
                End If
                actualtermsequation.theoperator = actualoperator
                flagoperand = True
                DirectCast(sender, Button).BackColor = Color.Coral
                arraylabelnumber(indexlabel).Text = DirectCast(sender, Button).Text
                actualtermsequation.rightoperand = DirectCast(sender, Button).Text
                listsource.Add(DirectCast(sender, Button).Name)
                indexlabel += 1
            End If
            If indexlabel Mod 4 = 3 Then
                arraylabelnumber(indexlabel).TextAlign = ContentAlignment.MiddleCenter
                arraylabelnumber(indexlabel).Text = "="

                arraylabelnumber(indexlabel).Enabled = False

                AddToListEquation(actualtermsequation)
                DisplayResult()
                arrayresult((indexlabel - 3) \ 4).Enabled = True
                indexlabel += 1
                flagsecondoperand = True
                flagoperand = False
            End If
            Buttonreset.Enabled = True


        End If
    End Sub
    Private Sub Buttonoperatoradd_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Buttonoperatoradd.MouseClick, Buttonoperatordiv.MouseClick, Buttonoperatorsub.MouseClick, Buttonoperatormult.MouseClick
        If TypeOf sender Is Button Then
            arraylabelnumber(indexlabel).TextAlign = ContentAlignment.MiddleCenter
            arraylabelnumber(indexlabel).Text = DirectCast(sender, Button).Tag.ToString
            actualoperator = System.Convert.ToChar(DirectCast(sender, Button).Tag)
            DirectCast(sender, Button).Enabled = False
            listsource.Add("op")
            indexlabel += 1
            FreezeOperator(True)
            FreezeOperand(False)
            flagsecondoperand = False
            flagoperand = False
            Buttonerase.Enabled = True
        End If
    End Sub

    Private Sub Buttonreset_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Buttonreset.MouseClick
        Reset()
        ButtonTirage.Enabled = False
        DirectCast(sender, Button).Enabled = False
    End Sub

    Private Sub Buttoneerase_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Buttonerase.MouseClick
        GroupBoxequation.Cursor = Cursors.Hand
        flagdelete = True
       
    End Sub
    Private Sub UpdateScore()

        If (mathresult = 0) And resultplayer = 0 Then
            Exit Sub
        End If
        If mathresult = numbertofind Then
            pcpoints += 9
            ptspc.Text = pcpoints.ToString
        End If
        If resultplayer = numbertofind Then
            playerpoints += 9
            ptsplayer.Text = playerpoints.ToString
        End If
        If (mathresult <> numbertofind) And (resultplayer <> numbertofind) Then
            If (Math.Abs(numbertofind - resultplayer) < Math.Abs(numbertofind - mathresult)) Then
                playerpoints += 6
                ptsplayer.Text = playerpoints.ToString
            End If
            If (Math.Abs(numbertofind - resultplayer) > Math.Abs(numbertofind - mathresult)) Then
                pcpoints += 6
                ptspc.Text = pcpoints.ToString
            End If
            If (Math.Abs(numbertofind - resultplayer) = Math.Abs(numbertofind - mathresult)) AndAlso listsolution.Count > 0 Then
                pcpoints += 6
                ptspc.Text = pcpoints.ToString
                playerpoints += 6
                ptsplayer.Text = playerpoints.ToString
            End If

        End If
    End Sub
    Private Sub Timerprogressbar_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timerprogressbar.Tick

        thetimespan = DateTime.Now - starttime
        countertime -= 1
        unitsec = (countertime Mod 60) Mod 10
        tensec = (countertime Mod 60) \ 10
        unitmin = (countertime \ 60)
        unitsecpic.Invalidate()
        tensecpic.Invalidate()
        unitminpic.Invalidate()
        t = System.Convert.ToInt32(thetimespan.TotalSeconds)
        If countertime = 0 Then
            Timerprogressbar.Stop()
            Combosec.Enabled = True

            ToolStripButtonSolution.Enabled = True
            ToolStripButtonOral.Enabled = True
            If flagame Then
                ToolStripButtonNew.Enabled = False
                flagstartchiffre = True
                Combosec.Enabled = False
                Buttonnextgame.Enabled = True
            Else
                ToolStripButtonNew.Enabled = True
            End If
            MessageBox.Show("Le temps s'est écoulé", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            FreezeAll()
            Buttonreset.Enabled = False
            Buttonerase.Enabled = False
            flagresult = True
            UpdateScore()
            Exit Sub
        End If

    End Sub
    Private Sub ToolStripButtonNew_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripButtonNew.MouseEnter
        Groupchrono.Visible = False
    End Sub
    Private Sub ToolStripButtonNew_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ToolStripButtonNew.MouseDown

        If backgroundWorker1.IsBusy Then
            backgroundWorker1.CancelAsync()
        End If
        If flagame Then
            Dirigepartie.Rungame()
            InitPanelScore()
        End If
        Timerprogressbar.Stop()

        indexlabel = 0
        t = 0
        countertime = limittime
        unitmin = limittime \ 60
        tensec = (limittime Mod 60) \ 10
        unitsec = (limittime Mod 60) Mod 10
        unitsecpic.Invalidate()
        tensecpic.Invalidate()
        unitminpic.Invalidate()
        InitPanelSevenseg()
        InitGroupchiffre()
        Panelsolution.Visible = False
        Reset()
        FreezeAll()
        If backgroundWorker1.IsBusy Then
            backgroundWorker1.CancelAsync()
        End If
        If Not oralsolution.IsDisposed Then
            oralsolution.Dispose()
        End If

    End Sub
    Private Sub Groupchrono_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Groupchrono.MouseEnter
        insidegroupchrono = True
    End Sub
    Private Sub ToolStripButtonChrono_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripButtonChrono.MouseEnter
        Groupchrono.Visible = True

    End Sub
    Private Sub ToolStripButtonHelp_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ToolStripButtonHelp.MouseDown
        If helpmenu.IsDisposed Then
            helpmenu = New Classhelp("HelpChiffre.txt")
        End If
        Me.Controls.Add(helpmenu)
        helpmenu.Location = New Point(6, ToolStripchiffres.Height * 2)
        helpmenu.BringToFront()
        helpmenu.showhelp()
    End Sub

   

    Private Sub backgroundWorker1_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles backgroundWorker1.DoWork
        Dim number As Int64
        number = numbertofind
        If backgroundWorker1.CancellationPending Then
            e.Cancel = True
        End If
        
        thesolution = New MathSolution(thelistnumber, number)
        listsolution.Clear()
        listsolution = thesolution.FindSolution(Function() backgroundWorker1.CancellationPending, number, Function() isflagchrono(), Function() gettime(), Function() getlimittime())
        mathresult = number

        If Not flagchrono Then
            Try
                Invoke(ModifyButton)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If

    End Sub
    Private Sub backgroundWorker1_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles backgroundWorker1.RunWorkerCompleted
        Dim x As Integer = 4
    End Sub
    Private Function ChangeTrueButton() As Boolean
        ToolStripButtonSolution.Enabled = True
        ToolStripButtonOral.Enabled = True
        Return True
    End Function
    Private Sub Buttonnextgame_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Buttonnextgame.MouseClick
        totalcoup += 1
        Combosec.Enabled = False

        Formlettres.Show()
        flagckickX = False
        flagquit = False
        Me.Close()
    End Sub

    Private Sub chrono_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chrono.CheckedChanged
        flagchrono = True
        Paneltimer.Visible = True
    End Sub

    Private Sub nochrono_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles nochrono.CheckedChanged
        flagchrono = False
        Paneltimer.Visible = False
    End Sub

    Private Sub Combosec_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Combosec.SelectedValueChanged
        limittime = Convert.ToInt32(DirectCast(sender, ComboBox).SelectedItem)
        countertime = limittime
        limittimechiffre = limittime
        My.Settings.numbertime = limittime
        unitmin = limittime \ 60
        tensec = (limittime Mod 60) \ 10
        unitsec = (limittime Mod 60) Mod 10
        unitsecpic.Invalidate()
        tensecpic.Invalidate()
        unitminpic.Invalidate()


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

    Private Sub colonpic_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles colonpic.Paint
        colonminuteobj.DrawDrawColon(e.Graphics)
    End Sub

    Private Sub ToolStripButtonSolution_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ToolStripButtonSolution.MouseDown
        ShowChiffresResult()
        If Not flagame Then
            ToolStripButtonNew.Enabled = True
        End If
        DirectCast(sender, ToolStripButton).Enabled = False
    End Sub



    Private Sub ToolStripButtonMainMenu_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ToolStripButtonMainMenu.MouseDown
        flagreturn = False
        If backgroundWorker1.IsBusy Then
            backgroundWorker1.CancelAsync()
        End If
        flagame = False
        Formpreface.Show()
        flagckickX = False
        flagquit = False
        Me.Close()
    End Sub


    
    Private Sub ToolStripButtonOral_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ToolStripButtonOral.MouseDown
        If oralsolution.IsDisposed Then
            oralsolution = New ClassVoice
            Me.Controls.Add(oralsolution)
        End If

        oralsolution.Location = New Point(ListBoxresult.Right + 10, PanelMath.Top)
        oralsolution.BringToFront()
        oralsolution.thelistnumber = listnum
        oralsolution.TexttoSpeech = listsolution
        oralsolution.Visible = True
        DirectCast(sender, ToolStripButton).Enabled = False
    End Sub
    Private Sub ToolStripButtonQuit_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ToolStripButtonQuit.MouseDown
        Dim result As DialogResult
        If backgroundWorker1.IsBusy Then
            backgroundWorker1.CancelAsync()
        End If
        result = MessageBox.Show("Voulez vous quitter ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        If result = Windows.Forms.DialogResult.Yes Then
            flagckickX = False
            Me.Close()
        End If

    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Try
            imageleschiffres = CType(My.Resources.ResourceManager.GetObject("leschiffres"), Bitmap)
            imageeraser = CType(My.Resources.ResourceManager.GetObject("eraser"), Bitmap)
            imagecanceleraser = CType(My.Resources.ResourceManager.GetObject("canceleraser"), Bitmap)
            trainingimage = CType(My.Resources.ResourceManager.GetObject("training_fw"), Bitmap)
            gamegimage = CType(My.Resources.ResourceManager.GetObject("game_fw"), Bitmap)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Buttonclose_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Buttonclose.MouseClick
        Panelsolution.Visible = False
        ToolStripButtonSolution.Enabled = True
    End Sub

#End Region

   
End Class