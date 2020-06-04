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
    public partial class BestelLijstFrom : Form
    {
        private Order order;
        private Reservation_Service reservationService;
        private Table tafel;
        public BestelLijstFrom(Table tafel, Order order)
        {
            this.tafel = tafel;
            this.order = order;
            InitializeComponent();
        }

        private void BestelLijstFrom_Load(object sender, EventArgs e)
        {
            if (order.Dishes == null && order.Drinks == null)
            {
                dataGridView.Visible = false;
                label1.Text = "Er is nog niets besteld!";
            }
            dataGridView.DataSource = order.Dishes;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bestelBtn_Click(object sender, EventArgs e)
        {
            Reservation reservation = new Reservation(1, "testreservation", DateTime.Today, DateTime.Now, DateTime.Today.AddDays(1), 5, tafel);
            reservationService = new Reservation_Service();
            reservationService.AddReservation(reservation);
            MessageBox.Show("Attentie", "Reservatie is geplaatst.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
