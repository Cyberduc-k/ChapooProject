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
    public partial class ControlPanelForm : Form
    {
        //The services used to interact with the DAO
        private ListViewColumnSorter lvwColumnSorter = new ListViewColumnSorter();
        private Drink_Service drinkService = new Drink_Service();
        private Dish_Service dishService = new Dish_Service();
        private Employee_Service employeeService = new Employee_Service();
        private Bill_Service billService = new Bill_Service();

        //Var used to create new columnHeader for the listView sorter
        private ColumnHeader columnheader;

        //Var to track the shown menu card
        private MenuType shownMenu;

        public ControlPanelForm()
        {
            InitializeComponent();

            //Hide all the existing panels on startup
            HideAllPanels();
            //Make sure all the listviews are setup properly
            InitializeSorting();

            //Show voorraad by default
            CP_btnVoorraad_Click(null, null);
        }

        //Code for the navmenu
        #region NavMenu
        //Highlight the button, set the text in the top bar, hide all other panels, show correct panel
        private void CP_btnVoorraad_Click(object sender, EventArgs e)
        {
            SetHightlight(CP_btnVoorraad);
            CP_lblActivePanel.Text = "Voorraad";
            HideAllPanels();
            CP_pnlVoorraad.Show();

            LoadVoorraadDrinks();
        }

        //Highlight the button, set the text in the top bar, hide all other panels, show correct panel
        private void CP_btnMenukaarten_Click(object sender, EventArgs e)
        {
            SetHightlight(CP_btnMenukaarten);
            CP_lblActivePanel.Text = "Menukaarten";
            HideAllPanels();
            CP_pnlMenukaarten.Show();

            LoadMenukaartenDrinks();
        }

        //Highlight the button, set the text in the top bar, hide all other panels, show correct panel
        private void CP_btnInkomsten_Click(object sender, EventArgs e)
        {
            SetHightlight(CP_btnInkomsten);
            CP_lblActivePanel.Text = "Inkomsten";
            HideAllPanels();
            CP_pnlInkomsten.Show();

            LoadRevenue();
        }

        //Highlight the button, set the text in the top bar, hide all other panels, show correct panel
        private void CP_btnMedewerkers_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            SetHightlight(CP_btnMedewerkers);
            CP_lblActivePanel.Text = "Medewerkers";
            CP_pnlMedewerkers.Show();
            
            LoadEmployeeList();
        }

        private void CP_btnUitloggen_Click(object sender, EventArgs e)
        {
            //@TODO uitloggen
            SetHightlight(CP_btnUitloggen);
            Owner.Show();

            Close();
        }
        #endregion

        //Code for the Voorraad panel
        #region Voorraad
        //Load all drinks into the vooraad ListView
        private void LoadVoorraadDrinks()
        {
            //Empty the listview
            CP_Voorraad_listView.Clear();

            //Create a list of all the drinks
            List<Drink> drinkList = drinkService.GetAllDrinks();

            //Add all drinks to the listview
            for (int i = 0; i < drinkList.Count; i++)
            {
                ListViewItem li = new ListViewItem(drinkList[i].Name);
                li.SubItems.Add(drinkList[i].Alcoholic.ToString());
                li.SubItems.Add(drinkList[i].Stock.ToString() + "x");

                //Tag is used to store the drink object
                li.Tag = drinkList[i];

                CP_Voorraad_listView.Items.Add(li);
            }

            // Create some column headers for the data. 
            columnheader = new ColumnHeader();
            columnheader.Text = "Naam";

            CP_Voorraad_listView.Columns.Add(columnheader);
            columnheader = new ColumnHeader();
            columnheader.Text = "Alcoholisch";
            CP_Voorraad_listView.Columns.Add(columnheader);

            columnheader = new ColumnHeader();
            columnheader.Text = "Voorraad";
            CP_Voorraad_listView.Columns.Add(columnheader);

            // Loop through and size each column header to fit the column header text.
            foreach (ColumnHeader ch in CP_Voorraad_listView.Columns)
            {
                ch.Width = -2;
            }

            //Keep track of the shown menu
            shownMenu = MenuType.Drinksmenu;

            //Select the first item in the listview
            if (CP_Voorraad_listView.Items.Count > 0)
                CP_Voorraad_listView.Items[0].Selected = true;

            //Change the text of the buttons
            CP_Voorraad_btnEditItem.Text = "Voorraad van drank aanpassen";
            CP_Voorraad_btnEmptyItem.Text = "Voorraad van drank legen";
        }

        //Load all lunch dishes into the Voorraad ListView
        private void LoadVoorraadLunch()
        {
            //Empty the ListView
            CP_Voorraad_listView.Clear();

            //Create a list of all the drinks
            List<Dish> lunchList = dishService.GetAllLunch();

            //Add all dishes to the listView
            for (int i = 0; i < lunchList.Count; i++)
            {
                ListViewItem li = new ListViewItem(lunchList[i].Name);
                li.SubItems.Add(lunchList[i].Category.ToString());
                li.SubItems.Add(lunchList[i].Stock.ToString() + "x");

                //Tag is used to store the dish object
                li.Tag = lunchList[i];

                CP_Voorraad_listView.Items.Add(li);
            }

            // Create some column headers for the data. 
            columnheader = new ColumnHeader();
            columnheader.Text = "Naam";
            CP_Voorraad_listView.Columns.Add(columnheader);

            columnheader = new ColumnHeader();
            columnheader.Text = "Categorie";
            CP_Voorraad_listView.Columns.Add(columnheader);

            columnheader = new ColumnHeader();
            columnheader.Text = "Voorraad";
            CP_Voorraad_listView.Columns.Add(columnheader);

            // Loop through and size each column header to fit the column header text.
            foreach (ColumnHeader ch in CP_Voorraad_listView.Columns)
            {
                ch.Width = -2;
            }

            //Keep track of the shown menu
            shownMenu = MenuType.Lunchmenu;

            //Select the first item in the listview
            if (CP_Voorraad_listView.Items.Count > 0)
                CP_Voorraad_listView.Items[0].Selected = true;

            //Change the text of the buttons
            CP_Voorraad_btnEditItem.Text = "Voorraad van gerecht aanpassen";
            CP_Voorraad_btnEmptyItem.Text = "Voorraad van gerecht legen";
        }

        //Load all dinner dishes into the Voorraad ListView
        private void LoadVoorraadDinner()
        {
            //Empty the listView
            CP_Voorraad_listView.Clear();

            //Create a list of dinner dishes
            List<Dish> dinnerList = dishService.GetAllDinner();

            //Add all dishes to the listView
            for (int i = 0; i < dinnerList.Count; i++)
            {
                ListViewItem li = new ListViewItem(dinnerList[i].Name);
                li.SubItems.Add(dinnerList[i].Category.ToString());
                li.SubItems.Add(dinnerList[i].Stock.ToString() + "x");

                //Tag is used to store the dish object
                li.Tag = dinnerList[i];

                CP_Voorraad_listView.Items.Add(li);
            }

            // Create some column headers for the data. 
            columnheader = new ColumnHeader();
            columnheader.Text = "Naam";
            CP_Voorraad_listView.Columns.Add(columnheader);

            columnheader = new ColumnHeader();
            columnheader.Text = "Categorie";
            CP_Voorraad_listView.Columns.Add(columnheader);

            columnheader = new ColumnHeader();
            columnheader.Text = "Voorraad";
            CP_Voorraad_listView.Columns.Add(columnheader);

            // Loop through and size each column header to fit the column header text.
            foreach (ColumnHeader ch in CP_Voorraad_listView.Columns)
            {
                ch.Width = -2;
            }

            //Keep track of the shown menu
            shownMenu = MenuType.Dinnermenu;

            //Select the first item in the listview
            if (CP_Voorraad_listView.Items.Count > 0)
                CP_Voorraad_listView.Items[0].Selected = true;

            //Change the text of the buttons
            CP_Voorraad_btnEditItem.Text = "Voorraad van gerecht aanpassen";
            CP_Voorraad_btnEmptyItem.Text = "Voorraad van gerecht legen";
        }

        //Determine what type of items to load
        private void LoadListViewVoorraad()
        {
            //Fill the list according to the shown menu
            if (shownMenu == MenuType.Dinnermenu)
                LoadVoorraadDinner();
            else if (shownMenu == MenuType.Lunchmenu)
                LoadVoorraadLunch();
            else
                LoadVoorraadDrinks();
        }

        #region OnClicks
        //Show all drinks 
        private void CP_Voorraad_btnDranken_Click(object sender, EventArgs e)
        {
            CP_Voorraad_btnDranken.BackColor = Color.FromArgb(0, 184, 255);
            CP_Voorraad_btnLunchgerechten.BackColor = CP_Voorraad_btnDinergerechten.BackColor = Color.FromArgb(0, 165, 229);

            LoadVoorraadDrinks();
        }

        //Show all lunch dishes
        private void CP_Voorraad_btnLunchgerechten_Click(object sender, EventArgs e)
        {
            CP_Voorraad_btnLunchgerechten.BackColor = Color.FromArgb(0, 184, 255);
            CP_Voorraad_btnDranken.BackColor = CP_Voorraad_btnDinergerechten.BackColor = Color.FromArgb(0, 165, 229);

            LoadVoorraadLunch();
        }

        //Show all diner dishes
        private void CP_Voorraad_btnDinergerechten_Click(object sender, EventArgs e)
        {
            CP_Voorraad_btnDinergerechten.BackColor = Color.FromArgb(0, 184, 255);
            CP_Voorraad_btnLunchgerechten.BackColor = CP_Voorraad_btnDranken.BackColor = Color.FromArgb(0, 165, 229);

            LoadVoorraadDinner();
        }

        //Sort the listview on a column when it is clicked
        private void CP_Voorraad_listView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            SortListView(e, CP_Voorraad_listView);
        }

        //Edit the stock of an item
        private void CP_Voorraad_btnEditItem_Click(object sender, EventArgs e)
        {
            //Make sure a single item is selected
            if (CP_Voorraad_listView.SelectedItems.Count != 1)
            {
                if (CP_Voorraad_listView.SelectedItems.Count > 1)
                    MessageBox.Show("U kunt maar van 1 item de voorraad tegelijk aanpassen", "Selecteer 1 item", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            //Show the popup for changing the stock
            CP_Popup_ChangeStock popup = new CP_Popup_ChangeStock((Item)CP_Voorraad_listView.SelectedItems[0].Tag);
            popup.ShowDialog();

            //When popup has been succesfully executed show feedback to the user and reload the listView
            if (popup.DialogResult == DialogResult.OK)
            {
                new CP_Feedback(((Item)CP_Voorraad_listView.SelectedItems[0].Tag).Name + " is succesvol geweizigd", 2500).Show();
                LoadListViewVoorraad();
            }
        }

        //Clear the stocks of an item
        private void CP_Voorraad_btnEmptyItem_Click(object sender, EventArgs e)
        {
            //Make sure a item is selected
            if (CP_Voorraad_listView.SelectedItems.Count == 0)
            {
                MessageBox.Show("U moet een item selecteren", "Selecteer 1 item", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Verify if the user really wants to clear these stocks
            CP_Popup_Sure popup = new CP_Popup_Sure();

            if (CP_Voorraad_listView.SelectedItems.Count > 1)
                popup.SetAsEmptyStock(CP_Voorraad_listView.SelectedItems.Count);
            else
            {
                if (((Item)CP_Voorraad_listView.SelectedItems[0].Tag).Stock == 0)
                    return;

                popup.SetAsEmptyStock(((Item)CP_Voorraad_listView.SelectedItems[0].Tag).Name);
            }

            //Show the popup and check if Ok is clickec
            popup.ShowDialog();

            if (!(popup.DialogResult == DialogResult.OK))
                return;

            //Empty all selected stocks of the shown menu
            if (shownMenu == MenuType.Drinksmenu)
                foreach (ListViewItem item in CP_Voorraad_listView.SelectedItems)
                {
                    drinkService.EmptyStock(((Drink)item.Tag).Id);
                }
            else
                foreach (ListViewItem item in CP_Voorraad_listView.SelectedItems)
                {
                    dishService.EmptyStock(((Dish)item.Tag).Id);
                }

            //Reload the voorraad list and give the user feedback
            new CP_Feedback("Voorraad(en) succesvol geleegd", 2500).Show();
            LoadListViewVoorraad();
        }

        //Gets called when the selected item in the listView changes
        private void CP_Voorraad_listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Make sure an item is selected
            //By default an item should be selected, but just to be sure and to avoid errors in future implementation
            if (!(CP_Voorraad_listView.SelectedItems.Count > 0))
                return;

            //If it is selected, enable the buttons
            CP_Voorraad_btnEditItem.Enabled = true;
            CP_Voorraad_btnEmptyItem.Enabled = true;

            CP_Voorraad_btnEditItem.BackColor = Color.FromArgb(0, 184, 255);
            CP_Voorraad_btnEmptyItem.BackColor = Color.Red;
        }

        //Sort the listview on a column when it is clicked
        private void CP_Voorraad_listView_ColumnClick_1(object sender, ColumnClickEventArgs e)
        {
            SortListView(e, CP_Voorraad_listView);
        }
        #endregion
        #endregion

        //Code for the Medewerker panel
        #region Medewerkers
        //Get a list of all the employees in the database
        private void LoadEmployeeList()
        {
            //Get the list
            List<Employee> employeeList = employeeService.GetAllEmployees();

            //Make sure the ListView is clear
            CP_Medewerkers_listView.Clear();

            //Add all of the items in the list to the listView
            for (int i = 0; i < employeeList.Count; i++)
            {
                ListViewItem li = new ListViewItem(employeeList[i].Id.ToString());
                li.SubItems.Add(employeeList[i].FirstName.ToString() + " " + employeeList[i].LastName.ToString());
                li.SubItems.Add(employeeList[i].Age.ToString());
                li.SubItems.Add(employeeList[i].Gender.ToShortString());
                li.SubItems.Add(employeeList[i].DateEmployment.ToString("dd-MM-yyyy"));
                li.SubItems.Add(employeeList[i].Password.ToString());
                li.SubItems.Add(employeeList[i].EmployeeType.ToDutchString());

                //Tag is used to store the employee object
                li.Tag = employeeList[i];

                CP_Medewerkers_listView.Items.Add(li);
            }

            // Create some column headers for the data. 
            columnheader = new ColumnHeader();
            columnheader.Text = "ID";
            CP_Medewerkers_listView.Columns.Add(columnheader);

            columnheader = new ColumnHeader();
            columnheader.Text = "Naam";
            CP_Medewerkers_listView.Columns.Add(columnheader);

            columnheader = new ColumnHeader();
            columnheader.Text = "Leeftijd";
            CP_Medewerkers_listView.Columns.Add(columnheader);

            columnheader = new ColumnHeader();
            columnheader.Text = "Geslacht";
            CP_Medewerkers_listView.Columns.Add(columnheader);

            columnheader = new ColumnHeader();
            columnheader.Text = "Indiensttreding";
            CP_Medewerkers_listView.Columns.Add(columnheader);

            columnheader = new ColumnHeader();
            columnheader.Text = "Wachtwoord";
            CP_Medewerkers_listView.Columns.Add(columnheader);

            columnheader = new ColumnHeader();
            columnheader.Text = "Rol";
            CP_Medewerkers_listView.Columns.Add(columnheader);

            // Loop through and size each column header to fit the column header text.
            foreach (ColumnHeader ch in CP_Medewerkers_listView.Columns)
            {
                ch.Width = -2;
            }

            //No item is selected after reloading, so dont make the buttons that require a selected item enabled
            CP_Medewerkers_btnEdit.Enabled = false;
            CP_Medewerkers_btnVerwijderen.Enabled = false;

            CP_Medewerkers_btnEdit.BackColor = Color.PaleTurquoise;
            CP_Medewerkers_btnVerwijderen.BackColor = Color.Salmon;

            //Select the first item in the listview
            if (CP_Medewerkers_listView.Items.Count > 0)
                CP_Medewerkers_listView.Items[0].Selected = true;
        }

        //All of the OnClick functions
        #region OnClicks

        //Called when an item is selected, so the buttons that require a selected item are enabled
        //By default an item should be selected, but just to be sure and to avoid errors in future implementation
        private void CP_Medewerkers_listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Make sure an item is selected
            if (!(CP_Medewerkers_listView.SelectedItems.Count > 0))
                return;

            //Enable the buttons when an item is selected in the listView
            CP_Medewerkers_btnEdit.Enabled = true;
            CP_Medewerkers_btnVerwijderen.Enabled = true;

            CP_Medewerkers_btnEdit.BackColor = Color.FromArgb(0, 184, 255);
            CP_Medewerkers_btnVerwijderen.BackColor = Color.Red;
        }

        //Sort the listview on a column when it is clicked
        private void CP_Medewerkers_listView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            SortListView(e, CP_Medewerkers_listView);
        }

        //Remove the selected employee(s)
        private void CP_Medewerkers_btnVerwijderen_Click(object sender, EventArgs e)
        {
            //Make sure an employee is selected
            if (CP_Medewerkers_listView.SelectedItems.Count == 0)
            {
                MessageBox.Show("U moet een medewerker selecteren", "Selecteer 1 medewerker", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Verify if the user really wants to remove these items
            CP_Popup_Sure popup = new CP_Popup_Sure();
            if (CP_Medewerkers_listView.SelectedItems.Count > 1)
                popup.SetAsRemoveEmployee(CP_Medewerkers_listView.SelectedItems.Count);
            else
                popup.SetAsRemoveEmployee(((Employee)CP_Medewerkers_listView.SelectedItems[0].Tag).FirstName);

            popup.ShowDialog();

            if (!(popup.DialogResult == DialogResult.OK))
                return;

            //Remove all selected employee's
            foreach (ListViewItem item in CP_Medewerkers_listView.SelectedItems)
            {
                bool success = int.TryParse(item.Text, out int id);
                if (success)
                    employeeService.DeleteEmployee(id);
            }

            //Show the succesfull bar
            new CP_Feedback("Medewerker(s) succesvol verwijderd", 2500).Show();

            //Reload the employee list
            LoadEmployeeList();
        }

        //Edit the selected employee
        private void CP_Medewerkers_btnEdit_Click(object sender, EventArgs e)
        {
            //Make sure a single item is selected
            if (CP_Medewerkers_listView.SelectedItems.Count != 1)
            {
                if (CP_Medewerkers_listView.SelectedItems.Count > 1)
                    MessageBox.Show("U kunt maar 1 medewerker tegelijk aanpassen", "Selecteer 1 medewerker", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            //Show the popup for editing an employee
            CP_Popup_EditEmployee popup = new CP_Popup_EditEmployee((Employee)CP_Medewerkers_listView.SelectedItems[0].Tag);
            popup.ShowDialog();

            //If the user presses Ok show feedback and reload the listView
            if (popup.DialogResult == DialogResult.OK)
            {
                new CP_Feedback(((Employee)CP_Medewerkers_listView.SelectedItems[0].Tag).FirstName + " is succesvol geweizigd", 2500).Show();
                LoadEmployeeList();
            }
        }

        //Add a new employee
        private void CP_Medewerkers_btnNieuweMedewerker_Click(object sender, EventArgs e)
        {
            //Show the popup for adding an employee
            CP_Popup_NewEmployee popup = new CP_Popup_NewEmployee();
            popup.ShowDialog();

            //If the user presses Ok in the popup show feedback and reload the listView
            if (popup.DialogResult == DialogResult.OK)
            {
                new CP_Feedback("Nieuwe medewerker succesvol toegevoegd", 2500).Show();
                LoadEmployeeList();
            }
        }
        #endregion
        #endregion

        //Code for the Menukaarten panel
        #region Menukaarten
        //Load all drinks into the menukaarten listView
        private void LoadMenukaartenDrinks()
        {
            //Empty the listView
            CP_Menukaarten_listView.Clear();

            //Get a list of all drinks
            List<Drink> drinkList = drinkService.GetAllDrinks();

            //Fill the listView with drinks
            for (int i = 0; i < drinkList.Count; i++)
            {
                ListViewItem li = new ListViewItem(drinkList[i].Name);
                li.SubItems.Add(drinkList[i].Alcoholic.ToString());
                li.SubItems.Add(drinkList[i].Price.ToString("0.00"));

                //Tag is used to store the Drink Object
                li.Tag = drinkList[i];

                CP_Menukaarten_listView.Items.Add(li);
            }

            // Create some column headers for the data. 
            columnheader = new ColumnHeader();
            columnheader.Text = "Naam";
            CP_Menukaarten_listView.Columns.Add(columnheader);

            columnheader = new ColumnHeader();
            columnheader.Text = "Alcoholisch";
            CP_Menukaarten_listView.Columns.Add(columnheader);

            columnheader = new ColumnHeader();
            columnheader.Text = "Prijs";
            CP_Menukaarten_listView.Columns.Add(columnheader);

            // Loop through and size each column header to fit the column header text.
            foreach (ColumnHeader ch in CP_Menukaarten_listView.Columns)
            {
                ch.Width = -2;
            }

            //Keep track of what type of menu is shown
            shownMenu = MenuType.Drinksmenu;

            //Select the first item in the listview
            if (CP_Menukaarten_listView.Items.Count > 0)
                CP_Menukaarten_listView.Items[0].Selected = true;

            //Change the text of the buttons
            CP_Menukaarten_btnNewItem.Text = "Nieuwe drank toevoegen";
            CP_Menukaarten_btnEditItem.Text = "Drank aanpassen";
        }

        //Load all lunch dishes into the menukaarten listView
        private void LoadMenukaartenLunch()
        {
            //Empty the listView
            CP_Menukaarten_listView.Clear();

            //Get a list of all lunch dishes
            List<Dish> lunchList = dishService.GetAllLunch();

            //Fill the listView with lunchDishes
            for (int i = 0; i < lunchList.Count; i++)
            {
                ListViewItem li = new ListViewItem(lunchList[i].Name);
                li.SubItems.Add(lunchList[i].Description);
                li.SubItems.Add(lunchList[i].Ingredients);
                li.SubItems.Add(lunchList[i].Category.ToString());
                li.SubItems.Add(lunchList[i].Price.ToString("0.00"));

                //Tag is used to store the Dish Object
                li.Tag = lunchList[i];

                CP_Menukaarten_listView.Items.Add(li);
            }

            // Create some column headers for the data. 
            columnheader = new ColumnHeader();
            columnheader.Text = "Naam";
            CP_Menukaarten_listView.Columns.Add(columnheader);

            columnheader = new ColumnHeader();
            columnheader.Text = "Omschrijving";
            CP_Menukaarten_listView.Columns.Add(columnheader);

            columnheader = new ColumnHeader();
            columnheader.Text = "Ingredienten";
            CP_Menukaarten_listView.Columns.Add(columnheader);

            columnheader = new ColumnHeader();
            columnheader.Text = "Prijs";
            CP_Menukaarten_listView.Columns.Add(columnheader);

            columnheader = new ColumnHeader();
            columnheader.Text = "Categorie";
            CP_Menukaarten_listView.Columns.Add(columnheader);

            // Loop through and size each column header to fit the column header text.
            foreach (ColumnHeader ch in CP_Menukaarten_listView.Columns)
            {
                ch.Width = -2;
            }

            //Keep track of what type of menu is shown
            shownMenu = MenuType.Lunchmenu;

            //Select the first item in the listview
            if (CP_Menukaarten_listView.Items.Count > 0)
                CP_Menukaarten_listView.Items[0].Selected = true;

            //Change the text of the buttons
            CP_Menukaarten_btnNewItem.Text = "Nieuw gerecht toevoegen";
            CP_Menukaarten_btnEditItem.Text = "Gerecht aanpassen";
        }

        //Load all dinner dishes into the menukaarten listView
        private void LoadMenukaartenDinner()
        {
            //Clear the listView
            CP_Menukaarten_listView.Clear();

            //Get a list of all dinner dishes
            List<Dish> dinnerList = dishService.GetAllDinner();

            //Fill the listview with the dinnerlist
            for (int i = 0; i < dinnerList.Count; i++)
            {
                ListViewItem li = new ListViewItem(dinnerList[i].Name);
                li.SubItems.Add(dinnerList[i].Description);
                li.SubItems.Add(dinnerList[i].Ingredients);
                li.SubItems.Add(dinnerList[i].Category.ToString());
                li.SubItems.Add("€" + dinnerList[i].Price.ToString("0.00"));

                //Tag is used to store the Dish Object
                li.Tag = dinnerList[i];

                CP_Menukaarten_listView.Items.Add(li);
            }

            // Create some column headers for the data. 
            columnheader = new ColumnHeader();
            columnheader.Text = "Naam";
            CP_Menukaarten_listView.Columns.Add(columnheader);

            columnheader = new ColumnHeader();
            columnheader.Text = "Omschrijving";
            CP_Menukaarten_listView.Columns.Add(columnheader);

            columnheader = new ColumnHeader();
            columnheader.Text = "Ingredienten";
            CP_Menukaarten_listView.Columns.Add(columnheader);

            columnheader = new ColumnHeader();
            columnheader.Text = "Categorie";
            CP_Menukaarten_listView.Columns.Add(columnheader);

            columnheader = new ColumnHeader();
            columnheader.Text = "Prijs";
            CP_Menukaarten_listView.Columns.Add(columnheader);

            // Loop through and size each column header to fit the column header text.
            foreach (ColumnHeader ch in CP_Menukaarten_listView.Columns)
            {
                ch.Width = -2;
            }

            //Keep track of what type of menu is shown
            shownMenu = MenuType.Dinnermenu;

            //Select the first item in the listview
            if (CP_Menukaarten_listView.Items.Count > 0)
                CP_Menukaarten_listView.Items[0].Selected = true;

            //Change the text of the buttons
            CP_Menukaarten_btnNewItem.Text = "Nieuw gerecht toevoegen";
            CP_Menukaarten_btnEditItem.Text = "Gerecht aanpassen";
        }

        //Determine what type of items to load
        private void LoadListViewMenus()
        {
            if (shownMenu == MenuType.Dinnermenu)
                LoadMenukaartenDinner();
            else if (shownMenu == MenuType.Lunchmenu)
                LoadMenukaartenLunch();
            else
                LoadMenukaartenDrinks();
        }

        #region OnClicks
        private void CP_Menukaarten_listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Make sure an item is selected
            //By default an item should be selected, but just to be sure and to avoid errors in future implementation
            if (!(CP_Menukaarten_listView.SelectedItems.Count > 0))
                return;

            //Enable the buttons when an item is selected
            CP_Menukaarten_btnEditItem.Enabled = true;
            CP_Menukaarten_btnDeleteItem.Enabled = true;

            CP_Menukaarten_btnEditItem.BackColor = Color.FromArgb(0, 184, 255);
            CP_Menukaarten_btnDeleteItem.BackColor = Color.Red;
        }

        //Show all drinks
        private void CP_Menukaarten_btnDranken_Click(object sender, EventArgs e)
        {
            CP_Menukaarten_btnDranken.BackColor = Color.FromArgb(0, 184, 255);
            CP_Menukaarten_btnLunchgerechten.BackColor = CP_Menukaarten_btnDinergerechten.BackColor = Color.FromArgb(0, 165, 229);

            LoadMenukaartenDrinks();
        }

        //Show all lunch dishes
        private void CP_Menukaarten_btnLunchgerechten_Click(object sender, EventArgs e)
        {
            CP_Menukaarten_btnLunchgerechten.BackColor = Color.FromArgb(0, 184, 255);
            CP_Menukaarten_btnDranken.BackColor = CP_Menukaarten_btnDinergerechten.BackColor = Color.FromArgb(0, 165, 229);

            LoadMenukaartenLunch();
        }

        //Show all dinner dishes
        private void CP_Menukaarten_btnDinergerechten_Click(object sender, EventArgs e)
        {
            CP_Menukaarten_btnDinergerechten.BackColor = Color.FromArgb(0, 184, 255);
            CP_Menukaarten_btnLunchgerechten.BackColor = CP_Menukaarten_btnDranken.BackColor = Color.FromArgb(0, 165, 229);

            LoadMenukaartenDinner();
        }

        //Add a new dish to the menu
        private void CP_Menukaarten_btnNewItem_Click(object sender, EventArgs e)
        {
            //Show a popup for adding a drink or adding a dish in the shown menu
            CP_Popup_Parent popup;
            if (shownMenu == MenuType.Drinksmenu)
                popup = new CP_Popup_AddToDrinksMenu();
            else
                popup = new CP_Popup_AddToMenu(shownMenu);

            popup.ShowDialog();

            //Reload the menu list when the dialog is succesful
            if (popup.DialogResult == DialogResult.OK)
            {
                new CP_Feedback("Nieuw item succesvol toegevoegd", 2500).Show();
                LoadListViewMenus();
            }
        }

        //Edit a dish in the menu
        private void CP_Menukaarten_btnEditItem_Click(object sender, EventArgs e)
        {
            //Make sure a single item is selected
            if (CP_Menukaarten_listView.SelectedItems.Count != 1)
            {
                if (CP_Menukaarten_listView.SelectedItems.Count > 1)
                    MessageBox.Show("U kunt maar 1 item tegelijk aanpassen", "Selecteer 1 item", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            //Show a popup for editing a drink or editing a dish in the shown menu
            CP_Popup_Parent popup;
            if (shownMenu == MenuType.Drinksmenu)
                popup = new CP_Popup_EditDrinksMenu((Drink)CP_Menukaarten_listView.SelectedItems[0].Tag);
            else
                popup = new CP_Popup_EditMenu((Dish)CP_Menukaarten_listView.SelectedItems[0].Tag);

            popup.ShowDialog();

            //Reload the menu list when the dialog is succesful
            if (popup.DialogResult == DialogResult.OK)
            {
                new CP_Feedback(((Item)CP_Menukaarten_listView.SelectedItems[0].Tag).Name + " is succesvol geweizigd", 2500).Show();
                LoadListViewMenus();
            }
        }

        //Remove 1 or more items from the menu
        private void CP_Menukaarten_btnDeleteItem_Click(object sender, EventArgs e)
        {
            //Make sure a single item is selected
            if (CP_Menukaarten_listView.SelectedItems.Count == 0)
            {
                MessageBox.Show("U moet een item selecteren", "Selecteer 1 item", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Verify if the user really wants to remove these items
            CP_Popup_Sure popup = new CP_Popup_Sure();
            if (CP_Menukaarten_listView.SelectedItems.Count > 1)
            {
                if (shownMenu == MenuType.Drinksmenu)
                    popup.SetAsRemoveDrink(CP_Menukaarten_listView.SelectedItems.Count);
                else
                    popup.SetAsRemoveDish(CP_Menukaarten_listView.SelectedItems.Count);
            }
            else
            {
                if (shownMenu == MenuType.Drinksmenu)
                    popup.SetAsRemoveDrink(((Drink)CP_Menukaarten_listView.SelectedItems[0].Tag).Name);
                else
                    popup.SetAsRemoveDish(((Dish)CP_Menukaarten_listView.SelectedItems[0].Tag).Name);
            }

            popup.ShowDialog();

            if (!(popup.DialogResult == DialogResult.OK))
                return;

            //Remove all selected items
            if (shownMenu == MenuType.Drinksmenu)
                foreach (ListViewItem item in CP_Menukaarten_listView.SelectedItems)
                {
                    drinkService.RemoveDrink(((Drink)item.Tag).Id);
                }
            else
                foreach (ListViewItem item in CP_Menukaarten_listView.SelectedItems)
                {
                    dishService.RemoveDish(((Dish)item.Tag).Id);
                }

            //Reload the menu list
            new CP_Feedback("Item(s) succesvol verwijderd", 2500).Show();
            LoadListViewMenus();
        }
        #endregion
        #endregion

        #region Inkomsten
        //Code used for the Inkomsten panel
        private void LoadRevenueBetweenDates(DateTime from, DateTime to)
        {
            LoadRevenueFromList(billService.GetAllBetweenDates(from, to));
        }

        //Function is unnecesary but helps with readability
        private void LoadRevenue()
        {
            LoadRevenueFromList(billService.GetAllBills());
        }

        //Load the revenue from these bills
        private void LoadRevenueFromList(List<Bill> billList)
        {
            //Clear the listview
            CP_Inkomsten_listView.Clear();

            //A dictionary is used for each row, the key is the date of the order
            Dictionary<DateTime, RevenueRow> rows = new Dictionary<DateTime, RevenueRow>();

            //Get all dinner and lunch dishes
            List<Dish> dinnerDishes = dishService.GetAllDinner();
            List<Dish> lunchDishes = dishService.GetAllLunch();

            //Merge the bills into the format for the Revenue listView
            for (int i = 0; i < billList.Count; i++)
            {
                //Check there already is an orde for this date
                if (rows.ContainsKey(billList[i].Date))
                {
                    //Loop through all the orders of the bill
                    foreach (Order order in billList[i].Orders)
                    {
                        rows[billList[i].Date].OrderCount++;

                        //Loop through all the dishes and drinks, and add their prices to the total values
                        foreach (Dish dish in order.Dishes)
                        {
                            if (dinnerDishes.Contains(dish))
                                rows[billList[i].Date].TotalDinner += dish.Price;
                            else if (lunchDishes.Contains(dish))
                                rows[billList[i].Date].TotalLunch += dish.Price;
                        }

                        foreach (Drink drink in order.Drinks)
                        {
                            rows[billList[i].Date].TotalDrinks += drink.Price;
                        }
                    }
                } //If there is not yet a row with this date try to add a new one
                else
                {
                    RevenueRow revenueRow = new RevenueRow();

                    //Loop through all the orders of the bill
                    foreach (Order order in billList[i].Orders)
                    {
                        revenueRow.OrderCount++;

                        //Loop through all the dishes and drinks, and add their prices to the total values
                        foreach (Dish dish in order.Dishes)
                        {
                            if (dinnerDishes.Contains(dish))
                                revenueRow.TotalDinner += dish.Price;
                            else if (lunchDishes.Contains(dish))
                                revenueRow.TotalLunch += dish.Price;
                        }

                        foreach (Drink drink in order.Drinks)
                        {
                            revenueRow.TotalDrinks += drink.Price;
                        }
                    }

                    //Only add a new row if the orders actually contained items
                    if (revenueRow.Total > 0)
                        rows.Add(billList[i].Date, revenueRow);
                }
            }

            //Create a new list item for each row
            foreach (KeyValuePair<DateTime, RevenueRow> kvp in rows)
            {
                ListViewItem li = new ListViewItem(kvp.Key.Date.ToString("dd/MM/yyyy"));
                li.SubItems.Add(kvp.Value.OrderCount.ToString());
                li.SubItems.Add("€" + kvp.Value.TotalDrinks.ToString("0.00"));
                li.SubItems.Add("€" + kvp.Value.TotalLunch.ToString("0.00"));
                li.SubItems.Add("€" + kvp.Value.TotalDinner.ToString("0.00"));
                li.SubItems.Add("€" + kvp.Value.Total.ToString("0.00"));

                CP_Inkomsten_listView.Items.Add(li);
            }

            // Create some column headers for the data. 
            columnheader = new ColumnHeader();
            columnheader.Text = "Datum";
            CP_Inkomsten_listView.Columns.Add(columnheader);

            columnheader = new ColumnHeader();
            columnheader.Text = "Aantal orders";
            CP_Inkomsten_listView.Columns.Add(columnheader);

            columnheader = new ColumnHeader();
            columnheader.Text = "Totaal dranken";
            CP_Inkomsten_listView.Columns.Add(columnheader);

            columnheader = new ColumnHeader();
            columnheader.Text = "Totaal lunch";
            CP_Inkomsten_listView.Columns.Add(columnheader);

            columnheader = new ColumnHeader();
            columnheader.Text = "Totaal diner";
            CP_Inkomsten_listView.Columns.Add(columnheader);

            columnheader = new ColumnHeader();
            columnheader.Text = "Totaal";
            CP_Inkomsten_listView.Columns.Add(columnheader);

            // Loop through and size each column header to fit the column header text.
            foreach (ColumnHeader ch in CP_Inkomsten_listView.Columns)
            {
                ch.Width = -2;
            }
        }

        #region OnClicks
        //Apply the date filter
        private void CP_Inkomsten_btnApply_Click(object sender, EventArgs e)
        {
            LoadRevenueBetweenDates(CP_Inkomsten_dtpVan.Value, CP_Inkomsten_dtpTot.Value);
        }

        //Sort the listview on a column when it is clicked
        private void CP_Inkomsten_listView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            SortListView(e, CP_Inkomsten_listView);
        }
        #endregion
        #endregion

        //Code used by multiple panels
        #region General
        //Sort the items of this list view based on the selected column
        private void SortListView(ColumnClickEventArgs e, ListView lv)
        {
            // Determine if clicked column is already the column that is being sorted.
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                if (lvwColumnSorter.Order == SortOrder.Ascending)
                    lvwColumnSorter.Order = SortOrder.Descending;
                else
                    lvwColumnSorter.Order = SortOrder.Ascending;
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }

            lv.Sort();
        }

        //Makes sure all the listviews are setup properly
        private void InitializeSorting()
        {
            //View has to be set to details in order to show column headers
            //The sorter has to be set to our custom sorter
            CP_Voorraad_listView.View = View.Details;
            CP_Voorraad_listView.ListViewItemSorter = lvwColumnSorter;

            CP_Medewerkers_listView.View = View.Details;
            CP_Medewerkers_listView.ListViewItemSorter = lvwColumnSorter;

            CP_Menukaarten_listView.View = View.Details;
            CP_Menukaarten_listView.ListViewItemSorter = lvwColumnSorter;

            CP_Inkomsten_listView.View = View.Details;
            CP_Inkomsten_listView.ListViewItemSorter = lvwColumnSorter;
        }

        //Hide all the panels
        private void HideAllPanels()
        {
            CP_pnlVoorraad.Hide();
            CP_pnlMedewerkers.Hide();
            CP_pnlMenukaarten.Hide();
            CP_pnlInkomsten.Hide();
        }

        //Highlight the selected button
        private void SetHightlight(Button btn)
        {
            CP_btnVoorraad.BackColor = CP_btnMenukaarten.BackColor
            = CP_btnInkomsten.BackColor = CP_btnMedewerkers.BackColor = CP_btnUitloggen.BackColor = Color.FromArgb(0, 165, 229);

            btn.BackColor = Color.FromArgb(0, 184, 255);
        }
        #endregion
    }
}