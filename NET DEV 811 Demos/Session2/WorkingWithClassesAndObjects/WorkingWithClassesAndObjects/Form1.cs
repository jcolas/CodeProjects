using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WorkingWithClassesAndObjects
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                 //This calls the constructor to make a new person object
                Person objP1 = new Person();
                
                //Set the properties
                objP1.Name = "Bob Smith";
                objP1.DOB = Convert.ToDateTime("01/01/1980");
                objP1.Gender = Gender.Male;

                //Use a method
                MessageBox.Show(objP1.GetData());

                //This connects the event to a method
                //objP1.NameChanged += new EventHandler(objP1_NameChanged);
                objP1.Name = "Robert Smith";
                MessageBox.Show(objP1.GetData());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void objP1_NameChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Note: the name has been changed!");
        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //This calls the constructor to make a new person object
                Customer objC1 = new Customer(1, "Sue Jones", Convert.ToDateTime("01/01/1980"), Gender.Female);
                
               //Use a method
                MessageBox.Show(objC1.GetData());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                //This calls the constructor to make a new person object
                ClassLibraryDemo.Customer objC1 = new ClassLibraryDemo.Customer(1, "Sue Jones", Convert.ToDateTime("01/01/1980"), ClassLibraryDemo.Gender.Female);

                //Use a method
                MessageBox.Show(objC1.GetData());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
