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
    public partial class ucRecords : UserControl
    {
        #region Singleton Instance
        // >>> Singleton Instance
        private static ucRecords _instance;

        public static ucRecords Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucRecords();
                }
                return _instance;
            }
        }
        #endregion
        public ucRecords()
        {
            InitializeComponent();
        }
    }
}
