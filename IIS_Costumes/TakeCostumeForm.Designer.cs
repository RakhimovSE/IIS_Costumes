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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(16, 122);
            this.OKButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(164, 28);
            this.OKButton.TabIndex = 0;
            this.OKButton.Text = "Принять";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // returndateLabel
            // 
            this.returndateLabel.AutoSize = true;
            this.returndateLabel.Location = new System.Drawing.Point(12, 11);
            this.returndateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.returndateLabel.Name = "returndateLabel";
            this.returndateLabel.Size = new System.Drawing.Size(106, 17);
            this.returndateLabel.TabIndex = 1;
            this.returndateLabel.Text = "Дата возврата";
            // 
            // returndateDTP
            // 
            this.returndateDTP.Location = new System.Drawing.Point(16, 31);
            this.returndateDTP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.returndateDTP.Name = "returndateDTP";
            this.returndateDTP.Size = new System.Drawing.Size(163, 22);
            this.returndateDTP.TabIndex = 2;
            // 
            // deptTB
            // 
            this.deptTB.Location = new System.Drawing.Point(16, 90);
            this.deptTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deptTB.Name = "deptTB";
            this.deptTB.Size = new System.Drawing.Size(85, 22);
            this.deptTB.TabIndex = 3;
            this.deptTB.Text = "300";
            // 
            // deptLabel
            // 
            this.deptLabel.AutoSize = true;
            this.deptLabel.Location = new System.Drawing.Point(12, 70);
            this.deptLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.deptLabel.Name = "deptLabel";
            this.deptLabel.Size = new System.Drawing.Size(172, 17);
            this.deptLabel.TabIndex = 4;
            this.deptLabel.Text = "Цена просрочки на день";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "руб.";
            // 
            // TakeCostumeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 159);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deptLabel);
            this.Controls.Add(this.deptTB);
            this.Controls.Add(this.returndateDTP);
            this.Controls.Add(this.returndateLabel);
            this.Controls.Add(this.OKButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Label label1;
    }
}