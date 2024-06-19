Public Class ViewSubmissionsForm
    Private currentIndex As Integer = 0
    Private submissions As List(Of Submission)

    Private Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load submissions from the backend
        submissions = LoadSubmissions()
        DisplaySubmission()
    End Sub

    Private Sub DisplaySubmission()
        If submissions IsNot Nothing AndAlso submissions.Count > 0 Then
            Dim submission As Submission = submissions(currentIndex)
            ' Assuming you have labels or text boxes named lblName, lblEmail, etc.
            lblName.Text = submission.Name
            lblEmail.Text = submission.Email
            lblPhoneNumber.Text = submission.PhoneNumber
            lblGithubLink.Text = submission.GitHubLink
        End If
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            DisplaySubmission()
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentIndex < submissions.Count - 1 Then
            currentIndex += 1
            DisplaySubmission()
        End If
    End Sub

    Private Function LoadSubmissions() As List(Of Submission)
        ' Placeholder: Load the submissions from your backend storage
        Return New List(Of Submission)() ' Example data
    End Function

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles lblPhoneNumber.Click

    End Sub
End Class
