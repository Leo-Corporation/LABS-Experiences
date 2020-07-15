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
    public partial class UseRam : Form
    {
        int counter = 0;
        int counter1 = 0;
        public UseRam()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            label3.Text = string.Format("Je compte : {0}", counter.ToString());
            if (pictureBox2.Image == Properties.Resources.Logo) // Si le logo est présent
            {
                pictureBox2.Image = null; // Pas d'image
            }
            else
            {
                pictureBox2.Image = Properties.Resources.Logo; // Image
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            counter1++;
            label4.Text = string.Format("Je compte également : {0}", counter1.ToString());
            label3.Left = (ClientSize.Width - label3.Width) / 2;
            label4.Left = (ClientSize.Width - label4.Width) / 2;
        }

        private void UseRam_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
        }
    }
}
