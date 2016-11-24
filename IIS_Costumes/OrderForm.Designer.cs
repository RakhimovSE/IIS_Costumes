namespace IIS_Costumes
{
    partial class OrderForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.headerLabel = new System.Windows.Forms.Label();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.mainDGV = new System.Windows.Forms.DataGridView();
            this.mainSelected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.mainName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainVendor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainSizeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainClientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainClientTelephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainReturndateShedule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issueButton = new System.Windows.Forms.Button();
            this.takeButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.журналЗаказовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.счетаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.клиентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.костюмыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.типыКостюмовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderGB = new System.Windows.Forms.GroupBox();
            this.costumeDGV = new System.Windows.Forms.DataGridView();
            this.costumeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costumeVendor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costumeSizeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costumePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnGB = new System.Windows.Forms.GroupBox();
            this.sheduleDTP = new System.Windows.Forms.DateTimePicker();
            this.returnedChB = new System.Windows.Forms.CheckBox();
            this.sheduleLabel = new System.Windows.Forms.Label();
            this.actualDTP = new System.Windows.Forms.DateTimePicker();
            this.actualLabel = new System.Windows.Forms.Label();
            this.costumeRemoveButton = new System.Windows.Forms.Button();
            this.costumeAddButton = new System.Windows.Forms.Button();
            this.totalLabel = new System.Windows.Forms.Label();
            this.clientButton = new System.Windows.Forms.Button();
            this.costumeLabel = new System.Windows.Forms.Label();
            this.clientCB = new System.Windows.Forms.ComboBox();
            this.clientLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.dateDTP = new System.Windows.Forms.DateTimePicker();
            this.OKButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainDGV)).BeginInit();
            this.mainMenuStrip.SuspendLayout();
            this.orderGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.costumeDGV)).BeginInit();
            this.returnGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.headerLabel.Location = new System.Drawing.Point(12, 26);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(52, 13);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Заказы";
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(12, 43);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(39, 13);
            this.searchLabel.TabIndex = 1;
            this.searchLabel.Text = "Поиск";
            // 
            // searchTB
            // 
            this.searchTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTB.Location = new System.Drawing.Point(12, 59);
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(829, 20);
            this.searchTB.TabIndex = 2;
            this.searchTB.TextChanged += new System.EventHandler(this.searchTB_TextChanged);
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
            this.mainSelected,
            this.mainName,
            this.mainVendor,
            this.mainSizeName,
            this.mainClientName,
            this.mainClientTelephone,
            this.mainReturndateShedule});
            this.mainDGV.Location = new System.Drawing.Point(12, 85);
            this.mainDGV.Name = "mainDGV";
            this.mainDGV.ReadOnly = true;
            this.mainDGV.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mainDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.mainDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mainDGV.Size = new System.Drawing.Size(829, 319);
            this.mainDGV.TabIndex = 1;
            this.mainDGV.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.mainDGV_CellMouseDoubleClick);
            this.mainDGV.SelectionChanged += new System.EventHandler(this.mainDgv_SelectionChanged);
            this.mainDGV.Sorted += new System.EventHandler(this.mainDGV_Sorted);
            // 
            // mainSelected
            // 
            this.mainSelected.HeaderText = "";
            this.mainSelected.Name = "mainSelected";
            this.mainSelected.ReadOnly = true;
            this.mainSelected.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.mainSelected.Width = 30;
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
            this.issueButton.Location = new System.Drawing.Point(847, 85);
            this.issueButton.Name = "issueButton";
            this.issueButton.Size = new System.Drawing.Size(110, 23);
            this.issueButton.TabIndex = 4;
            this.issueButton.Text = "Выдать костюмы";
            this.issueButton.UseVisualStyleBackColor = true;
            this.issueButton.Click += new System.EventHandler(this.issueButton_Click);
            // 
            // takeButton
            // 
            this.takeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.takeButton.Location = new System.Drawing.Point(847, 114);
            this.takeButton.Name = "takeButton";
            this.takeButton.Size = new System.Drawing.Size(110, 23);
            this.takeButton.TabIndex = 5;
            this.takeButton.Text = "Принять костюмы";
            this.takeButton.UseVisualStyleBackColor = true;
            this.takeButton.Click += new System.EventHandler(this.takeButton_Click);
            // 
            // editButton
            // 
            this.editButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editButton.Location = new System.Drawing.Point(846, 143);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(110, 23);
            this.editButton.TabIndex = 7;
            this.editButton.Text = "Редактировать";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справочникиToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(969, 24);
            this.mainMenuStrip.TabIndex = 8;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.журналЗаказовToolStripMenuItem,
            this.toolStripMenuItem2,
            this.счетаToolStripMenuItem,
            this.клиентыToolStripMenuItem,
            this.toolStripMenuItem1,
            this.костюмыToolStripMenuItem,
            this.типыКостюмовToolStripMenuItem});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // журналЗаказовToolStripMenuItem
            // 
            this.журналЗаказовToolStripMenuItem.Name = "журналЗаказовToolStripMenuItem";
            this.журналЗаказовToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.журналЗаказовToolStripMenuItem.Text = "Журнал заказов";
            this.журналЗаказовToolStripMenuItem.Click += new System.EventHandler(this.журналЗаказовToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(160, 6);
            // 
            // счетаToolStripMenuItem
            // 
            this.счетаToolStripMenuItem.Name = "счетаToolStripMenuItem";
            this.счетаToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.счетаToolStripMenuItem.Text = "Счета";
            this.счетаToolStripMenuItem.Click += new System.EventHandler(this.счетаToolStripMenuItem_Click);
            // 
            // клиентыToolStripMenuItem
            // 
            this.клиентыToolStripMenuItem.Name = "клиентыToolStripMenuItem";
            this.клиентыToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.клиентыToolStripMenuItem.Text = "Клиенты";
            this.клиентыToolStripMenuItem.Click += new System.EventHandler(this.клиентыToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(160, 6);
            // 
            // костюмыToolStripMenuItem
            // 
            this.костюмыToolStripMenuItem.Name = "костюмыToolStripMenuItem";
            this.костюмыToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.костюмыToolStripMenuItem.Text = "Костюмы";
            this.костюмыToolStripMenuItem.Click += new System.EventHandler(this.костюмыToolStripMenuItem_Click);
            // 
            // типыКостюмовToolStripMenuItem
            // 
            this.типыКостюмовToolStripMenuItem.Name = "типыКостюмовToolStripMenuItem";
            this.типыКостюмовToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.типыКостюмовToolStripMenuItem.Text = "Типы костюмов";
            this.типыКостюмовToolStripMenuItem.Click += new System.EventHandler(this.типыКостюмовToolStripMenuItem_Click);
            // 
            // orderGB
            // 
            this.orderGB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.orderGB.Controls.Add(this.costumeDGV);
            this.orderGB.Controls.Add(this.returnGB);
            this.orderGB.Controls.Add(this.costumeRemoveButton);
            this.orderGB.Controls.Add(this.costumeAddButton);
            this.orderGB.Controls.Add(this.totalLabel);
            this.orderGB.Controls.Add(this.clientButton);
            this.orderGB.Controls.Add(this.costumeLabel);
            this.orderGB.Controls.Add(this.clientCB);
            this.orderGB.Controls.Add(this.clientLabel);
            this.orderGB.Controls.Add(this.dateLabel);
            this.orderGB.Controls.Add(this.dateDTP);
            this.orderGB.Controls.Add(this.OKButton);
            this.orderGB.Controls.Add(this.cancelButton);
            this.orderGB.Location = new System.Drawing.Point(12, 85);
            this.orderGB.Margin = new System.Windows.Forms.Padding(2);
            this.orderGB.Name = "orderGB";
            this.orderGB.Padding = new System.Windows.Forms.Padding(2);
            this.orderGB.Size = new System.Drawing.Size(829, 319);
            this.orderGB.TabIndex = 9;
            this.orderGB.TabStop = false;
            this.orderGB.Text = "orderGB";
            // 
            // costumeDGV
            // 
            this.costumeDGV.AllowUserToAddRows = false;
            this.costumeDGV.AllowUserToResizeRows = false;
            this.costumeDGV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.costumeDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.costumeDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.costumeName,
            this.costumeVendor,
            this.costumeSizeName,
            this.costumePrice});
            this.costumeDGV.Location = new System.Drawing.Point(429, 45);
            this.costumeDGV.Name = "costumeDGV";
            this.costumeDGV.ReadOnly = true;
            this.costumeDGV.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.costumeDGV.RowHeadersVisible = false;
            this.costumeDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.costumeDGV.Size = new System.Drawing.Size(365, 240);
            this.costumeDGV.TabIndex = 29;
            // 
            // costumeName
            // 
            this.costumeName.HeaderText = "Название";
            this.costumeName.Name = "costumeName";
            this.costumeName.ReadOnly = true;
            this.costumeName.Width = 180;
            // 
            // costumeVendor
            // 
            this.costumeVendor.HeaderText = "Артикул";
            this.costumeVendor.Name = "costumeVendor";
            this.costumeVendor.ReadOnly = true;
            this.costumeVendor.Width = 60;
            // 
            // costumeSizeName
            // 
            this.costumeSizeName.HeaderText = "Размер";
            this.costumeSizeName.Name = "costumeSizeName";
            this.costumeSizeName.ReadOnly = true;
            this.costumeSizeName.Width = 50;
            // 
            // costumePrice
            // 
            this.costumePrice.HeaderText = "Цена";
            this.costumePrice.Name = "costumePrice";
            this.costumePrice.ReadOnly = true;
            this.costumePrice.Width = 50;
            // 
            // returnGB
            // 
            this.returnGB.Controls.Add(this.sheduleDTP);
            this.returnGB.Controls.Add(this.returnedChB);
            this.returnGB.Controls.Add(this.sheduleLabel);
            this.returnGB.Controls.Add(this.actualDTP);
            this.returnGB.Controls.Add(this.actualLabel);
            this.returnGB.Location = new System.Drawing.Point(5, 124);
            this.returnGB.Name = "returnGB";
            this.returnGB.Size = new System.Drawing.Size(253, 83);
            this.returnGB.TabIndex = 28;
            this.returnGB.TabStop = false;
            this.returnGB.Text = "Возврат";
            // 
            // sheduleDTP
            // 
            this.sheduleDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.sheduleDTP.Location = new System.Drawing.Point(6, 55);
            this.sheduleDTP.Name = "sheduleDTP";
            this.sheduleDTP.Size = new System.Drawing.Size(80, 20);
            this.sheduleDTP.TabIndex = 19;
            // 
            // returnedChB
            // 
            this.returnedChB.AutoSize = true;
            this.returnedChB.Location = new System.Drawing.Point(105, 19);
            this.returnedChB.Name = "returnedChB";
            this.returnedChB.Size = new System.Drawing.Size(142, 17);
            this.returnedChB.TabIndex = 27;
            this.returnedChB.Text = "Костюмы возвращены";
            this.returnedChB.UseVisualStyleBackColor = true;
            this.returnedChB.CheckedChanged += new System.EventHandler(this.returnedChB_CheckedChanged);
            // 
            // sheduleLabel
            // 
            this.sheduleLabel.AutoSize = true;
            this.sheduleLabel.Location = new System.Drawing.Point(6, 39);
            this.sheduleLabel.Name = "sheduleLabel";
            this.sheduleLabel.Size = new System.Drawing.Size(83, 13);
            this.sheduleLabel.TabIndex = 20;
            this.sheduleLabel.Text = "Плановая дата";
            // 
            // actualDTP
            // 
            this.actualDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.actualDTP.Location = new System.Drawing.Point(105, 55);
            this.actualDTP.Name = "actualDTP";
            this.actualDTP.Size = new System.Drawing.Size(80, 20);
            this.actualDTP.TabIndex = 21;
            // 
            // actualLabel
            // 
            this.actualLabel.AutoSize = true;
            this.actualLabel.Location = new System.Drawing.Point(105, 39);
            this.actualLabel.Name = "actualLabel";
            this.actualLabel.Size = new System.Drawing.Size(102, 13);
            this.actualLabel.TabIndex = 22;
            this.actualLabel.Text = "Фактическая дата";
            // 
            // costumeRemoveButton
            // 
            this.costumeRemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.costumeRemoveButton.Location = new System.Drawing.Point(800, 74);
            this.costumeRemoveButton.Name = "costumeRemoveButton";
            this.costumeRemoveButton.Size = new System.Drawing.Size(24, 23);
            this.costumeRemoveButton.TabIndex = 26;
            this.costumeRemoveButton.Text = "-";
            this.costumeRemoveButton.UseVisualStyleBackColor = true;
            this.costumeRemoveButton.Click += new System.EventHandler(this.costumeRemoveButton_Click);
            // 
            // costumeAddButton
            // 
            this.costumeAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.costumeAddButton.Location = new System.Drawing.Point(800, 45);
            this.costumeAddButton.Name = "costumeAddButton";
            this.costumeAddButton.Size = new System.Drawing.Size(24, 23);
            this.costumeAddButton.TabIndex = 24;
            this.costumeAddButton.Text = "+";
            this.costumeAddButton.UseVisualStyleBackColor = true;
            this.costumeAddButton.Click += new System.EventHandler(this.costumeAddButton_Click);
            // 
            // totalLabel
            // 
            this.totalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalLabel.Location = new System.Drawing.Point(426, 296);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(85, 13);
            this.totalLabel.TabIndex = 11;
            this.totalLabel.Text = "Итого: 0 руб.";
            // 
            // clientButton
            // 
            this.clientButton.Location = new System.Drawing.Point(234, 88);
            this.clientButton.Name = "clientButton";
            this.clientButton.Size = new System.Drawing.Size(24, 23);
            this.clientButton.TabIndex = 23;
            this.clientButton.Text = "...";
            this.clientButton.UseVisualStyleBackColor = true;
            this.clientButton.Click += new System.EventHandler(this.clientButton_Click);
            // 
            // costumeLabel
            // 
            this.costumeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.costumeLabel.AutoSize = true;
            this.costumeLabel.Location = new System.Drawing.Point(426, 29);
            this.costumeLabel.Name = "costumeLabel";
            this.costumeLabel.Size = new System.Drawing.Size(55, 13);
            this.costumeLabel.TabIndex = 18;
            this.costumeLabel.Text = "Костюмы";
            // 
            // clientCB
            // 
            this.clientCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clientCB.FormattingEnabled = true;
            this.clientCB.Location = new System.Drawing.Point(5, 89);
            this.clientCB.Name = "clientCB";
            this.clientCB.Size = new System.Drawing.Size(229, 21);
            this.clientCB.TabIndex = 16;
            // 
            // clientLabel
            // 
            this.clientLabel.AutoSize = true;
            this.clientLabel.Location = new System.Drawing.Point(5, 75);
            this.clientLabel.Name = "clientLabel";
            this.clientLabel.Size = new System.Drawing.Size(43, 13);
            this.clientLabel.TabIndex = 15;
            this.clientLabel.Text = "Клиент";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(5, 29);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(73, 13);
            this.dateLabel.TabIndex = 13;
            this.dateLabel.Text = "Дата выдачи";
            // 
            // dateDTP
            // 
            this.dateDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDTP.Location = new System.Drawing.Point(5, 45);
            this.dateDTP.Name = "dateDTP";
            this.dateDTP.Size = new System.Drawing.Size(80, 20);
            this.dateDTP.TabIndex = 12;
            // 
            // OKButton
            // 
            this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OKButton.Location = new System.Drawing.Point(684, 291);
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
            this.cancelButton.Location = new System.Drawing.Point(757, 291);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(67, 23);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.Location = new System.Drawing.Point(847, 201);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(110, 23);
            this.deleteButton.TabIndex = 10;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 416);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.takeButton);
            this.Controls.Add(this.issueButton);
            this.Controls.Add(this.searchTB);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.mainMenuStrip);
            this.Controls.Add(this.orderGB);
            this.Controls.Add(this.mainDGV);
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Карнавальные костюмы - Заказы";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainDGV)).EndInit();
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.orderGB.ResumeLayout(false);
            this.orderGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.costumeDGV)).EndInit();
            this.returnGB.ResumeLayout(false);
            this.returnGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox searchTB;
        private System.Windows.Forms.DataGridView mainDGV;
        private System.Windows.Forms.Button issueButton;
        private System.Windows.Forms.Button takeButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem клиентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem костюмыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem типыКостюмовToolStripMenuItem;
        private System.Windows.Forms.GroupBox orderGB;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ToolStripMenuItem счетаToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label actualLabel;
        private System.Windows.Forms.DateTimePicker actualDTP;
        private System.Windows.Forms.Label sheduleLabel;
        private System.Windows.Forms.DateTimePicker sheduleDTP;
        private System.Windows.Forms.Label costumeLabel;
        private System.Windows.Forms.Label clientLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.DateTimePicker dateDTP;
        private System.Windows.Forms.Button costumeRemoveButton;
        private System.Windows.Forms.Button costumeAddButton;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Button clientButton;
        private System.Windows.Forms.GroupBox returnGB;
        private System.Windows.Forms.CheckBox returnedChB;
        private System.Windows.Forms.DataGridView costumeDGV;
        private System.Windows.Forms.DataGridViewCheckBoxColumn mainSelected;
        private System.Windows.Forms.DataGridViewTextBoxColumn mainName;
        private System.Windows.Forms.DataGridViewTextBoxColumn mainVendor;
        private System.Windows.Forms.DataGridViewTextBoxColumn mainSizeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn mainClientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn mainClientTelephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn mainReturndateShedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn costumeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn costumeVendor;
        private System.Windows.Forms.DataGridViewTextBoxColumn costumeSizeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn costumePrice;
        private System.Windows.Forms.ToolStripMenuItem журналЗаказовToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        public System.Windows.Forms.ComboBox clientCB;
    }
}

