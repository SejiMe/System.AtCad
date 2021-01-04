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
    public partial class ucInventory : UserControl
    {
        // >>> singleton instance
        private static ucInventory _instance;

        public static ucInventory Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucInventory();
                }
                return _instance;
            }
        }

        public ucInventory()
        {
            InitializeComponent();
        }
    }
}
