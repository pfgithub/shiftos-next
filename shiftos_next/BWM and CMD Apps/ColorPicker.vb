Namespace BasicWM
    Public Class ColorPicker

        Public Color As Color
        Public oldcolor As Color

        Private Sub btnwhite_Click(sender As Object, e As EventArgs) Handles btnwhite.Click, btnblack.Click, btngray.Click, btnlightgray.Click, btndarkgray.Click, btnred.Click, btngreen.Click, btnblue.Click, btnyellow.Click, btnorange.Click, btnpink.Click, btnpurple.Click, btnbrown.Click
            Color = sender.backcolor
            lbselectedcolor.Text = "Selected color: " & Color.ToKnownColor.ToString
        End Sub

        Private Sub btnok_Click(sender As Object, e As EventArgs) Handles btnok.Click
            Me.Close()
        End Sub

        Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
            Color = oldcolor
            Me.Close()
        End Sub

        Private Sub ColorPicker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            loadcolors()
        End Sub


        Public Sub loadcolors()
            If boughtgray Then btngray.Show()
            If boughtred Then btnred.Show()
            If boughtgreen Then btngreen.Show()
            If boughtblue Then btnblue.Show()
            If boughtyellow Then btnyellow.Show()
            If boughtorange Then btnorange.Show()
            If boughtpink Then btnpink.Show()
            If boughtpurple Then btnpurple.Show()
            If boughtbrown Then btnbrown.Show()
            If boughtgray2 Then
                btnlightgray.Show()
                btndarkgray.Show()
            End If
        End Sub

    End Class
End Namespace