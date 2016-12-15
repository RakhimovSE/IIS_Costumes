namespace IIS_Costumes
{
    partial class TakeCostumeForm
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
            this.returndateLabel = new System.Windows.Forms.Label();
            this.returndateDTP = new System.Windows.Forms.DateTimePicker();
            this.deptTB = new System.Windows.Forms.TextBox();
            this.deptLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(12, 99);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(123, 23);
            this.OKButton.TabIndex = 0;
            this.OKButton.Text = "Принять";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // returndateLabel
            // 
            this.returndateLabel.AutoSize = true;
            this.returndateLabel.Location = new System.Drawing.Point(9, 9);
            this.returndateLabel.Name = "returndateLabel";
            this.returndateLabel.Size = new System.Drawing.Size(83, 13);
            this.returndateLabel.TabIndex = 1;
            this.returndateLabel.Text = "Дата возврата";
            // 
            // returndateDTP
            // 
            this.returndateDTP.Location = new System.Drawing.Point(12, 25);
            this.returndateDTP.Name = "returndateDTP";
            this.returndateDTP.Size = new System.Drawing.Size(123, 20);
            this.returndateDTP.TabIndex = 2;
            // 
            // deptTB
            // 
            this.deptTB.Location = new System.Drawing.Point(12, 73);
            this.deptTB.Name = "deptTB";
            this.deptTB.Size = new System.Drawing.Size(65, 20);
            this.deptTB.TabIndex = 3;
            this.deptTB.Text = "300";
            // 
            // deptLabel
            // 
            this.deptLabel.AutoSize = true;
            this.deptLabel.Location = new System.Drawing.Point(9, 57);
            this.deptLabel.Name = "deptLabel";
            this.deptLabel.Size = new System.Drawing.Size(131, 13);
            this.deptLabel.TabIndex = 4;
            this.deptLabel.Text = "Цена просрочки на день";
            // 
            // TakeCostumeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(147, 129);
            this.Controls.Add(this.deptLabel);
            this.Controls.Add(this.deptTB);
            this.Controls.Add(this.returndateDTP);
            this.Controls.Add(this.returndateLabel);
            this.Controls.Add(this.OKButton);
            this.MaximizeBox = false;
            this.Name = "TakeCostumeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.TakeCostumeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Label returndateLabel;
        private System.Windows.Forms.DateTimePicker returndateDTP;
        private System.Windows.Forms.TextBox deptTB;
        private System.Windows.Forms.Label deptLabel;
    }
}