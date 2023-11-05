Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim myItems
        myItems = InputBox("Enter your fav Phone")
        ComboBox1.Items.Add(myItems)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim myItems2
        myItems2 = InputBox("Enter your fav Phone")
        ComboBox1.Items.Remove(myItems2)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        ComboBox1.Items.Remove(ComboBox1.SelectedItem)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        ComboBox1.Items.Clear()
    End Sub
End Class
