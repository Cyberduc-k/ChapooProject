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
        private Dish_Service dishService;
        private Drink_Service drinkService;
        private Table tafel;
        private Table_Service tableService;
        private Employee employee;
        private string toBeDeleted;

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
            BindingList<Dish> bindlist = new BindingList<Dish>();
            BindingList<Drink> binddrinks = new BindingList<Drink>();
            foreach (Dish d in order.Dishes)
            {
                bindlist.Add(d);
            }
            foreach (Drink d in order.Drinks)
            {
                binddrinks.Add(d);
            }
            //dataGridView.DataSource = order.Dishes;
            dataGridView.DataSource = bindlist;
            Bill_GridDrinks.DataSource = binddrinks;
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
                tafel.Occupied = true;
                tableService.ModifyTable(tafel);
                order.Dishes.Clear();
                order.Drinks.Clear();
                return;
            }

            if (bill.Payed == false)
            {
                orderService.AddOrderWhereBillIdIs(order, bill.Id);
                MessageBox.Show("Bestelling is geplaatst.", "Attentie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                order.Dishes.Clear();
                order.Drinks.Clear();
                return;
            }
            else
            {
                orders = new List<Order>();
                bill = new Bill(DateTime.Now, tafel, orders, employee, false);
                billService.AddBill(bill);
                MessageBox.Show("Bestelling is geplaatst.", "Attentie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                orderService.AddOrderWhereBillIdIs(order, bill.Id);
                tafel.Occupied = true;
                tableService.ModifyTable(tafel);
            }

            foreach(Dish dish in order.Dishes)
            {
                dishService = new Dish_Service();
                dishService.ModifyStock(dish.Id, dish.Stock - dish.Aantal);
            }

            foreach(Drink drink in order.Drinks)
            {
                drinkService = new Drink_Service();
                drinkService.ModifyStock(drink.Id, drink.Stock - drink.Aantal);
            }
            order.Dishes.Clear();
            order.Drinks.Clear();
            order = new Order();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];
                toBeDeleted = row.Cells["Name"].Value.ToString();
            }
        }

        private void verwijderBtn_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach (DataGridViewRow item in this.dataGridView.SelectedRows)
            {
                i = item.Index;
                dataGridView.Rows.RemoveAt(item.Index);
                order.Dishes.RemoveAt(i);
            }
            foreach (DataGridViewRow item in this.Bill_GridDrinks.SelectedRows)
            {
                i = item.Index;
                Bill_GridDrinks.Rows.RemoveAt(item.Index);
                order.Drinks.RemoveAt(i);
            }
        }

        private void Bill_GridDrinks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
