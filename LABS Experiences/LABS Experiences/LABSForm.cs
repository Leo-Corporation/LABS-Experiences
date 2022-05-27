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
using System.Windows.Forms;

namespace LABS_Experiences;

public class LABSForm : Form
{
    private Panel panel1;
    private PictureBox pictureBox1;
    private Label label2;
    private Label label1;
    private string _title = "LABS Form";
    private string _description = "Description";

    public string Title
    {
        get
        {
            return _title;
        }

        set
        {
            _title = value; label1.Text = value; Text = value + " | Labs Experiences";
        }

    }

    public string Description
    {
        get
        {
            return _description;
        }
        set
        {
            _description = value; label2.Text = value;
        }
    }

    public LABSForm()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new(typeof(LABSForm));
        this.panel1 = new System.Windows.Forms.Panel();
        this.label2 = new System.Windows.Forms.Label();
        this.label1 = new System.Windows.Forms.Label();
        this.pictureBox1 = new System.Windows.Forms.PictureBox();
        this.panel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
        this.SuspendLayout();
        // 
        // panel1
        // 
        this.panel1.Controls.Add(this.pictureBox1);
        this.panel1.Controls.Add(this.label2);
        this.panel1.Controls.Add(this.label1);
        this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
        this.panel1.Location = new System.Drawing.Point(0, 0);
        this.panel1.Name = "panel1";
        this.panel1.Size = new System.Drawing.Size(446, 82);
        this.panel1.TabIndex = 2;
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.label2.Location = new System.Drawing.Point(84, 50);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(78, 19);
        this.label2.TabIndex = 0;
        this.label2.Text = "Description";
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
        this.label1.Location = new System.Drawing.Point(81, 13);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(75, 37);
        this.label1.TabIndex = 0;
        this.label1.Text = "Title";
        // 
        // pictureBox1
        // 
        this.pictureBox1.Image = global::LABS_Experiences.Properties.Resources.LABS_Logo;
        this.pictureBox1.Location = new System.Drawing.Point(7, 6);
        this.pictureBox1.Name = "pictureBox1";
        this.pictureBox1.Size = new System.Drawing.Size(70, 70);
        this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        this.pictureBox1.TabIndex = 1;
        this.pictureBox1.TabStop = false;
        // 
        // LABSForm
        // 
        this.BackColor = System.Drawing.Color.FromArgb(((byte)(0)), ((byte)(0)), (byte)(20));
        this.ForeColor = System.Drawing.Color.White;
        this.ClientSize = new System.Drawing.Size(446, 368);
        this.Controls.Add(this.panel1);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        this.MaximizeBox = false;
        this.Name = "LABSForm";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = " | LABS Experiences";
        this.panel1.ResumeLayout(false);
        this.panel1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
        this.ResumeLayout(false);

    }
}
