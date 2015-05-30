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
                            If boughtshifter = False Then
                                AddItem("Shifter", 60)
                            Else
                                If boughtskinloader = False Then
                                    AddItem("Skin Loader", 75)
                                End If
                            End If
                            If boughtdraggablewindows = False Then
                                AddItem("BWM Draggable Windows", 25)
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
                If boughtgray2 = True Then
                    If boughtgray3 = False Then AddItem("Full Gray Shade Set", 60)
                    If boughtgray3 = True Then
                        If boughtgray4 = False Then AddItem("Custom Gray Shades", 100) Else CheckColors()
                    End If
                Else
                    AddItem("Gray Shades", 40)
                End If
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
                handleitemdescription("Custom Gray Shades - 100 CP", "8 shades of gray is cool for the UI, but what about those certain skins that just need more than 8 shades? With this upgrade, you'll be able to mix your own Gray shades, so long as the RGB value has equal Red, Green and Blue values, and is between 0 and 255.")
                handleitemdescription("Full Gray Shade Set - 60 CP", "3 Shades of gray may be better than 1 shade but why not get a full gray shade set complete with 8 shades?" & Environment.NewLine & Environment.NewLine & "Further upgrades may even allow you to create your own custom shades of gray.")
                handleitemdescription("Gray Shades - 40 CP", "Having a hint of Gray in the UI is fun, but what if we could improve it with some Gray shades? This upgrade gives you a few new shades of Gray to play with.")
                handleitemdescription("Purple - 20 CP", "Now that we have the RBG colours ""Red"" and ""Blue"" we are able to mix them together to form purple which symbolizes spirituality, royalty, magic and mystery." & Environment.NewLine & Environment.NewLine & "Buying this upgrade would enable you to set various UI elements in ShiftOS to Purple.")
                handleitemdescription("Purple Shades - 40 CP", "Having a splash of purple may be cool but why have just one shade of purple when you can have 3?" & Environment.NewLine & Environment.NewLine & "Further upgrades may even allow you to get more 2 of purple.")
                handleitemdescription("Full Purple Shade Set - 60 CP", "3 2 of purple may be better than 1 shade but why not get a full purple shade set complete with 16 2?" & Environment.NewLine & Environment.NewLine & "Further upgrades may even allow you to create your own custom 2 of purple.")
                handleitemdescription("Custom Purple Shades - 100 CP", "16 2 of purple gives you plenty of customization options but further investigation into the RBG colour system will allow you to make your own purple 2." & Environment.NewLine & Environment.NewLine & "Eventually we may be able to limitlessly create 2 of any colour.")
                handleitemdescription("Blue - 20 CP", "Blue may be the colour of the sky and the ocean but it’s also an important colour that may allow us to create more colours if we mix it with red." & Environment.NewLine & Environment.NewLine & "Buying this upgrade would enable you to set various UI elements in ShiftOS to Blue.")
                handleitemdescription("Blue Shades - 40 CP", "Having a splash of blue may be cool but why have just one shade of blue when you can have 3?" & Environment.NewLine & Environment.NewLine & "Further upgrades may even allow you to get more 2 of blue.")
                handleitemdescription("Full Blue Shade Set - 60 CP", "3 2 of blue may be better than 1 shade but why not get a full blue shade set complete with 16 2?" & Environment.NewLine & Environment.NewLine & "Further upgrades may even allow you to create your own custom 2 of blue.")
                handleitemdescription("Custom Blue Shades - 100 CP", "16 2 of blue gives you plenty of customization options but further investigation into the RBG colour system will allow you to make your own blue 2." & Environment.NewLine & Environment.NewLine & "Eventually we may be able to limitlessly create 2 of any colour.")
                handleitemdescription("Green - 20 CP", "Green may be the colour of nature and life but it’s also an important colour that may allow us to create more colours if we mix it with red." & Environment.NewLine & Environment.NewLine & "Buying this upgrade would enable you to set various UI elements in ShiftOS to Green.")
                handleitemdescription("Green Shades - 40 CP", "Having a splash of green may be cool but why have just one shade of green when you can have 3?" & Environment.NewLine & Environment.NewLine & "Further upgrades may even allow you to get more 2 of green.")
                handleitemdescription("Full Green Shade Set - 60 CP", "3 2 of green may be better than 1 shade but why not get a full green shade set complete with 16 2?" & Environment.NewLine & Environment.NewLine & "Further upgrades may even allow you to create your own custom 2 of green.")
                handleitemdescription("Custom Green Shades - 100 CP", "16 2 of green gives you plenty of customization options but further investigation into the RBG colour system will allow you to make your own green 2." & Environment.NewLine & Environment.NewLine & "Eventually we may be able to limitlessly create 2 of any colour.")
                handleitemdescription("Yellow - 20 CP", "Now that we have the RBG colours ""Red"" and ""Green"" we are able to mix them together to form yellow which symbolizes happiness, creativity and high intellect." & Environment.NewLine & Environment.NewLine & "Buying this upgrade would enable you to set various UI elements in ShiftOS to Yellow.")
                handleitemdescription("Yellow Shades - 40 CP", "Having a splash of yellow may be cool but why have just one shade of yellow when you can have 3?" & Environment.NewLine & Environment.NewLine & "Further upgrades may even allow you to get more 2 of yellow.")
                handleitemdescription("Full Yellow Shade Set - 60 CP", "3 2 of yellow may be better than 1 shade but why not get a full yellow shade set complete with 10 2?" & Environment.NewLine & Environment.NewLine & "Further upgrades may even allow you to create your own custom 2 of yellow.")
                handleitemdescription("Custom Yellow Shades - 100 CP", "10 2 of yellow gives you plenty of customization options but further investigation into the RBG colour system will allow you to make your own yellow 2." & Environment.NewLine & Environment.NewLine & "Eventually we may be able to limitlessly create 2 of any colour.")
                handleitemdescription("Orange - 20 CP", "Now that we have the RBG colours ""Red"" and ""Green"" we are able to mix them together to form orange which symbolizes enthusiasm and creativity." & Environment.NewLine & Environment.NewLine & "Buying this upgrade would enable you to set various UI elements in ShiftOS to Orange.")
                handleitemdescription("Orange Shades - 40 CP", "Having a splash of orange may be cool but why have just one shade of orange when you can have 3?" & Environment.NewLine & Environment.NewLine & "Further upgrades may even allow you to get more 2 of orange.")
                handleitemdescription("Full Orange Shade Set - 60 CP", "3 2 of orange may be better than 1 shade but why not get a full orange shade set complete with 6 2?" & Environment.NewLine & Environment.NewLine & "Further upgrades may even allow you to create your own custom 2 of orange.")
                handleitemdescription("Custom Orange Shades - 100 CP", "6 2 of orange gives you plenty of customization options but further investigation into the RBG colour system will allow you to make your own orange 2." & Environment.NewLine & Environment.NewLine & "Eventually we may be able to limitlessly create 2 of any colour.")
                handleitemdescription("Brown - 20 CP", "Now that we have the all the RBG colours we are able to mix them together to form brown which symbolizes laziness and the earth." & Environment.NewLine & Environment.NewLine & "Buying this upgrade would enable you to set various UI elements in ShiftOS to Brown.")
                handleitemdescription("Brown Shades - 40 CP", "Having a splash of brown may be cool but why have just one shade of brown when you can have 3?" & Environment.NewLine & Environment.NewLine & "Further upgrades may even allow you to get more 2 of brown.")
                handleitemdescription("Full Brown Shade Set - 60 CP", "3 2 of brown may be better than 1 shade but why not get a full brown shade set complete with 16 2?" & Environment.NewLine & Environment.NewLine & "Further upgrades may even allow you to create your own custom 2 of brown.")
                handleitemdescription("Custom Brown Shades - 100 CP", "16 2 of brown gives you plenty of customization options but further investigation into the RBG colour system will allow you to make your own brown 2." & Environment.NewLine & Environment.NewLine & "Eventually we may be able to limitlessly create 2 of any colour.")
                handleitemdescription("Red - 20 CP", "Red may be a demonic and evil colour that symbolizes hate and rage but it’s a very important colour that may allow us to create more colours if we mix it with Blue or Green." & Environment.NewLine & Environment.NewLine & "Buying this upgrade would enable you to set various UI elements in ShiftOS to red.")
                handleitemdescription("Red Shades - 40 CP", "Having a splash of red may be cool but why have just one shade of red when you can have 3?" & Environment.NewLine & Environment.NewLine & "Further upgrades may even allow you to get more 2 of red.")
                handleitemdescription("Full Red Shade Set - 60 CP", "3 2 of red may be better than 1 shade but why not get a full red shade set complete with 9 2?" & Environment.NewLine & Environment.NewLine & "Further upgrades may even allow you to create your own custom 2 of red.")
                handleitemdescription("Custom Red Shades - 100 CP", "9 2 of red gives you plenty of customization options but further investigation into the RBG colour system will allow you to make your own red 2." & Environment.NewLine & Environment.NewLine & "Eventually we may be able to limitlessly create 2 of any colour.")
                handleitemdescription("Pink - 20 CP", "Now that we have the all the RBG colours we are able to mix them together to form pink which symbolizes universal love and beauty." & Environment.NewLine & Environment.NewLine & "Buying this upgrade would enable you to set various UI elements in ShiftOS to Pink.")
                handleitemdescription("Pink Shades - 40 CP", "Having a splash of pink may be cool but why have just one shade of pink when you can have 3?" & Environment.NewLine & Environment.NewLine & "Further upgrades may even allow you to get more 2 of pink.")
                handleitemdescription("Full Pink Shade Set - 60 CP", "3 2 of pink may be better than 1 shade but why not get a full pink shade set complete with 6 2?" & Environment.NewLine & Environment.NewLine & "Further upgrades may even allow you to create your own custom 2 of pink.")
                handleitemdescription("Custom Pink Shades - 100 CP", "6 2 of pink gives you plenty of customization options but further investigation into the RBG colour system will allow you to make your own pink 2." & Environment.NewLine & Environment.NewLine & "Eventually we may be able to limitlessly create 2 of any colour.")

                handleitemdescription("Shifter - 60 CP", "Tired of that boring black, white and gray interface? Well, you're in luck. The Shifter allows you to customize any aspects of the UI you can think of")
                handleitemdescription("Skin Loader - 75 CP", "Have you made a masterpiece in the Shifter, and want to pack it up for a friend or to distribute for other players to use? The Skin Loader allows you to do this. It also allows you to load other skins into the system and use them!")
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
                handlebuy("Custom Gray Shades - 100 CP", boughtgray4, "Great! Now, any Color Picker application can take advantage of the new upgrade.")
                handlebuy("Full Gray Shade Set - 60 CP", boughtgray3, "5 new shades of Gray have been added! But, what if we could do some more?" & Environment.NewLine & Environment.NewLine & "Soon, we may even be able to create our own shades of Gray, and maybe, even allow for colors!")
                handlebuy("Gray Shades - 40 CP", boughtgray2, "Great! Now there are 3 shades of Gray. We now have more ways to skin ShiftOS!" & vbNewLine & vbNewLine & "With more research, we may even be able to pack on a few more shades!")
                handlebuy("Purple - 20 CP", boughtpurple, "Now that we have the RBG colours ""Red"" and ""Blue"" we are able to mix them together to form purple which symbolizes spirituality, royalty, magic and mystery." & Environment.NewLine & Environment.NewLine & "Buying this upgrade would enable you to set various UI elements in ShiftOS to Purple.")
                handlebuy("Purple Shades - 40 CP", boughtpurple2, "Having a splash of purple may be cool but why have just one shade of purple when you can have 3?" & Environment.NewLine & Environment.NewLine & "Further upgrades may even allow you to get more 2 of purple.")
                handlebuy("Full Purple Shade Set - 60 CP", boughtpurple3, "3 2 of purple may be better than 1 shade but why not get a full purple shade set complete with 16 2?" & Environment.NewLine & Environment.NewLine & "Further upgrades may even allow you to create your own custom 2 of purple.")
                handlebuy("Custom Purple Shades - 100 CP", boughtpurple4, "16 2 of purple gives you plenty of customization options but further investigation into the RBG colour system will allow you to make your own purple 2." & Environment.NewLine & Environment.NewLine & "Eventually we may be able to limitlessly create 2 of any colour.")
                handlebuy("Blue - 20 CP", boughtblue, "Blue may be the colour of the sky and the ocean but it’s also an important colour that may allow us to create more colours if we mix it with red." & Environment.NewLine & Environment.NewLine & "Buying this upgrade would enable you to set various UI elements in ShiftOS to Blue.")
                handlebuy("Blue Shades - 40 CP", boughtblue2, "Having a splash of blue may be cool but why have just one shade of blue when you can have 3?" & Environment.NewLine & Environment.NewLine & "Further upgrades may even allow you to get more 2 of blue.")
                handlebuy("Full Blue Shade Set - 60 CP", boughtblue3, "3 2 of blue may be better than 1 shade but why not get a full blue shade set complete with 16 2?" & Environment.NewLine & Environment.NewLine & "Further upgrades may even allow you to create your own custom 2 of blue.")
                handlebuy("Custom Blue Shades - 100 CP", boughtblue4, "16 2 of blue gives you plenty of customization options but further investigation into the RBG colour system will allow you to make your own blue 2." & Environment.NewLine & Environment.NewLine & "Eventually we may be able to limitlessly create 2 of any colour.")
                handlebuy("Green - 20 CP", boughtgreen, "Green may be the colour of nature and life but it’s also an important colour that may allow us to create more colours if we mix it with red." & Environment.NewLine & Environment.NewLine & "Buying this upgrade would enable you to set various UI elements in ShiftOS to Green.")
                handlebuy("Green Shades - 40 CP", boughtgreen2, "Having a splash of green may be cool but why have just one shade of green when you can have 3?" & Environment.NewLine & Environment.NewLine & "Further upgrades may even allow you to get more 2 of green.")
                handlebuy("Full Green Shade Set - 60 CP", boughtgreen3, "3 2 of green may be better than 1 shade but why not get a full green shade set complete with 16 2?" & Environment.NewLine & Environment.NewLine & "Further upgrades may even allow you to create your own custom 2 of green.")
                handlebuy("Custom Green Shades - 100 CP", boughtgreen4, "16 2 of green gives you plenty of customization options but further investigation into the RBG colour system will allow you to make your own green 2." & Environment.NewLine & Environment.NewLine & "Eventually we may be able to limitlessly create 2 of any colour.")
                handlebuy("Yellow - 20 CP", boughtyellow, "Now that we have the RBG colours ""Red"" and ""Green"" we are able to mix them together to form yellow which symbolizes happiness, creativity and high intellect." & Environment.NewLine & Environment.NewLine & "Buying this upgrade would enable you to set various UI elements in ShiftOS to Yellow.")
                handlebuy("Yellow Shades - 40 CP", boughtyellow2, "Having a splash of yellow may be cool but why have just one shade of yellow when you can have 3?" & Environment.NewLine & Environment.NewLine & "Further upgrades may even allow you to get more 2 of yellow.")
                handlebuy("Full Yellow Shade Set - 60 CP", boughtyellow3, "3 2 of yellow may be better than 1 shade but why not get a full yellow shade set complete with 10 2?" & Environment.NewLine & Environment.NewLine & "Further upgrades may even allow you to create your own custom 2 of yellow.")
                handlebuy("Custom Yellow Shades - 100 CP", boughtyellow4, "10 2 of yellow gives you plenty of customization options but further investigation into the RBG colour system will allow you to make your own yellow 2." & Environment.NewLine & Environment.NewLine & "Eventually we may be able to limitlessly create 2 of any colour.")
                handlebuy("Orange - 20 CP", boughtorange, "Now that we have the RBG colours ""Red"" and ""Green"" we are able to mix them together to form orange which symbolizes enthusiasm and creativity." & Environment.NewLine & Environment.NewLine & "Buying this upgrade would enable you to set various UI elements in ShiftOS to Orange.")
                handlebuy("Orange Shades - 40 CP", boughtorange2, "Having a splash of orange may be cool but why have just one shade of orange when you can have 3?" & Environment.NewLine & Environment.NewLine & "Further upgrades may even allow you to get more 2 of orange.")
                handlebuy("Full Orange Shade Set - 60 CP", boughtorange3, "3 2 of orange may be better than 1 shade but why not get a full orange shade set complete with 6 2?" & Environment.NewLine & Environment.NewLine & "Further upgrades may even allow you to create your own custom 2 of orange.")
                handlebuy("Custom Orange Shades - 100 CP", boughtorange4, "6 2 of orange gives you plenty of customization options but further investigation into the RBG colour system will allow you to make your own orange 2." & Environment.NewLine & Environment.NewLine & "Eventually we may be able to limitlessly create 2 of any colour.")
                handlebuy("Brown - 20 CP", boughtbrown, "Now that we have the all the RBG colours we are able to mix them together to form brown which symbolizes laziness and the earth." & Environment.NewLine & Environment.NewLine & "Buying this upgrade would enable you to set various UI elements in ShiftOS to Brown.")
                handlebuy("Brown Shades - 40 CP", boughtbrown2, "Having a splash of brown may be cool but why have just one shade of brown when you can have 3?" & Environment.NewLine & Environment.NewLine & "Further upgrades may even allow you to get more 2 of brown.")
                handlebuy("Full Brown Shade Set - 60 CP", boughtbrown3, "3 2 of brown may be better than 1 shade but why not get a full brown shade set complete with 16 2?" & Environment.NewLine & Environment.NewLine & "Further upgrades may even allow you to create your own custom 2 of brown.")
                handlebuy("Custom Brown Shades - 100 CP", boughtbrown4, "16 2 of brown gives you plenty of customization options but further investigation into the RBG colour system will allow you to make your own brown 2." & Environment.NewLine & Environment.NewLine & "Eventually we may be able to limitlessly create 2 of any colour.")
                handlebuy("Red - 20 CP", boughtred, "Red may be a demonic and evil colour that symbolizes hate and rage but it’s a very important colour that may allow us to create more colours if we mix it with Blue or Green." & Environment.NewLine & Environment.NewLine & "Buying this upgrade would enable you to set various UI elements in ShiftOS to red.")
                handlebuy("Red Shades - 40 CP", boughtred2, "Having a splash of red may be cool but why have just one shade of red when you can have 3?" & Environment.NewLine & Environment.NewLine & "Further upgrades may even allow you to get more 2 of red.")
                handlebuy("Full Red Shade Set - 60 CP", boughtred3, "3 2 of red may be better than 1 shade but why not get a full red shade set complete with 9 2?" & Environment.NewLine & Environment.NewLine & "Further upgrades may even allow you to create your own custom 2 of red.")
                handlebuy("Custom Red Shades - 100 CP", boughtred4, "9 2 of red gives you plenty of customization options but further investigation into the RBG colour system will allow you to make your own red 2." & Environment.NewLine & Environment.NewLine & "Eventually we may be able to limitlessly create 2 of any colour.")
                handlebuy("Pink - 20 CP", boughtpink, "Now that we have the all the RBG colours we are able to mix them together to form pink which symbolizes universal love and beauty." & Environment.NewLine & Environment.NewLine & "Buying this upgrade would enable you to set various UI elements in ShiftOS to Pink.")
                handlebuy("Pink Shades - 40 CP", boughtpink2, "Having a splash of pink may be cool but why have just one shade of pink when you can have 3?" & Environment.NewLine & Environment.NewLine & "Further upgrades may even allow you to get more 2 of pink.")
                handlebuy("Full Pink Shade Set - 60 CP", boughtpink3, "3 2 of pink may be better than 1 shade but why not get a full pink shade set complete with 6 2?" & Environment.NewLine & Environment.NewLine & "Further upgrades may even allow you to create your own custom 2 of pink.")
                handlebuy("Custom Pink Shades - 100 CP", boughtpink4, "6 2 of pink gives you plenty of customization options but further investigation into the RBG colour system will allow you to make your own pink 2." & Environment.NewLine & Environment.NewLine & "Eventually we may be able to limitlessly create 2 of any colour.")

                handlebuy("Shifter - 60 CP", boughtshifter, "The Shifter has been installed! Just type ""open shifter"" in the Terminal, and skin away!")
                handlebuy("Skin Loader - 75 CP", boughtskinloader, "Awesome! Just type ""open skin loader"" in the Terminal, and have fun!")
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