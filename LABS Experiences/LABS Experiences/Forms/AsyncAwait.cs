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
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LABS_Experiences.Forms;

public partial class AsyncAwait : LABSForm
{
    public AsyncAwait()
    {
        InitializeComponent();
    }

    private void button2_Click(object sender, EventArgs e)
    {
        new TextDownloader().Show();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        new GetLastVersionAsync().Show();
    }

    private async void button3_Click(object sender, EventArgs e)
    {
        bool res = await IsInternetAvailable();
        MessageBox.Show(res.ToString());
    }

    internal Task<bool> IsInternetAvailable()
    {
        Task<bool> task = new(() => Internet("a"));
        task.Start();
        return task;
    }

    private bool Internet(string a)
    {
        try
        {
            using (var client = new WebClient()) // Navigateur Internet
            using (var stream = client.OpenRead("https://www.bing.com")) // Ouvrir bing.com
            {
                return true; // Si la page s'ouvre = connexion OK
            }
        }
        catch
        {
            return false; // Si la page ne s'ouvre pas = connexion down
        }
    }

    private async void button4_Click(object sender, EventArgs e)
    {
        MessageBox.Show(await GeneratePassword(10000, "a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z,1,2,3,4,5,6,7,8,9,0", ","));
    }

    private Task<string> GeneratePassword(int lenght, string chars, string separator)
    {
        Task<string> task = new(() => Password.Generate(lenght, chars, separator));
        task.Start();
        return task;
    }

	private async void button5_Click(object sender, EventArgs e)
	{
        await DownloadAsync(new("https://raw.githubusercontent.com/Leo-Corporation/LeoCorp-Docs/master/Liens/Update%20System/Datalya/Datalya.zip"), @"D:\Datalya.zip");
	}

    public static async Task DownloadAsync(Uri uri, string filePath)
    {
        using (var s = await new System.Net.Http.HttpClient().GetStreamAsync(uri))
        {
            using (var fs = new FileStream(filePath, FileMode.CreateNew))
            {
                await s.CopyToAsync(fs);
            }
        }
    }
}
