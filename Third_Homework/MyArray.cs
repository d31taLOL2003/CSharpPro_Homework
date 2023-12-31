using Third_Homework.Interfaces;

namespace Third_Homework
{
    public class MyArray : IOutput, IMath, ISort
    {
        private int[] _array;

        public MyArray(int[] initianalArray)
        {
            _array = initianalArray;
        }

        public int Max()
        {
            return _array.Max();
        }

        public int Min()
        {
            return _array.Min();
        }

        public int Avg()
        {
            return (int)_array.Average();
        }

        public bool Search(int valueSearch)
        {
            return _array.Contains(valueSearch);
        }

        public void SortAsc()
        {
            System.Array.Sort(_array);
        }

        public void SortDesc()
        {
            System.Array.Sort(_array);
            System.Array.Reverse(_array);
        }

        public void SortByParam(bool isAsc)
        {
            if (isAsc)
            {
                SortAsc();
            }
            else
            {
                SortDesc();
            }
        }

        public void Show()
        {
            foreach (var item in _array)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }

        public void Show(string info)
        {
            Console.WriteLine(info);
            Show();
        }

        public override string ToString()
        {
            return string.Join(" ", _array);
        }
    }
}
