Public Class ReverseDigits
    Dim num, r, temp As Integer, i As Integer = 0, revNum As Integer = 0
    Sub Input()
        Console.Write("Enter a number to reverse : ")
        num = Convert.ToInt32(Console.ReadLine())
    End Sub

    Sub Reverse()
        Dim n As Integer = num
        Dim digits() As Integer
        ReDim digits(8)
        While n <> 0
            r = n Mod 10
            digits(i) = r
            i += 1
            n = n \ 10
        End While
        Console.WriteLine()
        Console.Write("Reversed number : ")
        For j = 0 To i - 1
            revNum = revNum * 10
            revNum = revNum + digits(j)
        Next
        Console.Write(revNum)
    End Sub
End Class
