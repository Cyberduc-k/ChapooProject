namespace Ui
{
    partial class BarForm
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
            this.Bar_btnOverzicht = new System.Windows.Forms.Button();
            this.Bar_btnVoorraad = new System.Windows.Forms.Button();
            this.Bar_pnlVoorraad = new System.Windows.Forms.Panel();
            this.Bar_lvVoorraad = new System.Windows.Forms.ListView();
            this.Bar_pnlOverzicht = new System.Windows.Forms.Panel();
            this.Bar_lblGeenBestellingen = new System.Windows.Forms.Label();
            this.Bar_pnlOpmerkingen = new System.Windows.Forms.Panel();
            this.Bar_lblOpmerkingenContent = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Bar_pnlOverflow = new System.Windows.Forms.Panel();
            this.Bar_lblOverflow = new System.Windows.Forms.Label();
            this.Bar_pnlFourthOrder = new System.Windows.Forms.Panel();
            this.Bar_lvFourth = new System.Windows.Forms.ListView();
            this.Bar_pnlThirdOrder = new System.Windows.Forms.Panel();
            this.Bar_lvThird = new System.Windows.Forms.ListView();
            this.Bar_pnlSecondOrder = new System.Windows.Forms.Panel();
            this.Bar_lvSecond = new System.Windows.Forms.ListView();
            this.Bar_pnlFirstOrder = new System.Windows.Forms.Panel();
            this.Bar_btnFirstKlaar = new System.Windows.Forms.Button();
            this.Bar_lvFirstOrder = new System.Windows.Forms.ListView();
            this.Bar_lblActivePanel = new System.Windows.Forms.Label();
            this.Bar_btnGereed = new System.Windows.Forms.Button();
            this.Bar_pnlGereed = new System.Windows.Forms.Panel();
            this.Bar_pnlOrders = new System.Windows.Forms.Panel();
            this.Bar_pnlOpmerkingen2 = new System.Windows.Forms.Panel();
            this.Bar_lblOpmerkingeng2 = new System.Windows.Forms.Label();
            this.Chef_lblOpmerkingenContent2 = new System.Windows.Forms.Label();
            this.Bar_pnlVoorraad.SuspendLayout();
            this.Bar_pnlOverzicht.SuspendLayout();
            this.Bar_pnlOpmerkingen.SuspendLayout();
            this.Bar_pnlOverflow.SuspendLayout();
            this.Bar_pnlFourthOrder.SuspendLayout();
            this.Bar_pnlThirdOrder.SuspendLayout();
            this.Bar_pnlSecondOrder.SuspendLayout();
            this.Bar_pnlFirstOrder.SuspendLayout();
            this.Bar_pnlGereed.SuspendLayout();
            this.Bar_pnlOpmerkingen2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Bar_btnOverzicht
            // 
            this.Bar_btnOverzicht.Location = new System.Drawing.Point(18, 71);
            this.Bar_btnOverzicht.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Bar_btnOverzicht.Name = "Bar_btnOverzicht";
            this.Bar_btnOverzicht.Size = new System.Drawing.Size(112, 35);
            this.Bar_btnOverzicht.TabIndex = 0;
            this.Bar_btnOverzicht.Text = "Overzicht";
            this.Bar_btnOverzicht.UseVisualStyleBackColor = true;
            this.Bar_btnOverzicht.Click += new System.EventHandler(this.Bar_btnOverzicht_Click_1);
            // 
            // Bar_btnVoorraad
            // 
            this.Bar_btnVoorraad.Location = new System.Drawing.Point(18, 161);
            this.Bar_btnVoorraad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Bar_btnVoorraad.Name = "Bar_btnVoorraad";
            this.Bar_btnVoorraad.Size = new System.Drawing.Size(112, 35);
            this.Bar_btnVoorraad.TabIndex = 3;
            this.Bar_btnVoorraad.Text = "Voorraad";
            this.Bar_btnVoorraad.UseVisualStyleBackColor = true;
            this.Bar_btnVoorraad.Click += new System.EventHandler(this.Bar_btnVoorraad_Click);
            // 
            // Bar_pnlVoorraad
            // 
            this.Bar_pnlVoorraad.Controls.Add(this.Bar_lvVoorraad);
            this.Bar_pnlVoorraad.Location = new System.Drawing.Point(139, 71);
            this.Bar_pnlVoorraad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Bar_pnlVoorraad.Name = "Bar_pnlVoorraad";
            this.Bar_pnlVoorraad.Size = new System.Drawing.Size(1041, 603);
            this.Bar_pnlVoorraad.TabIndex = 5;
            // 
            // Bar_lvVoorraad
            // 
            this.Bar_lvVoorraad.HideSelection = false;
            this.Bar_lvVoorraad.Location = new System.Drawing.Point(4, 5);
            this.Bar_lvVoorraad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Bar_lvVoorraad.Name = "Bar_lvVoorraad";
            this.Bar_lvVoorraad.Size = new System.Drawing.Size(1030, 592);
            this.Bar_lvVoorraad.TabIndex = 0;
            this.Bar_lvVoorraad.UseCompatibleStateImageBehavior = false;
            this.Bar_lvVoorraad.View = System.Windows.Forms.View.Details;
            // 
            // Bar_pnlOverzicht
            // 
            this.Bar_pnlOverzicht.Controls.Add(this.Bar_lblGeenBestellingen);
            this.Bar_pnlOverzicht.Controls.Add(this.Bar_pnlOpmerkingen);
            this.Bar_pnlOverzicht.Controls.Add(this.Bar_pnlOverflow);
            this.Bar_pnlOverzicht.Controls.Add(this.Bar_pnlFourthOrder);
            this.Bar_pnlOverzicht.Controls.Add(this.Bar_pnlThirdOrder);
            this.Bar_pnlOverzicht.Controls.Add(this.Bar_pnlSecondOrder);
            this.Bar_pnlOverzicht.Controls.Add(this.Bar_pnlFirstOrder);
            this.Bar_pnlOverzicht.Location = new System.Drawing.Point(138, 71);
            this.Bar_pnlOverzicht.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Bar_pnlOverzicht.Name = "Bar_pnlOverzicht";
            this.Bar_pnlOverzicht.Size = new System.Drawing.Size(1041, 603);
            this.Bar_pnlOverzicht.TabIndex = 1;
            // 
            // Bar_lblGeenBestellingen
            // 
            this.Bar_lblGeenBestellingen.AutoSize = true;
            this.Bar_lblGeenBestellingen.Location = new System.Drawing.Point(458, 291);
            this.Bar_lblGeenBestellingen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Bar_lblGeenBestellingen.Name = "Bar_lblGeenBestellingen";
            this.Bar_lblGeenBestellingen.Size = new System.Drawing.Size(138, 20);
            this.Bar_lblGeenBestellingen.TabIndex = 1;
            this.Bar_lblGeenBestellingen.Text = "Geen bestellingen";
            // 
            // Bar_pnlOpmerkingen
            // 
            this.Bar_pnlOpmerkingen.Controls.Add(this.Bar_lblOpmerkingenContent);
            this.Bar_pnlOpmerkingen.Controls.Add(this.listView1);
            this.Bar_pnlOpmerkingen.Location = new System.Drawing.Point(568, 5);
            this.Bar_pnlOpmerkingen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Bar_pnlOpmerkingen.Name = "Bar_pnlOpmerkingen";
            this.Bar_pnlOpmerkingen.Size = new System.Drawing.Size(468, 246);
            this.Bar_pnlOpmerkingen.TabIndex = 1;
            // 
            // Bar_lblOpmerkingenContent
            // 
            this.Bar_lblOpmerkingenContent.AutoSize = true;
            this.Bar_lblOpmerkingenContent.Location = new System.Drawing.Point(204, 100);
            this.Bar_lblOpmerkingenContent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Bar_lblOpmerkingenContent.Name = "Bar_lblOpmerkingenContent";
            this.Bar_lblOpmerkingenContent.Size = new System.Drawing.Size(51, 20);
            this.Bar_lblOpmerkingenContent.TabIndex = 1;
            this.Bar_lblOpmerkingenContent.Text = "label1";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(4, 5);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(457, 235);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Bar_pnlOverflow
            // 
            this.Bar_pnlOverflow.Controls.Add(this.Bar_lblOverflow);
            this.Bar_pnlOverflow.Location = new System.Drawing.Point(914, 397);
            this.Bar_pnlOverflow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Bar_pnlOverflow.Name = "Bar_pnlOverflow";
            this.Bar_pnlOverflow.Size = new System.Drawing.Size(123, 118);
            this.Bar_pnlOverflow.TabIndex = 3;
            // 
            // Bar_lblOverflow
            // 
            this.Bar_lblOverflow.AutoSize = true;
            this.Bar_lblOverflow.Location = new System.Drawing.Point(33, 49);
            this.Bar_lblOverflow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Bar_lblOverflow.Name = "Bar_lblOverflow";
            this.Bar_lblOverflow.Size = new System.Drawing.Size(51, 20);
            this.Bar_lblOverflow.TabIndex = 0;
            this.Bar_lblOverflow.Text = "label1";
            // 
            // Bar_pnlFourthOrder
            // 
            this.Bar_pnlFourthOrder.Controls.Add(this.Bar_lvFourth);
            this.Bar_pnlFourthOrder.Location = new System.Drawing.Point(610, 351);
            this.Bar_pnlFourthOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Bar_pnlFourthOrder.Name = "Bar_pnlFourthOrder";
            this.Bar_pnlFourthOrder.Size = new System.Drawing.Size(294, 197);
            this.Bar_pnlFourthOrder.TabIndex = 2;
            // 
            // Bar_lvFourth
            // 
            this.Bar_lvFourth.HideSelection = false;
            this.Bar_lvFourth.Location = new System.Drawing.Point(6, 6);
            this.Bar_lvFourth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Bar_lvFourth.Name = "Bar_lvFourth";
            this.Bar_lvFourth.Size = new System.Drawing.Size(282, 184);
            this.Bar_lvFourth.TabIndex = 2;
            this.Bar_lvFourth.UseCompatibleStateImageBehavior = false;
            // 
            // Bar_pnlThirdOrder
            // 
            this.Bar_pnlThirdOrder.Controls.Add(this.Bar_lvThird);
            this.Bar_pnlThirdOrder.Location = new System.Drawing.Point(308, 351);
            this.Bar_pnlThirdOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Bar_pnlThirdOrder.Name = "Bar_pnlThirdOrder";
            this.Bar_pnlThirdOrder.Size = new System.Drawing.Size(294, 197);
            this.Bar_pnlThirdOrder.TabIndex = 2;
            // 
            // Bar_lvThird
            // 
            this.Bar_lvThird.HideSelection = false;
            this.Bar_lvThird.Location = new System.Drawing.Point(4, 6);
            this.Bar_lvThird.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Bar_lvThird.Name = "Bar_lvThird";
            this.Bar_lvThird.Size = new System.Drawing.Size(282, 184);
            this.Bar_lvThird.TabIndex = 1;
            this.Bar_lvThird.UseCompatibleStateImageBehavior = false;
            // 
            // Bar_pnlSecondOrder
            // 
            this.Bar_pnlSecondOrder.Controls.Add(this.Bar_lvSecond);
            this.Bar_pnlSecondOrder.Location = new System.Drawing.Point(4, 351);
            this.Bar_pnlSecondOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Bar_pnlSecondOrder.Name = "Bar_pnlSecondOrder";
            this.Bar_pnlSecondOrder.Size = new System.Drawing.Size(294, 197);
            this.Bar_pnlSecondOrder.TabIndex = 1;
            // 
            // Bar_lvSecond
            // 
            this.Bar_lvSecond.HideSelection = false;
            this.Bar_lvSecond.Location = new System.Drawing.Point(6, 6);
            this.Bar_lvSecond.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Bar_lvSecond.Name = "Bar_lvSecond";
            this.Bar_lvSecond.Size = new System.Drawing.Size(282, 184);
            this.Bar_lvSecond.TabIndex = 0;
            this.Bar_lvSecond.UseCompatibleStateImageBehavior = false;
            // 
            // Bar_pnlFirstOrder
            // 
            this.Bar_pnlFirstOrder.Controls.Add(this.Bar_btnFirstKlaar);
            this.Bar_pnlFirstOrder.Controls.Add(this.Bar_lvFirstOrder);
            this.Bar_pnlFirstOrder.Location = new System.Drawing.Point(4, 5);
            this.Bar_pnlFirstOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Bar_pnlFirstOrder.Name = "Bar_pnlFirstOrder";
            this.Bar_pnlFirstOrder.Size = new System.Drawing.Size(468, 246);
            this.Bar_pnlFirstOrder.TabIndex = 0;
            // 
            // Bar_btnFirstKlaar
            // 
            this.Bar_btnFirstKlaar.Location = new System.Drawing.Point(6, 206);
            this.Bar_btnFirstKlaar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Bar_btnFirstKlaar.Name = "Bar_btnFirstKlaar";
            this.Bar_btnFirstKlaar.Size = new System.Drawing.Size(112, 35);
            this.Bar_btnFirstKlaar.TabIndex = 2;
            this.Bar_btnFirstKlaar.Text = "Klaar";
            this.Bar_btnFirstKlaar.UseVisualStyleBackColor = true;
            this.Bar_btnFirstKlaar.Click += new System.EventHandler(this.Bar_btnFirstKlaar_Click_1);
            // 
            // Bar_lvFirstOrder
            // 
            this.Bar_lvFirstOrder.HideSelection = false;
            this.Bar_lvFirstOrder.Location = new System.Drawing.Point(4, 5);
            this.Bar_lvFirstOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Bar_lvFirstOrder.Name = "Bar_lvFirstOrder";
            this.Bar_lvFirstOrder.Size = new System.Drawing.Size(457, 235);
            this.Bar_lvFirstOrder.TabIndex = 0;
            this.Bar_lvFirstOrder.UseCompatibleStateImageBehavior = false;
            // 
            // Bar_lblActivePanel
            // 
            this.Bar_lblActivePanel.AutoSize = true;
            this.Bar_lblActivePanel.Location = new System.Drawing.Point(627, 30);
            this.Bar_lblActivePanel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Bar_lblActivePanel.Name = "Bar_lblActivePanel";
            this.Bar_lblActivePanel.Size = new System.Drawing.Size(75, 20);
            this.Bar_lblActivePanel.TabIndex = 6;
            this.Bar_lblActivePanel.Text = "Overzicht";
            // 
            // Bar_btnGereed
            // 
            this.Bar_btnGereed.Location = new System.Drawing.Point(18, 116);
            this.Bar_btnGereed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Bar_btnGereed.Name = "Bar_btnGereed";
            this.Bar_btnGereed.Size = new System.Drawing.Size(112, 35);
            this.Bar_btnGereed.TabIndex = 7;
            this.Bar_btnGereed.Text = "Gereed";
            this.Bar_btnGereed.UseVisualStyleBackColor = true;
            this.Bar_btnGereed.Click += new System.EventHandler(this.Bar_btnGereed_Click);
            // 
            // Bar_pnlGereed
            // 
            this.Bar_pnlGereed.Controls.Add(this.Bar_pnlOpmerkingen2);
            this.Bar_pnlGereed.Controls.Add(this.Bar_pnlOrders);
            this.Bar_pnlGereed.Location = new System.Drawing.Point(138, 71);
            this.Bar_pnlGereed.Name = "Bar_pnlGereed";
            this.Bar_pnlGereed.Size = new System.Drawing.Size(1042, 603);
            this.Bar_pnlGereed.TabIndex = 4;
            // 
            // Bar_pnlOrders
            // 
            this.Bar_pnlOrders.Location = new System.Drawing.Point(10, 10);
            this.Bar_pnlOrders.Name = "Bar_pnlOrders";
            this.Bar_pnlOrders.Size = new System.Drawing.Size(510, 587);
            this.Bar_pnlOrders.TabIndex = 2;
            // 
            // Bar_pnlOpmerkingen2
            // 
            this.Bar_pnlOpmerkingen2.Controls.Add(this.Chef_lblOpmerkingenContent2);
            this.Bar_pnlOpmerkingen2.Controls.Add(this.Bar_lblOpmerkingeng2);
            this.Bar_pnlOpmerkingen2.Location = new System.Drawing.Point(526, 10);
            this.Bar_pnlOpmerkingen2.Name = "Bar_pnlOpmerkingen2";
            this.Bar_pnlOpmerkingen2.Size = new System.Drawing.Size(510, 301);
            this.Bar_pnlOpmerkingen2.TabIndex = 3;
            // 
            // Bar_lblOpmerkingeng2
            // 
            this.Bar_lblOpmerkingeng2.AutoSize = true;
            this.Bar_lblOpmerkingeng2.Location = new System.Drawing.Point(17, 17);
            this.Bar_lblOpmerkingeng2.Name = "Bar_lblOpmerkingeng2";
            this.Bar_lblOpmerkingeng2.Size = new System.Drawing.Size(104, 20);
            this.Bar_lblOpmerkingeng2.TabIndex = 0;
            this.Bar_lblOpmerkingeng2.Text = "Opmerkingen";
            // 
            // Chef_lblOpmerkingenContent2
            // 
            this.Chef_lblOpmerkingenContent2.AutoSize = true;
            this.Chef_lblOpmerkingenContent2.Location = new System.Drawing.Point(19, 50);
            this.Chef_lblOpmerkingenContent2.Name = "Chef_lblOpmerkingenContent2";
            this.Chef_lblOpmerkingenContent2.Size = new System.Drawing.Size(0, 20);
            this.Chef_lblOpmerkingenContent2.TabIndex = 1;
            // 
            // BarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 692);
            this.Controls.Add(this.Bar_pnlGereed);
            this.Controls.Add(this.Bar_btnGereed);
            this.Controls.Add(this.Bar_pnlOverzicht);
            this.Controls.Add(this.Bar_lblActivePanel);
            this.Controls.Add(this.Bar_pnlVoorraad);
            this.Controls.Add(this.Bar_btnVoorraad);
            this.Controls.Add(this.Bar_btnOverzicht);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BarForm";
            this.Text = "BarForm";
            this.Bar_pnlVoorraad.ResumeLayout(false);
            this.Bar_pnlOverzicht.ResumeLayout(false);
            this.Bar_pnlOverzicht.PerformLayout();
            this.Bar_pnlOpmerkingen.ResumeLayout(false);
            this.Bar_pnlOpmerkingen.PerformLayout();
            this.Bar_pnlOverflow.ResumeLayout(false);
            this.Bar_pnlOverflow.PerformLayout();
            this.Bar_pnlFourthOrder.ResumeLayout(false);
            this.Bar_pnlThirdOrder.ResumeLayout(false);
            this.Bar_pnlSecondOrder.ResumeLayout(false);
            this.Bar_pnlFirstOrder.ResumeLayout(false);
            this.Bar_pnlGereed.ResumeLayout(false);
            this.Bar_pnlOpmerkingen2.ResumeLayout(false);
            this.Bar_pnlOpmerkingen2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bar_btnOverzicht;
        private System.Windows.Forms.Button Bar_btnVoorraad;
        private System.Windows.Forms.Panel Bar_pnlVoorraad;
        private System.Windows.Forms.ListView Bar_lvVoorraad;
        private System.Windows.Forms.Label Bar_lblActivePanel;
        private System.Windows.Forms.Panel Bar_pnlOverzicht;
        private System.Windows.Forms.Panel Bar_pnlFirstOrder;
        private System.Windows.Forms.Panel Bar_pnlFourthOrder;
        private System.Windows.Forms.Panel Bar_pnlThirdOrder;
        private System.Windows.Forms.Panel Bar_pnlSecondOrder;
        private System.Windows.Forms.Panel Bar_pnlOverflow;
        private System.Windows.Forms.Panel Bar_pnlOpmerkingen;
        private System.Windows.Forms.ListView Bar_lvSecond;
        private System.Windows.Forms.ListView Bar_lvFourth;
        private System.Windows.Forms.ListView Bar_lvThird;
        private System.Windows.Forms.Label Bar_lblOverflow;
        private System.Windows.Forms.ListView Bar_lvFirstOrder;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label Bar_lblOpmerkingenContent;
        private System.Windows.Forms.Label Bar_lblGeenBestellingen;
        private System.Windows.Forms.Button Bar_btnFirstKlaar;
        private System.Windows.Forms.Button Bar_btnGereed;
        private System.Windows.Forms.Panel Bar_pnlGereed;
        private System.Windows.Forms.Panel Bar_pnlOrders;
        private System.Windows.Forms.Panel Bar_pnlOpmerkingen2;
        private System.Windows.Forms.Label Bar_lblOpmerkingeng2;
        private System.Windows.Forms.Label Chef_lblOpmerkingenContent2;
    }
}