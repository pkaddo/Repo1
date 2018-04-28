Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports SimpleCalc.VB.PortableLibrary


<TestClass()> Public Class CalculatorTests

  <TestMethod()>
  Public Sub TestVbAddition()
    Dim calc As New Calculator()
    calc.Number1 = 10
    calc.Number2 = 10
    Dim answer As Double = calc.Add()
    'Ensure that 10+10=20
    Assert.AreEqual(answer, 20.0R)
  End Sub

  <TestMethod()>
  Public Sub TestVbSubtraction()
    Dim calc As New Calculator()
    calc.Number1 = 10
    calc.Number2 = 10
    Dim answer As Double = calc.Subtract()
    'Ensure that 10-10=0
    Assert.AreEqual(answer, 0.0R)
  End Sub

  <TestMethod()>
  Public Sub TestVbMultiplication()
    Dim calc As New Calculator()
    calc.Number1 = 10
    calc.Number2 = 10
    Dim answer As Double = calc.Multiply()
    'Ensure that 10*10=100
    Assert.AreEqual(answer, 100.0R)
  End Sub

  <TestMethod()>
  Public Sub TestVbDivision()
    Dim calc As New Calculator()
    calc.Number1 = 10
    calc.Number2 = 10
    Dim answer As Double = calc.Divide()
    'Ensure that 10/10=1
    Assert.AreEqual(answer, 1.0R)
  End Sub

End Class