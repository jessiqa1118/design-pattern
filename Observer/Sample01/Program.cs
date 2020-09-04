using System;

namespace design.pattern.observer.sample01
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberGeneratorBase generator = new RandomNumberGenerator();
            IObserver observer1 = new DigitObserver();
            IObserver observer2 = new GraphObserver();

            generator.AddObserver(observer1);
            generator.AddObserver(observer2);

            generator.Execute();
        }
    }
}
