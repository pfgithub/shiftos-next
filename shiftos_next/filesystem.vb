Module filesystem
    'This module represents the folder structure of the ShiftFS Filesystem.

    Public root As String = "C:\ShiftOS"

    Public home As String = root + "\Home\" 'Inconsistent to fix terminal glitch.

    Public documents As String = home + "Documents\"
    Public pictures As String = home + "Pictures\"
    Public music As String = home + "Music\"

    Public systemdir As String = root + "\Shiftum42\"

    Public drivers As String = systemdir + "Drivers\"

    Public save As String = drivers + "HDD.dri"


End Module
