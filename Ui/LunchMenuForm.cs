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
    public partial class LunchMenuForm : Form
    {
        private Table tafel;
        private Order order;
        private string maaltijd;
        private List<Dish> dishes;
        private List<Drink> drinks;
        private Dish_Service dishService = new Dish_Service();
        private Drink_Service drinkService = new Drink_Service();
        public LunchMenuForm(Table tafel, Order order, string maaltijd)
        {
            this.tafel = tafel;
            this.order = order;
            this.maaltijd = maaltijd;
            InitializeComponent();
        }

        private void LunchMenuForm_Load(object sender, EventArgs e)
        {
            // List<Dish> dishes = dishService.GetAllLunch();
            //dishes = new List<Dish>();
            //Dish voorgerecht = new Dish(0, "negerbrood", "brood voor de negers", "fufu", 5, 200, DishCategory.Voorgerechten);
            //Dish hoofdgerecht = new Dish(1, "mijn pik", "pik is de hoofdgerecht man", "zebi", 500, 1, DishCategory.Hoofdgerechten);
            //Dish nagerecht = new Dish(2, "pagga op stok", "paggerino", "sperrie", 100, 200000, DishCategory.Nagerechten);
            int i = 0;
            //dishes.Add(voorgerecht);
            //dishes.Add(hoofdgerecht);
            //dishes.Add(nagerecht);

            //hier komen de db calls voor de maaltijd, op basis van wat de maaaltijd string is weet je of het een lunch, diner of drank menu is.
            //lunch = "Lunchmenu"
            //diner = "Dinermenu"
            //drank = "Drankenlijst"
            if (maaltijd == "Lunchmenu")
            {
                //get lunchmenu
                List<Dish> dishes = dishService.GetAllLunch();

            }
            else if (maaltijd == "Dinermenu")
            {
                //get dinermenu
                List<Dish> dishes = dishService.GetAllDinner();
            }
            else if (maaltijd == "Drankenlijst")
            {
                //get drankenlijst
                List<Drink> drinks = drinkService.GetAllDrinks();
            }

            List<Button> list = new List<Button>();

            List<Button> voorgerechten = new List<Button>();
            List<Button> hoofdgerechten = new List<Button>();
            List<Button> nagerechten = new List<Button>();
            if (dishes == null)
            {
                label1.Text = "Er is niets in db";
                label2.Text = "Er is niets in db";
                label3.Text = "Er is niets in db";
                return;
            }

            if (maaltijd == "Drankenlijst")
            {
                foreach (Drink t in drinks)
                {
                    Button btn = new Button();
                    btn.BackColor = System.Drawing.Color.LightBlue;
                    btn.Text = t.Name;
                    btn.Click += new EventHandler(this.ClickEvent);
                    Point point = new Point();
                    point.X = i * 83;
                    point.Y = 35;
                    btn.Size = new Size(200, 50);
                    btn.PointToClient(point);
                    btn.Show();
                    list.Add(btn);
                    i++;
                    voorgerechten.Add(btn);
                    
                    this.Controls.Add(btn);
                }
                Button[] btns5 = voorgerechten.ToArray();
                voorgerechtFlow.Controls.AddRange(btns5);
            }
            else
            {
                foreach (Dish t in dishes)
                {
                    Button btn = new Button();
                    btn.BackColor = System.Drawing.Color.LightBlue;
                    btn.Text = t.Name;
                    btn.Click += new EventHandler(this.ClickEvent);
                    Point point = new Point();
                    point.X = i * 83;
                    point.Y = 35;
                    btn.Size = new Size(200, 50);
                    btn.PointToClient(point);
                    btn.Show();
                    list.Add(btn);
                    i++;
                    if (t.Category == DishCategory.Voorgerechten)
                    {
                        voorgerechten.Add(btn);
                    }
                    else if (t.Category == DishCategory.Hoofdgerechten)
                    {
                        hoofdgerechten.Add(btn);
                    }
                    else if (t.Category == DishCategory.Nagerechten)
                    {
                        nagerechten.Add(btn);
                    }
                    this.Controls.Add(btn);
                }
                Button[] btns1 = voorgerechten.ToArray();
                Button[] btns2 = hoofdgerechten.ToArray();
                Button[] btns3 = nagerechten.ToArray();

                voorgerechtFlow.Controls.AddRange(btns1);
                hoofdgerechtFlow.Controls.AddRange(btns2);
                nagerechtFlow.Controls.AddRange(btns3);
            }
        }
        private void ClickEvent(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Dish dish = new Dish();

            string name = btn.Text;
            foreach (Dish d in dishes)
            {
                if (d.Name == name)
                {
                    dish = d;
                }
            }
            DetailForm form = new DetailForm(tafel, dish, order, maaltijd);
            form.Show();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuForm form = new MenuForm(tafel, order);
            form.Show();
        }
    }
}
