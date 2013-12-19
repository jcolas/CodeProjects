using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _811Assignment02
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassLibrary.Calculator Calculator = new ClassLibrary.Calculator();
            Console.WriteLine("Would you like me to (A)dd, (S)ubract, (M)ultiply, or (D)ivide? ");
            string selection = Console.ReadLine();
            switch (selection)
            {
                case "a":
                    Calculator.Add();
                    break;
                case "s":
                    Calculator.Subtract();
                    break;
                case "m":
                    Calculator.Multiply();
                    break;
                case "d":
                    Calculator.Divide();
                    break;
                default:
                    Console.WriteLine("Please chose either (A)dd, (S)ubract, (M)ultiply, or (D)ivide:  ");
                    break;
            }
        }
    }
}