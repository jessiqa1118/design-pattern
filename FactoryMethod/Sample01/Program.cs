using System;
using Framework;
using Idcard;

class Program
{
    static void Main(string[] args)
    {
        Factory factory = new IDCardFactory();
        Product card1 = factory.create("Jessica");
        Product card2 = factory.create("karen");
        Product card3 = factory.create("Yuria");
        card1.use();
        card2.use();
        card3.use();
    }
}
