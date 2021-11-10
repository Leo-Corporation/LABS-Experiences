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
using System.Windows.Forms;

namespace LABS_Experiences.Forms;

public partial class ListViewSaveLoad : Form
{
    public ListViewSaveLoad()
    {
        InitializeComponent();
    }

    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        Save.ListViewContentCustom(listView1, Application.StartupPath + "/test.txt");
    }

    private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        LeoCorpLibrary.Load.ListViewContentCustom(listView1, Application.StartupPath + "/test.txt");
    }

    private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        listView1.Items.Clear();
    }

    private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        Save.ListViewContentXML(listView1, Application.StartupPath + "/test.xml");
    }

    private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        LeoCorpLibrary.Load.ListViewContentXML(listView1, Application.StartupPath + "/test.xml");
    }

    private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        Save.ListViewContentJSON(listView1, Application.StartupPath + "/test.json");
    }

    private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        LeoCorpLibrary.Load.ListViewContentJSON(listView1, Application.StartupPath + "/test.json");
    }
}
