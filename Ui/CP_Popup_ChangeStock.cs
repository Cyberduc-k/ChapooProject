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
    public partial class CP_Popup_ChangeStock : CP_Popup_Parent
    {
        //Bools to store if the text boxes are filled in
        private bool stockFilledIn = false;

        //The int of the item to change
        private Item item;

        public CP_Popup_ChangeStock(Item item)
        {
            InitializeComponent();

            //Load an icon for the form
            LoadIcon("Resources/pencil-icon.ico");

            //Store the item to change the stock off
            this.item = item;

            //Show the current stock in the textbox
            CP_Popup_ChangeStock_txtStock.Text = item.Stock.ToString();
        }

        //Update the state of the OK button when the textbox value changes
        private void CP_Popup_ChangeStock_txtStock_TextChanged(object sender, EventArgs e)
        {
            if (CP_Popup_ChangeStock_txtStock.Text != "") 
            {
                if(int.TryParse(CP_Popup_ChangeStock_txtStock.Text, out _))
                {
                    //Show the user an error if the parse fails
                    CP_Popup_ChangeStock_lblErrorStock.Hide();
                    stockFilledIn = true;
                }
                else
                {
                    CP_Popup_ChangeStock_lblErrorStock.Show();
                    stockFilledIn = false;
                }
            }
            else
            {
                CP_Popup_ChangeStock_lblErrorStock.Hide();
                stockFilledIn = false;
            }

            UpdateOKbtn(stockFilledIn);
        }

        public override void OnClickOK(object sender, EventArgs e)
        {
            //Check if the user is sure
            CP_Popup_Sure popup = new CP_Popup_Sure();
            popup.SetAsChangeStock(item.Name);
            popup.ShowDialog();

            if (!(popup.DialogResult == DialogResult.OK))
            {
                DialogResult = DialogResult.Cancel;
                Close();
            }

            //Store the value of the input
            bool stockParsed = int.TryParse(CP_Popup_ChangeStock_txtStock.Text, out int stock);

            //Close the form if the parse fails
            if (!stockParsed)
                Close();
            
            //Check whether to use the Dish or the drink Service
            if(item.GetType() == typeof(Dish))
            {
                Dish_Service dishService = new Dish_Service();

                //Modify the stock
                try
                {
                    dishService.ModifyStock(item.Id, stock);
                }
                catch (Exception ex)
                {
                    ErrorHandler.Instance.HandleError("Voorraad van " + item.Id + " kon niet aangepast worden!", "Voorraad niet aangepast", ex);

                    //Tell the ControlPanel form that the action didn't succeed
                    DialogResult = DialogResult.Cancel;
                }
            }
            else
            {
                Drink_Service drinkService = new Drink_Service();

                //Modify the stock
                try
                {
                    drinkService.ModifyStock(item.Id, stock);
                }
                catch (Exception ex)
                {
                    ErrorHandler.Instance.HandleError("Voorraad van " + item.Id + " kon niet aangepast worden!", "Voorraad niet aangepast", ex);

                    //Tell the ControlPanel form that the action didn't succeed
                    DialogResult = DialogResult.Cancel;
                }
            }        
        }

        //Close the form
        public override void OnClickCancel(object sender, EventArgs e)
        {
            Close();
        }
    }
}
