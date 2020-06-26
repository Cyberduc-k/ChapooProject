namespace Ui
{
    partial class ControlPanelForm
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
            this.CP_pnlNavMenu = new System.Windows.Forms.Panel();
            this.CP_btnMedewerkers = new System.Windows.Forms.Button();
            this.CP_btnInkomsten = new System.Windows.Forms.Button();
            this.CP_btnUitloggen = new System.Windows.Forms.Button();
            this.CP_btnMenukaarten = new System.Windows.Forms.Button();
            this.CP_btnVoorraad = new System.Windows.Forms.Button();
            this.CP_imgLogo = new System.Windows.Forms.PictureBox();
            this.CP_pnlHeader = new System.Windows.Forms.Panel();
            this.CP_lblActivePanel = new System.Windows.Forms.Label();
            this.CP_pnlVoorraad = new System.Windows.Forms.Panel();
            this.CP_Voorraad_btnEmptyItem = new System.Windows.Forms.Button();
            this.CP_Voorraad_btnEditItem = new System.Windows.Forms.Button();
            this.CP_Voorraad_listView = new System.Windows.Forms.ListView();
            this.CP_Voorraad_btnLunchgerechten = new System.Windows.Forms.Button();
            this.CP_Voorraad_btnDinergerechten = new System.Windows.Forms.Button();
            this.CP_Voorraad_btnDranken = new System.Windows.Forms.Button();
            this.CP_Menukaarten_listView = new System.Windows.Forms.ListView();
            this.CP_pnlMedewerkers = new System.Windows.Forms.Panel();
            this.CP_Medewerkers_btnVerwijderen = new System.Windows.Forms.Button();
            this.CP_Medewerkers_btnEdit = new System.Windows.Forms.Button();
            this.CP_Medewerkers_btnNieuweMedewerker = new System.Windows.Forms.Button();
            this.CP_Medewerkers_listView = new System.Windows.Forms.ListView();
            this.CP_pnlMenukaarten = new System.Windows.Forms.Panel();
            this.CP_Menukaarten_btnLunchgerechten = new System.Windows.Forms.Button();
            this.CP_Menukaarten_btnDinergerechten = new System.Windows.Forms.Button();
            this.CP_Menukaarten_btnDranken = new System.Windows.Forms.Button();
            this.CP_Menukaarten_btnDeleteItem = new System.Windows.Forms.Button();
            this.CP_Menukaarten_btnEditItem = new System.Windows.Forms.Button();
            this.CP_Menukaarten_btnNewItem = new System.Windows.Forms.Button();
            this.CP_pnlInkomsten = new System.Windows.Forms.Panel();
            this.CP_Inkomsten_dtpTot = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.CP_Inkomsten_dtpVan = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.CP_Inkomsten_btnApply = new System.Windows.Forms.Button();
            this.CP_Inkomsten_listView = new System.Windows.Forms.ListView();
            this.CP_pnlNavMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CP_imgLogo)).BeginInit();
            this.CP_pnlHeader.SuspendLayout();
            this.CP_pnlVoorraad.SuspendLayout();
            this.CP_pnlMedewerkers.SuspendLayout();
            this.CP_pnlMenukaarten.SuspendLayout();
            this.CP_pnlInkomsten.SuspendLayout();
            this.SuspendLayout();
            // 
            // CP_pnlNavMenu
            // 
            this.CP_pnlNavMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(165)))), ((int)(((byte)(229)))));
            this.CP_pnlNavMenu.Controls.Add(this.CP_btnMedewerkers);
            this.CP_pnlNavMenu.Controls.Add(this.CP_btnInkomsten);
            this.CP_pnlNavMenu.Controls.Add(this.CP_btnUitloggen);
            this.CP_pnlNavMenu.Controls.Add(this.CP_btnMenukaarten);
            this.CP_pnlNavMenu.Controls.Add(this.CP_btnVoorraad);
            this.CP_pnlNavMenu.Controls.Add(this.CP_imgLogo);
            this.CP_pnlNavMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.CP_pnlNavMenu.Location = new System.Drawing.Point(0, 0);
            this.CP_pnlNavMenu.Name = "CP_pnlNavMenu";
            this.CP_pnlNavMenu.Size = new System.Drawing.Size(151, 536);
            this.CP_pnlNavMenu.TabIndex = 1;
            // 
            // CP_btnMedewerkers
            // 
            this.CP_btnMedewerkers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(165)))), ((int)(((byte)(229)))));
            this.CP_btnMedewerkers.Dock = System.Windows.Forms.DockStyle.Top;
            this.CP_btnMedewerkers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(153)))));
            this.CP_btnMedewerkers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.CP_btnMedewerkers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CP_btnMedewerkers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CP_btnMedewerkers.ForeColor = System.Drawing.Color.White;
            this.CP_btnMedewerkers.Location = new System.Drawing.Point(0, 216);
            this.CP_btnMedewerkers.Name = "CP_btnMedewerkers";
            this.CP_btnMedewerkers.Size = new System.Drawing.Size(151, 50);
            this.CP_btnMedewerkers.TabIndex = 7;
            this.CP_btnMedewerkers.Text = "Medewerkers";
            this.CP_btnMedewerkers.UseVisualStyleBackColor = false;
            this.CP_btnMedewerkers.Click += new System.EventHandler(this.CP_btnMedewerkers_Click);
            // 
            // CP_btnInkomsten
            // 
            this.CP_btnInkomsten.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(165)))), ((int)(((byte)(229)))));
            this.CP_btnInkomsten.Dock = System.Windows.Forms.DockStyle.Top;
            this.CP_btnInkomsten.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(153)))));
            this.CP_btnInkomsten.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.CP_btnInkomsten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CP_btnInkomsten.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CP_btnInkomsten.ForeColor = System.Drawing.Color.White;
            this.CP_btnInkomsten.Location = new System.Drawing.Point(0, 166);
            this.CP_btnInkomsten.Name = "CP_btnInkomsten";
            this.CP_btnInkomsten.Size = new System.Drawing.Size(151, 50);
            this.CP_btnInkomsten.TabIndex = 6;
            this.CP_btnInkomsten.Text = "Inkomsten";
            this.CP_btnInkomsten.UseVisualStyleBackColor = false;
            this.CP_btnInkomsten.Click += new System.EventHandler(this.CP_btnInkomsten_Click);
            // 
            // CP_btnUitloggen
            // 
            this.CP_btnUitloggen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(165)))), ((int)(((byte)(229)))));
            this.CP_btnUitloggen.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CP_btnUitloggen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(153)))));
            this.CP_btnUitloggen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.CP_btnUitloggen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CP_btnUitloggen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CP_btnUitloggen.ForeColor = System.Drawing.Color.White;
            this.CP_btnUitloggen.Location = new System.Drawing.Point(0, 474);
            this.CP_btnUitloggen.Name = "CP_btnUitloggen";
            this.CP_btnUitloggen.Size = new System.Drawing.Size(151, 62);
            this.CP_btnUitloggen.TabIndex = 4;
            this.CP_btnUitloggen.Text = "Uitloggen";
            this.CP_btnUitloggen.UseVisualStyleBackColor = false;
            this.CP_btnUitloggen.Click += new System.EventHandler(this.CP_btnUitloggen_Click);
            // 
            // CP_btnMenukaarten
            // 
            this.CP_btnMenukaarten.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(165)))), ((int)(((byte)(229)))));
            this.CP_btnMenukaarten.Dock = System.Windows.Forms.DockStyle.Top;
            this.CP_btnMenukaarten.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(153)))));
            this.CP_btnMenukaarten.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.CP_btnMenukaarten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CP_btnMenukaarten.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CP_btnMenukaarten.ForeColor = System.Drawing.Color.White;
            this.CP_btnMenukaarten.Location = new System.Drawing.Point(0, 116);
            this.CP_btnMenukaarten.Name = "CP_btnMenukaarten";
            this.CP_btnMenukaarten.Size = new System.Drawing.Size(151, 50);
            this.CP_btnMenukaarten.TabIndex = 3;
            this.CP_btnMenukaarten.Text = "Menukaarten";
            this.CP_btnMenukaarten.UseVisualStyleBackColor = false;
            this.CP_btnMenukaarten.Click += new System.EventHandler(this.CP_btnMenukaarten_Click);
            // 
            // CP_btnVoorraad
            // 
            this.CP_btnVoorraad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(165)))), ((int)(((byte)(229)))));
            this.CP_btnVoorraad.Dock = System.Windows.Forms.DockStyle.Top;
            this.CP_btnVoorraad.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(153)))));
            this.CP_btnVoorraad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.CP_btnVoorraad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CP_btnVoorraad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CP_btnVoorraad.ForeColor = System.Drawing.Color.White;
            this.CP_btnVoorraad.Location = new System.Drawing.Point(0, 66);
            this.CP_btnVoorraad.Name = "CP_btnVoorraad";
            this.CP_btnVoorraad.Size = new System.Drawing.Size(151, 50);
            this.CP_btnVoorraad.TabIndex = 2;
            this.CP_btnVoorraad.Text = "Voorraad";
            this.CP_btnVoorraad.UseVisualStyleBackColor = false;
            this.CP_btnVoorraad.Click += new System.EventHandler(this.CP_btnVoorraad_Click);
            // 
            // CP_imgLogo
            // 
            this.CP_imgLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CP_imgLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.CP_imgLogo.Image = global::Ui.Properties.Resources.Logo2;
            this.CP_imgLogo.Location = new System.Drawing.Point(0, 0);
            this.CP_imgLogo.Name = "CP_imgLogo";
            this.CP_imgLogo.Size = new System.Drawing.Size(151, 66);
            this.CP_imgLogo.TabIndex = 1;
            this.CP_imgLogo.TabStop = false;
            // 
            // CP_pnlHeader
            // 
            this.CP_pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(165)))), ((int)(((byte)(229)))));
            this.CP_pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CP_pnlHeader.Controls.Add(this.CP_lblActivePanel);
            this.CP_pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.CP_pnlHeader.Location = new System.Drawing.Point(151, 0);
            this.CP_pnlHeader.Name = "CP_pnlHeader";
            this.CP_pnlHeader.Size = new System.Drawing.Size(858, 66);
            this.CP_pnlHeader.TabIndex = 2;
            // 
            // CP_lblActivePanel
            // 
            this.CP_lblActivePanel.AutoSize = true;
            this.CP_lblActivePanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CP_lblActivePanel.ForeColor = System.Drawing.Color.White;
            this.CP_lblActivePanel.Location = new System.Drawing.Point(366, 7);
            this.CP_lblActivePanel.Name = "CP_lblActivePanel";
            this.CP_lblActivePanel.Size = new System.Drawing.Size(159, 39);
            this.CP_lblActivePanel.TabIndex = 0;
            this.CP_lblActivePanel.Text = "Voorraad";
            // 
            // CP_pnlVoorraad
            // 
            this.CP_pnlVoorraad.BackColor = System.Drawing.Color.White;
            this.CP_pnlVoorraad.Controls.Add(this.CP_Voorraad_btnEmptyItem);
            this.CP_pnlVoorraad.Controls.Add(this.CP_Voorraad_btnEditItem);
            this.CP_pnlVoorraad.Controls.Add(this.CP_Voorraad_listView);
            this.CP_pnlVoorraad.Controls.Add(this.CP_Voorraad_btnLunchgerechten);
            this.CP_pnlVoorraad.Controls.Add(this.CP_Voorraad_btnDinergerechten);
            this.CP_pnlVoorraad.Controls.Add(this.CP_Voorraad_btnDranken);
            this.CP_pnlVoorraad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CP_pnlVoorraad.Location = new System.Drawing.Point(151, 66);
            this.CP_pnlVoorraad.Name = "CP_pnlVoorraad";
            this.CP_pnlVoorraad.Size = new System.Drawing.Size(857, 471);
            this.CP_pnlVoorraad.TabIndex = 3;
            // 
            // CP_Voorraad_btnEmptyItem
            // 
            this.CP_Voorraad_btnEmptyItem.BackColor = System.Drawing.Color.Salmon;
            this.CP_Voorraad_btnEmptyItem.Enabled = false;
            this.CP_Voorraad_btnEmptyItem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(153)))));
            this.CP_Voorraad_btnEmptyItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.CP_Voorraad_btnEmptyItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CP_Voorraad_btnEmptyItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CP_Voorraad_btnEmptyItem.ForeColor = System.Drawing.Color.White;
            this.CP_Voorraad_btnEmptyItem.Location = new System.Drawing.Point(435, 409);
            this.CP_Voorraad_btnEmptyItem.Name = "CP_Voorraad_btnEmptyItem";
            this.CP_Voorraad_btnEmptyItem.Size = new System.Drawing.Size(410, 50);
            this.CP_Voorraad_btnEmptyItem.TabIndex = 13;
            this.CP_Voorraad_btnEmptyItem.Text = "Voorraad van gerecht legen";
            this.CP_Voorraad_btnEmptyItem.UseVisualStyleBackColor = false;
            this.CP_Voorraad_btnEmptyItem.Click += new System.EventHandler(this.CP_Voorraad_btnEmptyItem_Click);
            // 
            // CP_Voorraad_btnEditItem
            // 
            this.CP_Voorraad_btnEditItem.BackColor = System.Drawing.Color.PaleTurquoise;
            this.CP_Voorraad_btnEditItem.Enabled = false;
            this.CP_Voorraad_btnEditItem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(153)))));
            this.CP_Voorraad_btnEditItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.CP_Voorraad_btnEditItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CP_Voorraad_btnEditItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CP_Voorraad_btnEditItem.ForeColor = System.Drawing.Color.White;
            this.CP_Voorraad_btnEditItem.Location = new System.Drawing.Point(7, 409);
            this.CP_Voorraad_btnEditItem.Name = "CP_Voorraad_btnEditItem";
            this.CP_Voorraad_btnEditItem.Size = new System.Drawing.Size(410, 50);
            this.CP_Voorraad_btnEditItem.TabIndex = 12;
            this.CP_Voorraad_btnEditItem.Text = "Voorraad van gerecht aanpassen";
            this.CP_Voorraad_btnEditItem.UseVisualStyleBackColor = false;
            this.CP_Voorraad_btnEditItem.Click += new System.EventHandler(this.CP_Voorraad_btnEditItem_Click);
            // 
            // CP_Voorraad_listView
            // 
            this.CP_Voorraad_listView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.CP_Voorraad_listView.FullRowSelect = true;
            this.CP_Voorraad_listView.HideSelection = false;
            this.CP_Voorraad_listView.Location = new System.Drawing.Point(7, 56);
            this.CP_Voorraad_listView.Name = "CP_Voorraad_listView";
            this.CP_Voorraad_listView.Size = new System.Drawing.Size(838, 344);
            this.CP_Voorraad_listView.TabIndex = 11;
            this.CP_Voorraad_listView.UseCompatibleStateImageBehavior = false;
            this.CP_Voorraad_listView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.CP_Voorraad_listView_ColumnClick_1);
            this.CP_Voorraad_listView.SelectedIndexChanged += new System.EventHandler(this.CP_Voorraad_listView_SelectedIndexChanged);
            // 
            // CP_Voorraad_btnLunchgerechten
            // 
            this.CP_Voorraad_btnLunchgerechten.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(165)))), ((int)(((byte)(229)))));
            this.CP_Voorraad_btnLunchgerechten.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(153)))));
            this.CP_Voorraad_btnLunchgerechten.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.CP_Voorraad_btnLunchgerechten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CP_Voorraad_btnLunchgerechten.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CP_Voorraad_btnLunchgerechten.ForeColor = System.Drawing.Color.White;
            this.CP_Voorraad_btnLunchgerechten.Location = new System.Drawing.Point(289, 0);
            this.CP_Voorraad_btnLunchgerechten.Name = "CP_Voorraad_btnLunchgerechten";
            this.CP_Voorraad_btnLunchgerechten.Size = new System.Drawing.Size(275, 50);
            this.CP_Voorraad_btnLunchgerechten.TabIndex = 10;
            this.CP_Voorraad_btnLunchgerechten.Text = "Lunchgerechten";
            this.CP_Voorraad_btnLunchgerechten.UseVisualStyleBackColor = false;
            this.CP_Voorraad_btnLunchgerechten.Click += new System.EventHandler(this.CP_Voorraad_btnLunchgerechten_Click);
            // 
            // CP_Voorraad_btnDinergerechten
            // 
            this.CP_Voorraad_btnDinergerechten.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(165)))), ((int)(((byte)(229)))));
            this.CP_Voorraad_btnDinergerechten.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(153)))));
            this.CP_Voorraad_btnDinergerechten.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.CP_Voorraad_btnDinergerechten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CP_Voorraad_btnDinergerechten.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CP_Voorraad_btnDinergerechten.ForeColor = System.Drawing.Color.White;
            this.CP_Voorraad_btnDinergerechten.Location = new System.Drawing.Point(570, 0);
            this.CP_Voorraad_btnDinergerechten.Name = "CP_Voorraad_btnDinergerechten";
            this.CP_Voorraad_btnDinergerechten.Size = new System.Drawing.Size(275, 50);
            this.CP_Voorraad_btnDinergerechten.TabIndex = 9;
            this.CP_Voorraad_btnDinergerechten.Text = "Dinergerechten";
            this.CP_Voorraad_btnDinergerechten.UseVisualStyleBackColor = false;
            this.CP_Voorraad_btnDinergerechten.Click += new System.EventHandler(this.CP_Voorraad_btnDinergerechten_Click);
            // 
            // CP_Voorraad_btnDranken
            // 
            this.CP_Voorraad_btnDranken.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.CP_Voorraad_btnDranken.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(153)))));
            this.CP_Voorraad_btnDranken.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.CP_Voorraad_btnDranken.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CP_Voorraad_btnDranken.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CP_Voorraad_btnDranken.ForeColor = System.Drawing.Color.White;
            this.CP_Voorraad_btnDranken.Location = new System.Drawing.Point(6, 0);
            this.CP_Voorraad_btnDranken.Name = "CP_Voorraad_btnDranken";
            this.CP_Voorraad_btnDranken.Size = new System.Drawing.Size(275, 50);
            this.CP_Voorraad_btnDranken.TabIndex = 8;
            this.CP_Voorraad_btnDranken.Text = "Dranken";
            this.CP_Voorraad_btnDranken.UseVisualStyleBackColor = false;
            this.CP_Voorraad_btnDranken.Click += new System.EventHandler(this.CP_Voorraad_btnDranken_Click);
            // 
            // CP_Menukaarten_listView
            // 
            this.CP_Menukaarten_listView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.CP_Menukaarten_listView.FullRowSelect = true;
            this.CP_Menukaarten_listView.HideSelection = false;
            this.CP_Menukaarten_listView.Location = new System.Drawing.Point(7, 59);
            this.CP_Menukaarten_listView.Name = "CP_Menukaarten_listView";
            this.CP_Menukaarten_listView.Size = new System.Drawing.Size(838, 344);
            this.CP_Menukaarten_listView.TabIndex = 0;
            this.CP_Menukaarten_listView.UseCompatibleStateImageBehavior = false;
            this.CP_Menukaarten_listView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.CP_Menukaarten_listView_ColumnClick);
            this.CP_Menukaarten_listView.SelectedIndexChanged += new System.EventHandler(this.CP_Menukaarten_listView_SelectedIndexChanged);
            // 
            // CP_pnlMedewerkers
            // 
            this.CP_pnlMedewerkers.BackColor = System.Drawing.Color.White;
            this.CP_pnlMedewerkers.Controls.Add(this.CP_Medewerkers_btnVerwijderen);
            this.CP_pnlMedewerkers.Controls.Add(this.CP_Medewerkers_btnEdit);
            this.CP_pnlMedewerkers.Controls.Add(this.CP_Medewerkers_btnNieuweMedewerker);
            this.CP_pnlMedewerkers.Controls.Add(this.CP_Medewerkers_listView);
            this.CP_pnlMedewerkers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CP_pnlMedewerkers.Location = new System.Drawing.Point(151, 66);
            this.CP_pnlMedewerkers.Name = "CP_pnlMedewerkers";
            this.CP_pnlMedewerkers.Size = new System.Drawing.Size(857, 471);
            this.CP_pnlMedewerkers.TabIndex = 11;
            // 
            // CP_Medewerkers_btnVerwijderen
            // 
            this.CP_Medewerkers_btnVerwijderen.BackColor = System.Drawing.Color.Salmon;
            this.CP_Medewerkers_btnVerwijderen.Enabled = false;
            this.CP_Medewerkers_btnVerwijderen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(153)))));
            this.CP_Medewerkers_btnVerwijderen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.CP_Medewerkers_btnVerwijderen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CP_Medewerkers_btnVerwijderen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CP_Medewerkers_btnVerwijderen.ForeColor = System.Drawing.Color.White;
            this.CP_Medewerkers_btnVerwijderen.Location = new System.Drawing.Point(643, 409);
            this.CP_Medewerkers_btnVerwijderen.Name = "CP_Medewerkers_btnVerwijderen";
            this.CP_Medewerkers_btnVerwijderen.Size = new System.Drawing.Size(202, 50);
            this.CP_Medewerkers_btnVerwijderen.TabIndex = 10;
            this.CP_Medewerkers_btnVerwijderen.Text = "Verwijderen";
            this.CP_Medewerkers_btnVerwijderen.UseVisualStyleBackColor = false;
            this.CP_Medewerkers_btnVerwijderen.Click += new System.EventHandler(this.CP_Medewerkers_btnVerwijderen_Click);
            // 
            // CP_Medewerkers_btnEdit
            // 
            this.CP_Medewerkers_btnEdit.BackColor = System.Drawing.Color.PaleTurquoise;
            this.CP_Medewerkers_btnEdit.Enabled = false;
            this.CP_Medewerkers_btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(153)))));
            this.CP_Medewerkers_btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.CP_Medewerkers_btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CP_Medewerkers_btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CP_Medewerkers_btnEdit.ForeColor = System.Drawing.Color.White;
            this.CP_Medewerkers_btnEdit.Location = new System.Drawing.Point(325, 409);
            this.CP_Medewerkers_btnEdit.Name = "CP_Medewerkers_btnEdit";
            this.CP_Medewerkers_btnEdit.Size = new System.Drawing.Size(312, 50);
            this.CP_Medewerkers_btnEdit.TabIndex = 9;
            this.CP_Medewerkers_btnEdit.Text = "Medewerker aanpassen";
            this.CP_Medewerkers_btnEdit.UseVisualStyleBackColor = false;
            this.CP_Medewerkers_btnEdit.Click += new System.EventHandler(this.CP_Medewerkers_btnEdit_Click);
            // 
            // CP_Medewerkers_btnNieuweMedewerker
            // 
            this.CP_Medewerkers_btnNieuweMedewerker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.CP_Medewerkers_btnNieuweMedewerker.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(153)))));
            this.CP_Medewerkers_btnNieuweMedewerker.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.CP_Medewerkers_btnNieuweMedewerker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CP_Medewerkers_btnNieuweMedewerker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CP_Medewerkers_btnNieuweMedewerker.ForeColor = System.Drawing.Color.White;
            this.CP_Medewerkers_btnNieuweMedewerker.Location = new System.Drawing.Point(7, 409);
            this.CP_Medewerkers_btnNieuweMedewerker.Name = "CP_Medewerkers_btnNieuweMedewerker";
            this.CP_Medewerkers_btnNieuweMedewerker.Size = new System.Drawing.Size(312, 50);
            this.CP_Medewerkers_btnNieuweMedewerker.TabIndex = 8;
            this.CP_Medewerkers_btnNieuweMedewerker.Text = "Nieuwe medewerker toevoegen";
            this.CP_Medewerkers_btnNieuweMedewerker.UseVisualStyleBackColor = false;
            this.CP_Medewerkers_btnNieuweMedewerker.Click += new System.EventHandler(this.CP_Medewerkers_btnNieuweMedewerker_Click);
            // 
            // CP_Medewerkers_listView
            // 
            this.CP_Medewerkers_listView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.CP_Medewerkers_listView.FullRowSelect = true;
            this.CP_Medewerkers_listView.HideSelection = false;
            this.CP_Medewerkers_listView.Location = new System.Drawing.Point(7, 0);
            this.CP_Medewerkers_listView.Name = "CP_Medewerkers_listView";
            this.CP_Medewerkers_listView.Size = new System.Drawing.Size(838, 403);
            this.CP_Medewerkers_listView.TabIndex = 0;
            this.CP_Medewerkers_listView.UseCompatibleStateImageBehavior = false;
            this.CP_Medewerkers_listView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.CP_Medewerkers_listView_ColumnClick);
            this.CP_Medewerkers_listView.SelectedIndexChanged += new System.EventHandler(this.CP_Medewerkers_listView_SelectedIndexChanged);
            // 
            // CP_pnlMenukaarten
            // 
            this.CP_pnlMenukaarten.BackColor = System.Drawing.Color.White;
            this.CP_pnlMenukaarten.Controls.Add(this.CP_Menukaarten_btnLunchgerechten);
            this.CP_pnlMenukaarten.Controls.Add(this.CP_Menukaarten_btnDinergerechten);
            this.CP_pnlMenukaarten.Controls.Add(this.CP_Menukaarten_btnDranken);
            this.CP_pnlMenukaarten.Controls.Add(this.CP_Menukaarten_btnDeleteItem);
            this.CP_pnlMenukaarten.Controls.Add(this.CP_Menukaarten_btnEditItem);
            this.CP_pnlMenukaarten.Controls.Add(this.CP_Menukaarten_btnNewItem);
            this.CP_pnlMenukaarten.Controls.Add(this.CP_Menukaarten_listView);
            this.CP_pnlMenukaarten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CP_pnlMenukaarten.Location = new System.Drawing.Point(151, 66);
            this.CP_pnlMenukaarten.Name = "CP_pnlMenukaarten";
            this.CP_pnlMenukaarten.Size = new System.Drawing.Size(857, 471);
            this.CP_pnlMenukaarten.TabIndex = 12;
            // 
            // CP_Menukaarten_btnLunchgerechten
            // 
            this.CP_Menukaarten_btnLunchgerechten.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(165)))), ((int)(((byte)(229)))));
            this.CP_Menukaarten_btnLunchgerechten.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(153)))));
            this.CP_Menukaarten_btnLunchgerechten.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.CP_Menukaarten_btnLunchgerechten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CP_Menukaarten_btnLunchgerechten.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CP_Menukaarten_btnLunchgerechten.ForeColor = System.Drawing.Color.White;
            this.CP_Menukaarten_btnLunchgerechten.Location = new System.Drawing.Point(289, 3);
            this.CP_Menukaarten_btnLunchgerechten.Name = "CP_Menukaarten_btnLunchgerechten";
            this.CP_Menukaarten_btnLunchgerechten.Size = new System.Drawing.Size(275, 50);
            this.CP_Menukaarten_btnLunchgerechten.TabIndex = 13;
            this.CP_Menukaarten_btnLunchgerechten.Text = "Lunchkaart";
            this.CP_Menukaarten_btnLunchgerechten.UseVisualStyleBackColor = false;
            this.CP_Menukaarten_btnLunchgerechten.Click += new System.EventHandler(this.CP_Menukaarten_btnLunchgerechten_Click);
            // 
            // CP_Menukaarten_btnDinergerechten
            // 
            this.CP_Menukaarten_btnDinergerechten.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(165)))), ((int)(((byte)(229)))));
            this.CP_Menukaarten_btnDinergerechten.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(153)))));
            this.CP_Menukaarten_btnDinergerechten.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.CP_Menukaarten_btnDinergerechten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CP_Menukaarten_btnDinergerechten.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CP_Menukaarten_btnDinergerechten.ForeColor = System.Drawing.Color.White;
            this.CP_Menukaarten_btnDinergerechten.Location = new System.Drawing.Point(570, 3);
            this.CP_Menukaarten_btnDinergerechten.Name = "CP_Menukaarten_btnDinergerechten";
            this.CP_Menukaarten_btnDinergerechten.Size = new System.Drawing.Size(275, 50);
            this.CP_Menukaarten_btnDinergerechten.TabIndex = 12;
            this.CP_Menukaarten_btnDinergerechten.Text = "Dinerkaart";
            this.CP_Menukaarten_btnDinergerechten.UseVisualStyleBackColor = false;
            this.CP_Menukaarten_btnDinergerechten.Click += new System.EventHandler(this.CP_Menukaarten_btnDinergerechten_Click);
            // 
            // CP_Menukaarten_btnDranken
            // 
            this.CP_Menukaarten_btnDranken.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.CP_Menukaarten_btnDranken.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(153)))));
            this.CP_Menukaarten_btnDranken.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.CP_Menukaarten_btnDranken.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CP_Menukaarten_btnDranken.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CP_Menukaarten_btnDranken.ForeColor = System.Drawing.Color.White;
            this.CP_Menukaarten_btnDranken.Location = new System.Drawing.Point(6, 3);
            this.CP_Menukaarten_btnDranken.Name = "CP_Menukaarten_btnDranken";
            this.CP_Menukaarten_btnDranken.Size = new System.Drawing.Size(275, 50);
            this.CP_Menukaarten_btnDranken.TabIndex = 11;
            this.CP_Menukaarten_btnDranken.Text = "Drankenkaart";
            this.CP_Menukaarten_btnDranken.UseVisualStyleBackColor = false;
            this.CP_Menukaarten_btnDranken.Click += new System.EventHandler(this.CP_Menukaarten_btnDranken_Click);
            // 
            // CP_Menukaarten_btnDeleteItem
            // 
            this.CP_Menukaarten_btnDeleteItem.BackColor = System.Drawing.Color.Salmon;
            this.CP_Menukaarten_btnDeleteItem.Enabled = false;
            this.CP_Menukaarten_btnDeleteItem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(153)))));
            this.CP_Menukaarten_btnDeleteItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.CP_Menukaarten_btnDeleteItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CP_Menukaarten_btnDeleteItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CP_Menukaarten_btnDeleteItem.ForeColor = System.Drawing.Color.White;
            this.CP_Menukaarten_btnDeleteItem.Location = new System.Drawing.Point(643, 409);
            this.CP_Menukaarten_btnDeleteItem.Name = "CP_Menukaarten_btnDeleteItem";
            this.CP_Menukaarten_btnDeleteItem.Size = new System.Drawing.Size(202, 50);
            this.CP_Menukaarten_btnDeleteItem.TabIndex = 10;
            this.CP_Menukaarten_btnDeleteItem.Text = "Verwijderen";
            this.CP_Menukaarten_btnDeleteItem.UseVisualStyleBackColor = false;
            this.CP_Menukaarten_btnDeleteItem.Click += new System.EventHandler(this.CP_Menukaarten_btnDeleteItem_Click);
            // 
            // CP_Menukaarten_btnEditItem
            // 
            this.CP_Menukaarten_btnEditItem.BackColor = System.Drawing.Color.PaleTurquoise;
            this.CP_Menukaarten_btnEditItem.Enabled = false;
            this.CP_Menukaarten_btnEditItem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(153)))));
            this.CP_Menukaarten_btnEditItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.CP_Menukaarten_btnEditItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CP_Menukaarten_btnEditItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CP_Menukaarten_btnEditItem.ForeColor = System.Drawing.Color.White;
            this.CP_Menukaarten_btnEditItem.Location = new System.Drawing.Point(325, 409);
            this.CP_Menukaarten_btnEditItem.Name = "CP_Menukaarten_btnEditItem";
            this.CP_Menukaarten_btnEditItem.Size = new System.Drawing.Size(312, 50);
            this.CP_Menukaarten_btnEditItem.TabIndex = 9;
            this.CP_Menukaarten_btnEditItem.Text = "Gerecht aanpassen";
            this.CP_Menukaarten_btnEditItem.UseVisualStyleBackColor = false;
            this.CP_Menukaarten_btnEditItem.Click += new System.EventHandler(this.CP_Menukaarten_btnEditItem_Click);
            // 
            // CP_Menukaarten_btnNewItem
            // 
            this.CP_Menukaarten_btnNewItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.CP_Menukaarten_btnNewItem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(153)))));
            this.CP_Menukaarten_btnNewItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.CP_Menukaarten_btnNewItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CP_Menukaarten_btnNewItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CP_Menukaarten_btnNewItem.ForeColor = System.Drawing.Color.White;
            this.CP_Menukaarten_btnNewItem.Location = new System.Drawing.Point(7, 409);
            this.CP_Menukaarten_btnNewItem.Name = "CP_Menukaarten_btnNewItem";
            this.CP_Menukaarten_btnNewItem.Size = new System.Drawing.Size(312, 50);
            this.CP_Menukaarten_btnNewItem.TabIndex = 8;
            this.CP_Menukaarten_btnNewItem.Text = "Nieuw gerecht toevoegen";
            this.CP_Menukaarten_btnNewItem.UseVisualStyleBackColor = false;
            this.CP_Menukaarten_btnNewItem.Click += new System.EventHandler(this.CP_Menukaarten_btnNewItem_Click);
            // 
            // CP_pnlInkomsten
            // 
            this.CP_pnlInkomsten.BackColor = System.Drawing.Color.White;
            this.CP_pnlInkomsten.Controls.Add(this.CP_Inkomsten_dtpTot);
            this.CP_pnlInkomsten.Controls.Add(this.label2);
            this.CP_pnlInkomsten.Controls.Add(this.CP_Inkomsten_dtpVan);
            this.CP_pnlInkomsten.Controls.Add(this.label1);
            this.CP_pnlInkomsten.Controls.Add(this.CP_Inkomsten_btnApply);
            this.CP_pnlInkomsten.Controls.Add(this.CP_Inkomsten_listView);
            this.CP_pnlInkomsten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CP_pnlInkomsten.Location = new System.Drawing.Point(151, 66);
            this.CP_pnlInkomsten.Name = "CP_pnlInkomsten";
            this.CP_pnlInkomsten.Size = new System.Drawing.Size(857, 471);
            this.CP_pnlInkomsten.TabIndex = 13;
            // 
            // CP_Inkomsten_dtpTot
            // 
            this.CP_Inkomsten_dtpTot.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(153)))));
            this.CP_Inkomsten_dtpTot.CustomFormat = "MM/dd/yyy";
            this.CP_Inkomsten_dtpTot.Location = new System.Drawing.Point(356, 18);
            this.CP_Inkomsten_dtpTot.Name = "CP_Inkomsten_dtpTot";
            this.CP_Inkomsten_dtpTot.Size = new System.Drawing.Size(217, 22);
            this.CP_Inkomsten_dtpTot.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(153)))));
            this.label2.Location = new System.Drawing.Point(308, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tot:";
            // 
            // CP_Inkomsten_dtpVan
            // 
            this.CP_Inkomsten_dtpVan.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(153)))));
            this.CP_Inkomsten_dtpVan.CustomFormat = "MM/dd/yyyy";
            this.CP_Inkomsten_dtpVan.Location = new System.Drawing.Point(61, 18);
            this.CP_Inkomsten_dtpVan.Name = "CP_Inkomsten_dtpVan";
            this.CP_Inkomsten_dtpVan.Size = new System.Drawing.Size(217, 22);
            this.CP_Inkomsten_dtpVan.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(153)))));
            this.label1.Location = new System.Drawing.Point(5, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Van:";
            // 
            // CP_Inkomsten_btnApply
            // 
            this.CP_Inkomsten_btnApply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.CP_Inkomsten_btnApply.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(153)))));
            this.CP_Inkomsten_btnApply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.CP_Inkomsten_btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CP_Inkomsten_btnApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CP_Inkomsten_btnApply.ForeColor = System.Drawing.Color.White;
            this.CP_Inkomsten_btnApply.Location = new System.Drawing.Point(643, 3);
            this.CP_Inkomsten_btnApply.Name = "CP_Inkomsten_btnApply";
            this.CP_Inkomsten_btnApply.Size = new System.Drawing.Size(199, 50);
            this.CP_Inkomsten_btnApply.TabIndex = 8;
            this.CP_Inkomsten_btnApply.Text = "Toepassen";
            this.CP_Inkomsten_btnApply.UseVisualStyleBackColor = false;
            this.CP_Inkomsten_btnApply.Click += new System.EventHandler(this.CP_Inkomsten_btnApply_Click);
            // 
            // CP_Inkomsten_listView
            // 
            this.CP_Inkomsten_listView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.CP_Inkomsten_listView.FullRowSelect = true;
            this.CP_Inkomsten_listView.HideSelection = false;
            this.CP_Inkomsten_listView.Location = new System.Drawing.Point(4, 59);
            this.CP_Inkomsten_listView.Name = "CP_Inkomsten_listView";
            this.CP_Inkomsten_listView.Size = new System.Drawing.Size(838, 403);
            this.CP_Inkomsten_listView.TabIndex = 0;
            this.CP_Inkomsten_listView.UseCompatibleStateImageBehavior = false;
            this.CP_Inkomsten_listView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.CP_Inkomsten_listView_ColumnClick);
            // 
            // ControlPanelForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1009, 536);
            this.Controls.Add(this.CP_pnlInkomsten);
            this.Controls.Add(this.CP_pnlMenukaarten);
            this.Controls.Add(this.CP_pnlMedewerkers);
            this.Controls.Add(this.CP_pnlVoorraad);
            this.Controls.Add(this.CP_pnlHeader);
            this.Controls.Add(this.CP_pnlNavMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ControlPanelForm";
            this.Text = "Controlepaneel";
            this.CP_pnlNavMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CP_imgLogo)).EndInit();
            this.CP_pnlHeader.ResumeLayout(false);
            this.CP_pnlHeader.PerformLayout();
            this.CP_pnlVoorraad.ResumeLayout(false);
            this.CP_pnlMedewerkers.ResumeLayout(false);
            this.CP_pnlMenukaarten.ResumeLayout(false);
            this.CP_pnlInkomsten.ResumeLayout(false);
            this.CP_pnlInkomsten.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel CP_pnlNavMenu;
        private System.Windows.Forms.Panel CP_pnlHeader;
        private System.Windows.Forms.PictureBox CP_imgLogo;
        private System.Windows.Forms.Button CP_btnVoorraad;
        private System.Windows.Forms.Label CP_lblActivePanel;
        private System.Windows.Forms.Button CP_btnMenukaarten;
        private System.Windows.Forms.Panel CP_pnlVoorraad;
        private System.Windows.Forms.Button CP_btnUitloggen;
        private System.Windows.Forms.Button CP_btnMedewerkers;
        private System.Windows.Forms.Button CP_btnInkomsten;
        private System.Windows.Forms.ListView CP_Menukaarten_listView;
        private System.Windows.Forms.Button CP_Voorraad_btnLunchgerechten;
        private System.Windows.Forms.Button CP_Voorraad_btnDinergerechten;
        private System.Windows.Forms.Button CP_Voorraad_btnDranken;
        private System.Windows.Forms.Button CP_Medewerkers_btnNieuweMedewerker;
        private System.Windows.Forms.ListView CP_Medewerkers_listView;
        private System.Windows.Forms.Panel CP_pnlMedewerkers;
        private System.Windows.Forms.Button CP_Medewerkers_btnVerwijderen;
        private System.Windows.Forms.Button CP_Medewerkers_btnEdit;
        private System.Windows.Forms.Panel CP_pnlMenukaarten;
        private System.Windows.Forms.Button CP_Menukaarten_btnLunchgerechten;
        private System.Windows.Forms.Button CP_Menukaarten_btnDinergerechten;
        private System.Windows.Forms.Button CP_Menukaarten_btnDranken;
        private System.Windows.Forms.Button CP_Menukaarten_btnDeleteItem;
        private System.Windows.Forms.Button CP_Menukaarten_btnEditItem;
        private System.Windows.Forms.Button CP_Menukaarten_btnNewItem;
        private System.Windows.Forms.ListView CP_Voorraad_listView;
        private System.Windows.Forms.Button CP_Voorraad_btnEmptyItem;
        private System.Windows.Forms.Button CP_Voorraad_btnEditItem;
        private System.Windows.Forms.Panel CP_pnlInkomsten;
        private System.Windows.Forms.DateTimePicker CP_Inkomsten_dtpVan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CP_Inkomsten_btnApply;
        private System.Windows.Forms.ListView CP_Inkomsten_listView;
        private System.Windows.Forms.DateTimePicker CP_Inkomsten_dtpTot;
        private System.Windows.Forms.Label label2;
    }
}

