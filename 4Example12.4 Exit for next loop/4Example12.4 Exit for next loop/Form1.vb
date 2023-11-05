Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n As Integer
        For n = 1 To 10
            If n > 10 Then
                Exit For
            Else
                ListBox1.Items.Add(n)
            End If
        Next
    End Sub
End Class
