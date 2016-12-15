namespace IIS_Costumes
{
    partial class SizeForm
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
            this.mainDGV = new System.Windows.Forms.DataGridView();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sizeTB = new System.Windows.Forms.TextBox();
            this.delButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.mainGB = new System.Windows.Forms.GroupBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.mainName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.altSizeTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.mainDGV)).BeginInit();
            this.mainGB.SuspendLayout();
            this.SuspendLayout();
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
            this.Column1});
            this.mainDGV.Location = new System.Drawing.Point(16, 39);
            this.mainDGV.Margin = new System.Windows.Forms.Padding(4);
            this.mainDGV.Name = "mainDGV";
            this.mainDGV.ReadOnly = true;
            this.mainDGV.Size = new System.Drawing.Size(418, 493);
            this.mainDGV.TabIndex = 41;
            this.mainDGV.SelectionChanged += new System.EventHandler(this.mainDGV_SelectionChanged);
            this.mainDGV.DoubleClick += new System.EventHandler(this.mainDGV_DoubleClick);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(323, 457);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(89, 28);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 36;
            this.label1.Text = "Размеры";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Размер";
            // 
            // sizeTB
            // 
            this.sizeTB.Location = new System.Drawing.Point(6, 54);
            this.sizeTB.Name = "sizeTB";
            this.sizeTB.Size = new System.Drawing.Size(131, 22);
            this.sizeTB.TabIndex = 12;
            // 
            // delButton
            // 
            this.delButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.delButton.Location = new System.Drawing.Point(442, 146);
            this.delButton.Margin = new System.Windows.Forms.Padding(4);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(125, 28);
            this.delButton.TabIndex = 39;
            this.delButton.Text = "Удалить";
            this.delButton.UseVisualStyleBackColor = true;
            this.delButton.Click += new System.EventHandler(this.delButton_Click);
            // 
            // editButton
            // 
            this.editButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editButton.Location = new System.Drawing.Point(442, 73);
            this.editButton.Margin = new System.Windows.Forms.Padding(4);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(125, 28);
            this.editButton.TabIndex = 38;
            this.editButton.Text = "Редактировать";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.Location = new System.Drawing.Point(442, 39);
            this.addButton.Margin = new System.Windows.Forms.Padding(4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(125, 28);
            this.addButton.TabIndex = 37;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // mainGB
            // 
            this.mainGB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainGB.Controls.Add(this.label2);
            this.mainGB.Controls.Add(this.altSizeTB);
            this.mainGB.Controls.Add(this.label3);
            this.mainGB.Controls.Add(this.sizeTB);
            this.mainGB.Controls.Add(this.OKButton);
            this.mainGB.Controls.Add(this.cancelButton);
            this.mainGB.Location = new System.Drawing.Point(16, 39);
            this.mainGB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainGB.Name = "mainGB";
            this.mainGB.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainGB.Size = new System.Drawing.Size(419, 493);
            this.mainGB.TabIndex = 40;
            this.mainGB.TabStop = false;
            this.mainGB.Text = "Карточка";
            // 
            // OKButton
            // 
            this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OKButton.Location = new System.Drawing.Point(226, 457);
            this.OKButton.Margin = new System.Windows.Forms.Padding(4);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(89, 28);
            this.OKButton.TabIndex = 11;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // mainName
            // 
            this.mainName.DataPropertyName = "name";
            this.mainName.HeaderText = "Название";
            this.mainName.Name = "mainName";
            this.mainName.ReadOnly = true;
            this.mainName.Width = 200;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "numeric";
            this.Column1.HeaderText = "Альтернативный размер";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Альернативный размер";
            // 
            // altSizeTB
            // 
            this.altSizeTB.Location = new System.Drawing.Point(3, 127);
            this.altSizeTB.Name = "altSizeTB";
            this.altSizeTB.Size = new System.Drawing.Size(134, 22);
            this.altSizeTB.TabIndex = 14;
            // 
            // SizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 545);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.mainGB);
            this.Controls.Add(this.mainDGV);
            this.Name = "SizeForm";
            this.Text = "Справочник \"Размеры\"";
            this.Load += new System.EventHandler(this.SizeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainDGV)).EndInit();
            this.mainGB.ResumeLayout(false);
            this.mainGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView mainDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn mainName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sizeTB;
        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.GroupBox mainGB;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox altSizeTB;
    }
}