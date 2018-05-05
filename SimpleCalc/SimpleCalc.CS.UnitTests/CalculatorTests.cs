namespace SimpleCalc.CS.UnitTests
{
  using Microsoft.VisualStudio.TestTools.UnitTesting;
  using SimpleCalc.CS.PortableLibrary;

  [TestClass]
  public class CalculatorTests
  {
    private Calculator calc;

    [TestInitialize]
    public void init()
    {
      calc = new Calculator();
    }

    [TestMethod]
    public void TestCsAddition()
    {
      calc.Number1 = 10;
      calc.Number2 = 10;
      double answer = calc.Add();
      ////Ensure that 10+10=20
      Assert.AreEqual(answer, 20d);
    }

    [TestMethod]
    public void TestCsSubtraction_ChangingJustToTestVcsLabelling()
    {
      calc.Number1 = 10;
      calc.Number2 = 10;
      double answer = calc.Subtract();
      //Ensure that 10-10=0
      Assert.AreEqual(answer, 0d);
    }

    [TestMethod]
    public void TestCsMultiplication()
    {
      calc.Number1 = 10;
      calc.Number2 = 10;
      double answer = calc.Multiply();
      //Ensure that 10*10=100
      Assert.AreEqual(answer, 100d);
    }

    [TestMethod]
    public void TestCsDivision()
    {
      calc.Number1 = 10;
      calc.Number2 = 10;
      double answer = calc.Divide();
      //Ensure that 10/10=1
      Assert.AreEqual(answer, 1d);
    }
  }
}
