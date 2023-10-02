using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;
using practice04.DAL.Model;

namespace practice04.DAL
{
    public class RepositoryClient
    {
        private readonly string path;
        public RepositoryClient(string path)
        {
            if(string.IsNullOrWhiteSpace(path))
                throw new ArgumentNullException("Путь в БД не может быть пустым");
            this.path = path;
        }
        public ReturnResultClient GetAllClients()
        {
            ReturnResultClient result = new ReturnResultClient();
            try
            {
                using (var db = new LiteDatabase(path)) 
                {
                    result.Clients = db.GetCollection<Client>
                        ("Client").FindAll().ToList();
                }
            }
            catch(LiteException ex)
                when(string.IsNullOrWhiteSpace(path))
            {
                result.Exception = ex;
                result.isError = true;
            }
            catch (Exception ex)
            {
                result.Exception = ex;
                result.isError = true;
            }

            return result;
        }

        public ReturnResultClient GetClientById(int Id)
        {
            ReturnResultClient result = new ReturnResultClient();
            try
            {
                using (var db = new LiteDatabase(path))
                {

                    result.Client = db.GetCollection<Client>
                        ("Client").FindById(Id);

                }
            }
            catch (Exception ex)
            {
                result.Exception = ex;
                result.isError = true;
            }
            return result;
        }

        public ReturnResultClient CreateClient(Client client)
        {
            ReturnResultClient result = new ReturnResultClient();
            try
            {
                using (var db = new LiteDatabase(path)) //правильное корректное соединение с бд
                {
                    var clients = db.GetCollection<Client>("Client");
                    clients.Insert(client);
                }

            }
            catch (Exception ex)
            {
                result.Exception = ex;
                result.isError = true;
            }
            return result;
        }
    }
}
