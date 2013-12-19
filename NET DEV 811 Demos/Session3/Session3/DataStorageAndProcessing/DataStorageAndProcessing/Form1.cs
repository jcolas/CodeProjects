using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DataStorageAndProcessing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Using Dlls Tab
        private void buttonTestDll_Click(object sender, EventArgs e)
        {
            // Create a new task object for the Dll demo
            DemoClassLibrary.Task objT1;
            objT1 = new DemoClassLibrary.Task();
            objT1.TaskDescription = textBoxTaskDesc.Text;
            MessageBox.Show(objT1.TaskDescription);

            DemoClassLibrary.FileWriter objFD;
            objFD = new DemoClassLibrary.FileWriter();
            try
            {
                objFD.SaveToFile(objT1.TaskDescription);
                MessageBox.Show("File saved");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        #endregion

        #region Access Modifiers Tab

            /* Access Modifiers and Inheritance */
        private void buttonTestAccessModifiers_Click(object sender, EventArgs e)
        {

            #region Working with an object made in the same assembly
            AccessModiferTests objTypicalClass;
            objTypicalClass = new AccessModiferTests();

            // These modifiers work from this location...
            objTypicalClass.TestPublic = -1;
            objTypicalClass.TestInternal = -1;
            objTypicalClass.TestProtectedInternal = -1;
            objTypicalClass.ShowData();

             //This does not work since it is private to the class           
            //objAMT.TestPrivate = -1;

            //This does not work since there is no inheritance to the Form1 class!    
            //objAMT.TestProtected = -1; 
            #endregion

            #region Working with an object made from a Child class, with a parent class in the same assembly
            AccessModifierChildClass objBasicChildClass;
            objBasicChildClass = new AccessModifierChildClass();
            objBasicChildClass.TestPublic = -2;
            objBasicChildClass.TestInternal = -2;
            objBasicChildClass.TestProtectedInternal = -2;
            objBasicChildClass.ShowData();

            //This still does not work since it is private to the class
            //objBasicChildClass.TestPrivate = -2;

            //This still does not work since there is no inheritance to the Form1 class!            
            //objBasicChildClass.TestProtected = -2;

            //HOWEVER, you can now access protected data within a child class (look at AccessModifierChildClass.cs)
            #endregion

            #region Working with an object made in the Different assembly
            /* Access Modifiers and DLLs */
            DemoClassLibrary.DLLAccessModifierTest objTypicalClassFromExternalAssembly;
            objTypicalClassFromExternalAssembly = new DemoClassLibrary.DLLAccessModifierTest();
            objTypicalClassFromExternalAssembly.TestPublic = -3;
            objTypicalClassFromExternalAssembly.ShowData();

            //These do not work now since they are not in the same assembly nor part of inheritance...
            //objTypicalClassFromExternalAssembly.TestInternal = -3;

            //... nor, part of inheritance.
            //objTypicalClassFromExternalAssembly.TestProtectedInternal = -3;

            //Of course this will not work from here
            //objTypicalClassFromExternalAssembly.TestPrivate = -3;

            //This does not work since there is no inheritance to the Form1 class!             
            //objTypicalClassFromExternalAssembly.TestProtected = -3;
            #endregion


            #region Working with an object made from a Child class, with a parent class in the same assembly
            
            /* Access Modifiers and DLLs */
            DLLAccessModifierTestChildClass objChildWithExertnalParent;
            objChildWithExertnalParent = new DLLAccessModifierTestChildClass();
            objChildWithExertnalParent.TestPublic = -3;
            objChildWithExertnalParent.ShowData();

            //These do not work now since they are not in the same assembly or part of inheritance.
            //objChildWithExertnalParent.TestInternal = -3;
            //objChildWithExertnalParent.TestProtectedInternal = -3;

            //Of course this will not work from here
            //objChildWithExertnalParent.TestPrivate = -3;

            //This does not work since there is no inheritance to the Form1 class!             
            //objChildWithExertnalParent.TestProtected = -3;

            //HOWEVER, you can now access protected data within a child class (look at DLLAccessModifierChildClass.cs)
            #endregion
        }

        #endregion

    }
}
