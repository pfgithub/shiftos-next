Module shiftorium_api
    'API for Shiftorium Applications.

    Public listboxtoaddto As ListBox
    Public codepoints As Integer

    Public Sub DeductCP(ammount As Integer)
        codepoints -= ammount
        savegame()
    End Sub

    Public Sub AddCP(ammount As Integer)
        codepoints += ammount
        savegame()
    End Sub

    Public Sub AddItem(name As String, CP As Integer)
        listboxtoaddto.Items.Add(name & " - " & CP & " CP")
    End Sub

    Public Sub CheckColors() 'This is here because it may dirty the Shiftorium if put elsewhere.
        If boughtgray4 = True Then
            If boughtblue = True Then
                If boughtred = True Then
                    If boughtpurple = False Then listboxtoaddto.Items.Add("Purple - 20 CP")
                    If boughtpurple = True Then
                        If boughtblue = True Then
                            If boughtgreen = True Then
                                If boughtyellow = True Then
                                    If boughtorange = True Then
                                        If boughtbrown = True Then
                                            If boughtred = True Then
                                                If boughtpink = True Then
                                                    If boughtpurple2 = False Then listboxtoaddto.Items.Add("Purple Shades - 40 CP")
                                                    If boughtpurple2 = True Then
                                                        If boughtpurple3 = False Then listboxtoaddto.Items.Add("Full Purple Shade Set - 60 CP")
                                                        If boughtpurple3 = True Then
                                                            If boughtpurple4 = False Then listboxtoaddto.Items.Add("Custom Purple Shades - 100 CP")
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
            If boughtblue = False Then listboxtoaddto.Items.Add("Blue - 20 CP")
            If boughtblue = True Then
                If boughtpurple = True Then
                    If boughtblue = True Then
                        If boughtgreen = True Then
                            If boughtyellow = True Then
                                If boughtorange = True Then
                                    If boughtbrown = True Then
                                        If boughtred = True Then
                                            If boughtpink = True Then
                                                If boughtblue2 = False Then listboxtoaddto.Items.Add("Blue Shades - 40 CP")
                                                If boughtblue2 = True Then
                                                    If boughtblue3 = False Then listboxtoaddto.Items.Add("Full Blue Shade Set - 60 CP")
                                                    If boughtblue3 = True Then
                                                        If boughtblue4 = False Then listboxtoaddto.Items.Add("Custom Blue Shades - 100 CP")
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If

            If boughtgreen = False Then listboxtoaddto.Items.Add("Green - 20 CP")
            If boughtgreen = True Then
                If boughtpurple = True Then
                    If boughtblue = True Then
                        If boughtgreen = True Then
                            If boughtyellow = True Then
                                If boughtorange = True Then
                                    If boughtbrown = True Then
                                        If boughtred = True Then
                                            If boughtpink = True Then
                                                If boughtgreen2 = False Then listboxtoaddto.Items.Add("Green Shades - 40 CP")
                                                If boughtgreen2 = True Then
                                                    If boughtgreen3 = False Then listboxtoaddto.Items.Add("Full Green Shade Set - 60 CP")
                                                    If boughtgreen3 = True Then
                                                        If boughtgreen4 = False Then listboxtoaddto.Items.Add("Custom Green Shades - 100 CP")
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
            If boughtgreen = True Then
                If boughtred = True Then
                    If boughtyellow = False Then listboxtoaddto.Items.Add("Yellow - 20 CP")
                    If boughtpurple = True Then
                        If boughtblue = True Then
                            If boughtgreen = True Then
                                If boughtyellow = True Then
                                    If boughtorange = True Then
                                        If boughtbrown = True Then
                                            If boughtred = True Then
                                                If boughtpink = True Then
                                                    If boughtyellow2 = False Then listboxtoaddto.Items.Add("Yellow Shades - 40 CP")
                                                    If boughtyellow2 = True Then
                                                        If boughtyellow3 = False Then listboxtoaddto.Items.Add("Full Yellow Shade Set - 60 CP")
                                                        If boughtyellow3 = True Then
                                                            If boughtyellow4 = False Then listboxtoaddto.Items.Add("Custom Yellow Shades - 100 CP")
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
            If boughtgreen = True Then
                If boughtred = True Then
                    If boughtorange = False Then listboxtoaddto.Items.Add("Orange - 20 CP")
                    If boughtpurple = True Then
                        If boughtblue = True Then
                            If boughtgreen = True Then
                                If boughtyellow = True Then
                                    If boughtorange = True Then
                                        If boughtbrown = True Then
                                            If boughtred = True Then
                                                If boughtpink = True Then
                                                    If boughtorange2 = False Then listboxtoaddto.Items.Add("Orange Shades - 40 CP")
                                                    If boughtorange2 = True Then
                                                        If boughtorange3 = False Then listboxtoaddto.Items.Add("Full Orange Shade Set - 60 CP")
                                                        If boughtorange3 = True Then
                                                            If boughtorange4 = False Then listboxtoaddto.Items.Add("Custom Orange Shades - 100 CP")
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
            If boughtgreen = True Then
                If boughtred = True Then
                    If boughtblue = True Then
                        If boughtbrown = False Then listboxtoaddto.Items.Add("Brown - 20 CP")
                        If boughtpurple = True Then
                            If boughtblue = True Then
                                If boughtgreen = True Then
                                    If boughtyellow = True Then
                                        If boughtorange = True Then
                                            If boughtbrown = True Then
                                                If boughtred = True Then
                                                    If boughtpink = True Then
                                                        If boughtbrown2 = False Then listboxtoaddto.Items.Add("Brown Shades - 40 CP")
                                                        If boughtbrown2 = True Then
                                                            If boughtbrown3 = False Then listboxtoaddto.Items.Add("Full Brown Shade Set - 60 CP")
                                                            If boughtbrown3 = True Then
                                                                If boughtbrown4 = False Then listboxtoaddto.Items.Add("Custom Brown Shades - 100 CP")
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
            If boughtred = False Then listboxtoaddto.Items.Add("Red - 20 CP")
            If boughtred = True Then
                If boughtpurple = True Then
                    If boughtblue = True Then
                        If boughtgreen = True Then
                            If boughtyellow = True Then
                                If boughtorange = True Then
                                    If boughtbrown = True Then
                                        If boughtred = True Then
                                            If boughtpink = True Then
                                                If boughtred2 = False Then listboxtoaddto.Items.Add("Red Shades - 40 CP")
                                                If boughtred2 = True Then
                                                    If boughtred3 = False Then listboxtoaddto.Items.Add("Full Red Shade Set - 60 CP")
                                                    If boughtred3 = True Then
                                                        If boughtred4 = False Then listboxtoaddto.Items.Add("Custom Red Shades - 100 CP")
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
            If boughtblue = True Then
                If boughtred = True Then
                    If boughtgreen = True Then
                        If boughtpink = False Then listboxtoaddto.Items.Add("Pink - 20 CP")
                        If boughtpurple = True Then
                            If boughtblue = True Then
                                If boughtgreen = True Then
                                    If boughtyellow = True Then
                                        If boughtorange = True Then
                                            If boughtbrown = True Then
                                                If boughtred = True Then
                                                    If boughtpink = True Then
                                                        If boughtpink2 = False Then listboxtoaddto.Items.Add("Pink Shades - 40 CP")
                                                        If boughtpink2 = True Then
                                                            If boughtpink3 = False Then listboxtoaddto.Items.Add("Full Pink Shade Set - 60 CP")
                                                            If boughtpink3 = True Then
                                                                If boughtpink4 = False Then listboxtoaddto.Items.Add("Custom Pink Shades - 100 CP")
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
            If boughtpurple4 = True Then
                If boughtblue4 = True Then
                    If boughtgreen4 = True Then
                        If boughtyellow4 = True Then
                            If boughtorange4 = True Then
                                If boughtbrown4 = True Then
                                    If boughtred4 = True Then
                                        If boughtpink4 = True Then
                                            If boughtanycolour = False Then listboxtoaddto.Items.Add("Basic Custom shade - 50 CP")
                                            If boughtanycolour = True Then
                                                If boughtanycolour2 = False Then listboxtoaddto.Items.Add("General Custom Shades - 100 CP")
                                                If boughtanycolour2 = True Then
                                                    If boughtanycolour3 = False Then listboxtoaddto.Items.Add("Advanced Custom Shades - 250 CP")
                                                    If boughtanycolour3 = True Then
                                                        If boughtanycolour4 = False Then listboxtoaddto.Items.Add("Limitless Custom Shades - 500 CP")
                                                        If boughtanycolour4 = True Then
                                                            If boughtunitymode = False Then listboxtoaddto.Items.Add("Unity Mode - 1000 CP")
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If

    End Sub
End Module
