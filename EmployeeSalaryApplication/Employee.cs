using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeSalaryApplication
{
    public abstract class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public float BasicSalary { get; set; }
        public int MonthsWorked { get; set; }
        public float AddedOnTax { get; set; }

        public abstract void DisplayEmployee();

        public abstract float GetAddonTax();

    }
}
