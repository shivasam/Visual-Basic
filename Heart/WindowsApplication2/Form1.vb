Public Class Form1
    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            Dim num1, num2 As Integer
            Dim subtract1 As Integer
            num1 = 220
            num2 = Convert.ToInt32(TextBox1.Text)
            subtract1 = num1 - num2
            TextBox2.Text = subtract1
        Catch ex As Exception
            MsgBox("Please enter valid number")
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
