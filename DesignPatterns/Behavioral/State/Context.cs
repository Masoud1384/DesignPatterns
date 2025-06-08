namespace DesignPatterns.Behavioral.State;

public class Context
{
    private IState _state;

    // for changing the state when the state is not being updated inside state itself
    // and must be changed from the outside
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
