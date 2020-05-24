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
        }

        private void CheckCredentials()
        {
            // @TODO Handle errors
            //catch (Exception e){
            //    ErrorHandler.Instance.HandleError("Er kon geen connectie gemaakt worden met de databse. Heeft u wel internet?", "Connectie mislukt", e);
            //}

            int id = int.Parse(Login_textBoxNummer.Text);
            string password = Login_textBoxWachtwoord.Text;
            Employee employee = employee_service.GetWithPassword(id, password);

            if (employee == null)
            {
                Login_textBoxNummer.Clear();
                Login_textBoxWachtwoord.Clear();
                Login_lblIncorrect.Show();
            }
            else
            {
                // @TODO
            }
        }

        private void Login_btnInloggen_Click(object sender, EventArgs e)
        {
            if (state == LoginState.Start)
            {
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
    }
}
