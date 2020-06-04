namespace Ui
{
    partial class BillForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Bill_btnAfrekenen = new System.Windows.Forms.Button();
            this.Bill_pnlAfrekenen = new System.Windows.Forms.Panel();
            this.Bill_btnPay = new System.Windows.Forms.Button();
            this.Bill_rbPaypal = new System.Windows.Forms.RadioButton();
            this.Bill_rbMastercard = new System.Windows.Forms.RadioButton();
            this.Bill_rbVisa = new System.Windows.Forms.RadioButton();
            this.Bill_rbCash = new System.Windows.Forms.RadioButton();
            this.Bill_lvBetaalMethode = new System.Windows.Forms.ListView();
            this.Bill_btnTable10 = new System.Windows.Forms.Button();
            this.Bill_btnTable8 = new System.Windows.Forms.Button();
            this.Bill_btnTable6 = new System.Windows.Forms.Button();
            this.Bill_btnTable4 = new System.Windows.Forms.Button();
            this.Bill_btnTable2 = new System.Windows.Forms.Button();
            this.Bill_btnTable9 = new System.Windows.Forms.Button();
            this.Bill_btnTable7 = new System.Windows.Forms.Button();
            this.Bill_btnTable5 = new System.Windows.Forms.Button();
            this.Bill_btnTable3 = new System.Windows.Forms.Button();
            this.Bill_btnTable1 = new System.Windows.Forms.Button();
            this.Bill_lvTables = new System.Windows.Forms.ListView();
            this.Bill_lblRekeningNietBeschikbaar = new System.Windows.Forms.Label();
            this.Bill_btnKiesBetaalmethode = new System.Windows.Forms.Button();
            this.Bill_lvBillOverview = new System.Windows.Forms.ListView();
            this.Bill_btnBillOverview = new System.Windows.Forms.Button();
            this.Bill_lblTableNumber = new System.Windows.Forms.Label();
            this.Bill_lblActivePanel = new System.Windows.Forms.Label();
            this.Bill_pnlAfrekenen.SuspendLayout();
            this.SuspendLayout();
            // 
            // Bill_btnAfrekenen
            // 
            this.Bill_btnAfrekenen.Location = new System.Drawing.Point(13, 95);
            this.Bill_btnAfrekenen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Bill_btnAfrekenen.Name = "Bill_btnAfrekenen";
            this.Bill_btnAfrekenen.Size = new System.Drawing.Size(112, 35);
            this.Bill_btnAfrekenen.TabIndex = 0;
            this.Bill_btnAfrekenen.Text = "Afrekenen";
            this.Bill_btnAfrekenen.UseVisualStyleBackColor = true;
            this.Bill_btnAfrekenen.Click += new System.EventHandler(this.Bill_btnAfrekenen_Click);
            // 
            // Bill_pnlAfrekenen
            // 
            this.Bill_pnlAfrekenen.Controls.Add(this.Bill_btnPay);
            this.Bill_pnlAfrekenen.Controls.Add(this.Bill_rbPaypal);
            this.Bill_pnlAfrekenen.Controls.Add(this.Bill_rbMastercard);
            this.Bill_pnlAfrekenen.Controls.Add(this.Bill_rbVisa);
            this.Bill_pnlAfrekenen.Controls.Add(this.Bill_rbCash);
            this.Bill_pnlAfrekenen.Controls.Add(this.Bill_lvBetaalMethode);
            this.Bill_pnlAfrekenen.Controls.Add(this.Bill_btnTable10);
            this.Bill_pnlAfrekenen.Controls.Add(this.Bill_btnTable8);
            this.Bill_pnlAfrekenen.Controls.Add(this.Bill_btnTable6);
            this.Bill_pnlAfrekenen.Controls.Add(this.Bill_btnTable4);
            this.Bill_pnlAfrekenen.Controls.Add(this.Bill_btnTable2);
            this.Bill_pnlAfrekenen.Controls.Add(this.Bill_btnTable9);
            this.Bill_pnlAfrekenen.Controls.Add(this.Bill_btnTable7);
            this.Bill_pnlAfrekenen.Controls.Add(this.Bill_btnTable5);
            this.Bill_pnlAfrekenen.Controls.Add(this.Bill_btnTable3);
            this.Bill_pnlAfrekenen.Controls.Add(this.Bill_btnTable1);
            this.Bill_pnlAfrekenen.Controls.Add(this.Bill_lvTables);
            this.Bill_pnlAfrekenen.Controls.Add(this.Bill_lblRekeningNietBeschikbaar);
            this.Bill_pnlAfrekenen.Controls.Add(this.Bill_btnKiesBetaalmethode);
            this.Bill_pnlAfrekenen.Controls.Add(this.Bill_lvBillOverview);
            this.Bill_pnlAfrekenen.Controls.Add(this.Bill_btnBillOverview);
            this.Bill_pnlAfrekenen.Controls.Add(this.Bill_lblTableNumber);
            this.Bill_pnlAfrekenen.Location = new System.Drawing.Point(140, 95);
            this.Bill_pnlAfrekenen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Bill_pnlAfrekenen.Name = "Bill_pnlAfrekenen";
            this.Bill_pnlAfrekenen.Size = new System.Drawing.Size(1042, 578);
            this.Bill_pnlAfrekenen.TabIndex = 1;
            // 
            // Bill_btnPay
            // 
            this.Bill_btnPay.Location = new System.Drawing.Point(667, 361);
            this.Bill_btnPay.Name = "Bill_btnPay";
            this.Bill_btnPay.Size = new System.Drawing.Size(83, 35);
            this.Bill_btnPay.TabIndex = 23;
            this.Bill_btnPay.Text = "Betaal";
            this.Bill_btnPay.UseVisualStyleBackColor = true;
            // 
            // Bill_rbPaypal
            // 
            this.Bill_rbPaypal.AutoSize = true;
            this.Bill_rbPaypal.Location = new System.Drawing.Point(260, 366);
            this.Bill_rbPaypal.Name = "Bill_rbPaypal";
            this.Bill_rbPaypal.Size = new System.Drawing.Size(74, 24);
            this.Bill_rbPaypal.TabIndex = 22;
            this.Bill_rbPaypal.Text = "Paypal";
            this.Bill_rbPaypal.UseVisualStyleBackColor = true;
            // 
            // Bill_rbMastercard
            // 
            this.Bill_rbMastercard.AutoSize = true;
            this.Bill_rbMastercard.Location = new System.Drawing.Point(260, 243);
            this.Bill_rbMastercard.Name = "Bill_rbMastercard";
            this.Bill_rbMastercard.Size = new System.Drawing.Size(107, 24);
            this.Bill_rbMastercard.TabIndex = 21;
            this.Bill_rbMastercard.Text = "Mastercard";
            this.Bill_rbMastercard.UseVisualStyleBackColor = true;
            // 
            // Bill_rbVisa
            // 
            this.Bill_rbVisa.AutoSize = true;
            this.Bill_rbVisa.Location = new System.Drawing.Point(260, 302);
            this.Bill_rbVisa.Name = "Bill_rbVisa";
            this.Bill_rbVisa.Size = new System.Drawing.Size(58, 24);
            this.Bill_rbVisa.TabIndex = 20;
            this.Bill_rbVisa.Text = "Visa";
            this.Bill_rbVisa.UseVisualStyleBackColor = true;
            // 
            // Bill_rbCash
            // 
            this.Bill_rbCash.AutoSize = true;
            this.Bill_rbCash.Checked = true;
            this.Bill_rbCash.Location = new System.Drawing.Point(260, 183);
            this.Bill_rbCash.Name = "Bill_rbCash";
            this.Bill_rbCash.Size = new System.Drawing.Size(64, 24);
            this.Bill_rbCash.TabIndex = 19;
            this.Bill_rbCash.TabStop = true;
            this.Bill_rbCash.Text = "Cash";
            this.Bill_rbCash.UseVisualStyleBackColor = true;
            // 
            // Bill_lvBetaalMethode
            // 
            this.Bill_lvBetaalMethode.HideSelection = false;
            this.Bill_lvBetaalMethode.Location = new System.Drawing.Point(242, 154);
            this.Bill_lvBetaalMethode.Name = "Bill_lvBetaalMethode";
            this.Bill_lvBetaalMethode.Size = new System.Drawing.Size(525, 261);
            this.Bill_lvBetaalMethode.TabIndex = 18;
            this.Bill_lvBetaalMethode.UseCompatibleStateImageBehavior = false;
            // 
            // Bill_btnTable10
            // 
            this.Bill_btnTable10.Location = new System.Drawing.Point(148, 421);
            this.Bill_btnTable10.Name = "Bill_btnTable10";
            this.Bill_btnTable10.Size = new System.Drawing.Size(88, 83);
            this.Bill_btnTable10.TabIndex = 17;
            this.Bill_btnTable10.Text = "Tafel 10";
            this.Bill_btnTable10.UseVisualStyleBackColor = true;
            this.Bill_btnTable10.Click += new System.EventHandler(this.Bill_btnTable10_Click);
            // 
            // Bill_btnTable8
            // 
            this.Bill_btnTable8.Location = new System.Drawing.Point(148, 332);
            this.Bill_btnTable8.Name = "Bill_btnTable8";
            this.Bill_btnTable8.Size = new System.Drawing.Size(88, 83);
            this.Bill_btnTable8.TabIndex = 16;
            this.Bill_btnTable8.Text = "Tafel 8";
            this.Bill_btnTable8.UseVisualStyleBackColor = true;
            this.Bill_btnTable8.Click += new System.EventHandler(this.Bill_btnTable8_Click);
            // 
            // Bill_btnTable6
            // 
            this.Bill_btnTable6.Location = new System.Drawing.Point(148, 243);
            this.Bill_btnTable6.Name = "Bill_btnTable6";
            this.Bill_btnTable6.Size = new System.Drawing.Size(88, 83);
            this.Bill_btnTable6.TabIndex = 15;
            this.Bill_btnTable6.Text = "Tafel 6";
            this.Bill_btnTable6.UseVisualStyleBackColor = true;
            this.Bill_btnTable6.Click += new System.EventHandler(this.Bill_btnTable6_Click);
            // 
            // Bill_btnTable4
            // 
            this.Bill_btnTable4.Location = new System.Drawing.Point(148, 154);
            this.Bill_btnTable4.Name = "Bill_btnTable4";
            this.Bill_btnTable4.Size = new System.Drawing.Size(88, 83);
            this.Bill_btnTable4.TabIndex = 14;
            this.Bill_btnTable4.Text = "Tafel 4";
            this.Bill_btnTable4.UseVisualStyleBackColor = true;
            this.Bill_btnTable4.Click += new System.EventHandler(this.Bill_btnTable4_Click);
            // 
            // Bill_btnTable2
            // 
            this.Bill_btnTable2.Location = new System.Drawing.Point(148, 65);
            this.Bill_btnTable2.Name = "Bill_btnTable2";
            this.Bill_btnTable2.Size = new System.Drawing.Size(88, 83);
            this.Bill_btnTable2.TabIndex = 13;
            this.Bill_btnTable2.Text = "Tafel 2";
            this.Bill_btnTable2.UseVisualStyleBackColor = true;
            this.Bill_btnTable2.Click += new System.EventHandler(this.Bill_btnTable2_Click);
            // 
            // Bill_btnTable9
            // 
            this.Bill_btnTable9.Location = new System.Drawing.Point(31, 421);
            this.Bill_btnTable9.Name = "Bill_btnTable9";
            this.Bill_btnTable9.Size = new System.Drawing.Size(88, 83);
            this.Bill_btnTable9.TabIndex = 12;
            this.Bill_btnTable9.Text = "Tafel 9";
            this.Bill_btnTable9.UseVisualStyleBackColor = true;
            this.Bill_btnTable9.Click += new System.EventHandler(this.Bill_btnTable9_Click);
            // 
            // Bill_btnTable7
            // 
            this.Bill_btnTable7.Location = new System.Drawing.Point(31, 332);
            this.Bill_btnTable7.Name = "Bill_btnTable7";
            this.Bill_btnTable7.Size = new System.Drawing.Size(88, 83);
            this.Bill_btnTable7.TabIndex = 11;
            this.Bill_btnTable7.Text = "Tafel 7";
            this.Bill_btnTable7.UseVisualStyleBackColor = true;
            this.Bill_btnTable7.Click += new System.EventHandler(this.Bill_btnTable7_Click);
            // 
            // Bill_btnTable5
            // 
            this.Bill_btnTable5.Location = new System.Drawing.Point(31, 243);
            this.Bill_btnTable5.Name = "Bill_btnTable5";
            this.Bill_btnTable5.Size = new System.Drawing.Size(88, 83);
            this.Bill_btnTable5.TabIndex = 10;
            this.Bill_btnTable5.Text = "Tafel 5";
            this.Bill_btnTable5.UseVisualStyleBackColor = true;
            this.Bill_btnTable5.Click += new System.EventHandler(this.Bill_btnTable5_Click);
            // 
            // Bill_btnTable3
            // 
            this.Bill_btnTable3.Location = new System.Drawing.Point(31, 154);
            this.Bill_btnTable3.Name = "Bill_btnTable3";
            this.Bill_btnTable3.Size = new System.Drawing.Size(88, 83);
            this.Bill_btnTable3.TabIndex = 9;
            this.Bill_btnTable3.Text = "Tafel 3";
            this.Bill_btnTable3.UseVisualStyleBackColor = true;
            this.Bill_btnTable3.Click += new System.EventHandler(this.Bill_btnTable3_Click);
            // 
            // Bill_btnTable1
            // 
            this.Bill_btnTable1.Location = new System.Drawing.Point(31, 65);
            this.Bill_btnTable1.Name = "Bill_btnTable1";
            this.Bill_btnTable1.Size = new System.Drawing.Size(88, 83);
            this.Bill_btnTable1.TabIndex = 8;
            this.Bill_btnTable1.Text = "Tafel 1";
            this.Bill_btnTable1.UseVisualStyleBackColor = true;
            this.Bill_btnTable1.Click += new System.EventHandler(this.Bill_btnTable1_Click);
            // 
            // Bill_lvTables
            // 
            this.Bill_lvTables.HideSelection = false;
            this.Bill_lvTables.Location = new System.Drawing.Point(3, 46);
            this.Bill_lvTables.Name = "Bill_lvTables";
            this.Bill_lvTables.Size = new System.Drawing.Size(1038, 532);
            this.Bill_lvTables.TabIndex = 7;
            this.Bill_lvTables.UseCompatibleStateImageBehavior = false;
            // 
            // Bill_lblRekeningNietBeschikbaar
            // 
            this.Bill_lblRekeningNietBeschikbaar.AutoSize = true;
            this.Bill_lblRekeningNietBeschikbaar.Location = new System.Drawing.Point(417, 269);
            this.Bill_lblRekeningNietBeschikbaar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Bill_lblRekeningNietBeschikbaar.Name = "Bill_lblRekeningNietBeschikbaar";
            this.Bill_lblRekeningNietBeschikbaar.Size = new System.Drawing.Size(197, 20);
            this.Bill_lblRekeningNietBeschikbaar.TabIndex = 5;
            this.Bill_lblRekeningNietBeschikbaar.Text = "Rekening niet beschikbaar";
            // 
            // Bill_btnKiesBetaalmethode
            // 
            this.Bill_btnKiesBetaalmethode.Location = new System.Drawing.Point(4, 525);
            this.Bill_btnKiesBetaalmethode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Bill_btnKiesBetaalmethode.Name = "Bill_btnKiesBetaalmethode";
            this.Bill_btnKiesBetaalmethode.Size = new System.Drawing.Size(182, 49);
            this.Bill_btnKiesBetaalmethode.TabIndex = 4;
            this.Bill_btnKiesBetaalmethode.Text = "Kies betaalmethode";
            this.Bill_btnKiesBetaalmethode.UseVisualStyleBackColor = true;
            this.Bill_btnKiesBetaalmethode.Click += new System.EventHandler(this.Bill_btnKiesBetaalmethode_Click);
            // 
            // Bill_lvBillOverview
            // 
            this.Bill_lvBillOverview.HideSelection = false;
            this.Bill_lvBillOverview.Location = new System.Drawing.Point(4, 46);
            this.Bill_lvBillOverview.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Bill_lvBillOverview.Name = "Bill_lvBillOverview";
            this.Bill_lvBillOverview.Size = new System.Drawing.Size(1032, 467);
            this.Bill_lvBillOverview.TabIndex = 3;
            this.Bill_lvBillOverview.UseCompatibleStateImageBehavior = false;
            // 
            // Bill_btnBillOverview
            // 
            this.Bill_btnBillOverview.Location = new System.Drawing.Point(237, 5);
            this.Bill_btnBillOverview.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Bill_btnBillOverview.Name = "Bill_btnBillOverview";
            this.Bill_btnBillOverview.Size = new System.Drawing.Size(170, 32);
            this.Bill_btnBillOverview.TabIndex = 2;
            this.Bill_btnBillOverview.Text = "Rekening overzicht";
            this.Bill_btnBillOverview.UseVisualStyleBackColor = true;
            this.Bill_btnBillOverview.Click += new System.EventHandler(this.Bill_btnRekeningOverzicht_Click);
            // 
            // Bill_lblTableNumber
            // 
            this.Bill_lblTableNumber.AutoSize = true;
            this.Bill_lblTableNumber.Location = new System.Drawing.Point(27, 11);
            this.Bill_lblTableNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Bill_lblTableNumber.Name = "Bill_lblTableNumber";
            this.Bill_lblTableNumber.Size = new System.Drawing.Size(126, 20);
            this.Bill_lblTableNumber.TabIndex = 0;
            this.Bill_lblTableNumber.Text = "Tafel nummer: ...";
            // 
            // Bill_lblActivePanel
            // 
            this.Bill_lblActivePanel.AutoSize = true;
            this.Bill_lblActivePanel.Location = new System.Drawing.Point(574, 37);
            this.Bill_lblActivePanel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Bill_lblActivePanel.Name = "Bill_lblActivePanel";
            this.Bill_lblActivePanel.Size = new System.Drawing.Size(83, 20);
            this.Bill_lblActivePanel.TabIndex = 2;
            this.Bill_lblActivePanel.Text = "Afrekenen";
            // 
            // BillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.Bill_lblActivePanel);
            this.Controls.Add(this.Bill_pnlAfrekenen);
            this.Controls.Add(this.Bill_btnAfrekenen);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BillForm";
            this.Text = "BillForm";
            this.Bill_pnlAfrekenen.ResumeLayout(false);
            this.Bill_pnlAfrekenen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bill_btnAfrekenen;
        private System.Windows.Forms.Panel Bill_pnlAfrekenen;
        private System.Windows.Forms.Label Bill_lblTableNumber;
        private System.Windows.Forms.Button Bill_btnKiesBetaalmethode;
        private System.Windows.Forms.ListView Bill_lvBillOverview;
        private System.Windows.Forms.Button Bill_btnBillOverview;
        private System.Windows.Forms.Label Bill_lblActivePanel;
        private System.Windows.Forms.Label Bill_lblRekeningNietBeschikbaar;
        private System.Windows.Forms.Button Bill_btnTable10;
        private System.Windows.Forms.Button Bill_btnTable8;
        private System.Windows.Forms.Button Bill_btnTable6;
        private System.Windows.Forms.Button Bill_btnTable4;
        private System.Windows.Forms.Button Bill_btnTable2;
        private System.Windows.Forms.Button Bill_btnTable9;
        private System.Windows.Forms.Button Bill_btnTable7;
        private System.Windows.Forms.Button Bill_btnTable5;
        private System.Windows.Forms.Button Bill_btnTable3;
        private System.Windows.Forms.Button Bill_btnTable1;
        private System.Windows.Forms.ListView Bill_lvTables;
        private System.Windows.Forms.Button Bill_btnPay;
        private System.Windows.Forms.RadioButton Bill_rbPaypal;
        private System.Windows.Forms.RadioButton Bill_rbMastercard;
        private System.Windows.Forms.RadioButton Bill_rbVisa;
        private System.Windows.Forms.RadioButton Bill_rbCash;
        private System.Windows.Forms.ListView Bill_lvBetaalMethode;
    }
}