using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeLibrary;

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

            // declare a new collection and instantiate it
            IEmployeeCollection employeeCollection = new EmployeeCollection();
            // call the addNewEmployee method
            Console.WriteLine();
            AddNewEmployee(employeeCollection);
        }

        static void AddNewEmployee(IEmployeeCollection employeeCollection)
        {
            // a couple of salary employees
            employeeCollection.add("Kyle", "Sherman", new DateTime(2016, 4, 4), 549m);
            employeeCollection.add("Seba", "Weber", new DateTime(2016, 4, 24), 1000m);
            // a couple of hourly employees
            employeeCollection.add("Heinrich", "Himmler", new DateTime(1945, 4, 4), 200m, 50);
            employeeCollection.add("Adolf", "Hitler", new DateTime(1941, 4, 4), 500m, 70);

            PrintCollection(employeeCollection);
        }

        static void PrintCollection(IEmployeeCollection employeeCollection)
        {
            Console.WriteLine(employeeCollection.GetPrintString());
        }
    }
}
