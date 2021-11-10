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
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LABS_Experiences.Forms;

public partial class TextDownloader : LABSForm
{
    public TextDownloader()
    {
        InitializeComponent();
    }

    private void button2_Click(object sender, EventArgs e)
    {
        /*Task<string> task = new Task<string>(DownloadString);
        task.Start();
        label3.Text = await task;*/
        Thread thread = new(DownloadStringVoid);
        thread.Start();
    }

    private string DownloadString()
    {
        string res = "";
        Task.Run(() =>
        {
            Thread.Sleep(2000);
            res = new WebClient().DownloadString("https://raw.githubusercontent.com/Leo-Corporation/LeoCorp-Docs/master/Liens/Update%20System/Educ'Maths%204.0/Dev/Download.txt");
        });
        return res;
    }

    private void DownloadStringVoid()
    {
        Thread.Sleep(2000);
        Invoke(new MethodInvoker(delegate ()
        {
            label3.Text = new WebClient().DownloadString("https://raw.githubusercontent.com/Leo-Corporation/LeoCorp-Docs/master/Liens/Update%20System/Educ'Maths%204.0/Dev/Download.txt");
        }));

    }
}
