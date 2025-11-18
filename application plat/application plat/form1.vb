Public Class form1
    Dim prix As Integer
    Private Sub form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isBoisson.Items.Add("caffé")
        isBoisson.Items.Add("eau minérale")
        isBoisson.Items.Add("jus d'orange")
        isBoisson.Items.Add("citronade")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim commande As String
        If RadioButton1.Checked Then
            commande = "pizza"
            prix = 8
        ElseIf RadioButton2.Checked Then
            commande = "burger"
            prix = 6
        Else
            commande = "pates"
            prix = 7
        End If
        For Each ctrl In GroupBox2.Controls
            If ctrl.checked Then
                commande = commande + " + " & ctrl.text
                If ctrl.text = "fromage" Then
                    prix += 2
                ElseIf ctrl.text = "frites" Then
                    prix += 2
                ElseIf ctrl.text = "dessert" Then
                    prix += 4
                End If
            End If
        Next
        Label2.Text = "Vous avez commandé : " & commande & " total " & prix
    End Sub
End Class