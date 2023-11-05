Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        For num = 1 To 5
            num += 1
            MsgBox(num)

            If num = 4 Then
                Exit For
            End If
        Next

        MsgBox("Out of the loop")
    End Sub
End Class
