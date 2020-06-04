﻿using System;
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
    public partial class CP_Popup_EditEmployee : CP_Popup_Parent
    {
        private int id;

        //Bools to store if the text boxes are filled in
        private bool firstNameFilledIn = false;
        private bool lastNameFilledIn = false;
        private bool passwordFilledIn = false;

        public CP_Popup_EditEmployee(Employee employee)
        {
            InitializeComponent();

            //Load an icon for the form
            LoadIcon("Resources/pencil-icon.ico");

            //Show the current values of the employee
            CP_PopopEditEmployee_txtFirstName.Text = employee.FirstName;
            CP_PopupEditEmployee_txtLastName.Text = employee.LastName;
            CP_PopopEditEmployee_dtpBirthdate.Value = employee.BirthDate;
            CP_PopopEditEmployee_dtpEmployment.Value = employee.DateEmployment;
            CP_PopopEditEmployee_txtPassword.Text = employee.Password;

            if (employee.Gender == Gender.Male)
                CP_PopopEditEmployee_rbtnMale.Checked = true;
            else
                CP_PopopEditEmployee_rbtnFemale.Checked = true;

            if (employee.EmployeeType == EmployeeType.Waiter)
                CP_PopupEditEmployee_rbtnWaiter.Checked = true;
            else if (employee.EmployeeType == EmployeeType.Bartender)
                CP_PopupEditEmployee_rbtnBartender.Checked = true;
            else if (employee.EmployeeType == EmployeeType.Chef)
                CP_PopupEditEmployee_rbtnChef.Checked = true;
            else
                CP_PopupEditEmployee_rbtnOwner.Checked = true;

            id = employee.Id;
        }

        public override void OnClickOK(object sender, EventArgs e)
        {
            CP_Popup_Sure popup = new CP_Popup_Sure();
            popup.SetAsEdit(CP_PopopEditEmployee_txtFirstName.Text);
            popup.ShowDialog();

            if (!(popup.DialogResult == DialogResult.OK))
            {
                DialogResult = DialogResult.Cancel;
                Close();
            }

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

            employeeService.ModifyEmployee(new Employee(id, firstName, lastName, birthDate, employment, gender, password, employeeType));
        }

        public override void OnClickCancel(object sender, EventArgs e)
        {
            Close();
        }

        private void CP_PopopEditEmployee_txtFirstName_TextChanged(object sender, EventArgs e)
        {
            if (CP_PopopEditEmployee_txtFirstName.Text != "")
                firstNameFilledIn = true;
            else
                firstNameFilledIn = false;

            UpdateOKbtn(firstNameFilledIn, lastNameFilledIn, passwordFilledIn);
        }

        private void CP_PopupEditEmployee_txtLastName_TextChanged(object sender, EventArgs e)
        {
            if (CP_PopupEditEmployee_txtLastName.Text != "")
                lastNameFilledIn = true;
            else
                lastNameFilledIn = false;

            UpdateOKbtn(firstNameFilledIn, lastNameFilledIn, passwordFilledIn);
        }

        private void CP_PopopEditEmployee_txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (CP_PopopEditEmployee_txtPassword.Text != "")
                passwordFilledIn = true;
            else
                passwordFilledIn = false;

            UpdateOKbtn(firstNameFilledIn, lastNameFilledIn, passwordFilledIn);
        }
    }
}
