namespace DesignPatterns.Behavioral.Mediator
{
    public class ConcreteColleague2 : Colleague
    {
        public ConcreteColleague2(IMediator mediator) : base(mediator) { }

        private bool _data;
        public bool Data => _data;

        public void SetBoolData(bool value)
        {
            _data = value;
            _mediator.Notify(this, "BoolChanged");
        }
    }

}
