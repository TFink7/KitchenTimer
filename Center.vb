'Tomer Finkelson 500585496

Public Class Center
    Private Sub Center_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackLeft.SelectMe()
    End Sub


    Private Sub TopLeft_clickTimer(sender As Object, e As EventArgs)

    End Sub

    Private Sub TopRight_clickTimer(sender As Object, e As EventArgs)

    End Sub

    Private Sub BottomLeft_clickTimer(sender As Object, e As EventArgs)

    End Sub

    Private Sub BottomRight_clickTimer(sender As Object, e As EventArgs)

    End Sub

    Private Sub Seconds_Click(sender As Object, e As EventArgs) Handles SecondButton.Click, ThreeSecond.Click, TenSecond.Click
        SingleTimer.AddSecondsToSelected(ActiveControl.Tag)
    End Sub

    Private Sub Minutes_Click(sender As Object, e As EventArgs) Handles MinuteButton.Click, ThreeMinute.Click, TenMinute.Click
        SingleTimer.AddMinutesToSelected(ActiveControl.Tag)
    End Sub

    Private Sub BackLeft_Load(sender As Object, e As EventArgs) Handles BackLeft.Load

    End Sub
End Class
