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
    public partial class BarForm : Form
    {
        private ListViewColumnSorter lvwColumnSorter = new ListViewColumnSorter();
        private Order_Service order_service = new Order_Service();
        private Drink_Service drink_service = new Drink_Service();
        private ColumnHeader columnheader;
        private List<Order> orders;

        public BarForm()
        {
            InitializeComponent();
            InitializeSorting();
            RefreshOrders();
        }

        private void InitializeSorting()
        {
            Bar_lvVoorraad.View = View.Details;
            Bar_lvVoorraad.ListViewItemSorter = lvwColumnSorter;
        }

        private void SetHightlight(Button btn)
        {
            Bar_btnOverzicht.BackColor = Color.FromArgb(0, 146, 204);
            Bar_btnVoorraad.BackColor = Color.FromArgb(0, 146, 204);
            btn.BackColor = Color.FromArgb(0, 184, 255);
        }

        private void HideAllPanels()
        {
            Bar_pnlOverzicht.Hide();
            Bar_lblGeenBestellingen.Hide();
            Bar_pnlOpmerkingen.Hide();
            Bar_pnlFirstOrder.Hide();
            Bar_pnlSecondOrder.Hide();
            Bar_pnlThirdOrder.Hide();
            Bar_pnlFourthOrder.Hide();
            Bar_pnlOverflow.Hide();
            Bar_pnlVoorraad.Hide();
            Bar_lblOpmerkingenContent.Hide();
            Bar_btnRefresh.Hide();
        }

        private void Bar_btnOverzicht_Click_1(object sender, EventArgs e)
        {
            SetHightlight(Bar_btnOverzicht);
            Bar_lblActivePanel1.Text = "Overzicht";
            HideAllPanels();
            Bar_pnlOverzicht.Show();
            Bar_btnRefresh.Show();
            RefreshOrders();
        }

        private void RefreshOrders()
        {
            Bar_lblGeenBestellingen.Hide();
            Bar_lblOpmerkingenContent.Hide();
            Bar_pnlOpmerkingen.Hide();
            Bar_pnlFirstOrder.Hide();
            Bar_pnlSecondOrder.Hide();
            Bar_pnlThirdOrder.Hide();
            Bar_pnlFourthOrder.Hide();
            Bar_pnlOverflow.Hide();

            orders = order_service
                .GetAllOrders()
                .Where(order => order.Drinks.Any(drink => !drink.Finished))
                .ToList();

            switch (orders.Count)
            {
                case 0:
                    Bar_lblGeenBestellingen.Show();
                    break;
                case 1:
                    FillOrder(orders[0], Bar_pnlFirstOrder, Bar_lvFirst, Bar_lblTafelFirst, Bar_lblBesteldOpFirst);
                    Bar_lvFirst.Items[0].Selected = true;
                    Bar_pnlOpmerkingen.Show();
                    Bar_lblOpmerkingenContent.Show();
                    break;
                case 2:
                    FillOrder(orders[1], Bar_pnlSecondOrder, Bar_lvSecond, Bar_lblTafelSecond, Bar_lblBesteldOpSecond);
                    goto case 1;
                case 3:
                    FillOrder(orders[2], Bar_pnlThirdOrder, Bar_lvThird, Bar_lblTafelThird, Bar_lblBesteldOpThird);
                    goto case 2;
                case 4:
                    FillOrder(orders[3], Bar_pnlFourthOrder, Bar_lvFourth, Bar_lblTafelFourth, Bar_lblBesteldOpFourth);
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
            ordered.Text = $"Besteld op: {order.TimeOrdering.ToString("hh:mm")}";

            foreach (Drink drink in order.Drinks)
                if (!drink.Finished)
                {
                    Console.WriteLine("{0}, {1}", order.Id, drink.Id);
                    ListViewItem li = new ListViewItem($"{drink.Aantal}x {drink.Name}");

                    li.Tag = drink;
                    lv.Items.Add(li);
                }

            panel.Show();
        }

        private void ShowOverflow(int count)
        {
            Bar_pnlOverflow.Show();
            Bar_lblOverflow.Text = string.Format("+ {0}", count);
        }

        private void Bar_btnVoorraad_Click(object sender, EventArgs e)
        {
            SetHightlight(Bar_btnVoorraad);
            Bar_lblActivePanel1.Text = "Voorraad";
            HideAllPanels();
            Bar_lvVoorraad.Clear();
            Bar_pnlVoorraad.Show();
            Bar_lblOpmerkingenContent.Hide();

            List<Drink> drinks = drink_service.GetAllDrinks();

            foreach (Drink drink in drinks)
            {
                ListViewItem li = new ListViewItem(drink.Name);

                if (drink.Stock <= 0) {
                    li.ForeColor = Color.FromArgb(255, 0, 0);
                }
                else if (drink.Stock <= 10)
                {
                    li.ForeColor = Color.FromArgb(255, 155, 0);
                }
                else
                {
                    li.ForeColor = Color.FromArgb(0, 200, 0);
                }

                li.BackColor = Color.FromArgb(229, 247, 255);

                li.SubItems.Add(drink.Stock.ToString());
                li.SubItems.Add(drink.Price.ToString("€ 0.00"));

                Bar_lvVoorraad.Items.Add(li);
            }

            columnheader = new ColumnHeader();
            columnheader.Text = "Drankje";
            columnheader.Width = 450;
            Bar_lvVoorraad.Columns.Add(columnheader);

            columnheader = new ColumnHeader();
            columnheader.Text = "Voorraad";
            columnheader.Width = 100;
            Bar_lvVoorraad.Columns.Add(columnheader);

            columnheader = new ColumnHeader();
            columnheader.Text = "Prijs";
            columnheader.Width = 100;
            Bar_lvVoorraad.Columns.Add(columnheader);

        }

        private void Bar_lvVoorraad_ColumnClickk(object sender, ColumnClickEventArgs e)
        {
            SortListView(e, Bar_lvVoorraad);
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

        private void Bar_btnFirstKlaar_Click_1(object sender, EventArgs e)
        {
            Order order = orders[0];
            List<Drink> drinks = order.Drinks.Where(drink => !drink.Finished).ToList();

            foreach (int idx in Bar_lvFirst.SelectedIndices)
            {
                Drink drink = drinks[idx];

                drink_service.ModifyFinished(order, drink, true);
            }

            order.TimeFinished = DateTime.Now;
            order_service.ModifyOrder(order);

            MessageBox.Show("De bestelling is gereed gemeld", "Gereed gemeld!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            RefreshOrders();
        }

        private void Bar_order_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView lv = (ListView)sender;

            if (lv.SelectedItems.Count != 0)
            {
                Drink drink = (Drink)lv.SelectedItems[0].Tag;

                if (drink.Comment.Length != 0)
                    Bar_lblOpmerkingenContent.Text = drink.Comment;
                else
                    Bar_lblOpmerkingenContent.Text = "Geen opmerkingen";
            }
        }

        private void Bar_btnUitloggen_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Bar_btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshOrders();
        }
    }
}
