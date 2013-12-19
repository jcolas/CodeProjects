using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyWorkingWithClassesAndObjects
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Person objectP1 = new Person();
            objectP1.Name = "Josh C";
            objectP1.DOB = DateTime.Parse("05/01/1900");
            objectP1.Gender = Gender.Male;

            MessageBox.Show(objectP1.GetData());
        }
    }
}
