Imports System.Drawing.Drawing2D
Imports System.Data.OleDb
Public Class formmanagement
#Region "declaration"
    Private imagemanageresult As Image
    Private helpmenu As New Classhelp("helpmanagement.txt")
    Private flagdel As Boolean
    'list des primary key  pour pouvoir supprimer le résultat 
    Private listcode As New List(Of Integer)
    Private flagckickX As Boolean = True
    Private flagdeletefromlist As Boolean = False
    Private flagquit As Boolean = True
#End Region


#Region "processing"
    
   
    Private Sub ShowMyresult()
        Dim recordset As OleDbDataReader

        DataGridresult.DataSource = Nothing
        DataGridresult.AutoSize = False
        Dim drawfont As New Font("arial", 14, FontStyle.Bold, GraphicsUnit.Pixel)

        DataGridresult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader
        DataGridresult.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders
        DataGridresult.ReadOnly = True
        DataGridresult.Font = drawfont
        recordset = db.GetPrivateResult(score.nameplayer, score.surnameplayer)
        DataGridresult.EnableHeadersVisualStyles = False
        DataGridresult.ColumnHeadersDefaultCellStyle.BackColor = Color.PowderBlue
        DataGridresult.AutoSize = True
        Dim bds As New BindingSource
        bds.DataSource = recordset

        DataGridresult.DataSource = bds

        Labeltitlegrid.Text = "Les résultats de " & score.nameplayer & " " & score.surnameplayer
        Labeltitlegrid.TextAlign = ContentAlignment.MiddleCenter
        Labeltitlegrid.Location = New Point(Me.Width \ 2 - Labeltitlegrid.Width \ 2, ToolStripmanagement.Bottom + 16 + imagemanageresult.Height * 2)
        DataGridresult.Location = New Point(Me.Width \ 2 - DataGridresult.Width \ 2, Labeltitlegrid.Bottom + 6)
        Labeltitlegrid.Visible = True
        DataGridresult.Visible = True

    End Sub
    

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Try
            imagemanageresult = CType(My.Resources.ResourceManager.GetObject("manageresult"), Bitmap)

        Catch ex As Exception

        End Try
        ' Add any initialization after the InitializeComponent() call.

    End Sub
#End Region
#Region "events"

    Private Sub formmanagement_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim result As DialogResult
        If Not flagquit Then
            Exit Sub
        End If
        If flagdeletefromlist Then
            MessageBox.Show("Aurevoir et merci", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Cancel = False
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


    Private Sub formmanagement_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Location = New Point(0, 0)

        db.Init()
        listcode = db.GetCodesResult(score.nameplayer, score.surnameplayer)
        Labeltitlegrid.Visible = False
        DataGridresult.Visible = False
    End Sub

    Private Sub formmanagement_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseEnter

        ToolStripDropDownmanage.HideDropDown()

    End Sub

    Private Sub formmanagement_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Try
            e.Graphics.DrawImage(imagemanageresult, ClientSize.Width \ 2 - imagemanageresult.Width \ 2, ToolStripmanagement.Bottom + imagemanageresult.Height)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Deleteanyresult_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Deleteanyresult.MouseDown
        flagdel = True
        If db.ISResult(score.nameplayer, score.surnameplayer) Then
            ShowMyresult()
        Else
            MessageBox.Show("Aucun résultat", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
    Private Sub Deleteallresults_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Deleteallresults.MouseDown
        flagdel = True
        Dim result As DialogResult


        If db.ISResult(score.nameplayer, score.surnameplayer) Then
            ShowMyresult()
            result = MessageBox.Show("Voulez vous supprimer tous vos résultats ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            If result = Windows.Forms.DialogResult.Yes Then
                db.DeleteAllPrivateRecord(score.nameplayer, score.surnameplayer)
                DataGridresult.Visible = False
            End If

        Else
            MessageBox.Show("Aucun résultat", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If
    End Sub
   
    Private Sub DataGridresult_RowHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridresult.RowHeaderMouseClick
        If Not flagdel Then
            Exit Sub
        End If
        Dim index As Integer
        Dim result As DialogResult
        index = DirectCast(sender, DataGridView).CurrentCellAddress.Y
        result = MessageBox.Show("Supprimer le résultat ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        If result = Windows.Forms.DialogResult.Yes Then
            db.DeleteRecord(listcode(index))
        End If

        If db.ISResult(score.nameplayer, score.surnameplayer) Then
            ShowMyresult()
        Else
            DataGridresult.Visible = False
        End If
    End Sub

    Private Sub ToolStripDropDownmanage_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripDropDownmanage.MouseEnter
        DirectCast(sender, ToolStripDropDownButton).ShowDropDown()

    End Sub
    Private Sub ToolStripDropDownstatistic_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripDropDownstatistic.MouseEnter
        DirectCast(sender, ToolStripDropDownButton).ShowDropDown()
    End Sub

    Private Sub Privateresult_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Privateresult.MouseDown
        flagdel = False
        If db.ISResult(score.nameplayer, score.surnameplayer) Then
            ShowMyresult()
        Else
            DataGridresult.Visible = False
            Labeltitlegrid.Text = "Les résultats de " & score.nameplayer & " " & score.surnameplayer
            Labeltitlegrid.TextAlign = ContentAlignment.MiddleCenter
            Labeltitlegrid.Location = New Point(Me.Width \ 2 - Labeltitlegrid.Width \ 2, ToolStripmanagement.Bottom + 16 + imagemanageresult.Height * 2)
            Labeltitlegrid.Visible = True
            MessageBox.Show("Aucun résultat", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
    
    Private Sub ToolStripButtonMainMenu_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ToolStripButtonMainMenu.MouseDown
        db.CloseConnection()
        Formpreface.Show()
        flagckickX = False
        flagquit = False
        Me.Close()
    End Sub

   


    Private Sub ToolStripButtonQuit_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ToolStripButtonQuit.MouseDown
        Dim result As DialogResult
        result = MessageBox.Show("Voulez vous quitter ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        If result = Windows.Forms.DialogResult.Yes Then
            db.CloseConnection()
            flagckickX = False
            Me.Close()
        End If
    End Sub


    Private Sub ToolStripButtonHelp_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ToolStripButtonHelp.MouseDown
        If helpmenu.IsDisposed Then
            helpmenu = New Classhelp("helpmanagement.txt")
        End If
        Me.Controls.Add(helpmenu)
        helpmenu.Location = New Point(6, ToolStripmanagement.Height * 2)
        helpmenu.BringToFront()
        helpmenu.showhelp()
    End Sub





#End Region

    
    
    
    
    
    
   
   
   
    
    
    
    
   
   
   
    
   
   
End Class