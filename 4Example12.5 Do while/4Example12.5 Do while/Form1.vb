Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim numbers As Integer

        Do While numbers < 10
            numbers += 1
            ListBox1.Items.Add(numbers)
        Loop
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim counter As Integer

        Do
            ListBox1.Items.Add(counter)
            counter += 1
        Loop Until counter >= 10
    End Sub
End Class
