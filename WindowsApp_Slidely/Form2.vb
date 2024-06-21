Imports Newtonsoft.Json
Imports System.Net.Http
Imports System.Text
Imports System.Threading.Tasks

Public Class ViewSubmissionsForm
    Private currentIndex As Integer = 0
    Private submissions As List(Of Submission)
    Private isEditMode As Boolean = False

    Private Async Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load submissions from the backend
        submissions = Await LoadSubmissions()
        DisplaySubmission()
        Me.KeyPreview = True
    End Sub

    Private Sub DisplaySubmission()
        If submissions IsNot Nothing AndAlso submissions.Count > 0 Then
            Dim submission As Submission = submissions(currentIndex)
            ' Assuming you have labels or text boxes named lblName, lblEmail, etc.
            lblName.Text = submission.Name
            lblEmail.Text = submission.Email
            lblPhoneNumber.Text = submission.PhoneNumber
            lblGithubLink.Text = submission.GitHubLink
            lblStopwatchTime.Text = submission.StopwatchTime
            SetReadOnly(True)
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

    Private Async Function LoadSubmissions() As Task(Of List(Of Submission))
        Dim loadedSubmissions As New List(Of Submission)

        Try
            Using client As New HttpClient()
                Dim index As Integer = 0
                While True
                    Dim response As HttpResponseMessage = Await client.GetAsync($"http://localhost:3000/read?index={index}")
                    If response.IsSuccessStatusCode Then
                        Dim json As String = Await response.Content.ReadAsStringAsync()
                        Dim submission As Submission = JsonConvert.DeserializeObject(Of Submission)(json)
                        loadedSubmissions.Add(submission)
                        index += 1
                    Else
                        Exit While
                    End If
                End While
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error fetching submissions: {ex.Message}")
        End Try

        Return loadedSubmissions
    End Function

    Private Async Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If submissions IsNot Nothing AndAlso submissions.Count > 0 Then
            Try
                Using client As New HttpClient()
                    Dim response As HttpResponseMessage = Await client.DeleteAsync($"http://localhost:3000/delete/{currentIndex}")
                    If response.IsSuccessStatusCode Then
                        submissions.RemoveAt(currentIndex)
                        If currentIndex >= submissions.Count Then
                            currentIndex = submissions.Count - 1
                        End If
                        DisplaySubmission()
                        MessageBox.Show("Submission deleted successfully!")
                    Else
                        MessageBox.Show("Failed to delete submission.")
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show($"Error deleting submission: {ex.Message}")
            End Try
        End If
    End Sub

    Private Async Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If isEditMode Then
            ' Save the edited data
            Dim editedSubmission As New Submission() With {
                .Name = lblName.Text,
                .Email = lblEmail.Text,
                .PhoneNumber = lblPhoneNumber.Text,
                .GitHubLink = lblGithubLink.Text,
                .StopwatchTime = lblStopwatchTime.Text
            }

            Try
                Using client As New HttpClient()
                    Dim json As String = JsonConvert.SerializeObject(editedSubmission)
                    Dim content As New StringContent(json, Encoding.UTF8, "application/json")
                    Dim response As HttpResponseMessage = Await client.PutAsync($"http://localhost:3000/edit/{currentIndex}", content)
                    If response.IsSuccessStatusCode Then
                        submissions(currentIndex) = editedSubmission
                        DisplaySubmission()
                        MessageBox.Show("Submission edited successfully!")
                    Else
                        MessageBox.Show("Failed to edit submission.")
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show($"Error editing submission: {ex.Message}")
            End Try

            SetReadOnly(True)
            btnEdit.Text = "Edit"
        Else
            ' Enable editing
            SetReadOnly(False)
            btnEdit.Text = "Save"
        End If

        isEditMode = Not isEditMode
    End Sub

    Private Sub SetReadOnly(isReadOnly As Boolean)
        lblName.ReadOnly = isReadOnly
        lblEmail.ReadOnly = isReadOnly
        lblPhoneNumber.ReadOnly = isReadOnly
        lblGithubLink.ReadOnly = isReadOnly
        lblStopwatchTime.ReadOnly = isReadOnly
    End Sub

    ' Event handlers for your form controls
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles PhoneNumber.Click
        ' Handle label click event if needed
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles lblName.TextChanged
        ' Handle text box text changed event if needed
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles lblPhoneNumber.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles lblGithubLink.TextChanged

    End Sub

    Private Sub lblStopwatchTime_TextChanged(sender As Object, e As EventArgs) Handles lblStopwatchTime.TextChanged

    End Sub

    Protected Overrides Sub OnKeyDown(e As KeyEventArgs)
        MyBase.OnKeyDown(e)
        If e.Control Then
            If e.KeyCode = Keys.N Then
                btnNext.PerformClick()
                e.Handled = True
            ElseIf e.KeyCode = Keys.P Then
                btnPrevious.PerformClick()
                e.Handled = True
            End If
        End If
    End Sub
End Class
