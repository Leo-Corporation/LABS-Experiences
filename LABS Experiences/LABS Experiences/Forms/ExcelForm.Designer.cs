﻿
namespace LABS_Experiences.Forms
{
	partial class ExcelForm
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
			this.button34 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// button34
			// 
			this.button34.BackColor = System.Drawing.Color.MediumSlateBlue;
			this.button34.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button34.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button34.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.button34.ForeColor = System.Drawing.Color.White;
			this.button34.Location = new System.Drawing.Point(471, 97);
			this.button34.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.button34.Name = "button34";
			this.button34.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.button34.Size = new System.Drawing.Size(220, 39);
			this.button34.TabIndex = 31;
			this.button34.Text = "Create Workbook";
			this.button34.UseVisualStyleBackColor = false;
			this.button34.Click += new System.EventHandler(this.button34_Click);
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.textBox1.Location = new System.Drawing.Point(13, 103);
			this.textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(450, 29);
			this.textBox1.TabIndex = 32;
			// 
			// ExcelForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.button34);
			this.Description = "Excel experimental stuff.";
			this.Name = "ExcelForm";
			this.Text = "Excel - LABS Experiences";
			this.Title = "Excel";
			this.Controls.SetChildIndex(this.button34, 0);
			this.Controls.SetChildIndex(this.textBox1, 0);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button34;
		private System.Windows.Forms.TextBox textBox1;
	}
}