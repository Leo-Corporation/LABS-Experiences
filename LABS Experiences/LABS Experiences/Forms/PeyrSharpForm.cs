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
using PeyrSharp.Enums;
using PeyrSharp.Env;
using PeyrSharp.Extensions;
using System;
using System.Windows.Forms;

namespace LABS_Experiences.Forms;
public partial class PeyrSharpForm : LABSForm
{
	public PeyrSharpForm()
	{
		InitializeComponent();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		MessageBox.Show(FileSys.GetTotalSpace(@"C:\", StorageUnits.Gigabyte).ToString());
	}

	private void button2_Click(object sender, EventArgs e)
	{
		MessageBox.Show(FileSys.GetAvailableSpace(@"C:\", StorageUnits.Gigabyte).ToString());
	}

	private void button3_Click(object sender, EventArgs e)
	{
		MessageBox.Show(FileSys.GetOccupiedSpace(@"C:\", StorageUnits.Gigabyte).ToString());
	}

	private void button25_Click(object sender, EventArgs e)
	{
		MessageBox.Show(Sys.CurrentOperatingSystem.ToString());
	}

	private void button14_Click(object sender, EventArgs e)
	{
		MessageBox.Show(Sys.CurrentWindowsVersion.ToString());
	}

	private void button15_Click(object sender, EventArgs e)
	{
		Sys.ExecuteAsAdmin(@"C:\Windows\System32\cmd.exe");
	}

	private void button17_Click(object sender, EventArgs e)
	{
		MessageBox.Show(Sys.UnixTime.ToString());
	}

	private void button24_Click(object sender, EventArgs e)
	{
		int number = 1;
		double div = number.ToDouble() / 2;
		string sentence = "Hello, this is a test sentence to see if the word counter in LeoCorpLibrary is working properly!!";

		int[] numbers = { 1, 5, 6, 4, 8 };
		int[] append = numbers.Append(10, 8, 9);
		string strNumbers = "";
		string strAppend = "";
		for (int i = 0; i < numbers.Length; i++)
		{
			strNumbers += numbers[i] + " ";
		}

		for (int i = 0; i < append.Length; i++)
		{
			strAppend += append[i] + " ";
		}

		int[] numbers1 = { 1, 2, 5, 6, 7, 8 };
		int[] remove = numbers1.RemoveElement(7, 2, 3);
		string strNumbers1 = "";
		string strRemove = "";

		for (int i = 0; i < numbers1.Length; i++)
		{
			strNumbers1 += numbers1[i] + " ";
		}

		for (int i = 0; i < remove.Length; i++)
		{
			strRemove += remove[i] + " ";
		}
		MessageBox.Show($"{div}\n{number / 2}");
		MessageBox.Show(number.IsEven().ToString());
		MessageBox.Show(sentence.CountWords().ToString());
		MessageBox.Show($"Numbers: {strNumbers}\nAppend numbers: {strAppend}");
		MessageBox.Show($"Numbers: {strNumbers1}\nRemove numbers: {strRemove}");
	}

	private void button22_Click(object sender, EventArgs e)
	{
		MessageBox.Show(FileSys.AppDataPath);
	}
}
