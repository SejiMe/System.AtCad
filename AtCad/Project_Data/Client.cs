using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCad.Project_Data
{
    public class Client
    {
        public string ClientName { get; set; }
        public string ContactNumber { get; set; }
        public string Address { get; set; }

        public string ClientDetails
        {
            get
            {
                return $"{ClientName} {ContactNumber} - {Address}";
            }
        }
    }
}
