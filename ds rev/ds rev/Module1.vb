Module Module1
    Public Structure Person
        Dim name As String
        Dim lastname As String
        Dim age As Integer
    End Structure
    Dim listpersons As New List(Of Person)
    Public Sub ajouterlistperson(p As Person)
        listpersons.Add(p)
    End Sub
End Module
