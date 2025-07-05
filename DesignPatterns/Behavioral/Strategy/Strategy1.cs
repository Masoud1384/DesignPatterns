namespace DesignPatterns.Behavioral.Strategy
{
    public class Strategy1 : IStrategy
    {
        public void Handle(string data)
        {
            Console.WriteLine($"This is strategy number 1 :Proccessing {data}");
        }
    }
}
