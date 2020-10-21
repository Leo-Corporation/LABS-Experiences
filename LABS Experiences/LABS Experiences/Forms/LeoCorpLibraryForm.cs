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
using LeoCorpLibrary.Extensions;
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
    public partial class LeoCorpLibraryForm : Form
    {
        public LeoCorpLibraryForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Env.GetTotalDriveSpace(@"C:\", UnitType.Gigabyte).ToString()); // Obtenir l'espace total du lecteur
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Env.GetDriveAvailableFreeSpace(@"C:\", UnitType.Gigabyte).ToString()); // Obtenir l'espace disponible du lecteur
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Env.GetOccupiedDriveSpace(@"C:\", UnitType.Gigabyte).ToString()); // Obtenir l'espace occupé du lecteur
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new ListViewSaveLoad().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Maths.Cube.GetVolume(2, 2).ToString());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Maths.Cylinder.GetVolume(4, 5).ToString());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Maths.Pyramid.GetVolume(5, 6, 7).ToString());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Maths.Pyramid.GetHeight(10, 10, 100).ToString());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Maths.Pyramid.GetWidthBase(100, 10).ToString());
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Maths.Pyramid.GetLenghtBase(100, 10).ToString());
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Maths.Cube.GetEdge(100).ToString());
        }

        private void button12_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Maths.Cylinder.GetHeight(1000, 3).ToString());
        }

        private void button13_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Maths.Cylinder.GetBaseArea(10).ToString());
        }

        private void button14_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Env.GetWindowsVersion().ToString());
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Env.ExecuteAsAdmin(@"C:\Windows\System32\cmd.exe");
        }

        private async void button16_Click(object sender, EventArgs e)
        {
            bool av = await NetworkConnection.IsAvailableAsync();
            bool av2 = await NetworkConnection.IsAvailableTestSiteAsync("https://leocorp.fr");
            MessageBox.Show(av.ToString());
            MessageBox.Show(av2.ToString());
        }

        private void button17_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Env.GetUnixTime().ToString());
            
            MessageBox.Show(Env.GetUnixTime(new DateTime(2020, 1, 1)).ToString());
        }

        private async void button18_Click(object sender, EventArgs e)
        {
            MessageBox.Show(await LeoCorpLibrary.Update.GetLastVersionAsync("https://raw.githubusercontent.com/Leo-Corporation/LeoCorp-Docs/master/Liens/Update%20System/Educ'Maths%204.0/Dev/Version.txt"));
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (File.Exists(Application.StartupPath + @"\test.labs"))
            {
                MessageBox.Show(Env.CountFileCharacters(Application.StartupPath + @"\test.labs").ToString());
            }
        }

        private async void button20_Click(object sender, EventArgs e)
        {
            if (File.Exists(Application.StartupPath + @"\test.labs"))
            {
                int a = await Env.CountFileCharactersAsync(Application.StartupPath + @"\test.labs");
                MessageBox.Show(a.ToString());
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            string guid = GuidGenerator.Generate();
            string guidLenght = GuidGenerator.Generate(10);
            string guidFromString = GuidGenerator.Generate("Test");
            string guidParameters = GuidGenerator.Generate("LABS",new GuidGeneratorParameters
            {
                WithHyphens = true,
                Lenght = 10,
                WithBraces = true
            }); ;
            MessageBox.Show($"Guid: {guid}{Environment.NewLine}Guid Lenght: {guidLenght}{ Environment.NewLine}Guid From String: {guidFromString}{Environment.NewLine}Guid Parameters: {guidParameters}");
        }

        private void button22_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"AppData path: {Env.GetAppDataPath()}");
        }

        private void button23_Click(object sender, EventArgs e)
        {
            new GenerateAsync().Show();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            int number = 1;
            double div = number.ToDouble() / 2;
            string sentence = "Hello, this is a test sentence to see if the word counter in LeoCorpLibrary is working properly!!";
            MessageBox.Show($"{div.ToString()}\n{number / 2}");
            MessageBox.Show(number.IsEven().ToString());
            MessageBox.Show(sentence.CountWords().ToString());
        }
    }
}
