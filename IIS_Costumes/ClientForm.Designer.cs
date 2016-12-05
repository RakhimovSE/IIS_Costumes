namespace IIS_Costumes
{
    partial class ClientForm
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
            this.OKButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.mainGB = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.passDepartRTB = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.passDateDTP = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.passNumTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.adressTB = new System.Windows.Forms.TextBox();
            this.phoneTB = new System.Windows.Forms.TextBox();
            this.fioTB = new System.Windows.Forms.TextBox();
            this.delButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mainDGV = new System.Windows.Forms.DataGridView();
            this.mainClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainTelephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainGB.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OKButton.Location = new System.Drawing.Point(515, 362);
            this.OKButton.Margin = new System.Windows.Forms.Padding(4);
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
            this.cancelButton.Location = new System.Drawing.Point(612, 362);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(89, 28);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // mainGB
            // 
            this.mainGB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainGB.Controls.Add(this.label5);
            this.mainGB.Controls.Add(this.label4);
            this.mainGB.Controls.Add(this.groupBox1);
            this.mainGB.Controls.Add(this.label3);
            this.mainGB.Controls.Add(this.adressTB);
            this.mainGB.Controls.Add(this.phoneTB);
            this.mainGB.Controls.Add(this.fioTB);
            this.mainGB.Controls.Add(this.OKButton);
            this.mainGB.Controls.Add(this.cancelButton);
            this.mainGB.Location = new System.Drawing.Point(13, 82);
            this.mainGB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainGB.Name = "mainGB";
            this.mainGB.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainGB.Size = new System.Drawing.Size(708, 398);
            this.mainGB.TabIndex = 18;
            this.mainGB.TabStop = false;
            this.mainGB.Text = "Карточка";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Место жительства";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Телефон";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.passDepartRTB);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.passDateDTP);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.passNumTB);
            this.groupBox1.Location = new System.Drawing.Point(365, 21);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(265, 271);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Паспорт";
            // 
            // passDepartRTB
            // 
            this.passDepartRTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passDepartRTB.Location = new System.Drawing.Point(9, 174);
            this.passDepartRTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passDepartRTB.Name = "passDepartRTB";
            this.passDepartRTB.Size = new System.Drawing.Size(249, 91);
            this.passDepartRTB.TabIndex = 25;
            this.passDepartRTB.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 17);
            this.label8.TabIndex = 24;
            this.label8.Text = "Кто выдал";
            // 
            // passDateDTP
            // 
            this.passDateDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.passDateDTP.Location = new System.Drawing.Point(9, 113);
            this.passDateDTP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passDateDTP.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.passDateDTP.Name = "passDateDTP";
            this.passDateDTP.Size = new System.Drawing.Size(127, 22);
            this.passDateDTP.TabIndex = 24;
            this.passDateDTP.Value = new System.DateTime(2016, 11, 5, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Серия и номер";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "Дата выдачи";
            // 
            // passNumTB
            // 
            this.passNumTB.Location = new System.Drawing.Point(9, 49);
            this.passNumTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passNumTB.Name = "passNumTB";
            this.passNumTB.Size = new System.Drawing.Size(149, 22);
            this.passNumTB.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "ФИО";
            // 
            // adressTB
            // 
            this.adressTB.Location = new System.Drawing.Point(5, 194);
            this.adressTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.adressTB.Name = "adressTB";
            this.adressTB.Size = new System.Drawing.Size(353, 22);
            this.adressTB.TabIndex = 15;
            // 
            // phoneTB
            // 
            this.phoneTB.Location = new System.Drawing.Point(5, 124);
            this.phoneTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.phoneTB.Name = "phoneTB";
            this.phoneTB.Size = new System.Drawing.Size(245, 22);
            this.phoneTB.TabIndex = 13;
            // 
            // fioTB
            // 
            this.fioTB.Location = new System.Drawing.Point(5, 58);
            this.fioTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fioTB.Name = "fioTB";
            this.fioTB.Size = new System.Drawing.Size(353, 22);
            this.fioTB.TabIndex = 12;
            // 
            // delButton
            // 
            this.delButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.delButton.Location = new System.Drawing.Point(728, 190);
            this.delButton.Margin = new System.Windows.Forms.Padding(4);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(125, 28);
            this.delButton.TabIndex = 16;
            this.delButton.Text = "Удалить";
            this.delButton.UseVisualStyleBackColor = true;
            this.delButton.Click += new System.EventHandler(this.delButton_Click);
            // 
            // editButton
            // 
            this.editButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editButton.Location = new System.Drawing.Point(728, 117);
            this.editButton.Margin = new System.Windows.Forms.Padding(4);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(125, 28);
            this.editButton.TabIndex = 15;
            this.editButton.Text = "Редактировать";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.Location = new System.Drawing.Point(728, 82);
            this.addButton.Margin = new System.Windows.Forms.Padding(4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(125, 28);
            this.addButton.TabIndex = 14;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // searchTB
            // 
            this.searchTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTB.Location = new System.Drawing.Point(13, 50);
            this.searchTB.Margin = new System.Windows.Forms.Padding(4);
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(707, 22);
            this.searchTB.TabIndex = 12;
            this.searchTB.TextChanged += new System.EventHandler(this.searchTB_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Поиск";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Клиенты";
            // 
            // mainDGV
            // 
            this.mainDGV.AllowUserToAddRows = false;
            this.mainDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mainClient,
            this.mainTelephone,
            this.address});
            this.mainDGV.Location = new System.Drawing.Point(13, 82);
            this.mainDGV.Margin = new System.Windows.Forms.Padding(4);
            this.mainDGV.Name = "mainDGV";
            this.mainDGV.ReadOnly = true;
            this.mainDGV.Size = new System.Drawing.Size(707, 398);
            this.mainDGV.TabIndex = 19;
            this.mainDGV.SelectionChanged += new System.EventHandler(this.mainDGV_SelectionChanged);
            this.mainDGV.DoubleClick += new System.EventHandler(this.mainDGV_DoubleClick);
            // 
            // mainClient
            // 
            this.mainClient.DataPropertyName = "name";
            this.mainClient.HeaderText = "Клиент";
            this.mainClient.Name = "mainClient";
            this.mainClient.ReadOnly = true;
            this.mainClient.Width = 200;
            // 
            // mainTelephone
            // 
            this.mainTelephone.DataPropertyName = "telephone";
            this.mainTelephone.HeaderText = "Телефон";
            this.mainTelephone.Name = "mainTelephone";
            this.mainTelephone.ReadOnly = true;
            // 
            // address
            // 
            this.address.DataPropertyName = "address";
            this.address.HeaderText = "Адрес";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 492);
            this.Controls.Add(this.delButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.searchTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mainDGV);
            this.Controls.Add(this.mainGB);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ClientForm";
            this.Text = "Карнавальные костюмы - Клиенты";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            this.mainGB.ResumeLayout(false);
            this.mainGB.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.GroupBox mainGB;
        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox searchTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passNumTB;
        private System.Windows.Forms.TextBox adressTB;
        private System.Windows.Forms.TextBox phoneTB;
        private System.Windows.Forms.TextBox fioTB;
        private System.Windows.Forms.RichTextBox passDepartRTB;
        private System.Windows.Forms.DateTimePicker passDateDTP;
        private System.Windows.Forms.DataGridView mainDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn mainClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn mainTelephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
    }
}