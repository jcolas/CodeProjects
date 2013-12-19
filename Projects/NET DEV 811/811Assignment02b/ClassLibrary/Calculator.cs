using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _811Assignment02b
{
    static public class Calculator
    {
        static public void Add(int value1, int value2, out string valuestring)
        {
            int value3 = value1 + value2;
            valuestring = Convert.ToString(value3);
        }

        static public void Subtract(int value1, int value2, out string valuestring)
        {
            int value3 = value1 - value2;
            valuestring = Convert.ToString(value3);
        }

        static public void Divide(int value1, int value2, out string valuestring)
        {
            int value3 = value1 / value2;
            valuestring = Convert.ToString(value3);
        }

        static public void Multiply(int value1, int value2, out string valuestring)
        {
            int value3 = value1 * value2;
            valuestring = Convert.ToString(value3);
        }
    }
}