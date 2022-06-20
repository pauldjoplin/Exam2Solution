using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam2Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool inRange(int min, int max)
        {
            int num = Convert.ToInt32(txtNum1.Text);
            if (num < min || num > max)
            {
                lblMsg.Text = "Number cannot be negative or above " + max;
                return false;
            }
            return true;
        }

        private void showModulus_Click(object sender, EventArgs e)
        {
            //Determining which buttons and textboxes are available //
            doModulus.Enabled = true;
            doFactorial.Enabled = false;
            doFib.Enabled = false;
            txtNum1.Visible = true;
            txtNum2.Visible = true;
            lblFunc.Text = "Enter two operands, the program will perform long division and return results with a whole number and the remainder.";


        }

        private void doModulus_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = Convert.ToInt32(txtNum1.Text);
                int num2 = Convert.ToInt32(txtNum2.Text);
                int divide = 0;
                int num3 = 0;
                string anSwer = "";

                if (num1 > num2)
                {
                    num3 = num1;

                    while (num3 >= num2)
                    {
                        num3 = num3 - (num2);
                        divide++;
                    }
                    anSwer = txtNum1.Text + " divided by " + txtNum2.Text + " is ";

                }
                else
                {
                    num3 = num2;

                    while (num3 >= num1)
                    {
                        num3 = num3 - (num1);
                        divide++;
                    }

                    anSwer = txtNum2.Text + " divided by " + txtNum1.Text + " is ";
                }

                string remainder = Convert.ToString(num3);
                string divided = Convert.ToString(divide);
                lblMsg.Text = anSwer + divided + " with a remainder of " + remainder;

            }
            catch 
            {
                lblMsg.Text = "Please enter a whole number in each box.";
            }

        }

        private void showFactorial_Click(object sender, EventArgs e)
        {
            //Determining which buttons and textboxes are available //
            doFactorial.Enabled = true;
            doModulus.Enabled = false;
            doFib.Enabled = false;
            txtNum1.Visible = true;
            txtNum2.Visible = false;
            lblFunc.Text = "Enter one operand, the program will multiply all numbers in sequence from 1 to the operand provided. None larger than 20, please!";
        }

        private void doFactorial_Click(object sender, EventArgs e)

        {

            try
            {
                int factorial = 1;
                int x = Convert.ToInt32(txtNum1.Text);
                int max = 20;
                int min = 0;

                if (inRange(min, max))
                {
                    for (int i = 1; i <= x; i++)
                    {
                        factorial = factorial * i;
                    }
                    lblMsg.Text = "The answer to !" + x + " is " + factorial.ToString();
                }
            }
            catch
            {
                lblMsg.Text = "Please enter a whole number.";
            }         
        }

        private void showFib_Click(object sender, EventArgs e)
        {
            //Determining which buttons and textboxes are available //

            doFib.Enabled = true;
            doModulus.Enabled = false;
            doFactorial.Enabled = false;
            txtNum1.Visible = true;
            txtNum2.Visible = false;
            lblFunc.Text = "Enter one operand, the program will find the value of a term by adding 2 previous term values. No negatives and nothing higher than 128, please!";
        }

        private void doFib_Click(object sender, EventArgs e)
        {
            try
            {
                decimal num1 = Convert.ToDecimal(txtNum1.Text);
                int i = 0;
                int j = 1;
                int k = 0;
                int fib = 0;
                int max = 128;
                int min = 0;

                if (inRange(min, max))
                {
                    for (i = 0; i < num1; i++)
                    {
                        fib = k + j;
                        k = j;
                        j = fib;
                    }
                    int kk = j - k;
                    int jj = k - kk;
                    string x = Convert.ToString(k);
                    lblMsg.Text = "Fibonacci(" + i + ")" + " = Fibonacci(" + (i - 1) + ") + " + " Fibonacci(" + (i - 2) + ") \n = " + jj + " + " + kk + " = " + x;


                }
            }
            catch
            {
                lblMsg.Text = "Please enter a whole number.";
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblMsg.Text = " ";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            lblMsg.Text = "";
            lblMsg.Text = "Thank you for using this application!";
            lblMsg.Update();
            int time = 0;

           while (time < 2000000000)
            {
                time++;
            }
            this.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblFunc_Click(object sender, EventArgs e)
        {

        }

        private void txtNum1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNum2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
