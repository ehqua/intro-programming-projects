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
        btnClickClack = New Button()
        Label1 = New Label()
        tbx1to20 = New TextBox()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' btnClickClack
        ' 
        btnClickClack.Location = New Point(349, 187)
        btnClickClack.Name = "btnClickClack"
        btnClickClack.Size = New Size(75, 23)
        btnClickClack.TabIndex = 0
        btnClickClack.Text = "Button1"
        btnClickClack.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(349, 93)
        Label1.Name = "Label1"
        Label1.Size = New Size(72, 15)
        Label1.TabIndex = 1
        Label1.Text = "Maigc woah"
        ' 
        ' tbx1to20
        ' 
        tbx1to20.Location = New Point(333, 133)
        tbx1to20.Name = "tbx1to20"
        tbx1to20.Size = New Size(100, 23)
        tbx1to20.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(363, 232)
        Label2.Name = "Label2"
        Label2.Size = New Size(41, 15)
        Label2.TabIndex = 3
        Label2.Text = "Label2"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label2)
        Controls.Add(tbx1to20)
        Controls.Add(Label1)
        Controls.Add(btnClickClack)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnClickClack As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents tbx1to20 As TextBox
    Friend WithEvents Label2 As Label

End Class
