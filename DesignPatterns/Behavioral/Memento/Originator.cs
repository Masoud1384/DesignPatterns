namespace DesignPatterns.Behavioral.Memento;

public class Originator
{
    public string Content { get; set; }

    public IMemento CreateMomento()
    {
        return new Memento(Content);
    }
    public void Restore(IMemento memento)
    {
        if (memento is Memento m)
            Content = m.Content;
    }

    private class Memento : IMemento
    {
        public string Content;

        public Memento(string content)
        {
            Content = content;
        }
    }

    public Originator(string content)
    {
        Content = content;
    }
}
