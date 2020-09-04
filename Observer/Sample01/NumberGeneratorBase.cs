using System.Collections.Generic;

namespace design.pattern.observer.sample01
{
    public abstract class NumberGeneratorBase
    {
        private List<IObserver> observers = new List<IObserver>();

        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void DeleteObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var o in observers)
            {
                o.Update(this);
            }
        }

        public abstract int GetNumber();
        public abstract void Execute();
    }
}
