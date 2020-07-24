using LeoCorpLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        }
    }
}
