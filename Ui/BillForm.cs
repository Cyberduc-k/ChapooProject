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
    public partial class BillForm : Form
    {
        private ListViewColumnSorter lvwColumnSorter = new ListViewColumnSorter();
        private Bill_Service bill_service = new Bill_Service();
        private List<Bill> bills;

        public BillForm()
        {
            InitializeComponent();
            Bill_btnAfrekenen_Click(null, null);
        }

        private void Bill_btnAfrekenen_Click(object sender, EventArgs e)
        {
            SetHightlight(Bill_btnAfrekenen);
            HideAll();
            Bill_lblActivePanel.Text = "Afrekenen";
            Bill_pnlAfrekenen.Show();
            Bill_lvTables.Show();

        }

        private void fillTableNumbers(Order order)
        {
            /*@TODO
            foreach (Table table in order.TableId)
            {
                Bill_cbTafelNummer.Items.Add(new ListViewItem(table.Number.ToString()));
            }
            */
        }

        private void Bill_btnRekeningOverzicht_Click(object sender, EventArgs e)
        {

        }

        private void Bill_btnKiesBetaalmethode_Click(object sender, EventArgs e)
        {

        }
        private void SetHightlight(Button btn)
        {
            Bill_btnAfrekenen.BackColor = Color.FromArgb(0, 165, 229);
            btn.BackColor = Color.FromArgb(0, 184, 255);
        }

        private void HideAll()
        {
            Bill_btnBillOverview.Hide();
            Bill_btnKiesBetaalmethode.Hide();
            Bill_lblDisplayTableNumber.Hide();
            Bill_lblRekeningNietBeschikbaar.Hide();
            Bill_lblTableNumber.Hide();
            Bill_lvTables.Hide();
            Bill_pnlAfrekenen.Hide();
        }
    }
}
