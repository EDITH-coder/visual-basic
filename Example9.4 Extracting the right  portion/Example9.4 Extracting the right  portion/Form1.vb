Public Class Form1
    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click

        Dim MyText As String
        MyText = "Visual Basic"
        ' extract the right and left text
        MsgBox(Microsoft.VisualBasic.Right(MyText, 4))
        MsgBox(Microsoft.VisualBasic.Left(MyText, 6))
        'convert text to uppercase
        MsgBox(Microsoft.VisualBasic.UCase(MyText))
    End Sub
End Class
