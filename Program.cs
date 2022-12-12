using System;

namespace AdressBookSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To adress Book System!");
            Program program = new Program();
            Console.WriteLine("Enter name = ");
            string Name = Console.ReadLine();
           
            Console.WriteLine("Enter address= ");
            String address = Console.ReadLine();
            Console.WriteLine("Enter city= ");
            String city = Console.ReadLine();
            Console.WriteLine("Enter state= ");
            String state = Console.ReadLine();
            Console.WriteLine("Enter zip= ");
            String zip = Console.ReadLine();
            Console.WriteLine("Enter phoneNumber= ");
            String phoneNumber = Console.ReadLine();
            Console.WriteLine("Enter email= ");
            String email = Console.ReadLine();
        }
    }
}