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
        private ListViewColumnSorter lvwColumnSorter = new ListViewColumnSorter();
        private Drink_Service drinkService = new Drink_Service();
        private Employee_Service employeeService = new Employee_Service();

        private ColumnHeader columnheader;

        public ControlPanelForm()
        {
            InitializeComponent();
            HideAllPanels();
            InitializeSorting();
        }

        private void CP_btnHome_Click(object sender, EventArgs e)
        {
            SetHightlight(CP_btnHome);
            CP_lblActivePanel.Text = "Home";
            HideAllPanels();
        }

        private void CP_btnVoorraad_Click(object sender, EventArgs e)
        {
            List<Drink> drinkList = drinkService.GetAllDrinks();
            drinkList = new List<Drink>();
            drinkList.Add(new Drink(1, "cola", 2, 2, false));
            drinkList.Add(new Drink(2, "bier", 2.50, 5, true));
            drinkList.Add(new Drink(3, "sprite", 3, 10, false));

            CP_Voorraad_listViewDranken.Clear();

            for (int i = 0; i < drinkList.Count; i++)
            {
                ListViewItem li = new ListViewItem(drinkList[i].Id.ToString());
                li.SubItems.Add(drinkList[i].Name);
                li.SubItems.Add(drinkList[i].Alcoholic.ToString());
                li.SubItems.Add(drinkList[i].Price.ToString());
                li.SubItems.Add(drinkList[i].NumberInStock.ToString());

                CP_Voorraad_listViewDranken.Items.Add(li);
            }

            // Create some column headers for the data. 
            columnheader = new ColumnHeader();
            columnheader.Text = "ID";
            CP_Voorraad_listViewDranken.Columns.Add(columnheader);

            columnheader = new ColumnHeader();
            columnheader.Text = "Naam";
            CP_Voorraad_listViewDranken.Columns.Add(columnheader);

            columnheader = new ColumnHeader();
            columnheader.Text = "Alcoholisch";
            CP_Voorraad_listViewDranken.Columns.Add(columnheader);

            columnheader = new ColumnHeader();
            columnheader.Text = "Prijs";
            CP_Voorraad_listViewDranken.Columns.Add(columnheader);

            columnheader = new ColumnHeader();
            columnheader.Text = "Voorraad";
            CP_Voorraad_listViewDranken.Columns.Add(columnheader);

            // Loop through and size each column header to fit the column header text.
            foreach (ColumnHeader ch in CP_Voorraad_listViewDranken.Columns)
            {
                ch.Width = -2;
            }

            SetHightlight(CP_btnVoorraad);
            CP_lblActivePanel.Text = "Voorraad";
            HideAllPanels();
            CP_pnlVoorraad.Show();
        }

        private void CP_btnMenukaarten_Click(object sender, EventArgs e)
        {
            SetHightlight(CP_btnMenukaarten);
            CP_lblActivePanel.Text = "Menukaarten";
            HideAllPanels();
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
            List<Employee> employeeList = employeeService.GetAllEmployees();

            employeeList = new List<Employee>();
            employeeList.Add(new Employee(1, "Bram", "Sierhuis", new DateTime(2001, 5, 16), new DateTime(2020, 4, 18), Gender.Male, "2039", EmployeeType.Owner));
            employeeList.Add(new Employee(2, "Bram", "Sierhuis", new DateTime(2001, 5, 16), new DateTime(2020, 4, 18), Gender.Male, "2039", EmployeeType.Owner));
            employeeList.Add(new Employee(3, "Bram", "Sierhuis", new DateTime(2001, 5, 16), new DateTime(2020, 4, 18), Gender.Male, "2039", EmployeeType.Owner));

            CP_Medewerkers_listView.Clear();

            for (int i = 0; i < employeeList.Count; i++)
            {
                ListViewItem li = new ListViewItem(employeeList[i].Id.ToString());
                li.SubItems.Add(employeeList[i].FirstName + " " + employeeList[i].LastName);
                li.SubItems.Add(employeeList[i].Alcoholic.ToString());
                li.SubItems.Add(employeeList[i].Price.ToString());
                li.SubItems.Add(employeeList[i].NumberInStock.ToString());

                CP_Voorraad_listViewDranken.Items.Add(li);
            }

            // Create some column headers for the data. 
            columnheader = new ColumnHeader();
            columnheader.Text = "ID";
            CP_Voorraad_listViewDranken.Columns.Add(columnheader);

            columnheader = new ColumnHeader();
            columnheader.Text = "Naam";
            CP_Voorraad_listViewDranken.Columns.Add(columnheader);

            columnheader = new ColumnHeader();
            columnheader.Text = "Alcoholisch";
            CP_Voorraad_listViewDranken.Columns.Add(columnheader);

            columnheader = new ColumnHeader();
            columnheader.Text = "Prijs";
            CP_Voorraad_listViewDranken.Columns.Add(columnheader);

            columnheader = new ColumnHeader();
            columnheader.Text = "Voorraad";
            CP_Voorraad_listViewDranken.Columns.Add(columnheader);

            // Loop through and size each column header to fit the column header text.
            foreach (ColumnHeader ch in CP_Voorraad_listViewDranken.Columns)
            {
                ch.Width = -2;
            }

            SetHightlight(CP_btnMedewerkers);
            CP_lblActivePanel.Text = "Medewerkers";
            HideAllPanels();
            CP_pnlMedewerkers.Show();
        }

        private void CP_btnUitloggen_Click(object sender, EventArgs e)
        {
            SetHightlight(CP_btnUitloggen);

            // @TODO signout
            Application.Exit();
        }

        //Highlight a button
        private void SetHightlight(Button btn)
        {
            CP_btnHome.BackColor = CP_btnVoorraad.BackColor = CP_btnMenukaarten.BackColor = CP_btnBestellingen.BackColor
            = CP_btnInkomsten.BackColor = CP_btnMedewerkers.BackColor = CP_btnUitloggen.BackColor = Color.FromArgb(0, 165, 229);

            btn.BackColor = Color.FromArgb(0, 184, 255);
        }

        private void CP_Home_listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            SortListView(e, CP_Voorraad_listViewDranken);
        }

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

        private void InitializeSorting()
        {
            CP_Voorraad_listViewDranken.View = View.Details;
            CP_Voorraad_listViewDranken.ListViewItemSorter = lvwColumnSorter;
        }

        private void HideAllPanels()
        {
            CP_pnlVoorraad.Hide();
        }

        private void CP_Voorraad_btnDranken_Click(object sender, EventArgs e)
        {
            CP_Voorraad_btnDranken.BackColor = Color.FromArgb(0, 184, 255);
            CP_Voorraad_btnLunchgerechten.BackColor = CP_Voorraad_btnDinergerechten.BackColor = Color.FromArgb(0, 165, 229);
        }

        private void CP_Voorraad_btnLunchgerechten_Click(object sender, EventArgs e)
        {
            CP_Voorraad_btnLunchgerechten.BackColor = Color.FromArgb(0, 184, 255);
            CP_Voorraad_btnDranken.BackColor = CP_Voorraad_btnDinergerechten.BackColor = Color.FromArgb(0, 165, 229);
        }

        private void CP_Voorraad_btnDinergerechten_Click(object sender, EventArgs e)
        {
            CP_Voorraad_btnDinergerechten.BackColor = Color.FromArgb(0, 184, 255);
            CP_Voorraad_btnLunchgerechten.BackColor = CP_Voorraad_btnDranken.BackColor = Color.FromArgb(0, 165, 229);
        }
    }
}
