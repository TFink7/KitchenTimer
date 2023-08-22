Public Class MinutesCounter
    Private Seconds As SecondsCounter

    'increase counter by Minutes
    Public Sub IncreaseBy(increment As Integer)
        If increment + Value <= MaxValue Then
            SetValue(increment + Value)
        Else
            SetToMax()
        End If
    End Sub
    'decrement counter by timer interval
    Public Sub decrement()
        If Not IsZero() Then
            SetValue(Value - 1)
        End If
    End Sub

    'Set Seconds Counter
    Public Sub SetSecondsCounter(ByRef newcounter As SecondsCounter)
        Seconds = newcounter
    End Sub


End Class
