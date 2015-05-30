Public Class fileskimmer_mde
    'Editable Variables
    Public currentfolder As String = home

    Public Sub setuplistview(folder As String)
        Dim lv As ListView = lvitems
        lv.Items.Clear()
        lv.LargeImageList = myfileimages
        lv.SmallImageList = myfileimages
        For Each Directory As String In IO.Directory.GetDirectories(folder)
            Dim lvitem As New ListViewItem
            Dim dirinf As New IO.DirectoryInfo(Directory)
            lvitem.Text = dirinf.Name
            lvitem.Tag = dirinf.FullName
            lvitem.ImageKey = "Folder"
            lv.Items.Add(lvitem)
        Next
        For Each File As String In IO.Directory.GetFiles(folder)
            Dim lvitem As New ListViewItem
            Dim filinf As New IO.FileInfo(File)
            lvitem.Text = filinf.Name
            lvitem.Tag = filinf.FullName
            lvitem.ImageKey = GetFileType(filinf.Extension)
            lv.Items.Add(lvitem)
        Next

        lbcurrentfolder.Text = folder
    End Sub

    Public Sub SetFontColors()
        For Each item In MenuStrip1.Items
            item.ForeColor = Color.White
            If Not item.Text = "--" Then
                For Each SubItem In item.DropDownItems
                    SubItem.ForeColor = Color.White
                    If Not SubItem.Text = "--" Then
                        For Each Destination In SubItem.DropDownItems
                            Destination.ForeColor = Color.White
                        Next
                    End If
                Next
            End If
        Next
        ToolStrip1.Renderer = New memphis.mde_renderer()
        MenuStrip1.Renderer = New memphis.mde_renderer()
        ToolStrip1.ForeColor = Color.White
    End Sub

    Public Sub setuptree()
        Dim tv As TreeView = tvfolders
        Dim tvitem As New TreeNode
        tvitem.Text = "Root (" + root + ")"
        tvitem.Tag = root
        tv.Nodes.Add(tvitem)
        tvitem.Expand()
        For Each directory As String In IO.Directory.GetDirectories(root)
            Dim dirinf As New IO.DirectoryInfo(directory)
            Dim tvitem2 As New TreeNode
            tvitem2.Text = dirinf.Name
            tvitem2.Tag = dirinf.FullName
            tvitem.Nodes.Add(tvitem2)
            For Each subdirectory As String In IO.Directory.GetDirectories(directory)
                Dim subdirinf As New IO.DirectoryInfo(subdirectory)
                Dim tvitem3 As New TreeNode
                tvitem3.Text = subdirinf.Name
                tvitem3.Tag = subdirinf.FullName
                tvitem2.Nodes.Add(tvitem3)
            Next
            tvitem2.Expand()
        Next
    End Sub

    Private Sub tvfolders_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles tvfolders.AfterSelect
        setuplistview(tvfolders.SelectedNode.Tag)
    End Sub

    Private Sub lvitems_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvitems.SelectedIndexChanged
        If lvitems.SelectedItems.Count > 0 Then
            OpenFile(lvitems.SelectedItems(0).Tag)
        End If
    End Sub

    Private Sub fileskimmer_mde_Load(sender As Object, e As EventArgs) Handles Me.Load
        setuptree()
        setuplistview(currentfolder)
        ToolStrip1.Renderer = New memphis.mde_renderer()
        MenuStrip1.Renderer = New memphis.mde_renderer()
        SetFontColors()
    End Sub

    Private Sub AboutExodusForMemphisDesktopEnvironmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutExodusForMemphisDesktopEnvironmentToolStripMenuItem.Click
        memphis.infobox.showinfo("About File Skimmer", "File Skimmer" & vbNewLine & vbNewLine & "Copyright (c) 2015 <Anonymous>" & vbNewLine & vbNewLine & "File Skimmer lets you view the files on your computer.")
    End Sub
End Class