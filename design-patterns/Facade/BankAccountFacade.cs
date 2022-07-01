using System;

namespace design_patterns.Facade
{
    public class BankAccountFacade
    {
        private int accountNumber;

        private int securityCode;

        private AccountNumberCheck accChecker;
        private SecurityCodeCheck codeChecker;
        private FundsCheck fundChecker;

        public BankAccountFacade(int accountNumber, int securityCode)
        {
            this.accountNumber = accountNumber;
            this.securityCode = securityCode;

            accChecker = new AccountNumberCheck();
            codeChecker = new SecurityCodeCheck();
            fundChecker = new FundsCheck();
        }

        public int AccountNumber
        {
            get => accountNumber;
        }

        public int SecurityCode
        {
            get => securityCode;
        }

        public void withdrawCash(float cash)
        {
            if (accChecker.isAccountActive(AccountNumber) && codeChecker.isCodeCorrect(SecurityCode) &&
                fundChecker.withdraw(cash))
            {
                Console.WriteLine("Transaction complete");
            }
            else
            {
                Console.WriteLine("Transaction failed");
            }
        }

        public void depositCash(float cash)
        {
            if (accChecker.isAccountActive(AccountNumber) && codeChecker.isCodeCorrect(SecurityCode))
            {
                fundChecker.deposit(cash);

                Console.WriteLine("Transaction complete");  
            }
            else
            {
                Console.WriteLine("Transaction failed");
            }
        }
    }
}