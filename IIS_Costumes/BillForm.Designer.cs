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
            this.issueButton = new System.Windows.Forms.Button();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.headerLabel = new System.Windows.Forms.Label();
            this.mainDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.mainDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.Location = new System.Drawing.Point(607, 184);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(110, 23);
            this.deleteButton.TabIndex = 19;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // editButton
            // 
            this.editButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editButton.Location = new System.Drawing.Point(607, 97);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(110, 23);
            this.editButton.TabIndex = 17;
            this.editButton.Text = "Редактировать";
            this.editButton.UseVisualStyleBackColor = true;
            // 
            // issueButton
            // 
            this.issueButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.issueButton.Location = new System.Drawing.Point(607, 68);
            this.issueButton.Name = "issueButton";
            this.issueButton.Size = new System.Drawing.Size(110, 23);
            this.issueButton.TabIndex = 15;
            this.issueButton.Text = "Выдать костюмы";
            this.issueButton.UseVisualStyleBackColor = true;
            // 
            // searchTB
            // 
            this.searchTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTB.Location = new System.Drawing.Point(12, 42);
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(588, 20);
            this.searchTB.TabIndex = 14;
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
            this.mainDGV.AllowUserToResizeRows = false;
            this.mainDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainDGV.Location = new System.Drawing.Point(12, 68);
            this.mainDGV.Name = "mainDGV";
            this.mainDGV.ReadOnly = true;
            this.mainDGV.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mainDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.mainDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mainDGV.Size = new System.Drawing.Size(588, 330);
            this.mainDGV.TabIndex = 13;
            // 
            // BillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 410);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.issueButton);
            this.Controls.Add(this.searchTB);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.mainDGV);
            this.Name = "BillForm";
            this.Text = "Карнавальные костюмы - Счета";
            ((System.ComponentModel.ISupportInitialize)(this.mainDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button issueButton;
        private System.Windows.Forms.TextBox searchTB;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.DataGridView mainDGV;
    }
}