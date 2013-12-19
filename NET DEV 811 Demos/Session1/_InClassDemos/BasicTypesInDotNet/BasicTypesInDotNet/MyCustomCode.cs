using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicTypesInDotNet
{
    /* .Net offers five basic "Types"
     * Enums
     * Delegates
     * Interfaces
     * Structures
     * Classes
     */

    //An Enum provides a pattern of Choices
    enum CustomerType { Wholesale = 1, Retail = 2 }

    //A Delegate defines the pattern for a Method.
    delegate void SimpleEventHandler(string Message);

    //An Interface defines the pattern for a Structure or a Class.
    interface IPerson
    { //An interface contains only the signatures of: 

        //events
        event SimpleEventHandler NameChanged;
        event SimpleEventHandler DOBChanged;

        //properties
        string Name { get; set; }
        string DOB { get; set; }

        //methods
        string GetPersonalData();

    }

    //Classes CAN define a pattern for child classes or structures.
    //And, provides actual implementation code!
    abstract class PersonClass : IPerson
    {
        //Default Constructor Method
        public PersonClass()
        { strName = "Some Initial Value"; strDOB = "Some Initial Value"; }

        //An additional Constructor Method
        public PersonClass(string FullName, string DateOfBirth)
        {
            Name = FullName;
            DOB = DateOfBirth;
        }

        //Events
        public event SimpleEventHandler NameChanged;
        public event SimpleEventHandler DOBChanged;

        //Fields
        private string strName;
        private string strDOB;

        //Properties
        public string Name
        {
            get { return strName; }
            set { strName = value; NameChanged("The Name has been changed."); }
        }

        public string DOB
        {
            get { return strDOB; }
            set { strDOB = value; DOBChanged("The Date of Birth (DBO) has been changed."); }
        }

        //Methods
        public string GetPersonalData()
        { return strName + "," + strDOB; }

        public virtual string GetPersonalData(string Seperator)
        { return strName + Seperator + strDOB; }

    }

    //Or, Classes can just provide implementation code!
    sealed class Customer : PersonClass
    {
        //Technically, the Constructor Methods do NOT inherit, but they do seem to, since it runs the base's constructor code.
        public Customer()
        {
        }

        //Technically, An additional Constructor Methods do NOT inherit
        public Customer(string FullName, string DateOfBirth)
        {
            //Note: We cannot set strName or strDOB here since they are private,
            //but we could if we changed private to protected!
            base.Name = FullName;
            base.DOB = DateOfBirth;
        }


        //Additional Events
        public event SimpleEventHandler CustomerIdChanged;

        //Additional Fields
        private int intCustomerId;


        //Additional Properties
        public int CustomerId
        {
            get { return intCustomerId; }
            set { intCustomerId = value; CustomerIdChanged("The Date of Birth (DBO) has been changed."); }
        }

        //Additional Methods 
        //Note: I am using the NEW Keyword to Override the existing method
        new public string GetPersonalData()
        { return Convert.ToString(intCustomerId) + "," + Name + "," + DOB; }

        //Note: I am using the OVERRIDE Keyword to Override the existing method
        public override string GetPersonalData(string Seperator)
        {
            return Convert.ToString(intCustomerId) + Seperator + Name + Seperator + DOB;
        }
    }

    //Structures can only provide implementation code!
    struct PersonStructure : IPerson
    {
        //Default Constructor Method (NOTE: You cannot define the Default Constructor in a Struct!)
        /*** public PersonStructure() { strName = "Some Initial Value"; strDOB = "Some Initial Value"; } ***/

        //An additional Constructor Method
        public PersonStructure(string FullName, string DateOfBirth)
            : this() //This forces my additional constructor to call the hidden default one!
        {
            Name = FullName;
            DOB = DateOfBirth;
        }

        //events
        public event SimpleEventHandler NameChanged;
        public event SimpleEventHandler DOBChanged;

        //Fields 
        //Note: These should be marked as Protected instead of Private.
        private string strName;
        private string strDOB;

        //Properties
        public string Name
        {
            get { return strName; }
            set { strName = value; NameChanged("The Name has been changed."); }
        }

        public string DOB
        {
            get { return strDOB; }
            set { strDOB = value; DOBChanged("The Data of Birth (DBO) has been changed."); }
        }

        //Methods
        public string GetPersonalData()
        { return strName + "," + strDOB; }
    }




}
