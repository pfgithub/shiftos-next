Module Skins
    '<summary>
    '   This module allows for skinning. Simply that.
    '</summary>

#Region "Basic Window Manager"
    Public titlebarcolor As Color = Color.Gray
    Public titlebartextcolor As Color = Color.White
    Public desktopbackcolor As Color = Color.Black
    Public newterminalbuttonbackcolor As Color = Color.Black
    Public newterminalbuttontextcolor As Color = Color.White

    'Load Skin from Save File

    Public Sub loadskindata()
        Try
            Dim loadlines() As String = IO.File.ReadAllLines(bwmskin + "data.bsk")
            titlebarcolor = Color.FromArgb(loadlines(0))
            titlebartextcolor = Color.FromArgb(loadlines(1))
            desktopbackcolor = Color.FromArgb(loadlines(2))
            newterminalbuttonbackcolor = Color.FromArgb(loadlines(3))
            newterminalbuttontextcolor = Color.FromArgb(loadlines(4))
            BasicWM.Desktop.Redraw()
        Catch ex As Exception
            saveskindata()
            loadskindata()
        End Try


    End Sub

    'Save to save data

    Public Sub saveskindata()
        Dim savelines(200) As String
        savelines(0) = titlebarcolor.ToArgb
        savelines(1) = titlebartextcolor.ToArgb
        savelines(2) = desktopbackcolor.ToArgb
        savelines(3) = newterminalbuttonbackcolor.ToArgb
        savelines(4) = newterminalbuttontextcolor.ToArgb
        Try
            IO.File.WriteAllLines(bwmskin + "data.bsk", savelines)
        Catch ex As Exception
            IO.Directory.CreateDirectory(bwmskin)
            IO.File.WriteAllLines(bwmskin + "data.bsk", savelines)
        End Try
        BasicWM.Desktop.Redraw()
    End Sub

#End Region


End Module
