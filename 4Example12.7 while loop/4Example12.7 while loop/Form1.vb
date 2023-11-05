Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sum, n As Integer
        ListBox1.Items.Add("n" & vbTab & "sum")
        ListBox1.Items.Add("---------------")
        While n <> 20
            n += 2
            sum += n
            ListBox1.Items.Add(n & vbTab & sum)
        End While
    End Sub
End Class
