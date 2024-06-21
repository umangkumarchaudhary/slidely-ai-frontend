Imports System.Net.Http
Imports Newtonsoft.Json

Public Class ViewSubmissions

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

                        If submissions.Count <= index Then
                            submissions.Add(submission)
                        Else
                            submissions(index) = submission
                        End If
                        DisplaySubmission()
                    Else
                        MessageBox.Show("No submission found at the specified index.")
                    End If
                Else
                    MessageBox.Show("You are at the end of submission")
                End If
            Catch ex As Exception
                MessageBox.Show("Error" + ex.Message)
            End Try
        End Using
    End Sub


    Private Sub DisplaySubmission()
        If submissions IsNot Nothing AndAlso submissions.Count > currentIndex Then
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
        If (currentIndex <= submissions.Count) Then
            FetchSubmission(currentIndex)
        Else
            MessageBox.Show("You are at the end of the submissions.")
            currentIndex -= 1
        End If
    End Sub


    Private Sub ViewSubmissions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        FetchSubmission(currentIndex)
    End Sub

    Private Sub ViewSubmissionsForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        If e.Control AndAlso e.KeyCode = Keys.P Then

            btnPrevClick.PerformClick()
        End If

        If e.Control AndAlso e.KeyCode = Keys.N Then

            btnNextClick.PerformClick()
        End If
    End Sub

End Class


