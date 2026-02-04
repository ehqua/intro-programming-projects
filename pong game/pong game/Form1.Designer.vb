<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        components = New ComponentModel.Container()
        PaddlePlayer = New PictureBox()
        ball = New PictureBox()
        lblScore = New Label()
        GameTimer = New Timer(components)
        PaddleCPU = New PictureBox()
        CType(PaddlePlayer, ComponentModel.ISupportInitialize).BeginInit()
        CType(ball, ComponentModel.ISupportInitialize).BeginInit()
        CType(PaddleCPU, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PaddlePlayer
        ' 
        PaddlePlayer.BackColor = Color.White
        PaddlePlayer.Location = New Point(333, 398)
        PaddlePlayer.Name = "PaddlePlayer"
        PaddlePlayer.Size = New Size(100, 20)
        PaddlePlayer.TabIndex = 0
        PaddlePlayer.TabStop = False
        ' 
        ' ball
        ' 
        ball.BackColor = Color.White
        ball.Location = New Point(373, 197)
        ball.Name = "ball"
        ball.Size = New Size(20, 20)
        ball.TabIndex = 1
        ball.TabStop = False
        ' 
        ' lblScore
        ' 
        lblScore.AutoSize = True
        lblScore.ForeColor = SystemColors.Control
        lblScore.Location = New Point(12, 9)
        lblScore.Name = "lblScore"
        lblScore.Size = New Size(92, 15)
        lblScore.TabIndex = 2
        lblScore.Text = "Player: 0 CPU: 0 "
        ' 
        ' GameTimer
        ' 
        GameTimer.Enabled = True
        GameTimer.Interval = 20
        ' 
        ' PaddleCPU
        ' 
        PaddleCPU.BackColor = Color.White
        PaddleCPU.Location = New Point(333, 12)
        PaddleCPU.Name = "PaddleCPU"
        PaddleCPU.Size = New Size(100, 20)
        PaddleCPU.TabIndex = 3
        PaddleCPU.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(800, 450)
        Controls.Add(PaddleCPU)
        Controls.Add(lblScore)
        Controls.Add(ball)
        Controls.Add(PaddlePlayer)
        Name = "Form1"
        Text = "pong"
        CType(PaddlePlayer, ComponentModel.ISupportInitialize).EndInit()
        CType(ball, ComponentModel.ISupportInitialize).EndInit()
        CType(PaddleCPU, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PaddlePlayer As PictureBox
    Friend WithEvents ball As PictureBox
    Friend WithEvents lblScore As Label
    Friend WithEvents GameTimer As Timer
    Friend WithEvents PaddleCPU As PictureBox

End Class
