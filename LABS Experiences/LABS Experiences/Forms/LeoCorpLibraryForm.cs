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
    }
}
