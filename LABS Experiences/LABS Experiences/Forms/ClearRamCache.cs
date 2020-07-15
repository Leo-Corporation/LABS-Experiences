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
    public partial class ClearRamCache : Form
    {
        public ClearRamCache()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new UseRam().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GC.Collect();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GC.Collect();
        }
    }
}
