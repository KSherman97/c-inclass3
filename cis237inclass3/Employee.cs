using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass3
{
    class Employee
    {
        // variables / Backing fields
        protected string _firstName;
        protected string _lastName;
        protected DateTime _startDate;

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

        public string GetAllEmployeeInformation()
        {
            return this._firstName + " " + this._lastName + " " + this.GetEmploymentDurationInYears();
        }

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
