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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.headerLabel = new System.Windows.Forms.Label();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.mainDGV = new System.Windows.Forms.DataGridView();
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
            this.размерыКостюмовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.типыКостюмовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.размерыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderGB = new System.Windows.Forms.GroupBox();
            this.employeeLabel = new System.Windows.Forms.Label();
            this.employeeTB = new System.Windows.Forms.TextBox();
            this.costumeDGV = new System.Windows.Forms.DataGridView();
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
            this.costumeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costumeVendor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costumeSizeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costumePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costumeDailyPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costumeShedule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costumeNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainSelected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.mainName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainVendor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainSizeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainClientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainClientTelephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainReturndateShedule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.mainDGV)).BeginInit();
            this.mainMenuStrip.SuspendLayout();
            this.orderGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.costumeDGV)).BeginInit();
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
            this.размерыКостюмовToolStripMenuItem,
            this.типыКостюмовToolStripMenuItem,
            this.размерыToolStripMenuItem});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // журналЗаказовToolStripMenuItem
            // 
            this.журналЗаказовToolStripMenuItem.Name = "журналЗаказовToolStripMenuItem";
            this.журналЗаказовToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.журналЗаказовToolStripMenuItem.Text = "Журнал заказов";
            this.журналЗаказовToolStripMenuItem.Click += new System.EventHandler(this.журналЗаказовToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(179, 6);
            // 
            // счетаToolStripMenuItem
            // 
            this.счетаToolStripMenuItem.Name = "счетаToolStripMenuItem";
            this.счетаToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.счетаToolStripMenuItem.Text = "Счета";
            this.счетаToolStripMenuItem.Click += new System.EventHandler(this.счетаToolStripMenuItem_Click);
            // 
            // клиентыToolStripMenuItem
            // 
            this.клиентыToolStripMenuItem.Name = "клиентыToolStripMenuItem";
            this.клиентыToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.клиентыToolStripMenuItem.Text = "Клиенты";
            this.клиентыToolStripMenuItem.Click += new System.EventHandler(this.клиентыToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(179, 6);
            // 
            // костюмыToolStripMenuItem
            // 
            this.костюмыToolStripMenuItem.Name = "костюмыToolStripMenuItem";
            this.костюмыToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.костюмыToolStripMenuItem.Text = "Костюмы";
            this.костюмыToolStripMenuItem.Click += new System.EventHandler(this.костюмыToolStripMenuItem_Click);
            // 
            // размерыКостюмовToolStripMenuItem
            // 
            this.размерыКостюмовToolStripMenuItem.Name = "размерыКостюмовToolStripMenuItem";
            this.размерыКостюмовToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.размерыКостюмовToolStripMenuItem.Text = "Размеры костюмов";
            this.размерыКостюмовToolStripMenuItem.Click += new System.EventHandler(this.размерыКостюмовToolStripMenuItem_Click);
            // 
            // типыКостюмовToolStripMenuItem
            // 
            this.типыКостюмовToolStripMenuItem.Name = "типыКостюмовToolStripMenuItem";
            this.типыКостюмовToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.типыКостюмовToolStripMenuItem.Text = "Типы костюмов";
            this.типыКостюмовToolStripMenuItem.Click += new System.EventHandler(this.типыКостюмовToolStripMenuItem_Click);
            // 
            // размерыToolStripMenuItem
            // 
            this.размерыToolStripMenuItem.Name = "размерыToolStripMenuItem";
            this.размерыToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.размерыToolStripMenuItem.Text = "Размеры";
            this.размерыToolStripMenuItem.Click += new System.EventHandler(this.размерыToolStripMenuItem_Click);
            // 
            // orderGB
            // 
            this.orderGB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.orderGB.Controls.Add(this.employeeLabel);
            this.orderGB.Controls.Add(this.employeeTB);
            this.orderGB.Controls.Add(this.costumeDGV);
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
            // employeeLabel
            // 
            this.employeeLabel.AutoSize = true;
            this.employeeLabel.Location = new System.Drawing.Point(192, 15);
            this.employeeLabel.Name = "employeeLabel";
            this.employeeLabel.Size = new System.Drawing.Size(56, 13);
            this.employeeLabel.TabIndex = 31;
            this.employeeLabel.Text = "Оператор";
            // 
            // employeeTB
            // 
            this.employeeTB.Location = new System.Drawing.Point(192, 31);
            this.employeeTB.Name = "employeeTB";
            this.employeeTB.ReadOnly = true;
            this.employeeTB.Size = new System.Drawing.Size(229, 20);
            this.employeeTB.TabIndex = 30;
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
            this.costumePrice,
            this.costumeDailyPrice,
            this.costumeShedule,
            this.costumeNote});
            this.costumeDGV.Location = new System.Drawing.Point(8, 74);
            this.costumeDGV.Name = "costumeDGV";
            this.costumeDGV.ReadOnly = true;
            this.costumeDGV.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.costumeDGV.RowHeadersVisible = false;
            this.costumeDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.costumeDGV.Size = new System.Drawing.Size(786, 211);
            this.costumeDGV.TabIndex = 29;
            this.costumeDGV.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.costumeDGV_CellMouseDoubleClick);
            // 
            // costumeRemoveButton
            // 
            this.costumeRemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.costumeRemoveButton.Location = new System.Drawing.Point(800, 103);
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
            this.costumeAddButton.Location = new System.Drawing.Point(800, 74);
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
            this.totalLabel.Location = new System.Drawing.Point(8, 296);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(85, 13);
            this.totalLabel.TabIndex = 11;
            this.totalLabel.Text = "Итого: 0 руб.";
            // 
            // clientButton
            // 
            this.clientButton.Location = new System.Drawing.Point(770, 30);
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
            this.costumeLabel.Location = new System.Drawing.Point(8, 58);
            this.costumeLabel.Name = "costumeLabel";
            this.costumeLabel.Size = new System.Drawing.Size(55, 13);
            this.costumeLabel.TabIndex = 18;
            this.costumeLabel.Text = "Костюмы";
            // 
            // clientCB
            // 
            this.clientCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clientCB.FormattingEnabled = true;
            this.clientCB.Location = new System.Drawing.Point(541, 31);
            this.clientCB.Name = "clientCB";
            this.clientCB.Size = new System.Drawing.Size(229, 21);
            this.clientCB.TabIndex = 16;
            // 
            // clientLabel
            // 
            this.clientLabel.AutoSize = true;
            this.clientLabel.Location = new System.Drawing.Point(541, 15);
            this.clientLabel.Name = "clientLabel";
            this.clientLabel.Size = new System.Drawing.Size(43, 13);
            this.clientLabel.TabIndex = 15;
            this.clientLabel.Text = "Клиент";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(8, 15);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(73, 13);
            this.dateLabel.TabIndex = 13;
            this.dateLabel.Text = "Дата выдачи";
            // 
            // dateDTP
            // 
            this.dateDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDTP.Location = new System.Drawing.Point(8, 31);
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
            this.costumeVendor.HeaderText = "Артикул";
            this.costumeVendor.Name = "costumeVendor";
            this.costumeVendor.ReadOnly = true;
            this.costumeVendor.Width = 70;
            // 
            // costumeSizeName
            // 
            this.costumeSizeName.DataPropertyName = "size_name";
            this.costumeSizeName.HeaderText = "Размер";
            this.costumeSizeName.Name = "costumeSizeName";
            this.costumeSizeName.ReadOnly = true;
            this.costumeSizeName.Width = 70;
            // 
            // costumePrice
            // 
            this.costumePrice.DataPropertyName = "price";
            this.costumePrice.HeaderText = "Цена";
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
            // costumeShedule
            // 
            this.costumeShedule.DataPropertyName = "returndate_shedule";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.costumeShedule.DefaultCellStyle = dataGridViewCellStyle2;
            this.costumeShedule.HeaderText = "Возврат план.";
            this.costumeShedule.Name = "costumeShedule";
            this.costumeShedule.ReadOnly = true;
            this.costumeShedule.Width = 80;
            // 
            // costumeNote
            // 
            this.costumeNote.DataPropertyName = "note";
            this.costumeNote.HeaderText = "Примечание";
            this.costumeNote.Name = "costumeNote";
            this.costumeNote.ReadOnly = true;
            this.costumeNote.Width = 200;
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
        private System.Windows.Forms.Label costumeLabel;
        private System.Windows.Forms.Label clientLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.DateTimePicker dateDTP;
        private System.Windows.Forms.Button costumeRemoveButton;
        private System.Windows.Forms.Button costumeAddButton;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Button clientButton;
        private System.Windows.Forms.ToolStripMenuItem журналЗаказовToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        public System.Windows.Forms.ComboBox clientCB;
        private System.Windows.Forms.Label employeeLabel;
        private System.Windows.Forms.TextBox employeeTB;
        private System.Windows.Forms.ToolStripMenuItem размерыКостюмовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem размерыToolStripMenuItem;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn costumeDailyPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn costumeShedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn costumeNote;
    }
}

