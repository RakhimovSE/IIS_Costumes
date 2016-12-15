namespace IIS_Costumes
{
    partial class CostumeSizeForm
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
            this.headerLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.mainGB = new System.Windows.Forms.GroupBox();
            this.selectCostumeButton = new System.Windows.Forms.Button();
            this.amountLabel = new System.Windows.Forms.Label();
            this.amountTB = new System.Windows.Forms.TextBox();
            this.sizeCB = new System.Windows.Forms.ComboBox();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.costumeCB = new System.Windows.Forms.ComboBox();
            this.costumeLabel = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.mainDGV = new System.Windows.Forms.DataGridView();
            this.mainName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainSizeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainSizeNumeric = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainDailyPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainInStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addOrderButton = new System.Windows.Forms.Button();
            this.mainGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.headerLabel.Location = new System.Drawing.Point(12, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(124, 13);
            this.headerLabel.TabIndex = 28;
            this.headerLabel.Text = "Размеры костюмов";
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.Location = new System.Drawing.Point(678, 185);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(107, 23);
            this.deleteButton.TabIndex = 33;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editButton.Location = new System.Drawing.Point(678, 126);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(107, 23);
            this.editButton.TabIndex = 32;
            this.editButton.Text = "Редактировать";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.Location = new System.Drawing.Point(678, 98);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(107, 23);
            this.addButton.TabIndex = 31;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // searchTB
            // 
            this.searchTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTB.Location = new System.Drawing.Point(12, 43);
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(660, 20);
            this.searchTB.TabIndex = 30;
            this.searchTB.TextChanged += new System.EventHandler(this.searchTB_TextChanged);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(12, 26);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(39, 13);
            this.searchLabel.TabIndex = 29;
            this.searchLabel.Text = "Поиск";
            // 
            // mainGB
            // 
            this.mainGB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainGB.Controls.Add(this.selectCostumeButton);
            this.mainGB.Controls.Add(this.amountLabel);
            this.mainGB.Controls.Add(this.amountTB);
            this.mainGB.Controls.Add(this.sizeCB);
            this.mainGB.Controls.Add(this.sizeLabel);
            this.mainGB.Controls.Add(this.costumeCB);
            this.mainGB.Controls.Add(this.costumeLabel);
            this.mainGB.Controls.Add(this.OKButton);
            this.mainGB.Controls.Add(this.cancelButton);
            this.mainGB.Location = new System.Drawing.Point(12, 69);
            this.mainGB.Margin = new System.Windows.Forms.Padding(2);
            this.mainGB.Name = "mainGB";
            this.mainGB.Padding = new System.Windows.Forms.Padding(2);
            this.mainGB.Size = new System.Drawing.Size(660, 116);
            this.mainGB.TabIndex = 34;
            this.mainGB.TabStop = false;
            this.mainGB.Text = "mainGB";
            // 
            // selectCostumeButton
            // 
            this.selectCostumeButton.Location = new System.Drawing.Point(258, 36);
            this.selectCostumeButton.Name = "selectCostumeButton";
            this.selectCostumeButton.Size = new System.Drawing.Size(24, 23);
            this.selectCostumeButton.TabIndex = 18;
            this.selectCostumeButton.Text = "...";
            this.selectCostumeButton.UseVisualStyleBackColor = true;
            this.selectCostumeButton.Click += new System.EventHandler(this.selectCostumeButton_Click);
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(419, 17);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(66, 13);
            this.amountLabel.TabIndex = 17;
            this.amountLabel.Text = "Количество";
            // 
            // amountTB
            // 
            this.amountTB.Location = new System.Drawing.Point(422, 37);
            this.amountTB.Name = "amountTB";
            this.amountTB.Size = new System.Drawing.Size(43, 20);
            this.amountTB.TabIndex = 16;
            // 
            // sizeCB
            // 
            this.sizeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sizeCB.FormattingEnabled = true;
            this.sizeCB.Location = new System.Drawing.Point(314, 37);
            this.sizeCB.Name = "sizeCB";
            this.sizeCB.Size = new System.Drawing.Size(84, 21);
            this.sizeCB.TabIndex = 15;
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Location = new System.Drawing.Point(314, 17);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(46, 13);
            this.sizeLabel.TabIndex = 14;
            this.sizeLabel.Text = "Размер";
            // 
            // costumeCB
            // 
            this.costumeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.costumeCB.FormattingEnabled = true;
            this.costumeCB.Location = new System.Drawing.Point(6, 37);
            this.costumeCB.Name = "costumeCB";
            this.costumeCB.Size = new System.Drawing.Size(251, 21);
            this.costumeCB.TabIndex = 13;
            // 
            // costumeLabel
            // 
            this.costumeLabel.AutoSize = true;
            this.costumeLabel.Location = new System.Drawing.Point(6, 17);
            this.costumeLabel.Name = "costumeLabel";
            this.costumeLabel.Size = new System.Drawing.Size(47, 13);
            this.costumeLabel.TabIndex = 12;
            this.costumeLabel.Text = "Костюм";
            // 
            // OKButton
            // 
            this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OKButton.Location = new System.Drawing.Point(515, 87);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(67, 23);
            this.OKButton.TabIndex = 11;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(588, 87);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(67, 23);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // mainDGV
            // 
            this.mainDGV.AllowUserToAddRows = false;
            this.mainDGV.AllowUserToResizeRows = false;
            this.mainDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mainName,
            this.mainTypeName,
            this.mainSizeName,
            this.mainSizeNumeric,
            this.mainDailyPrice,
            this.mainAmount,
            this.mainInStock});
            this.mainDGV.Location = new System.Drawing.Point(12, 69);
            this.mainDGV.Name = "mainDGV";
            this.mainDGV.ReadOnly = true;
            this.mainDGV.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mainDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.mainDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mainDGV.Size = new System.Drawing.Size(660, 298);
            this.mainDGV.TabIndex = 35;
            this.mainDGV.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.mainDGV_CellMouseDoubleClick);
            // 
            // mainName
            // 
            this.mainName.DataPropertyName = "costume_name";
            this.mainName.HeaderText = "Костюм";
            this.mainName.Name = "mainName";
            this.mainName.ReadOnly = true;
            this.mainName.Width = 160;
            // 
            // mainTypeName
            // 
            this.mainTypeName.DataPropertyName = "costume_type_name";
            this.mainTypeName.HeaderText = "Тип";
            this.mainTypeName.Name = "mainTypeName";
            this.mainTypeName.ReadOnly = true;
            this.mainTypeName.Width = 130;
            // 
            // mainSizeName
            // 
            this.mainSizeName.DataPropertyName = "size_name";
            this.mainSizeName.HeaderText = "Размер";
            this.mainSizeName.Name = "mainSizeName";
            this.mainSizeName.ReadOnly = true;
            this.mainSizeName.Width = 60;
            // 
            // mainSizeNumeric
            // 
            this.mainSizeNumeric.DataPropertyName = "size_numeric";
            this.mainSizeNumeric.HeaderText = "Размер (см)";
            this.mainSizeNumeric.Name = "mainSizeNumeric";
            this.mainSizeNumeric.ReadOnly = true;
            this.mainSizeNumeric.Width = 60;
            // 
            // mainDailyPrice
            // 
            this.mainDailyPrice.DataPropertyName = "costume_daily_price";
            this.mainDailyPrice.HeaderText = "Цена/ день";
            this.mainDailyPrice.Name = "mainDailyPrice";
            this.mainDailyPrice.ReadOnly = true;
            this.mainDailyPrice.Width = 60;
            // 
            // mainAmount
            // 
            this.mainAmount.DataPropertyName = "amount";
            this.mainAmount.HeaderText = "Кол-во";
            this.mainAmount.Name = "mainAmount";
            this.mainAmount.ReadOnly = true;
            this.mainAmount.Width = 60;
            // 
            // mainInStock
            // 
            this.mainInStock.DataPropertyName = "in_stock";
            this.mainInStock.HeaderText = "В наличии";
            this.mainInStock.Name = "mainInStock";
            this.mainInStock.ReadOnly = true;
            this.mainInStock.Width = 60;
            // 
            // addOrderButton
            // 
            this.addOrderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addOrderButton.Location = new System.Drawing.Point(678, 69);
            this.addOrderButton.Name = "addOrderButton";
            this.addOrderButton.Size = new System.Drawing.Size(107, 23);
            this.addOrderButton.TabIndex = 36;
            this.addOrderButton.Text = "Добавить в заказ";
            this.addOrderButton.UseVisualStyleBackColor = true;
            this.addOrderButton.Click += new System.EventHandler(this.addOrderButton_Click);
            // 
            // CostumeSizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 379);
            this.Controls.Add(this.addOrderButton);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.searchTB);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.mainDGV);
            this.Controls.Add(this.mainGB);
            this.Name = "CostumeSizeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Карнавальные костюмы - Размеры костюмов";
            this.Load += new System.EventHandler(this.CostumeSizeForm_Load);
            this.mainGB.ResumeLayout(false);
            this.mainGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox searchTB;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.GroupBox mainGB;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.DataGridView mainDGV;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.TextBox amountTB;
        private System.Windows.Forms.ComboBox sizeCB;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.Label costumeLabel;
        private System.Windows.Forms.Button selectCostumeButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn mainName;
        private System.Windows.Forms.DataGridViewTextBoxColumn mainTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn mainSizeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn mainSizeNumeric;
        private System.Windows.Forms.DataGridViewTextBoxColumn mainDailyPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn mainAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn mainInStock;
        public System.Windows.Forms.ComboBox costumeCB;
        private System.Windows.Forms.Button addOrderButton;
    }
}