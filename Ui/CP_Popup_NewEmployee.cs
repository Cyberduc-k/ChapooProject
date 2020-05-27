﻿using System;
using System.Drawing;
using System.Windows.Forms;
using Logic;
using Model;

namespace Ui
{
    public partial class CP_Popup_NewEmployee : Form
    {
        //Bools to store if the text boxes are filled in
        private bool firstNameFilledIn = false;
        private bool lastNameFilledIn = false;
        private bool passwordFilledIn = false;

        public CP_Popup_NewEmployee()
        {
            InitializeComponent();

            //Load an icon for the form
            try
            {
                Icon = new Icon("Resources/pencil-icon.ico");
            }
            catch (Exception e)
            {
                ErrorHandler.Instance.HandleError("Het icoon con niet ingeladen worden", "Icoon niet gevonden", e);
            }
        }

        private void CP_Popup_NewEmployee_btnOK_Click(object sender, EventArgs e)
        {
            Employee_Service employeeService = new Employee_Service();

            //Store the values of all of the inputs
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

            //Add a new employee to the system
            try
            {
                employeeService.AddEmployee(new Employee(firstName, lastName, birthDate, employment, gender, password, employeeType));
            }
            catch(Exception ex)
            {
                ErrorHandler.Instance.HandleError("Nieuwe medewerker kon niet toegevoegd worden!", "Medewerker niet toegevoegd", ex);

                //Tell the ControlPanel form that the action didn't succeed
                DialogResult = DialogResult.Cancel;
            }
        }

        private void CP_PopupNewEmployee_btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Get called whenever the text in the FirstName textbox changes
        private void CP_PopopNewEmployee_txtFirstName_TextChanged(object sender, EventArgs e)
        {
            if (CP_PopopNewEmployee_txtFirstName.Text != "")
                firstNameFilledIn = true;
            else
                firstNameFilledIn = false;

            UpdateOKbtn();
        }

        //Get called whenever the text in the LastName textbox changes
        private void CP_PopupNewEmployee_txtLastName_TextChanged(object sender, EventArgs e)
        {
            if (CP_PopupNewEmployee_txtLastName.Text != "")
                lastNameFilledIn = true;
            else
                lastNameFilledIn = false;

            UpdateOKbtn();
        }

        //Get called whenever the text in the Password textbox changes
        private void CP_PopopNewEmployee_txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (CP_PopopNewEmployee_txtPassword.Text != "")
                passwordFilledIn = true;
            else
                passwordFilledIn = false;

            UpdateOKbtn();
        }

        //Check if all txtFields are filled in, and if the OK button can be activated
        private void UpdateOKbtn()
        {

            if (firstNameFilledIn && lastNameFilledIn && passwordFilledIn)
                CP_Popup_NewEmployee_btnOK.Enabled = true;
            else
                CP_Popup_NewEmployee_btnOK.Enabled = false;
        }
    }
}
