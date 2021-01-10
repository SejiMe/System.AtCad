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

        public List<Client> getAllClient()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.connectionValue("ATCADDB")))
            {
                var clients = connection.Query<Client>("dbo.GetAllClient").ToList();
                return clients;
            }
        }

        public void insertClient(int ID,string FirstName, string MiddleName, string LastName, string Title, string ContactNumber, string Address )
        {

        }

    }
 }


          