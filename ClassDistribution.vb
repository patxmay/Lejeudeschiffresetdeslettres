Class ClassDistribution
    Private Class numbercard
        Public used As Boolean
        Public value As Integer
    End Class
    Private Class lettercard
        Public freq As Integer
        Public value As Char
    End Class

    Private listnumber As New List(Of numbercard)
    Private listconsonne As New List(Of lettercard)
    Private listvoyelle As New List(Of lettercard)


    Private Sub InitListVoyelle()
        Dim iter As Integer
        Dim card As lettercard
        listvoyelle.Clear()
        For iter = 0 To 5
            card = New lettercard
            Select Case iter
                Case 0
                    card.freq = 3
                    card.value = "A"c
                Case 1
                    card.freq = 3
                    card.value = "E"c
                Case 2
                    card.freq = 3
                    card.value = "I"c
                Case 3
                    card.freq = 3
                    card.value = "O"c
                Case 4
                    card.freq = 3
                    card.value = "U"c
                Case 5
                    card.freq = 1
                    card.value = "Y"c
            End Select

            listvoyelle.Add(card)
        Next
    End Sub
    Private Sub InitListConsonne()
        Dim iter As Integer
        Dim card As lettercard
        listconsonne.Clear()
        For iter = 0 To 19
            card = New lettercard
            Select Case iter
                Case 0
                    card.value = "B"c
                    card.freq = 3
                Case 1
                    card.value = "C"c
                    card.freq = 3
                Case 2
                    card.value = "D"c
                    card.freq = 3
                Case 3
                    card.value = "F"c
                    card.freq = 3
                Case 4
                    card.value = "G"c
                    card.freq = 3
                Case 5
                    card.value = "H"c
                    card.freq = 1
                Case 6
                    card.value = "J"c
                    card.freq = 1
                Case 7
                    card.value = "K"c
                    card.freq = 1
                Case 8
                    card.value = "L"c
                    card.freq = 3
                Case 9
                    card.value = "M"c
                    card.freq = 3
                Case 10
                    card.value = "N"c
                    card.freq = 3
                Case 11
                    card.value = "P"c
                    card.freq = 3
                Case 12
                    card.value = "Q"c
                    card.freq = 1
                Case 13
                    card.value = "R"c
                    card.freq = 3
                Case 14
                    card.value = "S"c
                    card.freq = 3
                Case 15
                    card.value = "T"c
                    card.freq = 3
                Case 16
                    card.value = "V"c
                    card.freq = 3
                Case 17
                    card.value = "W"c
                    card.freq = 1
                Case 18
                    card.value = "X"c
                    card.freq = 1
                Case 19
                    card.value = "Z"c
                    card.freq = 1
            End Select
            listconsonne.Add(card)
        Next
    End Sub
    Private Sub InitListnumber()
        Dim ncard As numbercard
        listnumber.Clear()
        For iter = 0 To 23
            ncard = New numbercard
            ncard.used = False
            If iter < 10 Then
                ncard.value = iter + 1
            ElseIf iter < 20 And iter > 10 Then
                ncard.value = iter - 10
            End If
            If iter = 10 Then
                ncard.value = 10
            ElseIf iter = 20 Then
                ncard.value = 25
            ElseIf iter = 21 Then
                ncard.value = 50
            ElseIf iter = 22 Then
                ncard.value = 75
            ElseIf iter = 23 Then
                ncard.value = 100
            End If
            listnumber.Add(ncard)

        Next
    End Sub

    Public Function GetConsonne() As Char
        Dim randnum As New Random
        Dim num As Integer
        Dim found As Boolean = False

        Dim index As Integer
       
        Do Until found
            For i = 0 To randnum.Next(10, 1000)
                num = randnum.Next(0, 65)
            Next
            Select Case num
                Case 0 To 4 : index = 0 'B
                Case 5 To 9 : index = 1 'C
                Case 10 To 14 : index = 2 'D
                Case 15 To 17 : index = 3 'F
                Case 17 To 19 : index = 4 'G
                Case 19 To 19 : index = 5 'H
                Case 20 To 20 : index = 6 'J
                Case 21 To 21
                    If randnum.Next(0, 1000) Mod 5 = 0 Then
                        index = 7
                    End If
                Case 22 To 26 : index = 8 'L
                Case 27 To 30 : index = 9 'M
                Case 31 To 34 : index = 10 'N
                Case 35 To 40 : index = 11 'P
                Case 41 To 41 : index = 12 'Q
                Case 42 To 46 : index = 13 'R
                Case 47 To 51 : index = 14 'S
                Case 52 To 56 : index = 15 'T
                Case 57 To 61 : index = 16 'V
                Case 62 To 62
                    If randnum.Next(0, 1000) Mod 7 = 0 Then
                        index = 17
                    End If
                Case 63 To 63
                    If randnum.Next(0, 1000) Mod 7 = 0 Then
                        index = 18
                    End If
                Case 64 To 64
                    If randnum.Next(0, 1000) Mod 7 = 0 Then
                        index = 19
                    End If
            End Select
            If listconsonne(index).freq > 0 Then
                found = True
            End If
             Loop
        listconsonne(index).freq -= 1
        Return listconsonne(index).value
    End Function
    Public Function GetVoyelle() As Char
        Dim randnum As New Random
        Dim num As Integer
        Dim index As Integer
        Dim found As Boolean = False
        Do Until found
            For i = 0 To randnum.Next(10, 1000)
                num = randnum.Next(0, 23)
            Next
            Select Case num
                Case 0 To 3 : index = 0 'A
                Case 4 To 11 : index = 1 'E
                Case 12 To 15 : index = 2 'I
                Case 16 To 18 : index = 3 'O
                Case 19 To 21 : index = 4 'U
                Case 22 To 22
                    If randnum.Next(0, 1000) Mod 5 = 0 Then
                        index = 5
                    End If

            End Select
            If listvoyelle(index).freq > 0 Then
                found = True
            End If
        Loop
        listvoyelle(index).freq -= 1
        Return listvoyelle(index).value
    End Function
    Public Function RandomChooseNumber() As List(Of Int64)
        'choisi aléatoirement 6 nombres
        Dim randnum As New Random
        Dim listnum As New List(Of Int64)
        Dim num As Integer
        Dim counter As Integer
        Dim counterbigger10 As Integer
        Dim found As Boolean


        counterbigger10 = 0
        For counter = 1 To 6
            found = False
            While Not found
                num = randnum.Next(0, 24)
                If listnumber(num).used = False Then
                    found = True
                    If num > 19 Then
                        If counterbigger10 >= 2 Then
                            found = False
                        End If
                        counterbigger10 += 1
                    End If
                End If
            End While
            listnumber(num).used = True
            listnum.Add(listnumber(num).value)
        Next


        Return listnum
    End Function

    Public Sub New()
        InitListConsonne()
        InitListnumber()
        InitListVoyelle()
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
End Class
