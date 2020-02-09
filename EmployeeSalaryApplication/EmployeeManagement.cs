using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeSalaryApplication
{
    public class EmployeeManagement
    {
        public List<TaxBracket> LevelsOfTax { get; set; }

        public EmployeeManagement()
        {
            LevelsOfTax = new List<TaxBracket>() { new TaxBracket(0.1F, 5000, 10000),
                                                    new TaxBracket(0.15F, 10000, 15000),
                                                    new TaxBracket(0.2F, 15000, 20000),
                                                    new TaxBracket(0.25F, 20000, 30000),
                                                    new TaxBracket(0.3F, 30000, -1)};
        }

        public float GetTakeHomeSalary (Employee employee)
        {
            foreach (var taxlevel in LevelsOfTax)
            {
                if (taxlevel.FallInBracket(employee.BasicSalary))
                {
                    return (employee.BasicSalary - (employee.BasicSalary * taxlevel.TaxPercentage) * employee.GetAddonTax());
                }
            }
            return employee.BasicSalary;
        }

        public float GetTaxAmount (Employee employee)
        {
            foreach (var taxlevel in LevelsOfTax)
            {
                if (taxlevel.FallInBracket(employee.BasicSalary))
                {
                    return (employee.BasicSalary * taxlevel.TaxPercentage) * employee.GetAddonTax();
                }
            }
            return 0;
        }

        public void DisplayDetails(Employee employee)
        {
            employee.DisplayEmployee();
            Console.WriteLine($"\nNet Salary: R{employee.BasicSalary}");
            Console.WriteLine($"Take Home Salary: R{GetTakeHomeSalary(employee)}");
            Console.WriteLine($"Tax Amount R{GetTaxAmount(employee)}\n");
        }
    }
}
