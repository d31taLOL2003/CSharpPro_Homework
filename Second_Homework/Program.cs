using Second_Homework.First_Task;
using Second_Homework.Second_Task;
using Second_Homework.Third_Task;


namespace Second_Homework
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("First Task: ");
            Money priceOfProduct = new Money(50, 99);
            Product coffeMaker = new Product("Coffee Maker", "Makes great coffee", "Kitchen", priceOfProduct, 100);

            coffeMaker.DisplayProductInfo();
            Console.WriteLine();

            coffeMaker.ReducePrice(10, 40);
            coffeMaker.UpdateStock(-27);

            coffeMaker.DisplayProductInfo();
            Console.WriteLine();

            coffeMaker.ReducePrice(0, 59);
            coffeMaker.UpdateStock(17);
            coffeMaker.DisplayProductInfo();

            Console.WriteLine("---------------------------------------------");

            Console.WriteLine("\nSecond Task: ");
            Violin violin = new Violin();

            violin.Show();
            violin.Sound();
            violin.Desc();
            violin.History();
            Console.WriteLine();

            Trombone trombone = new Trombone();

            trombone.Show();
            trombone.Sound();
            trombone.Desc();
            trombone.History();
            Console.WriteLine();

            Ukulele ukulele = new Ukulele();

            ukulele.Show();
            ukulele.Sound();
            ukulele.Desc(); 
            ukulele.History();
            Console.WriteLine();

            Cello cello = new Cello();

            cello.Show();
            cello.Sound();
            cello.Desc();
            cello.History();
            Console.WriteLine();

            Console.WriteLine("---------------------------------------------");

            Console.WriteLine("\nThird Task: ");
            DecimalNumber myNumber = new DecimalNumber(123);

            Console.WriteLine($"Binary: {myNumber.ToBinary()}");
            Console.WriteLine($"Octal: {myNumber.ToOctal()}");
            Console.WriteLine($"Hexadecimal: {myNumber.ToHexadecimal()}");
        }
    }
}
