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

        //Var used to create new columnHeader for the listView sorter
        private ColumnHeader columnheader;

        public ControlPanelForm()
        {
            InitializeComponent();

            //Hide all the existing panels on startup
            HideAllPanels();
            //Make sure all the listviews are setup properly
            InitializeSorting();
        }

        //Code for the navmenu
        #region NavMenu
        private void CP_btnHome_Click(object sender, EventArgs e)
        {
            SetHightlight(CP_btnHome);
            CP_lblActivePanel.Text = "Home";
            HideAllPanels();
        }

        private void CP_btnVoorraad_Click(object sender, EventArgs e)
        {
            LoadVoorraadDrinks();

            SetHightlight(CP_btnVoorraad);
            CP_lblActivePanel.Text = "Voorraad";
            HideAllPanels();
            CP_pnlVoorraad.Show();
        }

        private void CP_btnMenukaarten_Click(object sender, EventArgs e)
        {
            LoadMenukaartenDrinks();

            SetHightlight(CP_btnMenukaarten);
            CP_lblActivePanel.Text = "Menukaarten";
            HideAllPanels();
            CP_pnlMenukaarten.Show();
        }

        private void CP_btnBestellingen_Click(object sender, EventArgs e)
        {
            SetHightlight(CP_btnBestellingen);
            CP_lblActivePanel.Text = "Bestellingen";
            HideAllPanels();
        }

        private void CP_btnInkomsten_Click(object sender, EventArgs e)
        {
            SetHightlight(CP_btnInkomsten);
            CP_lblActivePanel.Text = "Inkomsten";
            HideAllPanels();
        }

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
            SetHightlight(CP_btnUitloggen);
            Close();
            Owner.Show();
        }
        #endregion

        //Code for the Voorraad panel
        #region Voorraad
        private void LoadVoorraadDrinks()
        {
            CP_Voorraad_listView.Clear();

            List<Drink> drinkList = drinkService.GetAllDrinks();

            for (int i = 0; i < drinkList.Count; i++)
            {
                ListViewItem li = new ListViewItem(drinkList[i].Id.ToString());
                li.SubItems.Add(drinkList[i].Name);
                li.SubItems.Add(drinkList[i].Alcoholic.ToString());
                li.SubItems.Add(drinkList[i].Price.ToString());
                li.SubItems.Add(drinkList[i].Stock.ToString());

                CP_Voorraad_listView.Items.Add(li);
            }

            // Create some column headers for the data. 
            columnheader = new ColumnHeader();
            columnheader.Text = "ID";
            CP_Voorraad_listView.Columns.Add(columnheader);

            columnheader = new ColumnHeader();
            columnheader.Text = "Naam";
            CP_Voorraad_listView.Columns.Add(columnheader);

            columnheader = new ColumnHeader();
            columnheader.Text = "Alcoholisch";
            CP_Voorraad_listView.Columns.Add(columnheader);

            columnheader = new ColumnHeader();
            columnheader.Text = "Prijs";
            CP_Voorraad_listView.Columns.Add(columnheader);

            columnheader = new ColumnHeader();
            columnheader.Text = "Voorraad";
            CP_Voorraad_listView.Columns.Add(columnheader);

            // Loop through and size each column header to fit the column header text.
            foreach (ColumnHeader ch in CP_Voorraad_listView.Columns)
            {
                ch.Width = -2;
            }
        }

        private void LoadVoorraadLunch()
        {
            CP_Voorraad_listView.Clear();

            List<Dish> lunchList = dishService.GetAllLunch();

            for (int i = 0; i < lunchList.Count; i++)
            {
                //@TODO: Add category
                ListViewItem li = new ListViewItem(lunchList[i].Id.ToString());
                li.SubItems.Add(lunchList[i].Name);
                li.SubItems.Add(lunchList[i].Description);
                li.SubItems.Add(lunchList[i].Ingredients);
                li.SubItems.Add(lunchList[i].Price.ToString());
                li.SubItems.Add(lunchList[i].Stock.ToString());
                li.SubItems.Add(lunchList[i].Category.ToString());

                CP_Voorraad_listView.Items.Add(li);
            }

            // Create some column headers for the data. 
            columnheader = new ColumnHeader();
            columnheader.Text = "ID";
            CP_Voorraad_listView.Columns.Add(columnheader);

            columnheader = new ColumnHeader();
            columnheader.Text = "Naam";
            CP_Voorraad_listView.Columns.Add(columnheader);

            columnheader = new ColumnHeader();
            columnheader.Text = "Beschrijving";
            CP_Voorraad_listView.Columns.Add(columnheader);

            columnheader = new ColumnHeader();
            columnheader.Text = "Ingredienten";
            CP_Voorraad_listView.Columns.Add(columnheader);

            columnheader = new ColumnHeader();
            columnheader.Text = "Prijs";
            CP_Voorraad_listView.Columns.Add(columnheader);

            columnheader = new ColumnHeader();
            columnheader.Text = "Voorraad";
            CP_Voorraad_listView.Columns.Add(columnheader);

            columnheader = new ColumnHeader();
            columnheader.Text = "Categorie";
            CP_Voorraad_listView.Columns.Add(columnheader);

            // Loop through and size each column header to fit the column header text.
            foreach (ColumnHeader ch in CP_Voorraad_listView.Columns)
            {
                ch.Width = -2;
            }
        }

        private void LoadVoorraadDinner()
        {
            CP_Voorraad_listView.Clear();

            List<Dish> dinnerList = dishService.GetAllDinner();

            for (int i = 0; i < dinnerList.Count; i++)
            {
                //@TODO: Add category
                ListViewItem li = new ListViewItem(dinnerList[i].Id.ToString());
                li.SubItems.Add(dinnerList[i].Name);
                li.SubItems.Add(dinnerList[i].Description);
                li.SubItems.Add(dinnerList[i].Ingredients);
                li.SubItems.Add(dinnerList[i].Price.ToString());
                li.SubItems.Add(dinnerList[i].Stock.ToString());
                li.SubItems.Add(dinnerList[i].Category.ToString());

                CP_Voorraad_listView.Items.Add(li);
            }

            // Create some column headers for the data. 
            columnheader = new ColumnHeader();
            columnheader.Text = "ID";
            CP_Voorraad_listView.Columns.Add(columnheader);

            columnheader = new ColumnHeader();
            columnheader.Text = "Naam";
            CP_Voorraad_listView.Columns.Add(columnheader);

            columnheader = new ColumnHeader();
            columnheader.Text = "Beschrijving";
            CP_Voorraad_listView.Columns.Add(columnheader);

            columnheader = new ColumnHeader();
            columnheader.Text = "Ingredienten";
            CP_Voorraad_listView.Columns.Add(columnheader);

            columnheader = new ColumnHeader();
            columnheader.Text = "Prijs";
            CP_Voorraad_listView.Columns.Add(columnheader);

            columnheader = new ColumnHeader();
            columnheader.Text = "Voorraad";
            CP_Voorraad_listView.Columns.Add(columnheader);

            columnheader = new ColumnHeader();
            columnheader.Text = "Categorie";
            CP_Voorraad_listView.Columns.Add(columnheader);

            // Loop through and size each column header to fit the column header text.
            foreach (ColumnHeader ch in CP_Voorraad_listView.Columns)
            {
                ch.Width = -2;
            }
        }

        #region OnClicks
        private void CP_Voorraad_btnDranken_Click(object sender, EventArgs e)
        {
            CP_Voorraad_btnDranken.BackColor = Color.FromArgb(0, 184, 255);
            CP_Voorraad_btnLunchgerechten.BackColor = CP_Voorraad_btnDinergerechten.BackColor = Color.FromArgb(0, 165, 229);

            LoadVoorraadDrinks();
        }

        private void CP_Voorraad_btnLunchgerechten_Click(object sender, EventArgs e)
        {
            CP_Voorraad_btnLunchgerechten.BackColor = Color.FromArgb(0, 184, 255);
            CP_Voorraad_btnDranken.BackColor = CP_Voorraad_btnDinergerechten.BackColor = Color.FromArgb(0, 165, 229);

            LoadVoorraadLunch();
        }

        private void CP_Voorraad_btnDinergerechten_Click(object sender, EventArgs e)
        {
            CP_Voorraad_btnDinergerechten.BackColor = Color.FromArgb(0, 184, 255);
            CP_Voorraad_btnLunchgerechten.BackColor = CP_Voorraad_btnDranken.BackColor = Color.FromArgb(0, 165, 229);

            LoadVoorraadDinner();
        }
        private void CP_Voorraad_listView_ColumnClick(object sender, ColumnClickEventArgs e)
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
                li.SubItems.Add(employeeList[i].FirstName.ToString());
                li.SubItems.Add(employeeList[i].LastName.ToString());
                li.SubItems.Add(employeeList[i].BirthDate.ToString());
                li.SubItems.Add(employeeList[i].Gender.ToString());
                li.SubItems.Add(employeeList[i].DateEmployment.ToString());
                li.SubItems.Add(employeeList[i].Password.ToString());
                li.SubItems.Add(employeeList[i].EmployeeType.ToString());

                CP_Medewerkers_listView.Items.Add(li);
            }

            // Create some column headers for the data. 
            columnheader = new ColumnHeader();
            columnheader.Text = "ID";
            CP_Medewerkers_listView.Columns.Add(columnheader);

            columnheader = new ColumnHeader();
            columnheader.Text = "Voornaam";
            CP_Medewerkers_listView.Columns.Add(columnheader);

            columnheader = new ColumnHeader();
            columnheader.Text = "Achternaam";
            CP_Medewerkers_listView.Columns.Add(columnheader);

            columnheader = new ColumnHeader();
            columnheader.Text = "Geboortedatum";
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
        }

        //All of the OnClick functions
        #region OnClicks

        //Called when an item is selected, so the buttons that require a selected item are enabled
        private void CP_Medewerkers_listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            CP_Medewerkers_btnEdit.Enabled = true;
            CP_Medewerkers_btnVerwijderen.Enabled = true;

            CP_Medewerkers_btnEdit.BackColor = Color.FromArgb(0, 184, 255);
            CP_Medewerkers_btnVerwijderen.BackColor = Color.Red;
        }

        //Sort the selected column
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
            Form popup = new CP_Popup_Sure(CP_Medewerkers_listView.SelectedItems.Count);
            popup.ShowDialog();

            if (!(popup.DialogResult == DialogResult.OK))
                return;

            //Remove all selected employee's
            foreach (ListViewItem item in CP_Medewerkers_listView.SelectedItems){
                bool success = int.TryParse(item.Text, out int id);
                if(success)
                    employeeService.DeleteEmployee(id);
            }

            //Reload the employee list
            LoadEmployeeList();
        }

        private void CP_Medewerkers_btnEdit_Click(object sender, EventArgs e)
        {
            //Make sure a single item is selected
            if (CP_Medewerkers_listView.SelectedItems.Count != 1)
            {
                if (CP_Medewerkers_listView.SelectedItems.Count > 1)
                    MessageBox.Show("U kunt maar 1 medewerker tegelijk aanpassen", "Selecteer 1 medewerker", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            ListViewItem item = CP_Medewerkers_listView.SelectedItems[0];

            int id = int.Parse(item.SubItems[0].Text);
            string firstName = item.SubItems[1].Text;
            string lastName = item.SubItems[2].Text;
            DateTime birthDate = Convert.ToDateTime(item.SubItems[3].Text);
            bool genderParsed = Enum.TryParse(item.SubItems[4].Text, out Gender gender);
            DateTime employment = Convert.ToDateTime(item.SubItems[5].Text);
            string password = item.SubItems[6].Text;
            bool typeParsed = Enum.TryParse(item.SubItems[7].Text, out EmployeeType employeeType);

            if(!genderParsed || !typeParsed)
            {
                if (!genderParsed)
                    ErrorHandler.Instance.HandleError("Het geslacht van " + firstName + " bestaat niet", "Onbekend geslacht", new ArgumentException());
                if (!typeParsed)
                    ErrorHandler.Instance.HandleError("Het medewerker type van " + firstName + " bestaat niet", "Onbekend medewerker type", new ArgumentException());

                return;
            }

            Form popup = new CP_Popup_EditEmployee(id, firstName, lastName, birthDate, employment, gender, password, employeeType);

            popup.ShowDialog();

            if (popup.DialogResult == DialogResult.OK)
                LoadEmployeeList();
        }

        private void CP_Medewerkers_btnNieuweMedewerker_Click(object sender, EventArgs e)
        {
            Form popup = new CP_Popup_NewEmployee();

            popup.ShowDialog();

            if (popup.DialogResult == DialogResult.OK)
                LoadEmployeeList();
        }

        #endregion
        #endregion

        //Code for the Menukaarten panel
        #region Menukaarten
        private void LoadMenukaartenDrinks()
        {
            CP_Menukaarten_listView.Clear();

            List<Drink> drinkList = drinkService.GetAllDrinks();

            for (int i = 0; i < drinkList.Count; i++)
            {
                ListViewItem li = new ListViewItem(drinkList[i].Name);
                li.SubItems.Add(drinkList[i].Alcoholic.ToString());
                li.SubItems.Add(drinkList[i].Price.ToString());

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
        }

        private void LoadMenukaartenLunch()
        {
            CP_Menukaarten_listView.Clear();

            List<Dish> lunchList = dishService.GetAllLunch();

            for (int i = 0; i < lunchList.Count; i++)
            {
                //@TODO: Add category
                ListViewItem li = new ListViewItem(lunchList[i].Name);
                li.SubItems.Add(lunchList[i].Description);
                li.SubItems.Add(lunchList[i].Ingredients);
                li.SubItems.Add(lunchList[i].Price.ToString());
                li.SubItems.Add(lunchList[i].Category.ToString());

                CP_Menukaarten_listView.Items.Add(li);
            }

            // Create some column headers for the data. 
            columnheader = new ColumnHeader();
            columnheader.Text = "Naam";
            CP_Menukaarten_listView.Columns.Add(columnheader);

            columnheader = new ColumnHeader();
            columnheader.Text = "Beschrijving";
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
        }

        private void LoadMenukaartenDinner()
        {
            CP_Menukaarten_listView.Clear();

            List<Dish> dinnerList = dishService.GetAllDinner();

            for (int i = 0; i < dinnerList.Count; i++)
            {
                //@TODO: Add category
                ListViewItem li = new ListViewItem(dinnerList[i].Name);
                li.SubItems.Add(dinnerList[i].Description);
                li.SubItems.Add(dinnerList[i].Ingredients);
                li.SubItems.Add(dinnerList[i].Price.ToString());
                li.SubItems.Add(dinnerList[i].Category.ToString());

                CP_Menukaarten_listView.Items.Add(li);
            }

            // Create some column headers for the data. 
            columnheader = new ColumnHeader();
            columnheader.Text = "Naam";
            CP_Menukaarten_listView.Columns.Add(columnheader);

            columnheader = new ColumnHeader();
            columnheader.Text = "Beschrijving";
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
        }
        #region OnClicks
        private void CP_Menukaarten_listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            CP_Menukaarten_btnEditItem.Enabled = true;
            CP_Menukaarten_btnDeleteItem.Enabled = true;

            CP_Menukaarten_btnEditItem.BackColor = Color.FromArgb(0, 184, 255);
            CP_Menukaarten_btnDeleteItem.BackColor = Color.Red;
        }

        private void CP_Menukaarten_btnDranken_Click(object sender, EventArgs e)
        {
            CP_Menukaarten_btnDranken.BackColor = Color.FromArgb(0, 184, 255);
            CP_Menukaarten_btnLunchgerechten.BackColor = CP_Menukaarten_btnDinergerechten.BackColor = Color.FromArgb(0, 165, 229);

            LoadMenukaartenDrinks();
        }

        private void CP_Menukaarten_btnLunchgerechten_Click(object sender, EventArgs e)
        {
            CP_Menukaarten_btnLunchgerechten.BackColor = Color.FromArgb(0, 184, 255);
            CP_Menukaarten_btnDranken.BackColor = CP_Menukaarten_btnDinergerechten.BackColor = Color.FromArgb(0, 165, 229);
            
            LoadMenukaartenLunch();
        }

        private void CP_Menukaarten_btnDinergerechten_Click(object sender, EventArgs e)
        {
            CP_Menukaarten_btnDinergerechten.BackColor = Color.FromArgb(0, 184, 255);
            CP_Menukaarten_btnLunchgerechten.BackColor = CP_Menukaarten_btnDranken.BackColor = Color.FromArgb(0, 165, 229);
            
            LoadMenukaartenDinner();
        }

        private void CP_Menukaarten_btnNewItem_Click(object sender, EventArgs e)
        {

        }

        private void CP_Menukaarten_btnEditItem_Click(object sender, EventArgs e)
        {

        }

        private void CP_Menukaarten_btnDeleteItem_Click(object sender, EventArgs e)
        {

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
            CP_Voorraad_listView.View = View.Details;
            CP_Voorraad_listView.ListViewItemSorter = lvwColumnSorter;

            CP_Medewerkers_listView.View = View.Details;
            CP_Medewerkers_listView.ListViewItemSorter = lvwColumnSorter;

            CP_Menukaarten_listView.View = View.Details;
            CP_Menukaarten_listView.ListViewItemSorter = lvwColumnSorter;
        }

        //Hide all the panels
        private void HideAllPanels()
        {
            CP_pnlVoorraad.Hide();
            CP_pnlMedewerkers.Hide();
            CP_pnlMenukaarten.Hide();
        }

        //Highlight the selected button
        private void SetHightlight(Button btn)
        {
            CP_btnHome.BackColor = CP_btnVoorraad.BackColor = CP_btnMenukaarten.BackColor = CP_btnBestellingen.BackColor
            = CP_btnInkomsten.BackColor = CP_btnMedewerkers.BackColor = CP_btnUitloggen.BackColor = Color.FromArgb(0, 165, 229);

            btn.BackColor = Color.FromArgb(0, 184, 255);
        }
        #endregion
    }
}
