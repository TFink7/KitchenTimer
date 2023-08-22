Public Class SingleTimer
    Private _Title As String
    Private Shared _SelectedTimer() As Boolean = {False, False, False, False}
    Private _frequency As Integer
    Private _beeps As Integer
    Private _countdown As Boolean = False



    'Get/Set for Title of Radio Button
    Public Property Title() As String
        Get
            Return _Title
        End Get
        Set
            _Title = Value
            RadioButton1.Text() = _Title
        End Set
    End Property

    'Get/Set for Frequency of Timer Beep
    Public Property Frequency() As Integer
        Get
            Return _frequency
        End Get
        Set
            _frequency = Value
        End Set
    End Property

    'Get/Set for duration of beeps
    Public Property Beeps() As Integer
        Get
            Return _beeps
        End Get
        Set
            _beeps = Value
        End Set
    End Property

    'Method to deselect the radio button
    Private Sub DeselectMe()
        RadioButton1.Checked = False
        _SelectedTimer(Tag) = False
        SetLook()
    End Sub
    'Method to select the radio button
    Public Sub SelectMe()
        If _SelectedTimer(Tag) = False Then
            For Each singletimer In Center.Controls.OfType(Of SingleTimer)
                If _SelectedTimer(singletimer.Tag) Then
                    singletimer.DeselectMe()
                End If
            Next
            RadioButton1.Checked = True
            _SelectedTimer(Tag) = True
            SetLook()
        End If

    End Sub

    'Set Minutes Counter to 0
    Public Sub ResetMinutesCounter()
        MinutesCounter1.Reset()
    End Sub

    'Method to add Seconds to SingleTimer
    Private Sub AddSeconds(extraSecs As Integer)
        SecondsCounter1.MaxValue = 59
        MinutesCounter1.MaxValue = 99
        SecondsCounter1.SetMinutesCounter(MinutesCounter1)
        SecondsCounter1.IncreaseBy(extraSecs)
        ClearButton.Enabled = True
        StartButton.Enabled = True

    End Sub

    'Method to find Selected Timer and add seconds to it
    Public Shared Sub AddSecondsToSelected(extraSecs As Integer)
        For Each singletimer In Center.Controls.OfType(Of SingleTimer)
            If _SelectedTimer(singletimer.Tag) Then
                singletimer.AddSeconds(extraSecs)
            End If
        Next
    End Sub

    'Method to add Minutes to SingleTimer
    Private Sub AddMinutes(extraMins As Integer)
        MinutesCounter1.MaxValue = 99
        MinutesCounter1.IncreaseBy(extraMins)
        ClearButton.Enabled = True
        StartButton.Enabled = True
    End Sub

    'Method to find Selected Timer and add Minutes to it
    Public Shared Sub AddMinutesToSelected(ExtraMins As Integer)
        For Each singletimer In Center.Controls.OfType(Of SingleTimer)
            If _SelectedTimer(singletimer.Tag) Then
                singletimer.AddMinutes(ExtraMins)
            End If
        Next
    End Sub

    'Clear Button click handler
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        StopTiming()
        MinutesCounter1.Reset()
        SecondsCounter1.Reset()
        DisAbleAllButtons()
    End Sub

    'Timer functions 
    Private Sub Timer_Tick(Sender As Object, e As EventArgs) Handles Timer1.Tick
        If MinutesCounter1.IsZero And SecondsCounter1.IsZero Then
            ClearButton.Enabled = False
            _countdown = True
            If Not MinutesCounter1.ForeColor = Color.Red Then
                SetLook()
            End If
            SoundAlarm()
        Else
            SecondsCounter1.SetMinutesCounter(MinutesCounter1)
            SecondsCounter1.decrement()
        End If

    End Sub

    'Method to stop the timer
    Private Sub StopTiming()
        Timer1.Enabled = False
        _countdown = False
        Colon.Visible = True
    End Sub

    'Disable all buttons
    Private Sub DisAbleAllButtons()
        ClearButton.Enabled = False
        StartButton.Enabled = False
        StopButton.Enabled = False
    End Sub

    'Stop Button click handler
    Private Sub StopButton_Click(sender As Object, e As EventArgs) Handles StopButton.Click
        If Not MinutesCounter1.Value = 0 Or Not SecondsCounter1.Value = 0 Then
            StartButton.Enabled = True
            StopButton.Enabled = False
            StopTiming()
        Else
            DisAbleAllButtons()
            StopTiming()
            SetLook()
        End If
    End Sub

    'Start Button click handler
    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        Timer1.Enabled = True
        StartButton.Enabled = False
        StopButton.Enabled = True
    End Sub

    'Activate alarm
    Private Sub SoundAlarm()
        Console.Beep(Frequency, Beeps)
        Colon.Visible = Not Colon.Visible
    End Sub

    'Set Back Color
    Private Sub NewBackcolor(newcolor As Color)
        Me.BackColor = newcolor
    End Sub

    'Set Forecolor
    Private Sub NewForeColor(newcolor As Color)
        MinutesCounter1.ForeColor = newcolor
        SecondsCounter1.ForeColor = newcolor
        RadioButton1.ForeColor = newcolor
        Colon.ForeColor = newcolor
    End Sub

    'Set appropriate design for SingleTimer instance
    Private Sub SetLook()
        If _SelectedTimer(Tag) And Not _countdown Then
            NewBackcolor(Color.SteelBlue)
            NewForeColor(Color.White)
            BorderStyle = BorderStyle.Fixed3D
        ElseIf _countdown And _SelectedTimer(Tag) Then
            NewBackcolor(Color.SteelBlue)
            NewForeColor(Color.Red)
            BorderStyle = BorderStyle.None
        ElseIf _countdown And Not _SelectedTimer(Tag) Then
            NewBackcolor(SystemColors.GradientInactiveCaption)
            NewForeColor(Color.Red)
            BorderStyle = BorderStyle.None
        Else
            NewBackcolor(SystemColors.GradientInactiveCaption)
            NewForeColor(Color.SteelBlue)
            BorderStyle = BorderStyle.None
        End If
    End Sub

    'General Timer click handler
    Private Sub SingleTimer_Click(sender As Object, e As EventArgs) Handles Me.Click, Colon.Click, SecondsCounter1.Click, MinutesCounter1.Click, RadioButton1.Click, StartButton.Click, StopButton.Click, ClearButton.Click
        SelectMe()
    End Sub

    'Set appropriate Start button design on change
    Private Sub StartButton_EnabledChanged(sender As Object, e As EventArgs) Handles StartButton.EnabledChanged
        If StartButton.Enabled Then
            StartButton.ForeColor = Color.Lime
            StartButton.BackColor = SystemColors.ButtonFace
        Else
            StartButton.ForeColor = Color.Black
            StartButton.BackColor = Color.LightGray
        End If
    End Sub

    'Set appropriate Clear button design on change
    Private Sub ClearButton_EnabledChanged(sender As Object, e As EventArgs) Handles ClearButton.EnabledChanged
        If ClearButton.Enabled Then
            ClearButton.BackColor = SystemColors.ButtonFace
        Else
            ClearButton.BackColor = Color.LightGray
        End If

    End Sub

    'Set appropriate Stop button design on change
    Private Sub StopButton_EnabledChanged(sender As Object, e As EventArgs) Handles StopButton.EnabledChanged
        If StopButton.Enabled Then
            StopButton.ForeColor = Color.Red
            StopButton.BackColor = SystemColors.ButtonFace
        Else
            StopButton.ForeColor = Color.Black
            StopButton.BackColor = Color.LightGray
        End If
    End Sub

    Private Sub SingleTimer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
