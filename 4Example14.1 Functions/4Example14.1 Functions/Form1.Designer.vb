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
        Button1 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        TxtHeight = New TextBox()
        TxtWeight = New TextBox()
        TxtBMI = New TextBox()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(147, 257)
        Button1.Name = "Button1"
        Button1.Size = New Size(184, 52)
        Button1.TabIndex = 0
        Button1.Text = "Calculate"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(32, 96)
        Label1.Name = "Label1"
        Label1.Size = New Size(43, 15)
        Label1.TabIndex = 1
        Label1.Text = "Height"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(32, 149)
        Label2.Name = "Label2"
        Label2.Size = New Size(45, 15)
        Label2.TabIndex = 2
        Label2.Text = "Weight"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(32, 204)
        Label3.Name = "Label3"
        Label3.Size = New Size(28, 15)
        Label3.TabIndex = 3
        Label3.Text = "BMI"
        ' 
        ' TxtHeight
        ' 
        TxtHeight.Location = New Point(187, 95)
        TxtHeight.Name = "TxtHeight"
        TxtHeight.Size = New Size(222, 23)
        TxtHeight.TabIndex = 4
        ' 
        ' TxtWeight
        ' 
        TxtWeight.Location = New Point(187, 145)
        TxtWeight.Name = "TxtWeight"
        TxtWeight.Size = New Size(222, 23)
        TxtWeight.TabIndex = 5
        ' 
        ' TxtBMI
        ' 
        TxtBMI.Location = New Point(187, 195)
        TxtBMI.Name = "TxtBMI"
        TxtBMI.Size = New Size(222, 23)
        TxtBMI.TabIndex = 6
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TxtBMI)
        Controls.Add(TxtWeight)
        Controls.Add(TxtHeight)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtHeight As TextBox
    Friend WithEvents TxtWeight As TextBox
    Friend WithEvents TxtBMI As TextBox
End Class
