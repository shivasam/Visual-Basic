Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            TextBox2.Text = TextBox1.Text * 3
            TextBox3.Text = TextBox1.Text * 36
            TextBox4.Text = TextBox1.Text * 91.44
        Catch ex As Exception
            MsgBox("Please enter valid number")
        End Try

    End Sub
End Class

