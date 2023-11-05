Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim year As Integer
        year = Val(TextBox1.Text)
        If (year Mod 4 = 0 & year Mod 100 <> 0) Then
            MsgBox("is a leap year")
        Else
            MsgBox("is not a leap year")
        End If
    End Sub
    'Program to check if number is odd or prime
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim numbers As Integer
        numbers = Val(TextBox2.Text)
        If (numbers Mod 2 = 0) Then
            MsgBox("")
        End If


    End Sub
End Class
