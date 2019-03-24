namespace DesignPatterns.ObserverPattern
{
    public interface ISubject
    {
        void Attach(IObserver observer);

        int GetState();

        void NotifyObservers();

        void SetState(int state);

    }
}
