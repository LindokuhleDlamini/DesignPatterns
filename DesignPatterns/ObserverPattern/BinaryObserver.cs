using System;

namespace DesignPatterns.ObserverPattern
{
    public class BinaryObserver : IObserver
    {
        private ISubject _subject;

        public BinaryObserver(ISubject subject)
        {
            _subject = subject;
            _subject.Attach(this);
        }

        public void Update()
        {
            Console.WriteLine("Binary String: " + Convert.ToString(_subject.GetState(), 2));
        }
    }
}
