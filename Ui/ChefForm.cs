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
    public partial class ChefForm : Form
    {
        private Order_Service order_service = new Order_Service();

        public ChefForm()
        {
            InitializeComponent();
            Chef_btnOverzicht_Click(null, null);
        }

        // Highlight a button
        private void SetHightlight(Button btn)
        {
            Chef_btnOverzicht.BackColor = Color.FromArgb(0, 165, 229);
            Chef_btnVoorraad.BackColor = Color.FromArgb(0, 165, 229);
            btn.BackColor = Color.FromArgb(0, 184, 255);
        }

        private void HideAllPanels()
        {
            Chef_pnlOverzicht.Hide();
            // Chef_pnlvoorraad.Hide();
        }

        private void Chef_btnOverzicht_Click(object sender, EventArgs e)
        {
            SetHightlight(Chef_btnOverzicht);
            Chef_lblActivePanel.Text = "Overzicht";
            HideAllPanels();
            Chef_lblGeenBestellingen.Hide();
            Chef_pnlFirstOrder.Hide();
            Chef_pnlOverzicht.Show();

            List<Order> orders = order_service.GetAllOrders();

            if (orders.Count == 0)
                Chef_lblGeenBestellingen.Show();
            else
            {
                Chef_pnlFirstOrder.Show();
            }
        }

        private void Chef_btnVoorraad_Click(object sender, EventArgs e)
        {
            SetHightlight(Chef_btnVoorraad);
            Chef_lblActivePanel.Text = "Voorraad";
            HideAllPanels();
            // Chef_pnlVoorraad.Show();
        }
    }
}
