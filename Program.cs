using System;

namespace Cache.Lru
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("LRU Cache.");
            LruCache<int, string> cache = new LruCache<int, string>();
            Console.ReadLine();
        }
    }
}
