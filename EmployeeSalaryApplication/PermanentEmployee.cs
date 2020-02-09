using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeSalaryApplication
{
    public class PermanentEmployee : Employee
    {
        public override void DisplayEmployee()
        {
            Console.WriteLine("This is a permament Employee");
        }

        public override float GetAddonTax()
        {
            return 1;
        }
    }
}
