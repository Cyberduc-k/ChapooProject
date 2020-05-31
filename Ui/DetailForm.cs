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
        private Dish dish;
        private Order order;
        private string maaltijd;
        public DetailForm(Table tafel, Dish dish, Order order, string maaltijd)
        {
            this.tafel = tafel;
            this.dish = dish;
            this.order = order;
            this.maaltijd = maaltijd;
            InitializeComponent();
        }

        private void DetailForm_Load(object sender, EventArgs e)
        {
            nameLbl.Text = dish.Name;
            ingredientTxt.Text = dish.Ingredients;
            int[] items = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            comboBox.DataSource = items;
            int quantity  = (int)comboBox.SelectedItem;
            prijsLbl.Text = (dish.Price * quantity).ToString();
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int quantity = (int)comboBox.SelectedItem;
            prijsLbl.Text = (dish.Price * quantity).ToString();
        }

        private void bestelBtn_Click(object sender, EventArgs e)
        {
            List<Dish> dishes = new List<Dish>();
            List<Drink> drinks = new List<Drink>();
            if (order.Dishes == null)
            {
                order = new Order(0, DateTime.Now, DateTime.Now, dishes, drinks, 0, tafel.Number, OrderState.Started, "");
                order.Dishes.Add(dish);
            }
            else
            {
                order.Dishes.Add(dish);
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
