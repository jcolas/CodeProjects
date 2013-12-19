using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _811Assignment02b
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            Calculator.Add(int.Parse(textBox1.Text), int.Parse(textBox2.Text), out valuestring);
            textBox3.Text = ("The sum of both integers is: " + (valuestring) + "\r\n");
            Calculator.Subtract(int.Parse(textBox1.Text), int.Parse(textBox2.Text), out valuestring);
            textBox3.Text += ("The difference between both integers is: " + calculator.valuestring + "\r\n");
            Calculator.Divide(int.Parse(textBox1.Text), int.Parse(textBox2.Text), out valuestring);
            textBox3.Text += ("The quotient of both integers is: " + calculator.valuestring + "\r\n");
            Calculator.Multiply(int.Parse(textBox1.Text), int.Parse(textBox2.Text), out valuestring);
            textBox3.Text += ("The product of both integers is: " + calculator.valuestring + "\r\n");
        }
    }
}