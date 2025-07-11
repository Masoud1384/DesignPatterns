
namespace DesignPatterns.Behavioral.Observer
{
    public class Subject : ISubject
    {
        private List<IObserver> _observers;
        public Subject()
        {
            _observers = new List<IObserver>();
        }

        private string _data;
        public string Data
        {
            get
            {
                return _data;
            }
            set
            {
                _data = value;
                Notify();
            }
        }

        public bool Attach(IObserver observer)
        {
            lock (this)
            {
                if (!_observers.Contains(observer))
                {
                    _observers.Add(observer);
                    return true;
                }
                return false;
            }
        }

        public bool Detach(IObserver observer)
        {
            return _observers.Remove(observer);
        }

        public string GetData()
        {
            return Data;
        }

        public void Notify()
        {
            // detach and attach can be both call here or somewehere else
            // also this method can filter or sort the observers 
            List<IObserver> observers;
            lock (this)
            {
                if (_observers == null || _observers.Count <= 0)
                    return;

                observers = _observers.ToList();
            }
            foreach (var observer in observers)
                observer.Update(this);

        }
    }
}
