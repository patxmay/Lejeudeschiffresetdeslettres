Public Class Classkeyboard
    Inherits Panel
    Public Event akeypress()
    Private imagekey As Image
    Private imagebackspace As Image
    Private listbuttonskey As New List(Of Button)
    Property getkey As Char

  Public Sub New()
        Me.Text = String.Empty
        imagekey = CType(My.Resources.ResourceManager.GetObject("buttonkey"), Bitmap)
        imagebackspace = CType(My.Resources.ResourceManager.GetObject("backspace"), Bitmap)
        InitList()

    End Sub
    Private Sub InitList()
        Dim fontkey As New Font("arial", 12, FontStyle.Bold)
        Dim voyelle As String = "AEIOUY8"
        Dim buttonkey As Button
        Dim consonne As String = "BCDFGHJKLMNPQRSTVWXZ"
        Dim left, top As Integer
        left = 0
        top = 0
        For iter = 0 To 26
            buttonkey = New Button
            With buttonkey
                If iter = 6 Then
                    .Image = imagebackspace
                Else
                    .Image = imagekey
                End If
                .Size = .Image.Size
                .FlatStyle = Windows.Forms.FlatStyle.Popup
                .Font = fontkey
                .ForeColor = Color.AntiqueWhite
                If iter > 6 Then
                    .Text = consonne(iter - 7)
                ElseIf iter < 6 Then
                    .Text = voyelle(iter)
                End If
                If iter = 6 Then
                    .Tag = "8"c
                Else
                    .Tag = Convert.ToChar(.Text)
                End If
                .Location = New Point(left, top)
                listbuttonskey.Add(buttonkey)
                Me.Controls.Add(buttonkey)
                If (iter = 6) Or (iter = 16) Then
                    top = listbuttonskey(iter - 1).Bottom
                    left = 0
                Else
                    left = listbuttonskey(iter).Right - 3
                End If
            End With
            AddHandler listbuttonskey(iter).MouseClick, AddressOf keyMouseClick
        Next

        Me.BackColor = Color.Black
        Me.BorderStyle = Windows.Forms.BorderStyle.Fixed3D
        Me.Width = listbuttonskey(26).Right + 2
        Me.Height = 3 * listbuttonskey(0).Height + 6
    End Sub

    Private Sub keyMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        getkey = Convert.ToChar(DirectCast(sender, Button).Tag)
        RaiseEvent akeypress()
    End Sub
End Class
