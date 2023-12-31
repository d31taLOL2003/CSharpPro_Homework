namespace Third_Homework
{
    public class Program
    {
        static void Main(string[] args)
        {
            MyArray myArray = new MyArray(new int[] { 6, 2, 7, 5, 13, 8, 4, 3, 1, 9, 10, 12, 11 });

            myArray.Show("Elements in the array: ");

            Console.WriteLine();
            Console.WriteLine($"Maximum value in the array: {myArray.Max()}");
            Console.WriteLine($"Minimum value in the array: {myArray.Min()}");
            Console.WriteLine($"Avaerage value of the array: {myArray.Avg()}\n");

            int searchValue = 7;
            Console.WriteLine($"Is value {searchValue} found in the array?\nAnswer: {myArray.Search(searchValue)}");

            Console.WriteLine();

            myArray.SortAsc();
            Console.WriteLine($"Sorted Ascending: {myArray.ToString()}");

            Console.WriteLine();

            myArray.SortDesc();
            Console.WriteLine($"Sorted Descending: {myArray.ToString()}");

            Console.WriteLine();

            myArray.SortByParam(true);
            Console.WriteLine($"Sorted by Param Ascending: {myArray.ToString()}");

            Console.WriteLine();

            myArray.SortByParam(false);
            Console.WriteLine($"Sorted by Param Descending: {myArray.ToString()}");
        }
    }
}
