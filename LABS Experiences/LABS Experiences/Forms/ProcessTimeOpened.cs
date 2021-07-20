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
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LABS_Experiences.Forms
{
	public partial class ProcessTimeOpened : LABSForm
	{
		int secondsRunned = 0;
		public ProcessTimeOpened()
		{
			InitializeComponent();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			if (IsProcessRunning(textBox1.Text))
			{
				secondsRunned++;
				label3.Text = $"Time Opened (s): {secondsRunned}";
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			timer1.Start();
		}

		static bool IsProcessRunning(string procName)
		{
			Process[] pName = Process.GetProcessesByName(procName);
			if (pName.Length == 0)
			{
				return false;
			}
			else
			{
				return true;
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Process.Start(textBox1.Text, textBox2.Text);
		}
	}
}
