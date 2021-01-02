using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtCad
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            Thread thread = new Thread(new ThreadStart(splashForm));
            thread.Start();
            Thread.Sleep(3500);
            InitializeComponent();
            thread.Abort();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
             
        }

        private void splashForm()
        {
            try
            {
                Application.Run(new SplashForm());
            }
            catch (ThreadStateException e)
            {
                var message = e.Message;
                MessageBox.Show(message);
            }

        }

    }
}
