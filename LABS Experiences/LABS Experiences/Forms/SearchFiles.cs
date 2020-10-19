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
using LeoCorpLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LABS_Experiences.Forms
{
    public partial class SearchFiles : LABSForm
    {
        public SearchFiles()
        {
            InitializeComponent();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            //string res = SearchFolder("Name", textBox2.Text);

            SearchFile(textBox1.Text, textBox2.Text);
        }

        private string SearchFolder(string name, string path, SearchOption searchOption = SearchOption.AllDirectories)
        {
            string result = "";
            int count = 0;
            foreach (string folder in Directory.GetDirectories(path, name, searchOption))
            {
                result = folder;
                count++;
            }

            return result;
        }

        private void SearchFile(string fileName, string directory, SearchOption searchOption = SearchOption.AllDirectories)
        {
            foreach (string file in Directory.GetFiles(directory, fileName, searchOption))
            {
                listBox1.Items.Add(file);
            }
        }
    }
}
