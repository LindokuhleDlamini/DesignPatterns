using System;

namespace DesignPatterns.ObserverPattern
{
    public class HexaObserver : IObserver
    {
        private ISubject _subject;

        public HexaObserver(ISubject subject)
        {
            _subject = subject;
            _subject.Attach(this);
        }

        public void Update()
        {
            Console.WriteLine("Hexa String: " + Convert.ToString(_subject.GetState(), 16));
        }
    }
}
