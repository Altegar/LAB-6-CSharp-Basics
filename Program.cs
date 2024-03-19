// Сушинський Ігор
// Лабораторна робота № 6
// Літерні рядки.
// Варіант 3

namespace LAB_6_CSharp
{
    internal class Program
    {
        private static int Count(string s)
        {
            int count = 0;
            foreach (char c in s)
            {
                if (c == ',')
                    count++;
            }
            return count;
        }

        private static string Change(string s)
        {
            string t = s.Replace(",", "**");
            return t;
        }

        private static void Main(string[] args)
        {
            Console.WriteLine("s = ");
            string s = Console.ReadLine();
            Console.WriteLine($"',' includes {Count(s)} times");
            Console.WriteLine($"new string = {Change(s)}");
        }
    }
}