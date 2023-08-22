<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Center
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.SecondButton = New System.Windows.Forms.Button()
        Me.ThreeSecond = New System.Windows.Forms.Button()
        Me.TenSecond = New System.Windows.Forms.Button()
        Me.MinuteButton = New System.Windows.Forms.Button()
        Me.ThreeMinute = New System.Windows.Forms.Button()
        Me.TenMinute = New System.Windows.Forms.Button()
        Me.BackLeft = New A1_Final.SingleTimer()
        Me.BackRight = New A1_Final.SingleTimer()
        Me.FrontLeft = New A1_Final.SingleTimer()
        Me.FrontRight = New A1_Final.SingleTimer()
        Me.SuspendLayout()
        '
        'SecondButton
        '
        Me.SecondButton.BackColor = System.Drawing.Color.SteelBlue
        Me.SecondButton.Font = New System.Drawing.Font("Lato", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.SecondButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.SecondButton.Location = New System.Drawing.Point(14, 457)
        Me.SecondButton.Name = "SecondButton"
        Me.SecondButton.Size = New System.Drawing.Size(180, 70)
        Me.SecondButton.TabIndex = 2
        Me.SecondButton.Tag = "1"
        Me.SecondButton.Text = "1 Second"
        Me.SecondButton.UseVisualStyleBackColor = False
        '
        'ThreeSecond
        '
        Me.ThreeSecond.BackColor = System.Drawing.Color.SteelBlue
        Me.ThreeSecond.Font = New System.Drawing.Font("Lato", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ThreeSecond.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ThreeSecond.Location = New System.Drawing.Point(221, 457)
        Me.ThreeSecond.Name = "ThreeSecond"
        Me.ThreeSecond.Size = New System.Drawing.Size(180, 70)
        Me.ThreeSecond.TabIndex = 3
        Me.ThreeSecond.Tag = "3"
        Me.ThreeSecond.Text = "3 Seconds"
        Me.ThreeSecond.UseVisualStyleBackColor = False
        '
        'TenSecond
        '
        Me.TenSecond.BackColor = System.Drawing.Color.SteelBlue
        Me.TenSecond.Font = New System.Drawing.Font("Lato", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TenSecond.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TenSecond.Location = New System.Drawing.Point(428, 457)
        Me.TenSecond.Name = "TenSecond"
        Me.TenSecond.Size = New System.Drawing.Size(180, 70)
        Me.TenSecond.TabIndex = 4
        Me.TenSecond.Tag = "10"
        Me.TenSecond.Text = "10 Seconds"
        Me.TenSecond.UseVisualStyleBackColor = False
        '
        'MinuteButton
        '
        Me.MinuteButton.BackColor = System.Drawing.Color.SteelBlue
        Me.MinuteButton.Font = New System.Drawing.Font("Lato", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.MinuteButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.MinuteButton.Location = New System.Drawing.Point(14, 533)
        Me.MinuteButton.Name = "MinuteButton"
        Me.MinuteButton.Size = New System.Drawing.Size(180, 70)
        Me.MinuteButton.TabIndex = 5
        Me.MinuteButton.Tag = "1"
        Me.MinuteButton.Text = "1 Minute"
        Me.MinuteButton.UseVisualStyleBackColor = False
        '
        'ThreeMinute
        '
        Me.ThreeMinute.BackColor = System.Drawing.Color.SteelBlue
        Me.ThreeMinute.Font = New System.Drawing.Font("Lato", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ThreeMinute.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ThreeMinute.Location = New System.Drawing.Point(221, 533)
        Me.ThreeMinute.Name = "ThreeMinute"
        Me.ThreeMinute.Size = New System.Drawing.Size(180, 70)
        Me.ThreeMinute.TabIndex = 6
        Me.ThreeMinute.TabStop = False
        Me.ThreeMinute.Tag = "3"
        Me.ThreeMinute.Text = "3 Minutes"
        Me.ThreeMinute.UseVisualStyleBackColor = False
        '
        'TenMinute
        '
        Me.TenMinute.BackColor = System.Drawing.Color.SteelBlue
        Me.TenMinute.Font = New System.Drawing.Font("Lato", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TenMinute.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TenMinute.Location = New System.Drawing.Point(428, 533)
        Me.TenMinute.Name = "TenMinute"
        Me.TenMinute.Size = New System.Drawing.Size(180, 70)
        Me.TenMinute.TabIndex = 7
        Me.TenMinute.Tag = "10"
        Me.TenMinute.Text = "10 Minutes"
        Me.TenMinute.UseVisualStyleBackColor = False
        '
        'BackLeft
        '
        Me.BackLeft.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.BackLeft.Beeps = 100
        Me.BackLeft.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BackLeft.Frequency = 3150
        Me.BackLeft.Location = New System.Drawing.Point(18, 17)
        Me.BackLeft.Name = "BackLeft"
        Me.BackLeft.Size = New System.Drawing.Size(276, 200)
        Me.BackLeft.TabIndex = 12
        Me.BackLeft.Tag = "0"
        Me.BackLeft.Title = "Back Left"
        '
        'BackRight
        '
        Me.BackRight.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.BackRight.Beeps = 100
        Me.BackRight.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BackRight.Frequency = 1655
        Me.BackRight.Location = New System.Drawing.Point(329, 17)
        Me.BackRight.Name = "BackRight"
        Me.BackRight.Size = New System.Drawing.Size(276, 200)
        Me.BackRight.TabIndex = 13
        Me.BackRight.Tag = "1"
        Me.BackRight.Title = "Back Right"
        '
        'FrontLeft
        '
        Me.FrontLeft.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.FrontLeft.Beeps = 100
        Me.FrontLeft.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FrontLeft.Frequency = 5000
        Me.FrontLeft.Location = New System.Drawing.Point(18, 243)
        Me.FrontLeft.Name = "FrontLeft"
        Me.FrontLeft.Size = New System.Drawing.Size(276, 200)
        Me.FrontLeft.TabIndex = 14
        Me.FrontLeft.Tag = "2"
        Me.FrontLeft.Title = "Front Left"
        '
        'FrontRight
        '
        Me.FrontRight.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.FrontRight.Beeps = 100
        Me.FrontRight.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FrontRight.Frequency = 855
        Me.FrontRight.Location = New System.Drawing.Point(329, 243)
        Me.FrontRight.Name = "FrontRight"
        Me.FrontRight.Size = New System.Drawing.Size(276, 200)
        Me.FrontRight.TabIndex = 15
        Me.FrontRight.Tag = "3"
        Me.FrontRight.Title = "Front Right"
        '
        'Center
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(622, 616)
        Me.Controls.Add(Me.FrontRight)
        Me.Controls.Add(Me.FrontLeft)
        Me.Controls.Add(Me.BackRight)
        Me.Controls.Add(Me.BackLeft)
        Me.Controls.Add(Me.TenMinute)
        Me.Controls.Add(Me.ThreeMinute)
        Me.Controls.Add(Me.MinuteButton)
        Me.Controls.Add(Me.TenSecond)
        Me.Controls.Add(Me.ThreeSecond)
        Me.Controls.Add(Me.SecondButton)
        Me.Name = "Center"
        Me.Text = "Kitchen Stove Timer"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SecondButton As Button
    Friend WithEvents ThreeSecond As Button
    Friend WithEvents TenSecond As Button
    Friend WithEvents MinuteButton As Button
    Friend WithEvents ThreeMinute As Button
    Friend WithEvents TenMinute As Button
    Friend WithEvents BackLeft As SingleTimer
    Friend WithEvents BackRight As SingleTimer
    Friend WithEvents FrontLeft As SingleTimer
    Friend WithEvents FrontRight As SingleTimer
End Class
