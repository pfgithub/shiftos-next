Module saveengine
    'Core for Save Engine

    Public username As String = "user"
    Public osname As String = "shiftos"

    '
    ' NEWER UPGRADES: These are partly from UltraDOS, partially from Orion, and a few others created just for this project.
    '

    Public boughtdirectorysurfing As Boolean = False
    Public boughtbasicsettings As Boolean = False
    Public boughtbasicgui As Boolean = False
    Public boughtterminalsettextcolor As Boolean = False
    Public boughtbasicwm As Boolean = False

    '
    ' OLD SHIFTOS UPGRADES: These upgrades may be useful, so I've added them.
    '

    'Shiftorium Upgrades
    Public boughttitlebar As Boolean = False
    Public boughtgray As Boolean = False
    Public boughtsecondspastmidnight As Boolean = False
    Public boughtminutespastmidnight As Boolean = False
    Public boughthourspastmidnight As Boolean = False
    Public boughtcustomusername As Boolean = False
    Public boughtwindowsanywhere As Boolean = False
    Public boughtmultitasking As Boolean = False
    Public boughtautoscrollterminal As Boolean = False
    Public boughtmovablewindows As Boolean = False
    Public boughtdraggablewindows As Boolean = False
    Public boughtwindowborders As Boolean = False
    Public boughtpmandam As Boolean = False
    Public boughtminuteaccuracytime As Boolean = False
    Public boughtsplitsecondtime As Boolean = False
    Public boughttitletext As Boolean = False
    Public boughtclosebutton As Boolean = False
    Public boughtdesktoppanel As Boolean = False
    Public boughtclock As Boolean = False
    Public boughtwindowedterminal As Boolean = False
    Public boughtapplaunchermenu As Boolean = False
    Public boughtalknowledgeinput As Boolean = False
    Public boughtalclock As Boolean = False
    Public boughtalshiftorium As Boolean = False
    Public boughtapplaunchershutdown As Boolean = False
    Public boughtdesktoppanelclock As Boolean = False
    Public boughtterminalscrollbar As Boolean = False
    Public boughtkiaddons As Boolean = False
    Public boughtkicarbrands As Boolean = False
    Public boughtkigameconsoles As Boolean = False
    Public boughtshifter As Boolean = False
    Public boughtalshifter As Boolean = False
    Public boughtrollupcommand As Boolean = False
    Public boughtrollupbutton As Boolean = False
    Public boughtshiftdesktop As Boolean = False
    Public boughtshiftpanelclock As Boolean = False
    Public boughtshiftapplauncher As Boolean = False
    Public boughtshiftdesktoppanel As Boolean = False
    Public boughtshifttitlebar As Boolean = False
    Public boughtshifttitletext As Boolean = False
    Public boughtshifttitlebuttons As Boolean = False
    Public boughtshiftborders As Boolean = False
    Public boughtgray2 As Boolean = False
    Public boughtgray3 As Boolean = False
    Public boughtgray4 As Boolean = False
    Public boughtanycolour As Boolean = False
    Public boughtanycolour2 As Boolean = False
    Public boughtanycolour3 As Boolean = False
    Public boughtanycolour4 As Boolean = False
    Public boughtpurple As Boolean = False
    Public boughtpurple2 As Boolean = False
    Public boughtpurple3 As Boolean = False
    Public boughtpurple4 As Boolean = False
    Public boughtblue As Boolean = False
    Public boughtblue2 As Boolean = False
    Public boughtblue3 As Boolean = False
    Public boughtblue4 As Boolean = False
    Public boughtgreen As Boolean = False
    Public boughtgreen2 As Boolean = False
    Public boughtgreen3 As Boolean = False
    Public boughtgreen4 As Boolean = False
    Public boughtyellow As Boolean = False
    Public boughtyellow2 As Boolean = False
    Public boughtyellow3 As Boolean = False
    Public boughtyellow4 As Boolean = False
    Public boughtorange As Boolean = False
    Public boughtorange2 As Boolean = False
    Public boughtorange3 As Boolean = False
    Public boughtorange4 As Boolean = False
    Public boughtbrown As Boolean = False
    Public boughtbrown2 As Boolean = False
    Public boughtbrown3 As Boolean = False
    Public boughtbrown4 As Boolean = False
    Public boughtred As Boolean = False
    Public boughtred2 As Boolean = False
    Public boughtred3 As Boolean = False
    Public boughtred4 As Boolean = False
    Public boughtpink As Boolean = False
    Public boughtpink2 As Boolean = False
    Public boughtpink3 As Boolean = False
    Public boughtpink4 As Boolean = False
    'new 0.0.6 content
    Public boughtpong As Boolean = False
    Public boughtknowledgeinputicon As Boolean = False
    Public boughtshiftericon As Boolean = False
    Public boughtshiftoriumicon As Boolean = False
    Public boughtclockicon As Boolean = False
    Public boughtshutdownicon As Boolean = False
    Public boughtpongicon As Boolean = False
    Public boughtterminalicon As Boolean = False
    Public boughtalpong As Boolean = False
    Public boughtfileskimmer As Boolean = False
    Public boughtalfileskimmer As Boolean = False
    Public boughttextpad As Boolean = False
    Public boughtaltextpad As Boolean = False
    Public boughtfileskimmericon As Boolean = False
    Public boughttextpadicon As Boolean = False
    Public boughttextpadnew As Boolean = False
    Public boughttextpadsave As Boolean = False
    Public boughttextpadopen As Boolean = False
    Public boughtfileskimmernewfolder As Boolean = False
    Public boughtfileskimmerdelete As Boolean = False
    Public boughtkielements As Boolean = False
    Public boughtcolourpickericon As Boolean = False
    Public boughtinfoboxicon As Boolean = False
    'new 0.0.7 content
    Public boughtskinloader As Boolean = False
    Public boughtminimizebutton As Boolean = False
    Public boughtpanelbuttons As Boolean = False
    Public boughtshiftpanelbuttons As Boolean = False
    Public boughtartpad As Boolean = False
    Public boughtalartpad As Boolean = False
    Public boughtartpadicon As Boolean = False
    Public boughtskinning As Boolean = False
    Public boughtminimizecommand As Boolean = False
    Public boughtusefulpanelbuttons As Boolean = False
    Public boughtunitymode As Boolean = False
    Public boughtartpadpixellimit4 As Boolean = False
    Public boughtartpadpixellimit8 As Boolean = False
    Public boughtartpadpixellimit16 As Boolean = False
    Public boughtartpadpixellimit64 As Boolean = False
    Public boughtartpadpixellimit256 As Boolean = False
    Public boughtartpadpixellimit1024 As Boolean = False
    Public boughtartpadpixellimit4096 As Boolean = False
    Public boughtartpadpixellimit16384 As Boolean = False
    Public boughtartpadpixellimit65536 As Boolean = False
    Public boughtartpadlimitlesspixels As Boolean = False
    Public boughtartpad4colorpallets As Boolean = False
    Public boughtartpad8colorpallets As Boolean = False
    Public boughtartpad16colorpallets As Boolean = False
    Public boughtartpad32colorpallets As Boolean = False
    Public boughtartpad64colorpallets As Boolean = False
    Public boughtartpad128colorpallets As Boolean = False
    Public boughtartpadcustompallets As Boolean = False
    Public boughtartpadnew As Boolean = False
    Public boughtartpadpixelplacer As Boolean = False
    Public boughtartpadpixelplacermovementmode As Boolean = False
    Public boughtartpadpencil As Boolean = False
    Public boughtartpadpaintbrush As Boolean = False
    Public boughtartpadlinetool As Boolean = False
    Public boughtartpadovaltool As Boolean = False
    Public boughtartpadrectangletool As Boolean = False
    Public boughtartpaderaser As Boolean = False
    Public boughtartpadfilltool As Boolean = False
    Public boughtartpadtexttool As Boolean = False
    Public boughtartpadundo As Boolean = False
    Public boughtartpadredo As Boolean = False
    Public boughtartpadsave As Boolean = False
    Public boughtartpadload As Boolean = False
    'new 0.0.8 features
    Public boughtresizablewindows As Boolean = False
    Public boughtcalculator As Boolean = False
    Public boughtaudioplayer As Boolean = False
    Public boughtchangeosnamecommand As Boolean = False
    Public boughtwebbrowser As Boolean = False
    Public boughtvideoplayer As Boolean = False
    Public boughtnamechanger As Boolean = False
    Public boughticonmanager As Boolean = False
    Public boughtbitnotewallet As Boolean = False
    Public boughtbitnotedigger As Boolean = False
    Public boughtskinshifter As Boolean = False
    Public boughtshiftnet As Boolean = False
    Public boughtdownloader As Boolean = False
    Public boughtshiftneticon As Boolean = False
    Public boughtalshiftnet As Boolean = False
    Public boughtdodge As Boolean = False
    Public boughtdownloadmanager As Boolean = False
    Public boughtinstaller As Boolean = False
    Public boughtsnakey As Boolean = False
    Public boughtsysinfoicon As Boolean = False
    Public boughtorcwrite As Boolean = False
    Public boughtfloodgate As Boolean = False
    Public boughtmaze As Boolean = False
    Public boughtunitymodetoggle As Boolean = False
    Public boughtunitytoggleicon As Boolean = False
    Public bitnotediggergrade As Integer = 0
    Public boughtvirusscannericon As Boolean = False
    Public virusscannergrade As Integer = 0
    Public boughttextpadtrm As Boolean = False
    Public boughtshiftapplauncheritems As Boolean = False
    Public boughtadvapplauncher As Boolean = False

    
    Public Sub savegame()
        Dim savelines(2000) As String
        If boughttitlebar = True Then savelines(0) = 11 Else savelines(0) = 10
        If boughtgray = True Then savelines(1) = 11 Else savelines(1) = 10
        If boughtsecondspastmidnight = True Then savelines(2) = 11 Else savelines(2) = 10
        If boughtminutespastmidnight = True Then savelines(3) = 11 Else savelines(3) = 10
        If boughthourspastmidnight = True Then savelines(4) = 11 Else savelines(4) = 10
        If boughtcustomusername = True Then savelines(5) = 11 Else savelines(5) = 10
        If boughtwindowsanywhere = True Then savelines(6) = 11 Else savelines(6) = 10
        If boughtmultitasking = True Then savelines(7) = 11 Else savelines(7) = 10
        If boughtautoscrollterminal = True Then savelines(8) = 11 Else savelines(8) = 10
        savelines(9) = codepoints
        If boughtmovablewindows = True Then savelines(10) = 11 Else savelines(10) = 10
        If boughtdraggablewindows = True Then savelines(11) = 11 Else savelines(11) = 10
        If boughtwindowborders = True Then savelines(12) = 11 Else savelines(12) = 10
        If boughtpmandam = True Then savelines(13) = 11 Else savelines(13) = 10
        If boughtminuteaccuracytime = True Then savelines(14) = 11 Else savelines(14) = 10
        If boughtsplitsecondtime = True Then savelines(15) = 11 Else savelines(15) = 10
        If boughttitletext = True Then savelines(16) = 11 Else savelines(16) = 10
        If boughtclosebutton = True Then savelines(17) = 11 Else savelines(17) = 10
        If boughtdesktoppanel = True Then savelines(18) = 11 Else savelines(18) = 10
        If boughtclock = True Then savelines(19) = 11 Else savelines(19) = 10
        If boughtwindowedterminal = True Then savelines(20) = 11 Else savelines(20) = 10
        If boughtapplaunchermenu = True Then savelines(21) = 11 Else savelines(21) = 10
        If boughtalknowledgeinput = True Then savelines(22) = 11 Else savelines(22) = 10
        If boughtalclock = True Then savelines(23) = 11 Else savelines(23) = 10
        If boughtalshiftorium = True Then savelines(24) = 11 Else savelines(24) = 10
        If boughtapplaunchershutdown = True Then savelines(25) = 11 Else savelines(25) = 10
        If boughtdesktoppanelclock = True Then savelines(26) = 11 Else savelines(26) = 10
        If boughtterminalscrollbar = True Then savelines(27) = 11 Else savelines(27) = 10
        If boughtkiaddons = True Then savelines(28) = 11 Else savelines(28) = 10
        If boughtkicarbrands = True Then savelines(29) = 11 Else savelines(29) = 10
        If boughtkigameconsoles = True Then savelines(30) = 11 Else savelines(30) = 10
        savelines(31) = username
        If boughtshifter = True Then savelines(33) = 11 Else savelines(33) = 10
        If boughtalshifter = True Then savelines(34) = 11 Else savelines(34) = 10
        If boughtrollupcommand = True Then savelines(35) = 11 Else savelines(35) = 10
        If boughtrollupbutton = True Then savelines(36) = 11 Else savelines(36) = 10
        If boughtshiftdesktop = True Then savelines(37) = 11 Else savelines(37) = 10
        If boughtshiftpanelclock = True Then savelines(38) = 11 Else savelines(38) = 10
        If boughtshiftapplauncher = True Then savelines(39) = 11 Else savelines(39) = 10
        If boughtshiftdesktoppanel = True Then savelines(40) = 11 Else savelines(40) = 10
        If boughtshifttitlebar = True Then savelines(41) = 11 Else savelines(41) = 10
        If boughtshifttitletext = True Then savelines(42) = 11 Else savelines(42) = 10
        If boughtshifttitlebuttons = True Then savelines(43) = 11 Else savelines(43) = 10
        If boughtshiftborders = True Then savelines(44) = 11 Else savelines(44) = 10
        If boughtgray2 = True Then savelines(45) = 11 Else savelines(45) = 10
        If boughtgray3 = True Then savelines(46) = 11 Else savelines(46) = 10
        If boughtgray4 = True Then savelines(47) = 11 Else savelines(47) = 10
        If boughtanycolour = True Then savelines(48) = 11 Else savelines(48) = 10
        If boughtanycolour2 = True Then savelines(49) = 11 Else savelines(49) = 10
        If boughtanycolour3 = True Then savelines(50) = 11 Else savelines(50) = 10
        If boughtanycolour4 = True Then savelines(51) = 11 Else savelines(51) = 10
        If boughtpurple = True Then savelines(52) = 11 Else savelines(52) = 10
        If boughtpurple2 = True Then savelines(53) = 11 Else savelines(53) = 10
        If boughtpurple3 = True Then savelines(54) = 11 Else savelines(54) = 10
        If boughtpurple4 = True Then savelines(55) = 11 Else savelines(55) = 10
        If boughtblue = True Then savelines(56) = 11 Else savelines(56) = 10
        If boughtblue2 = True Then savelines(57) = 11 Else savelines(57) = 10
        If boughtblue3 = True Then savelines(58) = 11 Else savelines(58) = 10
        If boughtblue4 = True Then savelines(59) = 11 Else savelines(59) = 10
        If boughtgreen = True Then savelines(60) = 11 Else savelines(60) = 10
        If boughtgreen2 = True Then savelines(61) = 11 Else savelines(61) = 10
        If boughtgreen3 = True Then savelines(62) = 11 Else savelines(62) = 10
        If boughtgreen4 = True Then savelines(63) = 11 Else savelines(63) = 10
        If boughtyellow = True Then savelines(64) = 11 Else savelines(64) = 10
        If boughtyellow2 = True Then savelines(65) = 11 Else savelines(65) = 10
        If boughtyellow3 = True Then savelines(66) = 11 Else savelines(66) = 10
        If boughtyellow4 = True Then savelines(67) = 11 Else savelines(67) = 10
        If boughtorange = True Then savelines(68) = 11 Else savelines(68) = 10
        If boughtorange2 = True Then savelines(69) = 11 Else savelines(69) = 10
        If boughtorange3 = True Then savelines(70) = 11 Else savelines(70) = 10
        If boughtorange4 = True Then savelines(71) = 11 Else savelines(71) = 10
        If boughtbrown = True Then savelines(72) = 11 Else savelines(72) = 10
        If boughtbrown2 = True Then savelines(73) = 11 Else savelines(73) = 10
        If boughtbrown3 = True Then savelines(74) = 11 Else savelines(74) = 10
        If boughtbrown4 = True Then savelines(75) = 11 Else savelines(75) = 10
        If boughtred = True Then savelines(76) = 11 Else savelines(76) = 10
        If boughtred2 = True Then savelines(77) = 11 Else savelines(77) = 10
        If boughtred3 = True Then savelines(78) = 11 Else savelines(78) = 10
        If boughtred4 = True Then savelines(79) = 11 Else savelines(79) = 10
        If boughtpink = True Then savelines(80) = 11 Else savelines(80) = 10
        If boughtpink2 = True Then savelines(81) = 11 Else savelines(81) = 10
        If boughtpink3 = True Then savelines(82) = 11 Else savelines(82) = 10
        If boughtpink4 = True Then savelines(83) = 11 Else savelines(83) = 10
        If boughtdirectorysurfing = True Then savelines(84) = 11 Else savelines(84) = 10
        savelines(85) = osname
        If boughtbasicsettings = True Then savelines(86) = 11 Else savelines(86) = 10
        If boughtbasicgui = True Then savelines(87) = 11 Else savelines(87) = 10
        If boughtterminalsettextcolor = True Then savelines(88) = 11 Else savelines(88) = 10
        If boughtbasicwm = True Then savelines(89) = 11 Else savelines(89) = 10


        'Large gap in file. Add new features here.

        If boughtpong = True Then savelines(285) = 11 Else savelines(285) = 10
        If boughtknowledgeinputicon = True Then savelines(286) = 11 Else savelines(286) = 10
        If boughtshiftericon = True Then savelines(287) = 11 Else savelines(287) = 10
        If boughtshiftoriumicon = True Then savelines(288) = 11 Else savelines(288) = 10
        If boughtclockicon = True Then savelines(289) = 11 Else savelines(289) = 10
        If boughtshutdownicon = True Then savelines(290) = 11 Else savelines(290) = 10
        If boughtpongicon = True Then savelines(291) = 11 Else savelines(291) = 10
        If boughtterminalicon = True Then savelines(292) = 11 Else savelines(292) = 10
        If boughtalpong = True Then savelines(293) = 11 Else savelines(293) = 10
        If boughtfileskimmer = True Then savelines(294) = 11 Else savelines(294) = 10
        If boughtalfileskimmer = True Then savelines(295) = 11 Else savelines(295) = 10
        If boughttextpad = True Then savelines(296) = 11 Else savelines(296) = 10
        If boughtaltextpad = True Then savelines(297) = 11 Else savelines(297) = 10
        If boughtfileskimmericon = True Then savelines(298) = 11 Else savelines(298) = 10
        If boughttextpadicon = True Then savelines(299) = 11 Else savelines(299) = 10
        If boughttextpadnew = True Then savelines(300) = 11 Else savelines(300) = 10
        If boughttextpadsave = True Then savelines(301) = 11 Else savelines(301) = 10
        If boughttextpadopen = True Then savelines(302) = 11 Else savelines(302) = 10
        If boughtfileskimmernewfolder = True Then savelines(303) = 11 Else savelines(303) = 10
        If boughtfileskimmerdelete = True Then savelines(304) = 11 Else savelines(304) = 10
        If boughtkielements = True Then savelines(305) = 11 Else savelines(305) = 10
        If boughtcolourpickericon = True Then savelines(306) = 11 Else savelines(306) = 10
        If boughtinfoboxicon = True Then savelines(307) = 11 Else savelines(307) = 10

        'Large gap in file. More room for more features.

        If boughtskinloader = True Then savelines(314) = 11 Else savelines(314) = 10
        If boughtminimizebutton = True Then savelines(315) = 11 Else savelines(315) = 10
        If boughtpanelbuttons = True Then savelines(316) = 11 Else savelines(316) = 10
        If boughtshiftpanelbuttons = True Then savelines(317) = 11 Else savelines(317) = 10
        If boughtartpad = True Then savelines(318) = 11 Else savelines(318) = 10
        If boughtalartpad = True Then savelines(319) = 11 Else savelines(319) = 10
        If boughtartpadicon = True Then savelines(320) = 11 Else savelines(320) = 10
        If boughtskinning = True Then savelines(321) = 11 Else savelines(321) = 10
        If boughtminimizecommand = True Then savelines(322) = 11 Else savelines(322) = 10
        If boughtusefulpanelbuttons = True Then savelines(323) = 11 Else savelines(323) = 10
        If boughtunitymode = True Then savelines(324) = 11 Else savelines(324) = 10
        If boughtartpadpixellimit4 = True Then savelines(325) = 11 Else savelines(325) = 10
        If boughtartpadpixellimit8 = True Then savelines(326) = 11 Else savelines(326) = 10
        If boughtartpadpixellimit16 = True Then savelines(327) = 11 Else savelines(327) = 10
        If boughtartpadpixellimit64 = True Then savelines(328) = 11 Else savelines(328) = 10
        If boughtartpadpixellimit256 = True Then savelines(329) = 11 Else savelines(329) = 10
        If boughtartpadpixellimit1024 = True Then savelines(330) = 11 Else savelines(330) = 10
        If boughtartpadpixellimit4096 = True Then savelines(331) = 11 Else savelines(331) = 10
        If boughtartpadpixellimit16384 = True Then savelines(332) = 11 Else savelines(332) = 10
        If boughtartpadpixellimit65536 = True Then savelines(333) = 11 Else savelines(333) = 10
        If boughtartpadlimitlesspixels = True Then savelines(334) = 11 Else savelines(334) = 10
        If boughtartpad4colorpallets = True Then savelines(335) = 11 Else savelines(335) = 10
        If boughtartpad8colorpallets = True Then savelines(336) = 11 Else savelines(336) = 10
        If boughtartpad16colorpallets = True Then savelines(337) = 11 Else savelines(337) = 10
        If boughtartpad32colorpallets = True Then savelines(338) = 11 Else savelines(338) = 10
        If boughtartpad64colorpallets = True Then savelines(339) = 11 Else savelines(339) = 10
        If boughtartpad128colorpallets = True Then savelines(340) = 11 Else savelines(340) = 10
        If boughtartpadcustompallets = True Then savelines(341) = 11 Else savelines(341) = 10
        If boughtartpadpixelplacer = True Then savelines(342) = 11 Else savelines(342) = 10
        If boughtartpadpixelplacermovementmode = True Then savelines(343) = 11 Else savelines(343) = 10
        If boughtartpadpencil = True Then savelines(344) = 11 Else savelines(344) = 10
        If boughtartpadpaintbrush = True Then savelines(345) = 11 Else savelines(345) = 10
        If boughtartpadlinetool = True Then savelines(346) = 11 Else savelines(346) = 10
        If boughtartpadovaltool = True Then savelines(347) = 11 Else savelines(347) = 10
        If boughtartpadrectangletool = True Then savelines(348) = 11 Else savelines(348) = 10
        If boughtartpaderaser = True Then savelines(349) = 11 Else savelines(349) = 10
        If boughtartpadfilltool = True Then savelines(350) = 11 Else savelines(350) = 10
        If boughtartpadtexttool = True Then savelines(351) = 11 Else savelines(351) = 10
        If boughtartpadundo = True Then savelines(352) = 11 Else savelines(352) = 10
        If boughtartpadredo = True Then savelines(353) = 11 Else savelines(353) = 10
        If boughtartpadsave = True Then savelines(354) = 11 Else savelines(354) = 10
        If boughtartpadload = True Then savelines(355) = 11 Else savelines(355) = 10
        If boughtartpadnew = True Then savelines(484) = 11 Else savelines(484) = 10
        '0.0.8
        'savelines(485) = ingameversion - Not yet implemented, will be soon.
        If boughtresizablewindows Then savelines(486) = 11 Else savelines(486) = 10
        If boughtcalculator Then savelines(487) = 11 Else savelines(487) = 10
        If boughtaudioplayer Then savelines(488) = 11 Else savelines(488) = 10
        If boughtchangeosnamecommand Then savelines(489) = 11 Else savelines(489) = 10
        If boughtwebbrowser Then savelines(490) = 11 Else savelines(490) = 10
        If boughtvideoplayer Then savelines(491) = 11 Else savelines(491) = 10
        If boughtnamechanger Then savelines(492) = 11 Else savelines(492) = 10
        If boughticonmanager Then savelines(493) = 11 Else savelines(493) = 10
        If boughtbitnotewallet Then savelines(494) = 11 Else savelines(494) = 10
        If boughtbitnotedigger Then savelines(495) = 11 Else savelines(495) = 10
        If boughtskinshifter Then savelines(496) = 11 Else savelines(496) = 10
        If boughtshiftnet Then savelines(497) = 11 Else savelines(497) = 10
        If boughtshiftneticon Then savelines(498) = 11 Else savelines(498) = 10
        If boughtalshiftnet Then savelines(499) = 11 Else savelines(499) = 10
        If boughtdodge Then savelines(500) = 11 Else savelines(500) = 10
        If boughtdownloadmanager Then savelines(501) = 11 Else savelines(501) = 10
        If boughtinstaller Then savelines(502) = 11 Else savelines(502) = 10
        If boughtsysinfoicon Then savelines(503) = 11 Else savelines(503) = 10
        If boughtorcwrite Then savelines(504) = 11 Else savelines(504) = 10
        If boughtfloodgate Then savelines(505) = 11 Else savelines(505) = 10
        If boughtmaze Then savelines(506) = 11 Else savelines(506) = 10
        If boughtunitymodetoggle Then savelines(507) = 11 Else savelines(507) = 10
        If boughtunitytoggleicon Then savelines(508) = 11 Else savelines(508) = 10
        savelines(509) = bitnotediggergrade
        If boughtvirusscannericon Then savelines(510) = 11 Else savelines(510) = 10
        savelines(511) = virusscannergrade
        If boughttextpadtrm Then savelines(512) = 11 Else savelines(512) = 10
        If boughtshiftapplauncheritems Then savelines(513) = 11 Else savelines(513) = 10

        
        IO.File.WriteAllLines(save, savelines)
    End Sub

   

    Public Sub loadgame()
        Try
            Dim loadlines() As String = IO.File.ReadAllLines(save)
            If loadlines(0) = 11 Then boughttitlebar = True Else boughttitlebar = False
            If loadlines(1) = 11 Then boughtgray = True Else boughtgray = False
            If loadlines(2) = 11 Then boughtsecondspastmidnight = True Else boughtsecondspastmidnight = False
            If loadlines(3) = 11 Then boughtminutespastmidnight = True Else boughtminutespastmidnight = False
            If loadlines(4) = 11 Then boughthourspastmidnight = True Else boughthourspastmidnight = False
            If loadlines(5) = 11 Then boughtcustomusername = True Else boughtcustomusername = False
            If loadlines(6) = 11 Then boughtwindowsanywhere = True Else boughtwindowsanywhere = False
            If loadlines(7) = 11 Then boughtmultitasking = True Else boughtmultitasking = False
            If loadlines(8) = 11 Then boughtautoscrollterminal = True Else boughtautoscrollterminal = False
            codepoints = loadlines(9)
            If loadlines(10) = 11 Then boughtmovablewindows = True Else boughtmovablewindows = False
            If loadlines(11) = 11 Then boughtdraggablewindows = True Else boughtdraggablewindows = False
            If loadlines(12) = 11 Then boughtwindowborders = True Else boughtwindowborders = False
            If loadlines(13) = 11 Then boughtpmandam = True Else boughtpmandam = False
            If loadlines(14) = 11 Then boughtminuteaccuracytime = True Else boughtminuteaccuracytime = False
            If loadlines(15) = 11 Then boughtsplitsecondtime = True Else boughtsplitsecondtime = False
            If loadlines(16) = 11 Then boughttitletext = True Else boughttitletext = False
            If loadlines(17) = 11 Then boughtclosebutton = True Else boughtclosebutton = False
            If loadlines(18) = 11 Then boughtdesktoppanel = True Else boughtdesktoppanel = False
            If loadlines(19) = 11 Then boughtclock = True Else boughtclock = False
            If loadlines(20) = 11 Then boughtwindowedterminal = True Else boughtwindowedterminal = False
            If loadlines(21) = 11 Then boughtapplaunchermenu = True Else boughtapplaunchermenu = False
            If loadlines(22) = 11 Then boughtalknowledgeinput = True Else boughtalknowledgeinput = False
            If loadlines(23) = 11 Then boughtalclock = True Else boughtalclock = False
            If loadlines(24) = 11 Then boughtalshiftorium = True Else boughtalshiftorium = False
            If loadlines(25) = 11 Then boughtapplaunchershutdown = True Else boughtapplaunchershutdown = False
            If loadlines(26) = 11 Then boughtdesktoppanelclock = True Else boughtdesktoppanelclock = False
            If loadlines(27) = 11 Then boughtterminalscrollbar = True Else boughtterminalscrollbar = False
            If loadlines(28) = 11 Then boughtkiaddons = True Else boughtkiaddons = False
            If loadlines(29) = 11 Then boughtkicarbrands = True Else boughtkicarbrands = False
            If loadlines(30) = 11 Then boughtkigameconsoles = True Else boughtkigameconsoles = False
            username = loadlines(31)
            If loadlines(33) = 11 Then boughtshifter = True Else boughtshifter = False
            If loadlines(34) = 11 Then boughtalshifter = True Else boughtalshifter = False
            If loadlines(35) = 11 Then boughtrollupcommand = True Else boughtrollupcommand = False
            If loadlines(36) = 11 Then boughtrollupbutton = True Else boughtrollupbutton = False
            If loadlines(37) = 11 Then boughtshiftdesktop = True Else boughtshiftdesktop = False
            If loadlines(38) = 11 Then boughtshiftpanelclock = True Else boughtshiftpanelclock = False
            If loadlines(39) = 11 Then boughtshiftapplauncher = True Else boughtshiftapplauncher = False
            If loadlines(40) = 11 Then boughtshiftdesktoppanel = True Else boughtshiftdesktoppanel = False
            If loadlines(41) = 11 Then boughtshifttitlebar = True Else boughtshifttitlebar = False
            If loadlines(42) = 11 Then boughtshifttitletext = True Else boughtshifttitletext = False
            If loadlines(43) = 11 Then boughtshifttitlebuttons = True Else boughtshifttitlebuttons = False
            If loadlines(44) = 11 Then boughtshiftborders = True Else boughtshiftborders = False
            If loadlines(45) = 11 Then boughtgray2 = True Else boughtgray2 = False
            If loadlines(46) = 11 Then boughtgray3 = True Else boughtgray3 = False
            If loadlines(47) = 11 Then boughtgray4 = True Else boughtgray4 = False
            If loadlines(48) = 11 Then boughtanycolour = True Else boughtanycolour = False
            If loadlines(49) = 11 Then boughtanycolour2 = True Else boughtanycolour2 = False
            If loadlines(50) = 11 Then boughtanycolour3 = True Else boughtanycolour3 = False
            If loadlines(51) = 11 Then boughtanycolour4 = True Else boughtanycolour4 = False
            If loadlines(52) = 11 Then boughtpurple = True Else boughtpurple = False
            If loadlines(53) = 11 Then boughtpurple2 = True Else boughtpurple2 = False
            If loadlines(54) = 11 Then boughtpurple3 = True Else boughtpurple3 = False
            If loadlines(55) = 11 Then boughtpurple4 = True Else boughtpurple4 = False
            If loadlines(56) = 11 Then boughtblue = True Else boughtblue = False
            If loadlines(57) = 11 Then boughtblue2 = True Else boughtblue2 = False
            If loadlines(58) = 11 Then boughtblue3 = True Else boughtblue3 = False
            If loadlines(59) = 11 Then boughtblue4 = True Else boughtblue4 = False
            If loadlines(60) = 11 Then boughtgreen = True Else boughtgreen = False
            If loadlines(61) = 11 Then boughtgreen2 = True Else boughtgreen2 = False
            If loadlines(62) = 11 Then boughtgreen3 = True Else boughtgreen3 = False
            If loadlines(63) = 11 Then boughtgreen4 = True Else boughtgreen4 = False
            If loadlines(64) = 11 Then boughtyellow = True Else boughtyellow = False
            If loadlines(65) = 11 Then boughtyellow2 = True Else boughtyellow2 = False
            If loadlines(66) = 11 Then boughtyellow3 = True Else boughtyellow3 = False
            If loadlines(67) = 11 Then boughtyellow4 = True Else boughtyellow4 = False
            If loadlines(68) = 11 Then boughtorange = True Else boughtorange = False
            If loadlines(69) = 11 Then boughtorange2 = True Else boughtorange2 = False
            If loadlines(70) = 11 Then boughtorange3 = True Else boughtorange3 = False
            If loadlines(71) = 11 Then boughtorange4 = True Else boughtorange4 = False
            If loadlines(72) = 11 Then boughtbrown = True Else boughtbrown = False
            If loadlines(73) = 11 Then boughtbrown2 = True Else boughtbrown2 = False
            If loadlines(74) = 11 Then boughtbrown3 = True Else boughtbrown3 = False
            If loadlines(75) = 11 Then boughtbrown4 = True Else boughtbrown4 = False
            If loadlines(76) = 11 Then boughtred = True Else boughtred = False
            If loadlines(77) = 11 Then boughtred2 = True Else boughtred2 = False
            If loadlines(78) = 11 Then boughtred3 = True Else boughtred3 = False
            If loadlines(79) = 11 Then boughtred4 = True Else boughtred4 = False
            If loadlines(80) = 11 Then boughtpink = True Else boughtpink = False
            If loadlines(81) = 11 Then boughtpink2 = True Else boughtpink2 = False
            If loadlines(82) = 11 Then boughtpink3 = True Else boughtpink3 = False
            If loadlines(83) = 11 Then boughtpink4 = True Else boughtpink4 = False
            If loadlines(84) = 11 Then boughtdirectorysurfing = True Else boughtdirectorysurfing = False
            osname = loadlines(85)
            If loadlines(86) = 11 Then boughtbasicsettings = True Else boughtbasicsettings = False
            If loadlines(87) = 11 Then boughtbasicgui = True Else boughtbasicgui = False
            If loadlines(88) = 11 Then boughtterminalsettextcolor = True Else boughtterminalsettextcolor = False
            If loadlines(89) = 11 Then boughtbasicwm = True Else boughtbasicwm = False







            'Add appropriate features here.

            If loadlines(285) = 11 Then boughtpong = True Else boughtpong = False
            If loadlines(286) = 11 Then boughtknowledgeinputicon = True Else boughtknowledgeinputicon = False
            If loadlines(287) = 11 Then boughtshiftericon = True Else boughtshiftericon = False
            If loadlines(288) = 11 Then boughtshiftoriumicon = True Else boughtshiftoriumicon = False
            If loadlines(289) = 11 Then boughtclockicon = True Else boughtclockicon = False
            If loadlines(290) = 11 Then boughtshutdownicon = True Else boughtshutdownicon = False
            If loadlines(291) = 11 Then boughtpongicon = True Else boughtpongicon = False
            If loadlines(292) = 11 Then boughtterminalicon = True Else boughtterminalicon = False
            If loadlines(293) = 11 Then boughtalpong = True Else boughtalpong = False
            If loadlines(294) = 11 Then boughtfileskimmer = True Else boughtfileskimmer = False
            If loadlines(295) = 11 Then boughtalfileskimmer = True Else boughtalfileskimmer = False
            If loadlines(296) = 11 Then boughttextpad = True Else boughttextpad = False
            If loadlines(297) = 11 Then boughtaltextpad = True Else boughtaltextpad = False
            If loadlines(298) = 11 Then boughtfileskimmericon = True Else boughtfileskimmericon = False
            If loadlines(299) = 11 Then boughttextpadicon = True Else boughttextpadicon = False
            If loadlines(300) = 11 Then boughttextpadnew = True Else boughttextpadnew = False
            If loadlines(301) = 11 Then boughttextpadsave = True Else boughttextpadsave = False
            If loadlines(302) = 11 Then boughttextpadopen = True Else boughttextpadopen = False
            If loadlines(303) = 11 Then boughtfileskimmernewfolder = True Else boughtfileskimmernewfolder = False
            If loadlines(304) = 11 Then boughtfileskimmerdelete = True Else boughtfileskimmerdelete = False
            If loadlines(305) = 11 Then boughtkielements = True Else boughtkielements = False
            If loadlines(306) = 11 Then boughtcolourpickericon = True Else boughtcolourpickericon = False
            If loadlines(307) = 11 Then boughtinfoboxicon = True Else boughtinfoboxicon = False

            'Add appropriate features here

            If loadlines(314) = 11 Then boughtskinloader = True Else boughtskinloader = False
            If loadlines(315) = 11 Then boughtminimizebutton = True Else boughtminimizebutton = False
            If loadlines(316) = 11 Then boughtpanelbuttons = True Else boughtpanelbuttons = False
            If loadlines(317) = 11 Then boughtshiftpanelbuttons = True Else boughtshiftpanelbuttons = False
            If loadlines(318) = 11 Then boughtartpad = True Else boughtartpad = False
            If loadlines(319) = 11 Then boughtalartpad = True Else boughtalartpad = False
            If loadlines(320) = 11 Then boughtartpadicon = True Else boughtartpadicon = False
            If loadlines(321) = 11 Then boughtskinning = True Else boughtskinning = False
            If loadlines(322) = 11 Then boughtminimizecommand = True Else boughtminimizecommand = False
            If loadlines(323) = 11 Then boughtusefulpanelbuttons = True Else boughtusefulpanelbuttons = False
            If loadlines(324) = 11 Then boughtunitymode = True Else boughtunitymode = False
            If loadlines(325) = 11 Then boughtartpadpixellimit4 = True Else boughtartpadpixellimit4 = False
            If loadlines(326) = 11 Then boughtartpadpixellimit8 = True Else boughtartpadpixellimit8 = False
            If loadlines(327) = 11 Then boughtartpadpixellimit16 = True Else boughtartpadpixellimit16 = False
            If loadlines(328) = 11 Then boughtartpadpixellimit64 = True Else boughtartpadpixellimit64 = False
            If loadlines(329) = 11 Then boughtartpadpixellimit256 = True Else boughtartpadpixellimit256 = False
            If loadlines(330) = 11 Then boughtartpadpixellimit1024 = True Else boughtartpadpixellimit1024 = False
            If loadlines(331) = 11 Then boughtartpadpixellimit4096 = True Else boughtartpadpixellimit4096 = False
            If loadlines(332) = 11 Then boughtartpadpixellimit16384 = True Else boughtartpadpixellimit16384 = False
            If loadlines(333) = 11 Then boughtartpadpixellimit65536 = True Else boughtartpadpixellimit65536 = False
            If loadlines(334) = 11 Then boughtartpadlimitlesspixels = True Else boughtartpadlimitlesspixels = False
            If loadlines(335) = 11 Then boughtartpad4colorpallets = True Else boughtartpad4colorpallets = False
            If loadlines(336) = 11 Then boughtartpad8colorpallets = True Else boughtartpad8colorpallets = False
            If loadlines(337) = 11 Then boughtartpad16colorpallets = True Else boughtartpad16colorpallets = False
            If loadlines(338) = 11 Then boughtartpad32colorpallets = True Else boughtartpad32colorpallets = False
            If loadlines(339) = 11 Then boughtartpad64colorpallets = True Else boughtartpad64colorpallets = False
            If loadlines(340) = 11 Then boughtartpad128colorpallets = True Else boughtartpad128colorpallets = False
            If loadlines(341) = 11 Then boughtartpadcustompallets = True Else boughtartpadcustompallets = False
            If loadlines(342) = 11 Then boughtartpadpixelplacer = True Else boughtartpadpixelplacer = False
            If loadlines(343) = 11 Then boughtartpadpixelplacermovementmode = True Else boughtartpadpixelplacermovementmode = False
            If loadlines(344) = 11 Then boughtartpadpencil = True Else boughtartpadpencil = False
            If loadlines(345) = 11 Then boughtartpadpaintbrush = True Else boughtartpadpaintbrush = False
            If loadlines(346) = 11 Then boughtartpadlinetool = True Else boughtartpadlinetool = False
            If loadlines(347) = 11 Then boughtartpadovaltool = True Else boughtartpadovaltool = False
            If loadlines(348) = 11 Then boughtartpadrectangletool = True Else boughtartpadrectangletool = False
            If loadlines(349) = 11 Then boughtartpaderaser = True Else boughtartpaderaser = False
            If loadlines(350) = 11 Then boughtartpadfilltool = True Else boughtartpadfilltool = False
            If loadlines(351) = 11 Then boughtartpadtexttool = True Else boughtartpadtexttool = False
            If loadlines(352) = 11 Then boughtartpadundo = True Else boughtartpadundo = False
            If loadlines(353) = 11 Then boughtartpadredo = True Else boughtartpadredo = False
            If loadlines(354) = 11 Then boughtartpadsave = True Else boughtartpadsave = False
            If loadlines(355) = 11 Then boughtartpadload = True Else boughtartpadload = False
            If loadlines(484) = "" Then  Else If loadlines(484) = 11 Then boughtartpadnew = True Else boughtartpadnew = False
            'Not yet implemented! ingameversion = loadlines(485)
            If loadlines(486) = 11 Then boughtresizablewindows = True Else boughtresizablewindows = False
            If loadlines(487) = 11 Then boughtcalculator = True Else boughtcalculator = False
            If loadlines(488) = 11 Then boughtaudioplayer = True Else boughtaudioplayer = False
            If loadlines(489) = 11 Then boughtchangeosnamecommand = True Else boughtchangeosnamecommand = False
            If loadlines(490) = 11 Then boughtwebbrowser = True Else boughtwebbrowser = False
            If loadlines(491) = 11 Then boughtvideoplayer = True Else boughtvideoplayer = False
            If loadlines(492) = 11 Then boughtnamechanger = True Else boughtnamechanger = False
            If loadlines(493) = 11 Then boughticonmanager = True Else boughticonmanager = False
            If loadlines(494) = 11 Then boughtbitnotewallet = True Else boughtbitnotewallet = False
            If loadlines(495) = 11 Then boughtbitnotedigger = True Else boughtbitnotedigger = False
            If loadlines(496) = 11 Then boughtskinshifter = True Else boughtskinshifter = False
            If loadlines(497) = 11 Then boughtshiftnet = True Else boughtshiftnet = False
            If loadlines(498) = 11 Then boughtshiftneticon = True Else boughtshiftneticon = False
            If loadlines(499) = 11 Then boughtalshiftnet = True Else boughtalshiftnet = False
            If loadlines(500) = 11 Then boughtdodge = True Else boughtdodge = False
            If loadlines(501) = 11 Then boughtdownloadmanager = True Else boughtdownloadmanager = False
            If loadlines(502) = 11 Then boughtinstaller = True Else boughtinstaller = False
            If loadlines(503) = 11 Then boughtsysinfoicon = True Else boughtsysinfoicon = False
            If loadlines(504) = 11 Then boughtorcwrite = True Else boughtorcwrite = False
            If loadlines(505) = 11 Then boughtfloodgate = True Else boughtfloodgate = False
            If loadlines(506) = 11 Then boughtmaze = True Else boughtmaze = False
            If loadlines(507) = 11 Then boughtunitymodetoggle = True Else boughtunitymodetoggle = False
            If loadlines(508) = 11 Then boughtunitytoggleicon = True Else boughtunitytoggleicon = False
            bitnotediggergrade = loadlines(509)
            If loadlines(510) = 11 Then boughtvirusscannericon = True Else boughtvirusscannericon = False
            virusscannergrade = loadlines(511)
            If loadlines(512) = 11 Then boughttextpadtrm = True Else boughttextpadtrm = False
            If loadlines(513) = 11 Then boughtshiftapplauncheritems = True Else boughtshiftapplauncheritems = False
        Catch ex As Exception
            prompttoupdatesave = True
        End Try
    End Sub


End Module
