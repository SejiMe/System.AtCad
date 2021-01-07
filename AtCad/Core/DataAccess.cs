using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AtCad.Project_Data;
using Dapper;

namespace AtCad.Core
{
    public class DataAccess
    {
        public void getProducts()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.connectionValue("ATCADDB")))
            {

            }
        }

        public List<Client> getClient()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.connectionValue("ATCADDB")))
            {
                var clients = new List<Client>();
                return clients;
            }
        }


    }
}
