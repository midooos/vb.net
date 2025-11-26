Imports System.Configuration
Imports System.Security.Cryptography.X509Certificates

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim name As String
        Dim lastname As String
        Dim age As Integer
        Dim p As Person
        If String.IsNullOrWhiteSpace(TextBox1.Text) Or IsNumeric(TextBox1.Text) Then
            ErrorProvider1.SetError(TextBox1, "invalid name")
        End If
        If String.IsNullOrWhiteSpace(TextBox2.Text) Or IsNumeric(TextBox2.Text) Then
            ErrorProvider1.SetError(TextBox2, "invalid last name")
        End If
        If Integer.TryParse(TextBox3.Text, age) = False Then
            ErrorProvider1.SetError(TextBox3, "invalid age")
        End If
        p.name = TextBox1.Text
        p.lastname = TextBox2.Text
        p.age = CInt(age)
        ajouterlistperson(p)
        DataGridView1.Rows.Clear()
        Dim listpersons As List(Of Person) = listpersons

        For Each p1 As Person In listpersons
            DataGridView1.Rows.Add(p1.name, p1.lastname, p1.age)
        Next

    End Sub

End Class
