using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AsTimePermits
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonDelegates_Click(object sender, EventArgs e)
        {
            DelegatesAndMethods.DelegateMain();
        }

        private void buttonLambdas_Click(object sender, EventArgs e)
        {
            DelegatesAndLambdas.LambdasMain();
        }

        private void buttonAnonymousTypes_Click(object sender, EventArgs e)
        {
            AnonymousTypes.AnonymousTypesMain();
        }
    }
}
