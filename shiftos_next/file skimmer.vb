Public Class file_skimmer



    Public mode As String
    Public application As String 'The application sending either an open or save mode.
    Public currentdir As String = home

    Public Sub setupmenufonts()
        For Each item In topmenu.Items
            item.ForeColor = Color.White
            item.Font = New Font("Courier New", 8.25)
            For Each SubItem In item.DropDownItems
                SubItem.ForeColor = Color.White
                SubItem.font = New Font("Courier New", 8.25)
            Next
        Next
    End Sub

    Public Sub showfiles()
        Dim lv As ListView = lvfiles
        lv.Items.Clear()
        lv.View = View.Tile
        lv.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
        Dim upone As New ListViewItem
        upone.Text = "Up one"
        lv.Items.Add(upone)
        upone.SubItems.Add("directory")

        For Each dir As String In My.Computer.FileSystem.GetDirectories(currentdir)
            Dim dirinf As New IO.DirectoryInfo(dir)
            Dim lvitem As New ListViewItem
            lvitem.Text = dirinf.Name
            lvitem.Tag = dirinf.FullName
            lv.Items.Add(lvitem)
            lvitem.SubItems.Add("Directory")
            lvitem.SubItems.Add(dirinf.LastAccessTime)

        Next
        For Each file As String In My.Computer.FileSystem.GetFiles(currentdir)
            Dim filinf As New IO.DirectoryInfo(file)
            Dim lvitem As New ListViewItem
            lvitem.Text = filinf.Name
            lvitem.Tag = filinf.FullName
            lv.Items.Add(lvitem)

            lvitem.SubItems.Add(GetFileType(filinf.Extension))
            lvitem.SubItems.Add(filinf.LastAccessTime)
        Next
        lbcurrentdir.Text = currentdir.Replace(root, "~").Replace("\", "/")
    End Sub

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
            Case Else
                FileType = "Unknown File"
        End Select
        Return FileType
    End Function

    Public Sub OpenFile(file As String)
        If IO.Directory.Exists(file) Then
            currentdir = file
            showfiles()
        Else
            Dim filinf As New IO.FileInfo(file)
            Select Case filinf.Extension
                Case Else
                    basicwm_infobox.showinfo("Exodus - File Format not valid", "The format of the file """ & filinf.Name & """ is not a format in which Exodus File Browser can read.")
            End Select
        End If
    End Sub
    Private Sub lvfiles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvfiles.DoubleClick
        Try
            If lvfiles.SelectedItems(0).Text = "Up one" Then
                If Not currentdir = root Then
                    currentdir = IO.Directory.GetParent(currentdir).ToString
                    showfiles()
                End If
            Else
                If mode = "open" Then
                    Select Case Application
                        Case "textpad"
                            Dim sr As New IO.StreamReader(lvfiles.SelectedItems(0).Tag.ToString)
                            TextPad.txtfilebody.Text = sr.ReadToEnd()
                            sr.Close()
                            Me.Close()
                    End Select
                Else
                    OpenFile(lvfiles.SelectedItems(0).Tag)
                End If
            End If
        Catch
        End Try
    End Sub

    Private Sub file_skimmer_Load(sender As Object, e As EventArgs) Handles Me.Load
        topmenu.Renderer = New basicwm_renderer()
        tools.Renderer = New basicwm_renderer()
        setupmenufonts()
        setupui()
        showfiles()
    End Sub

    Public Sub setupui()
        FolderToolStripMenuItem.Visible = boughtfileskimmernewfolder
        newseperator.Visible = boughtfileskimmernewfolder
        btnnewfolder.Visible = boughtfileskimmernewfolder
        btndelete.Visible = boughtfileskimmerdelete
        If mode = "save" Then
            pnlsave.Visible = True
        Else
            pnlsave.Visible = False
        End If
        If boughtbasicwm = True Then
            pnltop.Show()
            Me.WindowState = FormWindowState.Normal
            Me.Left = (Screen.PrimaryScreen.Bounds.Width - Me.Width) / 2
            Me.Top = (Screen.PrimaryScreen.Bounds.Height - Me.Height) / 2
            Me.TopMost = True
        Else
            pnltop.Hide()
            Me.WindowState = FormWindowState.Maximized
            Me.TopMost = False
        End If
    End Sub

    Private Sub ExitSessionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitSessionToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ProductInfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductInfoToolStripMenuItem.Click
        basicwm_infobox.showinfo("File Skimmer - v1.2", "Browse, edit, move, copy and delete the files on your computer.")
    End Sub



    Private Sub FolderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FolderToolStripMenuItem.Click, btnnewfolder.Click
        basicwm_infobox.showinfo("Create New Folder", "Please specify a name for your folder.", True)
        If Not IO.Directory.Exists(currentdir & "\" & basicwm_infobox.userinput) Then
            IO.Directory.CreateDirectory(currentdir & "\" & basicwm_infobox.userinput)
        Else
            basicwm_infobox.showinfo("Create New Folder", "The specified folder already exists!")
        End If
        showfiles()
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Try
            If IO.Directory.Exists(lvfiles.SelectedItems(0).Tag) Then
                IO.Directory.Delete(lvfiles.SelectedItems(0).Tag, True)
            ElseIf IO.File.Exists(lvfiles.SelectedItems(0).Tag) Then
                IO.File.Delete(lvfiles.SelectedItems(0).Tag)
            End If
        Catch ex As Exception
            basicwm_infobox.showinfo("Error!", "The following Visual Basic exception has occurred: " & vbNewLine & vbNewLine & ex.Message)
        End Try
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If Not txtfilename.Text = "" Then
            If IO.Directory.Exists(currentdir + "\" + txtfilename.Text) Then
                basicwm_infobox.showinfo("Invalid File Name", "You can't save a file ontop of a directory with the same name!")
            Else
                Select Case Application
                    Case "textpad"
                        Dim sw As New IO.StreamWriter(currentdir + "\" + txtfilename.Text)
                        sw.Write(TextPad.txtfilebody.Text)
                        sw.Close()
                        Me.Close()
                End Select
            End If
        Else
            basicwm_infobox.showinfo("Invalid File Name", "Please specify a file name, and not leave it blank!")
        End If
    End Sub
End Class