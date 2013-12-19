using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _811Assignment03
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }

        public string currentDefaultSavePath = @"c:\temp\text.txt";

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            Decimal Sum, Difference, Product, Quotient;
            Calculator.Calculate(decimal.Parse(textBox1.Text), decimal.Parse(textBox2.Text), out Sum, out Difference, out Product, out Quotient);
            textBox3.Text = "The answers are: " + Environment.NewLine;
            textBox3.Text += "Sum: " + Sum.ToString() + Environment.NewLine;
            textBox3.Text += "Difference: " + Difference.ToString() + Environment.NewLine;
            textBox3.Text += "Product: " + Product.ToString() + Environment.NewLine;
            textBox3.Text += "Quotient: " + Quotient.ToString() + Environment.NewLine;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {  
            currentDefaultSavePath.Replace(@"\\", @"\");
            DataSaver dataSaver = new DataSaver((textBox3.Text), (currentDefaultSavePath));
            dataSaver.SaveFile();     
        }

        private void UpdateSaveLocationButton_Click(object sender, EventArgs e)
        {
            currentDefaultSavePath = "@" + (savePathTextBox.Text);
            currentDefaultSavePath.Replace(@"\\", @"\");
            MessageBox.Show("Your new save path is now " + (currentDefaultSavePath), "Save Location Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
