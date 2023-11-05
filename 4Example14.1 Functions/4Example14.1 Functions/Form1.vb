Public Class Form1

    Private Function BMI(Height As Single, weight As Single) As Double
        BMI = weight / Height ^ 2
    End Function


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim h As Single, w As Single
        h = Val(TxtHeight.Text)
        w = Val(TxtWeight.Text)
        TxtBMI.Text = BMI(h, w)
        ' TxtBMI.Text = Format(BMI(h, w), "0.00")
    End Sub
End Class
