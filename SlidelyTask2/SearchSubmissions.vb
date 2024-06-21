Imports System.Net.Http
Imports Newtonsoft.Json

Public Class SearchSubmissions
    Dim submissions As New List(Of Submission)
    Dim currentIndex As Integer = 0

    Private Async Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim email As String = txtSearch.Text.Trim()

        If String.IsNullOrEmpty(email) Then
            MessageBox.Show("Please enter an email to search.")
            Return
        End If

        Using client As New HttpClient()
            Try
                Dim response = Await client.GetAsync("http://localhost:3400/search/?email=" & email)
                If response.IsSuccessStatusCode Then
                    Dim json As String = Await response.Content.ReadAsStringAsync()
                    submissions = JsonConvert.DeserializeObject(Of List(Of Submission))(json)

                    If submissions.Count > 0 Then
                        currentIndex = 0
                        DisplaySubmissions()
                    Else
                        MessageBox.Show("No submissions found for the provided email.")
                        lstResults.Items.Clear()
                    End If
                Else
                    MessageBox.Show("No submissions found for the provided email.")
                End If
            Catch ex As Exception
                MessageBox.Show("Error searching submissions: " & ex.Message)
            End Try
        End Using
    End Sub


    Private Sub DisplaySubmissions()
        lstResults.Items.Clear()

        If submissions IsNot Nothing AndAlso submissions.Count > 0 Then
            For Each submission As Submission In submissions
                lstResults.Items.Add($"Name: {submission.Name}")
                lstResults.Items.Add($"Email: {submission.Email}")
                lstResults.Items.Add($"Phone: {submission.Phone}")
                lstResults.Items.Add($"GitHub: {submission.Github_Link}")
                lstResults.Items.Add($"Time: {submission.Stopwatch_Time}")
                lstResults.Items.Add("")
            Next
        Else
            MessageBox.Show("No submissions to display.")
        End If
    End Sub

    Private Sub SearchSubmissions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
    End Sub

    Private Sub SearchSubmissions_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.S Then
            btnSearch.PerformClick()
        End If
    End Sub

    Private Sub btnPrevClick_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnNextClick_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lstResults_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstResults.SelectedIndexChanged

    End Sub
End Class



