<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SingleTimer
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MinutesCounter1 = New A1_Final.MinutesCounter()
        Me.SecondsCounter1 = New A1_Final.SecondsCounter()
        Me.Colon = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.StartButton = New System.Windows.Forms.Button()
        Me.StopButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'MinutesCounter1
        '
        Me.MinutesCounter1.Font = New System.Drawing.Font("Lato", 47.99999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.MinutesCounter1.ForeColor = System.Drawing.Color.SteelBlue
        Me.MinutesCounter1.Location = New System.Drawing.Point(10, 43)
        Me.MinutesCounter1.MaxValue = 0
        Me.MinutesCounter1.Name = "MinutesCounter1"
        Me.MinutesCounter1.Size = New System.Drawing.Size(107, 104)
        Me.MinutesCounter1.TabIndex = 0
        Me.MinutesCounter1.Text = "00"
        Me.MinutesCounter1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MinutesCounter1.Value = 0
        '
        'SecondsCounter1
        '
        Me.SecondsCounter1.Font = New System.Drawing.Font("Lato", 47.99999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.SecondsCounter1.ForeColor = System.Drawing.Color.SteelBlue
        Me.SecondsCounter1.Location = New System.Drawing.Point(159, 43)
        Me.SecondsCounter1.MaxValue = 0
        Me.SecondsCounter1.Name = "SecondsCounter1"
        Me.SecondsCounter1.Size = New System.Drawing.Size(107, 104)
        Me.SecondsCounter1.TabIndex = 1
        Me.SecondsCounter1.Text = "00"
        Me.SecondsCounter1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.SecondsCounter1.Value = 0
        '
        'Colon
        '
        Me.Colon.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Colon.Font = New System.Drawing.Font("Lato", 39.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Colon.ForeColor = System.Drawing.Color.SteelBlue
        Me.Colon.Location = New System.Drawing.Point(113, 55)
        Me.Colon.Margin = New System.Windows.Forms.Padding(0)
        Me.Colon.Name = "Colon"
        Me.Colon.Size = New System.Drawing.Size(50, 72)
        Me.Colon.TabIndex = 2
        Me.Colon.Text = ":"
        Me.Colon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Lato", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.RadioButton1.ForeColor = System.Drawing.Color.SteelBlue
        Me.RadioButton1.Location = New System.Drawing.Point(24, 13)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(212, 39)
        Me.RadioButton1.TabIndex = 3
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "RadioButton1"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'StartButton
        '
        Me.StartButton.BackColor = System.Drawing.Color.LightGray
        Me.StartButton.Enabled = False
        Me.StartButton.FlatAppearance.BorderSize = 0
        Me.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StartButton.Font = New System.Drawing.Font("Lato", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.StartButton.ForeColor = System.Drawing.Color.Black
        Me.StartButton.Location = New System.Drawing.Point(18, 141)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(75, 50)
        Me.StartButton.TabIndex = 4
        Me.StartButton.Text = "Start"
        Me.StartButton.UseVisualStyleBackColor = False
        '
        'StopButton
        '
        Me.StopButton.BackColor = System.Drawing.Color.LightGray
        Me.StopButton.Enabled = False
        Me.StopButton.FlatAppearance.BorderSize = 0
        Me.StopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StopButton.Font = New System.Drawing.Font("Lato", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.StopButton.ForeColor = System.Drawing.Color.Black
        Me.StopButton.Location = New System.Drawing.Point(101, 141)
        Me.StopButton.Name = "StopButton"
        Me.StopButton.Size = New System.Drawing.Size(75, 50)
        Me.StopButton.TabIndex = 5
        Me.StopButton.Text = "Stop"
        Me.StopButton.UseVisualStyleBackColor = False
        '
        'ClearButton
        '
        Me.ClearButton.BackColor = System.Drawing.Color.LightGray
        Me.ClearButton.Enabled = False
        Me.ClearButton.FlatAppearance.BorderSize = 0
        Me.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClearButton.Font = New System.Drawing.Font("Lato", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ClearButton.ForeColor = System.Drawing.Color.Black
        Me.ClearButton.Location = New System.Drawing.Point(184, 141)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(75, 50)
        Me.ClearButton.TabIndex = 6
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'SingleTimer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.StopButton)
        Me.Controls.Add(Me.StartButton)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Colon)
        Me.Controls.Add(Me.SecondsCounter1)
        Me.Controls.Add(Me.MinutesCounter1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "SingleTimer"
        Me.Size = New System.Drawing.Size(276, 206)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MinutesCounter1 As MinutesCounter
    Friend WithEvents SecondsCounter1 As SecondsCounter
    Friend WithEvents Colon As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents StartButton As Button
    Friend WithEvents StopButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents Timer1 As Timer
End Class
