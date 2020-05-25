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
    public partial class ChefForm : Form
    {
        private Order_Service order_service = new Order_Service();
        private Dish_Service dish_service = new Dish_Service();
        private List<Order> orders;

        public ChefForm()
        {
            InitializeComponent();
            Chef_btnOverzicht_Click(null, null);
        }

        // Highlight a button
        private void SetHightlight(Button btn)
        {
            Chef_btnOverzicht.BackColor = Color.FromArgb(0, 165, 229);
            Chef_btnVoorraad.BackColor = Color.FromArgb(0, 165, 229);
            btn.BackColor = Color.FromArgb(0, 184, 255);
        }

        private void HideAllPanels()
        {
            Chef_pnlOverzicht.Hide();
            Chef_lblGeenBestellingen.Hide();
            Chef_pnlFirstOrder.Hide();
            Chef_pnlSecondOrder.Hide();
            Chef_pnlThirdOrder.Hide();
            Chef_pnlFourthOrder.Hide();
            Chef_pnlOverflow.Hide();

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

            if (orders.Count == 0)
                Chef_lblGeenBestellingen.Show();
            else
            {
                FillFirstOrder(orders[0]);

                if (orders.Count >= 2)
                    FillSecondOrder(orders[1]);

                if (orders.Count >= 3)
                    FillThirdOrder(orders[2]);

                if (orders.Count >= 4)
                    FillFourthOrder(orders[3]);

                if (orders.Count >= 5)
                    ShowOverflow(orders.Count - 4);
            }
        }

        private void FillFirstOrder(Order order)
        {
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
    }
}
