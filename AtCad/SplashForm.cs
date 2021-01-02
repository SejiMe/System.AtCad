using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtCad
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {
            timerProgressBar.Start();
        }

        private void timerProgressBar_Tick(object sender, EventArgs e)
        {
            if (panelLoadBar.Left > 635)
            {
                panelLoadBar.Left = 0;
            }
            panelLoadBar.Left += 8;
        }
    }
}
