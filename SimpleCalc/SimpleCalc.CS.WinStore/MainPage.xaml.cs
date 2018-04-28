using SimpleCalc.CS.PortableLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace SimpleCalc.CS.WinStore
{
  /// <summary>
  /// An empty page that can be used on its own or navigated to within a Frame.
  /// </summary>
  public sealed partial class MainPage : Page
  {
    public MainPage()
    {
      this.InitializeComponent();
    }

    private void Page_Loaded(object sender, RoutedEventArgs e)
    {
      OperatorComboBox.SelectedItem = OperatorComboBox.Items[0];
    }

    private void CalculateButton_Click(object sender, RoutedEventArgs e)
    {
      //Get the input values from the form, and initiaze the answer to zero
      double num1 = 0;
      double.TryParse(Number1TextBox.Text, out num1);
      double num2 = 0;
      double.TryParse(Number2TextBox.Text, out num2);
      string op = ((ListBoxItem)OperatorComboBox.SelectedItem).Content.ToString();
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
