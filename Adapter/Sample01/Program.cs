using System;

namespace Sample01
{
    class Program
    {
        static void Main(string[] args)
        {
            Print p = new PrintBanner("Hello");
            p.printWeak();
            p.printStrong();
        }
    }
}
