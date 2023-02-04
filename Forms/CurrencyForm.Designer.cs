namespace demo.Forms
{
    partial class CurrencyForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.favoritesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.currencyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AddCurrencyBtn = new System.Windows.Forms.Button();
            this.EditCurrencyBtn = new System.Windows.Forms.Button();
            this.RemoveCurrencyBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.favoritesDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.currencyBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(459, 192);
            this.dataGridView1.TabIndex = 0;
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
            this.nameDataGridViewTextBoxColumn.HeaderText = "Название валюты";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // favoritesDataGridViewTextBoxColumn
            // 
            this.favoritesDataGridViewTextBoxColumn.DataPropertyName = "Favorites";
            this.favoritesDataGridViewTextBoxColumn.HeaderText = "Избранное";
            this.favoritesDataGridViewTextBoxColumn.Name = "favoritesDataGridViewTextBoxColumn";
            this.favoritesDataGridViewTextBoxColumn.ReadOnly = true;
            this.favoritesDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.favoritesDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // currencyBindingSource
            // 
            this.currencyBindingSource.DataSource = typeof(demo.Contexts.Currency);
            // 
            // AddCurrencyBtn
            // 
            this.AddCurrencyBtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddCurrencyBtn.Location = new System.Drawing.Point(505, 33);
            this.AddCurrencyBtn.Name = "AddCurrencyBtn";
            this.AddCurrencyBtn.Size = new System.Drawing.Size(150, 31);
            this.AddCurrencyBtn.TabIndex = 1;
            this.AddCurrencyBtn.Text = "Добавить";
            this.AddCurrencyBtn.UseVisualStyleBackColor = true;
            this.AddCurrencyBtn.Click += new System.EventHandler(this.AddCurrencyBtn_Click);
            // 
            // EditCurrencyBtn
            // 
            this.EditCurrencyBtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EditCurrencyBtn.Location = new System.Drawing.Point(505, 70);
            this.EditCurrencyBtn.Name = "EditCurrencyBtn";
            this.EditCurrencyBtn.Size = new System.Drawing.Size(150, 31);
            this.EditCurrencyBtn.TabIndex = 2;
            this.EditCurrencyBtn.Text = "Редактировать";
            this.EditCurrencyBtn.UseVisualStyleBackColor = true;
            this.EditCurrencyBtn.Click += new System.EventHandler(this.EditCurrencyBtn_Click);
            // 
            // RemoveCurrencyBtn
            // 
            this.RemoveCurrencyBtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RemoveCurrencyBtn.Location = new System.Drawing.Point(505, 107);
            this.RemoveCurrencyBtn.Name = "RemoveCurrencyBtn";
            this.RemoveCurrencyBtn.Size = new System.Drawing.Size(150, 31);
            this.RemoveCurrencyBtn.TabIndex = 3;
            this.RemoveCurrencyBtn.Text = "Удалить";
            this.RemoveCurrencyBtn.UseVisualStyleBackColor = true;
            this.RemoveCurrencyBtn.Click += new System.EventHandler(this.RemoveCurrencyBtn_Click);
            // 
            // CurrencyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 343);
            this.Controls.Add(this.RemoveCurrencyBtn);
            this.Controls.Add(this.EditCurrencyBtn);
            this.Controls.Add(this.AddCurrencyBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CurrencyForm";
            this.Text = "Валюты";
            this.Activated += new System.EventHandler(this.CurrencyForm_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private BindingSource currencyBindingSource;
        private Button AddCurrencyBtn;
        private Button EditCurrencyBtn;
        private Button RemoveCurrencyBtn;
        public DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn favoritesDataGridViewTextBoxColumn;
    }
}