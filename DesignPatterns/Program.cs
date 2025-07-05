using DesignPatterns.Behavioral.State;


var context = new Context();
// set the state
context.SetState(new ConcreteClass1());
// use the behavior based on the current state 
// this would be the first state
context.Request();

if (true)
{
    // this would be the second state 
    context.Request();
}
Console.ReadKey();
