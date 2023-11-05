Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' ListBox1.Items.Add("Edith")

        'Declare a variable

        Dim myItem
        myItem = InputBox("Enter your phone")
        ListBox1.Items.Add(myItem)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim myItem2
        myItem2 = InputBox("Enter the phone you want to remove")
        ListBox1.Items.Remove(myItem2)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox1.Items.Remove(ListBox1.SelectedItem)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ListBox1.Items.Clear()
    End Sub
End Class
