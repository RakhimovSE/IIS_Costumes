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
            this.label1 = new System.Windows.Forms.Label();
            this.delButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mainGB = new System.Windows.Forms.GroupBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.mainDGV = new System.Windows.Forms.DataGridView();
            this.mainName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainSizeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainSizeNumeric = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainDailyPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainInStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Размеры костюмов";
            // 
            // delButton
            // 
            this.delButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.delButton.Location = new System.Drawing.Point(610, 156);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(94, 23);
            this.delButton.TabIndex = 33;
            this.delButton.Text = "Удалить";
            this.delButton.UseVisualStyleBackColor = true;
            this.delButton.Click += new System.EventHandler(this.delButton_Click);
            // 
            // editButton
            // 
            this.editButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editButton.Location = new System.Drawing.Point(610, 97);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(94, 23);
            this.editButton.TabIndex = 32;
            this.editButton.Text = "Редактировать";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.Location = new System.Drawing.Point(610, 69);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(94, 23);
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
            this.searchTB.Size = new System.Drawing.Size(592, 20);
            this.searchTB.TabIndex = 30;
            this.searchTB.TextChanged += new System.EventHandler(this.searchTB_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Поиск";
            // 
            // mainGB
            // 
            this.mainGB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainGB.Controls.Add(this.OKButton);
            this.mainGB.Controls.Add(this.cancelButton);
            this.mainGB.Location = new System.Drawing.Point(12, 69);
            this.mainGB.Margin = new System.Windows.Forms.Padding(2);
            this.mainGB.Name = "mainGB";
            this.mainGB.Padding = new System.Windows.Forms.Padding(2);
            this.mainGB.Size = new System.Drawing.Size(592, 299);
            this.mainGB.TabIndex = 34;
            this.mainGB.TabStop = false;
            this.mainGB.Text = "Карточка";
            // 
            // OKButton
            // 
            this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OKButton.Location = new System.Drawing.Point(447, 270);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(67, 23);
            this.OKButton.TabIndex = 11;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(520, 270);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(67, 23);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
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
            this.mainInStock});
            this.mainDGV.Location = new System.Drawing.Point(12, 69);
            this.mainDGV.Name = "mainDGV";
            this.mainDGV.ReadOnly = true;
            this.mainDGV.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mainDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.mainDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mainDGV.Size = new System.Drawing.Size(592, 298);
            this.mainDGV.TabIndex = 35;
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
            // mainInStock
            // 
            this.mainInStock.DataPropertyName = "in_stock";
            this.mainInStock.HeaderText = "В наличии";
            this.mainInStock.Name = "mainInStock";
            this.mainInStock.ReadOnly = true;
            this.mainInStock.Width = 60;
            // 
            // CostumeSizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 379);
            this.Controls.Add(this.mainDGV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.searchTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mainGB);
            this.Name = "CostumeSizeForm";
            this.Text = "Карнавальные костюмы - Размеры костюмов";
            this.Load += new System.EventHandler(this.CostumeSizeForm_Load);
            this.mainGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox searchTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox mainGB;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.DataGridView mainDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn mainName;
        private System.Windows.Forms.DataGridViewTextBoxColumn mainTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn mainSizeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn mainSizeNumeric;
        private System.Windows.Forms.DataGridViewTextBoxColumn mainDailyPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn mainInStock;
    }
}