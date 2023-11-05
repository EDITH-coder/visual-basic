Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim x, y As Single

        x = Val(TextBoxX.Text)

        y = Val(TextBoxY.Text)

        Sum(x, y)
    End Sub


    Sub Sum(a As Single, b As Single)
        Dim mySum As Single

        mySum = a + b

        TextSum.Text = mySum

    End Sub
End Class
