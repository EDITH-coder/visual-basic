Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim numbers As Integer

        For numbers = 0 To 10
            'ListBox1.Items.Add(numbers)numb    
            MsgBox(numbers)
        Next
        MsgBox("finish")
    End Sub
End Class
