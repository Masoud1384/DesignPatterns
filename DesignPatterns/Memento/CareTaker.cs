namespace DesignPatterns.Memento;

public class CareTaker
{
    public List<IMemento> Mementos { get; set; } = new();

    public void Push(IMemento memento)
    {
        this.Mementos.Add(memento);
    }

    public IMemento Pop()
    {
        var lastIndex = Mementos.Count - 1;
        var lastItem = Mementos[lastIndex];
        Mementos.Remove(Mementos.Last());

        return lastItem;
    }
}
