Public Class TextPad

    
    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        file_skimmer.mode = "open"
        file_skimmer.application = "textpad"
        file_skimmer.Show()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        file_skimmer.mode = "save"
        file_skimmer.application = "textpad"
        file_skimmer.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        txtfilebody.Text = ""
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        txtfilebody.Cut()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        txtfilebody.Copy()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        txtfilebody.Paste()
    End Sub

    Private Sub UndoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UndoToolStripMenuItem.Click
        txtfilebody.Undo()
    End Sub

    Private Sub RedoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedoToolStripMenuItem.Click
        txtfilebody.Redo()
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        txtfilebody.SelectAll()
    End Sub

    Private Sub FindToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FindToolStripMenuItem.Click
        basicwm_infobox.showinfo("Find", "Please specify a phrase to find:", True)
        txtfilebody.Find(basicwm_infobox.userinput)
    End Sub

    Private Sub ReplaceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReplaceToolStripMenuItem.Click
        basicwm_infobox.showinfo("Find", "Please specify a phrase to find:", True)
        Dim whattofind As String = basicwm_infobox.userinput
        basicwm_infobox.showinfo("Replace", "What shall we replace """ & whattofind & """ with?", True)
        txtfilebody.Text = txtfilebody.Text.Replace(whattofind, basicwm_infobox.userinput)
    End Sub

    Private Sub TextPad_Load(sender As Object, e As EventArgs) Handles Me.Load
        MenuStrip1.Renderer = New basicwm_renderer()
        setupmenufonts()
        pnltop.DetermineMyVisibility()
    End Sub

    Public Sub setupmenufonts()
        For Each item In MenuStrip1.Items
            item.ForeColor = Color.White
            item.Font = New Font("Courier New", 8.25)
            For Each SubItem In item.DropDownItems
                SubItem.ForeColor = Color.White
                SubItem.font = New Font("Courier New", 8.25)
            Next
        Next
    End Sub
End Class