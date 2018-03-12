using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
//Omar Qasem

namespace factCalculator
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		// calc funtion accepts a single integer parameter and finds the factorial of that value.
		public void calc(BigInteger x)
		{
				BigInteger ans = 1;
				//We only want integers 0 or greater
				while (x > 0)
				{
					ans *= x;
					x--;

				}
				resultTxtBox.Text = ans.ToString();
				
				//if statement checks if a negative value is entered, then displays an error message if the number is negative.
				if(x < 0)
				{
					resultTxtBox.Text = "";
					MessageBox.Show("Please enter a Whole POSITIVE Interger", "input error");
					enterTxtBox.Clear();
					resultTxtBox.Clear();
				}
		
				
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			enterTxtBox.Focus();
		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			enterTxtBox.Clear();
			resultTxtBox.Clear();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			
			BigInteger n;
			if (BigInteger.TryParse(enterTxtBox.Text, out n))
			{
				calc(n);
			}
			else
			{
				MessageBox.Show("Please Enter a Whole positive Integer!", "Input Error");
				enterTxtBox.Clear();
			}
		}
	}
}
