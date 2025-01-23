
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

        'jellyBeans = CInt(studentName)

        Console.WriteLine()

    End Sub

End Module
