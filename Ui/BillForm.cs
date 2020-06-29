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
    public partial class BillForm : Form
    {
        private Bill_Service bill_service = new Bill_Service();
        private Table_Service table_service = new Table_Service();
        private Employee employee;
        private ColumnHeader columnheader;
        private Table table;
        private Bill bill;
        private int tableId = 1;
        private double totalprice;
        private double totalItemPrice;
        private string items;
        private double fooi;
        private double btw = 0.21;

        public BillForm(Table table, Employee employee)
        {
            InitializeComponent();
            tableId = table.Number;
            Bill_lblTableNumber.Text = "Tafel nummer: " + tableId.ToString();
            Bill_btnRekeningOverzicht_Click(null, null);
        }

        private void Bill_btnRekeningOverzicht_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            Bill_btnBillOverview.Show();
            Bill_btnFooi.Show();
            Bill_btnKiesBetaalmethode.Show();
            Bill_lblBtw.Show();
            Bill_lblTotaalBedrag.Show();
            Bill_lblTotalPrice.Show();
            Bill_lblBtwLinks.Show();
            Bill_lvBillOverview.Show();
            Bill_lblTotalPrice.Show();
            Bill_lblBtw.Show();
            Bill_lblBtwLinks.Show();
            Bill_btnFooi.Show();
            Bill_btnKiesBetaalmethode.Show();

            Bill_lvBillOverview.Clear();
            totalprice = 0;
            totalItemPrice = 0;

            Bill bills = bill_service.GetBillByTableId(tableId);

            if (bills.Payed == false)
            {

                for (int i = 0; i < bills.Orders.Count; i++)
                {
                    foreach (Dish dish in bills.Orders[i].Dishes)
                    {
                        items = dish.Name;

                        ListViewItem li = new ListViewItem(items);
                        li.SubItems.Add(dish.Price.ToString("€0.00"));
                        li.SubItems.Add(dish.Aantal.ToString());

                        totalItemPrice = dish.Price * dish.Aantal;
                        li.SubItems.Add(totalItemPrice.ToString("€0.00"));
                        totalprice = totalprice + totalItemPrice;

                        Bill_lvBillOverview.Items.Add(li);
                    }

                    foreach (Drink drink in bills.Orders[i].Drinks)
                    {
                        items = drink.Name;

                        ListViewItem li = new ListViewItem(items);
                        li.SubItems.Add(drink.Price.ToString("€0.00"));
                        li.SubItems.Add(drink.Aantal.ToString());

                        totalItemPrice = drink.Price * drink.Aantal;
                        li.SubItems.Add(totalItemPrice.ToString("€0.00"));
                        totalprice = totalprice + totalItemPrice;

                        Bill_lvBillOverview.Items.Add(li);
                    }
                }
                columnheader = new ColumnHeader();
                columnheader.Text = "Item";
                columnheader.Width = 200;
                Bill_lvBillOverview.Columns.Add(columnheader);

                columnheader = new ColumnHeader();
                columnheader.Text = "Enkel";
                columnheader.Width = 70;
                Bill_lvBillOverview.Columns.Add(columnheader);

                columnheader = new ColumnHeader();
                columnheader.Text = "Aantal";
                columnheader.Width = 50;
                Bill_lvBillOverview.Columns.Add(columnheader);

                columnheader = new ColumnHeader();
                columnheader.Text = "Totaalprijs";
                columnheader.Width = 70;
                Bill_lvBillOverview.Columns.Add(columnheader);

                Bill_lblBtw.Text = (totalprice * btw).ToString("€0.00");

                Bill_lblTotalPrice.Text = totalprice.ToString("€0.00");
                
            }
            else
            {
                Bill_lblBetaald.Show();
            }
        }

        private void Bill_btnKiesBetaalmethode_Click_1(object sender, EventArgs e)
        {
            Bill_pnlFooi.Hide();
            Bill_pnlBetaalMethode.Show();
            Bill_rbCash.Show();
            Bill_rbMastercard.Show();
            Bill_rbPaypal.Show();
            Bill_rbVisa.Show();
            Bill_btnPay.Show();
        }

        private void HideAllPanels()
        {
            Bill_lblBtw.Hide();
            Bill_btnBillOverview.Hide();
            Bill_btnKiesBetaalmethode.Hide();
            Bill_btnFooi.Hide();
            Bill_pnlBetaalMethode.Hide();
            Bill_rbCash.Hide();
            Bill_rbMastercard.Hide();
            Bill_rbPaypal.Hide();
            Bill_rbVisa.Hide();
            Bill_btnPay.Hide();
            Bill_pnlFooi.Hide();
            Bill_lblTotalPrice.Hide();
            Bill_lblBetaald.Hide();
            Bill_lblBtwLinks.Hide();
            Bill_lblTotaalBedrag.Hide();
        }

        private void Bill_btnPay_Click(object sender, EventArgs e)
        {
            bill = bill_service.GetBillByTableId(tableId);
            bill.Payed = true;
            bill_service.ModifyBill(bill);

            table = table_service.GetWithId(tableId);
            table.Occupied = false;
            table_service.ModifyTable(table);

            MessageBox.Show("De bestelling is gereed gemeld", "Gereed gemeld!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Hide();
            OrderForm form = new OrderForm(employee);
            form.ShowDialog(Owner);
            Close();
        }

        private void Bill_btnBetaalmethodeX_Click(object sender, EventArgs e)
        {
            Bill_pnlBetaalMethode.Hide();
        }

        private void Bill_btnFooiX_Click(object sender, EventArgs e)
        {
            Bill_pnlFooi.Hide();
        }

        private void Bill_btnFooi_Click(object sender, EventArgs e)
        {
            Bill_pnlBetaalMethode.Hide();
            Bill_pnlFooi.Show();
        }

        private void Bill_btnPasAan_Click(object sender, EventArgs e)
        {
            if (Bill_txbAanvullenTot.Text.Length == 0)
            {
                totalprice += fooi;
            }
            else
            {
                if (double.Parse(Bill_txbAanvullenTot.Text) <= totalprice)
                {
                    return;
                }
                totalprice = double.Parse(Bill_txbAanvullenTot.Text);
            }

            Bill_lblTotalPrice.Text = totalprice.ToString("€0.00");
        }

        private void Bill_btnFooiPlus5_Click(object sender, EventArgs e)
        {
            fooi = 5;
        }

        private void Bill_btnFooiPlus10_Click(object sender, EventArgs e)
        {
            fooi = 10;
        }

        private void Bill_btnFooiPlus20_Click(object sender, EventArgs e)
        {
            fooi = 20;
        }

        private void Bill_btnTerug_Click(object sender, EventArgs e)
        {
            Hide();
            OrderForm form = new OrderForm(employee);
            form.ShowDialog(Owner);
            Close();
        }
    }
}
