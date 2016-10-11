using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass3
{
    interface IEmployeeCollection
    {
        // 2 different versions of this will appear. This is called method overload
        void add(string FirstName, string LastName, DateTime StartDate, decimal Salary);
        void add(string FirstName, string LastName, DateTime StartDate, decimal HourlyRate, decimal HoursPerWeek);

        string GetPrintString();
    }
}
