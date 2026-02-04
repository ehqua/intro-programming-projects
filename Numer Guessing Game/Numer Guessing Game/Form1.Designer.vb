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
        btnGuess = New Button()
        tbxNumber = New TextBox()
        lblHighLow = New Label()
        Label2 = New Label()
        lblCheat = New Label()
        lblRemainingGuess = New Label()
        SuspendLayout()
        ' 
        ' btnGuess
        ' 
        btnGuess.Location = New Point(276, 205)
        btnGuess.Name = "btnGuess"
        btnGuess.Size = New Size(75, 23)
        btnGuess.TabIndex = 0
        btnGuess.Text = "Guess"
        btnGuess.UseVisualStyleBackColor = True
        ' 
        ' tbxNumber
        ' 
        tbxNumber.Location = New Point(261, 166)
        tbxNumber.Name = "tbxNumber"
        tbxNumber.Size = New Size(100, 23)
        tbxNumber.TabIndex = 1
        ' 
        ' lblHighLow
        ' 
        lblHighLow.AutoSize = True
        lblHighLow.Location = New Point(293, 247)
        lblHighLow.Name = "lblHighLow"
        lblHighLow.Size = New Size(60, 15)
        lblHighLow.TabIndex = 2
        lblHighLow.Text = "High/Low"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(205, 67)
        Label2.Name = "Label2"
        Label2.Size = New Size(235, 15)
        Label2.TabIndex = 3
        Label2.Text = "10 guesses to guess number between 1-100"
        ' 
        ' lblCheat
        ' 
        lblCheat.AutoSize = True
        lblCheat.Location = New Point(26, 39)
        lblCheat.Name = "lblCheat"
        lblCheat.Size = New Size(38, 15)
        lblCheat.TabIndex = 4
        lblCheat.Text = "Cheat"
        ' 
        ' lblRemainingGuess
        ' 
        lblRemainingGuess.AutoSize = True
        lblRemainingGuess.Location = New Point(541, 137)
        lblRemainingGuess.Name = "lblRemainingGuess"
        lblRemainingGuess.Size = New Size(109, 15)
        lblRemainingGuess.TabIndex = 5
        lblRemainingGuess.Text = "Remaining Guesses"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblRemainingGuess)
        Controls.Add(lblCheat)
        Controls.Add(Label2)
        Controls.Add(lblHighLow)
        Controls.Add(tbxNumber)
        Controls.Add(btnGuess)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnGuess As Button
    Friend WithEvents tbxNumber As TextBox
    Friend WithEvents lblHighLow As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblCheat As Label
    Friend WithEvents lblRemainingGuess As Label

End Class
