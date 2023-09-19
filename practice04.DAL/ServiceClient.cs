using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;
using practice04.DAL.Model;

namespace practice04.DAL
{
    public class ServiceClient
    {
        public List<Client> GetAllClients(int Id)
        {
            List<Client> clients = null;
            Client client = null;
            using (var db = new LiteDatabase(@"C:\Temp\MyData.db")) //правильное корректное соединение с бд
            {
                // Get a collection (or create, if doesn't exist)
                var col = db.GetCollection<Client>("Client")
                    .FindById(Id);
            }

            return clients;
        }

      //  public Client GetClientById(int Id)
//        {

      //  }

        public bool CreateClient(Client client)
        {
            using (var db = new LiteDatabase(@"C:\Temp\MyData.db")) //правильное корректное соединение с бд
            {
                var clients = db.GetCollection<Client>("Client");
                clients.Insert(client);
            }

            return true;
        }
    }
}
