Public Class ShiftOSDesktop

    Public globaltransparencykey As Color = Color.FromArgb(1, 0, 1)
    Public unitymode As Boolean = False

#Region "Code"

    
    Private Sub ShiftOSDesktop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolStripManager.Renderer = New MyToolStripRenderer()
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        Skins.setupdefaults()
        Skins.loadimages()
        desktopicons.AllowDrop = True
        desktopicons.AutoArrange = False
        setupdesktop()
    End Sub

    

    Private Sub shortdisposecode(ByVal skinloadervarible As Array, ByVal shiftosdesktopvarible As Array, ByVal shiftervarible As Array, ByVal includedesktop As Boolean)
        If includedesktop = True Then
            If shiftosdesktopvarible(0) Is Nothing Then  Else shiftosdesktopvarible(0).Dispose()
            If shiftosdesktopvarible(1) Is Nothing Then  Else shiftosdesktopvarible(1).Dispose()
            If shiftosdesktopvarible(2) Is Nothing Then  Else shiftosdesktopvarible(2).Dispose()
            shiftosdesktopvarible(0) = Nothing
            shiftosdesktopvarible(1) = Nothing
            shiftosdesktopvarible(2) = Nothing
        End If
        If Shifter.Visible Then
            If shiftervarible(0) Is Nothing Then  Else shiftervarible(0).Dispose()
            If shiftervarible(1) Is Nothing Then  Else shiftervarible(1).Dispose()
            If shiftervarible(2) Is Nothing Then  Else shiftervarible(2).Dispose()
            shiftervarible(0) = Nothing
            shiftervarible(1) = Nothing
            shiftervarible(2) = Nothing
        End If
        If Skin_Loader.Visible Then
            If skinloadervarible(0) Is Nothing Then  Else skinloadervarible(0).Dispose()
            If skinloadervarible(1) Is Nothing Then  Else skinloadervarible(1).Dispose()
            If skinloadervarible(2) Is Nothing Then  Else skinloadervarible(2).Dispose()
            skinloadervarible(0) = Nothing
            skinloadervarible(1) = Nothing
            skinloadervarible(2) = Nothing
        End If
    End Sub





    Public Sub setpanelbuttonappearance()
        For Each pbtn As PanelButton In pnlpanelbuttonholder.Controls
            If Skins.panelbutton Is Nothing Then
                pbtn.BackColor = Skins.panelbuttoncolour
            Else
                pbtn.BackgroundImage = Skins.panelbutton
                pbtn.BackgroundImageLayout = Skins.panelbuttonlayout
            End If
            pbtn.ForeColor = Skins.panelbuttontextcolour
            pbtn.Font = New Font(Skins.panelbuttontextfont, Skins.panelbuttontextsize, Skins.panelbuttontextstyle)
            pbtn.lbappname.Location = New Point(Skins.panelbuttontextside, Skins.panelbuttontexttop)
            pbtn.pbicon.Location = New Point(Skins.panelbuttoniconside, Skins.panelbuttonicontop)
        Next
    End Sub

    Private Sub ShiftOSDesktop_keydown(sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.T AndAlso e.Control Then
            Dim term As New ShiftDE.Terminal
            term.TopMost = True
            term.Show()
        End If
    End Sub

    Public Sub closeeverything()

        If boughtmultitasking = False Then
            For Each f In My.Application.OpenForms.Cast(Of Form)().ToArray()
                Select Case f.Name
                    Case "ShiftOSDesktop", "HijackScreen", "ShiftOS Save File Converter"
                        'do nothing
                    Case Else
                        f.Close()
                End Select
            Next

        End If
    End Sub

    Public Sub shutdownshiftos()
        closeeverything()
        savegame()
    End Sub

    Public Sub setupdesktop()
        Select Case Skins.desktoppanelposition
            Case "Top"
                desktoppanel.Dock = DockStyle.Top
            Case "Bottom"
                desktoppanel.Dock = DockStyle.Bottom
        End Select
        desktoppanel.Height = Skins.desktoppanelheight
        If Skins.desktoppanel Is Nothing Then
            desktoppanel.BackColor = Skins.desktoppanelcolour
        Else
            desktoppanel.BackgroundImage = Skins.desktoppanel
            desktoppanel.BackgroundImageLayout = Skins.desktoppanellayout
        End If
    End Sub
    
    
    


    


    Private Sub ApplicationsToolStripMenuItem_MouseEnter(sender As Object, e As EventArgs) Handles ApplicationsToolStripMenuItem.MouseEnter
        Me.Focus()
        ToolStripManager.Renderer = New MyToolStripRenderer()
    End Sub

    Private Sub ShutdownToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Terminal.Show()
        Terminal.BringToFront()
        shutdownshiftos()
    End Sub

    Private Sub clocktick_Tick(sender As Object, e As EventArgs) Handles clocktick.Tick
        setclocktime()
    End Sub

    Private Sub setclocktime()
        If boughtsplitsecondtime = True Then
            paneltimetext.Text = TimeOfDay
        Else
            If boughtminuteaccuracytime = True Then
                If Date.Now.Hour < 12 Then
                    paneltimetext.Text = TimeOfDay.Hour & ":" & Format(TimeOfDay.Minute, "00") & " AM"
                Else
                    paneltimetext.Text = TimeOfDay.Hour - 12 & ":" & Format(TimeOfDay.Minute, "00") & " PM"
                End If
            Else
                If boughtpmandam = True Then
                    If Date.Now.Hour < 12 Then
                        paneltimetext.Text = TimeOfDay.Hour & " AM"
                    Else
                        paneltimetext.Text = TimeOfDay.Hour - 12 & " PM"
                    End If
                Else
                    If boughthourspastmidnight = True Then
                        paneltimetext.Text = Math.Floor(Date.Now.Subtract(Date.Today).TotalSeconds / 60 / 60)
                    Else
                        If boughtminutespastmidnight = True Then
                            paneltimetext.Text = Math.Floor(Date.Now.Subtract(Date.Today).TotalSeconds / 60)
                        Else
                            If boughtsecondspastmidnight = True Then
                                paneltimetext.Text = Math.Floor(Date.Now.Subtract(Date.Today).TotalSeconds)
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    
    
    Private Sub autosave_Tick(sender As Object, e As EventArgs) Handles autosave.Tick
        savegame()
    End Sub

    Public Sub ApplicationsToolStripMenuItem_Paint(sender As Object, e As PaintEventArgs) Handles ApplicationsToolStripMenuItem.Paint
        If Skins.applauncher Is Nothing Then
        Else
            e.Graphics.DrawImage(Skins.applauncher, 0, 0, Skins.applauncher.Width, Skins.applauncher.Height)
        End If
    End Sub


#End Region
#Region "Auto-Generated Code"
    'Don't use the toolkit
#End Region


    
    Public Sub refreshIcons()
        desktopicons.Items.Clear()
        desktopicons.ForeColor = Skins.icontextcolor
        desktopicons.View = iconview1
        If Skins.showicons = True Then
            desktopicons.LargeImageList = ShiftDE.SDE_File_Skimmer.ImageList1
            desktopicons.SmallImageList = ShiftDE.SDE_File_Skimmer.ImageList1

            Dim dir As New IO.DirectoryInfo(desktop)
            Dim files As IO.FileInfo() = dir.GetFiles()
            Dim file As IO.FileInfo
            Dim folders As IO.DirectoryInfo() = dir.GetDirectories()
            Dim folder As IO.DirectoryInfo
            Dim filetype As Integer
            For Each folder In folders
                Dim Str(3) As String

                Str(0) = folder.Name
                Str(1) = folder.LastAccessTime
                Str(2) = "Directory"

                Dim folderIcon As New ListViewItem
                folderIcon.Text = Str(0)
                folderIcon.Tag = folder.FullName
                folderIcon.SubItems.Add(Str(1))
                folderIcon.SubItems.Add(Str(2))
                folderIcon.ImageIndex = 0

                desktopicons.Items.Add(folderIcon)
            Next

            For Each file In files
                Dim filename As String = file.Name
                Dim fileex As String = file.Extension
                Dim program As String
                Dim item As New ListViewItem

                item.Text = filename
                item.Tag = file.FullName
                item.SubItems.Add(file.LastWriteTime)

                filetype = GetFileType(fileex)
                program = GetFileType(fileex)

                item.SubItems.Add(program)
                item.ImageIndex = filetype
                desktopicons.Items.Add(item)
            Next
        End If
    End Sub

    Private Sub ClickDesktopIcon(sender As Object, e As EventArgs) Handles desktopicons.DoubleClick
        If desktopicons.SelectedItems.Count > 0 Then
            Dim Path As String = desktopicons.SelectedItems(0).Tag
            openfile(Path)
        End If
    End Sub

    Private Sub IconViewToolStripMenuItem_Click(sender As Object, e As EventArgs)
        desktopicons.View = View.LargeIcon
        refreshIcons()
    End Sub

    Private Sub TileViewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TileViewToolStripMenuItem.Click
        desktopicons.View = View.SmallIcon
        desktopicons.SmallImageList = ShiftDE.SDE_File_Skimmer.ImageList1
        refreshIcons()
    End Sub

    Public Sub makefolder()
        My.Computer.FileSystem.CreateDirectory(desktop & infobox.txtuserinput.Text)
        refreshIcons()
        infobox.Close()
    End Sub

    Private Sub FolderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FolderToolStripMenuItem.Click
        infobox.title = "Create New Folder"
        infobox.textinfo = "What shall the name of your folder be?"
        infobox.txtuserinput.Visible = True
        infobox.state = "makingdesktopfolder"
        infobox.Show()
    End Sub

    Private Sub contextmenu_Show(sender As Object, e As PaintEventArgs) Handles ContextMenuStrip1.Paint
        If desktopicons.SelectedItems.Count > 0 Then
            TileViewToolStripMenuItem.Visible = True
            fileActionsSeparator.Visible = True
        Else
            TileViewToolStripMenuItem.Visible = False
            fileActionsSeparator.Visible = False
        End If

    End Sub

    Private Sub NewSkin_Click(sender As Object, e As EventArgs) Handles NewSkin.Click
        infobox.title = "Skin Loader"
        infobox.textinfo = "What should the name of your skin be?"
        infobox.state = "generatingskin"
        infobox.txtuserinput.Visible = True
        infobox.Show()
    End Sub

    Private Sub SystemInformationReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SystemInformationReportToolStripMenuItem.Click
        infobox.title = "System Information Dump"
        infobox.textinfo = "Please enter the name of the dump file."
        infobox.state = "generatingdump"
        infobox.txtuserinput.Visible = True
        infobox.Show()
    End Sub

    Private Sub TextDocumentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TextDocumentToolStripMenuItem.Click
        infobox.title = "New Text Document"
        infobox.textinfo = "What should the name of your text file be?"
        infobox.state = "newtextdocondesktop"
        infobox.txtuserinput.Visible = True
        infobox.Show()
    End Sub

    Public Sub generateShortCut(Name As String, relayPath As String)
        Dim sw As New IO.StreamWriter(desktop & Name & ".sct")
        sw.Write(relayPath)
        sw.Close()
    End Sub



    Private Sub desktopicons_ItemDrag(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemDragEventArgs) Handles desktopicons.ItemDrag
        If Skins.enabledraggableicons = True Then
            Dim lvi As ListViewItem = CType(e.Item, ListViewItem)
            desktopicons.DoDragDrop(New DataObject("System.Windows.Forms.ListViewItem", lvi), DragDropEffects.Move)
        End If
    End Sub
    Private Sub desktopicons_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles desktopicons.DragEnter
        If Skins.enabledraggableicons = True Then
            If e.Data.GetDataPresent("System.Windows.Forms.ListViewItem") Then
                e.Effect = DragDropEffects.Move
            End If
        End If
    End Sub
    Private Sub desktopicons_DragOver(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles desktopicons.DragOver
        If Skins.enabledraggableicons = True Then
            Dim lvi As ListViewItem = CType(e.Data.GetData("System.Windows.Forms.ListViewItem"), ListViewItem)
            Dim Offset As Size = Size.Subtract(Cursor.Size, New Size(Cursor.HotSpot.X, Cursor.HotSpot.Y))
            If (e.X < 53) Then
                lvi.Position = Point.Subtract(desktopicons.PointToClient(New Point(53, e.Y)), Offset)
            Else
                lvi.Position = Point.Subtract(desktopicons.PointToClient(New Point(e.X, e.Y)), Offset)
            End If
            e.Effect = DragDropEffects.Move
        End If

    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        If My.Computer.FileSystem.DirectoryExists(desktopicons.SelectedItems(0).Tag) Then
            My.Computer.FileSystem.DeleteDirectory(desktopicons.SelectedItems(0).Tag, FileIO.DeleteDirectoryOption.DeleteAllContents)
        Else
            My.Computer.FileSystem.DeleteFile(desktopicons.SelectedItems(0).Tag)
        End If
        refreshIcons()
    End Sub





    
    Private Sub MathQuizToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MathQuizToolStripMenuItem.Click
        Dim pb As New PanelButton
        pb.appname = "Terminal"
        Dim term As New ShiftDE.Terminal
        term.TopMost = True
        term.Show()
        pb.formToControl = term
        pnlpanelbuttonholder.Controls.Add(pb)
        Interpret("mathquiz")
    End Sub

    Public Sub hidestart()
        pnladvapplauncher.Hide()
    End Sub

    Private Sub ApplicationsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ApplicationsToolStripMenuItem.Click
        If Not pnladvapplauncher.Visible = True Then
            pnladvapplauncher.Show()
        Else
            hidestart()
        End If
    End Sub
End Class