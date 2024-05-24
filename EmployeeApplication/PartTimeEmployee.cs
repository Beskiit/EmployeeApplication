using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeInterface;

namespace EmployeeApplication
{
    internal class PartTimeEmployee : IEmployee
    {
        private string first_name;
        private string last_name;
        private string department;
        private string job_title;
        private double basic_salary;

        string IEmployee.FirstName
        {
            set
            {
                first_name = value;
            }
            get
            {
                return first_name;
            }
        }

        string IEmployee.LastName
        {
            set
            {
                last_name = value;
            }
            get
            {
                return last_name;
            }
        }

        string IEmployee.Department
        {
            set
            {
                department = value;
            }
            get
            {
                return department;
            }
        }

        string IEmployee.JobTitle
        {
            set
            {
                job_title = value;
            }
            get
            {
                return job_title;
            }
        }

        double IEmployee.BasicSalary
        {
            set
            {
                basic_salary = value;
            }
            get
            {
                return basic_salary;
            }
        }

        public PartTimeEmployee(string FName, string LName, string dept, string job)
        {
            this.first_name = FName;
            this.last_name = LName;
            this.department = dept;
            this.job_title = job;
        }

        public void computeSalary(int hoursWorked, double ratePerHour)
        {
            basic_salary = hoursWorked * ratePerHour;
        }

        public double getSalary()
        {
            return basic_salary;
        }
    }
}
