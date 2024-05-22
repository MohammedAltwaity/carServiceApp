namespace VLDGY0
{
    partial class Payment
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.worksheetCount = new System.Windows.Forms.Label();
            this.workCount = new System.Windows.Forms.Label();
            this.materialCost = new System.Windows.Forms.Label();
            this.serviceCost = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = " worksheets count";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Work count";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Material cost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Service cost";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Total";
            // 
            // worksheetCount
            // 
            this.worksheetCount.AutoSize = true;
            this.worksheetCount.Location = new System.Drawing.Point(139, 22);
            this.worksheetCount.Name = "worksheetCount";
            this.worksheetCount.Size = new System.Drawing.Size(0, 13);
            this.worksheetCount.TabIndex = 5;
            // 
            // workCount
            // 
            this.workCount.AutoSize = true;
            this.workCount.Location = new System.Drawing.Point(139, 52);
            this.workCount.Name = "workCount";
            this.workCount.Size = new System.Drawing.Size(0, 13);
            this.workCount.TabIndex = 6;
            // 
            // materialCost
            // 
            this.materialCost.AutoSize = true;
            this.materialCost.Location = new System.Drawing.Point(139, 82);
            this.materialCost.Name = "materialCost";
            this.materialCost.Size = new System.Drawing.Size(0, 13);
            this.materialCost.TabIndex = 7;
            // 
            // serviceCost
            // 
            this.serviceCost.AutoSize = true;
            this.serviceCost.Location = new System.Drawing.Point(139, 111);
            this.serviceCost.Name = "serviceCost";
            this.serviceCost.Size = new System.Drawing.Size(0, 13);
            this.serviceCost.TabIndex = 8;
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Location = new System.Drawing.Point(133, 142);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(0, 13);
            this.total.TabIndex = 9;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 185);
            this.Controls.Add(this.total);
            this.Controls.Add(this.serviceCost);
            this.Controls.Add(this.materialCost);
            this.Controls.Add(this.workCount);
            this.Controls.Add(this.worksheetCount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Payment";
            this.Text = "Payment";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Payment_FormClosing);
            this.Load += new System.EventHandler(this.Payment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label worksheetCount;
        private System.Windows.Forms.Label workCount;
        private System.Windows.Forms.Label materialCost;
        private System.Windows.Forms.Label serviceCost;
        private System.Windows.Forms.Label total;
    }
}