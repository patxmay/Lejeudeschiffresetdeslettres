Module Dirigepartie
    Public flagame As Boolean
    Public couplettre As Integer
    Public limittimechiffre As Integer
    Public limittimelettre As Integer
    Public flagstartchiffre As Boolean
    Public flagstartlettre As Boolean
    Public inside As Boolean = False
    Public totalcoup As Integer
    
    Private Sub initgame()
        flagame = True
        couplettre = 0
        totalcoup = 0
        pcpoints = 0
        playerpoints = 0
        flagstartchiffre = False
        flagstartlettre = False

    End Sub
    Public Sub Rungame()
        initgame()
        Formchiffre.Show()
    End Sub
End Module
