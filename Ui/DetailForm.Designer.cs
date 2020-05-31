namespace Ui
{
    partial class DetailForm
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
            this.nameLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.opmerkingenTxt = new System.Windows.Forms.RichTextBox();
            this.ingredientTxt = new System.Windows.Forms.RichTextBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.prijsLbl = new System.Windows.Forms.Label();
            this.bestelBtn = new System.Windows.Forms.Button();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CP_imgLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CP_imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.nameLbl.Location = new System.Drawing.Point(22, 95);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(87, 25);
            this.nameLbl.TabIndex = 13;
            this.nameLbl.Text = "nameLbl";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Ingredienten:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Opmerkingen:";
            // 
            // opmerkingenTxt
            // 
            this.opmerkingenTxt.Location = new System.Drawing.Point(27, 245);
            this.opmerkingenTxt.Name = "opmerkingenTxt";
            this.opmerkingenTxt.Size = new System.Drawing.Size(368, 96);
            this.opmerkingenTxt.TabIndex = 18;
            this.opmerkingenTxt.Text = "";
            // 
            // ingredientTxt
            // 
            this.ingredientTxt.Location = new System.Drawing.Point(27, 155);
            this.ingredientTxt.Name = "ingredientTxt";
            this.ingredientTxt.Size = new System.Drawing.Size(357, 59);
            this.ingredientTxt.TabIndex = 19;
            this.ingredientTxt.Text = "";
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(27, 505);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 20;
            this.backBtn.Text = "Terug";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 376);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Bestellen";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(27, 428);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 18);
            this.label4.TabIndex = 22;
            this.label4.Text = "Prijs:";
            // 
            // prijsLbl
            // 
            this.prijsLbl.AutoSize = true;
            this.prijsLbl.Location = new System.Drawing.Point(89, 433);
            this.prijsLbl.Name = "prijsLbl";
            this.prijsLbl.Size = new System.Drawing.Size(35, 13);
            this.prijsLbl.TabIndex = 23;
            this.prijsLbl.Text = "label5";
            // 
            // bestelBtn
            // 
            this.bestelBtn.Location = new System.Drawing.Point(320, 505);
            this.bestelBtn.Name = "bestelBtn";
            this.bestelBtn.Size = new System.Drawing.Size(75, 23);
            this.bestelBtn.TabIndex = 24;
            this.bestelBtn.Text = "Bestel";
            this.bestelBtn.UseVisualStyleBackColor = true;
            this.bestelBtn.Click += new System.EventHandler(this.bestelBtn_Click);
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(102, 373);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(45, 21);
            this.comboBox.TabIndex = 25;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 433);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "€";
            // 
            // CP_imgLogo
            // 
            this.CP_imgLogo.BackColor = System.Drawing.SystemColors.Control;
            this.CP_imgLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CP_imgLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.CP_imgLogo.Image = global::Ui.Properties.Resources.Logo2;
            this.CP_imgLogo.Location = new System.Drawing.Point(0, 0);
            this.CP_imgLogo.Name = "CP_imgLogo";
            this.CP_imgLogo.Size = new System.Drawing.Size(438, 75);
            this.CP_imgLogo.TabIndex = 12;
            this.CP_imgLogo.TabStop = false;
            // 
            // DetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 540);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.bestelBtn);
            this.Controls.Add(this.prijsLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.ingredientTxt);
            this.Controls.Add(this.opmerkingenTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.CP_imgLogo);
            this.Name = "DetailForm";
            this.Text = "DetailForm";
            this.Load += new System.EventHandler(this.DetailForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CP_imgLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox CP_imgLogo;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox opmerkingenTxt;
        private System.Windows.Forms.RichTextBox ingredientTxt;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label prijsLbl;
        private System.Windows.Forms.Button bestelBtn;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Label label5;
    }
}