﻿namespace Ui
{
    partial class ChefForm
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
            this.Chef_pnlLeft = new System.Windows.Forms.Panel();
            this.Chef_btnUitloggen = new System.Windows.Forms.Button();
            this.Chef_btnVoorraad = new System.Windows.Forms.Button();
            this.Chef_btnOverzicht = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Chef_pnlTop = new System.Windows.Forms.Panel();
            this.Chef_lblActivePanel = new System.Windows.Forms.Label();
            this.Chef_pnlOverzicht = new System.Windows.Forms.Panel();
            this.Chef_pnlOverflow = new System.Windows.Forms.Panel();
            this.Chef_lblOverflow = new System.Windows.Forms.Label();
            this.Chef_pnlFourthOrder = new System.Windows.Forms.Panel();
            this.Chef_btnFourthKlaar = new System.Windows.Forms.Button();
            this.Chef_pnlThirdOrder = new System.Windows.Forms.Panel();
            this.Chef_btnThirdKlaar = new System.Windows.Forms.Button();
            this.Chef_pnlSecondOrder = new System.Windows.Forms.Panel();
            this.Chef_btnSecondKlaar = new System.Windows.Forms.Button();
            this.Chef_pnlFirstOrder = new System.Windows.Forms.Panel();
            this.Chef_btnFirstKlaar = new System.Windows.Forms.Button();
            this.Chef_lblGeenBestellingen = new System.Windows.Forms.Label();
            this.Chef_lvFirst = new System.Windows.Forms.ListView();
            this.Chef_lvSecond = new System.Windows.Forms.ListView();
            this.Chef_lvThird = new System.Windows.Forms.ListView();
            this.Chef_lvFourth = new System.Windows.Forms.ListView();
            this.Chef_pnlVoorraad = new System.Windows.Forms.Panel();
            this.Chef_lvVoorraad = new System.Windows.Forms.ListView();
            this.Chef_chGerecht = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Chef_chAantal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Chef_chPrijs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Chef_pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Chef_pnlTop.SuspendLayout();
            this.Chef_pnlOverzicht.SuspendLayout();
            this.Chef_pnlOverflow.SuspendLayout();
            this.Chef_pnlFourthOrder.SuspendLayout();
            this.Chef_pnlThirdOrder.SuspendLayout();
            this.Chef_pnlSecondOrder.SuspendLayout();
            this.Chef_pnlFirstOrder.SuspendLayout();
            this.Chef_pnlVoorraad.SuspendLayout();
            this.SuspendLayout();
            // 
            // Chef_pnlLeft
            // 
            this.Chef_pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(165)))), ((int)(((byte)(229)))));
            this.Chef_pnlLeft.Controls.Add(this.Chef_btnUitloggen);
            this.Chef_pnlLeft.Controls.Add(this.Chef_btnVoorraad);
            this.Chef_pnlLeft.Controls.Add(this.Chef_btnOverzicht);
            this.Chef_pnlLeft.Controls.Add(this.pictureBox1);
            this.Chef_pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.Chef_pnlLeft.Margin = new System.Windows.Forms.Padding(0);
            this.Chef_pnlLeft.Name = "Chef_pnlLeft";
            this.Chef_pnlLeft.Size = new System.Drawing.Size(286, 1040);
            this.Chef_pnlLeft.TabIndex = 0;
            // 
            // Chef_btnUitloggen
            // 
            this.Chef_btnUitloggen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(153)))));
            this.Chef_btnUitloggen.FlatAppearance.BorderSize = 0;
            this.Chef_btnUitloggen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Chef_btnUitloggen.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chef_btnUitloggen.ForeColor = System.Drawing.Color.White;
            this.Chef_btnUitloggen.Location = new System.Drawing.Point(1, 947);
            this.Chef_btnUitloggen.Name = "Chef_btnUitloggen";
            this.Chef_btnUitloggen.Size = new System.Drawing.Size(285, 92);
            this.Chef_btnUitloggen.TabIndex = 1;
            this.Chef_btnUitloggen.Text = "Uitloggen";
            this.Chef_btnUitloggen.UseVisualStyleBackColor = true;
            // 
            // Chef_btnVoorraad
            // 
            this.Chef_btnVoorraad.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(153)))));
            this.Chef_btnVoorraad.FlatAppearance.BorderSize = 2;
            this.Chef_btnVoorraad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Chef_btnVoorraad.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chef_btnVoorraad.ForeColor = System.Drawing.Color.White;
            this.Chef_btnVoorraad.Location = new System.Drawing.Point(0, 216);
            this.Chef_btnVoorraad.Name = "Chef_btnVoorraad";
            this.Chef_btnVoorraad.Size = new System.Drawing.Size(285, 92);
            this.Chef_btnVoorraad.TabIndex = 1;
            this.Chef_btnVoorraad.Text = "Voorraad";
            this.Chef_btnVoorraad.UseVisualStyleBackColor = true;
            this.Chef_btnVoorraad.Click += new System.EventHandler(this.Chef_btnVoorraad_Click);
            // 
            // Chef_btnOverzicht
            // 
            this.Chef_btnOverzicht.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.Chef_btnOverzicht.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(153)))));
            this.Chef_btnOverzicht.FlatAppearance.BorderSize = 2;
            this.Chef_btnOverzicht.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Chef_btnOverzicht.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chef_btnOverzicht.ForeColor = System.Drawing.Color.White;
            this.Chef_btnOverzicht.Location = new System.Drawing.Point(0, 126);
            this.Chef_btnOverzicht.Name = "Chef_btnOverzicht";
            this.Chef_btnOverzicht.Size = new System.Drawing.Size(285, 92);
            this.Chef_btnOverzicht.TabIndex = 1;
            this.Chef_btnOverzicht.Text = "Overzicht";
            this.Chef_btnOverzicht.UseVisualStyleBackColor = false;
            this.Chef_btnOverzicht.Click += new System.EventHandler(this.Chef_btnOverzicht_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ui.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(47, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Chef_pnlTop
            // 
            this.Chef_pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(165)))), ((int)(((byte)(229)))));
            this.Chef_pnlTop.Controls.Add(this.Chef_lblActivePanel);
            this.Chef_pnlTop.Location = new System.Drawing.Point(286, 0);
            this.Chef_pnlTop.Name = "Chef_pnlTop";
            this.Chef_pnlTop.Size = new System.Drawing.Size(1618, 125);
            this.Chef_pnlTop.TabIndex = 1;
            // 
            // Chef_lblActivePanel
            // 
            this.Chef_lblActivePanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 80.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chef_lblActivePanel.ForeColor = System.Drawing.Color.White;
            this.Chef_lblActivePanel.Location = new System.Drawing.Point(0, 0);
            this.Chef_lblActivePanel.Name = "Chef_lblActivePanel";
            this.Chef_lblActivePanel.Size = new System.Drawing.Size(1618, 125);
            this.Chef_lblActivePanel.TabIndex = 0;
            this.Chef_lblActivePanel.Text = "Overzicht";
            this.Chef_lblActivePanel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Chef_pnlOverzicht
            // 
            this.Chef_pnlOverzicht.BackColor = System.Drawing.Color.White;
            this.Chef_pnlOverzicht.Controls.Add(this.Chef_pnlOverflow);
            this.Chef_pnlOverzicht.Controls.Add(this.Chef_pnlFourthOrder);
            this.Chef_pnlOverzicht.Controls.Add(this.Chef_pnlThirdOrder);
            this.Chef_pnlOverzicht.Controls.Add(this.Chef_pnlSecondOrder);
            this.Chef_pnlOverzicht.Controls.Add(this.Chef_pnlFirstOrder);
            this.Chef_pnlOverzicht.Controls.Add(this.Chef_lblGeenBestellingen);
            this.Chef_pnlOverzicht.Location = new System.Drawing.Point(286, 125);
            this.Chef_pnlOverzicht.Margin = new System.Windows.Forms.Padding(0);
            this.Chef_pnlOverzicht.Name = "Chef_pnlOverzicht";
            this.Chef_pnlOverzicht.Size = new System.Drawing.Size(1618, 915);
            this.Chef_pnlOverzicht.TabIndex = 2;
            // 
            // Chef_pnlOverflow
            // 
            this.Chef_pnlOverflow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.Chef_pnlOverflow.Controls.Add(this.Chef_lblOverflow);
            this.Chef_pnlOverflow.Location = new System.Drawing.Point(1439, 626);
            this.Chef_pnlOverflow.Name = "Chef_pnlOverflow";
            this.Chef_pnlOverflow.Size = new System.Drawing.Size(110, 100);
            this.Chef_pnlOverflow.TabIndex = 2;
            this.Chef_pnlOverflow.Visible = false;
            // 
            // Chef_lblOverflow
            // 
            this.Chef_lblOverflow.BackColor = System.Drawing.Color.Transparent;
            this.Chef_lblOverflow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Chef_lblOverflow.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chef_lblOverflow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(153)))));
            this.Chef_lblOverflow.Location = new System.Drawing.Point(0, 0);
            this.Chef_lblOverflow.Name = "Chef_lblOverflow";
            this.Chef_lblOverflow.Size = new System.Drawing.Size(110, 100);
            this.Chef_lblOverflow.TabIndex = 0;
            this.Chef_lblOverflow.Text = "+ 1";
            this.Chef_lblOverflow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Chef_pnlFourthOrder
            // 
            this.Chef_pnlFourthOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.Chef_pnlFourthOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Chef_pnlFourthOrder.Controls.Add(this.Chef_lvFourth);
            this.Chef_pnlFourthOrder.Controls.Add(this.Chef_btnFourthKlaar);
            this.Chef_pnlFourthOrder.Location = new System.Drawing.Point(961, 517);
            this.Chef_pnlFourthOrder.Name = "Chef_pnlFourthOrder";
            this.Chef_pnlFourthOrder.Size = new System.Drawing.Size(416, 327);
            this.Chef_pnlFourthOrder.TabIndex = 1;
            this.Chef_pnlFourthOrder.Visible = false;
            // 
            // Chef_btnFourthKlaar
            // 
            this.Chef_btnFourthKlaar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.Chef_btnFourthKlaar.Enabled = false;
            this.Chef_btnFourthKlaar.FlatAppearance.BorderSize = 0;
            this.Chef_btnFourthKlaar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Chef_btnFourthKlaar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chef_btnFourthKlaar.ForeColor = System.Drawing.Color.White;
            this.Chef_btnFourthKlaar.Location = new System.Drawing.Point(12, 281);
            this.Chef_btnFourthKlaar.Margin = new System.Windows.Forms.Padding(0);
            this.Chef_btnFourthKlaar.Name = "Chef_btnFourthKlaar";
            this.Chef_btnFourthKlaar.Size = new System.Drawing.Size(84, 34);
            this.Chef_btnFourthKlaar.TabIndex = 0;
            this.Chef_btnFourthKlaar.Text = "Klaar";
            this.Chef_btnFourthKlaar.UseVisualStyleBackColor = false;
            // 
            // Chef_pnlThirdOrder
            // 
            this.Chef_pnlThirdOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.Chef_pnlThirdOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Chef_pnlThirdOrder.Controls.Add(this.Chef_lvThird);
            this.Chef_pnlThirdOrder.Controls.Add(this.Chef_btnThirdKlaar);
            this.Chef_pnlThirdOrder.Location = new System.Drawing.Point(507, 517);
            this.Chef_pnlThirdOrder.Name = "Chef_pnlThirdOrder";
            this.Chef_pnlThirdOrder.Size = new System.Drawing.Size(416, 327);
            this.Chef_pnlThirdOrder.TabIndex = 1;
            this.Chef_pnlThirdOrder.Visible = false;
            // 
            // Chef_btnThirdKlaar
            // 
            this.Chef_btnThirdKlaar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.Chef_btnThirdKlaar.Enabled = false;
            this.Chef_btnThirdKlaar.FlatAppearance.BorderSize = 0;
            this.Chef_btnThirdKlaar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Chef_btnThirdKlaar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chef_btnThirdKlaar.ForeColor = System.Drawing.Color.White;
            this.Chef_btnThirdKlaar.Location = new System.Drawing.Point(12, 281);
            this.Chef_btnThirdKlaar.Margin = new System.Windows.Forms.Padding(0);
            this.Chef_btnThirdKlaar.Name = "Chef_btnThirdKlaar";
            this.Chef_btnThirdKlaar.Size = new System.Drawing.Size(84, 34);
            this.Chef_btnThirdKlaar.TabIndex = 0;
            this.Chef_btnThirdKlaar.Text = "Klaar";
            this.Chef_btnThirdKlaar.UseVisualStyleBackColor = false;
            // 
            // Chef_pnlSecondOrder
            // 
            this.Chef_pnlSecondOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.Chef_pnlSecondOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Chef_pnlSecondOrder.Controls.Add(this.Chef_lvSecond);
            this.Chef_pnlSecondOrder.Controls.Add(this.Chef_btnSecondKlaar);
            this.Chef_pnlSecondOrder.Location = new System.Drawing.Point(54, 517);
            this.Chef_pnlSecondOrder.Name = "Chef_pnlSecondOrder";
            this.Chef_pnlSecondOrder.Size = new System.Drawing.Size(416, 327);
            this.Chef_pnlSecondOrder.TabIndex = 1;
            this.Chef_pnlSecondOrder.Visible = false;
            // 
            // Chef_btnSecondKlaar
            // 
            this.Chef_btnSecondKlaar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.Chef_btnSecondKlaar.Enabled = false;
            this.Chef_btnSecondKlaar.FlatAppearance.BorderSize = 0;
            this.Chef_btnSecondKlaar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Chef_btnSecondKlaar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chef_btnSecondKlaar.ForeColor = System.Drawing.Color.White;
            this.Chef_btnSecondKlaar.Location = new System.Drawing.Point(12, 281);
            this.Chef_btnSecondKlaar.Margin = new System.Windows.Forms.Padding(0);
            this.Chef_btnSecondKlaar.Name = "Chef_btnSecondKlaar";
            this.Chef_btnSecondKlaar.Size = new System.Drawing.Size(84, 34);
            this.Chef_btnSecondKlaar.TabIndex = 0;
            this.Chef_btnSecondKlaar.Text = "Klaar";
            this.Chef_btnSecondKlaar.UseVisualStyleBackColor = false;
            // 
            // Chef_pnlFirstOrder
            // 
            this.Chef_pnlFirstOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.Chef_pnlFirstOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Chef_pnlFirstOrder.Controls.Add(this.Chef_lvFirst);
            this.Chef_pnlFirstOrder.Controls.Add(this.Chef_btnFirstKlaar);
            this.Chef_pnlFirstOrder.Location = new System.Drawing.Point(54, 54);
            this.Chef_pnlFirstOrder.Name = "Chef_pnlFirstOrder";
            this.Chef_pnlFirstOrder.Size = new System.Drawing.Size(500, 393);
            this.Chef_pnlFirstOrder.TabIndex = 1;
            this.Chef_pnlFirstOrder.Visible = false;
            // 
            // Chef_btnFirstKlaar
            // 
            this.Chef_btnFirstKlaar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.Chef_btnFirstKlaar.FlatAppearance.BorderSize = 0;
            this.Chef_btnFirstKlaar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Chef_btnFirstKlaar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chef_btnFirstKlaar.ForeColor = System.Drawing.Color.White;
            this.Chef_btnFirstKlaar.Location = new System.Drawing.Point(15, 338);
            this.Chef_btnFirstKlaar.Margin = new System.Windows.Forms.Padding(0);
            this.Chef_btnFirstKlaar.Name = "Chef_btnFirstKlaar";
            this.Chef_btnFirstKlaar.Size = new System.Drawing.Size(100, 40);
            this.Chef_btnFirstKlaar.TabIndex = 0;
            this.Chef_btnFirstKlaar.Text = "Klaar";
            this.Chef_btnFirstKlaar.UseVisualStyleBackColor = false;
            this.Chef_btnFirstKlaar.Click += new System.EventHandler(this.Chef_btnFirstKlaar_Click);
            // 
            // Chef_lblGeenBestellingen
            // 
            this.Chef_lblGeenBestellingen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Chef_lblGeenBestellingen.AutoSize = true;
            this.Chef_lblGeenBestellingen.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chef_lblGeenBestellingen.Location = new System.Drawing.Point(462, 358);
            this.Chef_lblGeenBestellingen.Name = "Chef_lblGeenBestellingen";
            this.Chef_lblGeenBestellingen.Size = new System.Drawing.Size(675, 91);
            this.Chef_lblGeenBestellingen.TabIndex = 0;
            this.Chef_lblGeenBestellingen.Text = "Geen bestellingen";
            this.Chef_lblGeenBestellingen.Visible = false;
            // 
            // Chef_lvFirst
            // 
            this.Chef_lvFirst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.Chef_lvFirst.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Chef_lvFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chef_lvFirst.HideSelection = false;
            this.Chef_lvFirst.Location = new System.Drawing.Point(0, 0);
            this.Chef_lvFirst.Margin = new System.Windows.Forms.Padding(0);
            this.Chef_lvFirst.Name = "Chef_lvFirst";
            this.Chef_lvFirst.Size = new System.Drawing.Size(498, 320);
            this.Chef_lvFirst.TabIndex = 1;
            this.Chef_lvFirst.UseCompatibleStateImageBehavior = false;
            this.Chef_lvFirst.View = System.Windows.Forms.View.List;
            // 
            // Chef_lvSecond
            // 
            this.Chef_lvSecond.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.Chef_lvSecond.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Chef_lvSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chef_lvSecond.HideSelection = false;
            this.Chef_lvSecond.Location = new System.Drawing.Point(-1, -1);
            this.Chef_lvSecond.Margin = new System.Windows.Forms.Padding(0);
            this.Chef_lvSecond.Name = "Chef_lvSecond";
            this.Chef_lvSecond.Size = new System.Drawing.Size(416, 269);
            this.Chef_lvSecond.TabIndex = 1;
            this.Chef_lvSecond.UseCompatibleStateImageBehavior = false;
            this.Chef_lvSecond.View = System.Windows.Forms.View.List;
            // 
            // Chef_lvThird
            // 
            this.Chef_lvThird.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.Chef_lvThird.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Chef_lvThird.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chef_lvThird.HideSelection = false;
            this.Chef_lvThird.Location = new System.Drawing.Point(-2, -1);
            this.Chef_lvThird.Margin = new System.Windows.Forms.Padding(0);
            this.Chef_lvThird.Name = "Chef_lvThird";
            this.Chef_lvThird.Size = new System.Drawing.Size(416, 269);
            this.Chef_lvThird.TabIndex = 1;
            this.Chef_lvThird.UseCompatibleStateImageBehavior = false;
            this.Chef_lvThird.View = System.Windows.Forms.View.List;
            // 
            // Chef_lvFourth
            // 
            this.Chef_lvFourth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.Chef_lvFourth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Chef_lvFourth.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chef_lvFourth.HideSelection = false;
            this.Chef_lvFourth.Location = new System.Drawing.Point(-1, -1);
            this.Chef_lvFourth.Margin = new System.Windows.Forms.Padding(0);
            this.Chef_lvFourth.Name = "Chef_lvFourth";
            this.Chef_lvFourth.Size = new System.Drawing.Size(416, 269);
            this.Chef_lvFourth.TabIndex = 1;
            this.Chef_lvFourth.UseCompatibleStateImageBehavior = false;
            this.Chef_lvFourth.View = System.Windows.Forms.View.List;
            // 
            // Chef_pnlVoorraad
            // 
            this.Chef_pnlVoorraad.BackColor = System.Drawing.Color.White;
            this.Chef_pnlVoorraad.Controls.Add(this.Chef_lvVoorraad);
            this.Chef_pnlVoorraad.Location = new System.Drawing.Point(286, 125);
            this.Chef_pnlVoorraad.Margin = new System.Windows.Forms.Padding(0);
            this.Chef_pnlVoorraad.Name = "Chef_pnlVoorraad";
            this.Chef_pnlVoorraad.Size = new System.Drawing.Size(1618, 915);
            this.Chef_pnlVoorraad.TabIndex = 2;
            // 
            // Chef_lvVoorraad
            // 
            this.Chef_lvVoorraad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.Chef_lvVoorraad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Chef_lvVoorraad.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Chef_chGerecht,
            this.Chef_chAantal,
            this.Chef_chPrijs});
            this.Chef_lvVoorraad.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chef_lvVoorraad.ForeColor = System.Drawing.Color.Black;
            this.Chef_lvVoorraad.HideSelection = false;
            this.Chef_lvVoorraad.Location = new System.Drawing.Point(30, 30);
            this.Chef_lvVoorraad.Name = "Chef_lvVoorraad";
            this.Chef_lvVoorraad.Size = new System.Drawing.Size(1560, 860);
            this.Chef_lvVoorraad.TabIndex = 0;
            this.Chef_lvVoorraad.UseCompatibleStateImageBehavior = false;
            this.Chef_lvVoorraad.View = System.Windows.Forms.View.Details;
            this.Chef_lvVoorraad.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.Chef_lvVoorraad_ColumnClicck);
            // 
            // Chef_chGerecht
            // 
            this.Chef_chGerecht.Text = "Gerecht";
            this.Chef_chGerecht.Width = 1218;
            // 
            // Chef_chAantal
            // 
            this.Chef_chAantal.Text = "Aantal";
            this.Chef_chAantal.Width = 150;
            // 
            // Chef_chPrijs
            // 
            this.Chef_chPrijs.Text = "Prijs";
            this.Chef_chPrijs.Width = 190;
            // 
            // ChefForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.Chef_pnlVoorraad);
            this.Controls.Add(this.Chef_pnlOverzicht);
            this.Controls.Add(this.Chef_pnlTop);
            this.Controls.Add(this.Chef_pnlLeft);
            this.Name = "ChefForm";
            this.Text = "Overzicht";
            this.Chef_pnlLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Chef_pnlTop.ResumeLayout(false);
            this.Chef_pnlOverzicht.ResumeLayout(false);
            this.Chef_pnlOverzicht.PerformLayout();
            this.Chef_pnlOverflow.ResumeLayout(false);
            this.Chef_pnlFourthOrder.ResumeLayout(false);
            this.Chef_pnlThirdOrder.ResumeLayout(false);
            this.Chef_pnlSecondOrder.ResumeLayout(false);
            this.Chef_pnlFirstOrder.ResumeLayout(false);
            this.Chef_pnlVoorraad.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Chef_pnlLeft;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Chef_btnOverzicht;
        private System.Windows.Forms.Button Chef_btnVoorraad;
        private System.Windows.Forms.Button Chef_btnUitloggen;
        private System.Windows.Forms.Panel Chef_pnlTop;
        private System.Windows.Forms.Label Chef_lblActivePanel;
        private System.Windows.Forms.Panel Chef_pnlOverzicht;
        private System.Windows.Forms.Label Chef_lblGeenBestellingen;
        private System.Windows.Forms.Panel Chef_pnlFirstOrder;
        private System.Windows.Forms.Panel Chef_pnlSecondOrder;
        private System.Windows.Forms.Panel Chef_pnlFourthOrder;
        private System.Windows.Forms.Panel Chef_pnlThirdOrder;
        private System.Windows.Forms.Panel Chef_pnlOverflow;
        private System.Windows.Forms.Label Chef_lblOverflow;
        private System.Windows.Forms.Button Chef_btnFirstKlaar;
        private System.Windows.Forms.Button Chef_btnSecondKlaar;
        private System.Windows.Forms.Button Chef_btnFourthKlaar;
        private System.Windows.Forms.Button Chef_btnThirdKlaar;
        private System.Windows.Forms.ListView Chef_lvFirst;
        private System.Windows.Forms.ListView Chef_lvFourth;
        private System.Windows.Forms.ListView Chef_lvThird;
        private System.Windows.Forms.ListView Chef_lvSecond;
        private System.Windows.Forms.Panel Chef_pnlVoorraad;
        private System.Windows.Forms.ListView Chef_lvVoorraad;
        private System.Windows.Forms.ColumnHeader Chef_chGerecht;
        private System.Windows.Forms.ColumnHeader Chef_chAantal;
        private System.Windows.Forms.ColumnHeader Chef_chPrijs;
    }
}