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

        string FirstName
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

        string LastName
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

        string Department
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

        string JobTitle
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

        double BasicSalary
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

        string IEmployee.FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IEmployee.LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IEmployee.Department { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IEmployee.JobTitle { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IEmployee.BasicSalary { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public PartTimeEmployee(string FName, string LName, string dept, string job)
        {
            FirstName = FName;
            LastName = LName;
            Department = dept;
            JobTitle = job;
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
