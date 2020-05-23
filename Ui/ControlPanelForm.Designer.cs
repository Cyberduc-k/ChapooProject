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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CP_btnHome = new System.Windows.Forms.Button();
            this.CP_btnVoorraad = new System.Windows.Forms.Button();
            this.CP_lblActivePanel = new System.Windows.Forms.Label();
            this.CP_btnMenukaarten = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CP_btnUitloggen = new System.Windows.Forms.Button();
            this.CP_btnBestellingen = new System.Windows.Forms.Button();
            this.CP_btnInkomsten = new System.Windows.Forms.Button();
            this.CP_btnMedewerkers = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(165)))), ((int)(((byte)(229)))));
            this.panel1.Controls.Add(this.CP_btnMedewerkers);
            this.panel1.Controls.Add(this.CP_btnInkomsten);
            this.panel1.Controls.Add(this.CP_btnBestellingen);
            this.panel1.Controls.Add(this.CP_btnUitloggen);
            this.panel1.Controls.Add(this.CP_btnMenukaarten);
            this.panel1.Controls.Add(this.CP_btnVoorraad);
            this.panel1.Controls.Add(this.CP_btnHome);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(151, 537);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(165)))), ((int)(((byte)(229)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.CP_lblActivePanel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(151, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(857, 66);
            this.panel2.TabIndex = 2;
            // 
            // CP_btnHome
            // 
            this.CP_btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.CP_btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.CP_btnHome.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(153)))));
            this.CP_btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.CP_btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CP_btnHome.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CP_btnHome.ForeColor = System.Drawing.Color.White;
            this.CP_btnHome.Location = new System.Drawing.Point(0, 66);
            this.CP_btnHome.Name = "CP_btnHome";
            this.CP_btnHome.Size = new System.Drawing.Size(151, 50);
            this.CP_btnHome.TabIndex = 0;
            this.CP_btnHome.Text = "Home";
            this.CP_btnHome.UseVisualStyleBackColor = false;
            this.CP_btnHome.Click += new System.EventHandler(this.CP_btnHome_Click);
            // 
            // CP_btnVoorraad
            // 
            this.CP_btnVoorraad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(165)))), ((int)(((byte)(229)))));
            this.CP_btnVoorraad.Dock = System.Windows.Forms.DockStyle.Top;
            this.CP_btnVoorraad.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(153)))));
            this.CP_btnVoorraad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.CP_btnVoorraad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CP_btnVoorraad.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CP_btnVoorraad.ForeColor = System.Drawing.Color.White;
            this.CP_btnVoorraad.Location = new System.Drawing.Point(0, 116);
            this.CP_btnVoorraad.Name = "CP_btnVoorraad";
            this.CP_btnVoorraad.Size = new System.Drawing.Size(151, 50);
            this.CP_btnVoorraad.TabIndex = 2;
            this.CP_btnVoorraad.Text = "Voorraad";
            this.CP_btnVoorraad.UseVisualStyleBackColor = false;
            this.CP_btnVoorraad.Click += new System.EventHandler(this.CP_btnVoorraad_Click);
            // 
            // CP_lblActivePanel
            // 
            this.CP_lblActivePanel.AutoSize = true;
            this.CP_lblActivePanel.Font = new System.Drawing.Font("Roboto", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CP_lblActivePanel.ForeColor = System.Drawing.Color.White;
            this.CP_lblActivePanel.Location = new System.Drawing.Point(366, 7);
            this.CP_lblActivePanel.Name = "CP_lblActivePanel";
            this.CP_lblActivePanel.Size = new System.Drawing.Size(113, 42);
            this.CP_lblActivePanel.TabIndex = 0;
            this.CP_lblActivePanel.Text = "Home";
            // 
            // CP_btnMenukaarten
            // 
            this.CP_btnMenukaarten.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(165)))), ((int)(((byte)(229)))));
            this.CP_btnMenukaarten.Dock = System.Windows.Forms.DockStyle.Top;
            this.CP_btnMenukaarten.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(153)))));
            this.CP_btnMenukaarten.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.CP_btnMenukaarten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CP_btnMenukaarten.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CP_btnMenukaarten.ForeColor = System.Drawing.Color.White;
            this.CP_btnMenukaarten.Location = new System.Drawing.Point(0, 166);
            this.CP_btnMenukaarten.Name = "CP_btnMenukaarten";
            this.CP_btnMenukaarten.Size = new System.Drawing.Size(151, 50);
            this.CP_btnMenukaarten.TabIndex = 3;
            this.CP_btnMenukaarten.Text = "Menukaarten";
            this.CP_btnMenukaarten.UseVisualStyleBackColor = false;
            this.CP_btnMenukaarten.Click += new System.EventHandler(this.CP_btnMenukaarten_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(151, 66);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(857, 471);
            this.panel3.TabIndex = 3;
            // 
            // CP_btnUitloggen
            // 
            this.CP_btnUitloggen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(165)))), ((int)(((byte)(229)))));
            this.CP_btnUitloggen.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CP_btnUitloggen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(153)))));
            this.CP_btnUitloggen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.CP_btnUitloggen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CP_btnUitloggen.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CP_btnUitloggen.ForeColor = System.Drawing.Color.White;
            this.CP_btnUitloggen.Location = new System.Drawing.Point(0, 475);
            this.CP_btnUitloggen.Name = "CP_btnUitloggen";
            this.CP_btnUitloggen.Size = new System.Drawing.Size(151, 62);
            this.CP_btnUitloggen.TabIndex = 4;
            this.CP_btnUitloggen.Text = "Uitloggen";
            this.CP_btnUitloggen.UseVisualStyleBackColor = false;
            this.CP_btnUitloggen.Click += new System.EventHandler(this.CP_btnUitloggen_Click);
            // 
            // CP_btnBestellingen
            // 
            this.CP_btnBestellingen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(165)))), ((int)(((byte)(229)))));
            this.CP_btnBestellingen.Dock = System.Windows.Forms.DockStyle.Top;
            this.CP_btnBestellingen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(153)))));
            this.CP_btnBestellingen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.CP_btnBestellingen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CP_btnBestellingen.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CP_btnBestellingen.ForeColor = System.Drawing.Color.White;
            this.CP_btnBestellingen.Location = new System.Drawing.Point(0, 216);
            this.CP_btnBestellingen.Name = "CP_btnBestellingen";
            this.CP_btnBestellingen.Size = new System.Drawing.Size(151, 50);
            this.CP_btnBestellingen.TabIndex = 5;
            this.CP_btnBestellingen.Text = "Bestellingen";
            this.CP_btnBestellingen.UseVisualStyleBackColor = false;
            this.CP_btnBestellingen.Click += new System.EventHandler(this.CP_btnBestellingen_Click);
            // 
            // CP_btnInkomsten
            // 
            this.CP_btnInkomsten.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(165)))), ((int)(((byte)(229)))));
            this.CP_btnInkomsten.Dock = System.Windows.Forms.DockStyle.Top;
            this.CP_btnInkomsten.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(153)))));
            this.CP_btnInkomsten.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.CP_btnInkomsten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CP_btnInkomsten.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CP_btnInkomsten.ForeColor = System.Drawing.Color.White;
            this.CP_btnInkomsten.Location = new System.Drawing.Point(0, 266);
            this.CP_btnInkomsten.Name = "CP_btnInkomsten";
            this.CP_btnInkomsten.Size = new System.Drawing.Size(151, 50);
            this.CP_btnInkomsten.TabIndex = 6;
            this.CP_btnInkomsten.Text = "Inkomsten";
            this.CP_btnInkomsten.UseVisualStyleBackColor = false;
            this.CP_btnInkomsten.Click += new System.EventHandler(this.CP_btnInkomsten_Click);
            // 
            // CP_btnMedewerkers
            // 
            this.CP_btnMedewerkers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(165)))), ((int)(((byte)(229)))));
            this.CP_btnMedewerkers.Dock = System.Windows.Forms.DockStyle.Top;
            this.CP_btnMedewerkers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(153)))));
            this.CP_btnMedewerkers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.CP_btnMedewerkers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CP_btnMedewerkers.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CP_btnMedewerkers.ForeColor = System.Drawing.Color.White;
            this.CP_btnMedewerkers.Location = new System.Drawing.Point(0, 316);
            this.CP_btnMedewerkers.Name = "CP_btnMedewerkers";
            this.CP_btnMedewerkers.Size = new System.Drawing.Size(151, 50);
            this.CP_btnMedewerkers.TabIndex = 7;
            this.CP_btnMedewerkers.Text = "Medewerkers";
            this.CP_btnMedewerkers.UseVisualStyleBackColor = false;
            this.CP_btnMedewerkers.Click += new System.EventHandler(this.CP_btnMedewerkers_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::Ui.Properties.Resources.Logo2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 66);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // ControlPanelForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1008, 537);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ControlPanelForm";
            this.Text = "Controlepaneel";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CP_btnHome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button CP_btnVoorraad;
        private System.Windows.Forms.Label CP_lblActivePanel;
        private System.Windows.Forms.Button CP_btnMenukaarten;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button CP_btnUitloggen;
        private System.Windows.Forms.Button CP_btnMedewerkers;
        private System.Windows.Forms.Button CP_btnInkomsten;
        private System.Windows.Forms.Button CP_btnBestellingen;
    }
}

