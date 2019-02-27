using ConsoleApp1.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            PeopleServiceClient client = new PeopleServiceClient();
            // 帳號密碼
            client.ClientCredentials.UserName.UserName = "peoplesite123";
            client.ClientCredentials.UserName.Password = "password";

            foreach (var person in client.GetPeople())
            {
                Console.WriteLine(person.FirstName);
            }

            Console.ReadLine();
        }
    }
}
