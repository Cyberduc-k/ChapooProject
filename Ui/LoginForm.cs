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
    public partial class LoginForm : Form
    {
        private Employee_Service employee_service = new Employee_Service();

        public LoginForm()
        {
            InitializeComponent();
            FormClosed += new FormClosedEventHandler(OnClosed);
        }

        // Open a new form after logging in
        private void OpenForm(Form form)
        {
            Hide();
            form.Location = Location;
            form.ShowDialog(this);
            Show();
        }

        // Clear the textboxes and show the incorrect info message
        private void IncorrectInfo(bool clearPassword, string message)
        {
            Login_textBoxNummer.Clear();
            Login_textBoxNummer.Focus();
            Login_lblIncorrect.Text = message;
            Login_lblIncorrect.Show();

            if (clearPassword)
                Login_textBoxWachtwoord.Clear();
        }

        private void Login_btnInloggen_Click(object sender, EventArgs e)
        {
            // Parse the user Id into a number
            if (!int.TryParse(Login_textBoxNummer.Text, out int id))
            {
                IncorrectInfo(false, "Incorrect personeelsnummer");
                return;
            }

            string password = Login_textBoxWachtwoord.Text;
            Employee employee = employee_service.GetWithPassword(id, password);

            // Check if the employee was found
            if (employee == null)
            {
                IncorrectInfo(true, "Incorrect wachtwoord of personeelsnummer");
            }
            else
            {
                switch (employee.EmployeeType)
                {
                    case EmployeeType.Owner:
                        OpenForm(new ControlPanelForm());
                        break;
                    case EmployeeType.Chef:
                        OpenForm(new ChefForm());
                        break;
                    case EmployeeType.Bartender:
                        OpenForm(new BarForm());
                        break;
                    case EmployeeType.Waiter:
                        OpenForm(new OrderForm(employee));
                        break;
                }

                Login_textBoxNummer.Clear();
                Login_textBoxWachtwoord.Clear();
                Login_lblIncorrect.Hide();
            }
        }

        private void OnClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
