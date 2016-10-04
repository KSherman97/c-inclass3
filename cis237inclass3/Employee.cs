using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass3
{
    // make this class abstract. This way it can't be instantiated, but
    // it will server as a good base for derived classes
    abstract class Employee
    {
        // variables / Backing fields
        protected string _firstName;
        protected string _lastName;
        protected DateTime _startDate;
        protected const decimal _weeksInYear = 52;

        // properties
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public DateTime StartDate
        {
            get { return _startDate; }
            set { _startDate = value; }
        }

        // methods
        public override string ToString()
        {
            return _firstName + " " + _lastName;
        }

        public int GetEmploymentDurationInYears()
        {
            return new TimeSpan(DateTime.Now.Ticks - this._startDate.Ticks).Days / 365;
        }

        public virtual string GetAllEmployeeInformation()
        {
            return this._firstName + " " + this._lastName + " " + this.GetEmploymentDurationInYears();
        }

        // Get the yearly salary of the employee
        // make the method abstract because we want the sub classes to implement it, but 
        // at this level we don't know how to implement it
        public abstract decimal GetYearlySalary();

        // Constructors
        public Employee(string FirstName, string LastName, DateTime StartDate)
        {
            this._firstName = FirstName;
            this._lastName = LastName;
            this._startDate = StartDate;
        }

        public Employee() { }
    }
}
