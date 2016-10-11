using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    public class HourlyEmployee : Employee
    {
        // backing fields [variables]
        private decimal _hourlyRate;
        private decimal _hoursPerWeek;

        public HourlyEmployee() : base() { }

        // properties
        // properties don't have to be a direct relationship to a single variable.
        // Here I am using 2 variables to get the value for a single property
        public decimal weeklySalary
        {
            get { return this._hourlyRate * this._hoursPerWeek; }
        }

        // methods
        public override string ToString()
        {
            // use the weekly salary property declared above to make up this ToString
            // This way it will return the same string as Salary Employee even though
            // this employee is hourly.
            return base.ToString() + " " + this.weeklySalary;
        }

        // override the virtual method declared in the employee class. I did not need
        // to override it. I could have used the parent class versoins, but I decided not to.
        public override string GetAllEmployeeInformation()
        {
            return base.GetAllEmployeeInformation() + " " + this.weeklySalary.ToString("c");
        }

        public override decimal GetYearlySalary()
        {
            return this.weeklySalary * Employee._weeksInYear;
            //throw new NotImplementedException();
        }

        public HourlyEmployee(string firstName, string lastName, DateTime startDate, decimal hourlyRate, decimal hoursPerWeek) 
            : base(firstName, lastName, startDate)
        {
            this._hourlyRate = hourlyRate;
            this._hoursPerWeek = hoursPerWeek;
        }
    }
}
