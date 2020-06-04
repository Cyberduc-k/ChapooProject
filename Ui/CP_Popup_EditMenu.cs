using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Logic;

namespace Ui
{
    public partial class CP_Popup_EditMenu : CP_Popup_Parent
    {
        //Bools to store if the text boxes are filled in
        private bool nameFilledIn = false;
        private bool ingredientsFilledIn = false;
        private bool priceFilledIn = false;
        private bool stockFilledIn = false;

        private int id;

        public CP_Popup_EditMenu(Dish dish)
        {
            InitializeComponent();

            //Load an icon for the form
            LoadIcon("Resources/pencil-icon.ico");

            //Show the current values of the dish
            CP_Popop_EditMenu_txtName.Text = dish.Name;
            CP_Popop_EditMenu_txtDescription.Text = dish.Description;
            CP_Popop_EditMenu_txtIngredients.Text = dish.Ingredients;
            CP_Popop_EditMenu_txtPrice.Text = dish.Price.ToString();
            CP_Popup_EditMenu_txtStock.Text = dish.Stock.ToString();

            if (dish.Category == DishCategory.Voorgerechten)
                CP_PopopEditEmployee_rbtnVoor.Checked = true;
            else if (dish.Category == DishCategory.Tussengerechten)
                CP_PopopEditEmployee_rbtnTussen.Checked = true;
            else if (dish.Category == DishCategory.Hoofdgerechten)
                CP_PopopEditEmployee_rbtnHoofd.Checked = true;
            else
                CP_PopopEditEmployee_rbtnNa.Checked = true;

            id = dish.Id;
        }

        private void CP_Popop_EditMenu_txtName_TextChanged(object sender, EventArgs e)
        {
            if (CP_Popop_EditMenu_txtName.Text != "")
                nameFilledIn = true;
            else
                nameFilledIn = false;

            UpdateOKbtn(nameFilledIn, priceFilledIn, ingredientsFilledIn, stockFilledIn);
        }

        private void CP_Popop_EditMenu_txtPrice_TextChanged(object sender, EventArgs e)
        {
            if(CP_Popop_EditMenu_txtPrice.Text != "")
            {
                if (double.TryParse(CP_Popop_EditMenu_txtPrice.Text, out _))
                {
                    CP_Popup_EditMenu_lblPrijsError.Hide();
                    priceFilledIn = true;
                }
                else
                {
                    CP_Popup_EditMenu_lblPrijsError.Show();
                    priceFilledIn = false;
                }
            }
            else
            {
                CP_Popup_EditMenu_lblPrijsError.Hide();
                priceFilledIn = false;
            }

            UpdateOKbtn(nameFilledIn, priceFilledIn, ingredientsFilledIn, stockFilledIn);
        }

        private void CP_Popop_EditMenu_txtIngredients_TextChanged(object sender, EventArgs e)
        {
            if (CP_Popop_EditMenu_txtIngredients.Text != "")
                ingredientsFilledIn = true;
            else
                ingredientsFilledIn = false;

            UpdateOKbtn(nameFilledIn, priceFilledIn, ingredientsFilledIn, stockFilledIn);
        }

        private void CP_Popup_EditMenu_txtStock_TextChanged(object sender, EventArgs e)
        {
            if (CP_Popup_EditMenu_txtStock.Text != "") 
            {
                if(int.TryParse(CP_Popup_EditMenu_txtStock.Text, out _))
                {
                    CP_Popup_EditMenu_lblErrorStock.Hide();
                    stockFilledIn = true;
                }
                else
                {
                    CP_Popup_EditMenu_lblErrorStock.Show();
                    stockFilledIn = false;
                }
            }
            else
            {
                CP_Popup_EditMenu_lblErrorStock.Hide();
                stockFilledIn = false;
            }

            UpdateOKbtn(nameFilledIn, priceFilledIn, ingredientsFilledIn, stockFilledIn);
        }

        public override void OnClickOK(object sender, EventArgs e)
        {
            CP_Popup_Sure popup = new CP_Popup_Sure();
            popup.SetAsEdit(CP_Popop_EditMenu_txtName.Text);
            popup.ShowDialog();

            if (!(popup.DialogResult == DialogResult.OK))
            {
                DialogResult = DialogResult.Cancel;
                Close();
            }

            Dish_Service dishService = new Dish_Service();

            //Store the values of all of the inputs
            string name = CP_Popop_EditMenu_txtName.Text;
            string description = CP_Popop_EditMenu_txtDescription.Text;
            string ingredients = CP_Popop_EditMenu_txtIngredients.Text;
            DishCategory category;

            bool priceParsed = double.TryParse(CP_Popop_EditMenu_txtPrice.Text, out double price);
            bool stockParsed = int.TryParse(CP_Popup_EditMenu_txtStock.Text, out int stock);

            if (!(priceParsed && stockParsed))
                Close();

            if (CP_PopopEditEmployee_rbtnVoor.Checked)
                category = DishCategory.Voorgerechten;
            else if (CP_PopopEditEmployee_rbtnTussen.Checked)
                category = DishCategory.Tussengerechten;
            else if (CP_PopopEditEmployee_rbtnHoofd.Checked)
                category = DishCategory.Hoofdgerechten;
            else
                category = DishCategory.Nagerechten;

            //Add a new dish to the system
            try
            {
                dishService.ModifyDish(new Dish(id, name, description, ingredients, price, stock, category));
            }
            catch (Exception ex)
            {
                ErrorHandler.Instance.HandleError("Gerecht met id " + id + " kon niet toegevoegd worden!", "Gerecht niet toegevoegd", ex);

                //Tell the ControlPanel form that the action didn't succeed
                DialogResult = DialogResult.Cancel;
            }
        }

        public override void OnClickCancel(object sender, EventArgs e)
        {
            Close();
        }
    }
}
