namespace demo.Forms
{
    partial class AddCurrencyForm
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
            this.NameCurrencyTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FavoritesCheckBox = new System.Windows.Forms.CheckBox();
            this.AddCurrencyBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameCurrencyTb
            // 
            this.NameCurrencyTb.Location = new System.Drawing.Point(231, 37);
            this.NameCurrencyTb.Name = "NameCurrencyTb";
            this.NameCurrencyTb.Size = new System.Drawing.Size(144, 23);
            this.NameCurrencyTb.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название валюты";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Избранная валюта *";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(26, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 78);
            this.label3.TabIndex = 3;
            this.label3.Text = "* поставьте галочку, если хотите внести валюту в список избранных";
            // 
            // FavoritesCheckBox
            // 
            this.FavoritesCheckBox.AutoSize = true;
            this.FavoritesCheckBox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FavoritesCheckBox.Location = new System.Drawing.Point(231, 96);
            this.FavoritesCheckBox.Name = "FavoritesCheckBox";
            this.FavoritesCheckBox.Size = new System.Drawing.Size(97, 20);
            this.FavoritesCheckBox.TabIndex = 4;
            this.FavoritesCheckBox.Text = "избранное";
            this.FavoritesCheckBox.UseVisualStyleBackColor = true;
            // 
            // AddCurrencyBtn
            // 
            this.AddCurrencyBtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddCurrencyBtn.Location = new System.Drawing.Point(96, 183);
            this.AddCurrencyBtn.Name = "AddCurrencyBtn";
            this.AddCurrencyBtn.Size = new System.Drawing.Size(197, 30);
            this.AddCurrencyBtn.TabIndex = 5;
            this.AddCurrencyBtn.Text = "Добавить валюту";
            this.AddCurrencyBtn.UseVisualStyleBackColor = true;
            this.AddCurrencyBtn.Click += new System.EventHandler(this.AddCurrencyBtn_Click);
            // 
            // AddCurrencyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 239);
            this.Controls.Add(this.AddCurrencyBtn);
            this.Controls.Add(this.FavoritesCheckBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameCurrencyTb);
            this.Name = "AddCurrencyForm";
            this.Text = "Добавление валюты";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        public TextBox NameCurrencyTb;
        public CheckBox FavoritesCheckBox;
        public Button AddCurrencyBtn;
    }
}