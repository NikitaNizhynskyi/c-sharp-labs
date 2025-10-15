using System;
using System.Security.Cryptography.X509Certificates;

namespace Task3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What's your age?");
            string input = Console.ReadLine();

            int age = int.Parse(input);
            Console.WriteLine(ClassifyAge(age));
        }

        public static string ClassifyAge(int age)
        {
            if(age >= 0 && age < 12)
            {
                return "Ви дитина";
            }else if (age >= 12 && age <= 17)
            {
                return "Підліток";
            }else if (age >=18 && age <= 59)
            {
                return "Дорослий";
            }else if (age >= 60 && age <= 120)
            {
                return "Пенсіонер";
            }else
            {
                return "Нереальний вік";
            }
        }
    }
}
