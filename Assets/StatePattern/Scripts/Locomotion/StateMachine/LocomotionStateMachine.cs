public class LocomotionStateMachine : ILocomotionContext
{
    private ILocomotionState _currentState;

    // Sets _currentstate as startingstate and calls its OnEnter method.
    public LocomotionStateMachine(ILocomotionState startingState)
    {
        _currentState = startingState;
        _currentState.OnEnter();
    }

    /*
    These are the actions that the locomotion state machine allows its users to perform:
    - Tick: Updates the algorithm of the current state. Often called in
    MonoBehaviour.Update().
    - Move: Moves the imaginary character.
    - Stop: Stops the imaginary character.
    */
    public void Tick() => _currentState.OnTick();
    public void Move() => _currentState.OnMove(this);
    public void Stop() => _currentState.OnStop(this);

    /*
    Since ideally, SetState should only be used by objects of type ILocomotionState, the
    use of an Explicit Interface Implementation is recommended. This way, SetState will
    only be available if the interface it belongs to is mentioned, preventing classes that
    have access to an LocomotionStateMachine from calling SetState by accident.
    */
    void ILocomotionContext.SetState(ILocomotionState newState)
    {
        _currentState = newState;
        _currentState.OnEnter();
    }
}
