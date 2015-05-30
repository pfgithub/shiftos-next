Module filesystem
    'This module represents the folder structure of the ShiftFS Filesystem.

    Public root As String = "C:\ShiftOS"

    Public home As String = root + "\Home\" 'Inconsistent to fix terminal glitch.

    Public desktop As String = home + "Desktop\"
    Public documents As String = home + "Documents\"
    Public pictures As String = home + "Pictures\"
    Public music As String = home + "Music\"

    Public systemdir As String = root + "\Shiftum42\"

    Public drivers As String = systemdir + "Drivers\"
    Public skindir As String = systemdir + "Skins\"

    Public bwmskin As String = skindir + "BWM\"
    Public sde_skindir As String = skindir + "Shifter's_Desktop"

    Public save As String = drivers + "HDD.dri"

    'Useful File Skimmer stuff

    Public Function GetFileType(ext As String)
        Dim FileType As String
        Select Case ext
            Case ".txt"
                FileType = "Text File"
            Case ".pkg"
                FileType = "Application"
            Case ".deb"
                FileType = "Application Installer"
            Case ".sft"
                FileType = "Data File"
            Case ".dri"
                FileType = "Driver"
            Case ".bsk"
                FileType = "Basic WM Skin"
            Case Else
                FileType = "Unknown File"
        End Select
        Return FileType
    End Function

End Module
