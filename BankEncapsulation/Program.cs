using System.ComponentModel.Design;
using System.Diagnostics;

namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            bool keepDepositing = true;

            while (keepDepositing)
            {
                Console.WriteLine("How much currency would you like to deposit?");

                double amountToDeposit;

                while (!double.TryParse(Console.ReadLine(), out amountToDeposit) || amountToDeposit <= 0)
                {
                    Console.WriteLine("Invalid input. Please enter a positive number:");
                }

                    account.Deposit(amountToDeposit);

                Console.WriteLine($"You have added {amountToDeposit:C} to your account.");
                Console.WriteLine($"Current Balance: {account.GetBalance():C}");

                Console.WriteLine("Would you like to make another deposit? Type 'y' for yes or 'n' for no:");
                string input = Console.ReadLine().ToLower();

                if (input != "y")
                {
                    keepDepositing = false;
                    Console.WriteLine("Thank you, come again soon!");
                }
            }
        }


    }
}

