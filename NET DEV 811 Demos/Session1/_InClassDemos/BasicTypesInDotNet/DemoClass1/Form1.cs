using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoClass1
{
    enum CustomerType { Wholesale = 1, Retail = 2}

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            CustomerType ct;
            ct = CustomerType.Retail;  
            if (ct == CustomerType.Retail)
            {
                Console.WriteLine("test");
            }

            SimpleEventHandler seh = new SimpleEventHandler(RunCode);
            seh.Invoke("A Message!");
        }

        private void RunCode(string Msg) 
        {
            MessageBox.Show("Test " + Msg);
        }
    }
}
