using System;

namespace BattingAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the place name");
            string strName = Console.ReadLine();
            Console.WriteLine("Enter the number of hits");
            double nHits = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of bats");
            double nBats = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(strName + "'s batting average is: " +nHits/nBats);
            Console.WriteLine("{0}'s batting average is {1}", strName, nHits / nBats);
            
        }
    }
}
