Module Module1
    Class AddDigits
        Dim num As Integer, sum As Integer = 0
        Sub Input()
            Console.Write("Enter a number : ")
            num = Convert.ToInt32(Console.ReadLine)
        End Sub
        Sub Digits()
            Dim r As Integer, n As Integer = num
            While n <> 0
                r = n Mod 10
                sum = sum + r
                n = n \ 10
            End While
            Console.Write("Sum of digits is {0}", sum)
            sum = 0
        End Sub
    End Class
    Class AddNumbers
        Dim num(3) As Integer
        Dim i, j As Integer, sum As Integer = 0
        Sub Add()
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
            Console.WriteLine("Sum of these numbers is {0}", sum)
        End Sub
    End Class
    Sub Main()
        'Console.WriteLine("Add 3 numbers - ")
        'Dim addNums As AddNumbers = New AddNumbers()
        'addNums.Add()
        'Console.WriteLine()
        'Console.WriteLine("Add the digits of a number - ")
        'Dim addDigs As AddDigits = New AddDigits()
        'addDigs.Input()
        'addDigs.Digits()
        Dim reverse As ReverseDigits = New ReverseDigits()
        reverse.Input()
        Console.ReadLine()
    End Sub

End Module
