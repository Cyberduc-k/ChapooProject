namespace Ui
{
    partial class CP_Feedback
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
            this.CP_Feedback_lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CP_Feedback_lblMessage
            // 
            this.CP_Feedback_lblMessage.AutoSize = true;
            this.CP_Feedback_lblMessage.BackColor = System.Drawing.Color.Transparent;
            this.CP_Feedback_lblMessage.Font = new System.Drawing.Font("Roboto", 30F);
            this.CP_Feedback_lblMessage.ForeColor = System.Drawing.Color.White;
            this.CP_Feedback_lblMessage.Location = new System.Drawing.Point(25, 44);
            this.CP_Feedback_lblMessage.MaximumSize = new System.Drawing.Size(1200, 48);
            this.CP_Feedback_lblMessage.MinimumSize = new System.Drawing.Size(1200, 48);
            this.CP_Feedback_lblMessage.Name = "CP_Feedback_lblMessage";
            this.CP_Feedback_lblMessage.Size = new System.Drawing.Size(1200, 48);
            this.CP_Feedback_lblMessage.TabIndex = 0;
            this.CP_Feedback_lblMessage.Text = "Een medewerker is succesvol uit de lijst verwijderd";
            this.CP_Feedback_lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CP_Feedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(1247, 128);
            this.Controls.Add(this.CP_Feedback_lblMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CP_Feedback";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CP_Feedback";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CP_Feedback_lblMessage;
    }
}