﻿using System;
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
        /*//Bools to store if the text boxes are filled in
        private bool nameFilledIn = false;
        private bool priceFilledIn = false;
        private bool stockFilledIn = false;

        public CP_Popup_ChangeStock()
        {
            InitializeComponent();

            //Load an icon for the form
            LoadIcon("Resources/pencil-icon.ico");
        }

        private void CP_Popop_ChangeStock_txtName_TextChanged(object sender, EventArgs e)
        {
            if (CP_Popop_ChangeStock_txtName.Text != "")
                nameFilledIn = true;
            else
                nameFilledIn = false;

            UpdateOKbtn(nameFilledIn, priceFilledIn, stockFilledIn);
        }

        private void CP_Popop_ChangeStock_txtPrice_TextChanged(object sender, EventArgs e)
        {
            if(CP_Popop_ChangeStock_txtPrice.Text != "")
            {
                if (double.TryParse(CP_Popop_ChangeStock_txtPrice.Text, out _))
                {
                    CP_Popup_ChangeStock_lblPrijsError.Hide();
                    priceFilledIn = true;
                }
                else
                {
                    CP_Popup_ChangeStock_lblPrijsError.Show();
                    priceFilledIn = false;
                }
            }
            else
            {
                CP_Popup_ChangeStock_lblPrijsError.Hide();
                priceFilledIn = false;
            }

            UpdateOKbtn(nameFilledIn, priceFilledIn, stockFilledIn);
        }

        private void CP_Popup_ChangeStock_txtStock_TextChanged(object sender, EventArgs e)
        {
            if (CP_Popup_ChangeStock_txtStock.Text != "") 
            {
                if(int.TryParse(CP_Popup_ChangeStock_txtStock.Text, out _))
                {
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

            UpdateOKbtn(nameFilledIn, priceFilledIn, stockFilledIn);
        }*/

        public override void OnClickOK(object sender, EventArgs e)
        {/*
            Drink_Service drinkService = new Drink_Service();

            //Store the values of all of the inputs
            string name = CP_Popop_ChangeStock_txtName.Text;
            bool alcoholic;

            bool priceParsed = double.TryParse(CP_Popop_ChangeStock_txtPrice.Text, out double price);
            bool stockParsed = int.TryParse(CP_Popup_ChangeStock_txtStock.Text, out int stock);

            if (!(priceParsed && stockParsed))
                Close();

            if (CP_Popup_ChangeStock_cboxAlcoholic.Checked)
                alcoholic = true;
            else
                alcoholic = false;

            //Add a new drink to the system
            try
            {
                drinkService.AddDrink(new Drink(name, alcoholic, price, stock));
            }
            catch (Exception ex)
            {
                ErrorHandler.Instance.HandleError("Drank kon niet toegevoegd worden!", "Drank niet toegevoegd", ex);

                //Tell the ControlPanel form that the action didn't succeed
                DialogResult = DialogResult.Cancel;
            }*/
        }

        public override void OnClickCancel(object sender, EventArgs e)
        {
            Close();
        }
    }
}
