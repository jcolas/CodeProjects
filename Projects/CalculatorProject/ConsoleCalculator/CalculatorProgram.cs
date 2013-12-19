using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    class CalculatorProgram
    {
        static void Main()
        {
            var Calculator = new DamageCalculator();
            Calculator.RequestTargetValues();
            Calculator.RequestDamageValues();
            Calculator.RequestDamageProperties();
            Calculator.CalculateDamage();
            Calculator.ClosingOptions();            
        }
    }
}