Public MustInherit Class Counter
    Private _MaxValue As Integer
    Private _value As Integer

    'maxvalue get and set
    Public Property MaxValue() As Integer
        Get
            Return _MaxValue
        End Get
        Set(ByVal tempval As Integer)
            _MaxValue = tempval
        End Set
    End Property

    'Value get and set
    Public Property Value() As Integer
        Get
            Return _value
        End Get
        Set(ByVal tempval As Integer)
            _value = tempval
        End Set
    End Property

    Public Sub SetValue(newvalue As Integer)
        'If newvalue <= MaxValue Then
        Value = newvalue
        Text = Value.ToString("00")
        'Else
        'Value = newvalue - 60
        'Text = Value.ToString("00")
        'End If
    End Sub

    'Method to check if counter at max
    Public Function IsMax() As Boolean
        Return Value >= MaxValue
    End Function

    'Method to check if counter is at zero
    Public Function IsZero() As Boolean
        Return Value = 0
    End Function

    'Method to reset counter
    Public Sub Reset()
        Value = 0
        Text = Value.ToString("00")
    End Sub

    'Set Max Value
    Public Sub SetToMax()
        Value = MaxValue
        Text = Value.ToString("00")
    End Sub



End Class



