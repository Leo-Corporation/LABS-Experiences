﻿/*
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
using LeoCorpLibrary.Enums;
using LeoCorpLibrary.UI;
using System;
using System.Windows.Forms;

namespace LABS_Experiences.Forms;

public partial class LeoCorpLibraryUI : LABSForm
{
    public LeoCorpLibraryUI()
    {
        InitializeComponent();
        timer1.Start();
    }

    private void button3_Click(object sender, EventArgs e)
    {
        WinFormsHelpers.CenterControlOnForm(label3, this, ControlAlignement.Horizontal);

    }

    private void button2_Click(object sender, EventArgs e)
    {
        WinFormsHelpers.CenterControlOnForm(label3, this,  ControlAlignement.Vertical);
    }

    private void button1_Click(object sender, EventArgs e)
    {
        WinFormsHelpers.CenterControlOnForm(label3, this);
    }

    private void button11_Click(object sender, EventArgs e)
    {
        WinFormsHelpers.CenterFormOnScreen(this);
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
        label4.Text = $"Mouse position: X: {Env.GetMouseCursorPosition().X}; Y: {Env.GetMouseCursorPosition().Y}";
    }

    private void button4_Click(object sender, EventArgs e)
    {
        double dpi = ScreenHelpers.GetScreenDPIFromWinForm(this);
        double scale = ScreenHelpers.GetScreenScalingFromWinForm(this);

        MessageBox.Show($"DPI: {dpi}\nScale: {scale}%");
    }
}
