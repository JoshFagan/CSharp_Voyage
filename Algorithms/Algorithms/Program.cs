using System;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            TestInsertionSort();
        }

        /// <summary>
        ///     Tests Insertion Sort of array of three different types.
        /// </summary>
        static void TestInsertionSort()
        {
            string[] stringList = { "Bob", "Alice", "Foo", "Bar" };
            int[] intList = { 23, 534, 2, 76, 3, 56, 87, 989, 234 };
            double[] doubleList = { 34.23, 543.56467, 56754.3442, 123.535464, 1232.4234, 567.99, 0.1 };

            Console.WriteLine("[{0}]", string.Join(", ", stringList));
            Sort<string>.InsertionSort(stringList);
            Console.WriteLine("[{0}]", string.Join(", ", stringList));

            Console.WriteLine("[{0}]", string.Join(", ", intList));
            Sort<int>.InsertionSort(intList);
            Console.WriteLine("[{0}]", string.Join(", ", intList));

            Console.WriteLine("[{0}]", string.Join(", ", doubleList));
            Sort<double>.InsertionSort(doubleList);
            Console.WriteLine("[{0}]", string.Join(", ", doubleList));
        }
    }
}