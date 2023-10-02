using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using practice04.DAL.Model;

namespace practice04.DAL
{
    public class ReturnResultClient
    {
        public bool isError { get; set; }
        public string Message { get; set; }
        public Exception Exception { get; set; }
        public Client Client { get; set; }
        public List<Client> Clients { get; set; }
    }
}
