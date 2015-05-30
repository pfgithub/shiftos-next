Imports System.IO
Namespace ShiftDE
    Public Class SDE_File_Skimmer
        Public rolldownsize As Integer
        Public oldbordersize As Integer
        Public oldtitlebarheight As Integer
        Public justopened As Boolean = False
        Public needtorollback As Boolean = False
        Public minimumsizewidth As Integer = 400
        Public minimumsizeheight As Integer = 177

        Dim itemsdeleted As Integer
        Dim filetype As Integer


        Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
            showcontents()
        End Sub

        
        Private Sub showcontents()
            Me.Show()

            lvfiles.Items.Clear()

            lvfiles.Items.Add("Exit Folder", 5)

            Dim dir As New DirectoryInfo(lbllocation.Text)
            Dim files As FileInfo() = dir.GetFiles()
            Dim file As FileInfo
            Dim folders As DirectoryInfo() = dir.GetDirectories()
            Dim folder As DirectoryInfo

            For Each folder In folders
                Dim foldername As String = folder.Name
                lvfiles.Items.Add(foldername, 0)
            Next

            For Each file In files
                Dim filename As String = file.Name
                Dim fileex As String = file.Extension

                filetype = GetFileType(fileex)(0)

                lvfiles.Items.Add(filename, filetype)
            Next
        End Sub

        Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            showcontents()
        End Sub

        Private Sub lbfiles_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lvfiles.MouseDoubleClick

            If lvfiles.SelectedItems(0).Text = "Exit Folder" Then

                If lbllocation.Text = "C:/ShiftOS" Or lbllocation.Text = "C:/ShiftOS/" Then
                    infobox.title = "File Skimmer - Warning!"
                    infobox.textinfo = "Unable to move into a higher directory due to error reading the requested folder on the drive." & Environment.NewLine & Environment.NewLine & "You can only enter directories formatted in the ShiftOS file system (ShiftFS)"
                    infobox.Show()
                Else
                    Dim directoryInfo As System.IO.DirectoryInfo
                    directoryInfo = System.IO.Directory.GetParent(lbllocation.Text)
                    If (directoryInfo.FullName = "C:\") Then Dim errerror As String = "an error" Else lbllocation.Text = directoryInfo.FullName

                    'Dim endloop As Boolean = False
                    'lbllocation.Text = lbllocation.Text.Substring(0, lbllocation.Text.Length - 1)

                    'While endloop = False
                    '    Try
                    '        If lbllocation.Text.Substring(lbllocation.Text.Length - 1) = "/" Then
                    '            endloop = True
                    '        Else
                    '            lbllocation.Text = lbllocation.Text.Substring(0, lbllocation.Text.Length - 1)
                    '        End If
                    '    Catch
                    '        infobox.title = "File Skimmer - Error!"
                    '        infobox.textinfo = "Unable to move into a higher directory due to error reading the requested folder on the drive." & Environment.NewLine & Environment.NewLine & "An error occured going up"
                    '        infobox.Show()
                    '    End Try
                    'End While


                    showcontents()
                End If
            Else
                'Check if selected item is a file or folder. It it's a folder check its extension
                If lbllocation.Text Like "*/" Then
                Else
                    lbllocation.Text = lbllocation.Text + "/"
                End If
                OpenFile(lbllocation.Text + lvfiles.SelectedItems(0).Text)
            End If

        End Sub
        Private Sub lbfiles_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lvfiles.MouseClick
            If e.Button = Windows.Forms.MouseButtons.Right Then
                fileactions.Show(MousePosition)
            Else
                If lvfiles.SelectedItems(0).Text Like "*.*" Then
                    btndeletefile.Text = "Delete File"
                    btndeletefile.Image = My.Resources.deletefile
                    btndeletefile.Size = New Size(117, 31)
                Else
                    btndeletefile.Text = "Delete Folder"
                    btndeletefile.Image = My.Resources.deletefolder
                    btndeletefile.Size = New Size(130, 31)
                End If
            End If
        End Sub

        Private Sub pnlbreak_MouseEnter(sender As Object, e As EventArgs) Handles pnlbreak.Click
            If pnloptions.Visible = False Then
                pnlbreak.BackgroundImage = My.Resources.downarrow
                pnloptions.Show()
            Else
                pnlbreak.BackgroundImage = My.Resources.uparrow
                pnloptions.Hide()
            End If
        End Sub

        Private Sub btndeletefile_Click() Handles btndeletefile.Click
            If lvfiles.SelectedItems.Count > 0 Then
                If lvfiles.SelectedItems(0).Text Like "*.*" Then
                    If lvfiles.SelectedItems(0).Text Like "*.dri*" Then
                        infobox.title = "File Skimmer - Warning!"
                        infobox.textinfo = "This system file is protected and cannot be deleted." & Environment.NewLine & Environment.NewLine & "Permission to delete this file has been blocked to protect the system from potential damage."
                        infobox.Show()
                    ElseIf lvfiles.SelectedItems(0).Text Like "*.sft*" Then
                        infobox.title = "File Skimmer - Warning!"
                        infobox.textinfo = "This system file is protected and cannot be deleted." & Environment.NewLine & Environment.NewLine & "Permission to delete this file has been blocked to protect the system from potential damage."
                        infobox.Show()
                    ElseIf lvfiles.SelectedItems(0).Text Like "*.lst*" Then
                        infobox.title = "File Skimmer - Warning!"
                        infobox.textinfo = "This system file is protected and cannot be deleted." & Environment.NewLine & Environment.NewLine & "Permission to delete this file has been blocked to protect the system from potential damage."
                        infobox.Show()
                    ElseIf lvfiles.SelectedItems(0).Text Like "*.lang*" Then
                        infobox.title = "File Skimmer - Warning!"
                        infobox.textinfo = "This system file is protected and cannot be deleted." & Environment.NewLine & Environment.NewLine & "Permission to delete this file has been blocked to protect the system from potential damage."
                        infobox.Show()
                    ElseIf lvfiles.SelectedItems(0).Text Like "Exit Folder" Then
                        infobox.title = "File Skimmer - Warning!"
                        infobox.textinfo = "You cannot delete this folder."
                        infobox.Show()
                    Else
                        My.Computer.FileSystem.DeleteFile(lbllocation.Text & "/" & lvfiles.SelectedItems(0).Text)
                        My.Computer.Audio.Play(My.Resources.writesound, AudioPlayMode.Background)
                        showcontents()
                    End If
                Else
                    Select Case lvfiles.SelectedItems(0).Text
                        Case "Shiftum42", "SoftwareData", "Drivers", "Languages", "KnowledgeInput"
                            infobox.title = "File Skimmer - Warning!"
                            infobox.textinfo = "This system folder is protected and cannot be deleted." & Environment.NewLine & Environment.NewLine & "Permission to delete this folder has been blocked to protect the system from potential damage."
                            infobox.Show()
                        Case Else
                            Try
                                My.Computer.FileSystem.DeleteDirectory(lbllocation.Text & "/" & lvfiles.SelectedItems(0).Text, FileIO.DeleteDirectoryOption.DeleteAllContents)
                                My.Computer.Audio.Play(My.Resources.writesound, AudioPlayMode.Background)
                                showcontents()
                            Catch ex As Exception
                                infobox.title = "File Skimmer - Error!"
                                infobox.textinfo = "Failed to delete the folder / file(s)."
                                infobox.Show()
                            End Try
                    End Select
                End If
            End If
        End Sub

        Private Sub btnnewfolder_Click(sender As Object, e As EventArgs) Handles btnnewfolder.Click
            infobox.lblintructtext.Text = "Please enter a name for your new folder:"
            infobox.txtuserinput.Text = ""
            infobox.lblintructtext.Show()
            infobox.txtuserinput.Show()
            infobox.title = "New Folder"
            infobox.Show()
            infobox.state = "makingfolder"
        End Sub

        Public Sub makefolder()
            My.Computer.FileSystem.CreateDirectory(lbllocation.Text & "/" & infobox.txtuserinput.Text)
            showcontents()
            infobox.Close()
        End Sub

    End Class
End Namespace