using UnityEngine;

public class LocomotionStateMachine : MonoBehaviour, ILocomotionContext
{
    private ILocomotionState _currentState = new IdleState();

    private void Awake() => _currentState.OnEnter();

    private void Update() => _currentState.OnTick();

    public void Move() => _currentState.Move(this);

    public void Stop() => _currentState.Stop(this);

    /*
    Since ideally, .SetState should only be used by ILocomotionState's, the use of an
    Explicit Interface Implementation is recommended. This way, .SetState will only be
    available if its interface is mentioned, preventing classes which have access to an
    LocomotionStateMachine from calling .SetState by accident.
    */
    void ILocomotionContext.SetState(ILocomotionState newState)
    {
        _currentState = newState;
        _currentState.OnEnter();
    }
}
