using SimpleCalc.CS.PortableLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalc.CS.ConsoleApp
{
  class Program
  {
    static void Main(string[] args)
    {
      //Get the input values from the console, and initiaze the answer to zero
      double num1 = 0;
      Console.WriteLine("Enter the value for Number 1:");
      double.TryParse(Console.ReadLine(), out num1);
      double num2 = 0;
      Console.WriteLine("Enter the value for Number 2:");
      double.TryParse(Console.ReadLine(), out num2);
      string op = "";
      Console.WriteLine("Enter the Operator (+,-,*,/):");
      op = Console.ReadLine();
      double answer = 0;

      //Instantiate a calculator instance, and supply the values for the operands
      Calculator calc = new Calculator();
      calc.Number1 = num1;
      calc.Number2 = num2;

      //Depending on which operator the user selected, call the approparite calculator method.
      //Store the result int the answer variable
      switch (op)
      {
        case "+":
          answer = calc.Add();
          break;
        case "-":
          answer = calc.Subtract();
          break;
        case "*":
          answer = calc.Multiply();
          break;
        case "/":
          answer = calc.Divide();
          break;
      }

      //Show the answer
      Console.WriteLine("{0} {1} {2} = {3}{4}{4}Press [ENTER] to continue...", num1, op, num2, answer, System.Environment.NewLine);
      Console.ReadLine();


    }
  }
}
