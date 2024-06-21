Imports System.Net.Http
Imports Newtonsoft.Json
Imports System.Text
Imports System.Diagnostics

Public Class EditSubmissions

    Dim submissions As New List(Of Submission)
    Dim currentIndex As Integer = 0
    Private stopwatch As Stopwatch
    Private stopwatchPaused As Boolean


    Public Sub New()
        InitializeComponent()
        stopwatch = New Stopwatch()
        stopwatchPaused = True
        Timer1.Interval = 1000
    End Sub


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
                    MessageBox.Show("You are at the end of submissions.")
                End If
            Catch ex As Exception
                MessageBox.Show("Error: " + ex.Message)
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
            lblStopwatch.Text = currentSubmission.Stopwatch_Time
        Else

            txtName.Text = ""
            txtEmail.Text = ""
            txtphone.Text = ""
            txtGithub_Link.Text = ""
            lblStopwatch.Text = ""
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

    Private Async Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If submissions IsNot Nothing AndAlso submissions.Count > currentIndex Then
            Dim updatedSubmission As New Submission With {
                .Name = txtName.Text,
                .Email = txtEmail.Text,
                .Phone = txtphone.Text,
                .Github_Link = txtGithub_Link.Text,
                .Stopwatch_Time = lblStopwatch.Text
            }

            Dim json As String = JsonConvert.SerializeObject(updatedSubmission)
            Dim content As New StringContent(json, Encoding.UTF8, "application/json")
            Dim index As String = currentIndex

            Using client As New HttpClient()
                Try
                    Dim response = Await client.PutAsync("http://localhost:3400/edit/" + index, content)
                    If response.IsSuccessStatusCode Then
                        MessageBox.Show("Submission updated successfully!")
                        submissions(currentIndex) = updatedSubmission
                    Else
                        MessageBox.Show("Update failed. Error: " & response.StatusCode)
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error updating submission: " & ex.Message)
                End Try
            End Using
        Else
            MessageBox.Show("No submission to update.")
        End If
    End Sub


    Private Sub btnPauseResume_Click(sender As Object, e As EventArgs) Handles btnPauseResume.Click
        If stopwatchPaused Then
            stopwatch.Start()
            Timer1.Start()
            btnPauseResume.Text = "Pause"
        Else
            stopwatch.Stop()
            Timer1.Stop()
            btnPauseResume.Text = "Resume"
        End If
        stopwatchPaused = Not stopwatchPaused
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblStopwatch.Text = String.Format("{0:hh\:mm\:ss}", stopwatch.Elapsed)
    End Sub


    Private Sub EditSubmissions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        FetchSubmission(currentIndex)
    End Sub

    Private Sub EditSubmissionsForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        If e.Control AndAlso e.KeyCode = Keys.P Then
            btnPrevClick.PerformClick()
        End If

        If e.Control AndAlso e.KeyCode = Keys.N Then
            btnNextClick.PerformClick()
        End If


        If e.Control AndAlso e.KeyCode = Keys.E Then
            btnEdit.PerformClick()
        End If
    End Sub
End Class



