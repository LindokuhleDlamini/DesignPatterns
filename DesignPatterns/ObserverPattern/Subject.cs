using System.Collections.Generic;

namespace DesignPatterns.ObserverPattern
{
    public class Subject : ISubject
    {
        private IList<IObserver> _observers;
        private int _state;

        public Subject()
        {
            _observers = new List<IObserver>();
        }

        public int GetState()
        {
            return _state;
        }

        public void SetState(int state)
        {
            _state = state;
            NotifyObservers();
        }

        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update();
            }
        }

        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }
    }
}
