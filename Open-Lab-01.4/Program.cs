using System;

namespace Open_Lab_01._4
{
    class Program
    {
        public static void Main(string[] args)
        {
            int s = Triangel(4, 2);
            Console.WriteLine(s);
        }
        public static int Triangel(int a, int b)
        {
            return a * b / 2;
        }
    }
}
