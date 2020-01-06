using System;

namespace Sample01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start.");
            Singleton obj1 = Singleton.getInstance();
            Singleton obj2 = Singleton.getInstance();

            if (obj1 == obj2)
            {
                Console.WriteLine("obj1とobj2は同じインスタンスです。");
            }
            else
            {
                Console.WriteLine("obj1とobj2は同じインスタンスではありません。");
            }

            Console.WriteLine("End.");
        }
    }
}
