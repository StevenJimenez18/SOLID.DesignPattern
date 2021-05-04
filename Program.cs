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
            // Welcome Message for user
            StandardMessages.WelcomeMessage();

            // Ask for user information
            Person user = PersonDataCapture.Capture();

            // Checks to be sure if the first and last names are valid
            bool isUserValid = PersonValidator.Validate(user);

            if(isUserValid == false)
            {
                StandardMessages.EndApplication();
                return;
            }

            // Creates a username for the user
            AccountGenerator.CreateAccount(user);

            // Ending message for user
            StandardMessages.EndApplication();
        }
    }
}
