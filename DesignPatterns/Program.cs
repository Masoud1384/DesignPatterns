using DesignPatterns.Memento;

// Initialize the first orginator and the care taker 
var originator = new Originator("First");
var history = new CareTaker();
history.Push(originator.CreateMomento());

// Change the content and create new histories
originator.Content = "Second";
history.Push(originator.CreateMomento());

// Just change the content 
originator.Content = "Third";

Console.WriteLine("Current originator content before undo : " + originator.Content );

originator.Restore(history.Pop());
Console.WriteLine("Current originator content after undo : " + originator.Content);

originator.Restore(history.Pop());
Console.WriteLine("Current originator content after second undo : " + originator.Content);



Console.ReadKey();
