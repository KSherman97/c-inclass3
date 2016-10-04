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
            SalaryEmployee sEmployees = new SalaryEmployee("Kyle", "Sherman", new DateTime(2014), 1000.01m);
            SalaryEmployee sEmployee2 = new SalaryEmployee();
            Console.WriteLine(sEmployees.nameAndSalary());
        }
    }
}
