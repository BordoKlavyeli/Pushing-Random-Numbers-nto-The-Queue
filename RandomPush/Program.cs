using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace RandomPush
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue sayilar = new Queue();
            Random rand = new Random();
            for (int i = 100; i > 0; i--)
            {
                int random = rand.Next(30, 2000);
                sayilar.Enqueue(random);
                System.Threading.Thread.Sleep(750);
                Console.Clear();
                if (i < 96)
                {
                    sayilar.Dequeue();
                }
                show(sayilar);
            }
            Console.ReadKey();
        }
        public static void show(Queue sayilar)
        {
            object obj = new object();
            Queue yeniyigin = (Queue)sayilar.Clone();
            if (sayilar.Count > 0)
            {
                while (yeniyigin.Count > 0)
                {
                    obj = yeniyigin.Dequeue();
                    Console.WriteLine("\t {0}", obj.ToString());
                }
            }
            else
                Console.WriteLine("\nYığın boş!");
        }
    }
}
