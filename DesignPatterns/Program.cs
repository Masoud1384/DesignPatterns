using DesignPatterns.Behavioral.State;


var context = new Context();
// set the state
context.SetState(new ConcreteClass1());
// use the behavior based on the current state
context.Request();
// change state 
context.SetState(new ConcreteClass2());
// use the changed begavior 
context.Request();


Console.ReadKey();
