Imports System.IO

Public Class Classhelp
    Inherits Panel
    Friend WithEvents ButtonClose As System.Windows.Forms.Button
    Friend WithEvents ListBoxhelp As System.Windows.Forms.ListBox
    Private listhelp As New List(Of String)
    Public Sub New(ByVal helpname As String)

        Me.Width = 600
        Me.Height = 300
        InitializeComponent()
        Me.Controls.Add(ListBoxhelp)
        Me.Controls.Add(ButtonClose)
        ListBoxhelp.Location = New Point(0, 0)
        ButtonClose.Location = New Point(0, 0)
        ButtonClose.BringToFront()
        ListBoxhelp.Size = Me.Size
        ListBoxhelp.HorizontalScrollbar = True
        Try
            Me.ListBoxhelp.Font = New Font("arial", 12, FontStyle.Bold)
            Me.ListBoxhelp.BackColor = Color.LemonChiffon
            ListBoxhelp.Items.AddRange(IO.File.ReadAllLines(Application.StartupPath & "\auxfile\" & helpname).ToArray)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Friend Shared Function LoadResourceText(ByVal Sender As Object, ByVal Name As String, ByRef found As Boolean) As String

        Dim Result As String = String.Empty

        Name = (If(Sender Is Nothing, "", (If(TypeOf Sender Is String, DirectCast(Sender, String), Sender.[GetType]().[Namespace])) & Convert.ToString("."))) + Name

        'TODO: Warning!!!, inline IF is not supported ?
        Dim stream As System.IO.Stream = System.Reflection.Assembly.GetExecutingAssembly.GetManifestResourceStream(Name)
        Result = New System.IO.StreamReader(stream).ReadToEnd()

        Return Result
    End Function
    Public Sub showhelp()
        Me.Visible = True
    End Sub

    Private Sub InitializeComponent()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.ListBoxhelp = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'ButtonClose
        '
        Me.ButtonClose.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.ButtonClose.ForeColor = System.Drawing.Color.SteelBlue
        Me.ButtonClose.Location = New System.Drawing.Point(0, 0)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(75, 23)
        Me.ButtonClose.TabIndex = 0
        Me.ButtonClose.Text = "Fermer"
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'ListBoxhelp
        '
        Me.ListBoxhelp.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxhelp.FormattingEnabled = True
        Me.ListBoxhelp.Location = New System.Drawing.Point(0, 0)
        Me.ListBoxhelp.Name = "ListBoxhelp"
        Me.ListBoxhelp.Size = New System.Drawing.Size(120, 96)
        Me.ListBoxhelp.TabIndex = 0
        Me.ResumeLayout(False)

    End Sub

    Private Sub ButtonClose_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ButtonClose.MouseClick
        Me.Dispose()
    End Sub
End Class
