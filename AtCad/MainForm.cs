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
            clock.Start(); 
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (Thread.CurrentThread != null)
            {
                Application.ExitThread();
            }
            Application.Exit();
        }

        private void clock_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("hh:mm:ss");
            lblDate.Text = DateTime.Now.ToString("MMM dd, yyyy");
            lblDay.Text = DateTime.Now.ToString("dddd");
            lblDate.TextAlign = ContentAlignment.TopCenter;
            lblClock.TextAlign = ContentAlignment.MiddleCenter;
            lblDay.TextAlign = ContentAlignment.BottomCenter;
        }
    }
}
