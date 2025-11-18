Module Module1
    Public Structure Patient
        Dim code As Integer
        Dim nom As String
        Dim prenom As String
        Dim age As Integer
    End Structure
    Public listPatients As New List(Of Patient)
    Public Sub ajouterPatient(p As Patient)
        p.code = listPatients.Count
        listPatients.Add(p)
    End Sub


End Module
