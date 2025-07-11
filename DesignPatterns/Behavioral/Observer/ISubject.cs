namespace DesignPatterns.Behavioral.Observer
{
    public interface ISubject
    {
        bool Attach(IObserver observer);
        bool Detach(IObserver observer);
        void Notify();
        string GetData();
    }
}
