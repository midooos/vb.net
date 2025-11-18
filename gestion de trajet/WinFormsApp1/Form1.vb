Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim r As reservation
        If ComboBox1.SelectedIndex = -1 Then
            ErrorProvider1.SetError(ComboBox1, "Veuillez sélectionner une ligne.")
        End If
        r.ligne = ComboBox1.Text
        If ComboBox4.SelectedIndex = -1 Then
            ErrorProvider1.SetError(ComboBox4, "Veuillez sélectionner une ville de départ.")
        End If
        r.villeDepart = ComboBox2.Text
        If ComboBox2.SelectedIndex = -1 Then
            ErrorProvider1.SetError(ComboBox2, "Veuillez sélectionner une ville d'arrivée.")
        End If
        r.villeArrivee = ComboBox2.Text
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label8.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm")
    End Sub
End Class
