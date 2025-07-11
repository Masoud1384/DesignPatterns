namespace DesignPatterns.Behavioral.Observer
{
    public class ConcreteObserver2 : IObserver
    {
        // fetch the data in Pull style
        public void Update(ISubject subject)
        {
            try
            {
                // implement some logic 
                string data = subject.GetData();
                Console.WriteLine("Concrete observer 2 proccessing : " + data);
            }
            catch (Exception e)
            {
                // exception handling per call because if one observer throw exception 
                // the chain of calling all other observers would be ruined
                Console.WriteLine("Concrete class 2 throwned exception");
            }
        }

    }
}
