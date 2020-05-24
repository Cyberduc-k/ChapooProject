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
    public partial class CP_Popup_EditEmployee : Form
    {
        private int id;

        public CP_Popup_EditEmployee(int id, string firstName, string lastName, DateTime birthDate, DateTime employment, Gender gender, string password, EmployeeType employeeType)
        {
            InitializeComponent();

            CP_PopopEditEmployee_txtFirstName.Text = firstName;
            CP_PopupEditEmployee_txtLastName.Text = lastName;
            CP_PopopEditEmployee_dtpBirthdate.Value = birthDate;
            CP_PopopEditEmployee_dtpEmployment.Value = employment;
            CP_PopopEditEmployee_txtPassword.Text = password;

            if (gender == Gender.Male)
                CP_PopopEditEmployee_rbtnMale.Checked = true;
            else
                CP_PopopEditEmployee_rbtnFemale.Checked = true;

            if (employeeType == EmployeeType.Waiter)
                CP_PopupEditEmployee_rbtnWaiter.Checked = true;
            else if (employeeType == EmployeeType.Bartender)
                CP_PopupEditEmployee_rbtnBartender.Checked = true;
            else if (employeeType == EmployeeType.Chef)
                CP_PopupEditEmployee_rbtnChef.Checked = true;
            else
                CP_PopupEditEmployee_rbtnOwner.Checked = true;

            this.id = id;
        }

        private void CP_Popup_EditEmployee_btnOK_Click(object sender, EventArgs e)
        {
            Employee_Service employeeService = new Employee_Service();

            string firstName = CP_PopopEditEmployee_txtFirstName.Text;
            string lastName = CP_PopupEditEmployee_txtLastName.Text;
            DateTime birthDate = CP_PopopEditEmployee_dtpBirthdate.Value;
            DateTime employment = CP_PopopEditEmployee_dtpEmployment.Value;
            Gender gender;
            string password = CP_PopopEditEmployee_txtPassword.Text;
            EmployeeType employeeType;

            if (CP_PopopEditEmployee_rbtnMale.Checked)
                gender = Gender.Male;
            else
                gender = Gender.Female;

            if (CP_PopupEditEmployee_rbtnWaiter.Checked)
                employeeType = EmployeeType.Waiter;
            else if (CP_PopupEditEmployee_rbtnOwner.Checked)
                employeeType = EmployeeType.Owner;
            else if (CP_PopupEditEmployee_rbtnBartender.Checked)
                employeeType = EmployeeType.Bartender;
            else
                employeeType = EmployeeType.Chef;

            //@TODO Handle errors
            if (firstName == "" || lastName == "" || password == null)
                return;

            //employeeService.AddEmployee(new Employee(1, "Bram", "Sierhuis", new DateTime(2001, 5, 16), new DateTime(2020, 5, 20), Gender.Male, "2343", EmployeeType.Chef));
            employeeService.ModifyEmployee(new Employee(id, firstName, lastName, birthDate, employment, gender, password, employeeType));
        }

        private void CP_PopupEditEmployee_btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
