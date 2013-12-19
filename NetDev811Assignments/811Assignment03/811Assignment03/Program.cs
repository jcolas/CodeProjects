using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _811Assignment03
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CalculatorForm());
        }
    }

    static public class Calculator 
        {
            static public void Calculate(decimal value1, decimal value2, out decimal Sum, out decimal Difference, out decimal Product, out decimal Quotient)
            {
                Sum = value1 + value2;
                Difference = value1 - value2;
                Product = value1 + value2;
                Quotient = value1 + value2;
            }
        }
}