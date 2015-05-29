Public Class ExodusFB_mde
    'Editable Variables
    Public apptitle As String = "Exodus File Browser" 'The name of your app
    Public currentfolder As String = "C:\UltraDOS"

#Region "Template Code"
    'Programmatically Defined
    Public mySizeW As Integer
    Public mySizeH As Integer
    Public isMaximized As Boolean
    Public mylocation As Point



    Private Sub captionbuttonholder_Paint(sender As Object, e As PaintEventArgs) Handles captionbuttonholder.Paint

    End Sub

    Private Sub closebtn_Click(sender As Object, e As EventArgs) Handles closebtn.Click
        Me.Close()
        memphis.setuppanelbuttons()
    End Sub

    Private Sub maxbtn_Click(sender As Object, e As EventArgs) Handles maxbtn.Click
        setMaximized()
    End Sub

    Public Sub setMaximized()
        If isMaximized = True Then
            Me.Size = New Size(mySizeW, mySizeH)
            Me.Location = mylocation
            isMaximized = False
        Else
            Dim desktopappbarheight As Integer = memphis.ToolStrip1.Height + memphis.ToolStrip2.Height
            Dim screenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
            Dim screenheight As Integer = Screen.PrimaryScreen.Bounds.Height - desktopappbarheight
            Me.Size = New Size(screenWidth, screenheight)
            Me.Location = New Point(0, memphis.ToolStrip1.Height)
            isMaximized = True
        End If
    End Sub

    Private Sub titletext_Click(sender As Object, e As MouseEventArgs) Handles titletext.MouseDown, captionbuttonholder.MouseDown
        If isMaximized = False Then
            If e.Button = MouseButtons.Left Then
                Titlebar.Capture = False
                titletext.Capture = False
                Const WM_NCLBUTTONDOWN As Integer = &HA1S
                Const HTCAPTION As Integer = 2
                Dim msg As Message = _
                    Message.Create(Me.Handle, WM_NCLBUTTONDOWN, _
                        New IntPtr(HTCAPTION), IntPtr.Zero)
                Me.DefWndProc(msg)
            End If
        End If
    End Sub

    Private Sub minbtn_Click(sender As Object, e As EventArgs) Handles minbtn.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Public Sub Me_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mySizeW = Me.Width
        mySizeH = Me.Height
        mylocation = Me.Location
        SetupTitle()
        Me.TopMost = True
        memphis.setuppanelbuttons()
        SetFontColors()
        setuptree()
    End Sub

    Public Sub SetupTitle()
        titletext.Text = apptitle
    End Sub

#End Region

    Public Function getfiletype(file As String)
        Dim filetype As Integer
        Select Case file
            Case ".txt", ".rtf", ".owd"
                filetype = 1
            Case Else
                filetype = 2
        End Select
        Return filetype
    End Function

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
            lvitem.ImageIndex = 0
            lv.Items.Add(lvitem)
        Next
        For Each File As String In IO.Directory.GetFiles(folder)
            Dim lvitem As New ListViewItem
            Dim filinf As New IO.FileInfo(File)
            lvitem.Text = filinf.Name
            lvitem.Tag = filinf.FullName
            lvitem.ImageIndex = getfiletype(filinf.Extension)
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
        ToolStrip1.Renderer = New mde_renderer()
        MenuStrip1.Renderer = New mde_renderer()
        ToolStrip1.ForeColor = Color.White
    End Sub

    Public Sub setuptree()
        Dim tv As TreeView = tvfolders
        Dim tvitem As New TreeNode
        tvitem.Text = "Root (C:\UltraDOS)"
        tvitem.Tag = "C:\UltraDOS"
        tv.Nodes.Add(tvitem)
        tvitem.Expand()
        For Each directory As String In IO.Directory.GetDirectories("C:\UltraDOS")
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
End Class