using System;

namespace EmployeeSalaryApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            EmployeeManagement employeemanagement = new EmployeeManagement();
            Employee employeevarun = new ContractEmployee();
            Employee employeemalisa = new ContractEmployee();
            Employee employeelungelo = new PermanentEmployee();

            employeevarun.BasicSalary = 8000;

            employeemalisa.BasicSalary = 8000;
            employeemalisa.MonthsWorked = 7;

            employeelungelo.BasicSalary = 17000;

            employeemanagement.DisplayDetails(employeevarun);
            employeemanagement.DisplayDetails(employeemalisa);
            employeemanagement.DisplayDetails(employeelungelo);

            Console.ReadKey();

        }
    }
}
