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
        MyListBox = New ListBox()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' MyListBox
        ' 
        MyListBox.FormattingEnabled = True
        MyListBox.ItemHeight = 15
        MyListBox.Location = New Point(240, 87)
        MyListBox.Name = "MyListBox"
        MyListBox.Size = New Size(120, 94)
        MyListBox.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(224, 236)
        Button1.Name = "Button1"
        Button1.Size = New Size(161, 43)
        Button1.TabIndex = 1
        Button1.Text = "Compute"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button1)
        Controls.Add(MyListBox)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents MyListBox As ListBox
    Friend WithEvents Button1 As Button
End Class
