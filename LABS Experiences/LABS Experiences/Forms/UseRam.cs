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
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LABS_Experiences.Forms
{
    public partial class UseRam : Form
    {
        int counter = 0;
        int counter1 = 0;
        public UseRam()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            label3.Text = string.Format("Je compte : {0}", counter.ToString());
            if (pictureBox2.Image == Properties.Resources.Logo) // Si le logo est présent
            {
                pictureBox2.Image = null; // Pas d'image
            }
            else
            {
                pictureBox2.Image = Properties.Resources.Logo; // Image
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            counter1++;
            label4.Text = string.Format("Je compte également : {0}", counter1.ToString());
            label3.Left = (ClientSize.Width - label3.Width) / 2;
            label4.Left = (ClientSize.Width - label4.Width) / 2;
        }

        private void UseRam_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
        }
    }
}
