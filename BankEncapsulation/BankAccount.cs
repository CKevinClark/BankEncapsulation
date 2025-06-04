using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class BankAccount
    {
        private double _balance; 
    
        public double CurrentBalance 
        { 
            get { return _balance;}
            private set {_balance = value;}
        }

    public void Deposit(double amount)
        {
            Console.WriteLine($"Adding to Account Balance {amount:C} Now");

            CurrentBalance += amount;

        }

        public double GetBalance()
        {
            return CurrentBalance;
        }
    }
}
