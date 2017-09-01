Public Class StringOperations
    Dim str As String
    Dim chars, letters As Char()
    Dim i As Integer
    Sub Input()
        Console.Write("Enter message : ")
        str = Console.ReadLine()
        chars = str.ToCharArray()
        letters = chars
    End Sub

    Sub ReverseChars()
        Array.Reverse(letters)
    End Sub

    Sub Output()
        Console.Write("Reversed string : ")
        Console.Write(letters)
    End Sub
End Class
