Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label5.Text = Date.Today.ToLongDateString()
        Label6.Text = TimeOfDay.ToLongTimeString()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim P As Patient
        Dim nom As String
        Dim prenom As String
        Dim age As Integer
        If String.IsNullOrWhiteSpace(TextBox1.Text) Then
            ErrorProvider1.SetError(TextBox1, "le nom est obligatoire")
            Return
        End If
        If String.IsNullOrWhiteSpace(TextBox2.Text) Then
            ErrorProvider1.SetError(TextBox2, "le prenom est obligatoire")
            Return
        End If
        age = CInt(NumericUpDown1.Text)
        P.nom = TextBox1.Text
        P.prenom = TextBox2.Text
        P.age = age
        ajouterPatient(P)

    End Sub
    Private Sub init()
        TextBox1.Clear()
        TextBox2.Clear()
        NumericUpDown1.ResetText()
    End Sub
    Private Sub MAJ_DgV()
        DataGridView1.Rows.Clear()
        For Each p As Patient In listPatients
            DataGridView1.Rows.Add(p.code, p.nom, p.prenom, p.age)
        Next
    End Sub
End Class
