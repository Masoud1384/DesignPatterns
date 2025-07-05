namespace DesignPatterns.Behavioral.Strategy
{
    public class Context
    {
        // we can have this and pass the interface through constructor
        // and also we can get it from Resolve args

        //private IStrategy _strategy;
        //public Context(IStrategy strategy)
        //{
        //    _strategy = strategy;
        //}

        // and also we can have setters of strategy 

        //public void ChangeStrategy(IStrategy strategy)
        //{
        //    _strategy = strategy;
        //}

        public void Execute(IStrategy strategy,string data)
        {
            strategy.Handle(data);
        }
    }
}
