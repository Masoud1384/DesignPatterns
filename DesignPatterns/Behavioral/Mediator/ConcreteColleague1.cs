namespace DesignPatterns.Behavioral.Mediator
{
    public class ConcreteColleague1 : Colleague
    {
        public ConcreteColleague1(IMediator mediator) : base(mediator) { }

        private string _data;
        public string Data => _data;

        public void SetData(string value)
        {
            _data = value;
            _mediator.Notify(this, "DataChanged");
        }
    }

}
