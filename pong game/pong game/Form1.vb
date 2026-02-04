Public Class Form1

    Dim ballXSpeed As Integer = 4
    Dim ballYSpeed As Integer = 4

    Dim paddleSpeed As Integer = 20
    Dim cpuSpeed As Integer = 4

    Dim playerScore As Integer = 0
    Dim cpuScore As Integer = 0

    Private Sub gameTimer_Tick(sender As Object, e As EventArgs) Handles gameTimer.Tick

        ball.Left += ballXSpeed
        ball.Top += ballYSpeed

        If ball.Left <= 0 Or ball.Right >= Me.ClientSize.Width Then
            ballXSpeed = -ballXSpeed
        End If

        If ball.Bounds.IntersectsWith(paddlePlayer.Bounds) Then
            ballYSpeed = -ballYSpeed
        End If

        If ball.Bounds.IntersectsWith(paddleCPU.Bounds) Then
            ballYSpeed = -ballYSpeed
        End If

        If ball.Left < paddleCPU.Left Then
            paddleCPU.Left -= cpuSpeed
        ElseIf ball.Right > paddleCPU.Right Then
            paddleCPU.Left += cpuSpeed
        End If

        If ball.Top <= 0 Then
            playerScore += 1
            ResetBall()
        End If

        If ball.Bottom >= Me.ClientSize.Height Then
            cpuScore += 1
            ResetBall()
        End If

        lblScore.Text = "Player: " & playerScore & "  CPU: " & cpuScore

        If playerScore = 3 Then
            gameTimer.Stop()
            MessageBox.Show("You win!")
        ElseIf cpuScore = 3 Then
            gameTimer.Stop()
            MessageBox.Show("Computer wins!")
        End If

    End Sub

    Private Sub ResetBall()
        ball.Left = (Me.ClientSize.Width \ 2) - (ball.Width \ 2)
        ball.Top = (Me.ClientSize.Height \ 2) - (ball.Height \ 2)
        ballYSpeed = -ballYSpeed
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = Keys.Left And paddlePlayer.Left > 0 Then
            paddlePlayer.Left -= paddleSpeed
        End If

        If e.KeyCode = Keys.Right And paddlePlayer.Right < Me.ClientSize.Width Then
            paddlePlayer.Left += paddleSpeed
        End If

    End Sub

End Class
