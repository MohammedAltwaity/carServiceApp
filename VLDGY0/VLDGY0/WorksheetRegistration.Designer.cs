namespace VLDGY0
{
    partial class WorksheetRegistration
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialCostLabel = new System.Windows.Forms.Label();
            this.materialCostValue = new System.Windows.Forms.Label();
            this.timeCostLabel = new System.Windows.Forms.Label();
            this.timeCostValue = new System.Windows.Forms.Label();
            this.registrationButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoScrollMargin = new System.Drawing.Size(1, 1);
            this.panel1.AutoScrollMinSize = new System.Drawing.Size(1, 1);
            this.panel1.Location = new System.Drawing.Point(12, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(737, 285);
            this.panel1.TabIndex = 0;
            // 
            // materialCostLabel
            // 
            this.materialCostLabel.AutoSize = true;
            this.materialCostLabel.Location = new System.Drawing.Point(29, 390);
            this.materialCostLabel.Name = "materialCostLabel";
            this.materialCostLabel.Size = new System.Drawing.Size(72, 13);
            this.materialCostLabel.TabIndex = 1;
            this.materialCostLabel.Text = "Materila costs";
            this.materialCostLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // materialCostValue
            // 
            this.materialCostValue.AutoSize = true;
            this.materialCostValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.materialCostValue.Location = new System.Drawing.Point(124, 390);
            this.materialCostValue.Name = "materialCostValue";
            this.materialCostValue.Size = new System.Drawing.Size(29, 13);
            this.materialCostValue.TabIndex = 2;
            this.materialCostValue.Text = "0 FT";
            this.materialCostValue.Click += new System.EventHandler(this.materialCostValue_Click);
            // 
            // timeCostLabel
            // 
            this.timeCostLabel.AutoSize = true;
            this.timeCostLabel.Location = new System.Drawing.Point(272, 390);
            this.timeCostLabel.Name = "timeCostLabel";
            this.timeCostLabel.Size = new System.Drawing.Size(58, 13);
            this.timeCostLabel.TabIndex = 3;
            this.timeCostLabel.Text = "Time costs";
            // 
            // timeCostValue
            // 
            this.timeCostValue.AutoSize = true;
            this.timeCostValue.ForeColor = System.Drawing.Color.Red;
            this.timeCostValue.Location = new System.Drawing.Point(366, 390);
            this.timeCostValue.Name = "timeCostValue";
            this.timeCostValue.Size = new System.Drawing.Size(29, 13);
            this.timeCostValue.TabIndex = 5;
            this.timeCostValue.Text = "0 FT";
            this.timeCostValue.Click += new System.EventHandler(this.label2_Click);
            // 
            // registrationButton
            // 
            this.registrationButton.Location = new System.Drawing.Point(640, 385);
            this.registrationButton.Name = "registrationButton";
            this.registrationButton.Size = new System.Drawing.Size(75, 23);
            this.registrationButton.TabIndex = 6;
            this.registrationButton.Text = "Register";
            this.registrationButton.UseVisualStyleBackColor = true;
            this.registrationButton.Click += new System.EventHandler(this.registrationButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Material cost";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(609, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Total";
            // 
            // WorksheetRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 423);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.registrationButton);
            this.Controls.Add(this.timeCostValue);
            this.Controls.Add(this.timeCostLabel);
            this.Controls.Add(this.materialCostValue);
            this.Controls.Add(this.materialCostLabel);
            this.Controls.Add(this.panel1);
            this.Name = "WorksheetRegistration";
            this.Text = "Worksheet registration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WorksheetRegistration_FormClosing);
            this.Load += new System.EventHandler(this.WorksheetRegistration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label materialCostLabel;
        private System.Windows.Forms.Label materialCostValue;
        private System.Windows.Forms.Label timeCostLabel;
        private System.Windows.Forms.Label timeCostValue;
        private System.Windows.Forms.Button registrationButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}