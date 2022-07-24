using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ecosave
{
    public partial class Calculator_Page : Form
    {
        public Calculator_Page()
        {
            InitializeComponent();
        }
        string firstVal = "";
        string secondVal = "";
        double result = 0.0;
        string userVal = "";
        char function = '\0';

        private void plusBtn_Click(object sender, EventArgs e)
        {
            function = '+';
            firstVal = userVal;
            userVal = "";
        }

        private void minusBtn_Click(object sender, EventArgs e)
        {
            function = '-';
            firstVal = userVal;
            userVal = "";
        }

        private void multiplyBtn_Click(object sender, EventArgs e)
        {
            function = '*';
            firstVal = userVal;
            userVal = "";
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "0";
            firstVal = "";
            secondVal = "";
            result = 0.0;
            userVal = "";
        }

        private void equalBtn_Click(object sender, EventArgs e)
        {
            secondVal = userVal;
            double firstNum, secondNum;
            firstNum = Convert.ToDouble(firstVal);
            secondNum = Convert.ToDouble(secondVal);

            if (function == '+')
            {
                result = firstNum + secondNum;
                calculatorDisplay.Text = result.ToString();
            }
            else if (function == '-')
            {
                result = firstNum - secondNum;
                calculatorDisplay.Text = result.ToString();
            }
            else if (function == '*')
            {
                result = firstNum * secondNum;
                calculatorDisplay.Text = result.ToString();
            }
            else if (function == '/')
            {
                result = firstNum / secondNum;
                calculatorDisplay.Text = result.ToString();
            }

            else
            {
                MessageBox.Show("Please Enter a Valid Value");
            }
        }

        private void divisionBtn_Click(object sender, EventArgs e)
        {
            function = '/';
            firstVal = userVal;
            userVal = "";
        }

        private void num0_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userVal += "0";
            calculatorDisplay.Text = userVal;
        }
        private void num1_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userVal += "1";
            calculatorDisplay.Text = userVal;
        }
        private void num2_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userVal += "2";
            calculatorDisplay.Text = userVal;
        }

        private void num3_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userVal += "3";
            calculatorDisplay.Text = userVal;

        }

        
        private void num4_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userVal += "4";
            calculatorDisplay.Text = userVal;
        }
        private void num5_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userVal += "5";
            calculatorDisplay.Text = userVal;
        }
        private void num6_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userVal += "6";
            calculatorDisplay.Text = userVal;
        }

        private void num7_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userVal += "7";
            calculatorDisplay.Text = userVal;
        }

        private void num8_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userVal += "8";
            calculatorDisplay.Text = userVal;
        }

        private void num9_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userVal += "9";
            calculatorDisplay.Text = userVal;
        }

        

        
    }
}
