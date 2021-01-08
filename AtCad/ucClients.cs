using AtCad.Project_Data;
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
    public partial class ucClients : UserControl
    {
        private static List<Client> listOfClient = new List<Client>();


        private static ucClients _instance;

        public void LoatClient()
        {

        }


        public static ucClients Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucClients();
                return _instance;
            }
        }

        public ucClients()
        {
            InitializeComponent();
        }
    }
}
