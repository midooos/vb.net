Public Class Form1
    Dim tab(2) As etudiant
    Dim i As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim et As etudiant
        For i = 0 To 2
            et.nom = TextBox1.Text
            et.prenom = TextBox2.Text
            et.note = CDbl(TextBox3.Text)
            tab(i) = et
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim m As Double = 0
        Dim k As String = ""
        Dim moy As Double
        Dim s As Double = 0

        For i = 0 To 2
            If tab(i).note > m Then
                m = tab(i).note
                k = tab(i).nom
            End If
        Next

        Label5.Text = "la meilleure note est " & m & " de " & k

        For i = 0 To 2
            s = s + tab(i).note
        Next

        moy = s / 3
        Label6.Text = "la moyenne de la classe est " & moy
    End Sub
End Class
