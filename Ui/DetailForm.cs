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
    public partial class DetailForm : Form
    {
        private Table tafel;
        private DetailViewModel product;
        private Order order;
        private string maaltijd;
        public DetailForm(Table tafel, DetailViewModel product, Order order, string maaltijd)
        {
            this.tafel = tafel;
            this.product = product;
            this.order = order;
            this.maaltijd = maaltijd;
            InitializeComponent();
        }

        private void DetailForm_Load(object sender, EventArgs e)
        {
            int[] items = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            if (product.Dish != null)
            {
                nameLbl.Text = product.Dish.Name;
                ingredientTxt.Text = product.Dish.Ingredients;
                

                comboBox.DataSource = items;
                int quantity = (int)comboBox.SelectedItem;
                prijsLbl.Text = (product.Dish.Price * quantity).ToString();
            }
            else if (product.Drink != null)
            {
                ingredientTxt.Visible = false;
                nameLbl.Text = product.Drink.Name;
                label2.Text = $"Alcoholisch: {product.Drink.ToString()}";

                comboBox.DataSource = items;
                int quantity = (int)comboBox.SelectedItem;
                prijsLbl.Text = (product.Drink.Price * quantity).ToString();
            }
            
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (product.Dish != null)
            {
                int quantity = (int)comboBox.SelectedItem;
                prijsLbl.Text = (product.Dish.Price * quantity).ToString();
            }
            else if (product.Drink != null)
            {
                int quantity = (int)comboBox.SelectedItem;
                prijsLbl.Text = (product.Drink.Price * quantity).ToString();
            }
        }

        private void bestelBtn_Click(object sender, EventArgs e)
        {
            List<Dish> dishes = new List<Dish>();
            List<Drink> drinks = new List<Drink>();
            if (product.Dish != null)
            {
                if (order.Dishes == null)
                {
                    order = new Order(0, DateTime.Now, DateTime.Now, dishes, drinks, 0, tafel.Number, OrderState.Started, "");
                    order.Dishes.Add(product.Dish);
                }
                else
                {
                    order.Dishes.Add(product.Dish);
                }
            }
            else if (product.Drink != null)
            {
                if (order.Drinks == null)
                {
                    order = new Order(0, DateTime.Now, DateTime.Now, dishes, drinks, 0, tafel.Number, OrderState.Started, "");
                    order.Drinks.Add(product.Drink);
                }
                else
                {
                    order.Drinks.Add(product.Drink);
                }
            }
            //order.TableId = tafelnr;
            //order.State = OrderState.Started;
            //order.TimeOrdering = DateTime.Now;

            
            
            

            this.Hide();
            BestelLijstFrom form = new BestelLijstFrom(tafel, order);
            form.Show();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LunchMenuForm form = new LunchMenuForm(tafel, order, maaltijd);
            form.Show();
        }
    }
}
