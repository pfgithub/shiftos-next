Module shiftorium_api
    'API for Shiftorium Applications.

    Public codepoints As Integer

    Public Sub DeductCP(ammount As Integer)
        codepoints -= ammount
        savegame()
    End Sub

    Public Sub AddCP(ammount As Integer)
        codepoints += ammount
        savegame()
    End Sub
End Module
