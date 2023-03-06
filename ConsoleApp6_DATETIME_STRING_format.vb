'a console program that reads in a number and prints the date that number of days from now in this format: Saturday, March 06, 2023.

Imports System

Module Program

    Sub Main(args As String())
        Dim thisdatetime As Date = DateTime.Now
        Dim invalue As Integer
        invalue = CInt(Console.ReadLine())
        thisdatetime = thisdatetime.AddDays(invalue)

        Console.WriteLine(String.Format("{0:dddd, MMMM dd, yyyy}", thisdatetime))

    End Sub

End Module
