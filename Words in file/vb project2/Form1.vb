Imports System.ComponentModel

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As CancelEventArgs) Handles OpenFileDialog1.FileOk
        TextBox1.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("The file has " & IO.File.ReadAllBytes(TextBox1.Text).Length & " words. ")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Dim l1 As Integer = TextBox1.Text.Count
        Do While l1 = 0
            MsgBox("The text box has " & l1 & " l1. ")
            l1 += 1
            MsgBox("The text box has " & l1 - 1 & " l1. ")
        Loop
    End Sub


End Class
