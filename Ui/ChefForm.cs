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
        private Timer timer = new Timer();

        public ChefForm()
        {
            InitializeComponent();
            InitializeSorting();
            InitializeTimer();
            FormClosed += OnClosed;
            Chef_btnOverzicht_Click(null, null);
        }

        private void InitializeSorting()
        {
            Chef_lvVoorraad.View = View.Details;
            Chef_lvVoorraad.ListViewItemSorter = lvwColumnSorter;
        }

        private void InitializeTimer()
        {
            timer.Interval = 20000;
            timer.Tick += OnTimedEvent;
            timer.Stop();
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
            timer.Stop();
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
            OnTimedEvent(null, null);
            timer.Start();
        }

        // Code taken from: https://stackoverflow.com/questions/10775367/cross-thread-operation-not-valid-control-textbox1-accessed-from-a-thread-othe
        // to modify the ui from a different thread to avoid blocking on database access.
        delegate void RefreshOrdersCallback();

        private void RefreshOrders()
        {
            if (Chef_pnlOverzicht.InvokeRequired)
            {
                RefreshOrdersCallback d = new RefreshOrdersCallback(RefreshOrders);

                Invoke(d, new object[] { });
            } else
            {
                Chef_lblGeenBestellingen.Hide();
                Chef_pnlOpmerkingen.Hide();
                Chef_pnlFirstOrder.Hide();
                Chef_pnlSecondOrder.Hide();
                Chef_pnlThirdOrder.Hide();
                Chef_pnlFourthOrder.Hide();
                Chef_pnlOverflow.Hide();

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
        }

        void OnTimedEvent(Object source, EventArgs e)
        {
            // every 20 seconds the "Overzicht" panel will be refreshed
            new System.Threading.Thread(() =>
            {
                // Get all unprocessed orders
                orders = order_service
                        .GetAllOrders()
                        .Where(order => order.State == OrderState.None || order.State == OrderState.Started)
                        .Where(order => order.Dishes.Count > 0)
                        .ToList();

                RefreshOrders();
            }).Start();
        }

        private void FillFirstOrder(Order order)
        {
            Chef_lblOpmerkingenContent.Text = order.Comment;
            Chef_pnlOpmerkingen.Show();
            Chef_lvFirst.Clear();
            Chef_lblTafelFirst.Text = $"Tafel: {order.TableId}";
            Chef_lblBesteldOpFirst.Text = $"Besteld op: {order.TimeOrdering.ToString("hh:mm")}";

            foreach (Dish dish in order.Dishes)
                Chef_lvFirst.Items.Add(new ListViewItem(dish.Name));

            Chef_pnlFirstOrder.Show();
        }

        private void FillSecondOrder(Order order)
        {
            Chef_lvSecond.Clear();
            Chef_lblTafelSecond.Text = $"Tafel: {order.TableId}";
            Chef_lblBesteldOpSecond.Text = $"Besteld op: {order.TimeOrdering.ToString("hh:mm")}";

            foreach (Dish dish in order.Dishes)
                Chef_lvSecond.Items.Add(new ListViewItem(dish.Name));

            Chef_pnlSecondOrder.Show();
        }

        private void FillThirdOrder(Order order)
        {
            Chef_lvThird.Clear();
            Chef_lblTafelThird.Text = $"Tafel: {order.TableId}";
            Chef_lblBesteldOpThird.Text = $"Besteld op: {order.TimeOrdering.ToString("hh:mm")}";

            foreach (Dish dish in order.Dishes)
                Chef_lvThird.Items.Add(new ListViewItem(dish.Name));

            Chef_pnlThirdOrder.Show();
        }

        private void FillFourthOrder(Order order)
        {
            Chef_lvFourth.Clear();
            Chef_lblTafelFourth.Text = $"Tafel: {order.TableId}";
            Chef_lblBesteldOpFourth.Text = $"Besteld op: {order.TimeOrdering.ToString("hh:mm")}";

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
            Refresh();

            // Get all orders that are ready/served
            List<Order> orders = order_service
                .GetAllOrders()
                .Where(order => order.State == OrderState.Done || order.State == OrderState.Served)
                .ToList();

            HideAllPanels();
            Chef_pnlGereed.Show();
            Chef_pnlOrders.Controls.Clear();

            int y = 0;

            // Create a new panel and list view for each order and add them to Chef_pnlOrders
            for (int i = 0; i < orders.Count; i++)
            {
                Order order = orders[i];
                Panel pnl_order = CreateOrderPanel(i, y);
                ListView lv_order = CreateOrderListView(i);

                pnl_order.Controls.Add(lv_order);

                foreach (Dish dish in order.Dishes)
                {
                    ListViewItem li = new ListViewItem(dish.Name);

                    li.Tag = order;
                    lv_order.Items.Add(li);
                }

                lv_order.SelectedIndexChanged += ListViewGereed_IndexChanged;

                Chef_pnlOrders.Controls.Add(pnl_order);

                y += 503;
            }
        }

        // Create a new panel for the "Gereed" tab.
        private Panel CreateOrderPanel(int i, int y)
        {
            return new Panel
            {
                BackColor = Color.FromArgb(250, 253, 255),
                BorderStyle = BorderStyle.FixedSingle,
                Location = new Point(0, y),
                Name = $"Chef_pnlOrder_{i}",
                Size = new Size(456, 483)
            };
        }

        // Create a new list view for the "Gereed" tab.
        private ListView CreateOrderListView(int i)
        {
            return new ListView()
            {
                BackColor = Color.FromArgb(250, 253, 255),
                BorderStyle = BorderStyle.None,
                Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0),
                HideSelection = false,
                Location = new Point(0, 0),
                Margin = new Padding(0),
                Name = $"Chef_lvOrder_{i}",
                Size = new Size(454, 481),
                View = View.List,
            };
        }

        private void ListViewGereed_IndexChanged(object sender, EventArgs e)
        {
            ListView lv_order = (ListView)sender;

            if (lv_order.SelectedItems.Count > 0)
            {
                ListViewItem li = lv_order.SelectedItems[0];
                Order order = (Order)li.Tag;

                Chef_lblOpmerkingenContent2.Text = order.Comment;
            }
        }

        private void Chef_btnVoorraad_Click(object sender, EventArgs e)
        {
            SetHightlight(Chef_btnVoorraad);
            Chef_lblActivePanel.Text = "Voorraad";
            Refresh();

            List<Dish> dishes = dish_service.GetAllDishes();

            HideAllPanels();
            Chef_pnlVoorraad.Show();
            Chef_lvVoorraad.Items.Clear();

            foreach (Dish dish in dishes)
            {
                ListViewItem li = new ListViewItem(dish.Name);

                li.SubItems.Add(dish.Stock.ToString());
                li.SubItems.Add(dish.Price.ToString("€ 0.00"));

                Chef_lvVoorraad.Items.Add(li);
            }
        }

        // Only the first order can be marked as ready.
        private void Chef_btnFirstKlaar_Click(object sender, EventArgs e)
        {
            Order order = orders[0];

            order.TimeFinished = DateTime.Now;
            order.State = OrderState.Done;
            order_service.ModifyOrder(order);
            OnTimedEvent(null, null);

            MessageBox.Show("De bestelling is gereed gemeld", "Gereed gemeld!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void OnClosed(object sender, FormClosedEventArgs e)
        {
            timer.Stop();
            timer.Dispose();
            timer = null;
        }

        private void Chef_btnUitloggen_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
