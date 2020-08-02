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
    public partial class CursorWindow : Form
    {
        public CursorWindow()
        {
            InitializeComponent();
            TopMost = true;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Left = Cursor.Position.X + 20;
            Top = Cursor.Position.Y + 20;
        }
    }
}
