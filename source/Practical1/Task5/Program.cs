namespace Task5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[][] groups =
            {
                new int[] { 60, 71, 90, 76, 64, 81, 83, 78, 93, 70},
                new int[] { 80, 81, 94, 72, 63, 85, 73, 68, 92, 75 },
                new int[] { 66, 79, 97, 71, 77, 82, 84, 98, 65, 74 }
            };
            
            PrintGroupStatistics(groups);
        }

        public static double GetAverage(int[] marks)
        {
            int sum = 0;
            for (int i = 0; i < marks.Length; i++)
            {
                sum += marks[i];
            }
            return (double)sum / marks.Length;
        }
        public static int GetMin(int[] marks)
        {
            int min = marks[0];
            foreach (int i in marks)
            {
                if (i < min) min = i;
            }
            return min;
        }
        public static int GetMax(int[] marks)
        {
            int max = marks[0];
            foreach (int i in marks)
            {
                if (i > max) max = i;
            }
            return max;
        }

        public static void PrintGroupStatistics(int[][] groups)
        {
            for (int i = 0; i < groups.Length; i++)
            {
                double averageMark = GetAverage(groups[i]);
                int minMark = GetMin(groups[i]);
                int maxMark = GetMax(groups[i]);
                Console.WriteLine("Група " + (i + 1) + ": " + "Середній = " + averageMark + ", " + "Мінімальний = " + minMark + ", " + "Максимальний = " + maxMark);
            }
        }
    }
}
