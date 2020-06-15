namespace Ui
{
    partial class CP_Popup_ChangeStock
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
            this.CP_Popup_ChangeStock_txtStock = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CP_Popup_ChangeStock_lblErrorStock = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CP_Popup_ChangeStock_txtStock
            // 
            this.CP_Popup_ChangeStock_txtStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(153)))));
            this.CP_Popup_ChangeStock_txtStock.Location = new System.Drawing.Point(218, 13);
            this.CP_Popup_ChangeStock_txtStock.Margin = new System.Windows.Forms.Padding(4);
            this.CP_Popup_ChangeStock_txtStock.Name = "CP_Popup_ChangeStock_txtStock";
            this.CP_Popup_ChangeStock_txtStock.Size = new System.Drawing.Size(77, 27);
            this.CP_Popup_ChangeStock_txtStock.TabIndex = 41;
            this.CP_Popup_ChangeStock_txtStock.TextChanged += new System.EventHandler(this.CP_Popup_ChangeStock_txtStock_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(153)))));
            this.label5.Location = new System.Drawing.Point(16, 15);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 19);
            this.label5.TabIndex = 40;
            this.label5.Text = "Voorraad";
            // 
            // CP_Popup_ChangeStock_lblErrorStock
            // 
            this.CP_Popup_ChangeStock_lblErrorStock.AutoSize = true;
            this.CP_Popup_ChangeStock_lblErrorStock.ForeColor = System.Drawing.Color.Red;
            this.CP_Popup_ChangeStock_lblErrorStock.Location = new System.Drawing.Point(295, 18);
            this.CP_Popup_ChangeStock_lblErrorStock.Name = "CP_Popup_ChangeStock_lblErrorStock";
            this.CP_Popup_ChangeStock_lblErrorStock.Size = new System.Drawing.Size(232, 19);
            this.CP_Popup_ChangeStock_lblErrorStock.TabIndex = 43;
            this.CP_Popup_ChangeStock_lblErrorStock.Text = "De voorraad moet een getal zijn";
            this.CP_Popup_ChangeStock_lblErrorStock.Visible = false;
            // 
            // CP_Popup_ChangeStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 353);
            this.Controls.Add(this.CP_Popup_ChangeStock_lblErrorStock);
            this.Controls.Add(this.CP_Popup_ChangeStock_txtStock);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("Roboto", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CP_Popup_ChangeStock";
            this.Text = "Aan menu toevoegen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox CP_Popup_ChangeStock_txtStock;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label CP_Popup_ChangeStock_lblErrorStock;
    }
}