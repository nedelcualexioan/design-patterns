using System;

namespace design_patterns.Facade
{
    public class FundsCheck
    {
        private float cashInAccount = 1000F;

        public float CashInAccount
        {
            get => cashInAccount;
        }

        public void decreaseCash(float cash)
        {
            cashInAccount -= cash;
        }

        public void increaseCash(float cash)
        {
            cashInAccount += cash;
        }

        public bool withdraw(float cashToWithdraw)
        {
            if (cashToWithdraw > CashInAccount)
            {
                Console.WriteLine("Error: You don't have enough money.");
                Console.WriteLine("Current balance: " + CashInAccount);

                return false;
            }

            decreaseCash(cashToWithdraw);
            Console.WriteLine("Withdrawal complete. New balance: " + CashInAccount);

            return true;
        }

        public void deposit(float cashToDeposit)
        {
            increaseCash(cashToDeposit);

            Console.WriteLine("Deposit complete. New balance: " + CashInAccount);
        }

    }
}