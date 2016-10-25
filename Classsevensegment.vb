Public Class Classsevensegment
    'la class dessine un chiffre formé de segment 
    'chaque segment est représenté par un polygone de couleur noir si allumé ou de la meme couleur de fond si éteint
    Private digitlength As Integer
    
    Private brushseg As System.Drawing.Brush
    Private brushcolorbox As System.Drawing.Brush
    Private listbooleansegment As New List(Of Boolean)
    'listbooleansegment est une list de boolean qui indique si le segment est allumé ou éteint 

    Private Sub segment(ByVal GR As System.Drawing.Graphics, ByVal booleanvector As List(Of Boolean))
        'dessine le chiffre 

        Dim x1, y1 As Integer
        Dim vertex(5) As Point

        'vertical top left le segment vertical en haut à gauche
        vertex(0).X = 2
        vertex(0).Y = 2

        vertex(1).X = vertex(0).X
        vertex(1).Y = vertex(0).Y + digitlength
        vertex(2).X = vertex(1).X + 3
        vertex(2).Y = vertex(1).Y + 3
        vertex(3).X = vertex(2).X + 3
        vertex(3).Y = vertex(1).Y
        vertex(4).X = vertex(3).X
        vertex(4).Y = vertex(0).Y + 6
        vertex(5) = vertex(0)

        If booleanvector(3) = True Then
            GR.FillPolygon(brushseg, vertex)
        Else
            GR.FillPolygon(brushcolorbox, vertex)
        End If
        'midle horizontal segment
        Array.Resize(vertex, 7)
        vertex(0).X = vertex(3).X + 1
        vertex(0).Y = vertex(3).Y
        vertex(1).X = vertex(0).X + digitlength - 12
        vertex(1).Y = vertex(0).Y
        vertex(2).X = vertex(1).X + 3
        vertex(2).Y = vertex(1).Y + 3
        vertex(3).X = vertex(2).X - 3
        vertex(3).Y = vertex(2).Y + 3
        vertex(4).X = vertex(0).X
        vertex(4).Y = vertex(3).Y
        vertex(5).X = vertex(4).X - 3
        vertex(5).Y = vertex(4).Y - 3
        vertex(6) = vertex(0)
        If booleanvector(1) = True Then
            GR.FillPolygon(brushseg, vertex)
        Else
            GR.FillPolygon(brushcolorbox, vertex)
        End If

        'vertical bottom left le segment vertical en bas à gauche
        Array.Resize(vertex, 6)
        vertex(0).X = vertex(5).X - 1
        vertex(0).Y = vertex(5).Y
        vertex(1).X = vertex(0).X + 3
        vertex(1).Y = vertex(0).Y + 3
        vertex(2).X = vertex(1).X
        vertex(2).Y = vertex(1).Y + digitlength - 6
        vertex(3).X = vertex(2).X - 6
        vertex(3).Y = vertex(2).Y + 6
        vertex(4).X = vertex(3).X
        vertex(4).Y = vertex(1).Y
        vertex(5) = vertex(0)
        If booleanvector(5) = True Then
            GR.FillPolygon(brushseg, vertex)
        Else
            GR.FillPolygon(brushcolorbox, vertex)
        End If

        'horizontal bottom horizontal en bas
        Array.Resize(vertex, 5)
        vertex(0).X = vertex(2).X + 1
        vertex(0).Y = vertex(2).Y
        vertex(1).X = vertex(0).X + digitlength - 12
        vertex(1).Y = vertex(0).Y
        vertex(2).X = vertex(1).X + 6
        vertex(2).Y = vertex(1).Y + 6
        vertex(3).X = vertex(0).X - 6
        vertex(3).Y = vertex(2).Y
        vertex(4) = vertex(0)
        x1 = vertex(1).X
        y1 = vertex(1).Y
        
        If booleanvector(2) = True Then
            GR.FillPolygon(brushseg, vertex)
        Else
            GR.FillPolygon(brushcolorbox, vertex)
        End If

        'horizontal top horizontal en haut

        vertex(0).X = 3
        vertex(0).Y = 2
        vertex(1).X = vertex(0).X + digitlength
        vertex(1).Y = vertex(0).Y
        vertex(2).X = vertex(1).X - 6
        vertex(2).Y = vertex(1).Y + 6
        vertex(3).X = vertex(0).X + 6
        vertex(3).Y = vertex(2).Y
        vertex(4) = vertex(0)
        If booleanvector(0) = True Then
            GR.FillPolygon(brushseg, vertex)
        Else
            GR.FillPolygon(brushcolorbox, vertex)
        End If

        'right up vertical vertical en haut à droite
        Array.Resize(vertex, 6)
        vertex(0).X = vertex(1).X + 1
        vertex(0).Y = 2
        vertex(1).X = vertex(0).X
        vertex(1).Y = vertex(0).Y + digitlength
        vertex(2).X = vertex(1).X - 3
        vertex(2).Y = vertex(1).Y + 3
        vertex(3).X = vertex(2).X - 3
        vertex(3).Y = vertex(1).Y
        vertex(4).X = vertex(0).X - 6
        vertex(4).Y = vertex(0).Y + 6
        vertex(5) = vertex(0)
        If booleanvector(4) = True Then
            GR.FillPolygon(brushseg, vertex)
        Else
            GR.FillPolygon(brushcolorbox, vertex)
        End If

        'right bottom vertical vertical en bas à droite

        vertex(0).X = x1 + 1
        vertex(0).Y = y1
        vertex(1).X = vertex(0).X + 6
        vertex(1).Y = vertex(0).Y + 6
        vertex(2).X = vertex(1).X
        vertex(2).Y = vertex(1).Y - digitlength
        vertex(3).X = vertex(2).X - 3
        vertex(3).Y = vertex(2).Y - 3
        vertex(4).X = vertex(0).X
        vertex(4).Y = vertex(2).Y
        vertex(5) = vertex(0)
        If booleanvector(6) = True Then
            GR.FillPolygon(brushseg, vertex)
        Else
            GR.FillPolygon(brushcolorbox, vertex)
        End If








    End Sub

    Public Sub New(ByVal segemtlength As Integer, ByVal brushsegment As System.Drawing.Brush, ByVal brushbox As System.Drawing.Brush)
        digitlength = segemtlength
        brushseg = brushsegment
        brushcolorbox = brushbox
    End Sub
    Private Function UpdateBooleanVector(ByVal digit As Integer) As List(Of Boolean)
        ' met à jour  listbooleansegment selon le chiffre à afficher
        ' segment horizontal du haut index 0
        ' segment horizontal du milieu index 1
        ' segment horizontal du bas index 2
        ' segment vertical du haut à gauche index 3
        ' segment vertical du haut à droite index 4
        ' segment vertical du bas à gauche index 5
        ' segment vertical du bas à droite  index 6

        Dim sevensegbool As New List(Of Boolean)

        Select Case digit

            Case 0
                For iter = 0 To 6
                    If iter <> 1 Then
                        sevensegbool.Add(True)
                    Else
                        sevensegbool.Add(False)
                    End If

                Next

            Case 1
                For iter = 0 To 6
                    If iter <> 4 And iter <> 6 Then
                        sevensegbool.Add(False)
                    Else
                        sevensegbool.Add(True)
                    End If

                Next

            Case 2
                For iter = 0 To 6
                    If iter = 3 Or iter = 6 Then
                        sevensegbool.Add(False)
                    Else
                        sevensegbool.Add(True)
                    End If

                Next
            Case 3
                For iter = 0 To 6
                    If iter = 3 Or iter = 5 Then
                        sevensegbool.Add(False)
                    Else
                        sevensegbool.Add(True)
                    End If

                Next
            Case 4
                For iter = 0 To 6
                    If iter = 0 Or iter = 2 Or iter = 5 Then
                        sevensegbool.Add(False)
                    Else
                        sevensegbool.Add(True)
                    End If

                Next
            Case 5
                For iter = 0 To 6
                    If iter = 4 Or iter = 5 Then
                        sevensegbool.Add(False)
                    Else
                        sevensegbool.Add(True)
                    End If

                Next
            Case 6
                For iter = 0 To 6
                    If iter = 4 Then
                        sevensegbool.Add(False)
                    Else
                        sevensegbool.Add(True)
                    End If

                Next
            Case 7
                For iter = 0 To 6
                    If iter <> 4 And iter <> 6 And iter <> 0 Then
                        sevensegbool.Add(False)
                    Else
                        sevensegbool.Add(True)
                    End If

                Next
            Case 8
                For iter = 0 To 6
                    sevensegbool.Add(True)
                Next

            Case 9
                For iter = 0 To 6
                    If iter = 5 Then
                        sevensegbool.Add(False)
                    Else
                        sevensegbool.Add(True)
                    End If

                Next
        End Select

        Return sevensegbool
    End Function
    Public Sub DrawDigit(ByVal gr As System.Drawing.Graphics, ByVal digit As Integer)
        listbooleansegment = UpdateBooleanVector(digit)
        segment(gr, listbooleansegment)
    End Sub
    Public Sub DrawDrawColon(ByVal gr As System.Drawing.Graphics)
        Dim rect As New Rectangle
        rect.Location = New Point(digitlength \ 2, Convert.ToInt32(digitlength / 2))
        rect.Width = 6
        rect.Height = 6
        gr.FillRectangle(brushseg, rect)
        rect.Location = New Point(digitlength \ 2, Convert.ToInt32(3 * digitlength / 2))
        gr.FillRectangle(brushseg, rect)
    End Sub
    Public Function GetHeightBox() As Integer
        Return digitlength * 2 + 10
    End Function
    Public Function GetwidthBox() As Integer
        Return digitlength + 6
    End Function
End Class
