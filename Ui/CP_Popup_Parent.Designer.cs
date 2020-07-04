namespace Ui
{
    partial class CP_Popup_Parent
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
            this.CP_Popup_Parent_btnCancel = new System.Windows.Forms.Button();
            this.CP_Popup_Parent_btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CP_Popup_Parent_btnCancel
            // 
            this.CP_Popup_Parent_btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(204)))));
            this.CP_Popup_Parent_btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CP_Popup_Parent_btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(153)))));
            this.CP_Popup_Parent_btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.CP_Popup_Parent_btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CP_Popup_Parent_btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CP_Popup_Parent_btnCancel.ForeColor = System.Drawing.Color.White;
            this.CP_Popup_Parent_btnCancel.Location = new System.Drawing.Point(342, 294);
            this.CP_Popup_Parent_btnCancel.Margin = new System.Windows.Forms.Padding(6);
            this.CP_Popup_Parent_btnCancel.Name = "CP_Popup_Parent_btnCancel";
            this.CP_Popup_Parent_btnCancel.Size = new System.Drawing.Size(315, 44);
            this.CP_Popup_Parent_btnCancel.TabIndex = 12;
            this.CP_Popup_Parent_btnCancel.Text = "Cancel";
            this.CP_Popup_Parent_btnCancel.UseVisualStyleBackColor = false;
            this.CP_Popup_Parent_btnCancel.Click += new System.EventHandler(this.CP_Popup_Parent_btnCancel_Click);
            // 
            // CP_Popup_Parent_btnOK
            // 
            this.CP_Popup_Parent_btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(204)))));
            this.CP_Popup_Parent_btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.CP_Popup_Parent_btnOK.Enabled = false;
            this.CP_Popup_Parent_btnOK.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(153)))));
            this.CP_Popup_Parent_btnOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.CP_Popup_Parent_btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CP_Popup_Parent_btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CP_Popup_Parent_btnOK.ForeColor = System.Drawing.Color.White;
            this.CP_Popup_Parent_btnOK.Location = new System.Drawing.Point(15, 294);
            this.CP_Popup_Parent_btnOK.Margin = new System.Windows.Forms.Padding(6);
            this.CP_Popup_Parent_btnOK.Name = "CP_Popup_Parent_btnOK";
            this.CP_Popup_Parent_btnOK.Size = new System.Drawing.Size(315, 44);
            this.CP_Popup_Parent_btnOK.TabIndex = 11;
            this.CP_Popup_Parent_btnOK.Text = "Oke";
            this.CP_Popup_Parent_btnOK.UseVisualStyleBackColor = false;
            this.CP_Popup_Parent_btnOK.Click += new System.EventHandler(this.CP_Popup_Parent_btnOK_Click);
            // 
            // CP_Popup_Parent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(672, 353);
            this.Controls.Add(this.CP_Popup_Parent_btnCancel);
            this.Controls.Add(this.CP_Popup_Parent_btnOK);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(153)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CP_Popup_Parent";
            this.Text = "CP_Popup_Sure";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button CP_Popup_Parent_btnCancel;
        public System.Windows.Forms.Button CP_Popup_Parent_btnOK;
    }
}