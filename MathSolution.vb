Public Class MathSolution
    Private Class couple
        Public upperoperand As Int64
        Public loweroperand As Int64
    End Class
    Private Class term
        Public listcouple As New List(Of couple)
        Public remindoperand As New List(Of Int64)
        Public pointercouple As Integer
        Public pointeroperator As Integer
        Public res As Int64
    End Class
    Private strinput As String = String.Empty
    Private listgroup As New List(Of term)
    Private listresult As New List(Of String)
    Private listoperand As New List(Of Int64)
    Private listoperator As New List(Of Char)
    Private listnumbers As New List(Of List(Of Int64))
    Private thenumbers As List(Of Int64)
    Private number As Int64
    Private flagfound As Boolean
    Private IsCanceledA As Func(Of Boolean)
    Private IsFlagchronoA As Func(Of Boolean)
    Private GetTimeA As Func(Of Integer)
    Private LimitTimeA As Func(Of Integer)
    Private Class result
        Public listr As New List(Of String)
        Public res As Int64
    End Class
    Private listresults As New List(Of result)
    Private holdresult As Int64 = 0
    Private listsolutions As New List(Of List(Of String))
    Private Function makelistcoupleoperand(ByVal listoperandk As List(Of Int64)) As List(Of couple)
        'forme toutes les paires de nombres à partir de listoperandk

        Dim thecouples As New List(Of couple)
        For i = 0 To listoperandk.Count - 2
            For j = i + 1 To listoperandk.Count - 1
                Dim cp As New couple
                If listoperandk(i) > listoperandk(j) Then
                    cp.upperoperand = listoperandk(i)
                    cp.loweroperand = listoperandk(j)
                Else
                    cp.upperoperand = listoperandk(j)
                    cp.loweroperand = listoperandk(i)
                End If
                thecouples.Add(cp)
            Next
        Next
        Return thecouples
    End Function
    Private Sub SetFirstTerm()
        'prepare le premier term 
        Dim theterm As New term
        Dim grouppointer As Integer = 0
        Dim res As Int64
        theterm.listcouple = makelistcoupleoperand(thenumbers)
        theterm.pointercouple = 0
        theterm.pointeroperator = 0
        Dim vect(thenumbers.Count - 1) As Int64
        thenumbers.CopyTo(vect)
        theterm.remindoperand = vect.ToList
        res = Calculate(theterm.listcouple(theterm.pointercouple).upperoperand, theterm.listcouple(theterm.pointercouple).loweroperand, listoperator(theterm.pointeroperator))
        theterm.res = res
        listgroup.Add(theterm)
        AddResult(0)

    End Sub



    Private Sub AddResult(ByVal groupindex As Integer)
        'ecrit le resultat sous forme d'expression arithmetique
        Dim equation As String = String.Empty
        equation &= listgroup(groupindex).listcouple(listgroup(groupindex).pointercouple).upperoperand.ToString & " "
        equation &= listoperator(listgroup(groupindex).pointeroperator) & " "
        equation &= listgroup(groupindex).listcouple(listgroup(groupindex).pointercouple).loweroperand.ToString
        equation &= " = " & listgroup(groupindex).res
        listresult.Add(equation)
    End Sub
    Private Function Calculate(ByVal upperoperand As Int64, ByVal loweroperand As Int64, ByVal theoperator As Char) As Int64
        Select Case theoperator
            Case "*"c : Return upperoperand * loweroperand
            Case "+"c : Return upperoperand + loweroperand
            Case "-"c : Return upperoperand - loweroperand
            Case "/"c : If upperoperand Mod loweroperand = 0 Then
                    Return upperoperand \ loweroperand
                Else
                    Return -1
                End If
        End Select
    End Function
    Private Sub buildlistgroup()
        'forme la list initial de term
        SetFirstTerm()
        Dim iter As Integer
        Dim indexgroup As Integer = 0
        Dim element1, element2 As Int64
        Dim list1 As New List(Of Int64)
        Dim res As Int64
        Dim theterm As term

        For iter = 0 To thenumbers.Count - 3
            theterm = New term
            theterm.pointercouple = 0
            theterm.pointeroperator = 0

            Dim vect(listgroup(indexgroup).remindoperand.Count - 1) As Int64
            listgroup(indexgroup).remindoperand.CopyTo(vect)
            element1 = listgroup(indexgroup).listcouple(listgroup(indexgroup).pointercouple).upperoperand
            element2 = listgroup(indexgroup).listcouple(listgroup(indexgroup).pointercouple).loweroperand
            list1 = vect.ToList
            list1.Remove(element1)
            list1.Remove(element2)
            list1.Add(listgroup(indexgroup).res)

            theterm.listcouple = makelistcoupleoperand(list1)
            res = Calculate(theterm.listcouple(theterm.pointercouple).upperoperand, theterm.listcouple(theterm.pointercouple).loweroperand, listoperator(theterm.pointeroperator))
            theterm.res = res
            Array.Resize(vect, list1.Count)
            list1.CopyTo(vect)
            theterm.remindoperand = vect.ToList
            listgroup.Add(theterm)
            indexgroup += 1
            AddResult(indexgroup)

            
            list1.Clear()
        Next
        If listgroup.Count = thenumbers.Count - 1 Then
            If listgroup(listgroup.Count - 1).res = number Then

                If Not flagfound Then
                    listresults.Clear()
                End If
                CopyResult(listgroup(listgroup.Count - 1).res)
                flagfound = True
            ElseIf Not flagfound Then

                If Math.Abs(holdresult - number) >= Math.Abs(listgroup(listgroup.Count - 1).res - number) Then

                    If holdresult <> listgroup(listgroup.Count - 1).res Then
                        listresults.Clear()
                    End If
                    holdresult = listgroup(listgroup.Count - 1).res
                    CopyResult(listgroup(listgroup.Count - 1).res)
                End If
            End If
        End If
    End Sub
    Private Function UpdatetermChangeOperator(ByVal indexgroup As Integer) As Boolean
        Dim equation As String = String.Empty
        Dim res, element1, element2 As Int64

        For iter = listgroup(indexgroup).pointeroperator + 1 To listoperator.Count - 1
            element1 = listgroup(indexgroup).listcouple(listgroup(indexgroup).pointercouple).upperoperand
            element2 = listgroup(indexgroup).listcouple(listgroup(indexgroup).pointercouple).loweroperand
            res = Calculate(element1, element2, listoperator(iter))
            If res > 0 Then
                listgroup(indexgroup).res = res
                equation = String.Empty
                equation &= listgroup(indexgroup).listcouple(listgroup(indexgroup).pointercouple).upperoperand.ToString & " "
                equation &= listoperator(iter) & " "
                equation &= listgroup(indexgroup).listcouple(listgroup(indexgroup).pointercouple).loweroperand.ToString
                equation &= " = " & listgroup(indexgroup).res
                If listresult.Count = 0 Then
                    listresult.Add(equation)
                Else
                    listresult(listresult.Count - 1) = equation
                End If

                If listgroup.Count = thenumbers.Count - 1 Then
                    If listgroup(listgroup.Count - 1).res = number Then

                        If Not flagfound Then
                            listresults.Clear()
                        End If
                        CopyResult(listgroup(listgroup.Count - 1).res)
                        flagfound = True
                    ElseIf Not flagfound Then

                        If Math.Abs(holdresult - number) >= Math.Abs(listgroup(listgroup.Count - 1).res - number) Then
                            If holdresult <> listgroup(listgroup.Count - 1).res Then
                                listresults.Clear()
                            End If
                            holdresult = listgroup(listgroup.Count - 1).res
                            CopyResult(listgroup(listgroup.Count - 1).res)
                        End If
                    End If
                End If
                listgroup(indexgroup).pointeroperator = iter
                Return True
            End If
        Next

        Return False
    End Function

    Private Function UpdatetermChangeCouple(ByVal indexgroup As Integer) As Boolean
        Dim equation As String = String.Empty
        Dim res, element1, element2 As Int64
        listgroup(indexgroup).pointeroperator = 0
        For iter = listgroup(indexgroup).pointercouple + 1 To listgroup(indexgroup).listcouple.Count - 1
            element1 = listgroup(indexgroup).listcouple(iter).upperoperand
            element2 = listgroup(indexgroup).listcouple(iter).loweroperand
            res = Calculate(element1, element2, listoperator(listgroup(indexgroup).pointeroperator))
            If res > 0 Then
                listgroup(indexgroup).res = res
                equation = String.Empty
                equation &= element1 & " "
                equation &= listoperator(listgroup(indexgroup).pointeroperator) & " "
                equation &= element2
                equation &= " = " & listgroup(indexgroup).res
                If listresult.Count = 0 Then
                    listresult.Add(equation)
                Else
                    listresult(listresult.Count - 1) = equation
                End If
                If listgroup.Count = thenumbers.Count - 1 Then
                    If listgroup(listgroup.Count - 1).res = number Then

                        If Not flagfound Then
                            listresults.Clear()
                        End If
                        CopyResult(listgroup(listgroup.Count - 1).res)
                        flagfound = True
                    ElseIf Not flagfound Then

                        If Math.Abs(holdresult - number) >= Math.Abs(listgroup(listgroup.Count - 1).res - number) Then
                            If holdresult <> listgroup(listgroup.Count - 1).res Then
                                listresults.Clear()
                            End If
                            holdresult = listgroup(listgroup.Count - 1).res
                            CopyResult(listgroup(listgroup.Count - 1).res)
                        End If
                    End If
                End If
                listgroup(indexgroup).pointercouple = iter
                Return True
            End If
        Next

        Return False
    End Function


    Private Function Addterm(ByVal indexgroup As Integer) As Boolean
        Dim theterm As term
        Dim element1, element2 As Int64
        Dim list1 As New List(Of Int64)
        Dim index As Integer
        Dim res As Int64

        Dim ok As Boolean = False
        'on modifie le dernier term ou le supprime s'il le faut jusqu'a obtenir un term utilisable
        While Not ok

            If Not UpdatetermChangeOperator(indexgroup) Then

                If Not UpdatetermChangeCouple(indexgroup) Then
                    If listresult.Count > 0 Then
                        listresult.RemoveAt(listresult.Count - 1)
                    End If
                    listgroup.RemoveAt(indexgroup)
                    indexgroup = listgroup.Count - 1

                    If listgroup.Count = 0 Then
                        Return False
                    End If
                Else
                    ok = True
                End If
            Else
                ok = True
            End If
        End While

        'on ajoute les terms 
        index = indexgroup

        For iter = index To thenumbers.Count - 3
            theterm = New term
            theterm.pointercouple = 0
            theterm.pointeroperator = 0
            Dim vect(listgroup(indexgroup).remindoperand.Count - 1) As Int64
            listgroup(indexgroup).remindoperand.CopyTo(vect)
            list1 = vect.ToList
            element1 = listgroup(indexgroup).listcouple(listgroup(indexgroup).pointercouple).upperoperand
            element2 = listgroup(indexgroup).listcouple(listgroup(indexgroup).pointercouple).loweroperand
            list1.Remove(element1)
            list1.Remove(element2)
            '  list1.Reverse()
            list1.Add(listgroup(indexgroup).res)
            theterm.listcouple = makelistcoupleoperand(list1)
            res = Calculate(theterm.listcouple(theterm.pointercouple).upperoperand, theterm.listcouple(theterm.pointercouple).loweroperand, listoperator(theterm.pointeroperator))
            theterm.res = res
            Array.Resize(vect, list1.Count)
            list1.CopyTo(vect)
            theterm.remindoperand = vect.ToList
            listgroup.Add(theterm)
            indexgroup += 1
            AddResult(indexgroup)

            If listgroup.Count = thenumbers.Count - 1 Then
                If listgroup(listgroup.Count - 1).res = number Then

                    If Not flagfound Then
                        listresults.Clear()
                    End If
                    CopyResult(listgroup(listgroup.Count - 1).res)
                    flagfound = True
                ElseIf Not flagfound Then

                    If Math.Abs(holdresult - number) >= Math.Abs(listgroup(listgroup.Count - 1).res - number) Then
                        If holdresult <> listgroup(listgroup.Count - 1).res Then
                            listresults.Clear()
                        End If
                        holdresult = listgroup(listgroup.Count - 1).res
                        CopyResult(listgroup(listgroup.Count - 1).res)
                    End If
                End If
            End If
            list1.Clear()
        Next


        Return True
    End Function
    Private Sub CopyResult(ByVal res As Int64)
        Dim vect(listresult.Count - 1) As String
        listresult.CopyTo(vect)
        Dim theresult As New result
        theresult.listr = vect.ToList
        theresult.res = res
        listresults.Add(theresult)
    End Sub
    Private Function Search(Optional ByVal flagtimer As Boolean = True) As Boolean
        'cherche la solution 
        'après avoir former une liste de term,chaque term  contient les couples formés avec les nombres restants, la liste de nombre
        'restant ,indexcouple indexoperator et resultat de l'opération arithmétique
        'ainsi chaque term est formé selon le term précedent le dernier term contient un seul couple
        'à partir de ce stade
        'tant qu'il y a un term procède:verifie tant qu'on peut ajouter un term ajoute si tous les couples du term et pour chaque
        'couple tous les opérateur ont été utilisés on supprime le term
        Dim found As Boolean = False
        Dim indexgroup As Integer
        Dim finish As Boolean = False
        indexgroup = listgroup.Count - 1

        While Not finish
            If IsCanceledA() Then
                Return False
            End If
            While listgroup(indexgroup).listcouple.Count > 1
                If flagtimer Then
                    If IsFlagchronoA() Then
                        If (GetTimeA() >= LimitTimeA()) Then
                            finish = True
                            Exit While
                        End If
                    End If
                End If
               If Not Addterm(indexgroup) Then
                    finish = True
                    Exit While
                End If
                indexgroup += 1
            End While

            If finish Then
                Exit While
            End If
            If Not UpdatetermChangeOperator(indexgroup) Then
                If listresult.Count > 0 Then
                    listresult.RemoveAt(listresult.Count - 1)
                End If

                listgroup.RemoveAt(indexgroup)
                indexgroup = listgroup.Count - 1
                If listgroup.Count = 0 Then
                    Exit While
                End If
            Else

            End If

        End While
        Return True
    End Function
    Private Function MakeCombinaison(ByVal word As String) As List(Of List(Of Int64))
        'rend toutes les combinaisons des nombres 
        'combinaison de 1 2 3 4 5 6 7 8 ..N lettres 
        ' si j'ai un chaine de N lettres j'ai donc 2^N -1 combinaisons
        ' mot 1 lettre = N!/((N-1)! * 1!) 
        ' 2 lettres = N!/((N-2)! * 2!)
        ' 3 lettres = N!/((N-3)! * 3!)
        ' 4 lettres = N!/((N-4)! * 4!) 
        ' 5 lettres = N!/((N-5)! * 5!) 
        ' 6 lettres = N!/((N-6)! * 7!) 
        ' 7 lettres = N!/((N-7)! * 7!) 
        ' 8 lettres = N!/((N-8)! * 8!)
        ' N lettres = N!/((N-N)! * N!) 

        ' pour obtenir toutes les combinaisons on se sert d'une boucle qui iter varie de 1 à 2^N -1 
        ' iter est converti en binaire et devancé par des 0 de façon à obtenir toujours N chiffres 
        ' on remplace les 1 du nombre binaire par le caractère du meme index de la chaine
        ' on retire les 0 de la chaine 

        Dim strbinary As String
        Dim listnumber As New List(Of List(Of Int64))
        Dim listnum As List(Of Int64)
        Dim binarydigit As Char()
        Dim list1 As New List(Of String)
        For iter = 1 To 2 ^ (word.Length)

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
            If strbinary.Length > 1 Then
                list1.Add(strbinary)
            End If
        Next
        list1 = list1.Distinct.ToList
        For Each item In list1
            listnum = New List(Of Int64)
            For Each c As Char In item
                listnum.Add(listoperand(strinput.IndexOf(c)))
            Next
            listnumber.Add(listnum)
        Next

        Return listnumber
    End Function
    Private Sub MakeInputeString()
        'forme une chaine de lettre selon la liste de nombre pour chaque meme nombre on alloue une meme lettre 
        Dim listoccurence As New List(Of Integer)
        Dim res As Integer

        Dim counter As Char = "A"c
        listoperand.Sort()

        For Each num As Integer In listoperand
            res = listoccurence.BinarySearch(num)
            If res < 0 Then
                listoccurence.Add(num)
                strinput &= counter.ToString
                counter = Convert.ToChar((Convert.ToInt32(counter) + 1))
            Else
                strinput &= Convert.ToChar(Convert.ToInt32("A"c) + res)
            End If
        Next
    End Sub
    
    Private Sub RemoveDuplicate()

        For iter = listresults.Count - 1 To 1 Step -1
            Dim uniqueNamesQuery = listresults(iter).listr.Union(listresults(iter - 1).listr) '.Distinct
            If uniqueNamesQuery.Count = listresults(iter).listr.Count Then
                listresults.RemoveAt(iter)
            End If
        Next

    End Sub
    
    Public Function FindSolution(ByVal isCancellationPending As Func(Of Boolean), ByRef foundnumber As Int64, ByVal isflagchrono As Func(Of Boolean)) As List(Of List(Of String))
        
        IsCanceledA = isCancellationPending
        IsFlagchronoA = isflagchrono
        flagfound = False
        For Each item In listnumbers
            thenumbers = New List(Of Int64)
            thenumbers = item
            buildlistgroup()
            If Not Search(False) Then
                Return listsolutions
            End If
        Next
        RemoveDuplicate()
        For Each item In listresults
            listsolutions.Add(item.listr)
        Next
        foundnumber = Convert.ToInt64(listsolutions(0)(listsolutions(0).Count - 1).Substring(listsolutions(0)(listsolutions(0).Count - 1).IndexOf("=") + 1))
       Return listsolutions

    End Function

    Public Function FindSolution(ByVal isCancellationPending As Func(Of Boolean), ByRef foundnumber As Int64, ByVal isflagchrono As Func(Of Boolean), ByVal gettime As Func(Of Integer), ByVal limittime As Func(Of Integer)) As List(Of List(Of String))
       
        IsCanceledA = isCancellationPending
        IsFlagchronoA = isflagchrono
        GetTimeA = gettime
        limittimeA = limittime
        flagfound = False
        For Each item In listnumbers
            thenumbers = New List(Of Int64)
            thenumbers = item
            buildlistgroup()
            If Not Search() Then
                Return listsolutions
            End If
            If IsFlagchronoA() Then
                If (GetTimeA() >= LimitTimeA()) Then
                    Exit For
                     End If
            End If
        Next
        RemoveDuplicate()
        For Each item In listresults
            listsolutions.Add(item.listr)
        Next
        foundnumber = Convert.ToInt64(listsolutions(0)(listsolutions(0).Count - 1).Substring(listsolutions(0)(listsolutions(0).Count - 1).IndexOf("=") + 1))
        Return listsolutions

    End Function
  

    Public Sub New(ByVal listnumber As List(Of Int64), ByVal thefindnumber As Int64)
        listoperand = listnumber
        number = thefindnumber
        listoperator.Add("*"c)
        listoperator.Add("+"c)
        listoperator.Add("-"c)
        listoperator.Add("/"c)
        MakeInputeString()
        listnumbers = MakeCombinaison(strinput)
    End Sub
End Class
