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
    public partial class CP_Popup_EditDrinksMenu : CP_Popup_Parent
    {
        //Bools to store if the text boxes are filled in
        private bool nameFilledIn = false;
        private bool priceFilledIn = false;
        private bool stockFilledIn = false;

        //Reference to the id of the drink being edited
        private int id;

        public CP_Popup_EditDrinksMenu(Drink drink)
        {
            InitializeComponent();

            //Load an icon for the form
            LoadIcon("Resources/pencil-icon.ico");

            //Show the current values of the dish
            CP_Popop_EditDrinksMenu_txtName.Text = drink.Name;
            CP_Popop_EditDrinksMenu_txtPrice.Text = drink.Price.ToString();
            CP_Popup_EditDrinksMenu_txtStock.Text = drink.Stock.ToString();

            if (drink.Alcoholic)
                CP_Popup_EditDrinksMenu_cboxAlcoholic.Checked = true;
            else
                CP_Popup_EditDrinksMenu_cboxAlcoholic.Checked = false;

            //Store the reference
            id = drink.Id;
        }

        //Update the state of the OK button when the textbox value changes
        private void CP_Popop_EditDrinksMenu_txtName_TextChanged(object sender, EventArgs e)
        {
            if (CP_Popop_EditDrinksMenu_txtName.Text != "")
                nameFilledIn = true;
            else
                nameFilledIn = false;

            UpdateOKbtn(nameFilledIn, priceFilledIn, stockFilledIn);
        }

        //Update the state of the OK button when the textbox value changes
        private void CP_Popop_EditDrinksMenu_txtPrice_TextChanged(object sender, EventArgs e)
        {
            if(CP_Popop_EditDrinksMenu_txtPrice.Text != "")
            {
                if (double.TryParse(CP_Popop_EditDrinksMenu_txtPrice.Text, out _))
                {
                    //Show the user an error if the parse fails
                    CP_Popup_EditDrinksMenu_lblPrijsError.Hide();
                    priceFilledIn = true;
                }
                else
                {
                    CP_Popup_EditDrinksMenu_lblPrijsError.Show();
                    priceFilledIn = false;
                }
            }
            else
            {
                CP_Popup_EditDrinksMenu_lblPrijsError.Hide();
                priceFilledIn = false;
            }

            UpdateOKbtn(nameFilledIn, priceFilledIn, stockFilledIn);
        }

        //Update the state of the OK button when the textbox value changes
        private void CP_Popup_EditDrinksMenu_txtStock_TextChanged(object sender, EventArgs e)
        {
            if (CP_Popup_EditDrinksMenu_txtStock.Text != "") 
            {
                if(int.TryParse(CP_Popup_EditDrinksMenu_txtStock.Text, out _))
                {
                    //Show the user an error if the parse fails
                    CP_Popup_EditDrinksMenu_lblErrorStock.Hide();
                    stockFilledIn = true;
                }
                else
                {
                    CP_Popup_EditDrinksMenu_lblErrorStock.Show();
                    stockFilledIn = false;
                }
            }
            else
            {
                CP_Popup_EditDrinksMenu_lblErrorStock.Hide();
                stockFilledIn = false;
            }

            UpdateOKbtn(nameFilledIn, priceFilledIn, stockFilledIn);
        }

        public override void OnClickOK(object sender, EventArgs e)
        {
            CP_Popup_Sure popup = new CP_Popup_Sure();
            popup.SetAsEdit(CP_Popop_EditDrinksMenu_txtName.Text);
            popup.ShowDialog();

            if (!(popup.DialogResult == DialogResult.OK))
            {
                DialogResult = DialogResult.Cancel;
                Close();
            }

            Drink_Service drinkService = new Drink_Service();

            //Store the values of all of the inputs
            string name = CP_Popop_EditDrinksMenu_txtName.Text;
            bool alcoholic;

            bool priceParsed = double.TryParse(CP_Popop_EditDrinksMenu_txtPrice.Text, out double price);
            bool stockParsed = int.TryParse(CP_Popup_EditDrinksMenu_txtStock.Text, out int stock);

            if (!(priceParsed && stockParsed))
                Close();

            if (CP_Popup_EditDrinksMenu_cboxAlcoholic.Checked)
                alcoholic = true;
            else
                alcoholic = false;


            //Add a new dish to the system
            try
            {
                drinkService.ModifyDrink(new Drink(id, name, alcoholic, price, stock));
            }
            catch (Exception ex)
            {
                ErrorHandler.Instance.HandleError("Drank met id " + id + " kon niet aangepast worden!", "Gerecht niet aangepast", ex);

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
