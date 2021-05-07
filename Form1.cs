// Britney Cook, Behrooz Kazemi, and Mohammad Jokar-Konavi
// May 6, 2021
// Extra 6-1 Create a simple calculator 


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       

        // the new method coded for the calculation
        private decimal Calculate(decimal operand1, string operator1,
          decimal operand2)
        {
            decimal result = 0m;
            switch (operator1)
            {
                case "+":
                    result = operand1 + operand2;
                    break;
                case "-":
                    result = operand1 - operand2;
                    break;
                case "*":
                    result = operand1 * operand2;
                    break;
                case "/":
                    result = operand1 / operand2;
                    break;
            }

            return result;
        }


        // event handler for the Calculate bottun
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal operand1 = Convert.ToDecimal(txtOperand1.Text);
            decimal operand2 = Convert.ToDecimal(txtOperand2.Text);
            string operator1 = txtOperator.Text;

            // calling the Calculate method
            decimal result = this.Calculate(operand1, operator1, operand2);
            result = Math.Round(result, 4);  // the result rounded to four decimal places

            txtResult.Text = result.ToString();
            txtOperand1.Focus();
        }


        // event handler for the Exit button
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // any changes in other text boxes clear the result text box
        private void txtOperand1_TextChanged(object sender, EventArgs e)
        {
            txtResult.Text = "";
            
        }
    }
}
