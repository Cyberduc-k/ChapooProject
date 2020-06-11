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
        private Bill_Service billService;
        private Table tafel;
        private Employee employee;

        public BestelLijstFrom(Table tafel, Order order, Employee employee)
        {
            this.tafel = tafel;
            this.order = order;
            this.employee = employee;
            InitializeComponent();
        }

        private void BestelLijstFrom_Load(object sender, EventArgs e)
        {
            if (order.Dishes == null && order.Drinks == null)
            {
                dataGridView.Visible = false;
                Bill_GridDrinks.Visible = false;
                label1.Text = "Er is nog niets besteld!";
                bestelBtn.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
            }
            dataGridView.DataSource = order.Dishes;
            Bill_GridDrinks.DataSource = order.Drinks;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuForm form = new MenuForm(tafel, order, employee);
            form.Show();
        }

        private void bestelBtn_Click(object sender, EventArgs e)
        {
            orderService = new Order_Service();
            order.EmployeeId = employee.Id;
            orderService.AddOrder(order);
            billService = new Bill_Service();
            Bill bill = billService.GetBillByTableId(tafel.Number);

            if (bill != null)
            {
                orderService.AddOrderWhereBillIdIs(order, bill.Id);
                MessageBox.Show("Bestelling is geplaatst.", "Attentie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                order = new Order();
                return;
            }

            bill = new Bill(DateTime.Now, tafel, orders, employee, false);
            billService.AddBill(bill);
            MessageBox.Show("Bestelling is geplaatst.", "Attentie", MessageBoxButtons.OK, MessageBoxIcon.Information);
            order = new Order();
        }
    }
}
