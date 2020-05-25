using System;
using System.Windows.Forms;
using Logic;
using Model;

namespace Ui
{
    public partial class CP_Popup_NewEmployee : Form
    {
        private bool firstNameFilledIn = false;
        private bool lastNameFilledIn = false;
        private bool passwordFilledIn = false;

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

            employeeService.AddEmployee(new Employee(1, firstName, lastName, birthDate, employment, gender, password, employeeType));
        }

        private void CP_PopupNewEmployee_btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CP_PopopNewEmployee_txtFirstName_TextChanged(object sender, EventArgs e)
        {
            if (CP_PopopNewEmployee_txtFirstName.Text != "")
                firstNameFilledIn = true;
            else
                firstNameFilledIn = false;

            UpdateOKbtn();
        }

        private void CP_PopupNewEmployee_txtLastName_TextChanged(object sender, EventArgs e)
        {
            if (CP_PopupNewEmployee_txtLastName.Text != "")
                lastNameFilledIn = true;
            else
                lastNameFilledIn = false;

            UpdateOKbtn();
        }

        private void CP_PopopNewEmployee_txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (CP_PopopNewEmployee_txtPassword.Text != "")
                passwordFilledIn = true;
            else
                passwordFilledIn = false;

            UpdateOKbtn();
        }

        private void UpdateOKbtn()
        {

            if (firstNameFilledIn && lastNameFilledIn && passwordFilledIn)
                CP_Popup_NewEmployee_btnOK.Enabled = true;
            else
                CP_Popup_NewEmployee_btnOK.Enabled = false;
        }
    }
}
