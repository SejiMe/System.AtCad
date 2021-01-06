using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
