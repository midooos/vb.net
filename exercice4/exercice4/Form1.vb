Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim a As String
        a = TextBox1.Text
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim a As String
        Dim c As String
        a = TextBox1.Text
        c = a.ToUpper()
        Label3.Text = c

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim a As String
        Dim c As String
        a = TextBox1.Text
        c = a.ToLower()
        Label3.Text = c
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As String
        a = TextBox1.Text
        Dim b As Integer
        b = Len(a)
        Label3.Text = b
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click


    End Sub
End Class
