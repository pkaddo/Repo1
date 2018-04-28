Imports SimpleCalc.VB.PortableLibrary

Module Module1

  Sub Main()
    'Get the input values from the form, and initiaze the answer to zero
    Dim num1 As Double = 0
    Console.WriteLine("Enter the value for Number 1:")
    Double.TryParse(Console.ReadLine(), num1)
    Dim num2 As Double = 0
    Console.WriteLine("Enter the value for Number 2:")
    Double.TryParse(Console.ReadLine(), num2)
    Dim op As String = ""
    Console.WriteLine("Enter the Operator (+,-,*,/):")
    op = Console.ReadLine()
    Dim answer As Double = 0

    'Instantiate a calculator instance, and supply the values for the operands
    Dim calc As New Calculator()
    calc.Number1 = num1
    calc.Number2 = num2

    'Depending on which operator the user selected, call the approparite calculator method.
    'Store the result int the answer variable
    Select Case (op)
      Case "+"
        answer = calc.Add()
        Exit Select
      Case "-"
        answer = calc.Subtract()
        Exit Select
      Case "*"
        answer = calc.Multiply()
        Exit Select
      Case "/"
        answer = calc.Divide()
        Exit Select
    End Select

    'Show the answer
    Console.WriteLine("{0} {1} {2} = {3}{4}{4}Press [ENTER] to continue...", num1, op, num2, answer, System.Environment.NewLine)
    Console.ReadLine()

  End Sub

End Module
