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

        #region User controller Instances
        private void _UCDashboard()
        {
            if (!mainPanel.Controls.Contains(ucDashboard.Instance))
            {
                mainPanel.Controls.Add(ucDashboard.Instance);
                ucDashboard.Instance.Dock = DockStyle.Fill;
                ucDashboard.Instance.BringToFront();
            }
            ucDashboard.Instance.BringToFront();
        }

        private void _UCInventory()
        {
            if (!mainPanel.Controls.Contains(ucInventory.Instance))
            {
                mainPanel.Controls.Add(ucInventory.Instance);
                ucInventory.Instance.Dock = DockStyle.Fill;
                ucInventory.Instance.BringToFront();
            }
            ucInventory.Instance.BringToFront();
        }

        private void _UCTransactions()
        {
            if (!mainPanel.Controls.Contains(ucTransactions.Instance))
            {
                mainPanel.Controls.Add(ucTransactions.Instance);
                ucTransactions.Instance.Dock = DockStyle.Fill;
                ucTransactions.Instance.BringToFront();
            }
            ucTransactions.Instance.BringToFront();
        }
        private void _UCRecords()
        {
            if (!mainPanel.Controls.Contains(ucRecords.Instance))
            {
                mainPanel.Controls.Add(ucRecords.Instance);
                ucRecords.Instance.Dock = DockStyle.Fill;
                ucRecords.Instance.BringToFront();
            }
            ucRecords.Instance.BringToFront();
        }


        private void _UCClients()
        {
            if (!mainPanel.Controls.Contains(ucClients.Instance))
            {
                mainPanel.Controls.Add(ucClients.Instance);
                ucClients.Instance.Dock = DockStyle.Fill;
                ucClients.Instance.BringToFront();
            }
            ucClients.Instance.BringToFront();
        }


        #endregion

        public MainForm()
        {
            Thread thread = new Thread(new ThreadStart(splashForm));
            thread.Start();
            Thread.Sleep(3500);
            InitializeComponent();

            // >>> Open the program 
            // >>> TODO Try Async
            _UCInventory();
            _UCRecords();
            _UCTransactions();
            _UCDashboard();
            _UCClients();
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

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            _UCDashboard();
        }

        private void btnRecords_Click(object sender, EventArgs e)
        {
            _UCRecords();
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            _UCTransactions();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            _UCInventory();
        }
    }
}
