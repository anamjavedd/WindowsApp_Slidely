<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewSubmissionsForm
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
        Label1 = New Label()
        Email = New Label()
        PhoneNumber = New Label()
        GithubLink = New Label()
        Label6 = New Label()
        lblName = New TextBox()
        lblEmail = New TextBox()
        lblPhoneNumber = New TextBox()
        lblGithubLink = New TextBox()
        lblStopwatchTime = New TextBox()
        btnPrevious = New Button()
        btnNext = New Button()
        Label2 = New Label()
        btnEdit = New Button()
        btnDelete = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Showcard Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(124, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(574, 31)
        Label1.TabIndex = 0
        Label1.Text = "John Doe, Slidely Task 2 - View Submissions"
        ' 
        ' Email
        ' 
        Email.AutoSize = True
        Email.Font = New Font("Tahoma", 10.2F)
        Email.Location = New Point(167, 137)
        Email.Name = "Email"
        Email.Size = New Size(51, 21)
        Email.TabIndex = 2
        Email.Text = "Email"
        ' 
        ' PhoneNumber
        ' 
        PhoneNumber.AutoSize = True
        PhoneNumber.Font = New Font("Tahoma", 10.2F)
        PhoneNumber.Location = New Point(167, 179)
        PhoneNumber.Name = "PhoneNumber"
        PhoneNumber.Size = New Size(94, 21)
        PhoneNumber.TabIndex = 3
        PhoneNumber.Text = "Phone Num"
        ' 
        ' GithubLink
        ' 
        GithubLink.AutoSize = True
        GithubLink.Font = New Font("Tahoma", 10.2F)
        GithubLink.Location = New Point(167, 219)
        GithubLink.Name = "GithubLink"
        GithubLink.Size = New Size(175, 21)
        GithubLink.TabIndex = 4
        GithubLink.Text = "Github Link For Task 2"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Tahoma", 10.2F)
        Label6.Location = New Point(167, 266)
        Label6.Name = "Label6"
        Label6.Size = New Size(130, 21)
        Label6.TabIndex = 5
        Label6.Text = "Stopwatch Time"
        ' 
        ' lblName
        ' 
        lblName.BackColor = Color.FromArgb(CByte(233), CByte(236), CByte(239))
        lblName.BorderStyle = BorderStyle.FixedSingle
        lblName.Location = New Point(367, 92)
        lblName.Name = "lblName"
        lblName.ReadOnly = True
        lblName.Size = New Size(331, 27)
        lblName.TabIndex = 6
        ' 
        ' lblEmail
        ' 
        lblEmail.BackColor = Color.FromArgb(CByte(233), CByte(236), CByte(239))
        lblEmail.BorderStyle = BorderStyle.FixedSingle
        lblEmail.Location = New Point(367, 131)
        lblEmail.Name = "lblEmail"
        lblEmail.ReadOnly = True
        lblEmail.Size = New Size(331, 27)
        lblEmail.TabIndex = 7
        ' 
        ' lblPhoneNumber
        ' 
        lblPhoneNumber.BackColor = Color.FromArgb(CByte(233), CByte(236), CByte(239))
        lblPhoneNumber.BorderStyle = BorderStyle.FixedSingle
        lblPhoneNumber.Location = New Point(367, 173)
        lblPhoneNumber.Name = "lblPhoneNumber"
        lblPhoneNumber.ReadOnly = True
        lblPhoneNumber.Size = New Size(331, 27)
        lblPhoneNumber.TabIndex = 8
        ' 
        ' lblGithubLink
        ' 
        lblGithubLink.BackColor = Color.FromArgb(CByte(233), CByte(236), CByte(239))
        lblGithubLink.BorderStyle = BorderStyle.FixedSingle
        lblGithubLink.Location = New Point(367, 213)
        lblGithubLink.Name = "lblGithubLink"
        lblGithubLink.ReadOnly = True
        lblGithubLink.Size = New Size(331, 27)
        lblGithubLink.TabIndex = 9
        ' 
        ' lblStopwatchTime
        ' 
        lblStopwatchTime.BackColor = Color.FromArgb(CByte(233), CByte(236), CByte(239))
        lblStopwatchTime.BorderStyle = BorderStyle.FixedSingle
        lblStopwatchTime.Location = New Point(367, 260)
        lblStopwatchTime.Name = "lblStopwatchTime"
        lblStopwatchTime.ReadOnly = True
        lblStopwatchTime.Size = New Size(331, 27)
        lblStopwatchTime.TabIndex = 10
        ' 
        ' btnPrevious
        ' 
        btnPrevious.AutoEllipsis = True
        btnPrevious.BackColor = Color.FromArgb(CByte(255), CByte(236), CByte(153))
        btnPrevious.Font = New Font("Showcard Gothic", 11F)
        btnPrevious.Location = New Point(197, 377)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(231, 51)
        btnPrevious.TabIndex = 11
        btnPrevious.Text = "PREVIOUS (CTRL + P)"
        btnPrevious.UseVisualStyleBackColor = False
        ' 
        ' btnNext
        ' 
        btnNext.BackColor = Color.FromArgb(CByte(165), CByte(216), CByte(255))
        btnNext.Font = New Font("Showcard Gothic", 11F)
        btnNext.Location = New Point(434, 377)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(231, 51)
        btnNext.TabIndex = 12
        btnNext.Text = "NEXT (CTRL + N)"
        btnNext.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(167, 98)
        Label2.Name = "Label2"
        Label2.Size = New Size(53, 21)
        Label2.TabIndex = 13
        Label2.Text = "Name"
        ' 
        ' btnEdit
        ' 
        btnEdit.Font = New Font("Showcard Gothic", 11F)
        btnEdit.Location = New Point(247, 325)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(95, 39)
        btnEdit.TabIndex = 14
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Font = New Font("Showcard Gothic", 11F)
        btnDelete.Location = New Point(492, 325)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(95, 39)
        btnDelete.TabIndex = 15
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' ViewSubmissionsForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnDelete)
        Controls.Add(btnEdit)
        Controls.Add(Label2)
        Controls.Add(btnNext)
        Controls.Add(btnPrevious)
        Controls.Add(lblStopwatchTime)
        Controls.Add(lblGithubLink)
        Controls.Add(lblPhoneNumber)
        Controls.Add(lblEmail)
        Controls.Add(lblName)
        Controls.Add(Label6)
        Controls.Add(GithubLink)
        Controls.Add(PhoneNumber)
        Controls.Add(Email)
        Controls.Add(Label1)
        Name = "ViewSubmissionsForm"
        Padding = New Padding(0, 0, 10, 0)
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label

    Friend WithEvents Email As Label
    Friend WithEvents PhoneNumber As Label
    Friend WithEvents GithubLink As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblName As TextBox
    Friend WithEvents lblEmail As TextBox
    Friend WithEvents lblPhoneNumber As TextBox
    Friend WithEvents lblGithubLink As TextBox
    Friend WithEvents lblStopwatchTime As TextBox
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
End Class
