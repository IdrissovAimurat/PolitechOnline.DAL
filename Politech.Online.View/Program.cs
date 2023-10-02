using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using practice04.DAL.Model;
using practice04.DAL;
using Politech.BLL;
using System.Configuration;

namespace Politech.Online.View
{
    internal class Program
    {
        static string path = ConfigurationManager
            .ConnectionStrings["DefaultConnection"]
            .ConnectionString;
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

            ServiceClient service = new ServiceClient(path);
            var result = service.RegisterClient(client);
            if (result.isError)
            {
                Console.WriteLine("Возникла ошибка: {0} при создании клиента", result.message);
            }
            else
            {
                Console.WriteLine("Пользователь успешно зарегистрирован!");
            }
        }
        public static void FirstMenu()
        {
            Console.WriteLine("1) Авторизация");
            Console.WriteLine("2) Регистрация");
            Console.WriteLine("3) Выход");
        }
        public static void Authorization()
        {
            string = "";
        }
        public static void Registration()
        {
            Client client = new Client();
            Console.Write("Введите логин: ");

        }
    }
}
