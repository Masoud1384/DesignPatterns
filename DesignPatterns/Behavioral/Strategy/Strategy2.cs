namespace DesignPatterns.Behavioral.Strategy
{
    public class Strategy2 : IStrategy
    {
        public void Handle(string data)
        {
            Console.WriteLine($"This is strategy number 2 :Proccessing {data}");
        }
    }
}
