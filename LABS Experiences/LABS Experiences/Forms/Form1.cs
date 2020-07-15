using LABS_Experiences.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LABS_Experiences
{
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
    }
}
