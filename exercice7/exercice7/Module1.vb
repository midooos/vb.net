Module Module1
    Structure articles
        Dim code As Integer
        Dim designation As String
        Dim prix As Double
        Dim quantité As Integer
    End Structure
    Public listeArticle As New List(Of articles)
    Public Sub ajouterarctile(A As articles)
        Dim x As Integer = existe(A)
        If x >= 0 Then
            Dim temp As articles = listeArticle(x)
            temp.quantité = temp.quantité + A.quantité
            temp.prix = A.prix
            listeArticle(x) = temp
        Else
            listeArticle.Add(A)


        End If
    End Sub
    Function existe(A As articles) As Integer
        Dim p As Integer = -1
        For i As Integer = 0 To listeArticle.Count - 1
            If listeArticle(i).code = A.code Then
                p = i
            End If
        Next
        Return p
    End Function
End Module
