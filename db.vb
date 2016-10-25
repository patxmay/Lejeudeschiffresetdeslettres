Imports System.Data.OleDb


Module db
    Private Connection As New OleDb.OleDbConnection 'declares  connection
    
    Public Sub Init()

        Dim base As String = "provider=microsoft.jet.oledb.4.0;data source=" & Application.StartupPath & "\auxfile\dbchiffreslettres.mdb"
        If Connection.State = ConnectionState.Open Then
            Exit Sub
        End If
        Connection.ConnectionString = base
        Try
            Connection.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub CloseConnection()
        Connection.Close()
    End Sub
    
    
    Public Function IsPlayerExist(ByVal FamillyName As String, ByVal Surname As String) As Boolean
        Dim command As New OleDbCommand
        command.Connection = Connection
        command.CommandText = "SELECT Playercode FROM Player WHERE Name = [name?] AND Surname = [surname?];"
        command.Parameters.Add("name?", OleDbType.BSTR).Value = FamillyName
        command.Parameters.Add("surname?", OleDbType.BSTR).Value = Surname
        Try
            Return Convert.ToBoolean(command.ExecuteScalar())
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        
    End Function
    Public Sub InsertPlayer(ByVal FamillyName As String, ByVal Surname As String)

        Dim command As New OleDbCommand
        command.Connection = Connection
        command.CommandText = "INSERT INTO Player (Name,Surname) VALUES ([name?],[surname?]);"
        command.Parameters.Add("name?", OleDbType.BSTR).Value = FamillyName
        command.Parameters.Add("surname?", OleDbType.BSTR).Value = Surname
        command.ExecuteNonQuery()

    End Sub
    Public Sub UpdateNamePlayer(ByVal FamillyName As String, ByVal Surname As String)

        Dim command As New OleDbCommand
        Dim codeplayer As Integer
        codeplayer = GetCodePlayer(My.Settings.Nameplayer, My.Settings.Surnameplayer)
        command.Connection = Connection
        command.CommandText = "UPDATE Player SET Name = ?, Surname = ? WHERE Playercode = ?"
        command.Parameters.Add("?", OleDbType.BSTR).Value = FamillyName
        command.Parameters.Add("?", OleDbType.BSTR).Value = Surname
        command.Parameters.Add("?", OleDbType.Integer).Value = codeplayer
        command.ExecuteNonQuery()
    End Sub

    Private Function GetCodePlayer(ByVal FamillyName As String, ByVal Surname As String) As Integer

        Dim command As New OleDbCommand
        command.CommandText = "SELECT Playercode FROM Player WHERE Name = [name?] AND Surname = [surname?];"
        command.Parameters.Add("name?", OleDbType.BSTR).Value = FamillyName
        command.Parameters.Add("surname?", OleDbType.BSTR).Value = Surname
        command.Connection = Connection
        Return Convert.ToInt32(command.ExecuteScalar())

    End Function
    Public Sub InsertResult(ByVal FamillyName As String, ByVal Surname As String, ByVal pointplayer As Integer, ByVal pointpc As Integer, ByVal timelimitchiffre As Integer, ByVal timelimitlettre As Integer, ByVal dategame As Date)

        Dim command As New OleDbCommand
        Dim codeplayer As Integer
        codeplayer = GetCodePlayer(FamillyName, Surname)
        command.Connection = Connection
        command.CommandText = "INSERT INTO Results (playercode,Ptsplayer,Ptspc,TimerChiffres,TimerLettres,DateGame) VALUES (?,?,?,?,?,?);"
        command.Parameters.Add("?", OleDbType.Integer).Value = codeplayer
        command.Parameters.Add("?", OleDbType.Integer).Value = pointplayer
        command.Parameters.Add("?", OleDbType.Integer).Value = pointpc
        command.Parameters.Add("?", OleDbType.Integer).Value = timelimitchiffre
        command.Parameters.Add("?", OleDbType.Integer).Value = timelimitlettre
        command.Parameters.Add("?", OleDbType.DBDate).Value = dategame
        command.ExecuteNonQuery()

    End Sub
    Public Function GetPrivateResult(ByVal FamillyName As String, ByVal Surname As String) As OleDbDataReader

        Dim command As New OleDbCommand
        Dim recordset As OleDbDataReader
        recordset = Nothing
        Dim codeplayer As Integer
        codeplayer = GetCodePlayer(FamillyName, Surname)
        command.Connection = Connection
        command.CommandText = "SELECT Ptsplayer as Pointsjoueur  , Ptspc as Pointsordinateur,TimerChiffres as Chronochiffre ,TimerLettres as Chronolettres ,DateGame as Datedejeu  FROM Results WHERE playercode = [playercode?] ;"
        command.Parameters.Add("playercode?", OleDbType.Integer).Value = codeplayer
        recordset = command.ExecuteReader()
        ' x = Convert.ToInt32(command.ExecuteScalar())
        Return recordset
    End Function

    Public Function ISResult(ByVal FamillyName As String, ByVal Surname As String) As Boolean
        Dim x As Integer
        Dim command As New OleDbCommand
        Dim codeplayer As Integer
        codeplayer = GetCodePlayer(FamillyName, Surname)
        command.Connection = Connection
        command.CommandText = "SELECT coderesult FROM Results WHERE playercode = [playercode?] ;"
        command.Parameters.Add("playercode?", OleDbType.Integer).Value = codeplayer
        x = Convert.ToInt32(command.ExecuteScalar())
        If x > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

   Public Function GetCodesResult(ByVal FamillyName As String, ByVal Surname As String) As List(Of Integer)
        Dim command As New OleDbCommand
        Dim recordset As OleDbDataReader
        Dim list As New List(Of Integer)
        recordset = Nothing
        Dim codeplayer As Integer
        codeplayer = GetCodePlayer(FamillyName, Surname)
        command.Connection = Connection
        command.CommandText = "SELECT coderesult FROM Results WHERE playercode = [playercode?] ;"
        command.Parameters.Add("playercode?", OleDbType.Integer).Value = codeplayer
        recordset = command.ExecuteReader()
        While recordset.Read
            list.Add(Convert.ToInt32(recordset.GetValue(0)))
        End While
        Return list
    End Function

    Public Sub DeleteRecord(ByVal coderesult As Integer)

        Dim command As New OleDbCommand
        command.Connection = Connection
        command.CommandText = "DELETE FROM Results WHERE coderesult = [coderesult?];"
        command.Parameters.Add("coderesult?", OleDbType.Integer).Value = coderesult
        command.ExecuteNonQuery()
    End Sub
    Public Sub DeleteAllPrivateRecord(ByVal FamillyName As String, ByVal Surname As String)

        Dim command As New OleDbCommand
        Dim codeplayer As Integer
        codeplayer = GetCodePlayer(FamillyName, Surname)
        command.Connection = Connection
        command.CommandText = "DELETE FROM Results WHERE playercode = [playercode?] ;"
        command.Parameters.Add("playercode?", OleDbType.Integer).Value = codeplayer
        command.ExecuteNonQuery()
    End Sub
    
End Module

