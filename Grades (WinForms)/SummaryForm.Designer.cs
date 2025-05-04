namespace Grades__WinForms_
{
    partial class SummaryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SummaryForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TotalMarksTextBox = new System.Windows.Forms.TextBox();
            this.TotalMarksLabel = new System.Windows.Forms.Label();
            this.NumMarksTextBox = new System.Windows.Forms.TextBox();
            this.NumMarksLabel = new System.Windows.Forms.Label();
            this.AverageMarkTextBox = new System.Windows.Forms.TextBox();
            this.AverageMarkLabel = new System.Windows.Forms.Label();
            this.HighestMarkTextBox = new System.Windows.Forms.TextBox();
            this.HighestMarkLabel = new System.Windows.Forms.Label();
            this.LowestMarkTextBox = new System.Windows.Forms.TextBox();
            this.LowestMarkLabel = new System.Windows.Forms.Label();
            this.MainPageButton = new System.Windows.Forms.Button();
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
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Summary";
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
            // panel2
            // 
            this.panel2.Controls.Add(this.MainPageButton);
            this.panel2.Controls.Add(this.LowestMarkTextBox);
            this.panel2.Controls.Add(this.LowestMarkLabel);
            this.panel2.Controls.Add(this.HighestMarkTextBox);
            this.panel2.Controls.Add(this.HighestMarkLabel);
            this.panel2.Controls.Add(this.AverageMarkTextBox);
            this.panel2.Controls.Add(this.AverageMarkLabel);
            this.panel2.Controls.Add(this.TotalMarksTextBox);
            this.panel2.Controls.Add(this.TotalMarksLabel);
            this.panel2.Controls.Add(this.NumMarksTextBox);
            this.panel2.Controls.Add(this.NumMarksLabel);
            this.panel2.Location = new System.Drawing.Point(12, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(321, 309);
            this.panel2.TabIndex = 3;
            // 
            // TotalMarksTextBox
            // 
            this.TotalMarksTextBox.Enabled = false;
            this.TotalMarksTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalMarksTextBox.Location = new System.Drawing.Point(230, 67);
            this.TotalMarksTextBox.Name = "TotalMarksTextBox";
            this.TotalMarksTextBox.Size = new System.Drawing.Size(64, 29);
            this.TotalMarksTextBox.TabIndex = 3;
            // 
            // TotalMarksLabel
            // 
            this.TotalMarksLabel.AutoSize = true;
            this.TotalMarksLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalMarksLabel.Location = new System.Drawing.Point(16, 72);
            this.TotalMarksLabel.Name = "TotalMarksLabel";
            this.TotalMarksLabel.Size = new System.Drawing.Size(106, 24);
            this.TotalMarksLabel.TabIndex = 2;
            this.TotalMarksLabel.Text = "Total Marks";
            // 
            // NumMarksTextBox
            // 
            this.NumMarksTextBox.Enabled = false;
            this.NumMarksTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumMarksTextBox.Location = new System.Drawing.Point(230, 23);
            this.NumMarksTextBox.Name = "NumMarksTextBox";
            this.NumMarksTextBox.Size = new System.Drawing.Size(64, 29);
            this.NumMarksTextBox.TabIndex = 1;
            // 
            // NumMarksLabel
            // 
            this.NumMarksLabel.AutoSize = true;
            this.NumMarksLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumMarksLabel.Location = new System.Drawing.Point(16, 28);
            this.NumMarksLabel.Name = "NumMarksLabel";
            this.NumMarksLabel.Size = new System.Drawing.Size(106, 24);
            this.NumMarksLabel.TabIndex = 0;
            this.NumMarksLabel.Text = "Num Marks";
            // 
            // AverageMarkTextBox
            // 
            this.AverageMarkTextBox.Enabled = false;
            this.AverageMarkTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AverageMarkTextBox.Location = new System.Drawing.Point(230, 112);
            this.AverageMarkTextBox.Name = "AverageMarkTextBox";
            this.AverageMarkTextBox.Size = new System.Drawing.Size(64, 29);
            this.AverageMarkTextBox.TabIndex = 5;
            // 
            // AverageMarkLabel
            // 
            this.AverageMarkLabel.AutoSize = true;
            this.AverageMarkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AverageMarkLabel.Location = new System.Drawing.Point(16, 117);
            this.AverageMarkLabel.Name = "AverageMarkLabel";
            this.AverageMarkLabel.Size = new System.Drawing.Size(136, 24);
            this.AverageMarkLabel.TabIndex = 4;
            this.AverageMarkLabel.Text = "Average Marks";
            // 
            // HighestMarkTextBox
            // 
            this.HighestMarkTextBox.Enabled = false;
            this.HighestMarkTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HighestMarkTextBox.Location = new System.Drawing.Point(230, 158);
            this.HighestMarkTextBox.Name = "HighestMarkTextBox";
            this.HighestMarkTextBox.Size = new System.Drawing.Size(64, 29);
            this.HighestMarkTextBox.TabIndex = 7;
            // 
            // HighestMarkLabel
            // 
            this.HighestMarkLabel.AutoSize = true;
            this.HighestMarkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HighestMarkLabel.Location = new System.Drawing.Point(15, 163);
            this.HighestMarkLabel.Name = "HighestMarkLabel";
            this.HighestMarkLabel.Size = new System.Drawing.Size(120, 24);
            this.HighestMarkLabel.TabIndex = 6;
            this.HighestMarkLabel.Text = "Highest Mark";
            // 
            // LowestMarkTextBox
            // 
            this.LowestMarkTextBox.Enabled = false;
            this.LowestMarkTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LowestMarkTextBox.Location = new System.Drawing.Point(230, 206);
            this.LowestMarkTextBox.Name = "LowestMarkTextBox";
            this.LowestMarkTextBox.Size = new System.Drawing.Size(64, 29);
            this.LowestMarkTextBox.TabIndex = 9;
            // 
            // LowestMarkLabel
            // 
            this.LowestMarkLabel.AutoSize = true;
            this.LowestMarkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LowestMarkLabel.Location = new System.Drawing.Point(16, 211);
            this.LowestMarkLabel.Name = "LowestMarkLabel";
            this.LowestMarkLabel.Size = new System.Drawing.Size(115, 24);
            this.LowestMarkLabel.TabIndex = 8;
            this.LowestMarkLabel.Text = "Lowest Mark";
            // 
            // MainPageButton
            // 
            this.MainPageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainPageButton.Location = new System.Drawing.Point(99, 267);
            this.MainPageButton.Name = "MainPageButton";
            this.MainPageButton.Size = new System.Drawing.Size(115, 26);
            this.MainPageButton.TabIndex = 10;
            this.MainPageButton.Text = "Main Page";
            this.MainPageButton.UseVisualStyleBackColor = true;
            this.MainPageButton.Click += new System.EventHandler(this.MainPageButton_Click);
            // 
            // SummaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(344, 421);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SummaryForm";
            this.Text = "Summary Form";
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label NumMarksLabel;
        private System.Windows.Forms.TextBox NumMarksTextBox;
        private System.Windows.Forms.TextBox TotalMarksTextBox;
        private System.Windows.Forms.Label TotalMarksLabel;
        private System.Windows.Forms.TextBox AverageMarkTextBox;
        private System.Windows.Forms.Label AverageMarkLabel;
        private System.Windows.Forms.Button MainPageButton;
        private System.Windows.Forms.TextBox LowestMarkTextBox;
        private System.Windows.Forms.Label LowestMarkLabel;
        private System.Windows.Forms.TextBox HighestMarkTextBox;
        private System.Windows.Forms.Label HighestMarkLabel;
    }
}