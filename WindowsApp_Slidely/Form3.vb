Imports Newtonsoft.Json
Imports System.Net.Http
Imports System.Text

Public Class Form3
    Private stopwatchRunning As Boolean = False
    Private stopwatch As Stopwatch

    Private Sub CreateSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        stopwatch = New Stopwatch()
        ' Assign Ctrl + S shortcut to Submit button
        Me.KeyPreview = True
        ' Initialize Timer1 properties
        Timer1.Interval = 1000
    End Sub

    Private Sub btnToggleStopwatch_Click(sender As Object, e As EventArgs) Handles btnToggleStopwatch.Click
        If stopwatchRunning Then
            stopwatch.Stop()
            Timer1.Stop()
        Else
            stopwatch.Start()
            Timer1.Start()
        End If
        stopwatchRunning = Not stopwatchRunning
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Update the StopWatchTime TextBox with the current stopwatch elapsed time
        StopwatchTime.Text = GetFormattedStopwatchTime()
    End Sub

    Private Async Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' Collect data from the fields
        Dim newSubmission As New Submission() With {
            .Name = Names.Text,
            .Email = Email.Text,
            .PhoneNumber = PhoneNumber.Text,
            .GitHubLink = GithubLink.Text,
            .StopwatchTime = GetFormattedStopwatchTime()
        }
        ' Submit the data to the backend
        Await SubmitToBackend(newSubmission)
    End Sub

    Private Function GetFormattedStopwatchTime() As String
        Dim elapsed As TimeSpan = stopwatch.Elapsed
        Return $"{elapsed.Hours:00}:{elapsed.Minutes:00}:{elapsed.Seconds:00}"
    End Function

    Protected Overrides Sub OnKeyDown(e As KeyEventArgs)
        MyBase.OnKeyDown(e)
        If e.Control AndAlso e.KeyCode = Keys.S Then
            btnSubmit.PerformClick()
        ElseIf e.KeyCode = Keys.T Then
            btnToggleStopwatch.PerformClick()
            e.Handled = True
        End If
    End Sub

    Private Async Function SubmitToBackend(submission As Submission) As Task
        Try
            Dim json As String = JsonConvert.SerializeObject(submission)
            Console.WriteLine("Submitting data: " & json)
            Dim content As New StringContent(json, System.Text.Encoding.UTF8, "application/json")

            Using client As New HttpClient()
                Dim response As HttpResponseMessage = Await client.PostAsync("http://localhost:3000/submit", content)

                If response.IsSuccessStatusCode Then
                    MessageBox.Show("Submission successful!")
                Else
                    MessageBox.Show("Submission failed.")
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error submitting data: {ex.Message}")
        End Try
    End Function

    Private Sub lblGithubLink_Click(sender As Object, e As EventArgs) Handles lblGithubLink.Click

    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles Names.TextChanged

    End Sub

    Private Sub GithubLink_TextChanged(sender As Object, e As EventArgs) Handles GithubLink.TextChanged

    End Sub

    Private Sub PhoneNumber_TextChanged(sender As Object, e As EventArgs) Handles PhoneNumber.TextChanged

    End Sub

    Private Sub lblPhoneNumber_Click(sender As Object, e As EventArgs) Handles lblPhoneNumber.Click

    End Sub
End Class
