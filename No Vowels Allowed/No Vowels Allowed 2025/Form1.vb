Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim strOriginal As String
        Dim strNew As String
        strOriginal = RichTextBox1.Text
        For index = 0 To strOriginal.Length() - 1
            Dim check As Char = strOriginal(index)
            If check <> "a" And check <> "e" And check <> "i" And check <> "o" And check <> "u" And check <> "A" And check <> "E" And check <> "I" And check <> "O" And check <> "U" Then
                strNew &= check
            End If
        Next
        RichTextBox2.Text = strNew
    End Sub
End Class
