using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibraryDemo
{
    public class Customer : Person
    {
        readonly int intCustomerID; //Note that this is a read only Field!

        public int CustomerID
        {
            get { return intCustomerID; }
        } 

        //internal is the default! Which would only be accessible in the same assembly
        public Customer(int CustomerID, string Name, DateTime DOB, Gender Gender)
        {
            this.intCustomerID = CustomerID; //Read Only fields must be set by the constructor.
            this.Name = Name;
            this.DOB = DOB;
            this.Gender = Gender;
        }
    }
}
