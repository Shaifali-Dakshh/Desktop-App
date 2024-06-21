Imports System.IO
Imports Newtonsoft.Json

Module DataStorage
    Private Const SubmissionsFilePath As String = "submissions.json"

    ' Function to load submissions from the JSON file
    Public Function LoadSubmissions() As List(Of Submission)
        If File.Exists(SubmissionsFilePath) Then
            Dim json = File.ReadAllText(SubmissionsFilePath)
            Return JsonConvert.DeserializeObject(Of List(Of Submission))(json)
        End If
        Return New List(Of Submission)()
    End Function

    ' Function to save a new submission to the JSON file
    Public Sub SaveSubmission(submission As Submission)
        Dim submissions = LoadSubmissions()
        submissions.Add(submission)
        Dim json = JsonConvert.SerializeObject(submissions, Formatting.Indented)
        File.WriteAllText(SubmissionsFilePath, json)
    End Sub
End Module
