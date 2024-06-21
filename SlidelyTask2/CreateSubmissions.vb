Imports System.Net.Http
Imports Newtonsoft.Json
Imports System.Diagnostics
Imports System.Text

Public Class CreateSubmissions

    Private stopwatch As Stopwatch
    Private stopwatchPaused As Boolean


    Public Sub New()
        InitializeComponent()
        stopwatch = New Stopwatch()
        stopwatchPaused = True
        Timer1.Interval = 1000 ' 
    End Sub


    Private Sub btnPauseResume_Click(sender As Object, e As EventArgs) Handles btnPauseResume.Click
        If stopwatchPaused Then
            stopwatch.Start()
            Timer1.Start()
            btnPauseResume.Text = "PAUSE (CTRL + T)"
        Else
            stopwatch.Stop()
            Timer1.Stop()
            btnPauseResume.Text = "RESUME (CTRL + T)"
        End If
        stopwatchPaused = Not stopwatchPaused
    End Sub


    Private Async Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim submission As New Submission With {
        .Name = txtName.Text,
        .Email = txtEmail.Text,
        .Phone = txtPhone.Text,
        .Github_Link = txtGithub_Link.Text,
        .Stopwatch_Time = String.Format("{0:hh\:mm\:ss}", stopwatch.Elapsed)
    }

        Dim json As String = JsonConvert.SerializeObject(submission)



        Dim content As New StringContent(json, Encoding.UTF8, "application/json")

        Using client As New HttpClient()
            Try
                Dim response = Await client.PostAsync("http://localhost:3400/submit", content)
                If response.IsSuccessStatusCode Then
                    MessageBox.Show("Submission successful!")
                    AskForAnotherSubmission()
                Else
                    MessageBox.Show("Submission failed. Error: " & response.StatusCode)
                End If
            Catch ex As Exception
                MessageBox.Show("Error submitting data: " & ex.Message)
            End Try
        End Using
    End Sub


    Private Sub CreateSubmissionForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.S Then
            btnSubmit.PerformClick()
        End If

        If e.Control AndAlso e.KeyCode = Keys.T Then

            btnPauseResume.PerformClick()
        End If
    End Sub

    Private Sub AskForAnotherSubmission()
        Dim result As DialogResult = MessageBox.Show("Do you want to create another submission?", "Create Another Submission", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            ResetForm()
        Else
            Me.Close()
        End If
    End Sub


    Private Sub ResetForm()
        txtName.Clear()
        txtEmail.Clear()
        txtPhone.Clear()
        txtGithub_Link.Clear()
        stopwatch.Reset()
        lblStopwatch.Text = "00:00:00"

        stopwatchPaused = True
    End Sub


    Private Sub CreateSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
    End Sub


    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblStopwatch.Text = String.Format("{0:hh\:mm\:ss}", stopwatch.Elapsed)
    End Sub

    Private Sub lblStopwatch_Click(sender As Object, e As EventArgs) Handles lblStopwatch.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class


