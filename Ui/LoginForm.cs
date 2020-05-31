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
    public partial class LoginForm : Form
    {
        private LoginState state = LoginState.Start;
        private Employee_Service employee_service = new Employee_Service();

        public LoginForm()
        {
            InitializeComponent();

            // Also show the control panel on startup
            new ControlPanelForm().Show();

            // Also show the chef panel on startup
            new ChefForm().Show();

            // Also show the bar panel on startup
            new BarForm().Show();

            // Also show the order panel on startup
            new OrderForm().Show();

            // Also show the bill panel on startup
            new BillForm().Show();
        }

        private void CheckCredentials()
        {
            // Parse the user Id into a number
            if (!int.TryParse(Login_textBoxNummer.Text, out int id))
            {
                ErrorHandler.Instance.HandleError("Ongeldig personeelsnummer ingevoerd", "Ongeldig personeelsnummer", null);
                ErrorState();
                return;
            }

            string password = Login_textBoxWachtwoord.Text;
            Employee employee = employee_service.GetWithPassword(id, password);

            // Check if the employee was found
            if (employee == null)
            {
                ErrorState();
            }
            else
            {
                switch (employee.EmployeeType)
                {
                    case EmployeeType.Owner:
                        ControlPanelForm cp_form = new ControlPanelForm();

                        Hide();
                        cp_form.Location = Location;
                        cp_form.ShowDialog(this);
                        cp_form.FormClosed += (s, a) => Show();
                        break;
                    case EmployeeType.Chef:
                        ChefForm chef_form = new ChefForm();

                        Hide();
                        chef_form.Location = Location;
                        chef_form.ShowDialog(this);
                        chef_form.FormClosed += (s, a) => Show();
                        break;
                    case EmployeeType.Waiter:
                        OrderForm order_form = new OrderForm();

                        Hide();
                        order_form.Location = Location;
                        order_form.ShowDialog(this);
                        order_form.FormClosed += (s, a) => Show();
                        break;
                }

                ResetState();
            }
        }

        // Clear all text boxes and show the incorrect info message
        private void ErrorState()
        {
            Login_textBoxNummer.Clear();
            Login_textBoxWachtwoord.Clear();
            Login_lblIncorrect.Show();
            Login_textBoxNummer.Focus();
        }

        // Reset the form back to the Start state
        private void ResetState()
        {
            Login_Logo.Top = 285;
            Login_btnInloggen.Top = 631;
            Login_btnAnnuleren.Hide();
            Login_lblNummer.Hide();
            Login_textBoxNummer.Hide();
            Login_lblWachtwoord.Hide();
            Login_textBoxWachtwoord.Hide();
            Login_textBoxNummer.Clear();
            Login_lblIncorrect.Hide();
            Login_textBoxWachtwoord.Clear();
            state = LoginState.Start;
        }

        private void Login_btnInloggen_Click(object sender, EventArgs e)
        {
            if (state == LoginState.Start)
            {
                // Change the form to the EnterCredentials state
                Login_Logo.Top = 118;
                Login_btnInloggen.Top = 792;
                Login_btnAnnuleren.Show();
                Login_lblNummer.Show();
                Login_textBoxNummer.Show();
                Login_lblWachtwoord.Show();
                Login_textBoxWachtwoord.Show();
                Login_textBoxNummer.Focus();
                state = LoginState.EnterCredentials;
            }
            else
            {
                CheckCredentials();
            }
        }

        private void Login_btnAnnuleren_Click(object sender, EventArgs e)
        {
            ResetState();
        }
    }
}
