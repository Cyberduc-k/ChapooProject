namespace Ui
{
    partial class LoginForm
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
            this.Login_btnInloggen = new System.Windows.Forms.Button();
            this.Login_Logo = new System.Windows.Forms.PictureBox();
            this.Login_btnAnnuleren = new System.Windows.Forms.Button();
            this.Login_textBoxNummer = new System.Windows.Forms.TextBox();
            this.Login_textBoxWachtwoord = new System.Windows.Forms.TextBox();
            this.Login_lblNummer = new System.Windows.Forms.Label();
            this.Login_lblWachtwoord = new System.Windows.Forms.Label();
            this.Login_lblIncorrect = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Login_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Login_btnInloggen
            // 
            this.Login_btnInloggen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.Login_btnInloggen.Cursor = System.Windows.Forms.Cursors.Default;
            this.Login_btnInloggen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_btnInloggen.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_btnInloggen.ForeColor = System.Drawing.Color.White;
            this.Login_btnInloggen.Location = new System.Drawing.Point(1031, 777);
            this.Login_btnInloggen.Margin = new System.Windows.Forms.Padding(0);
            this.Login_btnInloggen.Name = "Login_btnInloggen";
            this.Login_btnInloggen.Size = new System.Drawing.Size(499, 87);
            this.Login_btnInloggen.TabIndex = 1;
            this.Login_btnInloggen.Text = "Inloggen";
            this.Login_btnInloggen.UseVisualStyleBackColor = false;
            this.Login_btnInloggen.Click += new System.EventHandler(this.Login_btnInloggen_Click);
            // 
            // Login_Logo
            // 
            this.Login_Logo.Image = global::Ui.Properties.Resources.Logo_Login;
            this.Login_Logo.Location = new System.Drawing.Point(952, 351);
            this.Login_Logo.Margin = new System.Windows.Forms.Padding(0);
            this.Login_Logo.Name = "Login_Logo";
            this.Login_Logo.Size = new System.Drawing.Size(656, 356);
            this.Login_Logo.TabIndex = 0;
            this.Login_Logo.TabStop = false;
            // 
            // Login_btnAnnuleren
            // 
            this.Login_btnAnnuleren.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.Login_btnAnnuleren.Cursor = System.Windows.Forms.Cursors.Default;
            this.Login_btnAnnuleren.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_btnAnnuleren.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_btnAnnuleren.ForeColor = System.Drawing.Color.White;
            this.Login_btnAnnuleren.Location = new System.Drawing.Point(1031, 1098);
            this.Login_btnAnnuleren.Margin = new System.Windows.Forms.Padding(0);
            this.Login_btnAnnuleren.Name = "Login_btnAnnuleren";
            this.Login_btnAnnuleren.Size = new System.Drawing.Size(499, 87);
            this.Login_btnAnnuleren.TabIndex = 2;
            this.Login_btnAnnuleren.Text = "Annuleren";
            this.Login_btnAnnuleren.UseVisualStyleBackColor = false;
            this.Login_btnAnnuleren.Visible = false;
            this.Login_btnAnnuleren.Click += new System.EventHandler(this.Login_btnAnnuleren_Click);
            // 
            // Login_textBoxNummer
            // 
            this.Login_textBoxNummer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Login_textBoxNummer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Login_textBoxNummer.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_textBoxNummer.ForeColor = System.Drawing.Color.Black;
            this.Login_textBoxNummer.Location = new System.Drawing.Point(1031, 647);
            this.Login_textBoxNummer.Margin = new System.Windows.Forms.Padding(0);
            this.Login_textBoxNummer.Name = "Login_textBoxNummer";
            this.Login_textBoxNummer.Size = new System.Drawing.Size(499, 68);
            this.Login_textBoxNummer.TabIndex = 3;
            this.Login_textBoxNummer.Visible = false;
            this.Login_textBoxNummer.WordWrap = false;
            // 
            // Login_textBoxWachtwoord
            // 
            this.Login_textBoxWachtwoord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Login_textBoxWachtwoord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Login_textBoxWachtwoord.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_textBoxWachtwoord.ForeColor = System.Drawing.Color.Black;
            this.Login_textBoxWachtwoord.Location = new System.Drawing.Point(1031, 801);
            this.Login_textBoxWachtwoord.Margin = new System.Windows.Forms.Padding(0);
            this.Login_textBoxWachtwoord.Name = "Login_textBoxWachtwoord";
            this.Login_textBoxWachtwoord.Size = new System.Drawing.Size(499, 68);
            this.Login_textBoxWachtwoord.TabIndex = 4;
            this.Login_textBoxWachtwoord.UseSystemPasswordChar = true;
            this.Login_textBoxWachtwoord.Visible = false;
            this.Login_textBoxWachtwoord.WordWrap = false;
            // 
            // Login_lblNummer
            // 
            this.Login_lblNummer.AutoSize = true;
            this.Login_lblNummer.BackColor = System.Drawing.Color.Transparent;
            this.Login_lblNummer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_lblNummer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_lblNummer.ForeColor = System.Drawing.Color.Black;
            this.Login_lblNummer.Location = new System.Drawing.Point(1031, 604);
            this.Login_lblNummer.Margin = new System.Windows.Forms.Padding(0);
            this.Login_lblNummer.Name = "Login_lblNummer";
            this.Login_lblNummer.Size = new System.Drawing.Size(312, 39);
            this.Login_lblNummer.TabIndex = 5;
            this.Login_lblNummer.Text = "Personeelsnummer";
            this.Login_lblNummer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Login_lblNummer.Visible = false;
            // 
            // Login_lblWachtwoord
            // 
            this.Login_lblWachtwoord.AutoSize = true;
            this.Login_lblWachtwoord.BackColor = System.Drawing.Color.Transparent;
            this.Login_lblWachtwoord.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_lblWachtwoord.Location = new System.Drawing.Point(1031, 758);
            this.Login_lblWachtwoord.Margin = new System.Windows.Forms.Padding(0);
            this.Login_lblWachtwoord.Name = "Login_lblWachtwoord";
            this.Login_lblWachtwoord.Size = new System.Drawing.Size(206, 39);
            this.Login_lblWachtwoord.TabIndex = 6;
            this.Login_lblWachtwoord.Text = "Wachtwoord";
            this.Login_lblWachtwoord.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Login_lblWachtwoord.Visible = false;
            // 
            // Login_lblIncorrect
            // 
            this.Login_lblIncorrect.AutoSize = true;
            this.Login_lblIncorrect.BackColor = System.Drawing.Color.Transparent;
            this.Login_lblIncorrect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_lblIncorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_lblIncorrect.ForeColor = System.Drawing.Color.Red;
            this.Login_lblIncorrect.Location = new System.Drawing.Point(1025, 548);
            this.Login_lblIncorrect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Login_lblIncorrect.Name = "Login_lblIncorrect";
            this.Login_lblIncorrect.Size = new System.Drawing.Size(452, 29);
            this.Login_lblIncorrect.TabIndex = 7;
            this.Login_lblIncorrect.Text = "Incorrecte gegevens! Probeer opnieuw.";
            this.Login_lblIncorrect.Visible = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(2539, 1281);
            this.Controls.Add(this.Login_lblIncorrect);
            this.Controls.Add(this.Login_lblWachtwoord);
            this.Controls.Add(this.Login_lblNummer);
            this.Controls.Add(this.Login_textBoxWachtwoord);
            this.Controls.Add(this.Login_textBoxNummer);
            this.Controls.Add(this.Login_btnAnnuleren);
            this.Controls.Add(this.Login_btnInloggen);
            this.Controls.Add(this.Login_Logo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LoginForm";
            this.Text = "Inloggen";
            ((System.ComponentModel.ISupportInitialize)(this.Login_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Login_Logo;
        private System.Windows.Forms.Button Login_btnInloggen;
        private System.Windows.Forms.Button Login_btnAnnuleren;
        private System.Windows.Forms.TextBox Login_textBoxNummer;
        private System.Windows.Forms.TextBox Login_textBoxWachtwoord;
        private System.Windows.Forms.Label Login_lblNummer;
        private System.Windows.Forms.Label Login_lblWachtwoord;
        private System.Windows.Forms.Label Login_lblIncorrect;
    }
}