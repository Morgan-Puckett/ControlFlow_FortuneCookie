'Morgan Puckett
'RCET0265
'S2022
'Fortune Cookie
'



Option Compare Text
Option Explicit On
Option Strict On

Module ControlFlow_FortuneCookie

    Sub Main()
        Dim done As Boolean
        Dim randomNumber As Integer
        Dim quitQue As String

        Console.WriteLine("Press enter to get a fortune cookie- or Q to quit")

        done = False
        Do While done = False

            quitQue = Console.ReadLine()
            If quitQue = "q" Then
                done = True
                Console.WriteLine($"Ok you can quit after this last one!{vbNewLine}")
            Else
                done = False
            End If
            randomNumber = CInt(Int((5 * Rnd()) + 1))    ' Generate random value between 1 and 5.
            Console.WriteLine($"The cookie you selected is cookie number {randomNumber}... Let's 
read this fortune... {vbNewLine} *cRaCkKkKk*{vbNewLine}")
            Select Case randomNumber
                Case 1
                    Console.WriteLine("""A conclusion is simply the place where you got tired of thinking.""")
                Case 2
                    Console.WriteLine("""A foolish man listens to his heart. A wise man listens to cookies.""")
                Case 3
                    Console.WriteLine("""If at first you don’t succeed, skydiving not for you.""")
                Case 4
                    Console.WriteLine("""You are cleverly disguised as responsible adult.""")
                Case 5
                    Console.WriteLine("""You have kleptomania. Take something for it.""")
            End Select

        Loop
        Console.WriteLine("Have a nice day")
        Console.ReadLine()
    End Sub

End Module
