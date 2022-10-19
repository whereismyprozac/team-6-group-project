using System;

namespace Bar_Chart_Group_6_Team_Project
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtStore1 = new System.Windows.Forms.TextBox();
            this.txtStore2 = new System.Windows.Forms.TextBox();
            this.txtStore3 = new System.Windows.Forms.TextBox();
            this.txtStore4 = new System.Windows.Forms.TextBox();
            this.txtStore5 = new System.Windows.Forms.TextBox();
            this.txtAverage = new System.Windows.Forms.TextBox();
            this.txtMaximum = new System.Windows.Forms.TextBox();
            this.txtMinimum = new System.Windows.Forms.TextBox();
            this.btnBarChart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Store1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "&Store2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "&Store3";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "&Store4";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "&Store5";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "&Average";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 316);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "&Maximum";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 355);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "&Minimum";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtStore1
            // 
            this.txtStore1.Location = new System.Drawing.Point(121, 24);
            this.txtStore1.Name = "txtStore1";
            this.txtStore1.Size = new System.Drawing.Size(100, 20);
            this.txtStore1.TabIndex = 8;
            // 
            // txtStore2
            // 
            this.txtStore2.Location = new System.Drawing.Point(121, 62);
            this.txtStore2.Name = "txtStore2";
            this.txtStore2.Size = new System.Drawing.Size(100, 20);
            this.txtStore2.TabIndex = 9;
            // 
            // txtStore3
            // 
            this.txtStore3.Location = new System.Drawing.Point(121, 102);
            this.txtStore3.Name = "txtStore3";
            this.txtStore3.Size = new System.Drawing.Size(100, 20);
            this.txtStore3.TabIndex = 10;
            // 
            // txtStore4
            // 
            this.txtStore4.Location = new System.Drawing.Point(121, 139);
            this.txtStore4.Name = "txtStore4";
            this.txtStore4.Size = new System.Drawing.Size(100, 20);
            this.txtStore4.TabIndex = 11;
            // 
            // txtStore5
            // 
            this.txtStore5.Location = new System.Drawing.Point(121, 180);
            this.txtStore5.Name = "txtStore5";
            this.txtStore5.Size = new System.Drawing.Size(100, 20);
            this.txtStore5.TabIndex = 12;
            // 
            // txtAverage
            // 
            this.txtAverage.Location = new System.Drawing.Point(121, 277);
            this.txtAverage.Name = "txtAverage";
            this.txtAverage.ReadOnly = true;
            this.txtAverage.Size = new System.Drawing.Size(100, 20);
            this.txtAverage.TabIndex = 13;
            // 
            // txtMaximum
            // 
            this.txtMaximum.Location = new System.Drawing.Point(121, 316);
            this.txtMaximum.Name = "txtMaximum";
            this.txtMaximum.ReadOnly = true;
            this.txtMaximum.Size = new System.Drawing.Size(100, 20);
            this.txtMaximum.TabIndex = 14;
            // 
            // txtMinimum
            // 
            this.txtMinimum.Location = new System.Drawing.Point(121, 355);
            this.txtMinimum.Name = "txtMinimum";
            this.txtMinimum.ReadOnly = true;
            this.txtMinimum.Size = new System.Drawing.Size(100, 20);
            this.txtMinimum.TabIndex = 15;
            // 
            // btnBarChart
            // 
            this.btnBarChart.Location = new System.Drawing.Point(76, 223);
            this.btnBarChart.Name = "btnBarChart";
            this.btnBarChart.Size = new System.Drawing.Size(123, 23);
            this.btnBarChart.TabIndex = 16;
            this.btnBarChart.Text = "&Bar Chart";
            this.btnBarChart.UseVisualStyleBackColor = true;
            this.btnBarChart.Click += new System.EventHandler(this.btnBarChart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 404);
            this.Controls.Add(this.btnBarChart);
            this.Controls.Add(this.txtMinimum);
            this.Controls.Add(this.txtMaximum);
            this.Controls.Add(this.txtAverage);
            this.Controls.Add(this.txtStore5);
            this.Controls.Add(this.txtStore4);
            this.Controls.Add(this.txtStore3);
            this.Controls.Add(this.txtStore2);
            this.Controls.Add(this.txtStore1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Bar Chart";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtStore1;
        private System.Windows.Forms.TextBox txtStore2;
        private System.Windows.Forms.TextBox txtStore3;
        private System.Windows.Forms.TextBox txtStore4;
        private System.Windows.Forms.TextBox txtStore5;
        private System.Windows.Forms.TextBox txtAverage;
        private System.Windows.Forms.TextBox txtMaximum;
        private System.Windows.Forms.TextBox txtMinimum;
        private System.Windows.Forms.Button btnBarChart;

        public EventHandler Form1_Load { get; private set; }
    }
}

