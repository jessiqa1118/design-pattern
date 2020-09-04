using System;
using System.Threading.Tasks;

namespace design.pattern.observer.sample01
{
    public class GraphObserver : IObserver
    {
        public async void Update(NumberGeneratorBase generator)
        {
            Console.Write("GraphObserver:");
            int count = generator.GetNumber();

            for (int i = 0; i < count; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");

            await Task.Delay(1000);
        }
    }
}
