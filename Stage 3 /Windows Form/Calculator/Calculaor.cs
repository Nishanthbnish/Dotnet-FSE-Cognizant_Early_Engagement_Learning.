using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculaor : Form
    {
        public Calculaor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string num1 = first_number.Text;
            string num2 = Second_number.Text;

            string regex = @"^[0-9]+$";

            if ( Regex.Match(num1,regex).Success &&  Regex.Match(num2,regex).Success)
            {
                Calculate(Convert.ToInt32(num1), Convert.ToInt32(num2));
            }
            else
            {
                MessageBox.Show(" Enter A Valid Number ") ;
            }
        }

        private void Calculate(int num1,int num2)
        {
            string result="Plese Select an Operation ";

            if (Radio_add.Checked)
            {
                result = (num1 + num2).ToString();
            }
            else if (Radio_sub.Checked)
            {
                result = (num1 - num2).ToString();
            }
            else if (Radio_Mul.Checked)
            {
                result = (num1 * num2).ToString();
            }
            else if (Radio_div.Checked)
            {
                try
                {
                    result = (num1 / num2).ToString();
                    
                }
                catch
                {
                    result = "Division by 0 Not Possible";
                }
            }

            MessageBox.Show(result);
        }
    }
}
