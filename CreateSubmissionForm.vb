Public Class CreateSubmissionForm
    Private stopwatch As Stopwatch = New Stopwatch()

    Private Sub ToggleStopwatchButton_Click(sender As Object, e As EventArgs) Handles ToggleStopwatchButton.Click
        If stopwatch.IsRunning Then
            stopwatch.Stop()
        Else
            stopwatch.Start()
        End If
        UpdateStopwatchTime()
    End Sub

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        ' Create a new submission and save it to the backend or data storage
        Dim submission As New Submission With {
            .Name = TextBox1.Text,
            .Email = TextBox2.Text,
            .PhoneNum = TextBox3.Text,
            .GithubLink = TextBox4.Text,
            .StopwatchTime = stopwatch.Elapsed
        }
        SaveSubmission(submission)
        Me.Close()
    End Sub

    Private Sub UpdateStopwatchTime()
        Label5.Text = stopwatch.Elapsed.ToString("hh\:mm\:ss")
    End Sub

    Private Sub CreateSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim timer As New Timer()
        AddHandler timer.Tick, Sub() UpdateStopwatchTime()
        timer.Interval = 1000
        timer.Start()
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If keyData = (Keys.Control Or Keys.T) Then
            ToggleStopwatchButton.PerformClick()
            Return True
        ElseIf keyData = (Keys.Control Or Keys.S) Then
            SubmitButton.PerformClick()
            Return True
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function
End Class
