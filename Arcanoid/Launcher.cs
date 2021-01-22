using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arcanoid
{
    public partial class Launcher : Form
    {
        public Launcher()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity += .03;
            if (this.Opacity == 1)
            {
                timer1.Stop();
            }
        }

        private void Launcher_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
