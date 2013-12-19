using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormCalculator
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void EventHandler(object sender, EventArgs e)
        {
            DamageTextBox.LostFocus += DamageTextBox_LostFocus;
            //eventhandler for when the control loses focus
        }

        void DamageTextBox_LostFocus(object sender, EventArgs e)
        {
            TextBox theDamageTextBox;
            theDamageTextBox = (TextBox)sender;

            throw new NotImplementedException();
        }

        public event EventHandler Leave;

        private void DamageTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void PenetrationTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DamageFieldLabel_Click(object sender, EventArgs e)
        {

        }

        private void PenetrationFieldLabel_Click(object sender, EventArgs e)
        {

        }

        private void IgnoreArmorCheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void IgnoreToughnessCheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {

        }
    }
}
