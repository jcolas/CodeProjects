using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Console.WriteLine("Please enter the first integer: ");
            value1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second integer: ");
            value2 = Convert.ToInt32(Console.ReadLine());
            var newvalue = value1 + value2;
            Console.WriteLine("The sum of both integers is: " + newvalue);
        }
        public void Subtract()
        {
            Console.WriteLine("Please enter the first integer: ");
            value1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second integer: ");
            value2 = Convert.ToInt32(Console.ReadLine());
            var newvalue = value1 - value2;
            Console.WriteLine("The difference of both integers is: " + newvalue);
        }
        public void Divide()
        {
            Console.WriteLine("Please enter the first integer: ");
            value1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second integer: ");
            value2 = Convert.ToInt32(Console.ReadLine());
            try
            {
                var newvalue = value1 / value2;
                Console.WriteLine("The quotient of both integers is: " + newvalue);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void Multiply()
        {
            Console.WriteLine("Please enter the first integer: ");
            value1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second integer: ");
            value2 = Convert.ToInt32(Console.ReadLine());
            var newvalue = value1 * value2;
            Console.WriteLine("The product of both integers is: " + newvalue);
        }
    }
}
