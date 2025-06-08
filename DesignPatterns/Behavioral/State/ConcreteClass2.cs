namespace DesignPatterns.Behavioral.State;

public class ConcreteClass2 : IState
{
    public void Handle(Context context)
    {
        Console.WriteLine("This is Concrete class 2");
    }
}
