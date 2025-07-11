namespace DesignPatterns.Behavioral.Observer
{
    public class ConcreteObserver1 : IObserver
    {
        // fetch the data in Pull style
        public void Update(ISubject subject)
        {
            try
            {
                // implement some logic 
                string data = subject.GetData();
                if (data.Contains("2"))
                    throw new Exception();
                else
                    Console.WriteLine("Concrete observer 1 proccessing : " + data);
            }
            catch (Exception e)
            {
                // exception handling per call because if one observer throw exception 
                // the chain of calling all other observers would be ruined
                Console.WriteLine("Concrete class 1 throwned exception");
            }
        }

    }
}
