Imports System.Net.Http
Imports Newtonsoft.Json

Public Class DeleteSubmissions

    Dim submissions As New List(Of Submission)
    Dim currentIndex As Integer = 0


    Private Async Sub FetchSubmission(index As Integer)
        Using client As New HttpClient()
            Try
                Dim response As HttpResponseMessage = Await client.GetAsync("http://localhost:3400/read?index=" & index)
                If response.IsSuccessStatusCode Then
                    Dim json As String = Await response.Content.ReadAsStringAsync()
                    Dim submission As Submission = JsonConvert.DeserializeObject(Of Submission)(json)
                    If submission IsNot Nothing Then

                        While submissions.Count <= index
                            submissions.Add(Nothing)
                        End While

                        submissions(index) = submission
                        DisplaySubmission()
                    Else
                        MessageBox.Show("No submission found at the specified index.")
                    End If
                Else
                    MessageBox.Show("You are at the end of submissions.")
                End If
            Catch ex As Exception
                MessageBox.Show("Error fetching submission: " + ex.Message)
            End Try
        End Using
    End Sub


    Private Sub DisplaySubmission()
        If submissions IsNot Nothing AndAlso submissions.Count > currentIndex AndAlso currentIndex >= 0 Then
            Dim currentSubmission As Submission = submissions(currentIndex)
            txtName.Text = currentSubmission.Name
            txtEmail.Text = currentSubmission.Email
            txtphone.Text = currentSubmission.Phone
            txtGithub_Link.Text = currentSubmission.Github_Link
            txtStopwatch_Time.Text = currentSubmission.Stopwatch_Time
        Else

            txtName.Text = ""
            txtEmail.Text = ""
            txtphone.Text = ""
            txtGithub_Link.Text = ""
            txtStopwatch_Time.Text = ""
        End If
    End Sub


    Private Sub btnPrevClick_Click(sender As Object, e As EventArgs) Handles btnPrevClick.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            FetchSubmission(currentIndex)
        Else
            MessageBox.Show("You are at the beginning of the submissions.")
        End If
    End Sub


    Private Sub btnNextClick_Click(sender As Object, e As EventArgs) Handles btnNextClick.Click
        currentIndex += 1
        If currentIndex <= submissions.Count Then
            FetchSubmission(currentIndex)
        Else
            MessageBox.Show("You are at the end of the submissions.")
            currentIndex -= 1
        End If
    End Sub


    Private Async Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If submissions IsNot Nothing AndAlso submissions.Count > currentIndex Then
            Dim index As Integer = currentIndex

            Using client As New HttpClient()
                Try
                    Dim response = Await client.DeleteAsync("http://localhost:3400/delete/" + index.ToString())

                    If response.IsSuccessStatusCode Then
                        MessageBox.Show("Submission deleted successfully!")
                        submissions.RemoveAt(index)


                        If currentIndex >= submissions.Count Then
                            currentIndex = submissions.Count - 1
                        End If


                        If submissions.Count = 0 Then
                            currentIndex = 0
                        End If

                        DisplaySubmission()
                    Else
                        MessageBox.Show("Deletion failed. Error: " & response.StatusCode)
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error deleting submission: " & ex.Message)
                End Try
            End Using
        Else
            MessageBox.Show("No submission to delete.")
        End If
    End Sub


    Private Sub DeleteSubmissions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        FetchSubmission(currentIndex)
    End Sub

    Private Sub DeleteSubmissionsForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        If e.Control AndAlso e.KeyCode = Keys.P Then
            btnPrevClick.PerformClick()
        End If


        If e.Control AndAlso e.KeyCode = Keys.N Then
            btnNextClick.PerformClick()
        End If


        If e.Control AndAlso e.KeyCode = Keys.D Then
            btnDelete.PerformClick()
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class


