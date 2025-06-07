namespace DesignPatterns.Memento;

public class Originator
{
    public string Content { get; set; }

    public IMemento CreateMomento()
    {
        return new Memento(this.Content);
    }
    public void Restore(IMemento memento)
    {
        if (memento is Memento m)
            this.Content = m.Content;
    }

    private class Memento : IMemento
    {
        public string Content;

        public Memento(string content)
        {
            this.Content = content;
        }
    }

    public Originator(string content)
    {
        Content = content;
    }
}
