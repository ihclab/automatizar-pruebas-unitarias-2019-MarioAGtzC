using System;

namespace UnitTesting
{
    class Program
    {
        Mean medias = new Mean();

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(Mean.arithmeticMean(1, 43, 5, 7, 8));
            Console.WriteLine(Mean.geometricMean(9, 78, 54));
            Console.WriteLine(Mean.harmonicMean(3, 4, 5));
            Console.ReadKey();
        }
    }
}
