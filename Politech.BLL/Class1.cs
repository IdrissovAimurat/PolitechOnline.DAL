using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using practice04.DAL.Model;
using practice04.DAL;

namespace Politech.BLL
{
    public class ServiceClient
    {
        private readonly string path = "";
        public ServiceClient(string path)
        {
            this.path = path;
        }
        public (bool isError, string message) RegisterClient(Client client)
        {
            RepositoryClient repo = new RepositoryClient(path);

            ReturnResultClient result = repo.CreateClient(client);

            return (result.isError,
                result.Exception != null
                ? result.Exception.Message
                : "");
        }
    }
}

