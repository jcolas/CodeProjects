using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary
{
    public class Calculator
    {

        public int value1
        { set; get; }

        public int value2
        { set; get; }

        public void Add()
        {
            value1 = Convert.ToInt32(Console.ReadLine());
            value2 = Convert.ToInt32(Console.ReadLine());
            var newvalue = value1 + value2;
        }
        public void Subtract()
        {
            value1 = Convert.ToInt32(Console.ReadLine());
            value2 = Convert.ToInt32(Console.ReadLine());
            var newvalue = value1 - value2;
        }
        public void Divide()
        {
            value1 = Convert.ToInt32(Console.ReadLine());
            value2 = Convert.ToInt32(Console.ReadLine());
            try
            {
                var newvalue = value1 / value2;
                Console.WriteLine("The quotient of both integers is: " + newvalue);
            }
            catch (DivideByZeroException e)
            {
                MessageBox.Show(e.Message, string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Multiply()
        {
            value1 = Convert.ToInt32(Console.ReadLine());
            value2 = Convert.ToInt32(Console.ReadLine());
            var newvalue = value1 * value2;
        }
    }



}