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
            RefreshOrders();
        }

        private void InitializeSorting()
        {
            Chef_lvVoorraad.View = View.Details;
            Chef_lvVoorraad.ListViewItemSorter = lvwColumnSorter;
        }

        // Highlight a button
        private void SetHightlight(Button btn)
        {
            Chef_btnOverzicht.BackColor = Color.FromArgb(0, 146, 204);
            Chef_btnGereed.BackColor = Color.FromArgb(0, 146, 204);
            Chef_btnVoorraad.BackColor = Color.FromArgb(0, 146, 204);
            btn.BackColor = Color.FromArgb(0, 184, 255);
        }

        private void HideAllPanels()
        {
            Chef_pnlOverzicht.Hide();
            Chef_pnlGereed.Hide();
            Chef_pnlVoorraad.Hide();
        }

        private void Chef_btnOverzicht_Click(object sender, EventArgs e)
        {
            SetHightlight(Chef_btnOverzicht);
            Chef_lblActivePanel.Text = "Overzicht";
            HideAllPanels();
            Chef_pnlOverzicht.Show();
            RefreshOrders();
        }

        private void Chef_btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshOrders();
        }

        private void RefreshOrders()
        {
            Chef_lblGeenBestellingen.Hide();
            Chef_pnlOpmerkingen.Hide();
            Chef_pnlFirstOrder.Hide();
            Chef_pnlSecondOrder.Hide();
            Chef_pnlThirdOrder.Hide();
            Chef_pnlFourthOrder.Hide();
            Chef_pnlOverflow.Hide();

            // Get all unprocessed orders
            orders = order_service
                .GetAllOrders()
                .Where(order => order.Dishes.Any(dish => !dish.Finished))
                .ToList();

            switch (orders.Count)
            {
                case 0:
                    Chef_lblGeenBestellingen.Show();
                    break;
                case 1:
                    FillOrder(orders[0], Chef_pnlFirstOrder, Chef_lvFirst, Chef_lblTafelFirst, Chef_lblBesteldOpFirst);
                    Chef_lvFirst.Items[0].Selected = true;
                    Chef_pnlOpmerkingen.Show();
                    break;
                case 2:
                    FillOrder(orders[1], Chef_pnlSecondOrder, Chef_lvSecond, Chef_lblTafelSecond, Chef_lblBesteldOpSecond);
                    goto case 1;
                case 3:
                    FillOrder(orders[2], Chef_pnlThirdOrder, Chef_lvThird, Chef_lblTafelThird, Chef_lblBesteldOpThird);
                    goto case 2;
                case 4:
                    FillOrder(orders[3], Chef_pnlFourthOrder, Chef_lvFourth, Chef_lblTafelFourth, Chef_lblBesteldOpFourth);
                    goto case 3;
                default:
                    ShowOverflow(orders.Count - 4);
                    goto case 4;
            }
        }

        private void FillOrder(Order order, Panel panel, ListView lv, Label table, Label ordered)
        {
            lv.Items.Clear();
            table.Text = $"Tafel: {order.TableId}";
            ordered.Text = $"Besteld op: {order.TimeOrdering.ToShortTimeString()}";

            foreach (Dish dish in order.Dishes)
                if (!dish.Finished)
                {
                    ListViewItem li = new ListViewItem($"{dish.Aantal}x {dish.Name}");

                    li.Tag = dish;
                    lv.Items.Add(li);
                }

            panel.Show();
        }

        private void ShowOverflow(int count)
        {
            Chef_pnlOverflow.Show();
            Chef_lblOverflow.Text = string.Format("+ {0}", count);
        }

        // Only the first order can be marked as ready.
        private void Chef_btnFirstKlaar_Click(object sender, EventArgs e)
        {
            Order order = orders[0];
            List<Dish> dishes = order.Dishes.Where(dish => !dish.Finished).ToList();

            foreach (int idx in Chef_lvFirst.SelectedIndices)
            {
                Dish dish = dishes[idx];

                dish_service.ModifyFinished(order, dish, true);
            }

            order.TimeFinished = DateTime.Now;
            order_service.ModifyOrder(order);
            MessageBox.Show("De bestelling is gereed gemeld", "Gereed gemeld!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RefreshOrders();
        }

        private void Chef_order_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView lv = (ListView)sender;

            if (lv.SelectedItems.Count != 0)
            {
                Dish dish = (Dish)lv.SelectedItems[0].Tag;

                if (dish.Comment.Length != 0)
                    Chef_lblOpmerkingenContent.Text = dish.Comment;
                else
                    Chef_lblOpmerkingenContent.Text = "Geen opmerkingen";
            }
        }

        private void Chef_btnGereed_Click(object sender, EventArgs e)
        {
            SetHightlight(Chef_btnGereed);
            Chef_lblActivePanel.Text = "Gereed";
            Refresh();
            HideAllPanels();
            Chef_pnlGereed.Show();
            Chef_lvGereed.Items.Clear();

            List<Order> orders = order_service
                .GetAllOrders()
                .Where(order => order.Dishes.Any(dish => dish.Finished))
                .ToList();

            foreach (Order order in orders)
            {
                ListViewItem li = new ListViewItem(order.TableId.ToString());

                li.SubItems.Add(order.TimeFinished.ToShortTimeString());
                li.Tag = order;

                Chef_lvGereed.Items.Add(li);
            }

            if (orders.Count != 0)
                Chef_lvGereed.Items[0].Selected = true;
        }

        private void Chef_lvGereed_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Chef_lvGereed.SelectedItems.Count != 0)
            {
                Order order = (Order)Chef_lvGereed.SelectedItems[0].Tag;

                Chef_lvOrderGereed.Items.Clear();

                foreach (Dish dish in order.Dishes)
                    if (dish.Finished)
                    {
                        ListViewItem li = new ListViewItem($"{dish.Aantal}x {dish.Name}");

                        li.Tag = dish;
                        Chef_lvOrderGereed.Items.Add(li);
                    }

                if (order.Dishes.Count != 0)
                    Chef_lvOrderGereed.Items[0].Selected = true;
            }
        }

        private void Chef_lvOrderGereed_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Chef_lvOrderGereed.SelectedItems.Count != 0)
            {
                Dish dish = (Dish)Chef_lvOrderGereed.SelectedItems[0].Tag;

                if (dish.Comment.Length != 0)
                    Chef_lblOpmerkingenContentGereed.Text = dish.Comment;
                else
                    Chef_lblOpmerkingenContentGereed.Text = "Geen opmerkingen";
            }
        }

        private void Chef_btnTerugzetten_Click(object sender, EventArgs e)
        {
            Order order = (Order)Chef_lvGereed.SelectedItems[0].Tag;
            List<Dish> dishes = order.Dishes.Where(dish => dish.Finished).ToList();

            foreach (int idx in Chef_lvOrderGereed.SelectedIndices)
            {
                Dish dish = dishes[idx];

                dish_service.ModifyFinished(order, dish, false);
            }

            MessageBox.Show("De bestelling is terug gezet", "Bestelling terug gezet!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Chef_btnGereed_Click(null, null);
        }

        private void Chef_btnVoorraad_Click(object sender, EventArgs e)
        {
            SetHightlight(Chef_btnVoorraad);
            Chef_lblActivePanel.Text = "Voorraad";
            HideAllPanels();
            Chef_pnlVoorraad.Show();
            Refresh();

            Chef_btnLunch_Click(null, null);
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

        private void Chef_btnLunch_Click(object sender, EventArgs e)
        {
            Chef_btnLunch.BackColor = Color.FromArgb(0, 184, 255);
            Chef_btnDiner.BackColor = Color.FromArgb(0, 146, 204);

            List<Dish> dishes = dish_service.GetAllLunch();

            FillStock(dishes);
        }

        private void Chef_btnDiner_Click(object sender, EventArgs e)
        {
            Chef_btnLunch.BackColor = Color.FromArgb(0, 146, 204);
            Chef_btnDiner.BackColor = Color.FromArgb(0, 184, 255);

            List<Dish> dishes = dish_service.GetAllDinner();

            FillStock(dishes);
        }

        private void FillStock(List<Dish> dishes)
        {
            Chef_lvVoorraad.Items.Clear();

            foreach (Dish dish in dishes)
            {
                ListViewItem li = new ListViewItem(dish.Name);

                li.SubItems.Add(dish.Stock.ToString());
                li.SubItems.Add(dish.Price.ToString("€ 0.00"));

                if (dish.Stock <= 0)
                    li.ForeColor = Color.FromArgb(255, 0, 0);
                else if (dish.Stock <= 10)
                    li.ForeColor = Color.FromArgb(255, 155, 0);
                else
                    li.ForeColor = Color.FromArgb(0, 200, 0);

                Chef_lvVoorraad.Items.Add(li);
            }
        }

        private void Chef_btnUitloggen_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
