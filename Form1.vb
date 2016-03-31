Imports System.IO

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim fileName As String = "mybin.bin"
        lblOutput.Text = ""

        Using writer As BinaryWriter = New BinaryWriter(File.Open(fileName, FileMode.Create))
            Dim i As Int32
            For i = 1 To 10
                writer.Write(i * 7)
            Next
        End Using
        Using reader As BinaryReader = New BinaryReader(File.Open(fileName, FileMode.Open))
            For i = 1 To 10
                lblOutput.Text = lblOutput.Text & i & " " & (reader.ReadInt32) & vbCrLf
            Next
        End Using

    End Sub
End Class
