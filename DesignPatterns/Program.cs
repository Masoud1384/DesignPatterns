using DesignPatterns.Behavioral.Observer;

var subject = new Subject();
var con1 = new ConcreteObserver1();
var con2 = new ConcreteObserver2();
subject.Attach(con1);
subject.Attach(con2);



subject.Data = "This is data number 1";

// further in the code 

subject.Data = "This is data number 2";
Console.ReadKey();
