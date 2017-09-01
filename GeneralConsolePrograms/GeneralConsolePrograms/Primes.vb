Public Class Primes
    Dim num, i, j, temp As Integer, flag As Integer = 0, prime_flag As Integer = 0
    Dim pair_flag As Integer = 0
    Sub Input()
        Console.Write("Enter the upper limit of numbers : ")
        num = Convert.ToInt32(Console.ReadLine())
        Console.WriteLine()
    End Sub

    Sub PrimeNums()
        Console.Write("Primes upto {0} are ", num)
        For i = 2 To num
            For j = 2 To i / 2
                If (i Mod j = 0) Then
                    flag = 1
                    Exit For
                End If
            Next
            If (flag = 0) Then
                Console.Write("{0},", i)
            Else
                flag = 0
            End If
        Next
    End Sub

    Sub TwinPrimes()
        Console.WriteLine("Twin prime pairs upto {0} -", num)
        For i = 2 To num
            For j = 2 To i / 2
                If i Mod j = 0 Then
                    prime_flag = 1
                End If
            Next
            If prime_flag = 0 Then
                If pair_flag Mod 2 = 0 Then
                    Console.Write("{0}, ", i)
                Else
                    Console.WriteLine(i)
                End If
                pair_flag += 1
            Else
                prime_flag = 0
            End If
        Next
    End Sub
End Class
