
Option Explicit On
Option Strict On



Module VariablesAndDataTypesAndStuff
    'Jacob_Horsley
    'Notes1_22_25
    Sub Main()

        Dim jellyBeans As Integer 'These_should_stay_on_top
        Dim laffyTaffy As Integer 'Choose clarity over efficiency
        Dim money As Decimal
        Dim studentName As String
        Dim userinput As String
        Dim firstNumber As Integer
        Dim secondnumber As Integer = 5


        Console.WriteLine(jellyBeans)

        jellyBeans = 120
        Console.WriteLine(jellyBeans)

        jellyBeans = jellyBeans + 10
        Console.WriteLine(jellyBeans)

        jellyBeans += 10
        Console.WriteLine(jellyBeans)

        laffyTaffy = 26
        Console.WriteLine(laffyTaffy)

        money = 9.123456789D 'D indicates that I know it's wrong send it
        jellyBeans = CInt(1.56)
        studentName = "7"

        jellyBeans = CInt(studentName)

        'Console.WriteLine("please enter a fruit")
        'userinput = Console.ReadLine()

        'Console.WriteLine("how do you like them " & userinput & "'s!")
        'Console.WriteLine($"you entered {userinput}!")







        'get number from user

        Console.WriteLine("Please enter a whole number:")
        userinput = Console.ReadLine()

        firstNumber = CInt(userinput)


        'menu example
        Console.WriteLine("Please make a selection: " & vbNewLine _
                          & "1. add" & vbNewLine _
                          & "2. subtract" & vbNewLine _
                          & "3. multiply" & vbNewLine
                          )

        userinput = Console.ReadLine()

        Console.WriteLine($"you chose {userinput}")

        If userinput = "1" Then
            Console.WriteLine("led's add!!")
            Console.WriteLine($"{firstNumber} + {secondnumber} = {firstNumber + secondnumber}")
        ElseIf userinput = "2" Then
            Console.WriteLine("led's subtract!!")
        ElseIf userinput = "3" Then
            Console.WriteLine("led's multiply!!")
        Else
            Console.WriteLine("Invalid Option!")
        End If





    End Sub

End Module
