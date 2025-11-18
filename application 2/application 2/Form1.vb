Imports System.Linq.Expressions

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim article As Article = New Article()
        Dim test As Boolean = False
        For Each ctrl In GroupBox1.Controls
            If ctrl.checked Then
                article.vetement = ctrl.text
                test = True
            End If
        Next
        If test = False Then
            ErrorProvider1.SetError(GroupBox1, "Veuillez sélectionner un vêtement.")
            Return
        End If
        test = False
        For Each ctrl In GroupBox2.Controls
            If ctrl.checked Then
                article.typeNetoyage = ctrl.text
                test = True
            End If
        Next
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = Date.Today.ToLongDateString()
        Label3.Text = TimeOfDay.ToLongTimeString()
    End Sub
End Class