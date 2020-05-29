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
            this.Bar_btnBestellen = new System.Windows.Forms.Button();
            this.Bar_pnlVoorraad = new System.Windows.Forms.Panel();
            this.Bar_pnlOverzicht = new System.Windows.Forms.Panel();
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
            this.Bar_lblGeenBestellingen = new System.Windows.Forms.Label();
            this.Bar_lvFirstOrder = new System.Windows.Forms.ListView();
            this.Bar_lvVoorraad = new System.Windows.Forms.ListView();
            this.Bar_lblActivePanel = new System.Windows.Forms.Label();
            this.Bar_btnFirstKlaar = new System.Windows.Forms.Button();
            this.Bar_pnlVoorraad.SuspendLayout();
            this.Bar_pnlOverzicht.SuspendLayout();
            this.Bar_pnlOpmerkingen.SuspendLayout();
            this.Bar_pnlOverflow.SuspendLayout();
            this.Bar_pnlFourthOrder.SuspendLayout();
            this.Bar_pnlThirdOrder.SuspendLayout();
            this.Bar_pnlSecondOrder.SuspendLayout();
            this.Bar_pnlFirstOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // Bar_btnOverzicht
            // 
            this.Bar_btnOverzicht.Location = new System.Drawing.Point(12, 46);
            this.Bar_btnOverzicht.Name = "Bar_btnOverzicht";
            this.Bar_btnOverzicht.Size = new System.Drawing.Size(75, 23);
            this.Bar_btnOverzicht.TabIndex = 0;
            this.Bar_btnOverzicht.Text = "Overzicht";
            this.Bar_btnOverzicht.UseVisualStyleBackColor = true;
            this.Bar_btnOverzicht.Click += new System.EventHandler(this.Bar_btnOverzicht_Click_1);
            // 
            // Bar_btnVoorraad
            // 
            this.Bar_btnVoorraad.Location = new System.Drawing.Point(12, 75);
            this.Bar_btnVoorraad.Name = "Bar_btnVoorraad";
            this.Bar_btnVoorraad.Size = new System.Drawing.Size(75, 23);
            this.Bar_btnVoorraad.TabIndex = 3;
            this.Bar_btnVoorraad.Text = "Voorraad";
            this.Bar_btnVoorraad.UseVisualStyleBackColor = true;
            this.Bar_btnVoorraad.Click += new System.EventHandler(this.Bar_btnVoorraad_Click);
            // 
            // Bar_btnBestellen
            // 
            this.Bar_btnBestellen.Location = new System.Drawing.Point(12, 104);
            this.Bar_btnBestellen.Name = "Bar_btnBestellen";
            this.Bar_btnBestellen.Size = new System.Drawing.Size(75, 23);
            this.Bar_btnBestellen.TabIndex = 4;
            this.Bar_btnBestellen.Text = "Bestellen";
            this.Bar_btnBestellen.UseVisualStyleBackColor = true;
            this.Bar_btnBestellen.Click += new System.EventHandler(this.Bar_btnBestellen_Click_1);
            // 
            // Bar_pnlVoorraad
            // 
            this.Bar_pnlVoorraad.Controls.Add(this.Bar_pnlOverzicht);
            this.Bar_pnlVoorraad.Controls.Add(this.Bar_lvVoorraad);
            this.Bar_pnlVoorraad.Location = new System.Drawing.Point(94, 46);
            this.Bar_pnlVoorraad.Name = "Bar_pnlVoorraad";
            this.Bar_pnlVoorraad.Size = new System.Drawing.Size(694, 392);
            this.Bar_pnlVoorraad.TabIndex = 5;
            // 
            // Bar_pnlOverzicht
            // 
            this.Bar_pnlOverzicht.Controls.Add(this.Bar_pnlOpmerkingen);
            this.Bar_pnlOverzicht.Controls.Add(this.Bar_pnlOverflow);
            this.Bar_pnlOverzicht.Controls.Add(this.Bar_pnlFourthOrder);
            this.Bar_pnlOverzicht.Controls.Add(this.Bar_pnlThirdOrder);
            this.Bar_pnlOverzicht.Controls.Add(this.Bar_pnlSecondOrder);
            this.Bar_pnlOverzicht.Controls.Add(this.Bar_pnlFirstOrder);
            this.Bar_pnlOverzicht.Location = new System.Drawing.Point(0, 0);
            this.Bar_pnlOverzicht.Name = "Bar_pnlOverzicht";
            this.Bar_pnlOverzicht.Size = new System.Drawing.Size(694, 392);
            this.Bar_pnlOverzicht.TabIndex = 1;
            // 
            // Bar_pnlOpmerkingen
            // 
            this.Bar_pnlOpmerkingen.Controls.Add(this.Bar_lblOpmerkingenContent);
            this.Bar_pnlOpmerkingen.Controls.Add(this.listView1);
            this.Bar_pnlOpmerkingen.Location = new System.Drawing.Point(379, 3);
            this.Bar_pnlOpmerkingen.Name = "Bar_pnlOpmerkingen";
            this.Bar_pnlOpmerkingen.Size = new System.Drawing.Size(312, 160);
            this.Bar_pnlOpmerkingen.TabIndex = 1;
            // 
            // Bar_lblOpmerkingenContent
            // 
            this.Bar_lblOpmerkingenContent.AutoSize = true;
            this.Bar_lblOpmerkingenContent.Location = new System.Drawing.Point(136, 65);
            this.Bar_lblOpmerkingenContent.Name = "Bar_lblOpmerkingenContent";
            this.Bar_lblOpmerkingenContent.Size = new System.Drawing.Size(35, 13);
            this.Bar_lblOpmerkingenContent.TabIndex = 1;
            this.Bar_lblOpmerkingenContent.Text = "label1";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(306, 154);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Bar_pnlOverflow
            // 
            this.Bar_pnlOverflow.Controls.Add(this.Bar_lblOverflow);
            this.Bar_pnlOverflow.Location = new System.Drawing.Point(609, 258);
            this.Bar_pnlOverflow.Name = "Bar_pnlOverflow";
            this.Bar_pnlOverflow.Size = new System.Drawing.Size(82, 77);
            this.Bar_pnlOverflow.TabIndex = 3;
            // 
            // Bar_lblOverflow
            // 
            this.Bar_lblOverflow.AutoSize = true;
            this.Bar_lblOverflow.Location = new System.Drawing.Point(22, 32);
            this.Bar_lblOverflow.Name = "Bar_lblOverflow";
            this.Bar_lblOverflow.Size = new System.Drawing.Size(35, 13);
            this.Bar_lblOverflow.TabIndex = 0;
            this.Bar_lblOverflow.Text = "label1";
            // 
            // Bar_pnlFourthOrder
            // 
            this.Bar_pnlFourthOrder.Controls.Add(this.Bar_lvFourth);
            this.Bar_pnlFourthOrder.Location = new System.Drawing.Point(407, 228);
            this.Bar_pnlFourthOrder.Name = "Bar_pnlFourthOrder";
            this.Bar_pnlFourthOrder.Size = new System.Drawing.Size(196, 128);
            this.Bar_pnlFourthOrder.TabIndex = 2;
            // 
            // Bar_lvFourth
            // 
            this.Bar_lvFourth.HideSelection = false;
            this.Bar_lvFourth.Location = new System.Drawing.Point(4, 4);
            this.Bar_lvFourth.Name = "Bar_lvFourth";
            this.Bar_lvFourth.Size = new System.Drawing.Size(189, 121);
            this.Bar_lvFourth.TabIndex = 2;
            this.Bar_lvFourth.UseCompatibleStateImageBehavior = false;
            // 
            // Bar_pnlThirdOrder
            // 
            this.Bar_pnlThirdOrder.Controls.Add(this.Bar_lvThird);
            this.Bar_pnlThirdOrder.Location = new System.Drawing.Point(205, 228);
            this.Bar_pnlThirdOrder.Name = "Bar_pnlThirdOrder";
            this.Bar_pnlThirdOrder.Size = new System.Drawing.Size(196, 128);
            this.Bar_pnlThirdOrder.TabIndex = 2;
            // 
            // Bar_lvThird
            // 
            this.Bar_lvThird.HideSelection = false;
            this.Bar_lvThird.Location = new System.Drawing.Point(3, 4);
            this.Bar_lvThird.Name = "Bar_lvThird";
            this.Bar_lvThird.Size = new System.Drawing.Size(189, 121);
            this.Bar_lvThird.TabIndex = 1;
            this.Bar_lvThird.UseCompatibleStateImageBehavior = false;
            // 
            // Bar_pnlSecondOrder
            // 
            this.Bar_pnlSecondOrder.Controls.Add(this.Bar_lvSecond);
            this.Bar_pnlSecondOrder.Location = new System.Drawing.Point(3, 228);
            this.Bar_pnlSecondOrder.Name = "Bar_pnlSecondOrder";
            this.Bar_pnlSecondOrder.Size = new System.Drawing.Size(196, 128);
            this.Bar_pnlSecondOrder.TabIndex = 1;
            // 
            // Bar_lvSecond
            // 
            this.Bar_lvSecond.HideSelection = false;
            this.Bar_lvSecond.Location = new System.Drawing.Point(4, 4);
            this.Bar_lvSecond.Name = "Bar_lvSecond";
            this.Bar_lvSecond.Size = new System.Drawing.Size(189, 121);
            this.Bar_lvSecond.TabIndex = 0;
            this.Bar_lvSecond.UseCompatibleStateImageBehavior = false;
            // 
            // Bar_pnlFirstOrder
            // 
            this.Bar_pnlFirstOrder.Controls.Add(this.Bar_btnFirstKlaar);
            this.Bar_pnlFirstOrder.Controls.Add(this.Bar_lblGeenBestellingen);
            this.Bar_pnlFirstOrder.Controls.Add(this.Bar_lvFirstOrder);
            this.Bar_pnlFirstOrder.Location = new System.Drawing.Point(3, 3);
            this.Bar_pnlFirstOrder.Name = "Bar_pnlFirstOrder";
            this.Bar_pnlFirstOrder.Size = new System.Drawing.Size(312, 160);
            this.Bar_pnlFirstOrder.TabIndex = 0;
            // 
            // Bar_lblGeenBestellingen
            // 
            this.Bar_lblGeenBestellingen.AutoSize = true;
            this.Bar_lblGeenBestellingen.Location = new System.Drawing.Point(137, 65);
            this.Bar_lblGeenBestellingen.Name = "Bar_lblGeenBestellingen";
            this.Bar_lblGeenBestellingen.Size = new System.Drawing.Size(35, 13);
            this.Bar_lblGeenBestellingen.TabIndex = 1;
            this.Bar_lblGeenBestellingen.Text = "label1";
            // 
            // Bar_lvFirstOrder
            // 
            this.Bar_lvFirstOrder.HideSelection = false;
            this.Bar_lvFirstOrder.Location = new System.Drawing.Point(3, 3);
            this.Bar_lvFirstOrder.Name = "Bar_lvFirstOrder";
            this.Bar_lvFirstOrder.Size = new System.Drawing.Size(306, 154);
            this.Bar_lvFirstOrder.TabIndex = 0;
            this.Bar_lvFirstOrder.UseCompatibleStateImageBehavior = false;
            // 
            // Bar_lvVoorraad
            // 
            this.Bar_lvVoorraad.HideSelection = false;
            this.Bar_lvVoorraad.Location = new System.Drawing.Point(3, 3);
            this.Bar_lvVoorraad.Name = "Bar_lvVoorraad";
            this.Bar_lvVoorraad.Size = new System.Drawing.Size(688, 386);
            this.Bar_lvVoorraad.TabIndex = 0;
            this.Bar_lvVoorraad.UseCompatibleStateImageBehavior = false;
            // 
            // Bar_lblActivePanel
            // 
            this.Bar_lblActivePanel.AutoSize = true;
            this.Bar_lblActivePanel.Location = new System.Drawing.Point(423, 9);
            this.Bar_lblActivePanel.Name = "Bar_lblActivePanel";
            this.Bar_lblActivePanel.Size = new System.Drawing.Size(35, 13);
            this.Bar_lblActivePanel.TabIndex = 6;
            this.Bar_lblActivePanel.Text = "label1";
            // 
            // Bar_btnFirstKlaar
            // 
            this.Bar_btnFirstKlaar.Location = new System.Drawing.Point(4, 134);
            this.Bar_btnFirstKlaar.Name = "Bar_btnFirstKlaar";
            this.Bar_btnFirstKlaar.Size = new System.Drawing.Size(75, 23);
            this.Bar_btnFirstKlaar.TabIndex = 2;
            this.Bar_btnFirstKlaar.Text = "Klaar";
            this.Bar_btnFirstKlaar.UseVisualStyleBackColor = true;
            this.Bar_btnFirstKlaar.Click += new System.EventHandler(this.Bar_btnFirstKlaar_Click_1);
            // 
            // BarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Bar_lblActivePanel);
            this.Controls.Add(this.Bar_pnlVoorraad);
            this.Controls.Add(this.Bar_btnBestellen);
            this.Controls.Add(this.Bar_btnVoorraad);
            this.Controls.Add(this.Bar_btnOverzicht);
            this.Name = "BarForm";
            this.Text = "BarForm";
            this.Bar_pnlVoorraad.ResumeLayout(false);
            this.Bar_pnlOverzicht.ResumeLayout(false);
            this.Bar_pnlOpmerkingen.ResumeLayout(false);
            this.Bar_pnlOpmerkingen.PerformLayout();
            this.Bar_pnlOverflow.ResumeLayout(false);
            this.Bar_pnlOverflow.PerformLayout();
            this.Bar_pnlFourthOrder.ResumeLayout(false);
            this.Bar_pnlThirdOrder.ResumeLayout(false);
            this.Bar_pnlSecondOrder.ResumeLayout(false);
            this.Bar_pnlFirstOrder.ResumeLayout(false);
            this.Bar_pnlFirstOrder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bar_btnOverzicht;
        private System.Windows.Forms.Button Bar_btnVoorraad;
        private System.Windows.Forms.Button Bar_btnBestellen;
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
    }
}