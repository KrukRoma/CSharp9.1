namespace CSharp9._1
{
    public interface IOutput
    {
        void Show();
        void Show(string info);
    }

    public interface IMath
    {
        int Max();
        int Min();
        float Avg(); 
        bool Search(int valueToSearch);
    }

    public class Array : IOutput, IMath
    {
        private int[] _array;

        public Array(int[] array)
        {
            _array = array;
        }

        public void Show()
        {
            Console.WriteLine("Array elements:");
            foreach (var item in _array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        public void Show(string info)
        {
            Console.WriteLine(info);
            Show();
        }

        public int Max()
        {
            return _array.Max();
        }

        public int Min()
        {
            return _array.Min();
        }

        public float Avg() 
        {
            return (float)_array.Average(); 
        }

        public bool Search(int valueToSearch)
        {
            return _array.Contains(valueToSearch);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            Array myArray = new Array(numbers);

            myArray.Show();

            myArray.Show("This is my array of numbers:");

            Console.WriteLine("Max value: " + myArray.Max());
            Console.WriteLine("Min value: " + myArray.Min());
            Console.WriteLine("Average value: " + myArray.Avg());
            Console.WriteLine("Search for 3: " + (myArray.Search(3) ? "Found" : "Not Found"));
            Console.WriteLine("Search for 10: " + (myArray.Search(10) ? "Found" : "Not Found"));
        }
    }
}