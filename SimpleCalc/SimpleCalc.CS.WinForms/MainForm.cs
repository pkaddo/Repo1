using SimpleCalc.CS.PortableLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalc.CS.WinForms
{
  public partial class MainForm : Form
  {
    public MainForm()
    {
      InitializeComponent();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
      //Set the default operator the first one (+)
      OperatorComboBox.SelectedItem = OperatorComboBox.Items[0];
    }

    private void CalculateButton_Click(object sender, EventArgs e)
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
      switch(op)
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

    private void Number1TextBox_TextChanged(object sender, EventArgs e)
    {

    }

    private void Number2TextBox_TextChanged(object sender, EventArgs e)
    {

    }

    private void OperatorComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void AnswerTextBox_TextChanged(object sender, EventArgs e)
    {

    }


  }
}
