using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace castlewindsor
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("------start-------");
            Console.WriteLine("------------------");
            Console.WriteLine("Initiate object");
            var user = new User()
            {
                Name = "Parang Pradopo",
                ID = "001",
                Address= "Pasir Ris",
                Email = "pradopo@gmail.com"
            };
            Console.WriteLine(string.Format("ID::{0}",user.ID));
            Console.WriteLine(string.Format("Name::{0}", user.Name));
            Console.WriteLine(string.Format("Address::{0}", user.Address));

            Console.WriteLine("---finish---");
            Console.ReadKey();
        }
    }
}
