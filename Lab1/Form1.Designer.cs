﻿namespace Lab1
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
            this.restaurantsGV = new System.Windows.Forms.DataGridView();
            this.cooksGV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantsGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cooksGV)).BeginInit();
            this.SuspendLayout();
            // 
            // restaurantsGV
            // 
            this.restaurantsGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.restaurantsGV.Location = new System.Drawing.Point(12, 71);
            this.restaurantsGV.Name = "restaurantsGV";
            this.restaurantsGV.RowTemplate.Height = 24;
            this.restaurantsGV.Size = new System.Drawing.Size(469, 476);
            this.restaurantsGV.TabIndex = 0;
            // 
            // cooksGV
            // 
            this.cooksGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cooksGV.Location = new System.Drawing.Point(487, 71);
            this.cooksGV.Name = "cooksGV";
            this.cooksGV.RowTemplate.Height = 24;
            this.cooksGV.Size = new System.Drawing.Size(862, 476);
            this.cooksGV.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Restaurants";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(895, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 38);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cooks";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(257, 553);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(809, 55);
            this.button1.TabIndex = 4;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 620);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cooksGV);
            this.Controls.Add(this.restaurantsGV);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.restaurantsGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cooksGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView restaurantsGV;
        private System.Windows.Forms.DataGridView cooksGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

