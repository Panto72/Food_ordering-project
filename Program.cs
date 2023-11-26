using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class Program
    {
        static void Deposit(cardHolder currentusers)
        {
            Console.WriteLine("Enter amount to deposit:");
            double Deposit = double.Parse(Console.ReadLine());
            currentusers.setBalance(Deposit);
            Console.WriteLine("money received, thank you");
            Console.WriteLine("new balance is: " + currentusers.getBalance());
        }

        static void Withdraw(cardHolder currentusers)
        {
            Console.WriteLine("Enter amount to withdraw:");
            double withdrawal = double.Parse(Console.ReadLine());
            if (currentusers.getBalance() < withdrawal)
            {
                Console.WriteLine("Insufficient amount");
            }
            else
            {
                double newBalance = currentusers.getBalance() - withdrawal;
                currentusers.setBalance(newBalance);
                Console.WriteLine("Successful...");
            }
        }

        static void Balance(cardHolder currentusers)
        {
            Console.WriteLine("current balance is: " + currentusers.getBalance());
        }

        static void PrintOptions()
        {
            Console.WriteLine("Please choose one from the following options:");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Balance");
            Console.WriteLine("4. Exit");
        }

        static void Main(string[] args)
        {
            List<cardHolder> cardHolders = new List<cardHolder>
            {
                new cardHolder("09876", 1122, "Mafuj", "Ahammad", 28500),
                new cardHolder("12345", 4321, "John", "Doe", 15000),
                new cardHolder("67890", 7890, "Alice", "Smith", 20000),
                new cardHolder("11111", 2345, "Bob", "Johnson", 18000),
                new cardHolder("55555", 1111, "Emily", "Davis", 25000)
            };

            Console.WriteLine("Welcome to our ATM");
            Console.WriteLine("Please insert your card number:");
            string DebitCardNum = "";
            cardHolder currentUsers;


            while (true)
            {
                try
                {
                    DebitCardNum = Console.ReadLine();
                    currentUsers = cardHolders.FirstOrDefault(a => a.cardNum == DebitCardNum);
                    if (currentUsers != null) { break; }
                    else { Console.WriteLine("Incorrect"); }
                }
                catch { Console.WriteLine("Incorrect"); }
            }

            Console.WriteLine("Enter your pin");
            int userPin = 0;
            while (true)
            {
                try
                {
                    userPin = int.Parse(Console.ReadLine());
                    if (currentUsers.getPin() == userPin) { break; }
                    else { Console.WriteLine("Incorrect pin"); }
                }
                catch { Console.WriteLine("Incorrect pin"); }
            }
            Console.WriteLine("Welcome " + currentUsers.getFirstName() + ":)");
            int option = 0;
            do
            {
                PrintOptions();
                try
                {
                    option = int.Parse(Console.ReadLine());

                }
                catch { }
                if (option == 1)
                { Deposit(currentUsers); }
                else if (option == 2)
                { Withdraw(currentUsers); }
                else if (option == 3)
                { Balance(currentUsers); }
                else if (option == 4)
                { break; }
                else { option = 0; }
            }
            while (option != 4);
            Console.WriteLine("Thank you, have a nice day");
        }
    }
}
