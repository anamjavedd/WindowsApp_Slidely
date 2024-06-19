<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateSubmissionForm
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
        Label1 = New Label()
        btnSubmit = New Button()
        btnToggleStopwatch = New Button()
        TextBox5 = New TextBox()
        txtGithubLink = New TextBox()
        txtPhoneNumber = New TextBox()
        txtEmail = New TextBox()
        txtName = New TextBox()
        lblGithubLink = New Label()
        lblPhoneNumber = New Label()
        lblEmail = New Label()
        lblName = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(228, 53)
        Label1.Name = "Label1"
        Label1.Size = New Size(307, 20)
        Label1.TabIndex = 1
        Label1.Text = "John Doe, Slidely Task 2 - Create Submissions"
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = Color.FromArgb(CByte(165), CByte(216), CByte(255))
        btnSubmit.Location = New Point(278, 354)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(149, 29)
        btnSubmit.TabIndex = 25
        btnSubmit.Text = "SUBMIT (CTRL + S)"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' btnToggleStopwatch
        ' 
        btnToggleStopwatch.AutoEllipsis = True
        btnToggleStopwatch.BackColor = Color.FromArgb(CByte(255), CByte(236), CByte(153))
        btnToggleStopwatch.Location = New Point(94, 275)
        btnToggleStopwatch.Name = "btnToggleStopwatch"
        btnToggleStopwatch.Size = New Size(242, 29)
        btnToggleStopwatch.TabIndex = 24
        btnToggleStopwatch.Text = "TOGGLE STOPWATCH (CTRL + T)"
        btnToggleStopwatch.UseVisualStyleBackColor = False
        ' 
        ' TextBox5
        ' 
        TextBox5.BackColor = Color.FromArgb(CByte(233), CByte(236), CByte(239))
        TextBox5.BorderStyle = BorderStyle.FixedSingle
        TextBox5.Location = New Point(356, 277)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(125, 27)
        TextBox5.TabIndex = 23
        ' 
        ' txtGithubLink
        ' 
        txtGithubLink.BackColor = Color.FromArgb(CByte(233), CByte(236), CByte(239))
        txtGithubLink.BorderStyle = BorderStyle.FixedSingle
        txtGithubLink.Location = New Point(356, 230)
        txtGithubLink.Name = "txtGithubLink"
        txtGithubLink.Size = New Size(125, 27)
        txtGithubLink.TabIndex = 22
        ' 
        ' txtPhoneNumber
        ' 
        txtPhoneNumber.BackColor = Color.FromArgb(CByte(233), CByte(236), CByte(239))
        txtPhoneNumber.BorderStyle = BorderStyle.FixedSingle
        txtPhoneNumber.Location = New Point(356, 190)
        txtPhoneNumber.Name = "txtPhoneNumber"
        txtPhoneNumber.Size = New Size(125, 27)
        txtPhoneNumber.TabIndex = 21
        ' 
        ' txtEmail
        ' 
        txtEmail.BackColor = Color.FromArgb(CByte(233), CByte(236), CByte(239))
        txtEmail.BorderStyle = BorderStyle.FixedSingle
        txtEmail.Location = New Point(356, 148)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(125, 27)
        txtEmail.TabIndex = 20
        ' 
        ' txtName
        ' 
        txtName.BackColor = Color.FromArgb(CByte(233), CByte(236), CByte(239))
        txtName.BorderStyle = BorderStyle.FixedSingle
        txtName.Location = New Point(356, 109)
        txtName.Name = "txtName"
        txtName.Size = New Size(125, 27)
        txtName.TabIndex = 19
        ' 
        ' lblGithubLink
        ' 
        lblGithubLink.AutoSize = True
        lblGithubLink.Location = New Point(185, 237)
        lblGithubLink.Name = "lblGithubLink"
        lblGithubLink.Size = New Size(151, 20)
        lblGithubLink.TabIndex = 17
        lblGithubLink.Text = "Github Link For Task 2"
        ' 
        ' lblPhoneNumber
        ' 
        lblPhoneNumber.AutoSize = True
        lblPhoneNumber.Location = New Point(228, 192)
        lblPhoneNumber.Name = "lblPhoneNumber"
        lblPhoneNumber.Size = New Size(86, 20)
        lblPhoneNumber.TabIndex = 16
        lblPhoneNumber.Text = "Phone Num"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Location = New Point(244, 155)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(46, 20)
        lblEmail.TabIndex = 15
        lblEmail.Text = "Email"
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Location = New Point(244, 109)
        lblName.Name = "lblName"
        lblName.Size = New Size(49, 20)
        lblName.TabIndex = 14
        lblName.Text = "Name"
        ' 
        ' CreateSubmissionForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnSubmit)
        Controls.Add(btnToggleStopwatch)
        Controls.Add(TextBox5)
        Controls.Add(txtGithubLink)
        Controls.Add(txtPhoneNumber)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Controls.Add(lblGithubLink)
        Controls.Add(lblPhoneNumber)
        Controls.Add(lblEmail)
        Controls.Add(lblName)
        Controls.Add(Label1)
        Name = "CreateSubmissionForm"
        Text = "Form3"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnToggleStopwatch As Button
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents txtGithubLink As TextBox
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblGithubLink As Label
    Friend WithEvents lblPhoneNumber As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblName As Label
End Class
