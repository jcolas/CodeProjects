using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BasicTypesInDotNet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            CustomerType objCT; //Enumeration
            SimpleEventHandler objSEH; //Delegate
            IPerson objIP; //Interface
            PersonClass objPC; //Abstract Class
            Customer objC; //"Concrete + Child + Sealed" Class
            PersonStructure objPS; //Structure

            /** Using an Enumeration **/
            objCT = new CustomerType();
            objCT = CustomerType.Retail;
            if (objCT == CustomerType.Retail) { Console.WriteLine("Retail Customer"); }

            /** Using an Delegate **/
            objSEH = new SimpleEventHandler(MyEventHanderMethod);
            objSEH.Invoke("Invoking the Method through the Delegate!");
            
            /** Using an Interface **/
            //objIP = new PersonClass;
            objIP = new PersonStructure();
            objIP.DOBChanged += new SimpleEventHandler(MyEventHanderMethod);
            objIP.NameChanged += new SimpleEventHandler(MyEventHanderMethod);
            objIP.Name = "Bob";
            objIP.DOB = "01/01/80";
            Console.WriteLine(objIP.GetPersonalData());
            //Console.WriteLine(objIP.GetPersonalData("|"));


            /** Using an Abstract Class **/
            //objPC = new PersonClass;
            //objPC = new PersonStructure();
            objPC = new Customer();
            objPC.DOBChanged += new SimpleEventHandler(MyEventHanderMethod);
            objPC.NameChanged += new SimpleEventHandler(MyEventHanderMethod);
            objPC.Name = "Bob";
            objPC.DOB = "01/01/80";
            Console.WriteLine(objPC.GetPersonalData());
            //Console.WriteLine(objPC.GetPersonalData("|"));

            /** Using an "Concrete + Child + Sealed" Class **/
            //objC = new PersonCustomer;
            //objC = new PersonStructure();
            objC = new Customer();
            objC.DOBChanged += new SimpleEventHandler(MyEventHanderMethod);
            objC.NameChanged += new SimpleEventHandler(MyEventHanderMethod);
            objC.Name = "Bob";
            objC.DOB = "01/01/80";
            Console.WriteLine(objC.GetPersonalData());
            Console.WriteLine(objC.GetPersonalData("|"));


            /** Using an Structure **/
            //objPS = new PersonClass;
            objPS = new PersonStructure();
            //objPS = new Customer(); 
            objPS.DOBChanged += new SimpleEventHandler(MyEventHanderMethod);
            objPS.NameChanged += new SimpleEventHandler(MyEventHanderMethod);
            objPS.Name = "Bob";
            objPS.DOB = "01/01/80";
            Console.WriteLine(objPS.GetPersonalData());
            //Console.WriteLine(objPS.GetPersonalData("|"));

        }

        public void MyEventHanderMethod(string Message)
        {
            Console.WriteLine(Message);
        }

    }
}
