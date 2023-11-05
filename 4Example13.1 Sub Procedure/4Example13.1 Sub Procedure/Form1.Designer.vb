<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        TextBoxX = New TextBox()
        TextBoxY = New TextBox()
        TextSum = New TextBox()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(24, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(76, 15)
        Label1.TabIndex = 0
        Label1.Text = "First Number"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(29, 79)
        Label2.Name = "Label2"
        Label2.Size = New Size(93, 15)
        Label2.TabIndex = 1
        Label2.Text = "Second Number"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(27, 122)
        Label3.Name = "Label3"
        Label3.Size = New Size(31, 15)
        Label3.TabIndex = 2
        Label3.Text = "Sum"
        ' 
        ' TextBoxX
        ' 
        TextBoxX.Location = New Point(246, 28)
        TextBoxX.Name = "TextBoxX"
        TextBoxX.Size = New Size(205, 23)
        TextBoxX.TabIndex = 3
        ' 
        ' TextBoxY
        ' 
        TextBoxY.Location = New Point(246, 71)
        TextBoxY.Name = "TextBoxY"
        TextBoxY.Size = New Size(205, 23)
        TextBoxY.TabIndex = 4
        ' 
        ' TextSum
        ' 
        TextSum.Location = New Point(246, 114)
        TextSum.Name = "TextSum"
        TextSum.Size = New Size(205, 23)
        TextSum.TabIndex = 5
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(246, 229)
        Button1.Name = "Button1"
        Button1.Size = New Size(129, 50)
        Button1.TabIndex = 6
        Button1.Text = "Compute"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button1)
        Controls.Add(TextSum)
        Controls.Add(TextBoxY)
        Controls.Add(TextBoxX)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxX As TextBox
    Friend WithEvents TextBoxY As TextBox
    Friend WithEvents TextSum As TextBox
    Friend WithEvents Button1 As Button
End Class
