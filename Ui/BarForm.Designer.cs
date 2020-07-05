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
            this.Bar_btnRefresh = new System.Windows.Forms.Button();
            this.Bar_lblGeenBestellingen = new System.Windows.Forms.Label();
            this.Bar_pnlOpmerkingen = new System.Windows.Forms.Panel();
            this.Bar_lblOpmerkingenContent = new System.Windows.Forms.Label();
            this.Bar_lblOpmerkingen = new System.Windows.Forms.Label();
            this.Bar_pnlOverflow = new System.Windows.Forms.Panel();
            this.Bar_lblOverflow = new System.Windows.Forms.Label();
            this.Bar_pnlFourthOrder = new System.Windows.Forms.Panel();
            this.Bar_lblBesteldOpFourth = new System.Windows.Forms.Label();
            this.Bar_lblTafelFourth = new System.Windows.Forms.Label();
            this.Bar_lvFourth = new System.Windows.Forms.ListView();
            this.Bar_pnlThirdOrder = new System.Windows.Forms.Panel();
            this.Bar_lblBesteldOpThird = new System.Windows.Forms.Label();
            this.Bar_lblTafelThird = new System.Windows.Forms.Label();
            this.Bar_lvThird = new System.Windows.Forms.ListView();
            this.Bar_pnlSecondOrder = new System.Windows.Forms.Panel();
            this.Bar_lblBesteldOpSecond = new System.Windows.Forms.Label();
            this.Bar_lblTafelSecond = new System.Windows.Forms.Label();
            this.Bar_lvSecond = new System.Windows.Forms.ListView();
            this.Bar_pnlFirstOrder = new System.Windows.Forms.Panel();
            this.Bar_lblBesteldOpFirst = new System.Windows.Forms.Label();
            this.Bar_lblTafelFirst = new System.Windows.Forms.Label();
            this.Bar_btnFirstKlaar = new System.Windows.Forms.Button();
            this.Bar_lvFirst = new System.Windows.Forms.ListView();
            this.Bar_lblActivePanel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Bar_lblActivePanel1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Bar_btnUitloggen = new System.Windows.Forms.Button();
            this.Bar_pnlVoorraad.SuspendLayout();
            this.Bar_pnlOverzicht.SuspendLayout();
            this.Bar_pnlOpmerkingen.SuspendLayout();
            this.Bar_pnlOverflow.SuspendLayout();
            this.Bar_pnlFourthOrder.SuspendLayout();
            this.Bar_pnlThirdOrder.SuspendLayout();
            this.Bar_pnlSecondOrder.SuspendLayout();
            this.Bar_pnlFirstOrder.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Bar_btnOverzicht
            // 
            this.Bar_btnOverzicht.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.Bar_btnOverzicht.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bar_btnOverzicht.ForeColor = System.Drawing.Color.White;
            this.Bar_btnOverzicht.Location = new System.Drawing.Point(0, 2);
            this.Bar_btnOverzicht.Name = "Bar_btnOverzicht";
            this.Bar_btnOverzicht.Size = new System.Drawing.Size(95, 29);
            this.Bar_btnOverzicht.TabIndex = 0;
            this.Bar_btnOverzicht.Text = "Overzicht";
            this.Bar_btnOverzicht.UseVisualStyleBackColor = false;
            this.Bar_btnOverzicht.Click += new System.EventHandler(this.Bar_btnOverzicht_Click_1);
            // 
            // Bar_btnVoorraad
            // 
            this.Bar_btnVoorraad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(204)))));
            this.Bar_btnVoorraad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bar_btnVoorraad.ForeColor = System.Drawing.Color.White;
            this.Bar_btnVoorraad.Location = new System.Drawing.Point(0, 30);
            this.Bar_btnVoorraad.Name = "Bar_btnVoorraad";
            this.Bar_btnVoorraad.Size = new System.Drawing.Size(95, 29);
            this.Bar_btnVoorraad.TabIndex = 3;
            this.Bar_btnVoorraad.Text = "Voorraad";
            this.Bar_btnVoorraad.UseVisualStyleBackColor = false;
            this.Bar_btnVoorraad.Click += new System.EventHandler(this.Bar_btnVoorraad_Click);
            // 
            // Bar_pnlVoorraad
            // 
            this.Bar_pnlVoorraad.Controls.Add(this.Bar_lvVoorraad);
            this.Bar_pnlVoorraad.Location = new System.Drawing.Point(93, 46);
            this.Bar_pnlVoorraad.Name = "Bar_pnlVoorraad";
            this.Bar_pnlVoorraad.Size = new System.Drawing.Size(694, 392);
            this.Bar_pnlVoorraad.TabIndex = 5;
            // 
            // Bar_lvVoorraad
            // 
            this.Bar_lvVoorraad.HideSelection = false;
            this.Bar_lvVoorraad.Location = new System.Drawing.Point(3, 3);
            this.Bar_lvVoorraad.Name = "Bar_lvVoorraad";
            this.Bar_lvVoorraad.Size = new System.Drawing.Size(688, 386);
            this.Bar_lvVoorraad.TabIndex = 0;
            this.Bar_lvVoorraad.UseCompatibleStateImageBehavior = false;
            this.Bar_lvVoorraad.View = System.Windows.Forms.View.Details;
            this.Bar_lvVoorraad.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.Bar_lvVoorraad_ColumnClickk);
            // 
            // Bar_pnlOverzicht
            // 
            this.Bar_pnlOverzicht.BackColor = System.Drawing.Color.White;
            this.Bar_pnlOverzicht.Controls.Add(this.Bar_btnRefresh);
            this.Bar_pnlOverzicht.Controls.Add(this.Bar_lblGeenBestellingen);
            this.Bar_pnlOverzicht.Controls.Add(this.Bar_pnlOpmerkingen);
            this.Bar_pnlOverzicht.Controls.Add(this.Bar_pnlOverflow);
            this.Bar_pnlOverzicht.Controls.Add(this.Bar_pnlFourthOrder);
            this.Bar_pnlOverzicht.Controls.Add(this.Bar_pnlThirdOrder);
            this.Bar_pnlOverzicht.Controls.Add(this.Bar_pnlSecondOrder);
            this.Bar_pnlOverzicht.Controls.Add(this.Bar_pnlFirstOrder);
            this.Bar_pnlOverzicht.ForeColor = System.Drawing.Color.Black;
            this.Bar_pnlOverzicht.Location = new System.Drawing.Point(94, 48);
            this.Bar_pnlOverzicht.Name = "Bar_pnlOverzicht";
            this.Bar_pnlOverzicht.Size = new System.Drawing.Size(694, 392);
            this.Bar_pnlOverzicht.TabIndex = 1;
            // 
            // Bar_btnRefresh
            // 
            this.Bar_btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(204)))));
            this.Bar_btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bar_btnRefresh.ForeColor = System.Drawing.Color.White;
            this.Bar_btnRefresh.Location = new System.Drawing.Point(609, 361);
            this.Bar_btnRefresh.Name = "Bar_btnRefresh";
            this.Bar_btnRefresh.Size = new System.Drawing.Size(81, 25);
            this.Bar_btnRefresh.TabIndex = 5;
            this.Bar_btnRefresh.Text = "Refresh";
            this.Bar_btnRefresh.UseVisualStyleBackColor = false;
            this.Bar_btnRefresh.Click += new System.EventHandler(this.Bar_btnRefresh_Click);
            // 
            // Bar_lblGeenBestellingen
            // 
            this.Bar_lblGeenBestellingen.AutoSize = true;
            this.Bar_lblGeenBestellingen.Location = new System.Drawing.Point(305, 189);
            this.Bar_lblGeenBestellingen.Name = "Bar_lblGeenBestellingen";
            this.Bar_lblGeenBestellingen.Size = new System.Drawing.Size(92, 13);
            this.Bar_lblGeenBestellingen.TabIndex = 1;
            this.Bar_lblGeenBestellingen.Text = "Geen bestellingen";
            // 
            // Bar_pnlOpmerkingen
            // 
            this.Bar_pnlOpmerkingen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Bar_pnlOpmerkingen.Controls.Add(this.Bar_lblOpmerkingenContent);
            this.Bar_pnlOpmerkingen.Controls.Add(this.Bar_lblOpmerkingen);
            this.Bar_pnlOpmerkingen.Location = new System.Drawing.Point(379, 3);
            this.Bar_pnlOpmerkingen.Name = "Bar_pnlOpmerkingen";
            this.Bar_pnlOpmerkingen.Size = new System.Drawing.Size(313, 161);
            this.Bar_pnlOpmerkingen.TabIndex = 1;
            // 
            // Bar_lblOpmerkingenContent
            // 
            this.Bar_lblOpmerkingenContent.AutoSize = true;
            this.Bar_lblOpmerkingenContent.BackColor = System.Drawing.Color.White;
            this.Bar_lblOpmerkingenContent.Location = new System.Drawing.Point(9, 25);
            this.Bar_lblOpmerkingenContent.MinimumSize = new System.Drawing.Size(293, 130);
            this.Bar_lblOpmerkingenContent.Name = "Bar_lblOpmerkingenContent";
            this.Bar_lblOpmerkingenContent.Size = new System.Drawing.Size(293, 130);
            this.Bar_lblOpmerkingenContent.TabIndex = 2;
            // 
            // Bar_lblOpmerkingen
            // 
            this.Bar_lblOpmerkingen.AutoSize = true;
            this.Bar_lblOpmerkingen.Location = new System.Drawing.Point(9, 6);
            this.Bar_lblOpmerkingen.Name = "Bar_lblOpmerkingen";
            this.Bar_lblOpmerkingen.Size = new System.Drawing.Size(61, 13);
            this.Bar_lblOpmerkingen.TabIndex = 1;
            this.Bar_lblOpmerkingen.Text = "Opmerking:";
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
            this.Bar_pnlFourthOrder.Controls.Add(this.Bar_lblBesteldOpFourth);
            this.Bar_pnlFourthOrder.Controls.Add(this.Bar_lblTafelFourth);
            this.Bar_pnlFourthOrder.Controls.Add(this.Bar_lvFourth);
            this.Bar_pnlFourthOrder.Location = new System.Drawing.Point(407, 228);
            this.Bar_pnlFourthOrder.Name = "Bar_pnlFourthOrder";
            this.Bar_pnlFourthOrder.Size = new System.Drawing.Size(196, 128);
            this.Bar_pnlFourthOrder.TabIndex = 2;
            // 
            // Bar_lblBesteldOpFourth
            // 
            this.Bar_lblBesteldOpFourth.AutoSize = true;
            this.Bar_lblBesteldOpFourth.Location = new System.Drawing.Point(71, 105);
            this.Bar_lblBesteldOpFourth.Name = "Bar_lblBesteldOpFourth";
            this.Bar_lblBesteldOpFourth.Size = new System.Drawing.Size(60, 13);
            this.Bar_lblBesteldOpFourth.TabIndex = 7;
            this.Bar_lblBesteldOpFourth.Text = "Besteld op:";
            // 
            // Bar_lblTafelFourth
            // 
            this.Bar_lblTafelFourth.AutoSize = true;
            this.Bar_lblTafelFourth.Location = new System.Drawing.Point(12, 105);
            this.Bar_lblTafelFourth.Name = "Bar_lblTafelFourth";
            this.Bar_lblTafelFourth.Size = new System.Drawing.Size(37, 13);
            this.Bar_lblTafelFourth.TabIndex = 6;
            this.Bar_lblTafelFourth.Text = "Tafel: ";
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
            this.Bar_pnlThirdOrder.Controls.Add(this.Bar_lblBesteldOpThird);
            this.Bar_pnlThirdOrder.Controls.Add(this.Bar_lblTafelThird);
            this.Bar_pnlThirdOrder.Controls.Add(this.Bar_lvThird);
            this.Bar_pnlThirdOrder.Location = new System.Drawing.Point(205, 228);
            this.Bar_pnlThirdOrder.Name = "Bar_pnlThirdOrder";
            this.Bar_pnlThirdOrder.Size = new System.Drawing.Size(196, 128);
            this.Bar_pnlThirdOrder.TabIndex = 2;
            // 
            // Bar_lblBesteldOpThird
            // 
            this.Bar_lblBesteldOpThird.AutoSize = true;
            this.Bar_lblBesteldOpThird.Location = new System.Drawing.Point(71, 105);
            this.Bar_lblBesteldOpThird.Name = "Bar_lblBesteldOpThird";
            this.Bar_lblBesteldOpThird.Size = new System.Drawing.Size(60, 13);
            this.Bar_lblBesteldOpThird.TabIndex = 6;
            this.Bar_lblBesteldOpThird.Text = "Besteld op:";
            // 
            // Bar_lblTafelThird
            // 
            this.Bar_lblTafelThird.AutoSize = true;
            this.Bar_lblTafelThird.Location = new System.Drawing.Point(11, 105);
            this.Bar_lblTafelThird.Name = "Bar_lblTafelThird";
            this.Bar_lblTafelThird.Size = new System.Drawing.Size(37, 13);
            this.Bar_lblTafelThird.TabIndex = 6;
            this.Bar_lblTafelThird.Text = "Tafel: ";
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
            this.Bar_pnlSecondOrder.Controls.Add(this.Bar_lblBesteldOpSecond);
            this.Bar_pnlSecondOrder.Controls.Add(this.Bar_lblTafelSecond);
            this.Bar_pnlSecondOrder.Controls.Add(this.Bar_lvSecond);
            this.Bar_pnlSecondOrder.Location = new System.Drawing.Point(3, 228);
            this.Bar_pnlSecondOrder.Name = "Bar_pnlSecondOrder";
            this.Bar_pnlSecondOrder.Size = new System.Drawing.Size(196, 128);
            this.Bar_pnlSecondOrder.TabIndex = 1;
            // 
            // Bar_lblBesteldOpSecond
            // 
            this.Bar_lblBesteldOpSecond.AutoSize = true;
            this.Bar_lblBesteldOpSecond.Location = new System.Drawing.Point(69, 105);
            this.Bar_lblBesteldOpSecond.Name = "Bar_lblBesteldOpSecond";
            this.Bar_lblBesteldOpSecond.Size = new System.Drawing.Size(60, 13);
            this.Bar_lblBesteldOpSecond.TabIndex = 5;
            this.Bar_lblBesteldOpSecond.Text = "Besteld op:";
            // 
            // Bar_lblTafelSecond
            // 
            this.Bar_lblTafelSecond.AutoSize = true;
            this.Bar_lblTafelSecond.Location = new System.Drawing.Point(11, 105);
            this.Bar_lblTafelSecond.Name = "Bar_lblTafelSecond";
            this.Bar_lblTafelSecond.Size = new System.Drawing.Size(37, 13);
            this.Bar_lblTafelSecond.TabIndex = 5;
            this.Bar_lblTafelSecond.Text = "Tafel: ";
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
            this.Bar_pnlFirstOrder.Controls.Add(this.Bar_lblBesteldOpFirst);
            this.Bar_pnlFirstOrder.Controls.Add(this.Bar_lblTafelFirst);
            this.Bar_pnlFirstOrder.Controls.Add(this.Bar_btnFirstKlaar);
            this.Bar_pnlFirstOrder.Controls.Add(this.Bar_lvFirst);
            this.Bar_pnlFirstOrder.Location = new System.Drawing.Point(3, 3);
            this.Bar_pnlFirstOrder.Name = "Bar_pnlFirstOrder";
            this.Bar_pnlFirstOrder.Size = new System.Drawing.Size(312, 160);
            this.Bar_pnlFirstOrder.TabIndex = 0;
            // 
            // Bar_lblBesteldOpFirst
            // 
            this.Bar_lblBesteldOpFirst.AutoSize = true;
            this.Bar_lblBesteldOpFirst.Location = new System.Drawing.Point(186, 138);
            this.Bar_lblBesteldOpFirst.Name = "Bar_lblBesteldOpFirst";
            this.Bar_lblBesteldOpFirst.Size = new System.Drawing.Size(60, 13);
            this.Bar_lblBesteldOpFirst.TabIndex = 4;
            this.Bar_lblBesteldOpFirst.Text = "Besteld op:";
            // 
            // Bar_lblTafelFirst
            // 
            this.Bar_lblTafelFirst.AutoSize = true;
            this.Bar_lblTafelFirst.Location = new System.Drawing.Point(84, 138);
            this.Bar_lblTafelFirst.Name = "Bar_lblTafelFirst";
            this.Bar_lblTafelFirst.Size = new System.Drawing.Size(37, 13);
            this.Bar_lblTafelFirst.TabIndex = 3;
            this.Bar_lblTafelFirst.Text = "Tafel: ";
            // 
            // Bar_btnFirstKlaar
            // 
            this.Bar_btnFirstKlaar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(204)))));
            this.Bar_btnFirstKlaar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bar_btnFirstKlaar.ForeColor = System.Drawing.Color.White;
            this.Bar_btnFirstKlaar.Location = new System.Drawing.Point(4, 132);
            this.Bar_btnFirstKlaar.Name = "Bar_btnFirstKlaar";
            this.Bar_btnFirstKlaar.Size = new System.Drawing.Size(75, 23);
            this.Bar_btnFirstKlaar.TabIndex = 2;
            this.Bar_btnFirstKlaar.Text = "Klaar";
            this.Bar_btnFirstKlaar.UseVisualStyleBackColor = false;
            this.Bar_btnFirstKlaar.Click += new System.EventHandler(this.Bar_btnFirstKlaar_Click_1);
            // 
            // Bar_lvFirst
            // 
            this.Bar_lvFirst.HideSelection = false;
            this.Bar_lvFirst.Location = new System.Drawing.Point(3, 3);
            this.Bar_lvFirst.Name = "Bar_lvFirst";
            this.Bar_lvFirst.Size = new System.Drawing.Size(306, 154);
            this.Bar_lvFirst.TabIndex = 0;
            this.Bar_lvFirst.UseCompatibleStateImageBehavior = false;
            this.Bar_lvFirst.SelectedIndexChanged += new System.EventHandler(this.Bar_order_SelectedIndexChanged);
            // 
            // Bar_lblActivePanel
            // 
            this.Bar_lblActivePanel.AutoSize = true;
            this.Bar_lblActivePanel.Location = new System.Drawing.Point(422, 19);
            this.Bar_lblActivePanel.Name = "Bar_lblActivePanel";
            this.Bar_lblActivePanel.Size = new System.Drawing.Size(0, 13);
            this.Bar_lblActivePanel.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(165)))), ((int)(((byte)(229)))));
            this.panel1.Controls.Add(this.Bar_lblActivePanel1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(787, 47);
            this.panel1.TabIndex = 7;
            // 
            // Bar_lblActivePanel1
            // 
            this.Bar_lblActivePanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(204)))));
            this.Bar_lblActivePanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.Bar_lblActivePanel1.ForeColor = System.Drawing.Color.White;
            this.Bar_lblActivePanel1.Location = new System.Drawing.Point(93, -1);
            this.Bar_lblActivePanel1.Name = "Bar_lblActivePanel1";
            this.Bar_lblActivePanel1.Size = new System.Drawing.Size(694, 51);
            this.Bar_lblActivePanel1.TabIndex = 10;
            this.Bar_lblActivePanel1.Text = "Overzicht";
            this.Bar_lblActivePanel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(204)))));
            this.pictureBox1.Image = global::Ui.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(204)))));
            this.panel2.Controls.Add(this.Bar_btnUitloggen);
            this.panel2.Controls.Add(this.Bar_btnOverzicht);
            this.panel2.Controls.Add(this.Bar_btnVoorraad);
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(1, 46);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(95, 392);
            this.panel2.TabIndex = 8;
            // 
            // Bar_btnUitloggen
            // 
            this.Bar_btnUitloggen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(204)))));
            this.Bar_btnUitloggen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bar_btnUitloggen.ForeColor = System.Drawing.Color.White;
            this.Bar_btnUitloggen.Location = new System.Drawing.Point(0, 363);
            this.Bar_btnUitloggen.Name = "Bar_btnUitloggen";
            this.Bar_btnUitloggen.Size = new System.Drawing.Size(95, 29);
            this.Bar_btnUitloggen.TabIndex = 4;
            this.Bar_btnUitloggen.Text = "Uitloggen";
            this.Bar_btnUitloggen.UseVisualStyleBackColor = false;
            this.Bar_btnUitloggen.Click += new System.EventHandler(this.Bar_btnUitloggen_Click);
            // 
            // BarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 437);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Bar_pnlOverzicht);
            this.Controls.Add(this.Bar_lblActivePanel);
            this.Controls.Add(this.Bar_pnlVoorraad);
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
            this.Bar_pnlFourthOrder.PerformLayout();
            this.Bar_pnlThirdOrder.ResumeLayout(false);
            this.Bar_pnlThirdOrder.PerformLayout();
            this.Bar_pnlSecondOrder.ResumeLayout(false);
            this.Bar_pnlSecondOrder.PerformLayout();
            this.Bar_pnlFirstOrder.ResumeLayout(false);
            this.Bar_pnlFirstOrder.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
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
        private System.Windows.Forms.ListView Bar_lvFirst;
        private System.Windows.Forms.Label Bar_lblOpmerkingen;
        private System.Windows.Forms.Label Bar_lblGeenBestellingen;
        private System.Windows.Forms.Button Bar_btnFirstKlaar;
        private System.Windows.Forms.Label Bar_lblTafelFirst;
        private System.Windows.Forms.Label Bar_lblBesteldOpFirst;
        private System.Windows.Forms.Label Bar_lblBesteldOpSecond;
        private System.Windows.Forms.Label Bar_lblTafelSecond;
        private System.Windows.Forms.Label Bar_lblBesteldOpFourth;
        private System.Windows.Forms.Label Bar_lblTafelFourth;
        private System.Windows.Forms.Label Bar_lblBesteldOpThird;
        private System.Windows.Forms.Label Bar_lblTafelThird;
        private System.Windows.Forms.Label Bar_lblOpmerkingenContent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Bar_lblActivePanel1;
        private System.Windows.Forms.Button Bar_btnUitloggen;
        private System.Windows.Forms.Button Bar_btnRefresh;
    }
}