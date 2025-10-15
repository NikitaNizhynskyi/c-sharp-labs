using System;

namespace Task2
{
    public class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Elements of generated array: ");
            int[] array = GenerateRandomArray(10, 1, 100);
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            Console.WriteLine("Sum of elements: " + GetSum(array));
            Console.WriteLine("Average of elements: " + GetAverage(array));
            Console.WriteLine("Minimal element: " + GetMin(array));
            Console.WriteLine("Maximal element: " + GetMax(array));
        }
        public static int[] GenerateRandomArray(int size, int min, int max)
        {
            int[] array = new int[size];
            Random r = new Random();
            for (int i = 0; i < size; i++)
            {
                array[i] = r.Next(min, max);
            }
            return array;
        }

        public static int GetSum(int[] numbers)
        {
            int sum = 0;
            foreach(int i in numbers)
            {
                sum += i;

            }
            return sum;
        }

        public static double GetAverage(int[] numbers)
        {
            int sum = GetSum(numbers);

            return (double)sum / (double)numbers.Length;
        }

        public static int GetMin(int[] numbers)
        {
            int min = numbers[0];
            foreach(int i in numbers)
            {
                if (i < min) min = i;
            }
            return min;
        }
        public static int GetMax(int[] numbers)
        {
            int max = numbers[0];
            foreach (int i in numbers)
            {
                if (i > max) max = i;
            }
            return max;
        }
    }
}
