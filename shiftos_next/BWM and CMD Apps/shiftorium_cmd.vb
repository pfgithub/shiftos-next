Public Class shiftorium_cmd

    
    Public Sub shiftorium_load(s As Object, e As EventArgs) Handles MyBase.Load
        listboxtoaddto = lbitems
        determineitems()
        lbitems.SelectedItem = 0
        lbprice.Hide()
        btnbuy.Hide()
        lbcodepoints.Text = "Codepoints: " & codepoints
        Titlebar1.shiftorium_special()
    End Sub

    Public Sub determineitems()
        lbitems.DrawMode = DrawMode.Normal
        lbitems.Items.Clear()
        Try
            If boughtbasicsettings = False Then
                AddItem("Basic Terminal Settings", 5)
            Else
                If boughtcustomusername = False Then
                    AddItem("Custom Username", 10)
                End If
            End If
            If boughtdirectorysurfing = False Then
                AddItem("Directory Surfing", 10)
            Else
                If boughtbasicgui = True Then
                    If boughtfileskimmer = False Then
                        AddItem("File Skimmer", 60)
                    Else
                        If boughtfileskimmernewfolder = False Then AddItem("FS New Folder", 15)
                        If boughtfileskimmerdelete = False Then AddItem("FS Delete", 15)
                    End If
                    If boughttextpad = False Then
                        AddItem("Textpad", 50)
                    End If
                    If boughttextpad = True And boughtfileskimmer = True Then
                        If boughtbasicwm = False Then
                            AddItem("Basic Window Manager", 100)
                        Else
                            If boughtdraggablewindows = False Then
                                AddItem("BWM Draggable Windows", 25)
                            End If
                            If boughtshifter = False Then
                                AddItem("Shifter", 60)
                            Else
                                If boughtskinloader = False Then
                                    AddItem("Skin Loader", 75)
                                End If
                            End If
                        End If
                    End If
                End If
            End If
            If boughtgray = False Then
                AddItem("Gray", 25)
            Else
                If boughtbasicgui = False Then
                    AddItem("Basic GUI Server", 100)
                End If
                If boughtterminalsettextcolor = False And boughtbasicsettings = True Then
                    AddItem("Set Terminal Text Color", 10)
                End If
                If boughtred = False Then AddItem("Red", 30)
                If boughtgreen = False Then AddItem("Green", 30)
                If boughtblue = False Then AddItem("Blue", 30)
                If boughtpurple = False Then AddItem("Purple", 30)
                If boughtpink = False Then AddItem("Pink", 30)
                If boughtyellow = False Then AddItem("Yellow", 30)
                If boughtorange = False Then AddItem("Orange", 30)
                If boughtbrown = False Then AddItem("Brown", 30)
            End If
            lbitems.SelectedIndex = 0
        Catch ex As Exception
            If debugmode = False Then
                lbitems.Items.Add("No items available.")
            Else
                lbitems.Items.Add(ex.Message)
            End If
        End Try
        lbitems.DrawMode = DrawMode.OwnerDrawFixed
    End Sub

    Public Sub lbitems_keydown(sender As System.Object, e As KeyEventArgs) Handles lbitems.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                e.SuppressKeyPress = True
                Me.Close()
                Terminal.Focus()
            Case Keys.Down
                e.SuppressKeyPress = True
                If Not lbitems.SelectedIndex = lbitems.Items.Count - 1 Then
                    lbitems.SelectedIndex += 1
                End If
            Case Keys.Up
                e.SuppressKeyPress = True
                If Not lbitems.SelectedIndex = 0 Then
                    lbitems.SelectedIndex -= 1
                End If
            Case Keys.Enter
                handleitemdescription("Skin Loader - 75 CP", "Ever wanted to save and load skins for use later? Really like that one color scheme but want to change? Want to share your skins with friends? This application is for you. It allows you to load, save, or apply BWM Skin Files.")
                handleitemdescription("Shifter - 60 CP", "Tired of that same old gray, black and white color scheme? Fear not, the Shifter is here! It allows you to set different settings for the BWM, such as text and background colors. Soon, you may even be able to share skins with friends!")

                handleitemdescription("Red - 30 CP", "Enable the display of Red on the screen.")
                handleitemdescription("Green - 30 CP", "Enable the display of Green on the screen.")
                handleitemdescription("Blue - 30 CP", "Enable the display of Blue on the screen.")
                handleitemdescription("Purple - 30 CP", "Enable the display of Purple on the screen.")
                handleitemdescription("Pink - 30 CP", "Enable the display of Pink on the screen.")
                handleitemdescription("Yellow - 30 CP", "Enable the display of Yellow on the screen.")
                handleitemdescription("Orange - 30 CP", "Enable the display of Orange on the screen.")
                handleitemdescription("Brown - 30 CP", "Enable the display of Brown on the screen.")

                handleitemdescription("BWM Draggable Windows - 25 CP", "We are able to have multiple windows on the screen, but they all stick to the center of the screen and can't be moved! This upgrade fixes that.")
                handleitemdescription("Basic Window Manager - 100 CP", "Fullscreen applications, well, suck. You can't get any work done outside of that app without closing it, and can't even view the Terminal. This upgrade changes that. We've found a way to use the Basic GUI server to create a simple window manager. It allows multiple windows on the screen, and up to 3 Terminal windows at once.")
                handleitemdescription("Textpad - 50 CP", "Hmmmmm... What was I gonna do on Sunday? Oh yeah! I have to get that website written for my buddy. Better write that down before I forget... " & vbNewLine & vbNewLine & "Textpad allows you to create text documents. Handy if you need to write something down!")
                handleitemdescription("FS Delete - 15 CP", "Alright, What's this unused document doing on my PC? I don't need this. I must delete it. With this upgrade, you can delete files in the File Skimmer.")
                handleitemdescription("FS New Folder - 15 CP", "Well, we can view the files on our computer, but we don't have the ability to create directories in the GUI... yet. Upgrade today, and you will be able to.")
                handleitemdescription("File Skimmer - 60 CP", "ShiftOS and Exodus Inc., authors of the Exodus File Browser for UltraDOS, have teamed up to create a GUI-based file browser for ShiftOS, based off the old File Skimmer.")
                handleitemdescription("Set Terminal Text Color - 10 CP", "Having a black and white color scheme on a Terminal is ibfact quite a cliche. This upgrade allows you to set the text color of the Terminal. It only allows for the basic colors, but it's better than just white!")
                handleitemdescription("Basic GUI Server - 100 CP", "Well, we've got Gray, and we've got the ability to write GUIs. Now, let's allow the users to run GUIs, and open a lot of possibilities up.")
                handleitemdescription("Gray - 25 CP", "Black, and white. Such a bland choice of colors. Black for the background, white for the text. What a hard way to develop an app. With this upgrade, the video card driver in ShiftOS will support the output of Gray (R=127, G=127, B=127) allowing for some better capabilities in application programming.")
                handleitemdescription("Directory Surfing - 10 CP", "ShiftOS came with a file system update. Instead of ShiftFS, we have ShiftFS Ultra. However, there's no point in using it... yet. This upgrade allows you to browse the filesystem in the terminal.")
                handleitemdescription("Custom Username - 10 CP", "Hello, user! Isn't that wierd that that's all we know you as? Buy this upgrade to change yourr name from ""user"" to anything you want!")
                handleitemdescription("Basic Terminal Settings - 5 CP", "Ever wanted to customize the terminal to act the way you'd like it to? This upgrade is for you. You won't be able to use it until you buy settings, but hey! The command is there.")
            Case Keys.Space
                handlebuy("Skin Loader - 75 CP", boughtskinloader, "Now, you can head to the Terminal and type ""open skin loader"", and do what you please.")
                handlebuy("Shifter - 60 CP", boughtshifter, "Great! Just type ""open shifter"" in the Terminal and start customizing!")

                handlebuy("Red - 30 CP", boughtred, "Red can now be displayed on screen, and used in the Color Picker.")
                handlebuy("Green - 30 CP", boughtgreen, "Green can now be displayed on screen, and used in the Color Picker.")
                handlebuy("Blue - 30 CP", boughtblue, "Blue can now be displayed on screen, and used in the Color Picker.")
                handlebuy("Purple - 30 CP", boughtpurple, "Purple can now be displayed on screen, and used in the Color Picker.")
                handlebuy("Pink - 30 CP", boughtpink, "Pink can now be displayed on screen, and used in the Color Picker.")
                handlebuy("Orange - 30 CP", boughtorange, "Orange can now be displayed on screen, and used in the Color Picker.")
                handlebuy("Yellow - 30 CP", boughtyellow, "Yellow can now be displayed on screen, and used in the Color Picker.")
                handlebuy("Brown - 30 CP", boughtbrown, "Brown can now be displayed on screen, and used in the Color Picker.")

                handlebuy("BWM Draggable Windows - 25 CP", boughtdraggablewindows, "The upgrade has been applied, and now we can drag windows around using our mouse!")
                handlebuy("Basic Window Manager - 100 CP", boughtbasicwm, "Awesome! Just exit the Shiftorium and type ""bwm"" into the Terminal, and away we go. Future sessions will not require typing ""bwm"".")
                handlebuy("Textpad - 50 CP", boughttextpad, "Great. Now our computer is a bit more useful than before...")
                handlebuy("FS Delete - 15 CP", boughtfileskimmerdelete, "There. I can finally destroy that evil document that's been taking up 3/4 of my hard drive. Just right-click a file and click 'Delete' to delete a file.")
                handlebuy("FS New Folder - 15 CP", boughtfileskimmernewfolder, "Awesome. You can now create new folders in the File Skimmer!")
                handlebuy("File Skimmer - 60 CP", boughtfileskimmer, "The upgrade's been downloaded, and we can now view the files on our computer in a much cleaner way. Just type 'open file skimmer' in the Terminal!")
                handlebuy("Set Terminal Text Color - 10 CP", boughtterminalsettextcolor, "Awesome! Now, you can use 'set textcolor <colorname>' to set the Terminal text color. For a reference on supported colors, you can also type 'colors'.")
                handlebuy("Basic GUI Server - 100 CP", boughtbasicgui, "Amazing. Come time, and money, we may be able to collaborate with other companies to develop applications, upgrades, and eventually a window manager.")
                handlebuy("Gray - 25 CP", boughtgray, "Great. Right away, the Shiftorium is easier to use! Look at that amazing gray highlight.")
                handlebuy("Directory Surfing - 10 CP", boughtdirectorysurfing, "Now we can do basic file navigation using the cd, dir, and mkdir commands. Hopefully, with more research, we may be able to create some apps to handle files, like a text editor.")
                handlebuy("Custom Username - 10 CP", boughtcustomusername, "Amazing! Just type ""set username <value>"" into the Terminal, and presto!")
                handlebuy("Basic Terminal Settings - 5 CP", boughtbasicsettings, "Great! Now, a new command has been added to the terminal. Use it with ""set <setting> <value>"". There are no settings to set, though.")
            Case Else
                e.SuppressKeyPress = True
        End Select
    End Sub




    Private Sub handlebuy(ByVal name As String, ByRef bought As Boolean, ByVal boughttutorial As String)

        On Error Resume Next
        Dim pricegrab As String
        If lbitems.SelectedItem = name Then
            If btnbuy.Text = "Press SPACE to download." Then
                pricegrab = lbitems.SelectedItem.ToString.Substring(lbitems.SelectedItem.ToString.IndexOf("-") + 2, lbitems.SelectedItem.ToString.Length - lbitemname.Text.Length - 5)
                codepoints -= Convert.ToInt32(pricegrab)
                bought = True
                lbdescription.Text = boughttutorial
                btnbuy.Text = "Upgrade """ & name & """ installed, deducting " & pricegrab & " Codepoints."
                lbprice.Hide()
                determineitems()
                lbcodepoints.Text = "Codepoints: " & codepoints
                savegame()
            End If
        End If
    End Sub

    'UltraDOS Upgrade List renderer
    Private Sub udos_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles lbitems.DrawItem
        e.DrawBackground()
        If (e.State And DrawItemState.Selected) = DrawItemState.Selected Then
            If boughtgray Then
                e.Graphics.FillRectangle(Brushes.Gray, e.Bounds)
                Using b As New SolidBrush(e.ForeColor)
                    e.Graphics.DrawString(lbitems.GetItemText(lbitems.Items(e.Index)), e.Font, b, e.Bounds)
                End Using
            Else
                e.Graphics.FillRectangle(Brushes.White, e.Bounds)
                Using b As New SolidBrush(Color.Black)
                    e.Graphics.DrawString(lbitems.GetItemText(lbitems.Items(e.Index)), e.Font, b, e.Bounds)
                End Using
            End If
        Else

            Using b As New SolidBrush(e.ForeColor)
                e.Graphics.DrawString(lbitems.GetItemText(lbitems.Items(e.Index)), e.Font, b, e.Bounds)
            End Using
        End If
        e.DrawFocusRectangle()

    End Sub


    Private Sub handleitemdescription(ByVal itemname As String, ByVal itemdescription As String)
        On Error Resume Next
        If lbitems.SelectedItem.ToString = itemname Then
            lbitemname.Text = lbitems.SelectedItem.ToString.Substring(0, lbitems.SelectedItem.ToString.IndexOf("-"))
            lbdescription.Text = itemdescription
            lbprice.Text = "This item costs " & lbitems.SelectedItem.ToString.Substring(lbitems.SelectedItem.ToString.IndexOf("-") + 2, lbitems.SelectedItem.ToString.Length - lbitemname.Text.Length - 5) & " Codepoints"
            lbprice.Show()
            btnbuy.Show()
            If codepoints > Convert.ToInt32(lbitems.SelectedItem.ToString.Substring(lbitems.SelectedItem.ToString.IndexOf("-") + 2, lbitems.SelectedItem.ToString.Length - lbitemname.Text.Length - 5)) Then
                btnbuy.Text = "Press SPACE to download."
            Else
                btnbuy.Text = "Insufficient Codepoints!"
            End If
        End If
    End Sub

 
End Class