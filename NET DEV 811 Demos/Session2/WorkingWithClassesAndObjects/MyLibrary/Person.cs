using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mylibrary
{
    public class Person
    {
        #region Fields
        private string strName;
        private DateTime dtDOB;
        private Gender enmGender;
        #endregion

        #region Events
        public event EventHandler NameChanged;
        public event EventHandler DOBChanged;
        public event EventHandler GenderChanged;
        #endregion

        #region Properties
        public string Name
        {
            get
            {

                try
                {
                    if (string.IsNullOrEmpty(strName))
                    {
                        throw new Exception("Name has not be set to a value!");
                    }
                    return strName;
                }
                catch (Exception)
                {
                    throw;
                }

            }
            set
            {
                try
                {
                    foreach (char chrLetter in (string)value)
                    {
                        if (char.IsDigit(chrLetter))
                        {
                            throw new Exception("Numbers are not allowed in a name.");
                        }
                    }

                    strName = value;
                    if (NameChanged != null)
                    {
                        NameChanged(this, new EventArgs());
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public DateTime DOB
        {
            get
            {
                return dtDOB;
            }
            set
            {

                try
                {
                    if (value > DateTime.Now)
                    {
                        throw new Exception("DOB cannot be in the future!");
                    }
                    dtDOB = value;
                    if (DOBChanged != null)
                    {
                        DOBChanged(this, new EventArgs());
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }

        }

        public Gender Gender
        {
            get
            {
                return enmGender;
            }
            set
            {
                enmGender = value;
                if (GenderChanged != null)
                {
                    GenderChanged(this, new EventArgs());
                }
            }
        }

        #endregion

        #region Constructors
        public Person()
            : this("", DateTime.Now, Gender.Female)
        {
            //Name = "";
            //DOB = DateTime.Now;
            //Gender = Gender.Female;          

            Console.WriteLine("This will be processed AFTER the 3 argument constructor");

            //NewMethod("", DateTime.Now, Gender.Female);
        }


        public Person(string Name, DateTime DOB, Gender Gender)
        {
            this.Name = Name;
            this.DOB = DOB;
            this.Gender = Gender;
        }

        #endregion

        #region Methods
        public String GetData()
        {
            return Name + "," + DOB.ToLongDateString() + "," + Gender.ToString();
        }
        #endregion

        #region Indexers
        //This class does not use Indexers
        //So please review the Box_IndexerDemo.cs file!
        #endregion
    }
}
