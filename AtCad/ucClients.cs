using AtCad.Core;
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

        static DataAccess DA = new DataAccess();
        private static List<Client> listOfClient = new List<Client>();


        private static ucClients _instance;

        public void LoadClients()
        {
            listBoxClient.DataSource = listOfClient;
            listBoxClient.DisplayMember = "ClientDetails";
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
            listOfClient = DA.getAllClient();
            textID.Text = $"{GenerateInitialID(GetCurrentID())}";
            LoadClients();
        }

        #region ID Generator
        private static int GetCurrentID()
        {
            listOfClient = DA.getAllClient();
            return listOfClient.Count + 1;
        }

        private bool isIDGenerated(int currentID)
        {
            bool isGenerated = false;


            foreach (var item in listOfClient)
            {
                if (currentID == item.ID)
                {
                    isGenerated = true;
                    break;
                }
                else
                {
                    isGenerated = false;
                }
            }

            //TODO Binary Search

            return isGenerated;
        }

        private string GenerateInitialID(int currentID)
        {
            Random random = new Random();
            int randomValue = random.Next(0, 9);
            string date = DateTime.Now.ToString("MM yy");
            date = date.Replace(" ", "");
            return $"{currentID}" + date + DateTime.Now.ToString("HH")+ $"{randomValue}";
        }

        private string GenerateID(int currentID, bool isGenerated)
        {
            Random random = new Random();
            int randomValue = random.Next(0,9);
            string date = DateTime.Now.ToString("MM yy");
            date = date.Replace(" ", "");
            string ID = textID.Text;

            if (isGenerated == true)
            {
                return ID;
            }
            else if(isGenerated == false)
            {
                randomValue = random.Next(0, 9);
                ID = $"{currentID}" + date + DateTime.Now.ToString("HH") + $"{randomValue}";
            }
            return ID;
        }

        #endregion

        private void btnResetIDGen_Click(object sender, EventArgs e)
        {
           textID.Text = GenerateID(listOfClient.Count + 1,isIDGenerated(int.Parse(textID.Text)));
        }
    }
}
