using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsbilityPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my application!");

            //Ask fo user information
            Person user = new Person();

            Console.Write("What is your first name: ");
            user.FirstName = Console.ReadLine();

            Console.Write("What is your last name: ");
            user.LastName = Console.ReadLine();

            //Checks to be sure if the first and last names are valid
            if (string.IsNullOrWhiteSpace(user.FirstName))
            {
                Console.WriteLine("You did not give us a valid first name!");
                Console.ReadLine();
                return;
            }
            if (string.IsNullOrWhiteSpace(user.LastName))
            {
                Console.WriteLine("You did not give us a valid last name!");
                Console.ReadLine();
                return;
            }

            // Creates a username for the user
            Console.WriteLine($"Your username is { user.FirstName.Substring(0, 1)}{ user.LastName }");

            Console.ReadLine();
        }
    }
}
