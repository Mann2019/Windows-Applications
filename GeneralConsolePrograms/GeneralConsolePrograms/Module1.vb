Module Module1

    Sub Main()
        Dim num(3) As Integer
        Dim i, j As Integer, sum As Integer = 0
        Console.Write("Enter 3 numbers to add : ")
        For i = 0 To 2
            num(i) = Convert.ToInt32(Console.ReadLine)
        Next i
        Console.Write("You Entered :")
        For j = 0 To 2
            sum = sum + num(j)
            Console.Write(" {0}", num(j))
        Next
        Console.WriteLine()
        Console.WriteLine("Sum of these numbers : {0}", sum)
        Console.ReadLine()
    End Sub

End Module
