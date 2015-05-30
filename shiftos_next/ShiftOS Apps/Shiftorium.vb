Imports System.IO

Public Class Shiftorium
    Public rolldownsize As Integer
    Public oldbordersize As Integer
    Public oldtitlebarheight As Integer
    Public justopened As Boolean = False
    Public needtorollback As Boolean = False
    Public minimumsizewidth As Integer = 0
    Public minimumsizeheight As Integer = 0

    Dim pricegrab As String
    Dim started As Boolean = False
    Dim fs As FileStream





    Private Sub lbupgrades_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles lbupgrades.DrawItem
        e.DrawBackground()
        If (e.State And DrawItemState.Selected) = DrawItemState.Selected Then
            e.Graphics.FillRectangle(Brushes.Black, e.Bounds)
        End If
        Dim sf As New StringFormat
        sf.Alignment = StringAlignment.Center
        On Error Resume Next
        Using b As New SolidBrush(e.ForeColor)
            e.Graphics.DrawString(lbupgrades.GetItemText(lbupgrades.Items(e.Index)), e.Font, b, e.Bounds, sf)
        End Using
        e.DrawFocusRectangle()
    End Sub


    Private Sub handlebuy(ByVal name As String, ByRef bought As Boolean, ByVal boughttutorial As String)

        On Error Resume Next
        If lbupgrades.SelectedItem.ToString = name Then
            If btnbuy.Text = "Buy" Then
                If name = "Title Bar - 80 CP" Then Skins.setupdefaults()
                pricegrab = lbprice.Text.Substring(0, lbprice.Text.Length - 3)
                DeductCP(Convert.ToInt32(pricegrab))
                bought = True
                lbupgradename.Font = New Font("teen", 13, FontStyle.Bold)
                lbupgradename.Text = "Purchased " & lbupgrades.SelectedItem.ToString.Substring(0, lbupgrades.SelectedItem.ToString.IndexOf("-"))
                lbudescription.Text = boughttutorial
                lbudescription.Size = New Size(321, 180)
                lbudescription.Location = New Point(24, 47)
                lbprice.Size = New Size(340, 49)
                lbprice.Location = New Point(10, 372)
                lbprice.Font = New Font("teen", 16, FontStyle.Bold)
                picpreview.Location = New Point(25, 237)
                lbprice.Text = "Bought for " & lbprice.Text.Substring(0, lbprice.Text.IndexOf(" ")) & " codepoints"
                btnbuy.Hide()
                lbupgradename.Location = New Point(5, 10)
            End If
        End If
    End Sub

    Private Sub handleupgradedescription(ByVal itemname As String, ByVal itempic As Image, ByVal itemdescription As String)
        On Error Resume Next
        If lbupgrades.SelectedItem.ToString = itemname Then
            lbupgradename.Font = New Font("teen", 20, FontStyle.Bold)
            lbupgradename.Text = lbupgrades.SelectedItem.ToString.Substring(0, lbupgrades.SelectedItem.ToString.IndexOf("-"))
            lbudescription.Text = itemdescription
            picpreview.Image = itempic
            lbprice.Text = lbupgrades.SelectedItem.ToString.Substring(lbupgrades.SelectedItem.ToString.IndexOf("-") + 2, lbupgrades.SelectedItem.ToString.Length - lbupgradename.Text.Length - 2)
            lbprice.Size = New Size(139, 59)
            lbprice.Location = New Point(3, 362)
            lbprice.Font = New Font("teen", 26, FontStyle.Bold)
            picpreview.Location = New Point(25, 218)
            lbudescription.Location = New Point(24, 61)
            lbudescription.Size = New Size(321, 144)
            lbupgradename.Location = New Point(5, 17)
            btnbuy.Show()
            If codepoints > Convert.ToInt32(lbprice.Text.Substring(0, lbprice.Text.Length - 3) - 1) Then
                btnbuy.Text = "Buy"
            Else
                btnbuy.Text = "Can't Afford"
            End If
        End If
    End Sub

    Private Sub tmrcodepointsupdate_Tick(sender As Object, e As EventArgs) Handles tmrcodepointsupdate.Tick
        lbcodepoints.Text = "Codepoints: " & codepoints
    End Sub

    End Class