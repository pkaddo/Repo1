Public Class Calculator

  'Declare a private backing field for the first number
  Private _number1 As Double

  'Create a public property for the first number
  Public Property Number1() As Double
    Get
      Return _number1
    End Get
    Set(value As Double)
      _number1 = value
    End Set
  End Property

  'Declare a private backing field for the second number
  Private _number2 As Double

  'Create a public property for the second number
  Public Property Number2() As Double
    Get
      Return _number2
    End Get
    Set(value As Double)
      _number2 = value
    End Set
  End Property

  'Create a method to add the two numbers
  Public Function Add() As Double
    Return _number1 + _number2
  End Function

  'Create a method to subtract the two numbers
  Public Function Subtract() As Double
    Return _number1 - _number2
  End Function


  'Create a method to multiply the two numbers
  Public Function Multiply() As Double
    Return _number1 * _number2
  End Function


  'Create a method to divide the two numbers
  Public Function Divide() As Double
    Return _number1 / _number2
  End Function


End Class
