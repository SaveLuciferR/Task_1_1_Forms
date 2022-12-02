using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_1_1_Forms
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			double a, b;
			a = double.Parse(textBox1.Text);
			b = double.Parse(textBox2.Text);
			
			if (a <= 0 || b <= 0)
			{
				textBox3.Text = "Катет должен быть положительный";
				return;
			}

			double c = Math.Sqrt(a * a + b * b);

			textBox3.Text = string.Format("A = " + a + "\r\nB = " + b + "\r\nC = " + c + "\r\nПериметр равен " + (a + b + c));
		}

		private void button2_Click(object sender, EventArgs e)
		{
			textBox1.Text = "";
			textBox2.Text = "";
			textBox3.Text = "";
		}
	}
}
