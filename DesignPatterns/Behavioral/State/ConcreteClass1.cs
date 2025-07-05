namespace DesignPatterns.Behavioral.State;

public class ConcreteClass1 : IState
{
    public void Handle(Context context)
    {
        Console.WriteLine("This is Concrete class 1");

        // by adding the code below we are changing the state of the context in the state itself 
        // therefore it's not necessary to do the state chaning in somewhere else 
        // and it's being done here automatically so in the Program.cs , there is no need to do it again
        // just call the Request() again and it will call ConcreteClass2
        // EXTERNAL TRANSITION VOIOLATES STATE RULES
        context.SetState(new ConcreteClass2());
    }
}
