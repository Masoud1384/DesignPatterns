namespace DesignPatterns.Behavioral.Mediator
{
    // Abstract base class for all colleagues
    public abstract class Colleague
    {
        protected IMediator _mediator;

        public Colleague(IMediator mediator)
        {
            _mediator = mediator;
        }
    }

}
