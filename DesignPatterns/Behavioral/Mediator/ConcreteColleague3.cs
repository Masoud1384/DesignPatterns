namespace DesignPatterns.Behavioral.Mediator
{
    public class ConcreteColleague3 : Colleague
    {
        public ConcreteColleague3(IMediator mediator) : base(mediator)
        {
            _data = new Random().Next(int.MinValue, int.MaxValue); 
        }

        private int _data;
        public int Data => _data;

        public void SetIntData(int value)
        {
            _data = value;
            _mediator.Notify(this, "IntChanged");
        }
    }

}
