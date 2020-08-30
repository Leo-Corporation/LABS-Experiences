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
using LABS_Experiences.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LABS_Experiences
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Forms.LeoCorpLibraryForm().Show(); // Ouvrir la fenêtre de l'expérience
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label4.Text = string.Format("© {0} Léo Corporation", DateTime.Now.Year.ToString()); // Mettre à jour le copyright
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new AboutForm().Show(); // Ouvrir la fenêtre "A propos"
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new ClearRamCache().Show(); // Afficher l'expérience
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new AsyncAwait().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CursorWindow cursorWindow = new CursorWindow();
            cursorWindow.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new LABS_XML().Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new ProcessTimeOpened().Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new GetFileIcon().Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new HasFilePermission().Show();
        }
    }
}
