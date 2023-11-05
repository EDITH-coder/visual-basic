Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim sum, n As Integer
        MyListBox.Items.Add("n" & vbTab & "Sum")
        MyListBox.Items.Add("---------------")
        Do
            n += 1
            sum += n
            MyListBox.Items.Add(n & vbTab & sum)
            If n = 20 Then
                Exit Do
            End If
        Loop
    End Sub
End Class
