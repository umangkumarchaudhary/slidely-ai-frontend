Imports System.Drawing.Drawing2D

Public Class Main
    Private Sub btnViewSub_Click(sender As Object, e As EventArgs) Handles btnViewSub.Click

        Dim viewSubmissionsForm As New ViewSubmissions()

        viewSubmissionsForm.Show()
    End Sub

    Private Sub btnCreateSub_Click(sender As Object, e As EventArgs) Handles btnCreateSub.Click
        Dim createForm As New CreateSubmissions()
        createForm.Show()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim deleteForm As New DeleteSubmissions()
        deleteForm.Show()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim editForm As New EditSubmissions()
        editForm.Show()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim searchForm As New SearchSubmissions()
        searchForm.Show()
    End Sub '


    Private Sub Main_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        If e.Control AndAlso e.KeyCode = Keys.V Then

            btnViewSub.PerformClick()
        End If

        If e.Control AndAlso e.KeyCode = Keys.N Then

            btnCreateSub.PerformClick()
        End If

        If e.Control AndAlso e.KeyCode = Keys.D Then

            btnDelete.PerformClick()
        End If

        If e.Control AndAlso e.KeyCode = Keys.E Then

            btnEdit.PerformClick()
        End If

        If e.Control AndAlso e.KeyCode = Keys.S Then

            btnSearch.PerformClick()
        End If
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

