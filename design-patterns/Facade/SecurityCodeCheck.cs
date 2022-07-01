namespace design_patterns.Facade
{
    public class SecurityCodeCheck
    {
        private int securityCode = 1234;

        public int SecurityCode
        {
            set => securityCode = value;
            get => securityCode;
        }

        public bool isCodeCorrect(int securityCode)
        {
            if (securityCode == SecurityCode)
            {
                return true;
            }

            return false;
        }
    }
}