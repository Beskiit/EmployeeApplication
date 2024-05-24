using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeApplication
{
    public partial class frmComputeSalary : Form
    {
        public frmComputeSalary()
        {
            InitializeComponent();
        }

        private void computeButton_Click(object sender, EventArgs e)
        {
            PartTimeEmployee partTime = new PartTimeEmployee(firstNameInput.Text, lastNameInput.Text, departmentInput.Text, jobTitleInput.Text);
            
            double hour = Convert.ToDouble(ratePerHourInput.Text);
            int totalHour = Convert.ToInt32(totalHoursInput.Text);
            partTime.computeSalary(totalHour, hour);

            string firstName = firstNameInput.Text;
            firstNameOutput.Text = firstName;
            string lastName = lastNameInput.Text;
            lastNameOutput.Text = lastName;
            double salary = Convert.ToDouble(partTime.getSalary());
            salaryOutput.Text = salary.ToString();        
                }
    }
}
