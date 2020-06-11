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
        private Order_Service orderService;
        private List<Order> orders;
        private Bill bill;
        private Bill_Service billService;
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
            MenuForm form = new MenuForm(tafel, order);
            form.Show();
        }

        private void bestelBtn_Click(object sender, EventArgs e)
        {
            orderService = new Order_Service();
            order.EmployeeId = 1021;
            orderService.AddOrder(order);
            MessageBox.Show("Bestelling is geplaatst.", "Attentie", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
