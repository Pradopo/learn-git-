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

                Address = "Pasir Ris",
                Email = "pradopo@gmail.com",



                Status = "Active"
            };
            Console.WriteLine(string.Format("ID::{0}",user.ID));

            for (var i = 1; i <=3; i++ ) {

                Console.WriteLine(string.Format("Name loop-{1}::{0}", user.Name,i));
                Console.WriteLine(string.Format("Address loop-{1}::{0}", user.Address,i));
            }
            Console.WriteLine(string.Format("Name::{0}", user.Name));
            Console.WriteLine(string.Format("Address::{0}", user.Address));
            Console.WriteLine(string.Format("Status::{0}", user.Status));
            Console.WriteLine("---finish data---");
            Console.ReadKey();
        }
    }
}
