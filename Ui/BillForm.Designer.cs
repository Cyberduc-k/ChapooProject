namespace Ui
{
    partial class BillForm
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
            this.Bill_lblTableNumber = new System.Windows.Forms.Label();
            this.Bill_btnBillOverview = new System.Windows.Forms.Button();
            this.Bill_btnPay = new System.Windows.Forms.Button();
            this.Bill_rbPaypal = new System.Windows.Forms.RadioButton();
            this.Bill_rbMastercard = new System.Windows.Forms.RadioButton();
            this.Bill_rbVisa = new System.Windows.Forms.RadioButton();
            this.Bill_rbCash = new System.Windows.Forms.RadioButton();
            this.Bill_lvBillOverview = new System.Windows.Forms.ListView();
            this.Bill_btnKiesBetaalmethode = new System.Windows.Forms.Button();
            this.Bill_pnlBetaalMethode = new System.Windows.Forms.Panel();
            this.Bill_btnBetaalmethodeX = new System.Windows.Forms.Button();
            this.Bill_pnlFooi = new System.Windows.Forms.Panel();
            this.Bill_btnFooiX = new System.Windows.Forms.Button();
            this.Bill_txbAanvullenTot = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Bill_btnFooiPlus20 = new System.Windows.Forms.Button();
            this.Bill_btnFooiPlus10 = new System.Windows.Forms.Button();
            this.Bill_btnFooiPlus5 = new System.Windows.Forms.Button();
            this.Bill_btnPasAan = new System.Windows.Forms.Button();
            this.Bill_lblBetaald = new System.Windows.Forms.Label();
            this.Bill_btnFooi = new System.Windows.Forms.Button();
            this.Bill_lblTotalPrice = new System.Windows.Forms.Label();
            this.Bill_lblBtw = new System.Windows.Forms.Label();
            this.Bill_lblBtwLinks = new System.Windows.Forms.Label();
            this.Bill_lblTotaalBedrag = new System.Windows.Forms.Label();
            this.CP_imgLogo = new System.Windows.Forms.PictureBox();
            this.Bill_lblAfrekenen = new System.Windows.Forms.Label();
            this.Bill_pnlBetaalMethode.SuspendLayout();
            this.Bill_pnlFooi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CP_imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // Bill_lblTableNumber
            // 
            this.Bill_lblTableNumber.AutoSize = true;
            this.Bill_lblTableNumber.Location = new System.Drawing.Point(12, 94);
            this.Bill_lblTableNumber.Name = "Bill_lblTableNumber";
            this.Bill_lblTableNumber.Size = new System.Drawing.Size(83, 13);
            this.Bill_lblTableNumber.TabIndex = 0;
            this.Bill_lblTableNumber.Text = "Tafel nummer: 1";
            // 
            // Bill_btnBillOverview
            // 
            this.Bill_btnBillOverview.Location = new System.Drawing.Point(101, 90);
            this.Bill_btnBillOverview.Name = "Bill_btnBillOverview";
            this.Bill_btnBillOverview.Size = new System.Drawing.Size(113, 21);
            this.Bill_btnBillOverview.TabIndex = 2;
            this.Bill_btnBillOverview.Text = "Rekening overzicht";
            this.Bill_btnBillOverview.UseVisualStyleBackColor = true;
            this.Bill_btnBillOverview.Click += new System.EventHandler(this.Bill_btnRekeningOverzicht_Click);
            // 
            // Bill_btnPay
            // 
            this.Bill_btnPay.Location = new System.Drawing.Point(292, 87);
            this.Bill_btnPay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Bill_btnPay.Name = "Bill_btnPay";
            this.Bill_btnPay.Size = new System.Drawing.Size(55, 23);
            this.Bill_btnPay.TabIndex = 23;
            this.Bill_btnPay.Text = "Betaal";
            this.Bill_btnPay.UseVisualStyleBackColor = true;
            this.Bill_btnPay.Click += new System.EventHandler(this.Bill_btnPay_Click);
            // 
            // Bill_rbPaypal
            // 
            this.Bill_rbPaypal.AutoSize = true;
            this.Bill_rbPaypal.Location = new System.Drawing.Point(11, 75);
            this.Bill_rbPaypal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Bill_rbPaypal.Name = "Bill_rbPaypal";
            this.Bill_rbPaypal.Size = new System.Drawing.Size(57, 17);
            this.Bill_rbPaypal.TabIndex = 22;
            this.Bill_rbPaypal.Text = "Paypal";
            this.Bill_rbPaypal.UseVisualStyleBackColor = true;
            // 
            // Bill_rbMastercard
            // 
            this.Bill_rbMastercard.AutoSize = true;
            this.Bill_rbMastercard.Location = new System.Drawing.Point(11, 33);
            this.Bill_rbMastercard.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Bill_rbMastercard.Name = "Bill_rbMastercard";
            this.Bill_rbMastercard.Size = new System.Drawing.Size(78, 17);
            this.Bill_rbMastercard.TabIndex = 21;
            this.Bill_rbMastercard.Text = "Mastercard";
            this.Bill_rbMastercard.UseVisualStyleBackColor = true;
            // 
            // Bill_rbVisa
            // 
            this.Bill_rbVisa.AutoSize = true;
            this.Bill_rbVisa.Location = new System.Drawing.Point(11, 54);
            this.Bill_rbVisa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Bill_rbVisa.Name = "Bill_rbVisa";
            this.Bill_rbVisa.Size = new System.Drawing.Size(45, 17);
            this.Bill_rbVisa.TabIndex = 20;
            this.Bill_rbVisa.Text = "Visa";
            this.Bill_rbVisa.UseVisualStyleBackColor = true;
            // 
            // Bill_rbCash
            // 
            this.Bill_rbCash.AutoSize = true;
            this.Bill_rbCash.Checked = true;
            this.Bill_rbCash.Location = new System.Drawing.Point(11, 12);
            this.Bill_rbCash.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Bill_rbCash.Name = "Bill_rbCash";
            this.Bill_rbCash.Size = new System.Drawing.Size(49, 17);
            this.Bill_rbCash.TabIndex = 19;
            this.Bill_rbCash.TabStop = true;
            this.Bill_rbCash.Text = "Cash";
            this.Bill_rbCash.UseVisualStyleBackColor = true;
            // 
            // Bill_lvBillOverview
            // 
            this.Bill_lvBillOverview.HideSelection = false;
            this.Bill_lvBillOverview.Location = new System.Drawing.Point(14, 118);
            this.Bill_lvBillOverview.Name = "Bill_lvBillOverview";
            this.Bill_lvBillOverview.Size = new System.Drawing.Size(426, 339);
            this.Bill_lvBillOverview.TabIndex = 3;
            this.Bill_lvBillOverview.UseCompatibleStateImageBehavior = false;
            this.Bill_lvBillOverview.View = System.Windows.Forms.View.Details;
            // 
            // Bill_btnKiesBetaalmethode
            // 
            this.Bill_btnKiesBetaalmethode.Location = new System.Drawing.Point(69, 462);
            this.Bill_btnKiesBetaalmethode.Name = "Bill_btnKiesBetaalmethode";
            this.Bill_btnKiesBetaalmethode.Size = new System.Drawing.Size(111, 32);
            this.Bill_btnKiesBetaalmethode.TabIndex = 24;
            this.Bill_btnKiesBetaalmethode.Text = "Kies betaalmethode";
            this.Bill_btnKiesBetaalmethode.UseVisualStyleBackColor = true;
            this.Bill_btnKiesBetaalmethode.Click += new System.EventHandler(this.Bill_btnKiesBetaalmethode_Click_1);
            // 
            // Bill_pnlBetaalMethode
            // 
            this.Bill_pnlBetaalMethode.BackColor = System.Drawing.SystemColors.Window;
            this.Bill_pnlBetaalMethode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Bill_pnlBetaalMethode.Controls.Add(this.Bill_btnBetaalmethodeX);
            this.Bill_pnlBetaalMethode.Controls.Add(this.Bill_rbCash);
            this.Bill_pnlBetaalMethode.Controls.Add(this.Bill_btnPay);
            this.Bill_pnlBetaalMethode.Controls.Add(this.Bill_rbMastercard);
            this.Bill_pnlBetaalMethode.Controls.Add(this.Bill_rbVisa);
            this.Bill_pnlBetaalMethode.Controls.Add(this.Bill_rbPaypal);
            this.Bill_pnlBetaalMethode.Location = new System.Drawing.Point(47, 233);
            this.Bill_pnlBetaalMethode.Name = "Bill_pnlBetaalMethode";
            this.Bill_pnlBetaalMethode.Size = new System.Drawing.Size(351, 114);
            this.Bill_pnlBetaalMethode.TabIndex = 25;
            // 
            // Bill_btnBetaalmethodeX
            // 
            this.Bill_btnBetaalmethodeX.Location = new System.Drawing.Point(326, -1);
            this.Bill_btnBetaalmethodeX.Name = "Bill_btnBetaalmethodeX";
            this.Bill_btnBetaalmethodeX.Size = new System.Drawing.Size(24, 23);
            this.Bill_btnBetaalmethodeX.TabIndex = 24;
            this.Bill_btnBetaalmethodeX.Text = "x";
            this.Bill_btnBetaalmethodeX.UseVisualStyleBackColor = true;
            this.Bill_btnBetaalmethodeX.Click += new System.EventHandler(this.Bill_btnBetaalmethodeX_Click);
            // 
            // Bill_pnlFooi
            // 
            this.Bill_pnlFooi.BackColor = System.Drawing.SystemColors.Window;
            this.Bill_pnlFooi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Bill_pnlFooi.Controls.Add(this.Bill_btnFooiX);
            this.Bill_pnlFooi.Controls.Add(this.Bill_txbAanvullenTot);
            this.Bill_pnlFooi.Controls.Add(this.label1);
            this.Bill_pnlFooi.Controls.Add(this.Bill_btnFooiPlus20);
            this.Bill_pnlFooi.Controls.Add(this.Bill_btnFooiPlus10);
            this.Bill_pnlFooi.Controls.Add(this.Bill_btnFooiPlus5);
            this.Bill_pnlFooi.Controls.Add(this.Bill_btnPasAan);
            this.Bill_pnlFooi.Location = new System.Drawing.Point(47, 233);
            this.Bill_pnlFooi.Name = "Bill_pnlFooi";
            this.Bill_pnlFooi.Size = new System.Drawing.Size(351, 114);
            this.Bill_pnlFooi.TabIndex = 26;
            // 
            // Bill_btnFooiX
            // 
            this.Bill_btnFooiX.Location = new System.Drawing.Point(326, -1);
            this.Bill_btnFooiX.Name = "Bill_btnFooiX";
            this.Bill_btnFooiX.Size = new System.Drawing.Size(24, 23);
            this.Bill_btnFooiX.TabIndex = 25;
            this.Bill_btnFooiX.Text = "x";
            this.Bill_btnFooiX.UseVisualStyleBackColor = true;
            this.Bill_btnFooiX.Click += new System.EventHandler(this.Bill_btnFooiX_Click);
            // 
            // Bill_txbAanvullenTot
            // 
            this.Bill_txbAanvullenTot.Location = new System.Drawing.Point(86, 89);
            this.Bill_txbAanvullenTot.Name = "Bill_txbAanvullenTot";
            this.Bill_txbAanvullenTot.Size = new System.Drawing.Size(100, 20);
            this.Bill_txbAanvullenTot.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "aanvullen tot €";
            // 
            // Bill_btnFooiPlus20
            // 
            this.Bill_btnFooiPlus20.Location = new System.Drawing.Point(3, 61);
            this.Bill_btnFooiPlus20.Name = "Bill_btnFooiPlus20";
            this.Bill_btnFooiPlus20.Size = new System.Drawing.Size(75, 23);
            this.Bill_btnFooiPlus20.TabIndex = 26;
            this.Bill_btnFooiPlus20.Text = "+ € 20,00";
            this.Bill_btnFooiPlus20.UseVisualStyleBackColor = true;
            this.Bill_btnFooiPlus20.Click += new System.EventHandler(this.Bill_btnFooiPlus20_Click);
            // 
            // Bill_btnFooiPlus10
            // 
            this.Bill_btnFooiPlus10.Location = new System.Drawing.Point(3, 32);
            this.Bill_btnFooiPlus10.Name = "Bill_btnFooiPlus10";
            this.Bill_btnFooiPlus10.Size = new System.Drawing.Size(75, 23);
            this.Bill_btnFooiPlus10.TabIndex = 25;
            this.Bill_btnFooiPlus10.Text = "+ € 10,00";
            this.Bill_btnFooiPlus10.UseVisualStyleBackColor = true;
            this.Bill_btnFooiPlus10.Click += new System.EventHandler(this.Bill_btnFooiPlus10_Click);
            // 
            // Bill_btnFooiPlus5
            // 
            this.Bill_btnFooiPlus5.Location = new System.Drawing.Point(3, 3);
            this.Bill_btnFooiPlus5.Name = "Bill_btnFooiPlus5";
            this.Bill_btnFooiPlus5.Size = new System.Drawing.Size(75, 23);
            this.Bill_btnFooiPlus5.TabIndex = 24;
            this.Bill_btnFooiPlus5.Text = "+ € 5,00";
            this.Bill_btnFooiPlus5.UseVisualStyleBackColor = true;
            this.Bill_btnFooiPlus5.Click += new System.EventHandler(this.Bill_btnFooiPlus5_Click);
            // 
            // Bill_btnPasAan
            // 
            this.Bill_btnPasAan.Location = new System.Drawing.Point(292, 87);
            this.Bill_btnPasAan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Bill_btnPasAan.Name = "Bill_btnPasAan";
            this.Bill_btnPasAan.Size = new System.Drawing.Size(55, 23);
            this.Bill_btnPasAan.TabIndex = 23;
            this.Bill_btnPasAan.Text = "Pas aan";
            this.Bill_btnPasAan.UseVisualStyleBackColor = true;
            this.Bill_btnPasAan.Click += new System.EventHandler(this.Bill_btnPasAan_Click);
            // 
            // Bill_lblBetaald
            // 
            this.Bill_lblBetaald.AutoSize = true;
            this.Bill_lblBetaald.Location = new System.Drawing.Point(166, 286);
            this.Bill_lblBetaald.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Bill_lblBetaald.Name = "Bill_lblBetaald";
            this.Bill_lblBetaald.Size = new System.Drawing.Size(124, 13);
            this.Bill_lblBetaald.TabIndex = 29;
            this.Bill_lblBetaald.Text = "De rekening is al betaald";
            // 
            // Bill_btnFooi
            // 
            this.Bill_btnFooi.Location = new System.Drawing.Point(12, 462);
            this.Bill_btnFooi.Name = "Bill_btnFooi";
            this.Bill_btnFooi.Size = new System.Drawing.Size(51, 32);
            this.Bill_btnFooi.TabIndex = 27;
            this.Bill_btnFooi.Text = "Fooi";
            this.Bill_btnFooi.UseVisualStyleBackColor = true;
            this.Bill_btnFooi.Click += new System.EventHandler(this.Bill_btnFooi_Click);
            // 
            // Bill_lblTotalPrice
            // 
            this.Bill_lblTotalPrice.AutoSize = true;
            this.Bill_lblTotalPrice.Location = new System.Drawing.Point(389, 472);
            this.Bill_lblTotalPrice.Name = "Bill_lblTotalPrice";
            this.Bill_lblTotalPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Bill_lblTotalPrice.Size = new System.Drawing.Size(49, 13);
            this.Bill_lblTotalPrice.TabIndex = 28;
            this.Bill_lblTotalPrice.Text = "€ 000,00";
            this.Bill_lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Bill_lblBtw
            // 
            this.Bill_lblBtw.AutoSize = true;
            this.Bill_lblBtw.Location = new System.Drawing.Point(210, 472);
            this.Bill_lblBtw.Name = "Bill_lblBtw";
            this.Bill_lblBtw.Size = new System.Drawing.Size(49, 13);
            this.Bill_lblBtw.TabIndex = 30;
            this.Bill_lblBtw.Text = "€ 000,00";
            // 
            // Bill_lblBtwLinks
            // 
            this.Bill_lblBtwLinks.AutoSize = true;
            this.Bill_lblBtwLinks.Location = new System.Drawing.Point(186, 472);
            this.Bill_lblBtwLinks.Name = "Bill_lblBtwLinks";
            this.Bill_lblBtwLinks.Size = new System.Drawing.Size(27, 13);
            this.Bill_lblBtwLinks.TabIndex = 31;
            this.Bill_lblBtwLinks.Text = "btw:";
            // 
            // Bill_lblTotaalBedrag
            // 
            this.Bill_lblTotaalBedrag.AutoSize = true;
            this.Bill_lblTotaalBedrag.Location = new System.Drawing.Point(307, 472);
            this.Bill_lblTotaalBedrag.Name = "Bill_lblTotaalBedrag";
            this.Bill_lblTotaalBedrag.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Bill_lblTotaalBedrag.Size = new System.Drawing.Size(76, 13);
            this.Bill_lblTotaalBedrag.TabIndex = 32;
            this.Bill_lblTotaalBedrag.Text = "Totaal bedrag:";
            this.Bill_lblTotaalBedrag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CP_imgLogo
            // 
            this.CP_imgLogo.BackColor = System.Drawing.SystemColors.Control;
            this.CP_imgLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CP_imgLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.CP_imgLogo.Image = global::Ui.Properties.Resources.Logo21;
            this.CP_imgLogo.Location = new System.Drawing.Point(0, 0);
            this.CP_imgLogo.Name = "CP_imgLogo";
            this.CP_imgLogo.Size = new System.Drawing.Size(462, 81);
            this.CP_imgLogo.TabIndex = 33;
            this.CP_imgLogo.TabStop = false;
            // 
            // Bill_lblAfrekenen
            // 
            this.Bill_lblAfrekenen.AutoSize = true;
            this.Bill_lblAfrekenen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Bill_lblAfrekenen.Location = new System.Drawing.Point(181, 61);
            this.Bill_lblAfrekenen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Bill_lblAfrekenen.Name = "Bill_lblAfrekenen";
            this.Bill_lblAfrekenen.Size = new System.Drawing.Size(107, 20);
            this.Bill_lblAfrekenen.TabIndex = 34;
            this.Bill_lblAfrekenen.Text = "AFREKENEN";
            // 
            // BillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 506);
            this.Controls.Add(this.Bill_lblAfrekenen);
            this.Controls.Add(this.CP_imgLogo);
            this.Controls.Add(this.Bill_btnBillOverview);
            this.Controls.Add(this.Bill_lblTableNumber);
            this.Controls.Add(this.Bill_lblTotaalBedrag);
            this.Controls.Add(this.Bill_lblBtwLinks);
            this.Controls.Add(this.Bill_lblBetaald);
            this.Controls.Add(this.Bill_lblBtw);
            this.Controls.Add(this.Bill_lblTotalPrice);
            this.Controls.Add(this.Bill_btnFooi);
            this.Controls.Add(this.Bill_pnlFooi);
            this.Controls.Add(this.Bill_pnlBetaalMethode);
            this.Controls.Add(this.Bill_btnKiesBetaalmethode);
            this.Controls.Add(this.Bill_lvBillOverview);
            this.Name = "BillForm";
            this.Text = "BillForm";
            this.Bill_pnlBetaalMethode.ResumeLayout(false);
            this.Bill_pnlBetaalMethode.PerformLayout();
            this.Bill_pnlFooi.ResumeLayout(false);
            this.Bill_pnlFooi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CP_imgLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Bill_lblTableNumber;
        private System.Windows.Forms.ListView Bill_lvBillOverview;
        private System.Windows.Forms.Button Bill_btnBillOverview;
        private System.Windows.Forms.Button Bill_btnPay;
        private System.Windows.Forms.RadioButton Bill_rbPaypal;
        private System.Windows.Forms.RadioButton Bill_rbMastercard;
        private System.Windows.Forms.RadioButton Bill_rbVisa;
        private System.Windows.Forms.RadioButton Bill_rbCash;
        private System.Windows.Forms.Button Bill_btnKiesBetaalmethode;
        private System.Windows.Forms.Panel Bill_pnlBetaalMethode;
        private System.Windows.Forms.Panel Bill_pnlFooi;
        private System.Windows.Forms.TextBox Bill_txbAanvullenTot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Bill_btnFooiPlus20;
        private System.Windows.Forms.Button Bill_btnFooiPlus10;
        private System.Windows.Forms.Button Bill_btnFooiPlus5;
        private System.Windows.Forms.Button Bill_btnPasAan;
        private System.Windows.Forms.Button Bill_btnFooi;
        private System.Windows.Forms.Button Bill_btnBetaalmethodeX;
        private System.Windows.Forms.Button Bill_btnFooiX;
        private System.Windows.Forms.Label Bill_lblTotalPrice;
        private System.Windows.Forms.Label Bill_lblBetaald;
        private System.Windows.Forms.Label Bill_lblBtw;
        private System.Windows.Forms.Label Bill_lblBtwLinks;
        private System.Windows.Forms.Label Bill_lblTotaalBedrag;
        private System.Windows.Forms.PictureBox CP_imgLogo;
        private System.Windows.Forms.Label Bill_lblAfrekenen;
    }
}