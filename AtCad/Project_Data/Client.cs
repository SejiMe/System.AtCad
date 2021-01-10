using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCad.Project_Data
{
    public class Client
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string ContactNumber { get; set; }
        public string Address { get; set; }

        public string ClientDetails
        {
            get
            {
                return $"{Title}, {FirstName} {MiddleName} {LastName} - {ContactNumber} - {Address}";
            }
        }
    }
}
