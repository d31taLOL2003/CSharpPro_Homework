namespace Second_Homework.First_Task
{
    public class Product
    {
        private string _name;
        private string _description;
        private string _category;
        private Money _price;
        private int _stockQuantity;

        public Product(string name, string description, string category, Money price, int stockQuantity)
        {
            _name = name;
            _description = description;
            _category = category;
            _price = price;
            _stockQuantity = stockQuantity;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public string Category
        {
            get { return _category; }
            set { _category = value; }
        }


        public Money Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public int StockQuantity
        {
            get { return _stockQuantity; }
            set
            {
                if (value < 0 )
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Stock quantity cannot be negative.");
                }
                else
                {
                    _stockQuantity = value;
                }
            }
        }

        public void ReducePrice(int integerToReduce, int coinToReduce = 0)
        {
            int totalCoins = _price.IntegerPart * 100 + _price.CoinPart;
            int reduction = integerToReduce * 100 + coinToReduce;

            if (reduction > totalCoins)
            {
                throw new InvalidOperationException("Reduction exceeds the current price");
            }

            totalCoins -= reduction;

            _price.IntegerPart = totalCoins / 100;
            _price.CoinPart = totalCoins % 100;
        }

        public void UpdateStock(int amount)
        {
            if (amount < 0 && Math.Abs(amount) > _stockQuantity)
            {
                throw new InvalidOperationException("Cannot remove more stock than is available.");
            }

            _stockQuantity += amount;
        }

        public void DisplayProductInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Category: {Category}");
            Console.WriteLine($"Price: ${Price.IntegerPart}.{Price.CoinPart:D2}");
            Console.WriteLine($"Stock Quantity: {StockQuantity}");
        }
    }
}
