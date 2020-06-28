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
        private Timer timer = new Timer();

        public BarForm()
        {
            InitializeComponent();
            InitializeSorting();
            InitializeTimer();
            FormClosed += OnClosed;
            Bar_btnOverzicht_Click_1(null, null);
        }

        private void InitializeSorting()
        {
            Bar_lvVoorraad.View = View.Details;
            Bar_lvVoorraad.ListViewItemSorter = lvwColumnSorter;
        }

        private void InitializeTimer()
        {
            timer.Interval = 2000;
            timer.Tick += OnTimedEvent;
            timer.Stop();
        }

    private void SetHightlight(Button btn)
        {
            Bar_btnOverzicht.BackColor = Color.FromArgb(0, 165, 229);
            Bar_btnVoorraad.BackColor = Color.FromArgb(0, 165, 229);
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
        }

        private void Bar_btnOverzicht_Click_1(object sender, EventArgs e)
        {
            SetHightlight(Bar_btnOverzicht);
            Bar_lblActivePanel1.Text = "Overzicht";
            HideAllPanels();
            Bar_pnlOverzicht.Show();
            OnTimedEvent(null, null);
            timer.Start();
        }

        // Code taken from: https://stackoverflow.com/questions/10775367/cross-thread-operation-not-valid-control-textbox1-accessed-from-a-thread-othe
        // to modify the ui from a different thread to avoid blocking on database access.
        delegate void RefreshOrdersCallback();

        private void RefreshOrders()
        {
            if (Bar_pnlOverzicht.InvokeRequired)
            {
                RefreshOrdersCallback d = new RefreshOrdersCallback(RefreshOrders);

                Invoke(d, new object[] { });
            }
            else
            {
                Bar_lblGeenBestellingen.Hide();
                Bar_pnlOpmerkingen.Hide();
                Bar_pnlFirstOrder.Hide();
                Bar_pnlSecondOrder.Hide();
                Bar_pnlThirdOrder.Hide();
                Bar_pnlFourthOrder.Hide();
                Bar_pnlOverflow.Hide();

                switch (orders.Count)
                {
                    case 0:
                        Bar_lblGeenBestellingen.Show();
                        break;
                    case 1:
                        FillOrder(orders[0], Bar_pnlFirstOrder, Bar_lvFirst, Bar_lblTafelFirst, Bar_lblBesteldOpFirst);
                        Bar_lvFirst.Items[0].Selected = true;
                        Bar_pnlOpmerkingen.Show();
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
        }

        void OnTimedEvent(Object source, EventArgs e)
        {
            // every 20 seconds the "Overzicht" panel will be refreshed
            new System.Threading.Thread(() =>
            {
                // Get all unprocessed orders
                orders = order_service
                        .GetAllOrders()
                        .Where(order => order.Drinks.Any(drink => !drink.Finished))
                        .Where(order => order.Drinks.Count > 0)
                        .ToList();

                RefreshOrders();
            }).Start();
        }

        private void FillOrder(Order order, Panel panel, ListView lv, Label table, Label ordered)
        {
            lv.Items.Clear();
            table.Text = $"Tafel: {order.TableId}";
            ordered.Text = $"Besteld op: {order.TimeOrdering.ToString("hh:mm")}";

            foreach (Drink drink in order.Drinks)
                if (!drink.Finished)
                {
                    ListViewItem li = new ListViewItem(drink.Name);

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

            List<Drink> drinks = drink_service.GetAllDrinks();

            foreach (Drink drink in drinks)
            {
                ListViewItem li = new ListViewItem(drink.Name);

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

        private void Bar_lvVoorraad_ColumnClick(object sender, ColumnClickEventArgs e)
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

            foreach (int idx in Bar_lvFirst.SelectedIndices)
            {
                Drink drink = order.Drinks[idx];

                drink_service.ModifyFinished(order, drink, true);
            }

            order.TimeFinished = DateTime.Now;
            order_service.ModifyOrder(order);
            OnTimedEvent(null, null);

            MessageBox.Show("De bestelling is gereed gemeld", "Gereed gemeld!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Bar_order_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView lv = (ListView)sender;

            if (lv.SelectedItems.Count != 0)
            {
                Dish dish = (Dish)lv.SelectedItems[0].Tag;

                if (dish.Comment.Length != 0)
                    Bar_lblOpmerkingenContent.Text = dish.Comment;
                else
                    Bar_lblOpmerkingenContent.Text = "Geen opmerkingen";
            }
        }

        private void OnClosed(object sender, FormClosedEventArgs e)
        {
            timer.Stop();
            timer.Dispose();
            timer = null;
        }
    }
}
