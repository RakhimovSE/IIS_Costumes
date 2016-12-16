namespace IIS_Costumes
{
    partial class JournalForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            this.printButton = new System.Windows.Forms.Button();
            this.totalRentLabel = new System.Windows.Forms.Label();
            this.employeeLabel = new System.Windows.Forms.Label();
            this.employeeTB = new System.Windows.Forms.TextBox();
            this.costumeDGV = new System.Windows.Forms.DataGridView();
            this.costumeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costumeVendor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costumeShedule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costumeSizeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costumePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costumeDailyPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costumeRentPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cancelButton = new System.Windows.Forms.Button();
            this.orderGB = new System.Windows.Forms.GroupBox();
            this.costumeRemoveButton = new System.Windows.Forms.Button();
            this.costumeAddButton = new System.Windows.Forms.Button();
            this.totalDepositLabel = new System.Windows.Forms.Label();
            this.clientButton = new System.Windows.Forms.Button();
            this.costumeLabel = new System.Windows.Forms.Label();
            this.clientCB = new System.Windows.Forms.ComboBox();
            this.clientLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.dateDTP = new System.Windows.Forms.DateTimePicker();
            this.OKButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.takeButton = new System.Windows.Forms.Button();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.mainName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainVendor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainSizeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainClientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainClientTelephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainReturndateShedule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issueButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.headerLabel = new System.Windows.Forms.Label();
            this.mainDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.costumeDGV)).BeginInit();
            this.orderGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // printButton
            // 
            this.printButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.printButton.Location = new System.Drawing.Point(721, 409);
            this.printButton.Margin = new System.Windows.Forms.Padding(4);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(89, 28);
            this.printButton.TabIndex = 33;
            this.printButton.Text = "Печать";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // totalRentLabel
            // 
            this.totalRentLabel.AutoSize = true;
            this.totalRentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalRentLabel.Location = new System.Drawing.Point(11, 414);
            this.totalRentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalRentLabel.Name = "totalRentLabel";
            this.totalRentLabel.Size = new System.Drawing.Size(165, 17);
            this.totalRentLabel.TabIndex = 32;
            this.totalRentLabel.Text = "Итого аренда: 0 руб.";
            // 
            // employeeLabel
            // 
            this.employeeLabel.AutoSize = true;
            this.employeeLabel.Location = new System.Drawing.Point(256, 18);
            this.employeeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.employeeLabel.Name = "employeeLabel";
            this.employeeLabel.Size = new System.Drawing.Size(74, 17);
            this.employeeLabel.TabIndex = 31;
            this.employeeLabel.Text = "Оператор";
            // 
            // employeeTB
            // 
            this.employeeTB.Location = new System.Drawing.Point(256, 38);
            this.employeeTB.Margin = new System.Windows.Forms.Padding(4);
            this.employeeTB.Name = "employeeTB";
            this.employeeTB.ReadOnly = true;
            this.employeeTB.Size = new System.Drawing.Size(304, 22);
            this.employeeTB.TabIndex = 30;
            // 
            // costumeDGV
            // 
            this.costumeDGV.AllowUserToAddRows = false;
            this.costumeDGV.AllowUserToResizeRows = false;
            this.costumeDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.costumeDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.costumeDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.costumeName,
            this.costumeVendor,
            this.costumeShedule,
            this.costumeSizeName,
            this.costumePrice,
            this.costumeDailyPrice,
            this.costumeRentPrice});
            this.costumeDGV.Location = new System.Drawing.Point(15, 91);
            this.costumeDGV.Margin = new System.Windows.Forms.Padding(4);
            this.costumeDGV.Name = "costumeDGV";
            this.costumeDGV.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.costumeDGV.RowHeadersVisible = false;
            this.costumeDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.costumeDGV.Size = new System.Drawing.Size(893, 311);
            this.costumeDGV.TabIndex = 29;
            // 
            // costumeName
            // 
            this.costumeName.DataPropertyName = "costume_name";
            this.costumeName.HeaderText = "Название";
            this.costumeName.Name = "costumeName";
            this.costumeName.ReadOnly = true;
            this.costumeName.Width = 200;
            // 
            // costumeVendor
            // 
            this.costumeVendor.DataPropertyName = "vendor";
            dataGridViewCellStyle37.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle37.ForeColor = System.Drawing.Color.Green;
            dataGridViewCellStyle37.SelectionForeColor = System.Drawing.Color.Green;
            this.costumeVendor.DefaultCellStyle = dataGridViewCellStyle37;
            this.costumeVendor.HeaderText = "Артикул";
            this.costumeVendor.Name = "costumeVendor";
            this.costumeVendor.Width = 70;
            // 
            // costumeShedule
            // 
            this.costumeShedule.DataPropertyName = "returndate_shedule";
            dataGridViewCellStyle38.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle38.ForeColor = System.Drawing.Color.Green;
            dataGridViewCellStyle38.Format = "d";
            dataGridViewCellStyle38.NullValue = null;
            dataGridViewCellStyle38.SelectionForeColor = System.Drawing.Color.Green;
            this.costumeShedule.DefaultCellStyle = dataGridViewCellStyle38;
            this.costumeShedule.HeaderText = "Возврат план.";
            this.costumeShedule.Name = "costumeShedule";
            this.costumeShedule.Width = 80;
            // 
            // costumeSizeName
            // 
            this.costumeSizeName.DataPropertyName = "size_name_num";
            this.costumeSizeName.HeaderText = "Размер";
            this.costumeSizeName.Name = "costumeSizeName";
            this.costumeSizeName.ReadOnly = true;
            this.costumeSizeName.Width = 70;
            // 
            // costumePrice
            // 
            this.costumePrice.DataPropertyName = "costume_price";
            this.costumePrice.HeaderText = "Депозит";
            this.costumePrice.Name = "costumePrice";
            this.costumePrice.ReadOnly = true;
            this.costumePrice.Width = 60;
            // 
            // costumeDailyPrice
            // 
            this.costumeDailyPrice.DataPropertyName = "costume_daily_price";
            this.costumeDailyPrice.HeaderText = "Цена/день";
            this.costumeDailyPrice.Name = "costumeDailyPrice";
            this.costumeDailyPrice.ReadOnly = true;
            this.costumeDailyPrice.Width = 80;
            // 
            // costumeRentPrice
            // 
            this.costumeRentPrice.DataPropertyName = "rent_price";
            this.costumeRentPrice.HeaderText = "Стоимость аренды";
            this.costumeRentPrice.Name = "costumeRentPrice";
            this.costumeRentPrice.ReadOnly = true;
            this.costumeRentPrice.Width = 70;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(972, 409);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(89, 28);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // orderGB
            // 
            this.orderGB.Controls.Add(this.printButton);
            this.orderGB.Controls.Add(this.totalRentLabel);
            this.orderGB.Controls.Add(this.employeeLabel);
            this.orderGB.Controls.Add(this.employeeTB);
            this.orderGB.Controls.Add(this.costumeRemoveButton);
            this.orderGB.Controls.Add(this.costumeAddButton);
            this.orderGB.Controls.Add(this.totalDepositLabel);
            this.orderGB.Controls.Add(this.clientButton);
            this.orderGB.Controls.Add(this.costumeLabel);
            this.orderGB.Controls.Add(this.clientCB);
            this.orderGB.Controls.Add(this.clientLabel);
            this.orderGB.Controls.Add(this.dateLabel);
            this.orderGB.Controls.Add(this.dateDTP);
            this.orderGB.Controls.Add(this.OKButton);
            this.orderGB.Controls.Add(this.cancelButton);
            this.orderGB.Controls.Add(this.costumeDGV);
            this.orderGB.Location = new System.Drawing.Point(13, 82);
            this.orderGB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.orderGB.Name = "orderGB";
            this.orderGB.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.orderGB.Size = new System.Drawing.Size(1068, 444);
            this.orderGB.TabIndex = 19;
            this.orderGB.TabStop = false;
            this.orderGB.Text = "orderGB";
            // 
            // costumeRemoveButton
            // 
            this.costumeRemoveButton.Location = new System.Drawing.Point(916, 127);
            this.costumeRemoveButton.Margin = new System.Windows.Forms.Padding(4);
            this.costumeRemoveButton.Name = "costumeRemoveButton";
            this.costumeRemoveButton.Size = new System.Drawing.Size(32, 28);
            this.costumeRemoveButton.TabIndex = 26;
            this.costumeRemoveButton.Text = "-";
            this.costumeRemoveButton.UseVisualStyleBackColor = true;
            this.costumeRemoveButton.Click += new System.EventHandler(this.costumeRemoveButton_Click);
            // 
            // costumeAddButton
            // 
            this.costumeAddButton.Location = new System.Drawing.Point(916, 91);
            this.costumeAddButton.Margin = new System.Windows.Forms.Padding(4);
            this.costumeAddButton.Name = "costumeAddButton";
            this.costumeAddButton.Size = new System.Drawing.Size(32, 28);
            this.costumeAddButton.TabIndex = 24;
            this.costumeAddButton.Text = "+";
            this.costumeAddButton.UseVisualStyleBackColor = true;
            this.costumeAddButton.Click += new System.EventHandler(this.costumeAddButton_Click);
            // 
            // totalDepositLabel
            // 
            this.totalDepositLabel.AutoSize = true;
            this.totalDepositLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalDepositLabel.Location = new System.Drawing.Point(204, 414);
            this.totalDepositLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalDepositLabel.Name = "totalDepositLabel";
            this.totalDepositLabel.Size = new System.Drawing.Size(172, 17);
            this.totalDepositLabel.TabIndex = 11;
            this.totalDepositLabel.Text = "Итого депозит: 0 руб.";
            // 
            // clientButton
            // 
            this.clientButton.Location = new System.Drawing.Point(1027, 37);
            this.clientButton.Margin = new System.Windows.Forms.Padding(4);
            this.clientButton.Name = "clientButton";
            this.clientButton.Size = new System.Drawing.Size(32, 28);
            this.clientButton.TabIndex = 23;
            this.clientButton.Text = "...";
            this.clientButton.UseVisualStyleBackColor = true;
            this.clientButton.Click += new System.EventHandler(this.clientButton_Click);
            // 
            // costumeLabel
            // 
            this.costumeLabel.AutoSize = true;
            this.costumeLabel.Location = new System.Drawing.Point(15, 71);
            this.costumeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.costumeLabel.Name = "costumeLabel";
            this.costumeLabel.Size = new System.Drawing.Size(68, 17);
            this.costumeLabel.TabIndex = 18;
            this.costumeLabel.Text = "Костюмы";
            // 
            // clientCB
            // 
            this.clientCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clientCB.FormattingEnabled = true;
            this.clientCB.Location = new System.Drawing.Point(721, 38);
            this.clientCB.Margin = new System.Windows.Forms.Padding(4);
            this.clientCB.Name = "clientCB";
            this.clientCB.Size = new System.Drawing.Size(304, 24);
            this.clientCB.TabIndex = 16;
            // 
            // clientLabel
            // 
            this.clientLabel.AutoSize = true;
            this.clientLabel.Location = new System.Drawing.Point(721, 18);
            this.clientLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.clientLabel.Name = "clientLabel";
            this.clientLabel.Size = new System.Drawing.Size(56, 17);
            this.clientLabel.TabIndex = 15;
            this.clientLabel.Text = "Клиент";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(11, 18);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(95, 17);
            this.dateLabel.TabIndex = 13;
            this.dateLabel.Text = "Дата выдачи";
            // 
            // dateDTP
            // 
            this.dateDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDTP.Location = new System.Drawing.Point(11, 38);
            this.dateDTP.Margin = new System.Windows.Forms.Padding(4);
            this.dateDTP.Name = "dateDTP";
            this.dateDTP.Size = new System.Drawing.Size(105, 22);
            this.dateDTP.TabIndex = 12;
            // 
            // OKButton
            // 
            this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OKButton.Location = new System.Drawing.Point(875, 409);
            this.OKButton.Margin = new System.Windows.Forms.Padding(4);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(89, 28);
            this.OKButton.TabIndex = 11;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.Location = new System.Drawing.Point(1089, 224);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(147, 28);
            this.deleteButton.TabIndex = 20;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // takeButton
            // 
            this.takeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.takeButton.Location = new System.Drawing.Point(1089, 117);
            this.takeButton.Margin = new System.Windows.Forms.Padding(4);
            this.takeButton.Name = "takeButton";
            this.takeButton.Size = new System.Drawing.Size(147, 28);
            this.takeButton.TabIndex = 16;
            this.takeButton.Text = "Принять костюмы";
            this.takeButton.UseVisualStyleBackColor = true;
            this.takeButton.Click += new System.EventHandler(this.takeButton_Click);
            // 
            // searchTB
            // 
            this.searchTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTB.Location = new System.Drawing.Point(13, 50);
            this.searchTB.Margin = new System.Windows.Forms.Padding(4);
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(1067, 22);
            this.searchTB.TabIndex = 14;
            this.searchTB.TextChanged += new System.EventHandler(this.searchTB_TextChanged);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(13, 30);
            this.searchLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(48, 17);
            this.searchLabel.TabIndex = 12;
            this.searchLabel.Text = "Поиск";
            // 
            // mainName
            // 
            this.mainName.DataPropertyName = "costume_name";
            this.mainName.HeaderText = "Костюм";
            this.mainName.Name = "mainName";
            this.mainName.ReadOnly = true;
            this.mainName.Width = 200;
            // 
            // mainVendor
            // 
            this.mainVendor.DataPropertyName = "vendor";
            this.mainVendor.HeaderText = "Артикул";
            this.mainVendor.Name = "mainVendor";
            this.mainVendor.ReadOnly = true;
            this.mainVendor.Width = 60;
            // 
            // mainSizeName
            // 
            this.mainSizeName.DataPropertyName = "size_name";
            this.mainSizeName.HeaderText = "Размер";
            this.mainSizeName.Name = "mainSizeName";
            this.mainSizeName.ReadOnly = true;
            this.mainSizeName.Width = 50;
            // 
            // mainClientName
            // 
            this.mainClientName.DataPropertyName = "client_name";
            this.mainClientName.HeaderText = "Клиент";
            this.mainClientName.Name = "mainClientName";
            this.mainClientName.ReadOnly = true;
            this.mainClientName.Width = 200;
            // 
            // mainClientTelephone
            // 
            this.mainClientTelephone.DataPropertyName = "client_telephone";
            this.mainClientTelephone.HeaderText = "Телефон";
            this.mainClientTelephone.Name = "mainClientTelephone";
            this.mainClientTelephone.ReadOnly = true;
            // 
            // mainReturndateShedule
            // 
            this.mainReturndateShedule.DataPropertyName = "returndate_shedule";
            this.mainReturndateShedule.HeaderText = "Дата возвр. план.";
            this.mainReturndateShedule.Name = "mainReturndateShedule";
            this.mainReturndateShedule.ReadOnly = true;
            // 
            // issueButton
            // 
            this.issueButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.issueButton.Location = new System.Drawing.Point(1089, 82);
            this.issueButton.Margin = new System.Windows.Forms.Padding(4);
            this.issueButton.Name = "issueButton";
            this.issueButton.Size = new System.Drawing.Size(147, 28);
            this.issueButton.TabIndex = 15;
            this.issueButton.Text = "Выдать костюмы";
            this.issueButton.UseVisualStyleBackColor = true;
            this.issueButton.Click += new System.EventHandler(this.issueButton_Click);
            // 
            // editButton
            // 
            this.editButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editButton.Location = new System.Drawing.Point(1088, 153);
            this.editButton.Margin = new System.Windows.Forms.Padding(4);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(147, 28);
            this.editButton.TabIndex = 17;
            this.editButton.Text = "Редактировать";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.headerLabel.Location = new System.Drawing.Point(13, 9);
            this.headerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(63, 17);
            this.headerLabel.TabIndex = 11;
            this.headerLabel.Text = "Заказы";
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
            this.mainVendor,
            this.mainSizeName,
            this.mainClientName,
            this.mainClientTelephone,
            this.mainReturndateShedule});
            this.mainDGV.Location = new System.Drawing.Point(13, 82);
            this.mainDGV.Margin = new System.Windows.Forms.Padding(4);
            this.mainDGV.Name = "mainDGV";
            this.mainDGV.ReadOnly = true;
            this.mainDGV.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mainDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.mainDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mainDGV.Size = new System.Drawing.Size(1068, 444);
            this.mainDGV.TabIndex = 13;
            this.mainDGV.SelectionChanged += new System.EventHandler(this.mainDGV_SelectionChanged);
            this.mainDGV.Sorted += new System.EventHandler(this.mainDGV_Sorted);
            this.mainDGV.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.mainDGV_MouseDoubleClick);
            // 
            // JournalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 537);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.takeButton);
            this.Controls.Add(this.searchTB);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.issueButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.orderGB);
            this.Controls.Add(this.mainDGV);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "JournalForm";
            this.Text = "Справочник \"Журнал заказов\"";
            this.Load += new System.EventHandler(this.JournalForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.costumeDGV)).EndInit();
            this.orderGB.ResumeLayout(false);
            this.orderGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Label totalRentLabel;
        private System.Windows.Forms.Label employeeLabel;
        private System.Windows.Forms.TextBox employeeTB;
        private System.Windows.Forms.DataGridView costumeDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn costumeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn costumeVendor;
        private System.Windows.Forms.DataGridViewTextBoxColumn costumeShedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn costumeSizeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn costumePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn costumeDailyPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn costumeRentPrice;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.GroupBox orderGB;
        private System.Windows.Forms.Button costumeRemoveButton;
        private System.Windows.Forms.Button costumeAddButton;
        private System.Windows.Forms.Label totalDepositLabel;
        private System.Windows.Forms.Button clientButton;
        private System.Windows.Forms.Label costumeLabel;
        public System.Windows.Forms.ComboBox clientCB;
        private System.Windows.Forms.Label clientLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.DateTimePicker dateDTP;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button takeButton;
        private System.Windows.Forms.TextBox searchTB;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn mainName;
        private System.Windows.Forms.DataGridViewTextBoxColumn mainVendor;
        private System.Windows.Forms.DataGridViewTextBoxColumn mainSizeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn mainClientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn mainClientTelephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn mainReturndateShedule;
        private System.Windows.Forms.Button issueButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.DataGridView mainDGV;
    }
}