using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance
{
    public abstract class Person //Abstract means that is was designed to be used for inheritance.
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

        #region Methods
        public Person()
            : this("", DateTime.Now, Gender.Female)
        {
        }

        public Person(string Name, DateTime DOB, Gender Gender)
        {
            //NewMethod( Name,  DOB,  Gender); 
            this.Name = Name;
            this.dtDOB = DOB;
            this.Gender = Gender;
        }

        //virtual means that it is designed to be overridden
        public virtual string GetData()
        {
            return Name + "," + DOB.ToLongDateString() + "," + Gender.ToString();
        } 
        #endregion
    }
}
