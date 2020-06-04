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
    public partial class CP_Popup_AddToMenu : CP_Popup_Parent
    {
        //Bools to store if the text boxes are filled in
        private bool nameFilledIn = false;
        private bool ingredientsFilledIn = false;
        private bool priceFilledIn = false;
        private bool stockFilledIn = false;
        private MenuType currentMenu;

        public CP_Popup_AddToMenu(MenuType currentMenu)
        {
            this.currentMenu = currentMenu;

            InitializeComponent();

            //Load an icon for the form
            LoadIcon("Resources/pencil-icon.ico");
        }

        private void CP_Popop_AddToMenu_txtName_TextChanged(object sender, EventArgs e)
        {
            if (CP_Popop_AddToMenu_txtName.Text != "")
                nameFilledIn = true;
            else
                nameFilledIn = false;

            UpdateOKbtn(nameFilledIn, priceFilledIn, ingredientsFilledIn, stockFilledIn);
        }

        private void CP_Popop_AddToMenu_txtPrice_TextChanged(object sender, EventArgs e)
        {
            if (CP_Popop_AddToMenu_txtPrice.Text != "")
                priceFilledIn = true;
            else
                priceFilledIn = false;

            UpdateOKbtn(nameFilledIn, priceFilledIn, ingredientsFilledIn, stockFilledIn);
        }

        private void CP_Popop_AddToMenu_txtIngredients_TextChanged(object sender, EventArgs e)
        {
            if (CP_Popop_AddToMenu_txtIngredients.Text != "")
                ingredientsFilledIn = true;
            else
                ingredientsFilledIn = false;

            UpdateOKbtn(nameFilledIn, priceFilledIn, ingredientsFilledIn, stockFilledIn);
        }

        private void CP_Popup_AddToMenu_txtStock_TextChanged(object sender, EventArgs e)
        {
            if (CP_Popup_AddToMenu_txtStock.Text != "")
                stockFilledIn = true;
            else
                stockFilledIn = false;

            UpdateOKbtn(nameFilledIn, priceFilledIn, ingredientsFilledIn, stockFilledIn);
        }

        public override void OnClickOK(object sender, EventArgs e)
        {
            Dish_Service dishService = new Dish_Service();

            //Store the values of all of the inputs
            string name = CP_Popop_AddToMenu_txtName.Text;
            string description = CP_Popop_AddToMenu_txtDescription.Text;
            string ingredients = CP_Popop_AddToMenu_txtIngredients.Text;
            DishCategory category;

            bool priceParsed = double.TryParse(CP_Popop_AddToMenu_txtPrice.Text, out double price);
            bool stockParsed = int.TryParse(CP_Popup_AddToMenu_txtStock.Text, out int stock);

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
                dishService.AddDish(new Dish(0, name, description, ingredients, price, stock, category), currentMenu);
            }
            catch (Exception ex)
            {
                ErrorHandler.Instance.HandleError("Nieuw gerecht kon niet toegevoegd worden!", "Gerecht niet toegevoegd", ex);

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
