using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeSalaryApplication
{
    public class ContractEmployee : Employee
    {

        public ContractEmployee()
        {
            AddedOnTax = 0.1F;
        }

        public override void DisplayEmployee()
        {
            Console.WriteLine($"This is a Contract employee");
        }
        public override float GetAddonTax()
        {
            if(MonthsWorked > 6)
            {
                return AddedOnTax;
            }
            else
            {
                return 1;
            }
        }
    }
}
