namespace Ui
{
    partial class LunchMenuForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.voorgerechtFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.hoofdgerechtFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.nagerechtFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.CP_imgLogo = new System.Windows.Forms.PictureBox();
            this.backBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CP_imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(155, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Voorgerecht";
            // 
            // voorgerechtFlow
            // 
            this.voorgerechtFlow.AutoScroll = true;
            this.voorgerechtFlow.Location = new System.Drawing.Point(87, 116);
            this.voorgerechtFlow.Name = "voorgerechtFlow";
            this.voorgerechtFlow.Size = new System.Drawing.Size(323, 139);
            this.voorgerechtFlow.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(155, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Hoofdgerecht";
            // 
            // hoofdgerechtFlow
            // 
            this.hoofdgerechtFlow.AutoScroll = true;
            this.hoofdgerechtFlow.Location = new System.Drawing.Point(87, 320);
            this.hoofdgerechtFlow.Name = "hoofdgerechtFlow";
            this.hoofdgerechtFlow.Size = new System.Drawing.Size(323, 142);
            this.hoofdgerechtFlow.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(155, 481);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Nagerecht";
            // 
            // nagerechtFlow
            // 
            this.nagerechtFlow.AutoScroll = true;
            this.nagerechtFlow.Location = new System.Drawing.Point(87, 520);
            this.nagerechtFlow.Name = "nagerechtFlow";
            this.nagerechtFlow.Size = new System.Drawing.Size(323, 100);
            this.nagerechtFlow.TabIndex = 17;
            // 
            // CP_imgLogo
            // 
            this.CP_imgLogo.BackColor = System.Drawing.SystemColors.Control;
            this.CP_imgLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CP_imgLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.CP_imgLogo.Image = global::Ui.Properties.Resources.Logo2;
            this.CP_imgLogo.Location = new System.Drawing.Point(0, 0);
            this.CP_imgLogo.Name = "CP_imgLogo";
            this.CP_imgLogo.Size = new System.Drawing.Size(410, 75);
            this.CP_imgLogo.TabIndex = 11;
            this.CP_imgLogo.TabStop = false;
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(12, 661);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 18;
            this.backBtn.Text = "Terug";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // LunchMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 699);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.nagerechtFlow);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hoofdgerechtFlow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.voorgerechtFlow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CP_imgLogo);
            this.Name = "LunchMenuForm";
            this.Text = "LunchMenuForm";
            this.Load += new System.EventHandler(this.LunchMenuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CP_imgLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox CP_imgLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel voorgerechtFlow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel hoofdgerechtFlow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel nagerechtFlow;
        private System.Windows.Forms.Button backBtn;
    }
}