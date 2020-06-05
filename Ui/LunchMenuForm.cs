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
        private List<Dish> orderDishes;
        private List<Drink> orderDrinks;
        private List<Dish> lunch;
        private List<Dish> diner;
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
            
            int i = 0;
            
            //hier komen de db calls voor de maaltijd, op basis van wat de maaaltijd string is weet je of het een lunch, diner of drank menu is.
            //lunch = "Lunchmenu"
            //diner = "Dinermenu"
            //drank = "Drankenlijst"
            if (maaltijd == "Lunchmenu")
            {
                //get lunchmenu
                lunch = dishService.GetAllLunch();
                
                if (lunch == null)
                {
                    label1.Text = "Er is niets in db";
                    label2.Text = "Er is niets in db";
                    label3.Text = "Er is niets in db";
                    return;
                }
            }
            else if (maaltijd == "Dinermenu")
            {
                //get dinermenu
                diner = dishService.GetAllDinner();

                if (diner == null)
                {
                    label1.Text = "Er is niets in db";
                    label2.Text = "Er is niets in db";
                    label3.Text = "Er is niets in db";
                    return;
                }
            }
            else if (maaltijd == "Drankenlijst")
            {
                //get drankenlijst
                drinks = drinkService.GetAllDrinks();

                if (drinks == null)
                {
                    label1.Text = "Er is niets in db";
                    label2.Text = "Er is niets in db";
                    label3.Text = "Er is niets in db";
                    return;
                }
            }

            List<Button> list = new List<Button>();

            List<Button> voorgerechten = new List<Button>();
            List<Button> hoofdgerechten = new List<Button>();
            List<Button> nagerechten = new List<Button>();
            

            if (maaltijd == "Drankenlijst")
            {
                label1.Text = "Frisdranken";
                label2.Text = "Alcoholische dranken";
                label3.Text = "Koffie/Thee";

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
                    if (t.Alcoholic)
                    {
                        hoofdgerechten.Add(btn);
                    }
                    else if (t.Id > 21)
                    {
                        nagerechten.Add(btn);
                    }
                    else
                    {
                        voorgerechten.Add(btn);
                    }
                    i++;
                    
                    this.Controls.Add(btn);
                }
                Button[] btns1 = voorgerechten.ToArray();
                Button[] btns2 = hoofdgerechten.ToArray();
                Button[] btns3 = nagerechten.ToArray();

                voorgerechtFlow.Controls.AddRange(btns1);
                hoofdgerechtFlow.Controls.AddRange(btns2);
                nagerechtFlow.Controls.AddRange(btns3);
            }
            else if(maaltijd == "Lunchmenu")
            {
                foreach (Dish t in lunch)
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
            else if (maaltijd == "Dinermenu")
            {
                foreach (Dish t in diner)
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
            Drink drink = new Drink();
            string name = btn.Text;
            List<Dish> dishes = new List<Dish>();
            if (lunch != null)
            {
                dishes = lunch;
            }

            else if (diner != null)
            {
                dishes = diner;
            }


            else if (drinks != null)
            {
                
                foreach (Drink d in drinks)
                {
                    if (d.Name == name)
                    {
                        drink = d;
                    }
                }
            }


            foreach (Dish d in dishes)
            {
                if (d.Name == name)
                {
                    dish = d;
                }
            }
            DetailViewModel product = new DetailViewModel(dish, drink);
            DetailForm form = new DetailForm(tafel, product, order, maaltijd);
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
