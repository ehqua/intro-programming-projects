Public Class Form1
    Dim RNG As New Random
    Dim intCheat As Integer
    Dim intGuess As Integer
    Dim intRmGuess As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        intCheat = RNG.Next(1, 101)
        lblCheat.Text = intCheat
        lblRemainingGuess.Text = intRmGuess

        If intRmGuess = 0 Then
            intRmGuess += 10
            lblRemainingGuess.Text = "Remaining Guesses " & intRmGuess
        End If
    End Sub

    Private Sub btnGuess_Click(sender As Object, e As EventArgs) Handles btnGuess.Click
        intGuess = tbxNumber.Text
        If intGuess > intCheat Then
            intRmGuess -= 1
            lblRemainingGuess.Text = "Remaining Guesses " & intRmGuess
            lblHighLow.Text = "Too High"
        End If
        If intGuess < intCheat Then
            intRmGuess -= 1
            lblRemainingGuess.Text = "Remaining Guesses " & intRmGuess
            lblHighLow.Text = "Too Low"
        End If
        If intRmGuess = 0 Then
            MessageBox.Show("You Lose")
        End If
        If intRmGuess = 0 Then
            intCheat = RNG.Next(1, 101)
            lblCheat.Text = intCheat
            intRmGuess += 10
            lblRemainingGuess.Text = "Remaining Guesses " & intRmGuess
            lblHighLow.Text = "High/Low"
        End If
        If intGuess = intCheat Then
            MessageBox.Show("You Win")
            intCheat = RNG.Next(1, 101)
            lblCheat.Text = intCheat
            intRmGuess = 10
            lblRemainingGuess.Text = "Remaining Guesses " & intRmGuess
            lblHighLow.Text = "High/Low"
        End If
    End Sub
End Class