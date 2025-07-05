using DesignPatterns.Behavioral.Strategy;


var context = new Context();
// the logic implementation of selecting different strategies is not like the code bellow 
// it must be done in the layer above Context because the Context in this design pattern is just an invoker
// and should not know anything about strategies and logics 
// and also it can be done through DI or using Factory design pattern so still we can get rid of 
// if/else switch statements 

string myData = "this is a data";
context.Execute(new Strategy1(),myData);

if (true)
    context.Execute(new Strategy3(), myData);
else
    context.Execute(new Strategy2(),myData);    


Console.ReadKey();
