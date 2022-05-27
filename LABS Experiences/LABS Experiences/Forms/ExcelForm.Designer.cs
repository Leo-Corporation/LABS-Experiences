/*
MIT License

Copyright (c) Léo Corporation

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE. 
*/
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExcelForm));
            this.button34 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button34
            // 
            this.button34.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.button34.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button34.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button34.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button34.ForeColor = System.Drawing.Color.White;
            this.button34.Location = new System.Drawing.Point(13, 97);
            this.button34.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button34.Name = "button34";
            this.button34.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button34.Size = new System.Drawing.Size(220, 39);
            this.button34.TabIndex = 31;
            this.button34.Text = "Create Workbook";
            this.button34.UseVisualStyleBackColor = false;
            this.button34.Click += new System.EventHandler(this.button34_Click);
            // 
            // ExcelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button34);
            this.Description = "Excel experimental stuff.";
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ExcelForm";
            this.Text = "Excel - LABS Experiences";
            this.Title = "Excel";
            this.Controls.SetChildIndex(this.button34, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button34;
    }
}