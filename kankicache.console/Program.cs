using System;
using kankicache;

namespace kankicache.console
{
    class Program
    {
        public static string key = "key-test";
        static void Main(string[] args)
        {
            Console.WriteLine(CalculateTest());
            Console.WriteLine(CalculateTest());
            KankiCache.RemoveValue(key);
            Console.WriteLine(CalculateTest());
            KankiCache.RemoveValue(key);
        }

        public static string CalculateTest()
        {
            int number = 0;

            if (KankiCache.HasValue(key))
            {
                Console.WriteLine("cache var");
                number = Convert.ToInt32(KankiCache.GetValue(key));
            }
            else
            {
                Console.WriteLine("cache yok");
                for (int i = 0; i < 1000000000; i++)
                {
                    number += i;
                }

                KankiCache.AddValue(key, number);
            }

            return number.ToString();
        }
    }
}