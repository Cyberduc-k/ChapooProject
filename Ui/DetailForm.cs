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
    public partial class DetailForm : Form
    {
        private Table tafel;
        private DetailViewModel product;
        private Order order;
        private string maaltijd;
        private Employee employee;

        public DetailForm(Table tafel, DetailViewModel product, Order order, Employee employee, string maaltijd)
        {
            this.tafel = tafel;
            this.product = product;
            this.order = order;
            this.maaltijd = maaltijd;
            this.employee = employee;
            InitializeComponent();
        }

        private void DetailForm_Load(object sender, EventArgs e)
        {
            lblTafelNummer.Text = $"Tafel: {tafel.Number.ToString()}";
            int[] items = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            if (product.Dish.Name != null)
            {
                nameLbl.Text = product.Dish.Name;
                ingredientTxt.Text = product.Dish.Ingredients;
                

                comboBox.DataSource = items;
                int quantity = (int)comboBox.SelectedItem;
                prijsLbl.Text = (product.Dish.Price * quantity).ToString();
            }
            else if (product.Drink.Name != null)
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
            if (product.Dish.Name != null)
            {
                int quantity = (int)comboBox.SelectedItem;
                prijsLbl.Text = (product.Dish.Price * quantity).ToString();
            }
            else if (product.Drink.Name != null)
            {
                int quantity = (int)comboBox.SelectedItem;
                prijsLbl.Text = (product.Drink.Price * quantity).ToString();
            }
        }

        private void bestelBtn_Click(object sender, EventArgs e)
        {
            List<Dish> dishes = new List<Dish>();
            List<Drink> drinks = new List<Drink>();
            if (product.Dish.Name != null)
            {
                if (product.Dish.Stock < (int)comboBox.SelectedItem)
                {
                    MessageBox.Show("Niet op voorraad", "Attentie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (order.Dishes == null)
                {
                    product.Dish.Aantal = (int)comboBox.SelectedItem;
                    order = new Order(0, DateTime.Now, DateTime.Now, dishes, drinks, 0, tafel.Number, OrderState.Started);
                    product.Dish.Comment = opmerkingenTxt.Text;
                    
                    order.Dishes.Add(product.Dish);
                }
                else
                {
                    
                    product.Dish.Aantal = (int)comboBox.SelectedItem;
                    if (order.Dishes.Any(dish => dish.Id == product.Dish.Id))
                    {
                        foreach (Dish d in order.Dishes)
                        {
                            if (product.Dish.Id == d.Id)
                            {
                                d.Aantal+= (int)comboBox.SelectedItem;
                            }
                        }
                        product.Dish.Comment = opmerkingenTxt.Text;
                    }
                    else
                    {
                        product.Dish.Comment = opmerkingenTxt.Text;
                        order.Dishes.Add(product.Dish);
                    }
                    
                    
                }
            }
            else if (product.Drink.Name != null)
            {
                if (product.Drink.Stock < (int)comboBox.SelectedItem)
                {
                    MessageBox.Show("Niet op voorraad", "Attentie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (order.Drinks == null)
                {
                    product.Drink.Aantal = (int)comboBox.SelectedItem;
                    order = new Order(0, DateTime.Now, DateTime.Now, dishes, drinks, 0, tafel.Number, OrderState.Started);
                    product.Drink.Comment = opmerkingenTxt.Text;
                    order.Drinks.Add(product.Drink);
                }
                else
                {
                    /*
                    product.Drink.Aantal = (int)comboBox.SelectedItem;
                    product.Drink.Comment = opmerkingenTxt.Text;
                    foreach(Drink d in order.Drinks)
                    {
                        if (d.Name == product.Drink.Name)
                        {
                            d.Aantal += (int)comboBox.SelectedItem;
                        }
                        else
                        {
                            product.Drink.Comment = opmerkingenTxt.Text;
                            order.Drinks.Add(product.Drink);
                        }
                    }
                    */
                    product.Drink.Aantal = (int)comboBox.SelectedItem;
                    if (order.Drinks.Any(drink => drink.Id == product.Drink.Id))
                    {
                        foreach (Drink d in order.Drinks)
                        {
                            if (product.Drink.Id == d.Id)
                            {
                                d.Aantal += (int)comboBox.SelectedItem;
                            }
                        }
                        product.Drink.Comment = opmerkingenTxt.Text;
                    }
                    else
                    {
                        product.Drink.Comment = opmerkingenTxt.Text;
                        order.Drinks.Add(product.Drink);
                    }
                }
            }
            Hide();
            BestelLijstFrom form = new BestelLijstFrom(tafel, order, employee);
            form.ShowDialog(Owner);
            Close();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Hide();
            LunchMenuForm form = new LunchMenuForm(tafel, order, employee, maaltijd);
            form.ShowDialog(Owner);
            Close();
        }
    }
}
