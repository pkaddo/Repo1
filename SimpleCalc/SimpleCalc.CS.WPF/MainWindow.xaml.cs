using SimpleCalc.CS.PortableLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SimpleCalc.CS.WPF
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();
    }

    private void Window_Loaded(object sender, RoutedEventArgs e)
    {
      //Set the default item
      OperatorComboBox.SelectedItem = OperatorComboBox.Items[0];
    }

    private void CalculateButton_Click(object sender, RoutedEventArgs e)
    {
      //Get the input values from the form, and initiaze the answer to zero
      double num1 = 0;
      double.TryParse(Number1TextBox.Text, out num1);
      double num2 = 0;
      double.TryParse(Number2TextBox.Text, out num2);
      string op = OperatorComboBox.SelectedItem.ToString();
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
