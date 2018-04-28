﻿Imports SimpleCalc.VB.PortableLibrary

' The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

''' <summary>
''' An empty page that can be used on its own or navigated to within a Frame.
''' </summary>
Public NotInheritable Class MainPage
    Inherits Page

  Private Sub Page_Loaded(sender As Object, e As RoutedEventArgs)
    OperatorComboBox.SelectedItem = OperatorComboBox.Items(0)
  End Sub


  Private Sub CalculateButton_Click(sender As Object, e As RoutedEventArgs) Handles CalculateButton.Click
    'Get the input values from the form, and initiaze the answer to zero
    Dim num1 As Double = 0
    Double.TryParse(Number1TextBox.Text, num1)
    Dim num2 As Double = 0
    Double.TryParse(Number2TextBox.Text, num2)
    Dim op As String = DirectCast(OperatorComboBox.SelectedItem, ListBoxItem).Content.ToString()
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
    AnswerTextBox.Text = answer.ToString()
  End Sub

End Class
