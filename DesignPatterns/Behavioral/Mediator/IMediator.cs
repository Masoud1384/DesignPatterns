namespace DesignPatterns.Behavioral.Mediator
{
    public interface IMediator
    {
        void Notify(Colleague sender, string eventCode);
    }

}
