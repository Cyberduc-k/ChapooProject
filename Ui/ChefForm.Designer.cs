namespace Ui
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Chef_btnOverzicht = new System.Windows.Forms.Button();
            this.Chef_btnVoorraad = new System.Windows.Forms.Button();
            this.Chef_btnUitloggen = new System.Windows.Forms.Button();
            this.Chef_pnlTop = new System.Windows.Forms.Panel();
            this.Chef_lblActivePanel = new System.Windows.Forms.Label();
            this.Chef_pnlOverzicht = new System.Windows.Forms.Panel();
            this.Chef_pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Chef_pnlTop.SuspendLayout();
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
            // Chef_btnOverzicht
            // 
            this.Chef_btnOverzicht.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.Chef_btnOverzicht.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(153)))));
            this.Chef_btnOverzicht.FlatAppearance.BorderSize = 2;
            this.Chef_btnOverzicht.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Chef_btnOverzicht.Font = new System.Drawing.Font("Roboto", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chef_btnOverzicht.ForeColor = System.Drawing.Color.White;
            this.Chef_btnOverzicht.Location = new System.Drawing.Point(0, 126);
            this.Chef_btnOverzicht.Name = "Chef_btnOverzicht";
            this.Chef_btnOverzicht.Size = new System.Drawing.Size(285, 92);
            this.Chef_btnOverzicht.TabIndex = 1;
            this.Chef_btnOverzicht.Text = "Overzicht";
            this.Chef_btnOverzicht.UseVisualStyleBackColor = false;
            this.Chef_btnOverzicht.Click += new System.EventHandler(this.Chef_btnOverzicht_Click);
            // 
            // Chef_btnVoorraad
            // 
            this.Chef_btnVoorraad.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(153)))));
            this.Chef_btnVoorraad.FlatAppearance.BorderSize = 2;
            this.Chef_btnVoorraad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Chef_btnVoorraad.Font = new System.Drawing.Font("Roboto", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chef_btnVoorraad.ForeColor = System.Drawing.Color.White;
            this.Chef_btnVoorraad.Location = new System.Drawing.Point(0, 216);
            this.Chef_btnVoorraad.Name = "Chef_btnVoorraad";
            this.Chef_btnVoorraad.Size = new System.Drawing.Size(285, 92);
            this.Chef_btnVoorraad.TabIndex = 1;
            this.Chef_btnVoorraad.Text = "Voorraad";
            this.Chef_btnVoorraad.UseVisualStyleBackColor = true;
            this.Chef_btnVoorraad.Click += new System.EventHandler(this.Chef_btnVoorraad_Click);
            // 
            // Chef_btnUitloggen
            // 
            this.Chef_btnUitloggen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(153)))));
            this.Chef_btnUitloggen.FlatAppearance.BorderSize = 0;
            this.Chef_btnUitloggen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Chef_btnUitloggen.Font = new System.Drawing.Font("Roboto", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chef_btnUitloggen.ForeColor = System.Drawing.Color.White;
            this.Chef_btnUitloggen.Location = new System.Drawing.Point(1, 947);
            this.Chef_btnUitloggen.Name = "Chef_btnUitloggen";
            this.Chef_btnUitloggen.Size = new System.Drawing.Size(285, 92);
            this.Chef_btnUitloggen.TabIndex = 1;
            this.Chef_btnUitloggen.Text = "Uitloggen";
            this.Chef_btnUitloggen.UseVisualStyleBackColor = true;
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
            this.Chef_lblActivePanel.Font = new System.Drawing.Font("Roboto", 80.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.Chef_pnlOverzicht.Location = new System.Drawing.Point(286, 125);
            this.Chef_pnlOverzicht.Margin = new System.Windows.Forms.Padding(0);
            this.Chef_pnlOverzicht.Name = "Chef_pnlOverzicht";
            this.Chef_pnlOverzicht.Size = new System.Drawing.Size(1618, 915);
            this.Chef_pnlOverzicht.TabIndex = 2;
            // 
            // ChefForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.Chef_pnlOverzicht);
            this.Controls.Add(this.Chef_pnlTop);
            this.Controls.Add(this.Chef_pnlLeft);
            this.Name = "ChefForm";
            this.Text = "Overzicht";
            this.Chef_pnlLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Chef_pnlTop.ResumeLayout(false);
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
    }
}