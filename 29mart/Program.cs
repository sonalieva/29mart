using System;

namespace _29mart
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("UserName ni daxil edin");
            string username = Console.ReadLine();

            Console.WriteLine("Passwordu daxil edin");
            string password = Console.ReadLine();
            User user = new User(username)
            {
                Password = password
            };
            user.GetInfo();


        }
    }
}
