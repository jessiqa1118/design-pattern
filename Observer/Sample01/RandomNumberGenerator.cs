using System;

namespace design.pattern.observer.sample01
{
    public class RandomNumberGenerator : NumberGeneratorBase
    {
        private Random random = new Random();
        private int number;

        public override int GetNumber()
        {
            return number;
        }

        public override void Execute()
        {
            for (int i = 0; i < 20; i++)
            {
                number = random.Next(50);
                NotifyObservers();
            }
        }
    }
}