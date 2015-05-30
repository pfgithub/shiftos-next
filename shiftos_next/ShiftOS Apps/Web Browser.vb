Imports Skybound.Gecko

Public Class Web_Browser
    Public rolldownsize As Integer
    Public oldbordersize As Integer
    Public oldtitlebarheight As Integer
    Public justopened As Boolean = False
    Public needtorollback As Boolean = False
    Public minimumsizewidth As Integer = 696
    Public minimumsizeheight As Integer = 300



    'To re add gecko, replace all refrences to WebBrowser with Skybound.Gecko.GeckoWebBrowser. I would do it but i dont have the files! 

    Public Sub addtab()
        Dim tab As New TabPage
        Dim brwsr As New WebBrowser 'NEEDS TO CHANGE TO GECKO OR WEBKIT
        tabs.TabPages.Add(tab)
        tab.Controls.Add(brwsr)
        brwsr.Dock = DockStyle.Fill
        tabs.SelectedTab = tab
        brwsr.Navigate("http://www.google.com")
    End Sub

    Private Sub btnAddTab_Click(sender As Object, e As EventArgs) Handles btnAddTab.Click
        addtab()
    End Sub

    Private Sub TabText_Tick(sender As Object, e As EventArgs) Handles TabText.Tick
        For Each opentab As TabPage In tabs.TabPages
            For Each browser As WebBrowser In opentab.Controls
                opentab.Text = browser.DocumentTitle
            Next
        Next
    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Try
            CType(tabs.SelectedTab.Controls.Item(0), WebBrowser).GoBack()
        Catch
        End Try
    End Sub

    Private Sub UrlText_Tick(sender As Object, e As EventArgs) Handles UrlText.Tick
        Try
            txtlocation.Text = (CType(tabs.SelectedTab.Controls.Item(0), WebBrowser).Url.AbsoluteUri.ToString)
        Catch
        End Try
    End Sub

    Private Sub txtlocation_Click(sender As Object, e As EventArgs) Handles txtlocation.Click
        txtlocation.Text = ""
        UrlText.Stop()
    End Sub

    Private Sub txtlocation_LostFocus(sender As Object, e As EventArgs) Handles txtlocation.LostFocus
        UrlText.Start()
    End Sub

    Private Sub btnforward_Click(sender As Object, e As EventArgs) Handles btnforward.Click
        Try
            CType(tabs.SelectedTab.Controls.Item(0), WebBrowser).GoForward()
        Catch
        End Try
    End Sub

    Private Sub btnhome_Click(sender As Object, e As EventArgs) Handles btnhome.Click
        If tabs.TabCount > 1 Then
            Try
                CType(tabs.SelectedTab.Controls.Item(0), WebBrowser).Navigate("http://www.google.com")
            Catch
            End Try
        Else
            addtab()
            Try
                CType(tabs.SelectedTab.Controls.Item(0), WebBrowser).Navigate("http://www.google.com")
            Catch
            End Try
        End If
    End Sub

    Private Sub Web_Browser_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles Me.PreviewKeyDown

    End Sub

    Private Sub txtlocation_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles txtlocation.PreviewKeyDown
        If tabs.TabCount > 1 Then
            If e.KeyCode = Keys.Enter Then
                CType(tabs.SelectedTab.Controls.Item(0), WebBrowser).Navigate(txtlocation.Text)
            End If
        Else
            If e.KeyCode = Keys.Enter Then
                addtab()
                CType(tabs.SelectedTab.Controls.Item(0), WebBrowser).Navigate(txtlocation.Text)
            End If
        End If
    End Sub

    Private Sub btnRemTab_Click(sender As Object, e As EventArgs) Handles btnRemTab.Click
        If tabs.TabCount > 1 Then
            tabs.Controls.Remove(tabs.SelectedTab)
        Else
            tabs.Controls.Remove(tabs.SelectedTab)
            Me.Close()
        End If
    End Sub
   
    Private Sub Progress_Tick(sender As Object, e As EventArgs) Handles Progress.Tick
        'BrowserProgress.MaxValue = (CType(tabs.SelectedTab.Controls.Item(0), WebBrowser)
    End Sub
End Class