Module shiftorium_api
    'API for Shiftorium Applications.

    Public listboxtoaddto As ListBox
    Public codepoints As Integer

    Public Sub DeductCP(ammount As Integer)
        codepoints -= ammount
        savegame()
    End Sub

    Public Sub AddCP(ammount As Integer)
        codepoints += ammount
        savegame()
    End Sub

    Public Sub AddItem(name As String, CP As Integer)
        listboxtoaddto.Items.Add(name & " - " & CP & " CP")
    End Sub

End Module
