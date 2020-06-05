﻿using System;
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
        private Table_Service table_service = new Table_Service();
        private List<Bill> bills;
        private List<Table> tables;
        private int tableId = 1;
        private double totalprice = 0;

        public BillForm()
        {
            InitializeComponent();
            Bill_btnAfrekenen_Click(null, null);
        }

        private void Bill_btnAfrekenen_Click(object sender, EventArgs e)
        {
            SetHightlight(Bill_btnAfrekenen);
            HideAllPanels();
            Bill_lblActivePanel.Text = "Afrekenen";
            Bill_pnlAfrekenen.Show();
            Bill_btnBillOverview.Show();
            Bill_lvTables.Show();
            ShowOccupiedTables();

        }

        private void Bill_btnRekeningOverzicht_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            
            Bill_lvBillOverview.Show();

            Bill bills = bill_service.GetBillByTableId(tableId);

            for (int i = 0; i < bills.Orders.Count; i++)
            {
                ListViewItem li = new ListViewItem(tableId.ToString());
                li.SubItems.Add(bills.Orders[i].Id.ToString());
                li.SubItems.Add(bills.Orders[i].Comment);
                li.SubItems.Add(bills.Orders[i].State.ToString());

                Bill_lvBillOverview.Items.Add(li);

                totalprice = totalprice + bills.Orders[i].TotalPrice;
            }
            Bill_lblTotalPrice.Text = totalprice.ToString("€ 00,00");

            Bill_lblTotalPrice.Show();
            Bill_btnFooi.Show();
            Bill_btnKiesBetaalmethode.Show();
        }

        private void Bill_btnKiesBetaalmethode_Click_1(object sender, EventArgs e)
        {
            Bill_pnlFooi.Hide();
            Bill_pnlBetaalMethode.Show();
            Bill_rbCash.Show();
            Bill_rbMastercard.Show();
            Bill_rbPaypal.Show();
            Bill_rbVisa.Show();
            Bill_btnPay.Show();
        }
        private void SetHightlight(Button btn)
        {
            Bill_btnAfrekenen.BackColor = Color.FromArgb(0, 165, 229);
            btn.BackColor = Color.FromArgb(0, 184, 255);
        }
        private void ShowOccupiedTables()
        {
            tables = table_service.GetAllTables();

            Button[] btnArray = new Button[]
            {
                Bill_btnTable1, Bill_btnTable2, Bill_btnTable3, Bill_btnTable4, Bill_btnTable5, Bill_btnTable6, Bill_btnTable7, Bill_btnTable8, Bill_btnTable9, Bill_btnTable10
            };

            for (int i = 0; i < tables.Count; i++)
            {
                if (tables[i].Occupied == true)
                {
                    btnArray[i].BackColor = Color.Red;
                    btnArray[i].Enabled = true;
                }
                else
                {
                    btnArray[i].BackColor = Color.Green;
                    btnArray[i].Enabled = false;
                }
            }
        }

        private void HideAllPanels()
        {
            Bill_btnBillOverview.Hide();
            Bill_btnKiesBetaalmethode.Hide();
            Bill_btnFooi.Hide();
            Bill_lblRekeningNietBeschikbaar.Hide();
            Bill_lvTables.Hide();
            Bill_pnlAfrekenen.Hide();
            Bill_pnlBetaalMethode.Hide();
            Bill_rbCash.Hide();
            Bill_rbMastercard.Hide();
            Bill_rbPaypal.Hide();
            Bill_rbVisa.Hide();
            Bill_btnPay.Hide();
            Bill_pnlFooi.Hide();
            Bill_lblTotalPrice.Hide();
        }

        private void Bill_btnTable1_Click(object sender, EventArgs e)
        {
            Bill_lblTableNumber.Text = "Tafel nummer: 1";
            tableId = 1;
        }

        private void Bill_btnTable2_Click(object sender, EventArgs e)
        {
            Bill_lblTableNumber.Text = "Tafel nummer: 2";
            tableId = 2;
        }

        private void Bill_btnTable3_Click(object sender, EventArgs e)
        {
            Bill_lblTableNumber.Text = "Tafel nummer: 3";
            tableId = 3;
        }

        private void Bill_btnTable4_Click(object sender, EventArgs e)
        {
            Bill_lblTableNumber.Text = "Tafel nummer: 4";
            tableId = 4;
        }

        private void Bill_btnTable5_Click(object sender, EventArgs e)
        {
            Bill_lblTableNumber.Text = "Tafel nummer: 5";
            tableId = 5;
        }

        private void Bill_btnTable6_Click(object sender, EventArgs e)
        {
            Bill_lblTableNumber.Text = "Tafel nummer: 6";
            tableId = 6;
        }

        private void Bill_btnTable7_Click(object sender, EventArgs e)
        {
            Bill_lblTableNumber.Text = "Tafel nummer: 7";
            tableId = 7;
        }

        private void Bill_btnTable8_Click(object sender, EventArgs e)
        {
            Bill_lblTableNumber.Text = "Tafel nummer: 8";
            tableId = 8;
        }

        private void Bill_btnTable9_Click(object sender, EventArgs e)
        {
            Bill_lblTableNumber.Text = "Tafel nummer: 9";
            tableId = 9;
        }

        private void Bill_btnTable10_Click(object sender, EventArgs e)
        {
            Bill_lblTableNumber.Text = "Tafel nummer: 10";
            tableId = 10;
        }

        private void Bill_btnPay_Click(object sender, EventArgs e)
        {
            //bill_service.RemoveBill();
        }

        private void Bill_btnBetaalmethodeX_Click(object sender, EventArgs e)
        {
            Bill_pnlBetaalMethode.Hide();
        }

        private void Bill_btnFooiX_Click(object sender, EventArgs e)
        {
            Bill_pnlFooi.Hide();
        }

        private void Bill_btnFooi_Click(object sender, EventArgs e)
        {
            Bill_pnlBetaalMethode.Hide();
            Bill_pnlFooi.Show();
        }
    }
}
