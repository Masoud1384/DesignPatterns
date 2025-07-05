namespace DesignPatterns.Behavioral.State;

public class Context
{
    private IState _state;

    // for changing the state when the state is not being updated inside state itself
    // and must be changed from the outside
    // external transition is not suggested for this pattern
    // because it is not compatible with designs structure and intentions 
    // it voiolates SRP and OCP

    public void SetState(IState state)
    {
        _state = state;
    }

    public void Request()
    {
        if (_state == null)
            Console.WriteLine("Declare state first");

        _state.Handle(this);
    }
}
