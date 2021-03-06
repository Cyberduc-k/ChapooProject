﻿using System;
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
        private List<Order> orders;

        public BarForm()
        {
            InitializeComponent();
            InitializeSorting();
            Bar_btnOverzicht_Click_1(null, null);
        }

        private void InitializeSorting()
        {
            Bar_lvVoorraad.View = View.Details;
            Bar_lvVoorraad.ListViewItemSorter = lvwColumnSorter;
        }

        // Highlight a button
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
            Bar_lblActivePanel.Text = "Overzicht";
            HideAllPanels();
            Bar_pnlOverzicht.Show();

            // Get all unprocessed orders
            orders = order_service
                .GetAllOrders()
                .Where(order => order.State == OrderState.None || order.State == OrderState.Started)
                .ToList();

            switch (orders.Count)
            {
                case 0:
                    Bar_lblGeenBestellingen.Show();
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
            Bar_lblOpmerkingenContent.Text = order.Comment;
            Bar_pnlOpmerkingen.Show();
            Bar_lvFirstOrder.Clear();
            Bar_lblTafelFirst.Text = $"Tafel: {order.TableId}";

            foreach (Drink drink in order.Drinks)
                Bar_lvFirstOrder.Items.Add(new ListViewItem(drink.Name));

            Bar_pnlFirstOrder.Show();
        }

        private void FillSecondOrder(Order order)
        {
            Bar_lvSecond.Clear();

            foreach (Drink drink in order.Drinks)
                Bar_lvSecond.Items.Add(new ListViewItem(drink.Name));

            Bar_pnlSecondOrder.Show();
        }

        private void FillThirdOrder(Order order)
        {
            Bar_lvThird.Clear();

            foreach (Drink drink in order.Drinks)
                Bar_lvThird.Items.Add(new ListViewItem(drink.Name));

            Bar_pnlThirdOrder.Show();
        }

        private void FillFourthOrder(Order order)
        {
            Bar_lvFourth.Clear();

            foreach (Drink drink in order.Drinks)
                Bar_lvFourth.Items.Add(new ListViewItem(drink.Name));

            Bar_pnlFourthOrder.Show();
        }

        private void ShowOverflow(int count)
        {
            Bar_pnlOverflow.Show();
            Bar_lblOverflow.Text = string.Format("+ {0}", count);
        }

        private void Bar_btnVoorraad_Click(object sender, EventArgs e)
        {
            SetHightlight(Bar_btnVoorraad);
            Bar_lblActivePanel.Text = "Voorraad";
            HideAllPanels();
            Bar_pnlVoorraad.Show();
            Bar_lvVoorraad.Items.Clear();

            List<Drink> drinks = drink_service.GetAllDrinks();

            foreach (Drink drink in drinks)
            {
                ListViewItem li = new ListViewItem(drink.Name);

                li.SubItems.Add(drink.Stock.ToString());
                li.SubItems.Add(drink.Price.ToString("€ 0.00"));

                Bar_lvVoorraad.Items.Add(li);
            }
        }

        private void Bar_btnFirstKlaar_Click_1(object sender, EventArgs e)
        {
            Order order = orders[0];

            order.TimeFinished = DateTime.Now;
            order.State = OrderState.Done;
            order_service.ModifyOrder(order);
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
    }
}
