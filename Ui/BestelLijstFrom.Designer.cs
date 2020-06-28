namespace Ui
{
    partial class BestelLijstFrom
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
            this.CP_imgLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aantal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ingredients = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dishBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.backBtn = new System.Windows.Forms.Button();
            this.bestelBtn = new System.Windows.Forms.Button();
            this.Bill_GridDrinks = new System.Windows.Forms.DataGridView();
            this.alcoholicDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finishedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aantalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drinkBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.drinkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.verwijderBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CP_imgLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bill_GridDrinks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drinkBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drinkBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CP_imgLogo
            // 
            this.CP_imgLogo.BackColor = System.Drawing.SystemColors.Control;
            this.CP_imgLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CP_imgLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.CP_imgLogo.Image = global::Ui.Properties.Resources.Logo21;
            this.CP_imgLogo.Location = new System.Drawing.Point(0, 0);
            this.CP_imgLogo.Name = "CP_imgLogo";
            this.CP_imgLogo.Size = new System.Drawing.Size(944, 75);
            this.CP_imgLogo.TabIndex = 11;
            this.CP_imgLogo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(140, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "BESTELLIJST";
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.aantal,
            this.Name,
            this.Description,
            this.Ingredients,
            this.Price,
            this.Stock,
            this.Category});
            this.dataGridView.DataSource = this.dishBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(32, 146);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(845, 161);
            this.dataGridView.TabIndex = 13;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // aantal
            // 
            this.aantal.DataPropertyName = "aantal";
            this.aantal.HeaderText = "aantal";
            this.aantal.Name = "aantal";
            // 
            // Name
            // 
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Ingredients
            // 
            this.Ingredients.DataPropertyName = "Ingredients";
            this.Ingredients.HeaderText = "Ingredients";
            this.Ingredients.Name = "Ingredients";
            this.Ingredients.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Stock
            // 
            this.Stock.DataPropertyName = "Stock";
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            // 
            // Category
            // 
            this.Category.DataPropertyName = "Category";
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            // 
            // dishBindingSource
            // 
            this.dishBindingSource.DataSource = typeof(Model.Dish);
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(Model.Order);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(32, 538);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 14;
            this.backBtn.Text = "Terug";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // bestelBtn
            // 
            this.bestelBtn.Location = new System.Drawing.Point(857, 538);
            this.bestelBtn.Name = "bestelBtn";
            this.bestelBtn.Size = new System.Drawing.Size(75, 23);
            this.bestelBtn.TabIndex = 15;
            this.bestelBtn.Text = "Bestel";
            this.bestelBtn.UseVisualStyleBackColor = true;
            this.bestelBtn.Click += new System.EventHandler(this.bestelBtn_Click);
            // 
            // Bill_GridDrinks
            // 
            this.Bill_GridDrinks.AutoGenerateColumns = false;
            this.Bill_GridDrinks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Bill_GridDrinks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.alcoholicDataGridViewCheckBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.stockDataGridViewTextBoxColumn,
            this.finishedDataGridViewCheckBoxColumn,
            this.commentDataGridViewTextBoxColumn,
            this.aantalDataGridViewTextBoxColumn});
            this.Bill_GridDrinks.DataSource = this.drinkBindingSource1;
            this.Bill_GridDrinks.Location = new System.Drawing.Point(32, 359);
            this.Bill_GridDrinks.Name = "Bill_GridDrinks";
            this.Bill_GridDrinks.Size = new System.Drawing.Size(845, 164);
            this.Bill_GridDrinks.TabIndex = 16;
            this.Bill_GridDrinks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Bill_GridDrinks_CellContentClick);
            // 
            // alcoholicDataGridViewCheckBoxColumn
            // 
            this.alcoholicDataGridViewCheckBoxColumn.DataPropertyName = "Alcoholic";
            this.alcoholicDataGridViewCheckBoxColumn.HeaderText = "Alcoholic";
            this.alcoholicDataGridViewCheckBoxColumn.Name = "alcoholicDataGridViewCheckBoxColumn";
            this.alcoholicDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stockDataGridViewTextBoxColumn
            // 
            this.stockDataGridViewTextBoxColumn.DataPropertyName = "Stock";
            this.stockDataGridViewTextBoxColumn.HeaderText = "Stock";
            this.stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            // 
            // finishedDataGridViewCheckBoxColumn
            // 
            this.finishedDataGridViewCheckBoxColumn.DataPropertyName = "Finished";
            this.finishedDataGridViewCheckBoxColumn.HeaderText = "Finished";
            this.finishedDataGridViewCheckBoxColumn.Name = "finishedDataGridViewCheckBoxColumn";
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "Comment";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            // 
            // aantalDataGridViewTextBoxColumn
            // 
            this.aantalDataGridViewTextBoxColumn.DataPropertyName = "Aantal";
            this.aantalDataGridViewTextBoxColumn.HeaderText = "Aantal";
            this.aantalDataGridViewTextBoxColumn.Name = "aantalDataGridViewTextBoxColumn";
            // 
            // drinkBindingSource1
            // 
            this.drinkBindingSource1.DataSource = typeof(Model.Drink);
            // 
            // drinkBindingSource
            // 
            this.drinkBindingSource.DataSource = typeof(Model.Drink);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Gerechten:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 343);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Dranken:";
            // 
            // verwijderBtn
            // 
            this.verwijderBtn.Location = new System.Drawing.Point(746, 538);
            this.verwijderBtn.Name = "verwijderBtn";
            this.verwijderBtn.Size = new System.Drawing.Size(75, 23);
            this.verwijderBtn.TabIndex = 19;
            this.verwijderBtn.Text = "Verwijder bestelling";
            this.verwijderBtn.UseVisualStyleBackColor = true;
            this.verwijderBtn.Click += new System.EventHandler(this.verwijderBtn_Click);
            // 
            // BestelLijstFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 573);
            this.Controls.Add(this.verwijderBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Bill_GridDrinks);
            this.Controls.Add(this.bestelBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CP_imgLogo);
            this.Name = "BestelLijstFrom";
            this.Text = "BestelLijstFrom";
            this.Load += new System.EventHandler(this.BestelLijstFrom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CP_imgLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bill_GridDrinks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drinkBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drinkBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox CP_imgLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.BindingSource dishBindingSource;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button bestelBtn;
        private System.Windows.Forms.DataGridView Bill_GridDrinks;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource drinkBindingSource;
        private System.Windows.Forms.Button verwijderBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn aantal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ingredients;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewCheckBoxColumn alcoholicDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn finishedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aantalDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource drinkBindingSource1;
    }
}