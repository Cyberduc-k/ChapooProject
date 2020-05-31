namespace Ui
{
    partial class CP_Popup_Sure
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CP_Popup_Sure_lblText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // CP_Popup_Sure_lblText
            // 
            this.CP_Popup_Sure_lblText.AutoSize = true;
            this.CP_Popup_Sure_lblText.Font = new System.Drawing.Font("Roboto", 12F);
            this.CP_Popup_Sure_lblText.Location = new System.Drawing.Point(159, 117);
            this.CP_Popup_Sure_lblText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CP_Popup_Sure_lblText.Name = "CP_Popup_Sure_lblText";
            this.CP_Popup_Sure_lblText.Size = new System.Drawing.Size(403, 19);
            this.CP_Popup_Sure_lblText.TabIndex = 3;
            this.CP_Popup_Sure_lblText.Text = "Weet je zeker dat je \"Xavier\" van de lijst wilt verwijderen?";
            this.CP_Popup_Sure_lblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CP_Popup_Sure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 343);
            this.Controls.Add(this.CP_Popup_Sure_lblText);
            this.Font = new System.Drawing.Font("Roboto", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CP_Popup_Sure";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label CP_Popup_Sure_lblText;
    }
}