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

        public ControlPanelForm()
        {
            InitializeComponent();
            HideAllPanels();
        }

        private void CP_btnHome_Click(object sender, EventArgs e)
        {
            SetHightlight(CP_btnHome);
            CP_lblActivePanel.Text = "Home";
            HideAllPanels();
        }

        private void CP_btnVoorraad_Click(object sender, EventArgs e)
        {
            Drink_Service drinkService = new Drink_Service();
            List<Drink> drinkList = drinkService.GetAllDrinks();

            SetHightlight(CP_btnVoorraad);
            CP_lblActivePanel.Text = "Voorraad";
            HideAllPanels();

            ListView view = CP_Voorraad_listViewDranken;

            // Ensure that the view is empty and set to show details.
            view.View = View.Details;
            view.Clear();
            view.ListViewItemSorter = lvwColumnSorter;

            for (int i = 0; i < drinkList.Count; i++)
            {
                ListViewItem li = new ListViewItem(drinkList[i].Id.ToString());
                li.SubItems.Add(drinkList[i].Name);
                li.SubItems.Add(drinkList[i].Alcoholic.ToString());
                li.SubItems.Add(drinkList[i].Price.ToString());
                li.SubItems.Add(drinkList[i].NumberInStock.ToString());

                view.Items.Add(li);
            }


            // Create some column headers for the data. 
            ColumnHeader columnheader;

            columnheader = new ColumnHeader();
            columnheader.Text = "ID";
            view.Columns.Add(columnheader);

            columnheader = new ColumnHeader();
            columnheader.Text = "Naam";
            view.Columns.Add(columnheader);

            columnheader = new ColumnHeader();
            columnheader.Text = "Alcoholisch";
            view.Columns.Add(columnheader);

            columnheader = new ColumnHeader();
            columnheader.Text = "Prijs";
            view.Columns.Add(columnheader);


            columnheader = new ColumnHeader();
            columnheader.Text = "Voorraad";
            view.Columns.Add(columnheader);

            // Loop through and size each column header to fit the column header text.
            foreach (ColumnHeader ch in view.Columns)
            {
                ch.Width = -2;
            }

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
        }

        private void CP_btnInkomsten_Click(object sender, EventArgs e)
        {
            SetHightlight(CP_btnInkomsten);
            CP_lblActivePanel.Text = "Inkomsten";
        }

        private void CP_btnMedewerkers_Click(object sender, EventArgs e)
        {
            SetHightlight(CP_btnMedewerkers);
            CP_lblActivePanel.Text = "Medewerkers";
        }

        private void CP_btnUitloggen_Click(object sender, EventArgs e)
        {
            SetHightlight(CP_btnUitloggen);
            Close();
            Owner.Show();
        }

        // Highlight a button
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
