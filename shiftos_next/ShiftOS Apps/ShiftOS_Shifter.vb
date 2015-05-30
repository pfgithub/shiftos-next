Public Class Shifter
    Public rolldownsize As Integer
    Public oldbordersize As Integer
    Public oldtitlebarheight As Integer
    Public justopened As Boolean = False
    Public needtorollback As Boolean = False
    Public minimumsizewidth As Integer = 0
    Public minimumsizeheight As Integer = 0
    Public ShiftOSPath As String = "C:\ShiftOS"

    Public skinlines(200) As String

    Public titlebarcolour As Color
    Public windowbordercolour As Color
    Public windowbordersize As Integer
    Public titlebarheight As Integer
    Public closebuttoncolour As Color
    Public closebuttonheight As Integer
    Public closebuttonwidth As Integer
    Public closebuttonside As Integer
    Public closebuttontop As Integer
    Public titletextcolour As Color
    Public titletexttop As Integer
    Public titletextside As Integer
    Public titletextsize As Integer
    Public titletextfont As String
    Public titletextstyle As FontStyle
    Public desktoppanelcolour As Color
    Public desktopbackgroundcolour As Color
    Public desktoppanelheight As Integer
    Public desktoppanelposition As String
    Public clocktextcolour As Color
    Public clockbackgroundcolor As Color
    Public panelclocktexttop As Integer
    Public panelclocktextsize As Integer
    Public panelclocktextfont As String
    Public panelclocktextstyle As FontStyle
    Public applauncherbuttoncolour As Color
    Public applauncherbuttonclickedcolour As Color
    Public applauncherbackgroundcolour As Color
    Public applaunchermouseovercolour As Color
    Public applicationsbuttontextcolour As Color
    Public applicationbuttonheight As Integer
    Public applicationbuttontextsize As Integer
    Public applicationbuttontextfont As String
    Public applicationbuttontextstyle As FontStyle
    Public applicationlaunchername As String
    Public titletextposition As String
    Public rollupbuttoncolour As Color
    Public rollupbuttonheight As Integer
    Public rollupbuttonwidth As Integer
    Public rollupbuttonside As Integer
    Public rollupbuttontop As Integer
    Public titlebariconside As Integer
    Public titlebaricontop As Integer
    Public showwindowcorners As Boolean
    Public titlebarcornerwidth As Integer
    Public titlebarrightcornercolour As Color
    Public titlebarleftcornercolour As Color
    Public applaunchermenuholderwidth As Integer = 100
    Public windowborderleftcolour As Color
    Public windowborderrightcolour As Color
    Public windowborderbottomcolour As Color
    Public windowborderbottomrightcolour As Color
    Public windowborderbottomleftcolour As Color
    Public panelbuttonicontop As Integer
    Public panelbuttoniconside As Integer
    Public panelbuttoniconsize As Integer
    Public panelbuttonheight As Integer
    Public panelbuttonwidth As Integer
    Public panelbuttoncolour As Color
    Public panelbuttontextcolour As Color
    Public panelbuttontextsize As Integer
    Public panelbuttontextfont As String
    Public panelbuttontextstyle As FontStyle
    Public panelbuttontextside As Integer
    Public panelbuttontexttop As Integer
    Public panelbuttongap As Integer
    Public panelbuttonfromtop As Integer
    Public panelbuttoninitialgap As Integer
    Public minimizebuttoncolour As Color
    Public minimizebuttonheight As Integer
    Public minimizebuttonwidth As Integer
    Public minimizebuttonside As Integer
    Public minimizebuttontop As Integer
    Public icontextcolor As Color

    'skins
    Public shifterskinimages(100) As String
    Public skinclosebutton(2) As Image
    Public skinclosebuttonstyle As ImageLayout
    Public shifterskintitlebar(2) As Image
    Public skintitlebarstyle As ImageLayout
    Public skindesktopbackground(2) As Image
    Public skindesktopbackgroundstyle As ImageLayout
    Public skinrollupbutton(2) As Image
    Public skinrollupbuttonstyle As ImageLayout
    Public skintitlebarrightcorner(2) As Image
    Public skintitlebarrightcornerstyle As ImageLayout = ImageLayout.Stretch
    Public skintitlebarleftcorner(2) As Image
    Public skintitlebarleftcornerstyle As ImageLayout = ImageLayout.Stretch
    Public skindesktoppanel(2) As Image
    Public skindesktoppanelstyle As ImageLayout = ImageLayout.Stretch
    Public skindesktoppaneltime(2) As Image
    Public skindesktoppaneltimestyle As ImageLayout = ImageLayout.Stretch
    Public skinapplauncherbutton(2) As Image
    Public skinapplauncherbuttonstyle As ImageLayout = ImageLayout.Stretch
    Public skinwindowborderleft(2) As Image
    Public skinwindowborderleftstyle As ImageLayout = ImageLayout.Stretch
    Public skinwindowborderright(2) As Image
    Public skinwindowborderrightstyle As ImageLayout = ImageLayout.Stretch
    Public skinwindowborderbottom(2) As Image
    Public skinwindowborderbottomstyle As ImageLayout = ImageLayout.Stretch
    Public skinwindowborderbottomright(2) As Image
    Public skinwindowborderbottomrightstyle As ImageLayout = ImageLayout.Stretch
    Public skinwindowborderbottomleft(2) As Image
    Public skinwindowborderbottomleftstyle As ImageLayout = ImageLayout.Stretch
    Public skinpanelbutton(2) As Image
    Public skinpanelbuttonstyle As ImageLayout = ImageLayout.Stretch
    Public skinminimizebutton(2) As Image
    Public skinminimizebuttonstyle As ImageLayout = ImageLayout.Stretch
    Public skinuserpanel(2) As Image
    Public skinshutdownbutton(2) As Image

    Public customizationtimepoints As Integer
    Public customizationsdone As Integer
    Public customizationpointsearned As Integer
    Dim bmp As Bitmap

    'DevX's ADV. App Launcher

    Public startWidth As Integer = Skins.startWidth
    Public startHeight As Integer = Skins.startHeight
    Public usernametextcolor As Color = Skins.usernametextcolor
    Public shutdowntextcolor As Color = Skins.shutdownTextColor
    Public usernamebgcolor As Color = Skins.userNamePanelBackgroundColor
    Public powerpanelbgcolor As Color = Skins.powerPanelBackgroundColor
    Public powerpanelbgimage As Image = Skins.powerPanelBackgroundImage
    Public usernamebgimage As Image = Skins.userNamePanelBackground
    Public usernamefont As String = Skins.usernamefont
    Public usernamefontsize As Integer = Skins.usernamefontsize
    Public usernamefontstyle As FontStyle = Skins.usernamefontstyle
    Public ShutDownString As String = Skins.shutdownstring
    Public powerpanelfont As String = Skins.shutdownTextFont
    Public powerpanelfontsize As Integer = Skins.shutdownTextSize
    Public powerpanelfontstyle As FontStyle = Skins.shutdownTextStyle
    Public usrbglayout As ImageLayout = Skins.usrPanelBackgroundLayout
    Public pwrbglayout As ImageLayout = Skins.pwrPanelBackgroundLayout




    

    

    Private Sub AddFonts()
        ' Get the installed fonts collection.
        Dim allFonts As New Drawing.Text.InstalledFontCollection

        ' Get an array of the system's font familiies.
        Dim fontFamilies() As FontFamily = allFonts.Families()

        ' Display the font families.
        For Each myFont As FontFamily In fontFamilies
            combotitletextfont.Items.Add(myFont.Name)
            comboclocktextfont.Items.Add(myFont.Name)
            comboappbuttontextfont.Items.Add(myFont.Name)
            cbpanelbuttonfont.Items.Add(myFont.Name)
            launcheritemfont.Items.Add(myFont.Name)
            cmbaalusrfont.Items.Add(myFont.Name)
        Next 'font_family
    End Sub

    Private Sub btnapply_Click(sender As Object, e As EventArgs) Handles btnapply.Click
        If Skin_Loader.Visible = True Then
            infobox.title = "Shifter - Error"
            infobox.textinfo = "It appears that the Skin Loader application is currently open." & Environment.NewLine & Environment.NewLine & "Due to system stability issues you must close it before applying your changes!"
            infobox.Show()
        Else
            ' Set skinning varibles to new values
            ' WINDOWS
            ' Image
            If Not IsNothing(pretitlebar.BackgroundImage) Then Skins.titlebar = pretitlebar.BackgroundImage Else Skins.titlebar = Nothing
            Skins.titlebarlayout = pretitlebar.BackgroundImageLayout
            If Not IsNothing(prepgleft.BackgroundImage) Then Skins.borderleft = prepgleft.BackgroundImage Else Skins.borderleft = Nothing
            Skins.borderleftlayout = prepgleft.BackgroundImageLayout
            If Not IsNothing(prepgright.BackgroundImage) Then Skins.borderright = prepgright.BackgroundImage Else Skins.borderright = Nothing
            Skins.borderrightlayout = prepgright.BackgroundImageLayout
            If Not IsNothing(prepgbottom.BackgroundImage) Then Skins.borderbottom = prepgbottom.BackgroundImage Else Skins.borderbottom = Nothing
            Skins.borderbottomlayout = prepgbottom.BackgroundImageLayout
            If Not IsNothing(preclosebutton.BackgroundImage) Then Skins.closebtn = preclosebutton.BackgroundImage Else Skins.closebtn = Nothing
            Skins.closebtnlayout = preclosebutton.BackgroundImageLayout
            If Not IsNothing(preclosebutton.BackgroundImage) Then Skins.closebtnhover = preclosebutton.BackgroundImage Else Skins.closebtnhover = Nothing
            If Not IsNothing(preclosebutton.BackgroundImage) Then Skins.closebtnclick = preclosebutton.BackgroundImage Else Skins.closebtnclick = Nothing
            If Not IsNothing(prerollupbutton.BackgroundImage) Then Skins.rollbtn = prerollupbutton.BackgroundImage Else Skins.rollbtn = Nothing
            Skins.rollbtnlayout = prerollupbutton.BackgroundImageLayout
            If Not IsNothing(prerollupbutton.BackgroundImage) Then Skins.rollbtnhover = prerollupbutton.BackgroundImage Else Skins.rollbtnhover = Nothing
            If Not IsNothing(prerollupbutton.BackgroundImage) Then Skins.rollbtnclick = prerollupbutton.BackgroundImage Else Skins.rollbtnclick = Nothing
            If Not IsNothing(preminimizebutton.BackgroundImage) Then Skins.minbtn = preminimizebutton.BackgroundImage Else Skins.minbtn = Nothing
            Skins.minbtnlayout = preminimizebutton.BackgroundImageLayout
            If Not IsNothing(preminimizebutton.BackgroundImage) Then Skins.minbtnhover = preminimizebutton.BackgroundImage Else Skins.minbtnhover = Nothing
            If Not IsNothing(preminimizebutton.BackgroundImage) Then Skins.minbtnclick = preminimizebutton.BackgroundImage Else Skins.minbtnclick = Nothing
            If Not IsNothing(prepgbottomrcorner.BackgroundImage) Then Skins.rightcorner = prepgbottomrcorner.BackgroundImage Else Skins.rightcorner = Nothing
            Skins.rightcornerlayout = prepgbottomrcorner.BackgroundImageLayout
            If Not IsNothing(prepgbottomlcorner.BackgroundImage) Then Skins.leftcorner = prepgbottomlcorner.BackgroundImage Else Skins.leftcorner = Nothing
            Skins.leftcornerlayout = prepgbottomlcorner.BackgroundImageLayout
            'Colours
            Skins.titlebarcolour = pretitlebar.BackColor
            Skins.borderleftcolour = prepgleft.BackColor
            Skins.borderrightcolour = prepgright.BackColor
            Skins.borderbottomcolour = prepgbottom.BackColor
            Skins.closebtncolour = preclosebutton.BackColor
            Skins.closebtnhovercolour = preclosebutton.BackColor
            Skins.closebtnclickcolour = preclosebutton.BackColor
            Skins.rollbtncolour = prerollupbutton.BackColor
            Skins.rollbtnhovercolour = prerollupbutton.BackColor
            Skins.rollbtnclickcolour = prerollupbutton.BackColor
            Skins.minbtncolour = preminimizebutton.BackColor
            Skins.minbtnhovercolour = preminimizebutton.BackColor
            Skins.minbtnclickcolour = preminimizebutton.BackColor
            Skins.rightcornercolour = prepgtoprcorner.BackColor
            Skins.leftcornercolour = prepgtoplcorner.BackColor
            Skins.bottomrightcornercolour = prepgbottomrcorner.BackColor
            Skins.bottomleftcornercolour = prepgbottomlcorner.BackColor
            ' Settings
            Skins.closebtnsize = preclosebutton.Size
            Skins.rollbtnsize = prerollupbutton.Size
            Skins.minbtnsize = preminimizebutton.Size
            Skins.titlebarheight = pretitlebar.Height
            Skins.closebtnfromtop = closebuttontop
            Skins.closebtnfromside = closebuttonside
            Skins.rollbtnfromtop = rollupbuttontop
            Skins.rollbtnfromside = rollupbuttonside
            Skins.minbtnfromtop = minimizebuttontop
            Skins.minbtnfromside = minimizebuttonside
            Skins.borderwidth = prepgleft.Width
            Skins.titlebarcornerwidth = prepgtoplcorner.Width
            Skins.enablecorners = showwindowcorners
            ' Text
            Skins.titletextfontfamily = pretitletext.Font.FontFamily.Name
            Skins.titletextfontsize = pretitletext.Font.Size
            Skins.titletextfontstyle = pretitletext.Font.Style
            Skins.titletextpos = titletextposition
            Skins.titletextfromtop = titletexttop
            Skins.titletextfromside = titletextside
            Skins.titletextcolour = pretitletext.ForeColor

            Skins.launcheritemcolour = launcheritemtxtcolour.BackColor
            Skins.launcheritemfont = launcheritemfont.Text
            Select Case launcheritemstyle.SelectedItem.ToString
                Case "Bold"
                    Skins.launcheritemstyle = FontStyle.Bold
                Case "Italic"
                    Skins.launcheritemstyle = FontStyle.Italic
                Case "Regular"
                    Skins.launcheritemstyle = FontStyle.Regular
                Case "Strikeout"
                    Skins.launcheritemstyle = FontStyle.Strikeout
                Case "Underline"
                    Skins.launcheritemstyle = FontStyle.Underline
            End Select
            Skins.launcheritemsize = txtlauncheritemtxtsize.Text

            ' DESKTOP
            Skins.desktoppanelcolour = desktoppanelcolour
            Skins.desktopbackgroundcolour = desktopbackgroundcolour
            Skins.desktoppanelheight = desktoppanelheight
            Skins.desktoppanelposition = desktoppanelposition
            Skins.clocktextcolour = clocktextcolour
            Skins.clockbackgroundcolor = clockbackgroundcolor
            Skins.panelclocktexttop = panelclocktexttop
            Skins.panelclocktextsize = panelclocktextsize
            Skins.panelclocktextfont = panelclocktextfont
            Skins.panelclocktextstyle = panelclocktextstyle
            Skins.applauncherbuttoncolour = applauncherbuttoncolour
            Skins.applauncherbuttonclickedcolour = applauncherbuttonclickedcolour
            Skins.applauncherbackgroundcolour = applauncherbackgroundcolour
            Skins.applaunchermouseovercolour = applaunchermouseovercolour
            Skins.applicationsbuttontextcolour = applicationsbuttontextcolour
            Skins.applicationbuttonheight = applicationbuttonheight
            Skins.applicationbuttontextsize = applicationbuttontextsize
            Skins.applicationbuttontextfont = applicationbuttontextfont
            Skins.applicationbuttontextstyle = applicationbuttontextstyle
            Skins.applicationlaunchername = applicationlaunchername
            Skins.titletextposition = titletextposition
            Skins.applaunchermenuholderwidth = applaunchermenuholderwidth
            Skins.panelbuttonicontop = panelbuttonicontop
            Skins.panelbuttoniconside = panelbuttoniconside
            Skins.panelbuttoniconsize = panelbuttoniconsize
            Skins.panelbuttonheight = panelbuttonheight
            Skins.panelbuttonwidth = panelbuttonwidth
            Skins.panelbuttoncolour = panelbuttoncolour
            Skins.panelbuttontextcolour = panelbuttontextcolour
            Skins.panelbuttontextsize = panelbuttontextsize
            Skins.panelbuttontextfont = panelbuttontextfont
            Skins.panelbuttontextstyle = panelbuttontextstyle
            Skins.panelbuttontextside = panelbuttontextside
            Skins.panelbuttontexttop = panelbuttontexttop
            Skins.panelbuttongap = panelbuttongap
            Skins.panelbuttonfromtop = panelbuttonfromtop
            Skins.panelbuttoninitialgap = panelbuttoninitialgap
            ' images
            Skins.desktoppanel = predesktoppanel.BackgroundImage
            Skins.desktoppanellayout = predesktoppanel.BackgroundImageLayout
            Skins.desktopbackground = pnldesktoppreview.BackgroundImage
            Skins.desktopbackgroundlayout = pnldesktoppreview.BackgroundImageLayout
            Skins.panelclock = pretimepanel.BackgroundImage
            Skins.panelclocklayout = pretimepanel.BackgroundImageLayout
            Skins.applaunchermouseover = skinapplauncherbutton(1)
            Skins.applauncher = skinapplauncherbutton(0)
            Skins.applauncherlayout = skinapplauncherbuttonstyle
            Skins.applauncherclick = skinapplauncherbutton(2)
            Skins.panelbutton = prepnlpanelbutton.BackgroundImage
            Skins.panelbuttonlayout = prepnlpanelbutton.BackgroundImageLayout
            Skins.leftcorner = prepgtoplcorner.BackgroundImage
            Skins.rightcorner = prepgtoprcorner.BackgroundImage

            Skins.bottomleftcorner = prepgbottomlcorner.BackgroundImage
            Skins.bottomleftcornerlayout = prepgbottomlcorner.BackgroundImageLayout
            Skins.bottomrightcorner = prepgbottomrcorner.BackgroundImage
            Skins.bottomrightcornerlayout = prepgbottomrcorner.BackgroundImageLayout
            Skins.enablebordercorners = cbindividualbordercolours.Checked
            Skins.titleiconfromside = titlebariconside
            Skins.titleiconfromtop = titlebaricontop
            Skins.enabledraggableicons = CheckBox1.Checked
            Skins.icontextcolor = icontextcolor

            'Adv App Launcher - Suggested by DevX

            Skins.usernametextcolor = usernametextcolor
            Skins.usernamefont = usernamefont
            Skins.usernamefontsize = usernamefontsize
            Skins.usernamefontstyle = usernamefontstyle
            Skins.userNamePanelBackgroundColor = usernamebgcolor
            Try
                Skins.userNamePanelBackground = skinuserpanel(0)
            Catch
                Skins.userNamePanelBackground = Nothing
            End Try
            Skins.powerPanelBackgroundColor = powerpanelbgcolor
            Try
                Skins.powerPanelBackgroundImage = skinshutdownbutton(0)
            Catch
                Skins.powerPanelBackgroundImage = Nothing
            End Try
            Skins.pwrPanelBackgroundLayout = pwrbglayout
            ' APPLY
            Skins.saveskinfiles(True)
            'windows resize fix
            ' earn code points
            customizationpointsearned = customizationtimepoints
            If customizationsdone < 0 Then customizationpointsearned = customizationpointsearned - Math.Abs(customizationsdone)
            AddCP(customizationpointsearned)
            btnapply.Text = "Earned " & customizationpointsearned & " CP"
            btnapply.BackColor = Color.Black
            btnapply.ForeColor = Color.White
            customizationtimepoints = 0
            customizationsdone = 0
            customizationpointsearned = 0
            timerearned.Start()
        End If

    End Sub

    Dim timingissuefixer As Integer = 0
    Public Sub applysettings()
        If My.Computer.FileSystem.DirectoryExists(ShiftOSPath + "Shiftum42\Skins\CurrentCopy\") Then My.Computer.FileSystem.DeleteDirectory(ShiftOSPath + "Shiftum42\Skins\CurrentCopy\", FileIO.DeleteDirectoryOption.DeleteAllContents)
        saveskintocurrentskin()

        'delay fixes timing issue
        tmrdelay.Start()
        If timingissuefixer > 10 Then
            tmrdelay.Stop()

            'quick fixes
            If titlebarheight > 500 Then
                titlebarheight = 500
                txttitlebarheight.Text = "500"
            End If

            If windowbordersize > 500 Then
                windowbordersize = 500
                txtbordersize.Text = "500"
            End If

            If desktoppanelheight > 500 Then
                desktoppanelheight = 500
                txtdesktoppanelheight.Text = "500"
            End If

            'ShiftOSDesktop.titlebarcolour = titlebarcolour
            'ShiftOSDesktop.windowbordercolour = windowbordercolour
            'ShiftOSDesktop.windowbordersize = windowbordersize
            'ShiftOSDesktop.titlebarheight = titlebarheight
            'ShiftOSDesktop.closebuttoncolour = closebuttoncolour
            'ShiftOSDesktop.closebuttonheight = closebuttonheight
            'ShiftOSDesktop.closebuttonwidth = closebuttonwidth
            'ShiftOSDesktop.closebuttontop = closebuttontop
            'ShiftOSDesktop.closebuttonside = closebuttonside
            'ShiftOSDesktop.titletextcolour = titletextcolour
            'ShiftOSDesktop.titletexttop = titletexttop
            'ShiftOSDesktop.titletextside = titletextside
            'ShiftOSDesktop.titletextsize = titletextsize
            'ShiftOSDesktop.titletextfont = titletextfont
            'ShiftOSDesktop.titletextstyle = titletextstyle
            'ShiftOSDesktop.desktoppanelcolour = desktoppanelcolour
            'ShiftOSDesktop.desktopbackgroundcolour = desktopbackgroundcolour
            'ShiftOSDesktop.desktoppanelheight = desktoppanelheight
            'ShiftOSDesktop.desktoppanelposition = desktoppanelposition
            'ShiftOSDesktop.clocktextcolour = clocktextcolour
            'ShiftOSDesktop.clockbackgroundcolor = clockbackgroundcolor
            'ShiftOSDesktop.panelclocktexttop = panelclocktexttop
            'ShiftOSDesktop.panelclocktextsize = panelclocktextsize
            'ShiftOSDesktop.panelclocktextfont = panelclocktextfont
            'ShiftOSDesktop.panelclocktextstyle = panelclocktextstyle
            'ShiftOSDesktop.applauncherbuttoncolour = applauncherbuttoncolour
            'ShiftOSDesktop.applauncherbuttonclickedcolour = applauncherbuttonclickedcolour
            'ShiftOSDesktop.applauncherbackgroundcolour = applauncherbackgroundcolour
            'ShiftOSDesktop.applaunchermouseovercolour = applaunchermouseovercolour
            'ShiftOSDesktop.ApplicationsToolStripMenuItem.BackColor = Color.Transparent
            'ShiftOSDesktop.applicationsbuttontextcolour = applicationsbuttontextcolour
            'ShiftOSDesktop.applicationbuttonheight = applicationbuttonheight
            'ShiftOSDesktop.applicationbuttontextsize = applicationbuttontextsize
            'ShiftOSDesktop.applicationbuttontextfont = applicationbuttontextfont
            'ShiftOSDesktop.applicationbuttontextstyle = applicationbuttontextstyle
            'ShiftOSDesktop.applicationlaunchername = applicationlaunchername
            'ShiftOSDesktop.titletextposition = titletextposition
            'ShiftOSDesktop.rollupbuttoncolour = rollupbuttoncolour
            'ShiftOSDesktop.rollupbuttonheight = rollupbuttonheight
            'ShiftOSDesktop.rollupbuttonwidth = rollupbuttonwidth
            'ShiftOSDesktop.rollupbuttonside = rollupbuttonside
            'ShiftOSDesktop.rollupbuttontop = rollupbuttontop
            'ShiftOSDesktop.titlebariconside = titlebariconside
            'ShiftOSDesktop.titlebaricontop = titlebaricontop
            'ShiftOSDesktop.showwindowcorners = showwindowcorners
            'ShiftOSDesktop.titlebarcornerwidth = titlebarcornerwidth
            'ShiftOSDesktop.titlebarrightcornercolour = titlebarrightcornercolour
            'ShiftOSDesktop.titlebarleftcornercolour = titlebarleftcornercolour
            'ShiftOSDesktop.applaunchermenuholderwidth = applaunchermenuholderwidth
            'ShiftOSDesktop.windowborderleftcolour = windowborderleftcolour
            'ShiftOSDesktop.windowborderrightcolour = windowborderrightcolour
            'ShiftOSDesktop.windowborderbottomcolour = windowborderbottomcolour
            'ShiftOSDesktop.windowborderbottomrightcolour = windowborderbottomrightcolour
            'ShiftOSDesktop.windowborderbottomleftcolour = windowborderbottomleftcolour
            'ShiftOSDesktop.panelbuttonicontop = panelbuttonicontop
            'ShiftOSDesktop.panelbuttoniconside = panelbuttoniconside
            'ShiftOSDesktop.panelbuttoniconsize = panelbuttoniconsize
            'ShiftOSDesktop.panelbuttoniconsize = panelbuttoniconsize
            'ShiftOSDesktop.panelbuttonheight = panelbuttonheight
            'ShiftOSDesktop.panelbuttonwidth = panelbuttonwidth
            'ShiftOSDesktop.panelbuttoncolour = panelbuttoncolour
            'ShiftOSDesktop.panelbuttontextcolour = panelbuttontextcolour
            'ShiftOSDesktop.panelbuttontextsize = panelbuttontextsize
            'ShiftOSDesktop.panelbuttontextfont = panelbuttontextfont
            'ShiftOSDesktop.panelbuttontextstyle = panelbuttontextstyle
            'ShiftOSDesktop.panelbuttontextside = panelbuttontextside
            'ShiftOSDesktop.panelbuttontexttop = panelbuttontexttop
            'ShiftOSDesktop.panelbuttongap = panelbuttongap
            'ShiftOSDesktop.panelbuttonfromtop = panelbuttonfromtop
            'ShiftOSDesktop.panelbuttoninitialgap = panelbuttoninitialgap
            'ShiftOSDesktop.minimizebuttoncolour = minimizebuttoncolour
            'ShiftOSDesktop.minimizebuttonheight = minimizebuttonheight
            'ShiftOSDesktop.minimizebuttonwidth = minimizebuttonwidth
            'ShiftOSDesktop.minimizebuttonside = minimizebuttonside
            'ShiftOSDesktop.minimizebuttontop = minimizebuttontop

            If shifterskinimages(0) = Nothing Then  Else skinclosebutton(0) = GetImage(shifterskinimages(0))
            If shifterskinimages(1) = Nothing Then  Else skinclosebutton(1) = GetImage(shifterskinimages(1))
            If shifterskinimages(2) = Nothing Then  Else skinclosebutton(2) = GetImage(shifterskinimages(2))
            If shifterskinimages(3) = Nothing Then  Else shifterskintitlebar(0) = GetImage(shifterskinimages(3))
            If shifterskinimages(4) = Nothing Then  Else shifterskintitlebar(1) = GetImage(shifterskinimages(4))
            If shifterskinimages(5) = Nothing Then  Else shifterskintitlebar(2) = GetImage(shifterskinimages(5))
            If shifterskinimages(6) = Nothing Then  Else skindesktopbackground(0) = GetImage(shifterskinimages(6))
            If shifterskinimages(7) = Nothing Then  Else skindesktopbackground(1) = GetImage(shifterskinimages(7))
            If shifterskinimages(8) = Nothing Then  Else skindesktopbackground(2) = GetImage(shifterskinimages(8))
            If shifterskinimages(9) = Nothing Then  Else skinrollupbutton(0) = GetImage(shifterskinimages(9))
            If shifterskinimages(10) = Nothing Then  Else skinrollupbutton(1) = GetImage(shifterskinimages(10))
            If shifterskinimages(11) = Nothing Then  Else skinrollupbutton(2) = GetImage(shifterskinimages(11))
            If shifterskinimages(12) = Nothing Then  Else skintitlebarrightcorner(0) = GetImage(shifterskinimages(12))
            If shifterskinimages(13) = Nothing Then  Else skintitlebarrightcorner(1) = GetImage(shifterskinimages(13))
            If shifterskinimages(14) = Nothing Then  Else skintitlebarrightcorner(2) = GetImage(shifterskinimages(14))
            If shifterskinimages(15) = Nothing Then  Else skintitlebarleftcorner(0) = GetImage(shifterskinimages(15))
            If shifterskinimages(16) = Nothing Then  Else skintitlebarleftcorner(1) = GetImage(shifterskinimages(16))
            If shifterskinimages(17) = Nothing Then  Else skintitlebarleftcorner(2) = GetImage(shifterskinimages(17))
            If shifterskinimages(18) = Nothing Then  Else skindesktoppanel(0) = GetImage(shifterskinimages(18))
            If shifterskinimages(19) = Nothing Then  Else skindesktoppanel(1) = GetImage(shifterskinimages(19))
            If shifterskinimages(20) = Nothing Then  Else skindesktoppanel(2) = GetImage(shifterskinimages(20))
            If shifterskinimages(21) = Nothing Then  Else skindesktoppaneltime(0) = GetImage(shifterskinimages(21))
            If shifterskinimages(22) = Nothing Then  Else skindesktoppaneltime(1) = GetImage(shifterskinimages(22))
            If shifterskinimages(23) = Nothing Then  Else skindesktoppaneltime(2) = GetImage(shifterskinimages(23))
            If shifterskinimages(24) = Nothing Then  Else skinapplauncherbutton(0) = GetImage(shifterskinimages(24))
            If shifterskinimages(25) = Nothing Then  Else skinapplauncherbutton(1) = GetImage(shifterskinimages(25))
            If shifterskinimages(26) = Nothing Then  Else skinapplauncherbutton(2) = GetImage(shifterskinimages(26))
            If shifterskinimages(27) = Nothing Then  Else skinwindowborderleft(0) = GetImage(shifterskinimages(27))
            If shifterskinimages(28) = Nothing Then  Else skinwindowborderleft(1) = GetImage(shifterskinimages(28))
            If shifterskinimages(29) = Nothing Then  Else skinwindowborderleft(2) = GetImage(shifterskinimages(29))
            If shifterskinimages(30) = Nothing Then  Else skinwindowborderright(0) = GetImage(shifterskinimages(30))
            If shifterskinimages(31) = Nothing Then  Else skinwindowborderright(1) = GetImage(shifterskinimages(31))
            If shifterskinimages(32) = Nothing Then  Else skinwindowborderright(2) = GetImage(shifterskinimages(32))
            If shifterskinimages(33) = Nothing Then  Else skinwindowborderbottom(0) = GetImage(shifterskinimages(33))
            If shifterskinimages(34) = Nothing Then  Else skinwindowborderbottom(1) = GetImage(shifterskinimages(34))
            If shifterskinimages(35) = Nothing Then  Else skinwindowborderbottom(2) = GetImage(shifterskinimages(35))
            If shifterskinimages(36) = Nothing Then  Else skinwindowborderbottomright(0) = GetImage(shifterskinimages(36))
            If shifterskinimages(37) = Nothing Then  Else skinwindowborderbottomright(1) = GetImage(shifterskinimages(37))
            If shifterskinimages(38) = Nothing Then  Else skinwindowborderbottomright(2) = GetImage(shifterskinimages(38))
            If shifterskinimages(39) = Nothing Then  Else skinwindowborderbottomleft(0) = GetImage(shifterskinimages(39))
            If shifterskinimages(40) = Nothing Then  Else skinwindowborderbottomleft(1) = GetImage(shifterskinimages(40))
            If shifterskinimages(41) = Nothing Then  Else skinwindowborderbottomleft(2) = GetImage(shifterskinimages(41))
            If shifterskinimages(42) = Nothing Then  Else skinminimizebutton(0) = GetImage(shifterskinimages(42))
            If shifterskinimages(43) = Nothing Then  Else skinminimizebutton(1) = GetImage(shifterskinimages(43))
            If shifterskinimages(44) = Nothing Then  Else skinminimizebutton(2) = GetImage(shifterskinimages(44))
            If shifterskinimages(45) = Nothing Then  Else skinpanelbutton(0) = GetImage(shifterskinimages(45))
            If shifterskinimages(46) = Nothing Then  Else skinpanelbutton(1) = GetImage(shifterskinimages(46))
            If shifterskinimages(47) = Nothing Then  Else skinpanelbutton(2) = GetImage(shifterskinimages(47))

            ShiftOSDesktop.Invalidate()

            customizationpointsearned = customizationtimepoints
            If customizationsdone < 0 Then customizationpointsearned = customizationpointsearned - Math.Abs(customizationsdone)
            AddCP(customizationpointsearned)
            btnapply.Text = "Earned " & customizationpointsearned & " CP"
            btnapply.BackColor = Color.Black
            btnapply.ForeColor = Color.White
            customizationtimepoints = 0
            customizationsdone = 0
            customizationpointsearned = 0
            timerearned.Start()

            Me.Invalidate()

        End If

    End Sub

    Private Function GetImage(ByVal fileName As String) As Bitmap
        Dim ret As Bitmap
        Using img As Image = Image.FromFile(fileName)
            ret = New Bitmap(img)
        End Using
        Return ret
    End Function

    Public Sub saveskintocurrentskin()
        If My.Computer.FileSystem.DirectoryExists(ShiftOSPath + "Shiftum42\Skins\Current\") Then  Else My.Computer.FileSystem.CreateDirectory(ShiftOSPath + "Shiftum42\Skins\Current\")
        My.Computer.FileSystem.CopyDirectory(ShiftOSPath + "Shiftum42\Skins\Current\", ShiftOSPath + "Shiftum42\Skins\CurrentCopy\")
        'ShiftOSDesktop.disposeoldskindata("shifterapply")

        For i = 0 To 50
            If shifterskinimages(i) Is Nothing Then  Else If shifterskinimages(i).Contains(ShiftOSPath + "Shiftum42\Skins\Current\") Then shifterskinimages(i) = shifterskinimages(i).Replace("Current", "CurrentCopy")
        Next

        'My.Computer.FileSystem.CopyDirectory(ShiftOSPath + "Shiftum42\Skins\ChangeOverTempFiles", ShiftOSPath + "Shiftum42\Skins\Current\")



        skinlines(0) = titlebarcolour.ToArgb
        skinlines(1) = windowbordercolour.ToArgb
        skinlines(2) = windowbordersize
        skinlines(3) = titlebarheight
        skinlines(4) = closebuttoncolour.ToArgb
        skinlines(5) = closebuttonheight
        skinlines(6) = closebuttonwidth
        skinlines(7) = closebuttonside
        skinlines(8) = closebuttontop
        skinlines(9) = titletextcolour.ToArgb
        skinlines(10) = titletexttop
        skinlines(11) = titletextside
        skinlines(12) = titletextsize
        skinlines(13) = titletextfont
        skinlines(14) = titletextstyle
        skinlines(15) = desktoppanelcolour.ToArgb
        skinlines(16) = desktopbackgroundcolour.ToArgb
        skinlines(17) = desktoppanelheight
        skinlines(18) = desktoppanelposition
        skinlines(19) = clocktextcolour.ToArgb
        skinlines(20) = clockbackgroundcolor.ToArgb
        skinlines(21) = panelclocktexttop
        skinlines(22) = panelclocktextsize
        skinlines(23) = panelclocktextfont
        skinlines(24) = panelclocktextstyle
        skinlines(25) = applauncherbuttoncolour.ToArgb
        skinlines(26) = applauncherbuttonclickedcolour.ToArgb
        skinlines(27) = applauncherbackgroundcolour.ToArgb
        skinlines(28) = applaunchermouseovercolour.ToArgb
        skinlines(29) = applicationsbuttontextcolour.ToArgb
        skinlines(30) = applicationbuttonheight
        skinlines(31) = applicationbuttontextsize
        skinlines(32) = applicationbuttontextfont
        skinlines(33) = applicationbuttontextstyle
        skinlines(34) = applicationlaunchername
        skinlines(35) = titletextposition
        skinlines(36) = rollupbuttoncolour.ToArgb
        skinlines(37) = rollupbuttonheight
        skinlines(38) = rollupbuttonwidth
        skinlines(39) = rollupbuttonside
        skinlines(40) = rollupbuttontop
        skinlines(41) = titlebariconside
        skinlines(42) = titlebaricontop
        skinlines(43) = showwindowcorners
        skinlines(44) = titlebarcornerwidth
        skinlines(45) = titlebarrightcornercolour.ToArgb
        skinlines(46) = titlebarleftcornercolour.ToArgb
        skinlines(47) = applaunchermenuholderwidth
        skinlines(48) = windowborderleftcolour.ToArgb
        skinlines(49) = windowborderrightcolour.ToArgb
        skinlines(50) = windowborderbottomcolour.ToArgb
        skinlines(51) = windowborderbottomrightcolour.ToArgb
        skinlines(52) = windowborderbottomleftcolour.ToArgb
        skinlines(50) = windowborderbottomcolour.ToArgb
        skinlines(51) = windowborderbottomrightcolour.ToArgb
        skinlines(52) = windowborderbottomleftcolour.ToArgb
        skinlines(50) = windowborderbottomcolour.ToArgb
        skinlines(51) = windowborderbottomrightcolour.ToArgb
        skinlines(52) = windowborderbottomleftcolour.ToArgb
        skinlines(50) = windowborderbottomcolour.ToArgb
        skinlines(51) = windowborderbottomrightcolour.ToArgb
        skinlines(52) = windowborderbottomleftcolour.ToArgb
        skinlines(50) = windowborderbottomcolour.ToArgb
        skinlines(51) = windowborderbottomrightcolour.ToArgb
        skinlines(52) = windowborderbottomleftcolour.ToArgb
        skinlines(50) = windowborderbottomcolour.ToArgb
        skinlines(51) = windowborderbottomrightcolour.ToArgb
        skinlines(52) = windowborderbottomleftcolour.ToArgb
        skinlines(53) = panelbuttonicontop
        skinlines(54) = panelbuttoniconside
        skinlines(55) = panelbuttoniconsize
        skinlines(56) = panelbuttoniconsize
        skinlines(57) = panelbuttonheight
        skinlines(58) = panelbuttonwidth
        skinlines(59) = panelbuttoncolour.ToArgb
        skinlines(60) = panelbuttontextcolour.ToArgb
        skinlines(61) = panelbuttontextsize
        skinlines(62) = panelbuttontextfont
        skinlines(63) = panelbuttontextstyle
        skinlines(64) = panelbuttontextside
        skinlines(65) = panelbuttontexttop
        skinlines(66) = panelbuttongap
        skinlines(67) = panelbuttonfromtop
        skinlines(68) = panelbuttoninitialgap
        skinlines(69) = minimizebuttoncolour.ToArgb
        skinlines(70) = minimizebuttonheight
        skinlines(71) = minimizebuttonwidth
        skinlines(72) = minimizebuttonside
        skinlines(73) = minimizebuttontop

        'convert real locations to currentskin folder
        Dim folderdivider As String = "\"
        For i = 0 To 50
            If shifterskinimages(i) = "" Then
            Else
                If shifterskinimages(i).Contains("\") Then folderdivider = "\" Else folderdivider = "/"
                If IO.File.Exists(shifterskinimages(i)) = True Then
                    IO.File.Copy(shifterskinimages(i), ShiftOSPath + "Shiftum42\Skins\Current\" & shifterskinimages(i).Substring(shifterskinimages(i).LastIndexOf(folderdivider)), True)
                    shifterskinimages(i) = ShiftOSPath + "Shiftum42\Skins\Current\" & shifterskinimages(i).Substring(shifterskinimages(i).LastIndexOf(folderdivider) + 1)
                Else
                    infobox.showinfo("Skinning Error", "It seems that the images used by this skin have been deleted. The file " & shifterskinimages(i) & " cannot be found.")
                End If
            End If

        Next

        skinlines(100) = shifterskinimages(0)
        skinlines(101) = shifterskinimages(1)
        skinlines(102) = shifterskinimages(2)
        skinlines(103) = shifterskinimages(3)
        skinlines(104) = shifterskinimages(4)
        skinlines(105) = shifterskinimages(5)
        skinlines(106) = shifterskinimages(6)
        skinlines(107) = shifterskinimages(7)
        skinlines(108) = shifterskinimages(8)
        skinlines(109) = shifterskinimages(9)
        skinlines(110) = shifterskinimages(10)
        skinlines(111) = shifterskinimages(11)
        skinlines(112) = shifterskinimages(12)
        skinlines(113) = shifterskinimages(13)
        skinlines(114) = shifterskinimages(14)
        skinlines(115) = shifterskinimages(15)
        skinlines(116) = shifterskinimages(16)
        skinlines(117) = shifterskinimages(17)
        skinlines(118) = shifterskinimages(18)
        skinlines(119) = shifterskinimages(19)
        skinlines(120) = shifterskinimages(20)
        skinlines(121) = shifterskinimages(21)
        skinlines(122) = shifterskinimages(22)
        skinlines(123) = shifterskinimages(23)
        skinlines(124) = shifterskinimages(24)
        skinlines(125) = shifterskinimages(25)
        skinlines(126) = shifterskinimages(26)
        skinlines(127) = shifterskinimages(27)
        skinlines(128) = shifterskinimages(28)
        skinlines(129) = shifterskinimages(29)
        skinlines(130) = shifterskinimages(30)
        skinlines(131) = shifterskinimages(31)
        skinlines(132) = shifterskinimages(32)
        skinlines(133) = shifterskinimages(33)
        skinlines(134) = shifterskinimages(34)
        skinlines(135) = shifterskinimages(35)
        skinlines(136) = shifterskinimages(36)
        skinlines(137) = shifterskinimages(37)
        skinlines(138) = shifterskinimages(38)
        skinlines(139) = shifterskinimages(39)
        skinlines(140) = shifterskinimages(40)
        skinlines(141) = shifterskinimages(41)
        skinlines(142) = shifterskinimages(42)
        skinlines(143) = shifterskinimages(43)
        skinlines(144) = shifterskinimages(44)
        skinlines(145) = shifterskinimages(45)
        skinlines(146) = shifterskinimages(46)
        skinlines(147) = shifterskinimages(47)
        skinlines(148) = shifterskinimages(48)
        skinlines(149) = shifterskinimages(49)
        skinlines(150) = shifterskinimages(50)

        IO.File.WriteAllLines(ShiftOSPath + "Shiftum42\Skins\Current\skindata.dat", skinlines)
    End Sub

    Private Sub setclocktime()
        If boughtsplitsecondtime = True Then
            prepaneltimetext.Text = TimeOfDay
        Else
            If boughtminuteaccuracytime = True Then
                If Date.Now.Hour < 12 Then
                    prepaneltimetext.Text = TimeOfDay.Hour & ":" & Format(TimeOfDay.Minute, "00") & " AM"
                Else
                    prepaneltimetext.Text = TimeOfDay.Hour - 12 & ":" & Format(TimeOfDay.Minute, "00") & " PM"
                End If
            Else
                If boughtpmandam = True Then
                    If Date.Now.Hour < 12 Then
                        prepaneltimetext.Text = TimeOfDay.Hour & " AM"
                    Else
                        prepaneltimetext.Text = TimeOfDay.Hour - 12 & " PM"
                    End If
                Else
                    If boughthourspastmidnight = True Then
                        prepaneltimetext.Text = Math.Floor(Date.Now.Subtract(Date.Today).TotalSeconds / 60 / 60)
                    Else
                        If boughtminutespastmidnight = True Then
                            prepaneltimetext.Text = Math.Floor(Date.Now.Subtract(Date.Today).TotalSeconds / 60)
                        Else
                            If boughtsecondspastmidnight = True Then
                                prepaneltimetext.Text = Math.Floor(Date.Now.Subtract(Date.Today).TotalSeconds)
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub pnlwindowsoptions_Paint(sender As Object, e As PaintEventArgs) Handles pnlwindowsoptions.Paint
        'e.Graphics.DrawRectangle(New Pen(Color.Black, 2), pnlwindowsobjects.ClientRectangle)
    End Sub

    Private Sub catholder_Paint(sender As Object, e As PaintEventArgs) Handles catholder.Paint
        e.Graphics.DrawRectangle(New Pen(Color.Black, 2), catholder.ClientRectangle)
    End Sub

    Private Sub btnwindows_Click(sender As Object, e As EventArgs) Handles btnwindows.Click
        pnlwindowsoptions.Location = New Point(133, 6)
        pnlwindowsoptions.Size = New Size(458, 297)
        pnlwindowsoptions.Show()
        pnlwindowsoptions.BringToFront()

    End Sub



    Private Sub btnreset_Click(sender As Object, e As EventArgs) Handles btnreset.Click
        pnlreset.Location = New Point(133, 6)
        pnlreset.Size = New Size(458, 297)
        pnlreset.Show()
        pnlreset.BringToFront()

    End Sub

    
    Private Sub btntitlebar_Click(sender As Object, e As EventArgs) Handles btntitlebar.Click
        If boughtshifttitlebar Then
            pnltitlebaroptions.Show()
            pnltitlebaroptions.Size = New Size(317, 134)
            pnltitlebaroptions.Location = New Point(136, 159)
            pnltitlebaroptions.BringToFront()
        Else
            infobox.title = "Shifter - Setting not found!"
            infobox.textinfo = "This setting can not be altered due to no system configuration files matching this option." & Environment.NewLine & Environment.NewLine & "The system files required are either corrupt or do not exist!"
            infobox.Show()
        End If
    End Sub

    Private Sub btnborders_Click(sender As Object, e As EventArgs) Handles btnborders.Click
        If boughtshiftborders Then
            pnlborderoptions.Show()
            pnlborderoptions.Size = New Size(317, 134)
            pnlborderoptions.Location = New Point(136, 159)
            pnlborderoptions.BringToFront()
        Else
            infobox.title = "Shifter - Setting not found!"
            infobox.textinfo = "This setting can not be altered due to no system configuration files matching this option." & Environment.NewLine & Environment.NewLine & "The system files required are either corrupt or do not exist!"
            infobox.Show()
        End If
    End Sub

    Private Sub btnclosebutton_Click(sender As Object, e As EventArgs) Handles btnbuttons.Click
        If boughtshifttitlebuttons Then
            pnlbuttonoptions.Show()
            pnlbuttonoptions.Size = New Size(317, 134)
            pnlbuttonoptions.Location = New Point(136, 159)
            pnlbuttonoptions.BringToFront()
        Else
            infobox.title = "Shifter - Setting not found!"
            infobox.textinfo = "This setting can not be altered due to no system configuration files matching this option." & Environment.NewLine & Environment.NewLine & "The system files required are either corrupt or do not exist!"
            infobox.Show()
        End If
    End Sub

    
    
    Private Sub btntitletext_Click(sender As Object, e As EventArgs) Handles btntitletext.Click
        If boughtshifttitletext Then
            pnltitletextoptions.Show()
            pnltitletextoptions.Size = New Size(317, 134)
            pnltitletextoptions.Location = New Point(136, 159)
            pnltitletextoptions.BringToFront()
        Else
            infobox.title = "Shifter - Setting not found!"
            infobox.textinfo = "This setting can not be altered due to no system configuration files matching this option." & Environment.NewLine & Environment.NewLine & "The system files required are either corrupt or do not exist!"
            infobox.Show()
        End If
    End Sub

    
    Private Sub btndesktoppanel_Click(sender As Object, e As EventArgs) Handles btndesktoppanel.Click
        If boughtshiftdesktoppanel Then
            Try
                pnldesktoppaneloptions.Show()
                pnldesktoppaneloptions.Size = New Size(317, 134)
                pnldesktoppaneloptions.Location = New Point(136, 159)
                pnldesktoppaneloptions.BringToFront()
            Catch ex As OutOfMemoryException
                infobox.showinfo("Memory Error", "There has been a memory error while accessing the desktop settings. Operation aborted.")
            End Try
        Else
            infobox.title = "Shifter - Setting not found!"
            infobox.textinfo = "This setting can not be altered due to no system configuration files matching this option." & Environment.NewLine & Environment.NewLine & "The system files required are either corrupt or do not exist!"
            infobox.Show()
        End If
    End Sub

    Private Sub btnpanelbuttons_Click(sender As Object, e As EventArgs) Handles btnpanelbuttons.Click
        If boughtshiftpanelbuttons Then
            pnlpanelbuttonsoptions.Show()
            pnlpanelbuttonsoptions.Size = New Size(317, 134)
            pnlpanelbuttonsoptions.Location = New Point(136, 159)
            pnlpanelbuttonsoptions.BringToFront()
        Else
            infobox.title = "Shifter - Setting not found!"
            infobox.textinfo = "This setting can not be altered due to no system configuration files matching this option." & Environment.NewLine & Environment.NewLine & "The system files required are either corrupt or do not exist!"
            infobox.Show()
        End If
    End Sub


    Private Sub btndesktopitself_Click(sender As Object, e As EventArgs) Handles btndesktopitself.Click
        If boughtshiftdesktop Then
            pnldesktopbackgroundoptions.Show()
            pnldesktopbackgroundoptions.Size = New Size(317, 134)
            pnldesktopbackgroundoptions.Location = New Point(136, 159)
            pnldesktopbackgroundoptions.BringToFront()
        Else
            infobox.title = "Shifter - Setting not found!"
            infobox.textinfo = "This setting can not be altered due to no system configuration files matching this option." & Environment.NewLine & Environment.NewLine & "The system files required are either corrupt or do not exist!"
            infobox.Show()
        End If
    End Sub

    Private Sub btnpanelclock_Click(sender As Object, e As EventArgs) Handles btnpanelclock.Click
        If boughtshiftpanelclock Then
            pnlpanelclockoptions.Show()
            pnlpanelclockoptions.Size = New Size(317, 134)
            pnlpanelclockoptions.Location = New Point(136, 159)
            pnlpanelclockoptions.BringToFront()
        Else
            infobox.title = "Shifter - Setting not found!"
            infobox.textinfo = "This setting can not be altered due to no system configuration files matching this option." & Environment.NewLine & Environment.NewLine & "The system files required are either corrupt or do not exist!"
            infobox.Show()
        End If
    End Sub

    Private Sub btnapplauncher_Click(sender As Object, e As EventArgs) Handles btnapplauncher.Click
        If boughtshiftapplauncher Then
            pnlapplauncheroptions.Show()
            pnlapplauncheroptions.Size = New Size(317, 134)
            pnlapplauncheroptions.Location = New Point(136, 159)
            pnlapplauncheroptions.BringToFront()
            pnllauncheritems.Hide()
        Else
            infobox.title = "Shifter - Setting not found!"
            infobox.textinfo = "This setting can not be altered due to no system configuration files matching this option." & Environment.NewLine & Environment.NewLine & "The system files required are either corrupt or do not exist!"
            infobox.Show()
        End If
    End Sub

    Private Sub predesktopappmenu_MouseEnter(sender As Object, e As EventArgs) Handles predesktopappmenu.MouseEnter
        Me.Focus()
    End Sub

    
End Class