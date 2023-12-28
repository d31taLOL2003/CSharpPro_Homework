namespace Second_Homework.First_Task
{
    public class Money
    {
        private int _integerPart;
        private int _coinPart;

        public Money(int integerPart, int coinPart)
        {
            IntegerPart = integerPart;
            CoinPart = coinPart;
        }

        public int IntegerPart
        {
            get
            {
                return _integerPart;
            }
            set
            {
                if (value > 0)
                {
                    _integerPart = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Integer part cannot be negative.");
                }
            }
        }

        public int CoinPart
        {
            get
            {
                return _coinPart;
            }
            set
            {
                if (value >= 0)
                {
                    _integerPart += value / 100;
                    _coinPart = value % 100;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Coin part cannot be negative.");
                }
            }
        }

        public void DisplayAmount()
        {
            Console.WriteLine($"Amount: {IntegerPart}.{CoinPart}");
        }
    }
}
