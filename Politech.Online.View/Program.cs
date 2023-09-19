using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using practice04.DAL.Model;
using practice04.DAL;

namespace Politech.Online.View
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            client.CreateDate = DateTime.Now;
            client.Dob = new DateTime(2003, 04, 09);
            client.Email = "123@gmail.com";

            client.Password = "123";
            client.FName = "Aimurat";
            client.SName = "Idrissov";
            client.LName = "";

            ServiceClient service = new ServiceClient();
            service.CreateClient(client);

        }
    }
}
