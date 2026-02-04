Public Class Form1
    Private Sub btnClickClack_Click(sender As Object, e As EventArgs) Handles btnClickClack.Click
        Dim RNG As New Random
        Dim strNumber As String
        strNumber = RNG.Next(1, 21)
        strNumber = Label2.Text
        Select Case RNG.Next(1, 21)
            Case 1
                Label2.Text = "It is certain"
            Case 2
                Label2.Text = "It is decidedly so"
            Case 3
                Label2.Text = "Without a doubt"
            Case 4
                Label2.Text = "Yes definitely"
            Case 5
                Label2.Text = "You may rely on it"
            Case 6
                Label2.Text = "As I see it. yes"
            Case 7
                Label2.Text = "Most likely"
            Case 8
                Label2.Text = "Outlook good"
            Case 9
                Label2.Text = "Yes"
            Case 10
                Label2.Text = "Signs point to yes"
            Case 11
                Label2.Text = "Reply hazy, try again"
            Case 12
                Label2.Text = "Ask again later"
            Case 13
                Label2.Text = "Better not to tell you now"
            Case 14
                Label2.Text = "Cannot predict now"
            Case 15
                Label2.Text = "Concentrate and ask again"
            Case 16
                Label2.Text = "Don't count on it"
            Case 17
                Label2.Text = "My reply is no"
            Case 18
                Label2.Text = "My sources say no"
            Case 19
                Label2.Text = "Outlook not so good"
            Case 20
                Label2.Text = "Very Doubtful"
        End Select


    End Sub
End Class
