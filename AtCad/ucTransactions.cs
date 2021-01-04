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
    public partial class ucTransactions : UserControl
    {

        #region Singleton Instance
        // >>> Singleton Instance
        private static ucTransactions _instance;

        public static ucTransactions Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucTransactions();
                return _instance;
            }
        }
        #endregion

        public ucTransactions()
        {
            InitializeComponent();
        }
    }
}
