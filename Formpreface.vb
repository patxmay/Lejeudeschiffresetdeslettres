'12371660

Imports System.Drawing.Drawing2D

Public Class Formpreface
    Private flagckickX As Boolean = True
    Private flagquit As Boolean = True

   
    Private Structure dataname
        Public name As String
        Public SurName As String
    End Structure
    Private listplayers As New List(Of dataname)



#Region "events"

    Private Sub Formpreface_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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


    Private Sub Formpreface_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        video.Location = New Point(0, Toolbarmenu.Bottom)
        video.Size = DisplayRectangle.Size
        video.Url = New Uri(Application.StartupPath & "\auxfile\preface.swf")

        ' video.Play()
        ' video.Loop = True
        Me.Location = New Point(0, 0)
        score.nameplayer = My.Settings.Nameplayer
        score.surnameplayer = My.Settings.Surnameplayer
        If Not db.IsPlayerExist(My.Settings.Nameplayer, My.Settings.Surnameplayer) Then
            db.InsertPlayer(My.Settings.Nameplayer, My.Settings.Surnameplayer)
        End If
        Dirigepartie.inside = True
    End Sub
    Private Sub ToolStripButtonchiffres_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ToolStripButtonchiffres.MouseUp
        Formchiffre.Show()
        flagckickX = False
        flagquit = False
        Me.Close()
    End Sub
    Private Sub ToolStripButtonlettres_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ToolStripButtonlettres.MouseUp
        Formlettres.Show()
        flagckickX = False
        flagquit = False
        Me.Close()
    End Sub
    Private Sub ToolStripButtonChooseNumbers_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ToolStripButtonChooseNumbers.MouseUp
        Formchoosen6number.Show()
        flagckickX = False
        flagquit = False
        Me.Close()
    End Sub
    Private Sub ToolStripButtonChooseLetter_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ToolStripButtonChooseLetter.MouseUp
        Formchoosenletter.Show()
        flagquit = False
        flagckickX = False
        Me.Close()
    End Sub
    Private Sub ToolStripButtonmanager_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ToolStripButtonmanager.MouseDown
        formmanagement.Show()
        flagckickX = False
        flagquit = False
        Me.Close()
    End Sub
    Private Sub ToolStripButtongame_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ToolStripButtongame.MouseUp
        If Not flagame Then
            Dirigepartie.Rungame()
            flagckickX = False
            flagquit = False
            Me.Close()
        End If
    End Sub




#End Region

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        Try
            db.Init()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        ' Add any initialization after the InitializeComponent() call.

    End Sub



    Private Sub Formpreface_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Refresh()
    End Sub

    Private Sub ToolStripButtonexit_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ToolStripButtonexit.MouseDown
        Dim result As DialogResult
        result = MessageBox.Show("Voulez vous quitter ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        If result = Windows.Forms.DialogResult.Yes Then

            flagckickX = False
            flagquit = True
            Me.Close()
        End If
    End Sub

  
End Class