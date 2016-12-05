﻿namespace IIS_Costumes
{
    partial class CostumeForm
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
            this.mainDGV = new System.Windows.Forms.DataGridView();
            this.delButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mainGB = new System.Windows.Forms.GroupBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.mainName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainCostumeType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daily_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.priceTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.daily_priceTB = new System.Windows.Forms.TextBox();
            this.typeButton = new System.Windows.Forms.Button();
            this.typeCB = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.mainDGV)).BeginInit();
            this.mainGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Костюмы";
            // 
            // mainDGV
            // 
            this.mainDGV.AllowUserToAddRows = false;
            this.mainDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mainName,
            this.mainCostumeType,
            this.mainPrice,
            this.daily_price});
            this.mainDGV.Location = new System.Drawing.Point(16, 85);
            this.mainDGV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mainDGV.Name = "mainDGV";
            this.mainDGV.ReadOnly = true;
            this.mainDGV.Size = new System.Drawing.Size(668, 398);
            this.mainDGV.TabIndex = 27;
            // 
            // delButton
            // 
            this.delButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.delButton.Location = new System.Drawing.Point(692, 192);
            this.delButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(125, 28);
            this.delButton.TabIndex = 25;
            this.delButton.Text = "Удалить";
            this.delButton.UseVisualStyleBackColor = true;
            this.delButton.Click += new System.EventHandler(this.delButton_Click);
            // 
            // editButton
            // 
            this.editButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editButton.Location = new System.Drawing.Point(692, 119);
            this.editButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(125, 28);
            this.editButton.TabIndex = 24;
            this.editButton.Text = "Редактировать";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.Location = new System.Drawing.Point(692, 85);
            this.addButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(125, 28);
            this.addButton.TabIndex = 23;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // searchTB
            // 
            this.searchTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTB.Location = new System.Drawing.Point(16, 53);
            this.searchTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(667, 22);
            this.searchTB.TabIndex = 22;
            this.searchTB.TextChanged += new System.EventHandler(this.searchTB_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Поиск";
            // 
            // mainGB
            // 
            this.mainGB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainGB.Controls.Add(this.typeButton);
            this.mainGB.Controls.Add(this.typeCB);
            this.mainGB.Controls.Add(this.label6);
            this.mainGB.Controls.Add(this.daily_priceTB);
            this.mainGB.Controls.Add(this.label5);
            this.mainGB.Controls.Add(this.priceTB);
            this.mainGB.Controls.Add(this.label4);
            this.mainGB.Controls.Add(this.label3);
            this.mainGB.Controls.Add(this.nameTB);
            this.mainGB.Controls.Add(this.OKButton);
            this.mainGB.Controls.Add(this.cancelButton);
            this.mainGB.Location = new System.Drawing.Point(16, 85);
            this.mainGB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainGB.Name = "mainGB";
            this.mainGB.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainGB.Size = new System.Drawing.Size(668, 398);
            this.mainGB.TabIndex = 26;
            this.mainGB.TabStop = false;
            this.mainGB.Text = "Карточка";
            // 
            // OKButton
            // 
            this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OKButton.Location = new System.Drawing.Point(475, 362);
            this.OKButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(89, 28);
            this.OKButton.TabIndex = 11;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(572, 362);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(89, 28);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // mainName
            // 
            this.mainName.DataPropertyName = "name";
            this.mainName.HeaderText = "Название";
            this.mainName.Name = "mainName";
            this.mainName.ReadOnly = true;
            this.mainName.Width = 200;
            // 
            // mainCostumeType
            // 
            this.mainCostumeType.DataPropertyName = "costume_type_name";
            this.mainCostumeType.HeaderText = "Тип";
            this.mainCostumeType.Name = "mainCostumeType";
            this.mainCostumeType.ReadOnly = true;
            this.mainCostumeType.Width = 150;
            // 
            // mainPrice
            // 
            this.mainPrice.DataPropertyName = "price";
            this.mainPrice.HeaderText = "Цена";
            this.mainPrice.Name = "mainPrice";
            this.mainPrice.ReadOnly = true;
            this.mainPrice.Width = 50;
            // 
            // daily_price
            // 
            this.daily_price.DataPropertyName = "daily_price";
            this.daily_price.HeaderText = "Стоимость аренды";
            this.daily_price.Name = "daily_price";
            this.daily_price.ReadOnly = true;
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(6, 54);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(277, 22);
            this.nameTB.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Название";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(301, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Тип костюма";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Цена";
            // 
            // priceTB
            // 
            this.priceTB.Location = new System.Drawing.Point(6, 118);
            this.priceTB.Name = "priceTB";
            this.priceTB.Size = new System.Drawing.Size(92, 22);
            this.priceTB.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(120, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Аренда";
            // 
            // daily_priceTB
            // 
            this.daily_priceTB.Location = new System.Drawing.Point(123, 118);
            this.daily_priceTB.Name = "daily_priceTB";
            this.daily_priceTB.Size = new System.Drawing.Size(112, 22);
            this.daily_priceTB.TabIndex = 18;
            // 
            // typeButton
            // 
            this.typeButton.Location = new System.Drawing.Point(532, 50);
            this.typeButton.Margin = new System.Windows.Forms.Padding(4);
            this.typeButton.Name = "typeButton";
            this.typeButton.Size = new System.Drawing.Size(32, 28);
            this.typeButton.TabIndex = 25;
            this.typeButton.Text = "...";
            this.typeButton.UseVisualStyleBackColor = true;
            // 
            // typeCB
            // 
            this.typeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeCB.FormattingEnabled = true;
            this.typeCB.Location = new System.Drawing.Point(304, 52);
            this.typeCB.Margin = new System.Windows.Forms.Padding(4);
            this.typeCB.Name = "typeCB";
            this.typeCB.Size = new System.Drawing.Size(224, 24);
            this.typeCB.TabIndex = 24;
            // 
            // CostumeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 533);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.searchTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mainGB);
            this.Controls.Add(this.mainDGV);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CostumeForm";
            this.Text = "Карнавальные костюмы - Костюмы";
            this.Load += new System.EventHandler(this.CostumeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainDGV)).EndInit();
            this.mainGB.ResumeLayout(false);
            this.mainGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView mainDGV;
        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox searchTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox mainGB;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn mainName;
        private System.Windows.Forms.DataGridViewTextBoxColumn mainCostumeType;
        private System.Windows.Forms.DataGridViewTextBoxColumn mainPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn daily_price;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox daily_priceTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox priceTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.Button typeButton;
        public System.Windows.Forms.ComboBox typeCB;
    }
}