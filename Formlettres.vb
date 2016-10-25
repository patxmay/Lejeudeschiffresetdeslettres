'Imports Microsoft.Speech.Synthesis
Imports System.Speech
Imports System.Speech.Synthesis
Imports System.Drawing.Drawing2D

Public Class Formlettres
#Region "declaration"
    Private flagckickX As Boolean = True
    Private Class letterposition
        Public original As Integer
        Public target As Integer
    End Class
    Private Class classletterdata
        Public used As Boolean
        Public value As String
        Public pic As PictureBox
    End Class
    Private Class caasedata
        Public tag As String
        Public location As Point
    End Class
    Private listcaseorigine As New List(Of caasedata)
    Private flagquit As Boolean = True
    Private listcasetarget As New List(Of caasedata)
    Private imagesupport As Image
    Private imagepanelletters As Image
    Private listletterposition(NUMBERLETTERS - 1) As letterposition
    Private listsolution As New List(Of String)
    Private Const NUMBERLETTERS As Integer = 10
    Private Const WIDTHCARD As Integer = 86
    Private Const HEIGHTCARD As Integer = 86
    Private flagchrono As Boolean
    Private solutionlettre As LettreSolution
    Private lettre As String
    Private t As Integer
    Private limittime As Integer
    Private insidegroupchrono As Boolean
    Private counter As Integer
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
    Private imageleslettres As Image
    Private trainingimage As Image
    Private gamegimage As Image
    Private stringofletters As String
    Private listlettre As New List(Of classletterdata)
    '  Private listlettre As New List(Of PictureBox)
    Private WithEvents backgroundWorker1 As New System.ComponentModel.BackgroundWorker
    Delegate Function ButtonSolutionToTrue() As Boolean
    Private ModifyButton As ButtonSolutionToTrue = New ButtonSolutionToTrue(AddressOf ChangeTrueButton)
    Private helpmenu As New Classhelp("HelpLettre.txt")
    Private distribute As ClassDistribution
    Private synth As SpeechSynthesizer
#End Region
#Region "initialize"

    Private Sub InitListCaseOrigine()
        Dim origine As caasedata
        Dim top, left As Integer



        Buttonnextgame.Location = New Point(CheckInsert.Right + 3, CheckInsert.Top)
        top = 10 + support.Top
        left = 20 + support.Left
        listcaseorigine.Clear()
        For iter = 0 To 9
            origine = New caasedata
            origine.tag = String.Empty
            origine.location = New Point(left, top)
            listcaseorigine.Add(origine)
            left += WIDTHCARD
        Next
    End Sub
    Private Function isflagchrono() As Boolean
        Return flagchrono
    End Function
    Private Function gettime() As Integer
        Return t
    End Function
    Private Function getlimittime() As Integer
        Return limittime
    End Function
    Private Sub InitListCaseTarget()
        Dim origine As caasedata
        Dim top, left As Integer
        top = 10
        left = 20
        listcasetarget.Clear()
        For iter = 0 To 9
            origine = New caasedata
            origine.tag = iter & "E"
            origine.location = New Point(left, top)
            listcasetarget.Add(origine)
            left += WIDTHCARD
        Next
    End Sub
    Private Sub InitPanelJeu()
        Dim left, top As Integer
        Dim lettrepos As letterposition
        left = 20
        top = 20
        Timerdelay.Stop()
        Buttonerase.Enabled = False
        InitListCaseOrigine()
        InitListCaseTarget()
        listlettre.Clear()
        For iter = 0 To NUMBERLETTERS - 1
            lettrepos = New letterposition
            Dim dataletter As New classletterdata
            lettrepos.original = iter
            lettrepos.target = -1
            listletterposition(iter) = lettrepos
            With dataletter
                '  .value = stringofletters(iter)
                .used = False
                .pic = New PictureBox
                With .pic
                    .Tag = iter
                    .BackColor = Color.LightGoldenrodYellow
                    .Width = WIDTHCARD
                    .Height = HEIGHTCARD
                    .Name = "lettres" & iter.ToString
                    .Enabled = False
                    .BorderStyle = BorderStyle.Fixed3D
                    '  .Location = New Point(listcaseorigine(iter).location.X, listcaseorigine(iter).location.Y)
                    .Location = New Point(Me.Width \ 2 - WIDTHCARD \ 2, 0)
                    listlettre.Add(dataletter)
                    Me.Controls.Add(dataletter.pic)
                    .Visible = False
                    .BringToFront()
                End With

            End With
            AddHandler listlettre(iter).pic.MouseDoubleClick, AddressOf thepicMousedoubleclick
            AddHandler listlettre(iter).pic.MouseDown, AddressOf thepicMouseDown
            AddHandler listlettre(iter).pic.MouseMove, AddressOf thepicMouseMove
            AddHandler listlettre(iter).pic.MouseUp, AddressOf thepicMouseUp
            AddHandler listlettre(iter).pic.Paint, AddressOf thepicPaint
            left += dataletter.pic.Width
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

        Paneltimer.Location = New Point(Me.Width \ 2 - Paneltimer.Width \ 2, PanelLettres.Bottom + 2)
        CheckInsert.Focus()


    End Sub
    Private Sub InitChronoOption()
        chrono.Checked = True
        insidegroupchrono = False
        flagchrono = True
        Groupchrono.Location = New Point(ToolStriplettres.Left + 12, ToolStriplettres.Bottom + 8)
        Groupchrono.Visible = False
    End Sub
    Private Sub InitComboSec()
        Dim iter As Integer
        For iter = 1 To 180
            Combosec.Items.Add(iter.ToString)
        Next
        Combosec.Text = My.Settings.lettertime.ToString
        limittime = My.Settings.lettertime
        countertime = limittime

    End Sub
    Private Sub InitTimer()
        Timerprogressbar.Interval = 1000
        Timerprogressbar.Stop()
        Timeranimation.Stop()
        Timeranimation.Interval = 1
    End Sub
    Private Sub InitPanelScore()
        Labelplayer.Text = nameplayer & " " & surnameplayer
        If Not flagame Then
            Buttonnextgame.Visible = False

        Else
            'news'trip.Enabled = False
            Buttonnextgame.Visible = True
            Buttonnextgame.Enabled = False
        End If
        ptspc.Text = pcpoints.ToString
        ptsplayer.Text = playerpoints.ToString
        panelscore.Top = ToolStriplettres.Bottom + imageleslettres.Height * 3
        panelscore.Left = Me.Width \ 2 - panelscore.Width \ 2 + 6
        Labelstatus.Location = New Point(panelscore.Left - Labelstatus.Width - 3, panelscore.Top + (panelscore.Bottom - panelscore.Top - Labelstatus.Height) \ 2)
        Buttonvoyelle.Size = Buttonvoyelle.Image.Size
        Buttonconsonne.Size = Buttonconsonne.Image.Size
        Buttonerase.Size = Buttonerase.Image.Size
        CheckInsert.Size = CheckInsert.Image.Size
        CheckInsert.Location = New Point(PanelLettres.Left + PanelLettres.Width \ 2 - (CheckInsert.Width + Buttonvoyelle.Width + Buttonconsonne.Width + Buttonerase.Width + 24) \ 2, panelscore.Bottom + 6)
        Buttonvoyelle.Location = New Point(CheckInsert.Right + 6, panelscore.Bottom + 6)
        Buttonconsonne.Location = New Point(Buttonvoyelle.Right + 6, panelscore.Bottom + 6)
        Buttonerase.Location = New Point(Buttonconsonne.Right + 10, panelscore.Bottom + 6)
        support.Location = New Point(12, Buttonerase.Bottom + 6)
    End Sub
    Private Sub InitLettre()

        flagresult = False
        counter = 0
        t = 0
        countervoyelle = 0
        Buttonvoyelle.Enabled = True
        Buttonconsonne.Enabled = True
        stringofletters = String.Empty
        ToolStripButtonSolution.Enabled = False
        wordplayer = String.Empty.PadLeft(10, " "c).ToCharArray

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
    Private Sub InitSizeListboxResult()
        Dim gr As System.Drawing.Graphics
        gr = ListBoxresult.CreateGraphics
        Dim thefont As New Font(ListBoxresult.Font.Name, ListBoxresult.Font.Size, ListBoxresult.Font.Style)
        Dim fmt As StringFormat = New StringFormat(StringFormat.GenericTypographic)
        fmt.FormatFlags = StringFormatFlags.MeasureTrailingSpaces
        Dim size As SizeF
        size = gr.MeasureString("MMMMMMMMMMI", thefont, 0, fmt)
        ListBoxresult.Width = Convert.ToInt32(size.Width)
        ListBoxresult.Height = Convert.ToInt32(size.Height * 8)
        Panelsolution.Width = ListBoxresult.Width + 3
        Panelsolution.Height = ListBoxresult.Height + 2 + Buttonclose.Height
        Panelsolution.Location = New Point(12, ToolStriplettres.Bottom + 8)
        Buttonclose.Location = New Point(1, 1)
        ListBoxresult.Location = New Point(1, Buttonclose.Bottom + 2)
        Panelsolution.Visible = False
    End Sub
#End Region
#Region "graphics"


    Private Sub ShowAllLetters(ByVal gr As System.Drawing.Graphics, ByVal thepic As PictureBox)
        Dim myfont As New Font("arial", 34, FontStyle.Bold, GraphicsUnit.Pixel)
        Dim mesure As New SizeF
        Dim index As Integer
        Try
            index = Convert.ToInt32(thepic.Tag)
            If index > stringofletters.Length - 1 Then
                Exit Sub
            End If
            mesure = gr.MeasureString(stringofletters(index), myfont)
            gr.DrawString(stringofletters(index), myfont, Brushes.Black, (thepic.Width - mesure.Width) / 2, (thepic.Height - mesure.Height) / 2)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub


#End Region


#Region "events"

    Private Sub Formlettres_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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

    Private Sub Formlettres_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        synth = New SpeechSynthesizer
        synth.SetOutputToDefaultAudioDevice()
        synth.SelectVoice("ScanSoft Virginie_Dri40_16kHz")
        ' synth.SelectVoice("Microsoft Server Speech Text to Speech Voice (fr-FR, Hortense)")
        AddHandler synth.SpeakCompleted, AddressOf synth_SpeakCompleted
        synth.Rate = 0
        Me.Location = New Point(0, 0)
        support.BackgroundImage = imagesupport
        support.Size = imagesupport.Size
        If flagame Then
            Labelstatus.Image = gamegimage
            Labelstatus.Size = gamegimage.Size
            ToolStripButtonNew.Enabled = False
            nochrono.Enabled = False
            If flagstartlettre Then
                Combosec.Enabled = False
            End If
        Else
            Labelstatus.Image = trainingimage
            Labelstatus.Size = trainingimage.Size
            ToolStripButtonNew.Enabled = True
            nochrono.Enabled = True
            backgroundWorker1.WorkerSupportsCancellation = True
        End If
        'db.Init()

        InitComboSec()
        distribute = New ClassDistribution
        InitPanelScore()
        InitChronoOption()
        InitPanelJeu()
        InitTimer()
        InitLettre()
        InitPanelTimer()
        CheckInsert.Focus()
        InitSizeListboxResult()

    End Sub
    Private Function CountOccurence(ByVal theletter As String) As Integer
        Dim count As Integer
        count = 0
        For iter = 0 To stringofletters.Length - 1
            If stringofletters(iter) = theletter Then
                count += 1
            End If
        Next
        Return count
    End Function
    Private Sub Buttonconsonne_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Buttonconsonne.MouseClick
        Dim keepsearch As Boolean
        keepsearch = True

        DirectCast(sender, Button).Enabled = False
        Do Until (Not keepsearch)
            lettre = distribute.GetConsonne
            If CountOccurence(lettre) < 3 Then
                keepsearch = False
            End If
        Loop
        counter += 1
        '   If counter > NUMBERLETTERS - 3 And countervoyelle < 2 Then
        'Buttonconsonne.Enabled = False
        ' Exit Sub
        'Else
        'Buttonconsonne.Enabled = True
        'End If
        stringofletters &= lettre
        synth.SpeakAsync(lettre)
        listlettre(counter - 1).value = lettre
        listlettre(counter - 1).pic.Invalidate()
        Timeranimation.Start()
        Timeranimation.Interval = 1
        If counter = NUMBERLETTERS Then
            Buttonerase.Enabled = True
            listlettre(counter - 1).pic.Invalidate()
            '  Buttonconsonne.Enabled = False
            ' Buttonvoyelle.Enabled = False
            FreezeLetter(False)

            If flagchrono Then
                Combosec.Enabled = False
                Timerprogressbar.Start()
                starttime = DateTime.Now
            Else
                Combosec.Enabled = True
                Timerprogressbar.Stop()
            End If
            If Not backgroundWorker1.IsBusy Then
                backgroundWorker1.RunWorkerAsync()
            End If

        End If
        CheckInsert.Focus()
    End Sub

    Private Sub synth_SpeakCompleted(ByVal sender As Object, ByVal e As SpeakCompletedEventArgs)
        Timerdelay.Interval = 100
        If counter < NUMBERLETTERS Then
            Timerdelay.Start()
        Else
            Timerdelay.Stop()
            Buttonvoyelle.Enabled = False
            Buttonconsonne.Enabled = False
        End If


    End Sub

    Private Sub FreezeLetter(ByVal flag As Boolean)
        For Each ctrl In Me.Controls
            If TypeOf ctrl Is PictureBox Then
                DirectCast(ctrl, PictureBox).Enabled = Not flag
            End If

        Next
    End Sub
    Private Sub Buttonvoyelle_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Buttonvoyelle.MouseClick
        DirectCast(sender, Button).Enabled = False
        Dim keepsearch As Boolean
        keepsearch = True
        Do Until (Not keepsearch)
            lettre = distribute.GetVoyelle
            If CountOccurence(lettre) < 3 Then
                keepsearch = False
            End If
        Loop
        counter += 1
        countervoyelle += 1
        If countervoyelle > 1 Then
            Buttonconsonne.Enabled = True
        End If
        stringofletters &= lettre
        synth.SpeakAsync(lettre)
        listlettre(counter - 1).value = lettre
        listlettre(counter - 1).pic.Invalidate()
        Timeranimation.Start()
        Timeranimation.Interval = 1
        If counter = NUMBERLETTERS Then
            buttonerase.Enabled = True
            listlettre(counter - 1).pic.Invalidate()
            '   Buttonvoyelle.Enabled = False
            '   Buttonconsonne.Enabled = False

            FreezeLetter(False)
            If flagchrono Then
                Combosec.Enabled = False
                Timerprogressbar.Start()
                starttime = DateTime.Now
            Else
                Combosec.Enabled = True
                Timerprogressbar.Stop()
            End If

            If Not backgroundWorker1.IsBusy Then
                backgroundWorker1.RunWorkerAsync()
            End If

        End If
        CheckInsert.Focus()
    End Sub

    Private Sub thepicMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        lastmouselocation = e.Location
        Dim x, y, left, top As Integer
        x = DirectCast(sender, PictureBox).Left
        y = DirectCast(sender, PictureBox).Top
        For iter = 0 To listcasetarget.Count - 1
            left = listcasetarget(iter).location.X + PanelLettres.Location.X
            top = listcasetarget(iter).location.Y + PanelLettres.Location.Y
            If ((x + e.X) >= left) And ((x + e.X) <= left + WIDTHCARD) And ((y + e.Y) >= top) And ((y + e.Y) <= top + HEIGHTCARD) And listcasetarget(iter).tag.ToString.Substring(1, 1) = "B" Then
                listcasetarget(iter).tag = listcasetarget(iter).tag.ToString.Substring(0, 1) & "E"
                Exit For
            End If
        Next

    End Sub

    Private Sub thepicMousedoubleclick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)

        For iter = 0 To listcasetarget.Count - 1

            If listcasetarget(iter).tag.Substring(1) = "E" Then
                listcaseorigine(Convert.ToInt32(DirectCast(sender, PictureBox).Tag)).tag = "E"
                DirectCast(sender, PictureBox).Left = listcasetarget(iter).location.X + PanelLettres.Location.X
                DirectCast(sender, PictureBox).Top = listcasetarget(iter).location.Y + PanelLettres.Location.Y
                listcasetarget(iter).tag = listcasetarget(iter).tag.ToString.Substring(0, 1) & "B" & Convert.ToInt32(DirectCast(sender, PictureBox).Tag).ToString
                listletterposition(Convert.ToInt32(DirectCast(sender, PictureBox).Tag)).target = iter
                Exit For
            End If
        Next

    End Sub

    Private Sub thepicMouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Dim x, y, indexcase, indexlettre, indexpreviousletter, left, top As Integer
        x = DirectCast(sender, PictureBox).Left
        y = DirectCast(sender, PictureBox).Top
        indexlettre = Convert.ToInt32(DirectCast(sender, PictureBox).Tag)

        For Each item In listcasetarget
            left = item.location.X + PanelLettres.Location.X
            top = item.location.Y + PanelLettres.Location.Y
            If ((x + e.X) >= left) And ((x + e.X) <= left + WIDTHCARD) And ((y + e.Y) >= top) And ((y + e.Y) <= top + HEIGHTCARD) Then

                'la lettre est placé dans une case 
                DirectCast(sender, PictureBox).BringToFront()
                DirectCast(sender, PictureBox).Left = left
                DirectCast(sender, PictureBox).Top = top
                If CheckInsert.Checked And item.tag.ToString.Substring(1, 1) = "B" Then
                    Dim indexemptycase As Integer
                    indexcase = Convert.ToInt32(item.tag.ToString.Substring(0, 1))
                    'trouver la premiere case vide à partir de indexcase
                    For indexemptycase = indexcase + 1 To listcasetarget.Count - 1
                        If listcasetarget(indexemptycase).tag.ToString.Substring(1, 1) = "E" Then
                            Exit For
                        End If
                    Next
                    'shift right
                    If indexemptycase = listcasetarget.Count Then
                        listletterposition(Convert.ToInt32(listcasetarget(indexemptycase - 1).tag.ToString.Substring(2, 1))).target = -1

                        listlettre(Convert.ToInt32(listcasetarget(indexemptycase - 1).tag.ToString.Substring(2, 1))).pic.Left = listcaseorigine(Convert.ToInt32(listcasetarget(indexemptycase - 1).tag.ToString.Substring(2, 1))).location.X
                        listlettre(Convert.ToInt32(listcasetarget(indexemptycase - 1).tag.ToString.Substring(2, 1))).pic.Top = listcaseorigine(Convert.ToInt32(listcasetarget(indexemptycase - 1).tag.ToString.Substring(2, 1))).location.Y
                        listcasetarget(indexemptycase - 1).tag = (indexemptycase - 1).ToString & "E"
                        indexemptycase -= 1
                    End If
                    indexemptycase -= 1

                    For iter = indexemptycase To indexcase Step -1
                        listlettre(Convert.ToInt32(listcasetarget(iter).tag.ToString.Substring(2, 1))).pic.Left = listcasetarget(iter + 1).location.X + PanelLettres.Left
                        listlettre(Convert.ToInt32(listcasetarget(iter).tag.ToString.Substring(2, 1))).pic.Top = listcasetarget(iter + 1).location.Y + PanelLettres.Top
                        listletterposition(Convert.ToInt32(listcasetarget(iter).tag.ToString.Substring(2, 1))).target = iter + 1
                        listcasetarget(iter + 1).tag = (iter + 1).ToString & "B" & listcasetarget(iter).tag.ToString.Substring(2, 1)

                    Next

                    listletterposition(indexlettre).target = Convert.ToInt32(item.tag.ToString.Substring(0, 1))
                    item.tag = item.tag.ToString.Substring(0, 1) & "B" & indexlettre.ToString
                    Exit Sub
                End If
                If item.tag.ToString.Substring(1, 1) = "E" Then
                    'si la case est vide
                    'la case target tag = index de la case B pour busy et l'index de la lettre 
                    item.tag = item.tag.ToString.Substring(0, 1) & "B" & indexlettre.ToString
                    listletterposition(indexlettre).target = Convert.ToInt32(item.tag.ToString.Substring(0, 1))
                    Exit Sub
                Else

                    ' la lettre  remplace une autre 
                    'indexcase de la case target qui doit etre  remplacer par la lettre
                    indexcase = Convert.ToInt32(item.tag.ToString.Substring(0, 1))
                    indexpreviousletter = Convert.ToInt32(item.tag.ToString.Substring(2, 1))
                    If listletterposition(indexlettre).target = -1 Then
                        'la lettre remplacée revient à sa case de départ
                        listlettre(indexpreviousletter).pic.Left = listcaseorigine(indexpreviousletter).location.X
                        listlettre(indexpreviousletter).pic.Top = listcaseorigine(indexpreviousletter).location.Y
                        listletterposition(indexpreviousletter).target = -1
                        listletterposition(indexlettre).target = indexcase
                        item.tag = item.tag.ToString.Substring(0, 1) & "B" & indexlettre.ToString
                        Exit Sub
                    Else
                        'inverser les lettres
                        Dim previousindexcase As Integer
                        previousindexcase = listletterposition(indexlettre).target
                        listlettre(indexpreviousletter).pic.Left = listcasetarget(previousindexcase).location.X + PanelLettres.Left
                        listlettre(indexpreviousletter).pic.Top = listcasetarget(previousindexcase).location.Y + PanelLettres.Top
                        listletterposition(indexpreviousletter).target = previousindexcase
                        listletterposition(indexlettre).target = indexcase
                        item.tag = item.tag.ToString.Substring(0, 1) & "B" & indexlettre.ToString
                        listcasetarget(previousindexcase).tag = listcasetarget(previousindexcase).tag.ToString.Substring(0, 1) & "B" & indexpreviousletter.ToString
                        Exit Sub

                    End If
                End If

            End If
        Next
        listletterposition(indexlettre).target = -1
        DirectCast(sender, PictureBox).Location = listcaseorigine(indexlettre).location

    End Sub
    Private Sub thepicMouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Dim pt As New Point
        If flagresult Then
            Exit Sub
        End If
        pt = e.Location
        If e.Button = Windows.Forms.MouseButtons.Left Then
            pt.X = (pt.X + DirectCast(sender, PictureBox).Left) - lastmouselocation.X
            pt.Y = (pt.Y + DirectCast(sender, PictureBox).Top) - lastmouselocation.Y
            DirectCast(sender, PictureBox).Location = pt
            DirectCast(sender, PictureBox).BringToFront()
        End If
    End Sub



    Private Sub Timerprogressbar_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timerprogressbar.Tick


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
            buttonerase.Enabled = False
            Combosec.Enabled = True
            ToolStripButtonSolution.Enabled = True
            If flagame Then
                ToolStripButtonNew.Enabled = False
                flagstartlettre = True
                Combosec.Enabled = False
                Buttonnextgame.Enabled = True
            Else
                ToolStripButtonNew.Enabled = True
            End If
            FreezeLetter(True)
            CheckInsert.Enabled = False
            MessageBox.Show("Le temps s'est écoulé", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            flagresult = True
            UpdateScore()
            Exit Sub
        End If

    End Sub


    Private Sub thepicPaint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs)

        If stringofletters <> String.Empty Then
            ShowAllLetters(e.Graphics, DirectCast(sender, PictureBox))
        End If

    End Sub

    Private Sub Formlettres_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseEnter
        If insidegroupchrono Then
            Groupchrono.Visible = False
            insidegroupchrono = False
        End If
    End Sub

    Private Sub Formleslettres_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Try
            e.Graphics.DrawImage(imageleslettres, ClientSize.Width \ 2 - imageleslettres.Width \ 2, ToolStriplettres.Bottom + imageleslettres.Height)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Buttonnextgame_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Buttonnextgame.MouseClick
        Dim scoreobj As ClassScore
        DirectCast(sender, Button).Enabled = False
        totalcoup += 1
        If totalcoup = 12 Then
            scoreobj = New ClassScore(score.surnameplayer & " " & score.nameplayer, Dirigepartie.limittimechiffre, Dirigepartie.limittimelettre, score.pcpoints, score.playerpoints)
            scoreobj.DisplayResult()
            scoreobj.Location = New Point(ClientSize.Width \ 2 - scoreobj.Width \ 2, ClientSize.Height \ 2 - scoreobj.Height \ 2 - ToolStriplettres.Height)
            scoreobj.ShowDialog()
            scoreobj.Close()
            flagame = False
            Formpreface.Show()
            flagckickX = False
            flagquit = False
            Me.Close()
            Exit Sub
        Else
            Combosec.Enabled = False
            couplettre += 1
            If couplettre = 2 Then
                couplettre = 0
                ' db.CloseConnection()
                Formchiffre.Show()
                flagckickX = False
                flagquit = False
                Me.Close()
            Else
                If backgroundWorker1.IsBusy Then
                    backgroundWorker1.CancelAsync()
                End If
                distribute = New ClassDistribution
                CheckInsert.Enabled = True
                CheckInsert.Checked = False
                Timeranimation.Stop()
                Timeranimation.Interval = 1

                Timerprogressbar.Stop()
                countertime = limittime
                unitmin = limittime \ 60
                tensec = (limittime Mod 60) \ 10
                unitsec = (limittime Mod 60) Mod 10
                unitsecpic.Invalidate()
                tensecpic.Invalidate()
                unitminpic.Invalidate()

                For x As Integer = 0 To 9
                    Controls.RemoveByKey("lettres" & x.ToString)
                Next
                InitLettre()
                InitPanelScore()
                InitPanelJeu()
                Panelsolution.Visible = False
                CheckInsert.Focus()

            End If
        End If



    End Sub
    Private Sub Combosec_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Combosec.SelectedValueChanged
        limittime = Convert.ToInt32(DirectCast(sender, ComboBox).SelectedItem)
        countertime = limittime
        limittimelettre = limittime
        My.Settings.lettertime = limittime
        unitmin = limittime \ 60
        tensec = (limittime Mod 60) \ 10
        unitsec = (limittime Mod 60) Mod 10
        unitsecpic.Invalidate()
        tensecpic.Invalidate()
        unitminpic.Invalidate()
    End Sub
    Private Sub ToolStripButtonChrono_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripButtonChrono.MouseEnter
        Groupchrono.Visible = True
    End Sub
    Private Sub ToolStripButtonSolution_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ToolStripButtonSolution.MouseDown
        ShowLettresResult()
        '  DirectCast(sender, ToolStripButton).Enabled = False
    End Sub
    Private Sub ToolStripButtonNew_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripButtonNew.MouseEnter
        Groupchrono.Visible = False
    End Sub
    Private Sub ToolStripButtonNew_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ToolStripButtonNew.MouseDown
        If backgroundWorker1.IsBusy Then
            backgroundWorker1.CancelAsync()
        End If
        distribute = New ClassDistribution
        CheckInsert.Enabled = True
        CheckInsert.Checked = False
        Timeranimation.Stop()
        Timeranimation.Interval = 1
        If flagame Then
            Dirigepartie.Rungame()
        End If
        Timerprogressbar.Stop()
        countertime = limittime
        unitmin = limittime \ 60
        tensec = (limittime Mod 60) \ 10
        unitsec = (limittime Mod 60) Mod 10
        unitsecpic.Invalidate()
        tensecpic.Invalidate()
        unitminpic.Invalidate()

        For x As Integer = 0 To 9
            Controls.RemoveByKey("lettres" & x.ToString)
        Next
        InitLettre()
        InitPanelScore()
        InitPanelJeu()
        Panelsolution.Visible = False
        CheckInsert.Focus()
    End Sub
    Private Sub ToolStripButtonHelp_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ToolStripButtonHelp.MouseDown
        If helpmenu.IsDisposed Then
            helpmenu = New Classhelp("HelpLettre.txt")
        End If
        Me.Controls.Add(helpmenu)
        helpmenu.Location = New Point(6, ToolStriplettres.Height * 2)
        helpmenu.BringToFront()
        helpmenu.showhelp()
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
    Private Sub ToolStripButtonQuit_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ToolStripButtonQuit.MouseDown
        Dim result As DialogResult
        If backgroundWorker1.IsBusy Then
            backgroundWorker1.CancelAsync()
        End If
        result = MessageBox.Show("Voulez vous quitter ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        If result = Windows.Forms.DialogResult.Yes Then
            flagckickX = False
            Me.Close()
        Else
            CheckInsert.Focus()
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

    Private Sub chrono_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chrono.CheckedChanged
        flagchrono = True
        Paneltimer.Visible = True
    End Sub

    Private Sub nochrono_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles nochrono.CheckedChanged
        flagchrono = False
        Paneltimer.Visible = False
    End Sub
    Private Sub Groupchrono_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Groupchrono.MouseEnter
        insidegroupchrono = True
    End Sub
    Private Sub Buttonerase_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Buttonerase.MouseClick
        For iter = 0 To listlettre.Count - 1
            listlettre(iter).pic.Left = listcaseorigine(Convert.ToInt32(listlettre(iter).pic.Tag.ToString)).location.X
            listlettre(iter).pic.Top = listcaseorigine(Convert.ToInt32(listlettre(iter).pic.Tag.ToString)).location.Y
            listlettre(iter).pic.Tag = Convert.ToInt32(listlettre(iter).pic.Tag.ToString)
            listcasetarget(Convert.ToInt32(listlettre(iter).pic.Tag.ToString)).tag = listlettre(iter).pic.Tag.ToString & "E"
            listletterposition(Convert.ToInt32(listlettre(iter).pic.Tag.ToString)).target = -1
        Next
        Panelsolution.Visible = False
        wordplayer = String.Empty.PadLeft(9, " "c).ToCharArray
        CheckInsert.Focus()
    End Sub


#End Region

#Region "process"
    Public Sub New()

        ' This call is required by the Windows Form Designer.

        InitializeComponent()
        trainingimage = CType(My.Resources.ResourceManager.GetObject("training_fw"), Bitmap)
        gamegimage = CType(My.Resources.ResourceManager.GetObject("game_fw"), Bitmap)
        imageleslettres = CType(My.Resources.ResourceManager.GetObject("leslettres"), Bitmap)
        imagepanelletters = CType(My.Resources.ResourceManager.GetObject("panelletters"), Bitmap)
        imagesupport = CType(My.Resources.ResourceManager.GetObject("support"), Bitmap)
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Function ChangeTrueButton() As Boolean
        If listsolution.Count >= 0 Then
            ToolStripButtonSolution.Enabled = True
            Return True
        End If
    End Function
    Private Sub ShowLettresResult()
        If listsolution.Count = 0 Then
            MessageBox.Show("Aucune solution", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        ListBoxresult.Items.Clear()
        ListBoxresult.Items.Add(listsolution(0).Length.ToString & " LETTRES")

        For Each item In listsolution
            ListBoxresult.Items.Add(item)
            ' ListBoxresult.Items.Add(Environment.NewLine)
        Next
        Panelsolution.Visible = True
    End Sub
   
    Private Sub backgroundWorker1_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles backgroundWorker1.DoWork
        solutionlettre = New LettreSolution(NUMBERLETTERS, stringofletters)
        listsolution.Clear()
        listsolution = solutionlettre.GetSolution(Function() backgroundWorker1.CancellationPending, Function() isflagchrono(), Function() gettime(), Function() getlimittime())

        If Not flagchrono Then
            Try
                Invoke(ModifyButton)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If

    End Sub
    Private Sub GetWord()
        'forme le mot avec les lettres choisies
        Dim iter As Integer
        For iter = 0 To listletterposition.Length - 1
            If listletterposition(iter).target <> -1 Then
                wordplayer(listletterposition(iter).target) = stringofletters(listletterposition(iter).original)

            End If
        Next
    End Sub
    Private Sub UpdateScore()
        Dim strword As String
        GetWord()
        strword = New String(wordplayer, 0, wordplayer.Length)
        strword = strword.Trim
        If strword <> String.Empty Then
            If solutionlettre.Checksolution(strword) Then
                If listsolution.Count > 0 AndAlso listsolution(0).Length > strword.Length Then
                    pcpoints += listsolution(0).Length
                End If
                If listsolution.Count > 0 AndAlso listsolution(0).Length = strword.Length Then
                    pcpoints += listsolution(0).Length
                    playerpoints += strword.Length
                End If
                If listsolution.Count > 0 AndAlso listsolution(0).Length < strword.Length Then
                    playerpoints += strword.Length
                End If
            Else
                MessageBox.Show(strword & " n'apparait pas dans le dictionnaire du logiciel", "Mot introuvable", MessageBoxButtons.OK, MessageBoxIcon.Information)
                If listsolution.Count > 0 Then
                    pcpoints += listsolution(0).Length
                End If
            End If
        Else
            If listsolution.Count > 0 Then
                pcpoints += listsolution(0).Length
            End If
        End If

        ptspc.Text = pcpoints.ToString
        ptsplayer.Text = playerpoints.ToString
    End Sub
    Private Sub Buttonclose_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Buttonclose.MouseClick
        Panelsolution.Visible = False
    End Sub
#End Region


    Private Sub ListBoxresult_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBoxresult.SelectedIndexChanged
        Dim word() As Char
        Dim index As Integer = 0
        If DirectCast(sender, ListBox).SelectedIndex = 0 Then
            Exit Sub
        End If
        word = DirectCast(sender, ListBox).SelectedItem.ToString.ToCharArray
        'on remet les lettres à leur position d'origine
        For Each item As classletterdata In listlettre
            item.used = False
            item.pic.Location = New Point(listcaseorigine(index).location.X, listcaseorigine(index).location.Y)
            index += 1

        Next

        'on affiche les lettres du mot selectionné dans le PanelLettres
        index = 0
        For Each item In word
            For Each data As classletterdata In listlettre
                If Not data.used AndAlso data.value = item Then
                    data.pic.Location = New Point(listcasetarget(index).location.X + PanelLettres.Left, listcasetarget(index).location.Y + PanelLettres.Top)
                    data.used = True
                    index += 1
                    Exit For
                End If
            Next

        Next
    End Sub

    Private Sub Timeranimation_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timeranimation.Tick
        listlettre(counter - 1).pic.Visible = True
        DirectCast(sender, Timer).Interval = 212
        Static countenter As Integer = 0
        If countenter = 0 Then
            If listcaseorigine(counter - 1).location.X < support.Width \ 2 Then
                listlettre(counter - 1).pic.Location = New Point((listlettre(counter - 1).pic.Location.X - listcaseorigine(counter - 1).location.X) \ 2 + listcaseorigine(counter - 1).location.X, listcaseorigine(counter - 1).location.Y \ 10)
            Else
                listlettre(counter - 1).pic.Location = New Point((listcaseorigine(counter - 1).location.X - listlettre(counter - 1).pic.Location.X) \ 2 + listlettre(counter - 1).pic.Location.X, listcaseorigine(counter - 1).location.Y \ 10)
            End If
            countenter += 1
           
        Else
            listlettre(counter - 1).pic.Location = New Point(listcaseorigine(counter - 1).location.X, listcaseorigine(counter - 1).location.Y)
            DirectCast(sender, Timer).Stop()
            If counter > NUMBERLETTERS - 3 And countervoyelle < 2 Then
                Buttonconsonne.Tag = "0"
            Else
                Buttonconsonne.Tag = "1"
            End If
            countenter = 0
        End If
       End Sub


    Private Sub Timerdelay_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timerdelay.Tick
        Buttonvoyelle.Enabled = True
        If Buttonconsonne.Tag.ToString = "1" Then
            Buttonconsonne.Enabled = True
        Else
            Buttonconsonne.Enabled = False
        End If
    End Sub

   
    
    
End Class

