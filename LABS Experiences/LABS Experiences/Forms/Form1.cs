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
using LABS_Experiences.Forms;
using Microsoft.Win32;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LABS_Experiences;

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
        CursorWindow cursorWindow = new();
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

    private void button9_Click(object sender, EventArgs e)
    {
        new LeoCorpLibraryUI().Show();
    }

    private void button10_Click(object sender, EventArgs e)
    {
        new SearchFiles().Show();
    }

    private void button11_Click(object sender, EventArgs e)
    {
        string RegistryKey = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Themes\Personalize";
        int theme = (int)Registry.GetValue(RegistryKey, "SystemUsesLightTheme", string.Empty);

        if (theme != 0)
        {
            MessageBox.Show("You use light theme");
        }
        else
        {
            MessageBox.Show("You use dark theme");
        }
    }

    private void button12_Click(object sender, EventArgs e)
    {
        float DpiX, DpiY;

        using (Graphics g = CreateGraphics())
        {
            DpiX = g.DpiX;
            DpiY = g.DpiY;
        }

        MessageBox.Show($"Your screen DPI: ({DpiX}x{DpiY}).");
    }

    private void button13_Click(object sender, EventArgs e)
    {
        new ExcelForm().Show(); // Show window
    }

    private void button14_Click(object sender, EventArgs e)
    {
        new PeyrSharpForm().Show();
    }
}
