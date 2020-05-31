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
            this.Bill_lblRekeningNietBeschikbaar = new System.Windows.Forms.Label();
            this.Bill_btnKiesBetaalmethode = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Bill_btnBillOverview = new System.Windows.Forms.Button();
            this.Bill_lblTableNumber = new System.Windows.Forms.Label();
            this.Bill_lblActivePanel = new System.Windows.Forms.Label();
            this.Bill_lblDisplayTableNumber = new System.Windows.Forms.Label();
            this.Bill_lvTables = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.Bill_pnlAfrekenen.SuspendLayout();
            this.SuspendLayout();
            // 
            // Bill_btnAfrekenen
            // 
            this.Bill_btnAfrekenen.Location = new System.Drawing.Point(18, 95);
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
            this.Bill_pnlAfrekenen.Controls.Add(this.button10);
            this.Bill_pnlAfrekenen.Controls.Add(this.button9);
            this.Bill_pnlAfrekenen.Controls.Add(this.button8);
            this.Bill_pnlAfrekenen.Controls.Add(this.button7);
            this.Bill_pnlAfrekenen.Controls.Add(this.button6);
            this.Bill_pnlAfrekenen.Controls.Add(this.button5);
            this.Bill_pnlAfrekenen.Controls.Add(this.button4);
            this.Bill_pnlAfrekenen.Controls.Add(this.button3);
            this.Bill_pnlAfrekenen.Controls.Add(this.button2);
            this.Bill_pnlAfrekenen.Controls.Add(this.button1);
            this.Bill_pnlAfrekenen.Controls.Add(this.Bill_lvTables);
            this.Bill_pnlAfrekenen.Controls.Add(this.Bill_lblDisplayTableNumber);
            this.Bill_pnlAfrekenen.Controls.Add(this.Bill_lblRekeningNietBeschikbaar);
            this.Bill_pnlAfrekenen.Controls.Add(this.Bill_btnKiesBetaalmethode);
            this.Bill_pnlAfrekenen.Controls.Add(this.listView1);
            this.Bill_pnlAfrekenen.Controls.Add(this.Bill_btnBillOverview);
            this.Bill_pnlAfrekenen.Controls.Add(this.Bill_lblTableNumber);
            this.Bill_pnlAfrekenen.Location = new System.Drawing.Point(140, 95);
            this.Bill_pnlAfrekenen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Bill_pnlAfrekenen.Name = "Bill_pnlAfrekenen";
            this.Bill_pnlAfrekenen.Size = new System.Drawing.Size(1042, 578);
            this.Bill_pnlAfrekenen.TabIndex = 1;
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
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(4, 46);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1032, 467);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
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
            this.Bill_lblTableNumber.Size = new System.Drawing.Size(110, 20);
            this.Bill_lblTableNumber.TabIndex = 0;
            this.Bill_lblTableNumber.Text = "Tafel nummer:";
            // 
            // Bill_lblActivePanel
            // 
            this.Bill_lblActivePanel.AutoSize = true;
            this.Bill_lblActivePanel.Location = new System.Drawing.Point(618, 35);
            this.Bill_lblActivePanel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Bill_lblActivePanel.Name = "Bill_lblActivePanel";
            this.Bill_lblActivePanel.Size = new System.Drawing.Size(51, 20);
            this.Bill_lblActivePanel.TabIndex = 2;
            this.Bill_lblActivePanel.Text = "label1";
            // 
            // Bill_lblDisplayTableNumber
            // 
            this.Bill_lblDisplayTableNumber.AutoSize = true;
            this.Bill_lblDisplayTableNumber.Location = new System.Drawing.Point(144, 11);
            this.Bill_lblDisplayTableNumber.Name = "Bill_lblDisplayTableNumber";
            this.Bill_lblDisplayTableNumber.Size = new System.Drawing.Size(21, 20);
            this.Bill_lblDisplayTableNumber.TabIndex = 6;
            this.Bill_lblDisplayTableNumber.Text = "...";
            // 
            // Bill_lvTables
            // 
            this.Bill_lvTables.HideSelection = false;
            this.Bill_lvTables.Location = new System.Drawing.Point(4, 46);
            this.Bill_lvTables.Name = "Bill_lvTables";
            this.Bill_lvTables.Size = new System.Drawing.Size(1038, 532);
            this.Bill_lvTables.TabIndex = 7;
            this.Bill_lvTables.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 83);
            this.button1.TabIndex = 8;
            this.button1.Text = "Tafel 1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(31, 154);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 83);
            this.button2.TabIndex = 9;
            this.button2.Text = "Tafel 3";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(31, 243);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 83);
            this.button3.TabIndex = 10;
            this.button3.Text = "Tafel 5";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(31, 332);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(88, 83);
            this.button4.TabIndex = 11;
            this.button4.Text = "Tafel 7";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(31, 421);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(88, 83);
            this.button5.TabIndex = 12;
            this.button5.Text = "Tafel 9";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(148, 65);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(88, 83);
            this.button6.TabIndex = 13;
            this.button6.Text = "Tafel 2";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(148, 154);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(88, 83);
            this.button7.TabIndex = 14;
            this.button7.Text = "Tafel 4";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(148, 243);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(88, 83);
            this.button8.TabIndex = 15;
            this.button8.Text = "Tafel 6";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(148, 332);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(88, 83);
            this.button9.TabIndex = 16;
            this.button9.Text = "Tafel 8";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(148, 421);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(88, 83);
            this.button10.TabIndex = 17;
            this.button10.Text = "Tafel 10";
            this.button10.UseVisualStyleBackColor = true;
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
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button Bill_btnBillOverview;
        private System.Windows.Forms.Label Bill_lblActivePanel;
        private System.Windows.Forms.Label Bill_lblRekeningNietBeschikbaar;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView Bill_lvTables;
        private System.Windows.Forms.Label Bill_lblDisplayTableNumber;
    }
}