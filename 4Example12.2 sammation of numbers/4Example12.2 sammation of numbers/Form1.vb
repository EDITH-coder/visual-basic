Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim numbers, sum As Integer
        For numbers = 1 To 10 Step 2
            sum += numbers
            ListBox1.Items.Add(sum)
        Next
    End Sub
    'Example 12.3 Negative Increment in a foor next loop
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim numbers, sum As Integer
        For numbers = 100 To 10 Step -5
            sum -= numbers
            ListBox1.Items.Add(sum)
        Next
    End Sub
End Class
