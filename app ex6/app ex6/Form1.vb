Public Class Form1
    Structure etudient
        Dim nom As String
        Dim prenom As String
        Dim note As Double

    End Structure
    Sub main()

        Dim tab(2) As etudient
        Dim i As Integer
        Dim e As etudient
        For i = 0 To 2
            Console.Write("entrez votre nom")
            e.nom = Console.ReadLine()
            Console.Write("entrez votre prenom")
            e.prenom = Console.ReadLine()
            Console.Write("entrez votre note")
            e.note = CDbl(Console.ReadLine())
            tab(i) = e
        Next
        Dim m As Double
        Dim b As String = ""
        Dim s As Double
        Dim k As Double
        For i = 0 To 2
            If tab(i).note > m Then
                m = tab(i).note
                b = tab(i).nom
            Else
                s = s + tab(i).note
            End If
        Next
        Console.Write("le meilleur note de la classe est" & m & " de " & b)
        k = s / 3
        Console.Write("la moyenne de las classe est " & k)

    End Sub
End Class
