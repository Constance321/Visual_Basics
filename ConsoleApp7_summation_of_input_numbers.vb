
'a program that reads in numbers until a -1 is entered and prints the average of all numbers entered with a comma thousand separator
'and two decimal places.

Imports System

Module Program
    Sub Main(args As String())

        Dim mysum As Decimal
        Dim invalue As Integer
        Dim count As Integer
        Do
            invalue = CInt(Console.ReadLine())
            mysum += invalue
            count += 1
        Loop Until invalue = -1


        Console.WriteLine(((mysum + 1) / (count - 1)).ToString("N"))
    End Sub
End Module
