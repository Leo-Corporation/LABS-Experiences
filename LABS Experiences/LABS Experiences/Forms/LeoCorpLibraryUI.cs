using LeoCorpLibrary.UI;
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
    public partial class LeoCorpLibraryUI : LABSForm
    {
        public LeoCorpLibraryUI()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WinFormsHelpers.CenterControlOnForm(label3, this, ControlAlignement.Horizontal);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            WinFormsHelpers.CenterControlOnForm(label3, this, ControlAlignement.Vertical);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WinFormsHelpers.CenterControlOnForm(label3, this);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            WinFormsHelpers.CenterFormOnScreen(this);
        }
    }
}
