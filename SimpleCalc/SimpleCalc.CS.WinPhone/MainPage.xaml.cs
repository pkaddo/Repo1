using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using SimpleCalc.CS.WinPhone.Resources;
using SimpleCalc.CS.PortableLibrary;

namespace SimpleCalc.CS.WinPhone
{
  public partial class MainPage : PhoneApplicationPage
  {
    // Constructor
    public MainPage()
    {
      InitializeComponent();
    }

    private void CalculateButton_Click(object sender, RoutedEventArgs e)
    {
      //Get the input values from the form, and initiaze the answer to zero
      double num1 = 0;
      double.TryParse(Number1TextBox.Text, out num1);
      double num2 = 0;
      double.TryParse(Number2TextBox.Text, out num2);
      string op = ((ListPickerItem)OperatorComboBox.SelectedItem).Content.ToString();
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
      AnswerTextBox.Text = answer.ToString();

    }

 }
}