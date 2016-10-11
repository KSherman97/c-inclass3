using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeLibrary;

namespace cis237inclass3
{
    class EmployeeCollection : IEmployeeCollection
    {
        // I can instantiate this array as an Employee type because it is an array
        // even though I can't instanciate a single employee since it is abstract,
        // and array is fine. I just have to make sure that I put non-abstract instances into it;
        // I could also instantiate it as type IEmployee
        IEmployee[] employees = new Employee[10];

        int currentIndex;

        // Constructor
        public EmployeeCollection()
        {
            currentIndex = 0;
        }
         
        public void add(string FirstName, string LastName, DateTime StartDate, decimal Salary)
        {
            employees[currentIndex++] = new SalaryEmployee(FirstName, LastName, StartDate, Salary);
        }

        public void add(string FirstName, string LastName, DateTime StartDate, decimal HourlyRate, decimal HoursPerWeek)
        {
            employees[currentIndex++] = new HourlyEmployee(FirstName, LastName, StartDate, HourlyRate, HoursPerWeek);
        }

        public string GetPrintString()
        {
            // declare a new blank string
            string allOutput = "";

            // foreach employee in the collection
            foreach (Employee employee in employees)
            {
                // as long as the employee is not a null value
                if (employee != null)
                {
                    // concat the employee information
                    //allOutput += employee.ToString() + Environment.NewLine;

                    // cast as a salary employee; Called downcasting
                    //another way 
                    //SalaryEmployee s = (SalaryEmployee)employee;
                    // s.nameAndSalary();
                    // we need to check to see if the type is of salaryEmployees
                    // otherwise calling the nameandsalary method would fail for 
                    // all ther types of classes
                    if (employee.GetType() == typeof(SalaryEmployee))   // this if statement makes sure that the type is of salary employee to prevent errors
                    {
                        // this is called a down cast because we are down casting it from
                        // the type of employees down to the type of salaryemployee
                        allOutput += ((SalaryEmployee)employee).nameAndSalary() + Environment.NewLine;
                    }
                    else
                    {
                        // concat the employee information
                        allOutput += employee.ToString() + Environment.NewLine;
                    }
                }
            }
            return allOutput; // return the concatinated string of employees
        }
    }
}
