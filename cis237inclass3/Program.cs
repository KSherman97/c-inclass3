using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Employee employee = new Employee();
            SalaryEmployee sEmployees = new SalaryEmployee("Kyle", "Sherman", new DateTime(2014, 10, 31), 1000.01m);
            //Console.WriteLine(sEmployees.GetAllEmployeeInformation().ToString());
            Console.WriteLine(sEmployees.ToString());
            //SalaryEmployee sEmployee2 = new SalaryEmployee();
            //Console.WriteLine(sEmployees.nameAndSalary());

            HourlyEmployee hEmployee1 = new HourlyEmployee("Steve", "MahBoi", new DateTime(2013, 10, 31), 1000.01m, 40);
            //Console.WriteLine(hEmployee1.GetAllEmployeeInformation().ToString());
            Console.WriteLine(hEmployee1.ToString());
            Console.WriteLine(hEmployee1.GetYearlySalary());
            Console.WriteLine(hEmployee1.GetAllEmployeeInformation());

        }
    }
}
