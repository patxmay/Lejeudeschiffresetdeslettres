Imports System.Text.RegularExpressions


Public Class LettreSolution
    'cherche la liste de mots le plus long selon les lettres distribuées
    'on construit une liste de combination de 10 9 8 7 6 5 4 3 2 lettres et on verifie avec chaque mot du dictionnaire sil est composé des meme lettres
    ' que la combination
    ' Private listdico() As List(Of String)
    Private listdico As New List(Of List(Of String))
    Private IsCanceledA As Func(Of Boolean)
    Private word As String

    Private Sub ReadList(ByVal n As Integer)
        Try
            For iter = 0 To n
                listdico.Add(New List(Of String))
                '  listdico(iter) = New List(Of String)
                listdico(iter) = System.IO.File.ReadAllLines(Application.StartupPath & "\auxfile\dico" & (iter).ToString & ".txt").ToList
            Next
        Catch ex As Exception
            'en cas d'exception affiche l'erreur 
            MessageBox.Show(ex.Message)

        End Try
    End Sub
   

    Public Function GetSolution(ByVal isCancellationPending As Func(Of Boolean)) As List(Of String)

        Dim found As Boolean

        Dim lengthword As Integer
        Dim listsolution As New List(Of String)
        Dim itemletters() As Char
        Dim listcombinaisons As New List(Of List(Of String))

        found = False
        IsCanceledA = isCancellationPending
        lengthword = word.Length - 2
        listcombinaisons = combinaison()
        If listcombinaisons.Count = 0 Then
            Return listsolution
        End If
        Do Until found Or lengthword = -1

            For Each item In listdico(lengthword)
                If IsCanceledA() Then
                    Return listsolution
                End If

                itemletters = item.ToCharArray
                Array.Sort(itemletters)
                For Each comb In listcombinaisons(lengthword)
                    If itemletters = comb Then
                        listsolution.Add(item)
                    End If
                Next
            Next

            If listsolution.Count > 0 Then
                found = True
            Else
                lengthword -= 1
            End If

        Loop

        Return listsolution.Distinct.ToList



    End Function

    Public Function GetSolution(ByVal isCancellationPending As Func(Of Boolean), ByVal isflagchrono As Func(Of Boolean), ByVal gettime As Func(Of Integer), ByVal limittime As Func(Of Integer)) As List(Of String)

        Dim found As Boolean

        Dim lengthword As Integer
        Dim listsolution As New List(Of String)
        Dim itemletters() As Char
        Dim listcombinaisons As New List(Of List(Of String))
        found = False
        IsCanceledA = isCancellationPending
        lengthword = word.Length - 2
        listcombinaisons = combinaison()
        If listcombinaisons.Count = 0 Then
            Return listsolution
        End If
        found = False
        IsCanceledA = isCancellationPending
        lengthword = word.Length - 2
        listcombinaisons = combinaison()

        Do Until found Or lengthword = -1
            For Each item In listdico(lengthword)
                If IsCanceledA() Then
                    Return listsolution
                End If
                itemletters = item.ToCharArray
                Array.Sort(itemletters)
                For Each comb In listcombinaisons(lengthword)
                    If itemletters = comb Then
                        listsolution.Add(item)
                    End If
                Next
            Next

            If listsolution.Count > 0 Then
                found = True
            Else
                lengthword -= 1
            End If
            If isflagchrono() Then
                If gettime() > limittime() Then
                    Exit Do
                End If
            End If
        Loop

        Return listsolution.Distinct.ToList

    End Function

    

    Private Function combinaison() As List(Of List(Of String))
        'construit une liste de combinaison de string de 2 à 10 lettres
        'combinaison de 2 3 4 5 6 7 8 9 10 lettres à partir des 10 lettres du tirage
        ' si j'ai un chaine de 10 lettres j'ai donc 2^10 -1 combinaisons
        ' mot 1 lettre = 10!/(10-1)! * 1! = 10
        ' 2 lettres = 10!/((10-2)! * 2!) = 45
        ' 3 lettres = 10!/((10-3)! * 3!) = 120
        ' 4 lettres = 10!/((10-4)! * 4!) = 210
        ' 5 lettres = 10!/((10-5)! * 5!) = 252
        ' 6 lettres = 10!/((10-6)! * 7!) = 210
        ' 7 lettres = 10!/((10-7)! * 7!) = 120
        ' 8 lettres = 10!/((10-8)! * 8!) = 45
        ' 9 lettres = 10!/((10-9)! * 9!) = 10
        ' 10 lettres = 10!/((10-10)! * 10!) = 1
        ' total = 1023 = 2^10 -2
        ' pour obtenir toutes les combinaisons on se sert d'une boucle qui iter varie de 1 à 2^10 -2 
        ' iter est converti en binaire et devancé par des 0 de façon à obtenir toujours 9 chiffres 
        ' on remplace les 1 du nombre binaire par le caractère du meme index de la chaine
        ' on retire les 0 de la chaine 
        Dim strbinary As String
        Dim vowelscount As Integer
        Dim binarydigit As Char()
        Dim itemletters() As Char
        Dim grouplistletter As New List(Of List(Of String))
        Dim list2letters As New List(Of String)
        Dim countletters As Integer = 2
        Dim pattern As String = "A|E|I|O|U|Y"
        Dim regex = New Regex(pattern)
        For iter = 1 To 2 ^ (word.Length) - 1

            strbinary = Convert.ToString(Convert.ToInt32(iter), 2)
            strbinary = strbinary.PadLeft(word.Length, "0"c)
            binarydigit = strbinary.ToCharArray

            For iter2 = 0 To binarydigit.Length - 1
                If binarydigit(iter2) = "1" Then
                    binarydigit(iter2) = word(iter2)
                End If
            Next
            strbinary = binarydigit
            strbinary = strbinary.Replace("0", String.Empty)
            vowelscount = regex.Matches(strbinary).Count
            If Not ((vowelscount = 0) Or strbinary.Length = 1) Then
                itemletters = strbinary.ToCharArray()
                Array.Sort(itemletters)
                Select Case itemletters.Length

                    Case 2 : If grouplistletter.Count > 0 Then
                            If Not grouplistletter(0).Contains(itemletters) Then
                                grouplistletter(0).Add(itemletters)
                            End If

                        Else
                            grouplistletter.Add(New List(Of String))
                            grouplistletter(0).Add(itemletters)
                        End If
                    Case 3 : If grouplistletter.Count > 1 Then
                            If Not grouplistletter(1).Contains(itemletters) Then
                                grouplistletter(1).Add(itemletters)
                            End If
                        Else
                            grouplistletter.Add(New List(Of String))
                            grouplistletter(1).Add(itemletters)
                        End If
                    Case 4 : If grouplistletter.Count > 2 Then
                            If Not grouplistletter(2).Contains(itemletters) Then
                                grouplistletter(2).Add(itemletters)
                            End If
                        Else
                            grouplistletter.Add(New List(Of String))
                            grouplistletter(2).Add(itemletters)
                        End If
                    Case 5 : If grouplistletter.Count > 3 Then
                            If Not grouplistletter(3).Contains(itemletters) Then
                                grouplistletter(3).Add(itemletters)
                            End If
                        Else
                            grouplistletter.Add(New List(Of String))
                            grouplistletter(3).Add(itemletters)
                        End If
                    Case 6 : If grouplistletter.Count > 4 Then
                            If Not grouplistletter(4).Contains(itemletters) Then
                                grouplistletter(4).Add(itemletters)
                            End If
                        Else
                            grouplistletter.Add(New List(Of String))
                            grouplistletter(4).Add(itemletters)
                        End If
                    Case 7 : If grouplistletter.Count > 5 Then
                            If Not grouplistletter(5).Contains(itemletters) Then
                                grouplistletter(5).Add(itemletters)
                            End If
                        Else
                            grouplistletter.Add(New List(Of String))
                            grouplistletter(5).Add(itemletters)
                        End If
                    Case 8 : If grouplistletter.Count > 6 Then
                            If Not grouplistletter(6).Contains(itemletters) Then
                                grouplistletter(6).Add(itemletters)
                            End If
                        Else
                            grouplistletter.Add(New List(Of String))
                            grouplistletter(6).Add(itemletters)
                        End If
                    Case 9 : If grouplistletter.Count > 7 Then
                            If Not grouplistletter(7).Contains(itemletters) Then
                                grouplistletter(7).Add(itemletters)
                            End If
                        Else
                            grouplistletter.Add(New List(Of String))
                            grouplistletter(7).Add(itemletters)
                        End If
                    Case 10 : If grouplistletter.Count > 8 Then
                            If Not grouplistletter(8).Contains(itemletters) Then
                                grouplistletter(8).Add(itemletters)
                            End If
                        Else
                            grouplistletter.Add(New List(Of String))
                            grouplistletter(8).Add(itemletters)
                        End If
                End Select
            End If
        Next
        Return grouplistletter
    End Function

    
    
   
    Public Function Checksolution(ByVal wordplayer As String) As Boolean
        If wordplayer.Length - 2 < 0 Then
            Return False
        End If
        If listdico(wordplayer.Length - 2).BinarySearch(wordplayer) >= 0 Then
            Return True
        Else
            Return False
        End If
    End Function


    Public Sub New(ByVal Nombrelettre As Integer, ByVal mot As String)
        ReadList(Nombrelettre - 2)
        word = mot

    End Sub
End Class
