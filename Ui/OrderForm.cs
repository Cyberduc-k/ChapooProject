using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Logic;

namespace Ui
{
    public partial class OrderForm : Form
    {
        private Table_Service tableService = new Table_Service();
        private List<Table> tafels;
        private Employee employee;
        private Bill_Service billService = new Bill_Service();
        public OrderForm(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            tafels = tableService.GetAllTables();
            var color = System.Drawing.Color.White;
            List<Button> list = new List<Button>();
            int i = 0;

            Bill bill = new Bill();

            foreach (Table t in tafels)
            {
                bill = billService.GetBillByTableId(t.Number);
                color = System.Drawing.Color.Green;

                if (t.Occupied)
                {
                    color = System.Drawing.Color.Red;
                }
                if (bill.Orders.Count > 0)
                {
                    if (bill.Orders.Any(order => order.Dishes.Any(dish => !dish.Finished) || order.Drinks.Any(drink => !drink.Finished)))
                    {
                        color = Color.Orange;
                    }
                    if (bill.Orders.Any(order => order.Dishes.Any(dish => dish.Finished) || order.Drinks.Any(drink => drink.Finished)))
                    {
                        color = Color.Yellow;
                    }
                    if (bill.Orders.All(order => order.Dishes.All(dish => dish.Finished) && order.Drinks.All(drink => drink.Finished)))
                    {
                        color = Color.Red;
                    }
                }
                if (bill.Payed)
                {
                    color = System.Drawing.Color.Green;
                }
                Button btn = new Button();
                btn.BackColor = color;
                btn.Name = ("tafel" + t.Number);
                btn.Text = t.Number.ToString();
                btn.Click += new EventHandler(this.ClickEvent);
                Point point = new Point();
                point.X = i * 83;
                point.Y = 35;
                btn.Size = new Size(50, 50);
                btn.PointToClient(point);
                btn.Show();
                list.Add(btn);
                i++;
                this.Controls.Add(btn);
            }
            Button[] btns = list.ToArray();

            flowPanel.Controls.AddRange(btns);
        }

        private void ClickEvent(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int tafelnr = int.Parse(btn.Text);
            Table tafel = new Table();

            foreach(Table t in tafels)
            {
                if (t.Number == tafelnr)
                {
                    tafel = t;
                }
            }

            Order order = new Order();
            MenuForm menu = new MenuForm(tafel, order, employee);

            Hide();
            menu.ShowDialog(Owner);
            Close();
        }
    }
}
