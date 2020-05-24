using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic;
using Model;

namespace Ui
{
    public partial class CP_Popup_NewEmployee : Form
    {
        public CP_Popup_NewEmployee()
        {
            InitializeComponent();
        }

        private void CP_Popup_NewEmployee_btnOK_Click(object sender, EventArgs e)
        {
            Employee_Service employeeService = new Employee_Service();

            string firstName = CP_PopopNewEmployee_txtFirstName.Text;
            string lastName = CP_PopupNewEmployee_txtLastName.Text;
            DateTime birthDate = CP_PopopNewEmployee_dtpBirthdate.Value;
            DateTime employment = CP_PopopNewEmployee_dtpEmployment.Value;
            Gender gender;
            string password = CP_PopopNewEmployee_txtPassword.Text;
            EmployeeType employeeType;

            if (CP_PopopNewEmployee_rbtnMale.Checked)
                gender = Gender.Male;
            else
                gender = Gender.Female;

            if (CP_PopupNewEmployee_rbtnWaiter.Checked)
                employeeType = EmployeeType.Waiter;
            else if (CP_PopupNewEmployee_rbtnOwner.Checked)
                employeeType = EmployeeType.Owner;
            else if (CP_PopupNewEmployee_rbtnBartender.Checked)
                employeeType = EmployeeType.Bartender;
            else
                employeeType = EmployeeType.Chef;

            //@TODO Handle errors
            if (firstName == "" || lastName == "" || password == null)
                return;

            //employeeService.AddEmployee(new Employee(1, "Bram", "Sierhuis", new DateTime(2001, 5, 16), new DateTime(2020, 5, 20), Gender.Male, "2343", EmployeeType.Chef));
            employeeService.AddEmployee(new Employee(1, firstName, lastName, birthDate, employment, gender, password, employeeType));
        }

        private void CP_PopupNewEmployee_btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
