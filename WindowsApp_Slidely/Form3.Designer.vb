<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        components = New ComponentModel.Container()
        Label1 = New Label()
        btnSubmit = New Button()
        btnToggleStopwatch = New Button()
        lblGithubLink = New Label()
        lblPhoneNumber = New Label()
        lblEmail = New Label()
        lblName = New Label()
        Timer1 = New Timer(components)
        StopwatchTime = New TextBox()
        GithubLink = New TextBox()
        PhoneNumber = New TextBox()
        Email = New TextBox()
        Names = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Showcard Gothic", 15F)
        Label1.Location = New Point(142, 40)
        Label1.Name = "Label1"
        Label1.Size = New Size(602, 31)
        Label1.TabIndex = 1
        Label1.Text = "John Doe, Slidely Task 2 - Create Submissions"
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = Color.FromArgb(CByte(165), CByte(216), CByte(255))
        btnSubmit.Font = New Font("Showcard Gothic", 11F)
        btnSubmit.Location = New Point(313, 372)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(220, 56)
        btnSubmit.TabIndex = 25
        btnSubmit.Text = "SUBMIT (CTRL + S)"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' btnToggleStopwatch
        ' 
        btnToggleStopwatch.AutoEllipsis = True
        btnToggleStopwatch.BackColor = Color.FromArgb(CByte(255), CByte(236), CByte(153))
        btnToggleStopwatch.Location = New Point(76, 281)
        btnToggleStopwatch.Name = "btnToggleStopwatch"
        btnToggleStopwatch.Size = New Size(300, 45)
        btnToggleStopwatch.TabIndex = 24
        btnToggleStopwatch.Text = "TOGGLE STOPWATCH (CTRL + T)"
        btnToggleStopwatch.UseVisualStyleBackColor = False
        ' 
        ' lblGithubLink
        ' 
        lblGithubLink.AutoSize = True
        lblGithubLink.Location = New Point(118, 248)
        lblGithubLink.Name = "lblGithubLink"
        lblGithubLink.Size = New Size(175, 21)
        lblGithubLink.TabIndex = 17
        lblGithubLink.Text = "Github Link For Task 2"
        ' 
        ' lblPhoneNumber
        ' 
        lblPhoneNumber.AutoSize = True
        lblPhoneNumber.Location = New Point(118, 206)
        lblPhoneNumber.Name = "lblPhoneNumber"
        lblPhoneNumber.Size = New Size(94, 21)
        lblPhoneNumber.TabIndex = 16
        lblPhoneNumber.Text = "Phone Num"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Location = New Point(118, 162)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(51, 21)
        lblEmail.TabIndex = 15
        lblEmail.Text = "Email"
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Location = New Point(118, 122)
        lblName.Name = "lblName"
        lblName.Size = New Size(53, 21)
        lblName.TabIndex = 14
        lblName.Text = "Name"
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 1000
        ' 
        ' StopwatchTime
        ' 
        StopwatchTime.BackColor = Color.FromArgb(CByte(233), CByte(236), CByte(239))
        StopwatchTime.BorderStyle = BorderStyle.FixedSingle
        StopwatchTime.Location = New Point(400, 291)
        StopwatchTime.Name = "StopwatchTime"
        StopwatchTime.Size = New Size(372, 28)
        StopwatchTime.TabIndex = 23
        ' 
        ' GithubLink
        ' 
        GithubLink.BackColor = Color.FromArgb(CByte(233), CByte(236), CByte(239))
        GithubLink.BorderStyle = BorderStyle.FixedSingle
        GithubLink.Location = New Point(400, 241)
        GithubLink.Name = "GithubLink"
        GithubLink.Size = New Size(372, 28)
        GithubLink.TabIndex = 22
        ' 
        ' PhoneNumber
        ' 
        PhoneNumber.BackColor = Color.FromArgb(CByte(233), CByte(236), CByte(239))
        PhoneNumber.BorderStyle = BorderStyle.FixedSingle
        PhoneNumber.Location = New Point(400, 199)
        PhoneNumber.Name = "PhoneNumber"
        PhoneNumber.Size = New Size(372, 28)
        PhoneNumber.TabIndex = 21
        ' 
        ' Email
        ' 
        Email.BackColor = Color.FromArgb(CByte(233), CByte(236), CByte(239))
        Email.BorderStyle = BorderStyle.FixedSingle
        Email.Location = New Point(400, 155)
        Email.Name = "Email"
        Email.Size = New Size(372, 28)
        Email.TabIndex = 20
        ' 
        ' Names
        ' 
        Names.BackColor = Color.FromArgb(CByte(233), CByte(236), CByte(239))
        Names.BorderStyle = BorderStyle.FixedSingle
        Names.Location = New Point(400, 114)
        Names.Name = "Names"
        Names.Size = New Size(372, 28)
        Names.TabIndex = 19
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(900, 472)
        Controls.Add(btnSubmit)
        Controls.Add(btnToggleStopwatch)
        Controls.Add(StopwatchTime)
        Controls.Add(GithubLink)
        Controls.Add(PhoneNumber)
        Controls.Add(Email)
        Controls.Add(Names)
        Controls.Add(lblGithubLink)
        Controls.Add(lblPhoneNumber)
        Controls.Add(lblEmail)
        Controls.Add(lblName)
        Controls.Add(Label1)
        Font = New Font("Tahoma", 10.2F)
        Name = "Form3"
        Text = "Form3"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnToggleStopwatch As Button
    Friend WithEvents lblGithubLink As Label
    Friend WithEvents lblPhoneNumber As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblName As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents StopwatchTime As TextBox
    Friend WithEvents GithubLink As TextBox
    Friend WithEvents PhoneNumber As TextBox
    Friend WithEvents Email As TextBox
    Friend WithEvents Names As TextBox
End Class
