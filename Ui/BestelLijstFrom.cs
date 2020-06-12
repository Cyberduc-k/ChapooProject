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
        private Bill bill;
        private Order_Service orderService;
        private List<Order> orders;
        private Bill_Service billService;
        private Table tafel;
        private Table_Service tableService;
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
            MenuForm form = new MenuForm(tafel, order, employee);

            Hide();
            form.ShowDialog(Owner);
            Close();
        }

        private void bestelBtn_Click(object sender, EventArgs e)
        {
            orderService = new Order_Service();
            tableService = new Table_Service();
            order.EmployeeId = employee.Id;
            billService = new Bill_Service();
            try
            {
                bill = billService.GetBillByTableId(tafel.Number);
            }
            catch (Exception d)
            {
                orders = new List<Order>();
                bill = new Bill(DateTime.Now, tafel, orders, employee, false);
                billService.AddBill(bill);
                MessageBox.Show("Bestelling is geplaatst.", "Attentie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                orderService.AddOrderWhereBillIdIs(order, bill.Id);
                tableService.ModifyTable(tafel);
                order = new Order();
                return;
            }

            if (bill.Payed == false)
            {
                orderService.AddOrderWhereBillIdIs(order, bill.Id);
                MessageBox.Show("Bestelling is geplaatst.", "Attentie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                order = new Order();
                return;
            }
            else
            {
                orders = new List<Order>();
                bill = new Bill(DateTime.Now, tafel, orders, employee, false);
                billService.AddBill(bill);
                MessageBox.Show("Bestelling is geplaatst.", "Attentie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                orderService.AddOrderWhereBillIdIs(order, bill.Id);
                tableService.ModifyTable(tafel);
                order = new Order();
            }
            
        }
    }
}
