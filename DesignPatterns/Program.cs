using DesignPatterns.Behavioral.Mediator;

var mediator = new ConcreteMediator();

var col1 = new ConcreteColleague1(mediator);
var col2 = new ConcreteColleague2(mediator);
var col3 = new ConcreteColleague3(mediator);

mediator.SetColleagues(col1, col2, col3);

col1.SetData("");

Console.WriteLine($"Col1: {col1.Data}");
Console.WriteLine($"Col2: {col2.Data}");
Console.WriteLine($"Col3: {col3.Data}");


Console.ReadLine();