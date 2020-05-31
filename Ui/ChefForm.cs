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
        private ListViewColumnSorter lvwColumnSorter = new ListViewColumnSorter();
        private Order_Service order_service = new Order_Service();
        private Dish_Service dish_service = new Dish_Service();
        private List<Order> orders;

        public ChefForm()
        {
            InitializeComponent();
            InitializeSorting();
            Chef_btnOverzicht_Click(null, null);
        }

        private void InitializeSorting()
        {
            Chef_lvVoorraad.View = View.Details;
            Chef_lvVoorraad.ListViewItemSorter = lvwColumnSorter;
        }

        // Highlight a button
        private void SetHightlight(Button btn)
        {
            Chef_btnOverzicht.BackColor = Color.FromArgb(0, 165, 229);
            Chef_btnGereed.BackColor = Color.FromArgb(0, 165, 229);
            Chef_btnVoorraad.BackColor = Color.FromArgb(0, 165, 229);
            btn.BackColor = Color.FromArgb(0, 184, 255);
        }

        private void HideAllPanels()
        {
            Chef_pnlOverzicht.Hide();
            Chef_lblGeenBestellingen.Hide();
            Chef_pnlOpmerkingen.Hide();
            Chef_pnlFirstOrder.Hide();
            Chef_pnlSecondOrder.Hide();
            Chef_pnlThirdOrder.Hide();
            Chef_pnlFourthOrder.Hide();
            Chef_pnlOverflow.Hide();
            Chef_pnlGereed.Hide();
            Chef_pnlVoorraad.Hide();
        }

        private void Chef_btnOverzicht_Click(object sender, EventArgs e)
        {
            SetHightlight(Chef_btnOverzicht);
            Chef_lblActivePanel.Text = "Overzicht";
            HideAllPanels();
            Chef_pnlOverzicht.Show();

            // Get all unprocessed orders
            orders = order_service
                .GetAllOrders()
                .Where(order => order.State == OrderState.None || order.State == OrderState.Started)
                .ToList();

            switch (orders.Count)
            {
                case 0:
                    Chef_lblGeenBestellingen.Show();
                    break;
                case 1:
                    FillFirstOrder(orders[0]);
                    break;
                case 2:
                    FillSecondOrder(orders[1]);
                    goto case 1;
                case 3:
                    FillThirdOrder(orders[2]);
                    goto case 2;
                case 4:
                    FillFourthOrder(orders[3]);
                    goto case 3;
                default:
                    ShowOverflow(orders.Count - 4);
                    goto case 4;
            }
        }

        private void FillFirstOrder(Order order)
        {
            Chef_lblOpmerkingenContent.Text = order.Comment;
            Chef_pnlOpmerkingen.Show();
            Chef_lvFirst.Clear();

            foreach (Dish dish in order.Dishes)
                Chef_lvFirst.Items.Add(new ListViewItem(dish.Name));

            Chef_pnlFirstOrder.Show();
        }

        private void FillSecondOrder(Order order)
        {
            Chef_lvSecond.Clear();

            foreach (Dish dish in order.Dishes)
                Chef_lvSecond.Items.Add(new ListViewItem(dish.Name));

            Chef_pnlSecondOrder.Show();
        }

        private void FillThirdOrder(Order order)
        {
            Chef_lvThird.Clear();

            foreach (Dish dish in order.Dishes)
                Chef_lvThird.Items.Add(new ListViewItem(dish.Name));

            Chef_pnlThirdOrder.Show();
        }

        private void FillFourthOrder(Order order)
        {
            Chef_lvFourth.Clear();

            foreach (Dish dish in order.Dishes)
                Chef_lvFourth.Items.Add(new ListViewItem(dish.Name));

            Chef_pnlFourthOrder.Show();
        }

        private void ShowOverflow(int count)
        {
            Chef_pnlOverflow.Show();
            Chef_lblOverflow.Text = string.Format("+ {0}", count);
        }

        private void Chef_btnGereed_Click(object sender, EventArgs e)
        {
            SetHightlight(Chef_btnGereed);
            Chef_lblActivePanel.Text = "Gereed";
            HideAllPanels();
            Chef_pnlGereed.Show();

            // Get all orders that are ready/served
            List<Order> orders = order_service
                .GetAllOrders()
                .Where(order => order.State == OrderState.Done || order.State == OrderState.Served)
                .ToList();

            Chef_pnlOrders.Controls.Clear();

            int y = 0;

            for (int i = 0; i < orders.Count; i++)
            {
                Order order = orders[i];
                Panel pnl_order = new Panel();
                ListView lv_order = new ListView();

                pnl_order.BackColor = Color.FromArgb(250, 253, 255);
                pnl_order.BorderStyle = BorderStyle.FixedSingle;
                pnl_order.Controls.Add(lv_order);
                pnl_order.Location = new Point(0, y);
                pnl_order.Name = $"Chef_pnlOrder_{i}";
                pnl_order.Size = new Size(666, 483);

                lv_order.BackColor = Color.FromArgb(250, 253, 255);
                lv_order.BorderStyle = BorderStyle.None;
                lv_order.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
                lv_order.HideSelection = false;
                lv_order.Location = new Point(0, 0);
                lv_order.Margin = new Padding(0);
                lv_order.Name = $"Chef_lvOrder_{i}";
                lv_order.Size = new Size(664, 481);
                lv_order.View = View.List;

                foreach (Dish dish in order.Dishes)
                    lv_order.Items.Add(dish.Name);

                Chef_pnlOrders.Controls.Add(pnl_order);

                y += 503;
            }
        }

        private void Chef_btnVoorraad_Click(object sender, EventArgs e)
        {
            SetHightlight(Chef_btnVoorraad);
            Chef_lblActivePanel.Text = "Voorraad";
            HideAllPanels();
            Chef_pnlVoorraad.Show();
            Chef_lvVoorraad.Items.Clear();

            List<Dish> dishes = dish_service.GetAllDishes();

            foreach (Dish dish in dishes)
            {
                ListViewItem li = new ListViewItem(dish.Name);

                li.SubItems.Add(dish.Stock.ToString());
                li.SubItems.Add(dish.Price.ToString("€ 0.00"));

                Chef_lvVoorraad.Items.Add(li);
            }
        }

        private void Chef_btnFirstKlaar_Click(object sender, EventArgs e)
        {
            Order order = orders[0];

            order.TimeFinished = DateTime.Now;
            order.State = OrderState.Done;
            order_service.ModifyOrder(order);
        }

        private void Chef_lvVoorraad_ColumnClicck(object sender, ColumnClickEventArgs e)
        {
            SortListView(e, Chef_lvVoorraad);
        }

        private void SortListView(ColumnClickEventArgs e, ListView lv)
        {
            // Determine if clicked column is already the column that is being sorted.
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                if (lvwColumnSorter.Order == SortOrder.Ascending)
                    lvwColumnSorter.Order = SortOrder.Descending;
                else
                    lvwColumnSorter.Order = SortOrder.Ascending;
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }

            lv.Sort();
        }
    }
}
