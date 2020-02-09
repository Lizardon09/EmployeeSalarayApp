using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeSalaryApplication
{
    public class TaxBracket
    {
        public float TaxPercentage { get; set; }
        public float LowerLimit { get; set; }
        public float UpperLimit { get; set; }
        public TaxBracket()
        {

        }

        public TaxBracket(float tax, float lower, float upper)
        {
            TaxPercentage = tax;
            LowerLimit = lower;
            UpperLimit = upper;
        }

        public bool FallInBracket(float amount)
        {
            if(LowerLimit <= 0 && amount <= UpperLimit)
            {
                return true;
            }
            else if(UpperLimit <= 0 && amount > LowerLimit)
            {
                return true;
            }
            else if (amount > LowerLimit && amount <= UpperLimit)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void DisplayBracket()
        {
            if (LowerLimit <= 0)
            {
                Console.WriteLine($"This tax bracket is <={UpperLimit} with a rate of {TaxPercentage}");
            }
            else if (UpperLimit <= 0)
            {
                Console.WriteLine($"This tax bracket is =>{LowerLimit} with a rate of {TaxPercentage}");
            }
            else
            {
                Console.WriteLine($"This tax bracket is BETWEEN {LowerLimit} and {UpperLimit} with a rate of {TaxPercentage}");
            }
        }

    }
}
