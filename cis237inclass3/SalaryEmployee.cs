using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass3
{
    class SalaryEmployee : Employee
    {
        private decimal _weeklySalary;
        private const decimal  _weeksInYear = 52;

        public decimal WeeklySalary
        {
            get { return _weeklySalary; }
            set { _weeklySalary = value; }
        }

        // methods
        public string nameAndSalary()
        {
            return base.ToString() + " " + _weeklySalary.ToString("c");        
        }

        // Override the ToString method that is in the parent class employee
        public override string ToString()
        {
            // take the parent ToString and add the weekly salary to it
            return base.ToString() + " " + this._weeklySalary;
        }

        public override string GetAllEmployeeInformation()
        {
            return base.GetAllEmployeeInformation() + " " + this._weeklySalary.ToString("c");
        }

        // override the abstract method in the Employee class. Because the mployee class declares
        // the method as abstract, this class MUST implement it.
        public override decimal GetYearlySalary()
        {
            //throw new NotImplementedException();
            return this._weeklySalary * _weeksInYear;
        }

        // constructor
        public SalaryEmployee(string FirstName, string LastName, DateTime StartDate, decimal WeeklySalary)
            // this next part calls the parent classes constructor so that we don't have to repeat the work
            // that the parent constructor is doing
            : base(FirstName, LastName, StartDate)
        {
            _weeklySalary = WeeklySalary;
        }

        public SalaryEmployee() : base() {}
    }
}
