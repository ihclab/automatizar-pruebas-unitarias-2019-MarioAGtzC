using System;

namespace UnitTesting
{
    class Program
    {
        Mean medias = new Mean();
        ReadFile rf = new ReadFile();

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(ReadFile.readFile());
            Console.ReadKey();
        }
    }
}
