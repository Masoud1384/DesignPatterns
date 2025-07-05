namespace DesignPatterns.Behavioral.Strategy
{
    public class Strategy3 : IStrategy
    {
        public void Handle(string data)
        {
            Console.WriteLine($"This is strategy number 3 :Proccessing {data}");
        }
    }
}
