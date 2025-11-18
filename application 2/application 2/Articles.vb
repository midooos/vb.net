Module Articles
    Public Structure Article
        Dim code As String
        Dim vetement As String
        Dim typeNetoyage As String
        Dim nombre As Integer
        Public supplement As List(Of Boolean)
        Public Sub InitArticle()
            supplement = New List(Of Boolean)({False, False})
        End Sub
    End Structure
    Public listArticles As New List(Of Article)
    Public Sub AjouterArticle(A As Article)
        A.code = A.vetement.Substring(1, 2) & "_" & listArticles.Count
        listArticles.Add(A)
    End Sub
End Module
