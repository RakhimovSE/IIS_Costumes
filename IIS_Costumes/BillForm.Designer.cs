namespace IIS_Costumes
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
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.headerLabel = new System.Windows.Forms.Label();
            this.mainDGV = new System.Windows.Forms.DataGridView();
            this.mainPaid = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.mainDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainCostumeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainBillTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainClientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainClientTelephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainEmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainPriceAbs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paidButton = new System.Windows.Forms.Button();
            this.notPaidButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.Location = new System.Drawing.Point(1025, 184);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(110, 23);
            this.deleteButton.TabIndex = 19;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Visible = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editButton.Location = new System.Drawing.Point(1025, 126);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(110, 23);
            this.editButton.TabIndex = 17;
            this.editButton.Text = "Редактировать";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Visible = false;
            // 
            // searchTB
            // 
            this.searchTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTB.Location = new System.Drawing.Point(12, 42);
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(1006, 20);
            this.searchTB.TabIndex = 14;
            this.searchTB.TextChanged += new System.EventHandler(this.searchTB_TextChanged);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(12, 26);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(39, 13);
            this.searchLabel.TabIndex = 12;
            this.searchLabel.Text = "Поиск";
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.headerLabel.Location = new System.Drawing.Point(12, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(41, 13);
            this.headerLabel.TabIndex = 11;
            this.headerLabel.Text = "Счета";
            // 
            // mainDGV
            // 
            this.mainDGV.AllowUserToAddRows = false;
            this.mainDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mainPaid,
            this.mainDate,
            this.mainCostumeName,
            this.mainBillTypeName,
            this.mainClientName,
            this.mainClientTelephone,
            this.mainEmployeeName,
            this.mainType,
            this.mainPriceAbs});
            this.mainDGV.Location = new System.Drawing.Point(12, 68);
            this.mainDGV.Name = "mainDGV";
            this.mainDGV.ReadOnly = true;
            this.mainDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mainDGV.Size = new System.Drawing.Size(1006, 330);
            this.mainDGV.TabIndex = 20;
            // 
            // mainPaid
            // 
            this.mainPaid.DataPropertyName = "paid";
            this.mainPaid.HeaderText = "Опл.";
            this.mainPaid.Name = "mainPaid";
            this.mainPaid.ReadOnly = true;
            this.mainPaid.Width = 40;
            // 
            // mainDate
            // 
            this.mainDate.DataPropertyName = "date";
            this.mainDate.HeaderText = "Дата";
            this.mainDate.Name = "mainDate";
            this.mainDate.ReadOnly = true;
            this.mainDate.Width = 70;
            // 
            // mainCostumeName
            // 
            this.mainCostumeName.DataPropertyName = "costume_name";
            this.mainCostumeName.HeaderText = "Костюм";
            this.mainCostumeName.Name = "mainCostumeName";
            this.mainCostumeName.ReadOnly = true;
            this.mainCostumeName.Width = 130;
            // 
            // mainBillTypeName
            // 
            this.mainBillTypeName.DataPropertyName = "bill_type_name";
            this.mainBillTypeName.HeaderText = "Тип счета";
            this.mainBillTypeName.Name = "mainBillTypeName";
            this.mainBillTypeName.ReadOnly = true;
            this.mainBillTypeName.Width = 180;
            // 
            // mainClientName
            // 
            this.mainClientName.DataPropertyName = "client_name";
            this.mainClientName.HeaderText = "Клиент";
            this.mainClientName.Name = "mainClientName";
            this.mainClientName.ReadOnly = true;
            this.mainClientName.Width = 150;
            // 
            // mainClientTelephone
            // 
            this.mainClientTelephone.DataPropertyName = "client_telephone";
            this.mainClientTelephone.HeaderText = "Телефон";
            this.mainClientTelephone.Name = "mainClientTelephone";
            this.mainClientTelephone.ReadOnly = true;
            // 
            // mainEmployeeName
            // 
            this.mainEmployeeName.DataPropertyName = "employee_name";
            this.mainEmployeeName.HeaderText = "Сотрудник";
            this.mainEmployeeName.Name = "mainEmployeeName";
            this.mainEmployeeName.ReadOnly = true;
            this.mainEmployeeName.Width = 140;
            // 
            // mainType
            // 
            this.mainType.DataPropertyName = "type";
            this.mainType.HeaderText = "Дт/Кт";
            this.mainType.Name = "mainType";
            this.mainType.ReadOnly = true;
            this.mainType.Width = 70;
            // 
            // mainPriceAbs
            // 
            this.mainPriceAbs.DataPropertyName = "price_abs";
            this.mainPriceAbs.HeaderText = "Сумма";
            this.mainPriceAbs.Name = "mainPriceAbs";
            this.mainPriceAbs.ReadOnly = true;
            this.mainPriceAbs.Width = 60;
            // 
            // paidButton
            // 
            this.paidButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.paidButton.Location = new System.Drawing.Point(1025, 68);
            this.paidButton.Name = "paidButton";
            this.paidButton.Size = new System.Drawing.Size(110, 23);
            this.paidButton.TabIndex = 21;
            this.paidButton.Text = "Оплачено";
            this.paidButton.UseVisualStyleBackColor = true;
            this.paidButton.Click += new System.EventHandler(this.paidButton_Click);
            // 
            // notPaidButton
            // 
            this.notPaidButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.notPaidButton.Location = new System.Drawing.Point(1025, 97);
            this.notPaidButton.Name = "notPaidButton";
            this.notPaidButton.Size = new System.Drawing.Size(110, 23);
            this.notPaidButton.TabIndex = 22;
            this.notPaidButton.Text = "Не оплачено";
            this.notPaidButton.UseVisualStyleBackColor = true;
            this.notPaidButton.Click += new System.EventHandler(this.notPaidButton_Click);
            // 
            // BillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 410);
            this.Controls.Add(this.notPaidButton);
            this.Controls.Add(this.paidButton);
            this.Controls.Add(this.mainDGV);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.searchTB);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.headerLabel);
            this.Name = "BillForm";
            this.Text = "Карнавальные костюмы - Счета";
            this.Load += new System.EventHandler(this.BillForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.TextBox searchTB;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.DataGridView mainDGV;
        private System.Windows.Forms.DataGridViewCheckBoxColumn mainPaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn mainDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn mainCostumeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn mainBillTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn mainClientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn mainClientTelephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn mainEmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn mainType;
        private System.Windows.Forms.DataGridViewTextBoxColumn mainPriceAbs;
        private System.Windows.Forms.Button paidButton;
        private System.Windows.Forms.Button notPaidButton;
    }
}