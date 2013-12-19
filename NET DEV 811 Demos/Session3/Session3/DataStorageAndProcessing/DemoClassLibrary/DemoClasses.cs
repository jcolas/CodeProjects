using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoClassLibrary
{
    /* Classes are designed around two basic aspects, data storage and data processing. */

    public class Task // A class that primarily STORES data
    {
        string _TaskDescription;

        //In this type of class the properties are its focus
        public string TaskDescription //add validation and formatting code
        {
            get { return _TaskDescription; }
            set { _TaskDescription = value; }
        }

        public override string ToString()
        {
            return TaskDescription;
        }
    }

    public class FileWriter // A class that primarily PROCESSES data
    {
        string _Data;

        public string Data //add validation and formatting code
        {
            get { return _Data; }
            set { _Data = value; }
        }

        //In this type of class the methods are its focus
        public void SaveToFile(string Data)
        {
            try
            {
                this.Data = Data;

                System.IO.StreamWriter objSW;
                objSW = new System.IO.StreamWriter("Data.txt");
                objSW.WriteLine(this.Data);
                objSW.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
