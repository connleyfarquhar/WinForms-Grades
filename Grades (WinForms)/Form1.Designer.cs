namespace Grades__WinForms_
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddGradeTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ShowSummaryButton = new System.Windows.Forms.Button();
            this.AddGradeButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 82);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Grades";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grade Summary App";
            // 
            // AddGradeTextBox
            // 
            this.AddGradeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddGradeTextBox.Location = new System.Drawing.Point(19, 23);
            this.AddGradeTextBox.Name = "AddGradeTextBox";
            this.AddGradeTextBox.Size = new System.Drawing.Size(110, 44);
            this.AddGradeTextBox.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ClearButton);
            this.panel2.Controls.Add(this.ShowSummaryButton);
            this.panel2.Controls.Add(this.AddGradeButton);
            this.panel2.Controls.Add(this.AddGradeTextBox);
            this.panel2.Location = new System.Drawing.Point(12, 109);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(321, 289);
            this.panel2.TabIndex = 2;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(163, 189);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(136, 44);
            this.ClearButton.TabIndex = 4;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ShowSummaryButton
            // 
            this.ShowSummaryButton.Location = new System.Drawing.Point(163, 104);
            this.ShowSummaryButton.Name = "ShowSummaryButton";
            this.ShowSummaryButton.Size = new System.Drawing.Size(136, 44);
            this.ShowSummaryButton.TabIndex = 3;
            this.ShowSummaryButton.Text = "Show Summary";
            this.ShowSummaryButton.UseVisualStyleBackColor = true;
            this.ShowSummaryButton.Click += new System.EventHandler(this.ShowSummaryButton_Click);
            // 
            // AddGradeButton
            // 
            this.AddGradeButton.Location = new System.Drawing.Point(163, 23);
            this.AddGradeButton.Name = "AddGradeButton";
            this.AddGradeButton.Size = new System.Drawing.Size(136, 44);
            this.AddGradeButton.TabIndex = 2;
            this.AddGradeButton.Text = "Add";
            this.AddGradeButton.UseVisualStyleBackColor = true;
            this.AddGradeButton.Click += new System.EventHandler(this.AddGradeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(344, 421);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Grade Summary App";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AddGradeTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ShowSummaryButton;
        private System.Windows.Forms.Button AddGradeButton;
        private System.Windows.Forms.Button ClearButton;
    }
}

