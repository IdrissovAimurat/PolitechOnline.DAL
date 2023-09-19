using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice04.DAL.Model
{
    public class Client
    {
        public Client() 
            : this(0)
        {

        }
        public Client(int Id)
            : this(Id, DateTime.Now)
        {

        }
        public Client(int Id, DateTime CreateDate)
            : this(Id, CreateDate, "")
        {

        }
        public Client(int Id, DateTime CreateDate, string PathToImag)
        {
            this.Id = Id;
            this.CreateDate = CreateDate;
            this.PathToImage = PathToImag;
        }

        int age;
        public int Id { get; set; }

        public DateTime CreatorDate { get; set; }

        public string FName { get; set; }
        public string SName { get; set; }
        public string LName { get; set; }

        public string FullName
        {
            get
            {
                return string.Format("{0} {1} {2}",
                    FName, SName, LName);
            }
        }
        public string ShortName
        {
            get
            {
                if(!string.IsNullOrWhiteSpace(LName))
                    return string.Format ("{0} {1}. {2}.", 
                        FName, SName[0], LName[0]);
                else
                    return string.Format("{0} {1}.",
                        FName, SName[0]);
            }
        }
        public DateTime CreateDate { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int Sex 
        {
            get; 
            set; 
        }
        public DateTime Dob { get; set; } = DateTime.Now;

        public int Age
        {
            get
            {
                return (DateTime.Now.Year - Dob.Year);
            }
        }

        public string PathToImage { get; set; }
        public Address Address { get; set; }
        public Account[] Accounts { get; set; }
        //{
            //возвращает
            //get
            //{
            //    return Id;
            //}
            //устанавливает
            //set
            //{
            //    if (value < 0)
            //        Id = 0;
            //    else
            //        Id = value;
            //} 
        //}
        
       // public string FName { get; set }

    }
}
