Imports System.Drawing.Text

Public Class Form1
    Dim intPlayerTurn As Integer
    Dim strButton1 As String
    Dim strButton2 As String
    Dim strButton3 As String
    Dim strButton4 As String
    Dim strButton5 As String
    Dim strButton6 As String
    Dim strButton7 As String
    Dim strButton8 As String
    Dim strButton9 As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        intPlayerTurn = 1
        btnTurn.Text = "X"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        If btn1.Text = "" Then
            If intPlayerTurn = 1 Then
                btn1.Text = "X"
            End If
            If intPlayerTurn = 2 Then
                btn1.Text = "O"
            End If
            TurnChange()
            XWin()
            OWin()

        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        If btn2.Text = "" Then
            If intPlayerTurn = 1 Then
                btn2.Text = "X"
            End If
            If intPlayerTurn = 2 Then
                btn2.Text = "O"
            End If
            TurnChange()
            XWin()
            OWin()
        End If

    End Sub
    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        If btn3.Text = "" Then
            If intPlayerTurn = 1 Then
                btn3.Text = "X"
            End If
            If intPlayerTurn = 2 Then
                btn3.Text = "O"
            End If
            TurnChange()
            XWin()
            OWin()
        End If
    End Sub
    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        If btn4.Text = "" Then
            If intPlayerTurn = 1 Then
                btn4.Text = "X"
            End If
            If intPlayerTurn = 2 Then
                btn4.Text = "O"
            End If
            TurnChange()
            XWin()
            OWin()
        End If

    End Sub
    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        If btn5.Text = "" Then
            If intPlayerTurn = 1 Then
                btn5.Text = "X"
            End If
            If intPlayerTurn = 2 Then
                btn5.Text = "O"
            End If
            TurnChange()
            XWin()
            OWin()
        End If
    End Sub
    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        If btn6.Text = "" Then
            If intPlayerTurn = 1 Then
                btn6.Text = "X"
            End If
            If intPlayerTurn = 2 Then
                btn6.Text = "O"
            End If
            TurnChange()
            XWin()
            OWin()
        End If
    End Sub
    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        If btn7.Text = "" Then
            If intPlayerTurn = 1 Then
                btn7.Text = "X"
            End If
            If intPlayerTurn = 2 Then
                btn7.Text = "O"
            End If
            TurnChange()
            XWin()
            OWin()
        End If
    End Sub
    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        If btn8.Text = "" Then
            If intPlayerTurn = 1 Then
                btn8.Text = "X"
            End If
            If intPlayerTurn = 2 Then
                btn8.Text = "O"
            End If
            TurnChange()
            XWin()
            OWin()
        End If
    End Sub
    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        If btn9.Text = "" Then
            If intPlayerTurn = 1 Then
                btn9.Text = "X"
            End If
            If intPlayerTurn = 2 Then
                btn9.Text = "O"
            End If
            TurnChange()
            XWin()
            OWin()
        End If
    End Sub
    Private Sub TurnChange()
        If intPlayerTurn = 1 Then
            intPlayerTurn = 2
            btnTurn.Text = "O"
        Else
            intPlayerTurn = 1
            btnTurn.Text = "X"
        End If
    End Sub
    Private Sub XWin()
        strButton1 = btn1.Text
        strButton2 = btn2.Text
        strButton3 = btn3.Text
        strButton4 = btn4.Text
        strButton5 = btn5.Text
        strButton6 = btn6.Text
        strButton7 = btn7.Text
        strButton8 = btn8.Text
        strButton9 = btn9.Text
        If strButton1 = "X" And strButton2 = "X" And strButton3 = "X" Then
            MessageBox.Show("X Wins!")
            Reset()
        End If
        If strButton4 = "X" And strButton5 = "X" And strButton6 = "X" Then
            MessageBox.Show("X Wins!")
            Reset()
        End If
        If strButton7 = "X" And strButton8 = "X" And strButton9 = "X" Then
            MessageBox.Show("X Wins!")
            Reset()
        End If
        If strButton1 = "X" And strButton4 = "X" And strButton7 = "X" Then
            MessageBox.Show("X Wins!")
            Reset()
        End If
        If strButton2 = "X" And strButton5 = "X" And strButton8 = "X" Then
            MessageBox.Show("X Wins!")
            Reset()
        End If
        If strButton3 = "X" And strButton6 = "X" And strButton9 = "X" Then
            MessageBox.Show("X Wins!")
            Reset()
        End If
        If strButton1 = "X" And strButton5 = "X" And strButton9 = "X" Then
            MessageBox.Show("X Wins!")
            Reset()
        End If
        If strButton3 = "X" And strButton5 = "X" And strButton7 = "X" Then
            MessageBox.Show("X Wins!")
            Reset()
        End If

    End Sub
    Private Sub OWin()
        strButton1 = btn1.Text
        strButton2 = btn2.Text
        strButton3 = btn3.Text
        strButton4 = btn4.Text
        strButton5 = btn5.Text
        strButton6 = btn6.Text
        strButton7 = btn7.Text
        strButton8 = btn8.Text
        strButton9 = btn9.Text
        If strButton1 = "O" And strButton2 = "O" And strButton3 = "O" Then
            MessageBox.Show("O Wins!")
            Reset()
        End If
        If strButton4 = "O" And strButton5 = "O" And strButton6 = "O" Then
            MessageBox.Show("O Wins!")
            Reset()
        End If
        If strButton7 = "O" And strButton8 = "O" And strButton9 = "O" Then
            MessageBox.Show("O Wins!")
            Reset()
        End If
        If strButton1 = "O" And strButton4 = "O" And strButton7 = "O" Then
            MessageBox.Show("O Wins!")
            Reset()
        End If
        If strButton2 = "O" And strButton5 = "O" And strButton8 = "O" Then
            MessageBox.Show("O Wins!")
            Reset()
        End If
        If strButton3 = "O" And strButton6 = "O" And strButton9 = "O" Then
            MessageBox.Show("O Wins!")
            Reset()
        End If
        If strButton1 = "O" And strButton5 = "O" And strButton9 = "O" Then
            MessageBox.Show("O Wins!")
            Reset()
        End If
        If strButton3 = "O" And strButton5 = "O" And strButton7 = "O" Then
            MessageBox.Show("O Wins!")
            Reset()
        End If
    End Sub
    Private Sub Reset()
        btn1.Text = ""
        btn2.Text = ""
        btn3.Text = ""
        btn4.Text = ""
        btn5.Text = ""
        btn6.Text = ""
        btn7.Text = ""
        btn8.Text = ""
        btn9.Text = ""
        btnTurn.Text = "X"
        intPlayerTurn = 1
    End Sub
End Class
