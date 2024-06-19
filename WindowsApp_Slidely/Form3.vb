Public Class CreateSubmissionForm
    Private stopwatchRunning As Boolean = False
    Private stopwatch As Stopwatch

    Private Sub CreateSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        stopwatch = New Stopwatch()
        ' Assign Ctrl + S shortcut to Submit button
        Me.KeyPreview = True
    End Sub

    Private Sub btnToggleStopwatch_Click(sender As Object, e As EventArgs) Handles btnToggleStopwatch.Click
        If stopwatchRunning Then
            stopwatch.Stop()
        Else
            stopwatch.Start()
        End If
        stopwatchRunning = Not stopwatchRunning
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' Collect data from the fields
        Dim newSubmission As New Submission() With {
            .Name = txtName.Text,
            .Email = txtEmail.Text,
            .PhoneNumber = txtPhoneNumber.Text,
            .GitHubLink = txtGithubLink.Text
        }
        ' Submit the data to the backend
        SubmitToBackend(newSubmission)
    End Sub

    Protected Overrides Sub OnKeyDown(e As KeyEventArgs)
        MyBase.OnKeyDown(e)
        If e.Control AndAlso e.KeyCode = Keys.S Then
            btnSubmit.PerformClick()
        End If
    End Sub

    Private Sub SubmitToBackend(submission As Submission)
        ' Placeholder: Submit the new submission to your backend storage
    End Sub
End Class
