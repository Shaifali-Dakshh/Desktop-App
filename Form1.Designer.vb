<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        ViewSubmissionsButton = New Button()
        CreateSubmissionButton = New Button()
        SuspendLayout()
        ' 
        ' ViewSubmissionsButton
        ' 
        ViewSubmissionsButton.Location = New Point(111, 58)
        ViewSubmissionsButton.Name = "ViewSubmissionsButton"
        ViewSubmissionsButton.Size = New Size(227, 23)
        ViewSubmissionsButton.TabIndex = 0
        ViewSubmissionsButton.Text = "VIEW SUBMISSIONS (CTRL + V)"
        ViewSubmissionsButton.UseVisualStyleBackColor = True
        ' 
        ' CreateSubmissionButton
        ' 
        CreateSubmissionButton.Location = New Point(111, 112)
        CreateSubmissionButton.Name = "CreateSubmissionButton"
        CreateSubmissionButton.Size = New Size(227, 23)
        CreateSubmissionButton.TabIndex = 1
        CreateSubmissionButton.Text = "CREATE NEW SUBMISSION (CTRL + N)"
        CreateSubmissionButton.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(CreateSubmissionButton)
        Controls.Add(ViewSubmissionsButton)
        KeyPreview = True
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents ViewSubmissionsButton As Button
    Friend WithEvents CreateSubmissionButton As Button

End Class
