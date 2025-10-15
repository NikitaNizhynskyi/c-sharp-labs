using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Task1
{
    public class Program
    {
        public static bool IsEven(int number)
        {
            return (number % 2 == 0)? true: false;
        }

        public static string GetMessage(int number)
        {
            if (IsEven(number))
            {
                return "Двері відкриваються!";
            }
            return "Двері зачинені...";
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Введіть ціле будь-яке число ( щоб відкрити двері):");
            string input = System.Console.ReadLine();

            int number = int.Parse(input);
            Console.WriteLine(GetMessage(number));
        }
    }
}
