using System.Numerics;

namespace Task4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введіть сторони трикутника:");
            Console.WriteLine("Сторона a");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Сторона b");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Сторона c");
            double c = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Чи існує трикутник:");
            Console.WriteLine(IsValidTriangle(a, b, c));

            Console.WriteLine("Периметр трикутника:");
            Console.WriteLine(GetPerimeter(a, b, c));

            Console.WriteLine("Площа трикутника:");
            Console.WriteLine(GetArea(a, b, c));

            Console.WriteLine("Вид трикутника:");
            Console.WriteLine(GetTriangleType(a, b, c));
        }

        public static bool IsValidTriangle(double a, double b, double c)
        {
            if(a > 0 && b > 0 && c > 0)
            {
                if (a + b > c && a + c > b && b + c > a)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public static double GetPerimeter(double a, double b, double c)
        {
            if (IsValidTriangle(a, b, c) == true)
            {
                return a + b + c;
            }
            else
            {
                return 0;
            }
        }
        public static double GetArea(double a, double b, double c)
        {
            if (IsValidTriangle(a, b, c) == true)
            {
                return Math.Sqrt((GetPerimeter(a,b,c)/2)*((GetPerimeter(a,b,c)/2) - a) * ((GetPerimeter(a, b, c) / 2) - b) * ((GetPerimeter(a, b, c) / 2) - c));
            }
            else
            {
                return 0;
            }
        }
        public static string GetTriangleType(double a, double b, double c)
        {
            if (IsValidTriangle(a, b, c) == true)
            {
                if(a == b && b == c && a == c)
                {
                    return "рівносторонній";
                }else if(a == b && b != c && a != c)
                {
                    return "рівнобедрений";
                }else if (Math.Pow(c, 2) == Math.Pow(a, 2) + Math.Pow(b, 2))
                {
                    return "прямокутний";
                }else
                {
                    return "довільний";
                }
            }
            else
            {
                return "не існує трикутника";
            }
        }
    }
}
