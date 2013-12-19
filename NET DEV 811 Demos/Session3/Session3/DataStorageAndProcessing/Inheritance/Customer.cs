using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance
{
    class Customer:Person 
    {
       private int intCustomerId;

        public int CustomerId
        {
            get { return intCustomerId; }
            set { intCustomerId = value; }
        }

        public new string GetData() //Using the New keyword forces an override!
        {
            //return CustomerId.ToString() + Name + DOB + Gender.ToString();
           return CustomerId.ToString() + "," + base.GetData(); //the BASE keyword refers to the Parent, or Base, class.
        }


        private class Address
        {
            public string Street
            {
                get
                {
                    throw new System.NotImplementedException();
                }
                set
                {
                }
            }

            public string City
            {
                get
                {
                    throw new System.NotImplementedException();
                }
                set
                {
                }
            }

            public string State
            {
                get
                {
                    throw new System.NotImplementedException();
                }
                set
                {
                }
            }

            public string Country
            {
                get
                {
                    throw new System.NotImplementedException();
                }
                set
                {
                }
            }
        }

    }
}
