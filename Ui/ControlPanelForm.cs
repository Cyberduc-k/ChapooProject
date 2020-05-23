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

namespace Ui
{
    public partial class ControlPanelForm : Form
    {
        private ListViewColumnSorter lvwColumnSorter = new ListViewColumnSorter();

        public ControlPanelForm()
        {
            InitializeComponent();
        }

        private void CP_btnHome_Click(object sender, EventArgs e)
        {
            ListView view = CP_Home_listView1;

            SetHightlight(CP_btnHome);
            CP_lblActivePanel.Text = "Home";

            // Ensure that the view is set to show details.
            view.View = View.Details;
            // clear the listview before filling it again
            view.Clear();

            ListViewItem li = new ListViewItem("Drankje");
            li.SubItems.Add("Gerecht");
            view.Items.Add(li);
            ListViewItem li2 = new ListViewItem("Drankje2");
            li2.SubItems.Add("Gerecht2");
            view.Items.Add(li2);


            // Create some column headers for the data. 
            ColumnHeader columnheader;

            columnheader = new ColumnHeader();
            columnheader.Text = "Number";
            view.Columns.Add(columnheader);

            columnheader = new ColumnHeader();
            columnheader.Text = "Name";
            view.Columns.Add(columnheader);

            // Loop through and size each column header to fit the column header text.
            foreach (ColumnHeader ch in view.Columns)
            {
                ch.Width = -2;
            }

            view.ListViewItemSorter = lvwColumnSorter;
        }

        private void CP_btnVoorraad_Click(object sender, EventArgs e)
        {
            SetHightlight(CP_btnVoorraad);
            CP_lblActivePanel.Text = "Voorraad";
        }

        private void CP_btnMenukaarten_Click(object sender, EventArgs e)
        {
            SetHightlight(CP_btnMenukaarten);
            CP_lblActivePanel.Text = "Menukaarten";
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
            SortListView(e, CP_Home_listView1);
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
    }
}
