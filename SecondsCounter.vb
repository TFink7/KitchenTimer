Public Class SecondsCounter
    Private minutes As MinutesCounter

    'Increase Counter by seconds
    Public Sub IncreaseBy(increment As Integer)
        If increment + Value <= MaxValue Then
            SetValue(increment + Value)
        ElseIf increment + Value >= 60 And Not minutes.IsMax() Then
            SetValue(increment + Value - 60)
            minutes.SetValue(1 + minutes.Value)
        Else
            minutes.SetToMax()
            SetToMax()
        End If
    End Sub

    'Set Minutes Counter
    Public Sub SetMinutesCounter(ByRef newcounter As MinutesCounter)
        minutes = newcounter
    End Sub

    'Decrement Counter
    Public Sub decrement()
        If Value - 1 <= 0 And Not minutes.IsZero Then
            minutes.decrement()
            Value = 59
            Text = Value.ToString("00")
        ElseIf IsZero() And minutes.IsZero Then
            SetValue(0)
        Else
            SetValue(Value - 1)
        End If

    End Sub



End Class
