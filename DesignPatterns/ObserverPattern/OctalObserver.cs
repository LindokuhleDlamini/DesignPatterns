using System;

namespace DesignPatterns.ObserverPattern
{
    public class OctalObserver : IObserver
    {
        private ISubject _subject;

        public OctalObserver(ISubject subject)
        {
            _subject = subject;
            _subject.Attach(this);
        }

        public void Update()
        {
            Console.WriteLine("Octal String: "+ Convert.ToString(_subject.GetState(), 8));
        }
    }
}
