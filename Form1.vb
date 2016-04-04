Imports System.IO 'File handling module library

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    'Write to file, read from file
        Dim fileName As String = "mybin.bin"
        lblOutput.Text = ""
        
        'Write to file
        Using writer As BinaryWriter = New BinaryWriter(File.Open(fileName, FileMode.Create))
            Dim i As Int32
            For i = 1 To 10
                writer.Write(i * 7)
            Next
        End Using
        
        'Read from file
        Using reader As BinaryReader = New BinaryReader(File.Open(fileName, FileMode.Open))
            For i = 1 To 10
            'Display in label
                lblOutput.Text = lblOutput.Text & i & " " & (reader.ReadInt32) & vbCrLf
            Next
        End Using

    End Sub
End Class
