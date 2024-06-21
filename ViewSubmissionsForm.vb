Public Class ViewSubmissionsForm
    Private currentIndex As Integer = 0
    Private submissions As List(Of Dictionary(Of String, String))

    Private Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load the first submission
        LoadSubmission(currentIndex)
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        currentIndex += 1
        If currentIndex < submissions.Count Then
            LoadSubmission(currentIndex)
        Else
            currentIndex -= 1
        End If
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        currentIndex -= 1
        If currentIndex >= 0 Then
            LoadSubmission(currentIndex)
        Else
            currentIndex += 1
        End If
    End Sub

    Private Sub LoadSubmission(index As Integer)
        ' Code to load the submission data from the backend server
    End Sub
End Class
