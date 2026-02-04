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
        btn7 = New Button()
        btn1 = New Button()
        btn2 = New Button()
        btn3 = New Button()
        btn4 = New Button()
        btn5 = New Button()
        btn6 = New Button()
        btn8 = New Button()
        btn9 = New Button()
        Label1 = New Label()
        btnTurn = New Button()
        SuspendLayout()
        ' 
        ' btn7
        ' 
        btn7.Location = New Point(223, 263)
        btn7.Name = "btn7"
        btn7.Size = New Size(75, 67)
        btn7.TabIndex = 6
        btn7.UseVisualStyleBackColor = True
        ' 
        ' btn1
        ' 
        btn1.Location = New Point(223, 53)
        btn1.Name = "btn1"
        btn1.Size = New Size(75, 67)
        btn1.TabIndex = 10
        btn1.UseVisualStyleBackColor = True
        ' 
        ' btn2
        ' 
        btn2.Location = New Point(336, 53)
        btn2.Name = "btn2"
        btn2.Size = New Size(75, 67)
        btn2.TabIndex = 11
        btn2.UseVisualStyleBackColor = True
        ' 
        ' btn3
        ' 
        btn3.Location = New Point(444, 53)
        btn3.Name = "btn3"
        btn3.Size = New Size(75, 67)
        btn3.TabIndex = 12
        btn3.UseVisualStyleBackColor = True
        ' 
        ' btn4
        ' 
        btn4.Location = New Point(223, 161)
        btn4.Name = "btn4"
        btn4.Size = New Size(75, 67)
        btn4.TabIndex = 13
        btn4.UseVisualStyleBackColor = True
        ' 
        ' btn5
        ' 
        btn5.Location = New Point(336, 161)
        btn5.Name = "btn5"
        btn5.Size = New Size(75, 67)
        btn5.TabIndex = 14
        btn5.UseVisualStyleBackColor = True
        ' 
        ' btn6
        ' 
        btn6.Location = New Point(444, 161)
        btn6.Name = "btn6"
        btn6.Size = New Size(75, 67)
        btn6.TabIndex = 15
        btn6.UseVisualStyleBackColor = True
        ' 
        ' btn8
        ' 
        btn8.Location = New Point(336, 263)
        btn8.Name = "btn8"
        btn8.Size = New Size(75, 67)
        btn8.TabIndex = 16
        btn8.UseVisualStyleBackColor = True
        ' 
        ' btn9
        ' 
        btn9.Location = New Point(444, 263)
        btn9.Name = "btn9"
        btn9.Size = New Size(75, 67)
        btn9.TabIndex = 17
        btn9.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(623, 105)
        Label1.Name = "Label1"
        Label1.Size = New Size(75, 15)
        Label1.TabIndex = 18
        Label1.Text = "Current Turn"
        ' 
        ' btnTurn
        ' 
        btnTurn.Location = New Point(623, 134)
        btnTurn.Name = "btnTurn"
        btnTurn.Size = New Size(67, 33)
        btnTurn.TabIndex = 19
        btnTurn.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Turquoise
        ClientSize = New Size(800, 450)
        Controls.Add(btnTurn)
        Controls.Add(Label1)
        Controls.Add(btn9)
        Controls.Add(btn8)
        Controls.Add(btn6)
        Controls.Add(btn5)
        Controls.Add(btn4)
        Controls.Add(btn3)
        Controls.Add(btn2)
        Controls.Add(btn1)
        Controls.Add(btn7)
        Name = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btn7 As Button
    Friend WithEvents btn1 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnTurn As Button

End Class
