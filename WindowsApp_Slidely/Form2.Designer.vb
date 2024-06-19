<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewSubmissionsForm
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
        lblName = New Label()
        lblEmail = New Label()
        lblPhoneNumber = New Label()
        lblGithubLink = New Label()
        Label6 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        btnPrevious = New Button()
        btnNext = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(239, 42)
        Label1.Name = "Label1"
        Label1.Size = New Size(296, 20)
        Label1.TabIndex = 0
        Label1.Text = "John Doe, Slidely Task 2 - View Submissions"
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Location = New Point(255, 92)
        lblName.Name = "lblName"
        lblName.Size = New Size(49, 20)
        lblName.TabIndex = 1
        lblName.Text = "Name"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Location = New Point(255, 138)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(46, 20)
        lblEmail.TabIndex = 2
        lblEmail.Text = "Email"
        ' 
        ' lblPhoneNumber
        ' 
        lblPhoneNumber.AutoSize = True
        lblPhoneNumber.Location = New Point(239, 175)
        lblPhoneNumber.Name = "lblPhoneNumber"
        lblPhoneNumber.Size = New Size(86, 20)
        lblPhoneNumber.TabIndex = 3
        lblPhoneNumber.Text = "Phone Num"
        ' 
        ' lblGithubLink
        ' 
        lblGithubLink.AutoSize = True
        lblGithubLink.Location = New Point(208, 220)
        lblGithubLink.Name = "lblGithubLink"
        lblGithubLink.Size = New Size(151, 20)
        lblGithubLink.TabIndex = 4
        lblGithubLink.Text = "Github Link For Task 2"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(227, 262)
        Label6.Name = "Label6"
        Label6.Size = New Size(116, 20)
        Label6.TabIndex = 5
        Label6.Text = "Stopwatch Time"
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.FromArgb(CByte(233), CByte(236), CByte(239))
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Location = New Point(367, 92)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(125, 27)
        TextBox1.TabIndex = 6
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.FromArgb(CByte(233), CByte(236), CByte(239))
        TextBox2.BorderStyle = BorderStyle.FixedSingle
        TextBox2.Location = New Point(367, 131)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(125, 27)
        TextBox2.TabIndex = 7
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = Color.FromArgb(CByte(233), CByte(236), CByte(239))
        TextBox3.BorderStyle = BorderStyle.FixedSingle
        TextBox3.Location = New Point(367, 173)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(125, 27)
        TextBox3.TabIndex = 8
        ' 
        ' TextBox4
        ' 
        TextBox4.BackColor = Color.FromArgb(CByte(233), CByte(236), CByte(239))
        TextBox4.BorderStyle = BorderStyle.FixedSingle
        TextBox4.Location = New Point(367, 213)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(125, 27)
        TextBox4.TabIndex = 9
        ' 
        ' TextBox5
        ' 
        TextBox5.BackColor = Color.FromArgb(CByte(233), CByte(236), CByte(239))
        TextBox5.BorderStyle = BorderStyle.FixedSingle
        TextBox5.Location = New Point(367, 260)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(125, 27)
        TextBox5.TabIndex = 10
        ' 
        ' btnPrevious
        ' 
        btnPrevious.AutoEllipsis = True
        btnPrevious.BackColor = Color.FromArgb(CByte(255), CByte(236), CByte(153))
        btnPrevious.Location = New Point(239, 345)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(189, 29)
        btnPrevious.TabIndex = 11
        btnPrevious.Text = "PREVIOUS (CTRL + P)"
        btnPrevious.UseVisualStyleBackColor = False
        ' 
        ' btnNext
        ' 
        btnNext.BackColor = Color.FromArgb(CByte(165), CByte(216), CByte(255))
        btnNext.Location = New Point(434, 345)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(180, 29)
        btnNext.TabIndex = 12
        btnNext.Text = "NEXT (CTRL + N)"
        btnNext.UseVisualStyleBackColor = False
        ' 
        ' ViewSubmissionsForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnNext)
        Controls.Add(btnPrevious)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label6)
        Controls.Add(lblGithubLink)
        Controls.Add(lblPhoneNumber)
        Controls.Add(lblEmail)
        Controls.Add(lblName)
        Controls.Add(Label1)
        Name = "ViewSubmissionsForm"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblPhoneNumber As Label
    Friend WithEvents lblGithubLink As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
End Class
