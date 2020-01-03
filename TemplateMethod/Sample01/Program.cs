using System;

namespace Sample01
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractDisplay d1 = new CharDisplay('H');
            AbstractDisplay d2 = new StringDisplay("Hello, world.");
            AbstractDisplay d3 = new StringDisplay("こんにちは。");

            d1.display();
            d2.display();
            d3.display();
        }
    }
}
