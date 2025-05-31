using System.Diagnostics;

namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount ba = new BankAccount();

            Console.WriteLine("How much currency would you like to deposit?"); 

            double amountToDeposit = double.Parse(Console.ReadLine());

            ba.Deposit(amountToDeposit);

            double userBalance = ba.GetBalance();

            Console.WriteLine($"You have added {userBalance:c} to your account.");

            
                Console.WriteLine("Would you like to make another deposit? type y for yes or n for no.");

                string input = Console.ReadLine();

                if (input.ToLower() == "y")
                {
                    Process.Start(Environment.ProcessPath);
                }

                else
            {
                Console.WriteLine("Thank you, come again soon!");
            }
           
        }
    }
}
