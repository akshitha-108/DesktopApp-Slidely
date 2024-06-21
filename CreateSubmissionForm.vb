Public Class CreateSubmissionForm
    Private stopwatch As New Stopwatch()

    Private Sub btnStartPause_Click(sender As Object, e As EventArgs) Handles btnStartPause.Click
        If stopwatch.IsRunning Then
            stopwatch.Stop()
            btnStartPause.Text = "Resume"
        Else
            stopwatch.Start()
            btnStartPause.Text = "Pause"
        End If
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' Code to submit data to the backend server
        Dim submission As New Dictionary(Of String, String) From {
            {"name", txtName.Text},
            {"email", txtEmail.Text},
            {"phone", txtPhone.Text},
            {"github_link", txtGithub.Text},
            {"stopwatch_time", stopwatch.Elapsed.ToString()}
        }
        ' Call the backend API to submit the data
    End Sub

    Private Sub CreateSubmissionForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.S Then
            btnSubmit.PerformClick()
        End If
    End Sub
End Class
