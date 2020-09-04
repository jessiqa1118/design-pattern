using System;
using System.Threading.Tasks;

namespace design.pattern.observer.sample01
{
    public class DigitObserver : IObserver
    {
        public async void Update(NumberGeneratorBase generator)
        {
            Console.WriteLine($"DigitObserver: {generator.GetNumber()}");
            await Task.Delay(1000);
        }
    }
}
