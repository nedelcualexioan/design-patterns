using System.Security.Cryptography.X509Certificates;

namespace design_patterns.Facade
{
    public class AccountNumberCheck
    {
        private int accountNumber = 123456789;

        public int AccountNumber
        {
            set => accountNumber = value;
            get => accountNumber;
        }

        public bool isAccountActive(int accountNumber)
        {
            if (accountNumber == AccountNumber)
            {
                return true;
            }

            return false;
        }
    }
}