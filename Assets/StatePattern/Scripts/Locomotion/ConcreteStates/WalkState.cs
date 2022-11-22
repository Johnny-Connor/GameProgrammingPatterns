// Using for Debug.Log.
using UnityEngine;

public class WalkState : ILocomotionState
{
    public void OnEnter()
    {
        Debug.Log("Entered in " + this + ".");      
    }

    public void OnTick()
    {
        Debug.Log("A tick from " + this + ".");
    }

    public void Move(ILocomotionContext context)
    {
        Debug.Log("Called Move in " + this + ".");
    }

    public void Stop(ILocomotionContext context)
    {
        Debug.Log("Called Stop in " + this + ".");
        context.SetState(new IdleState());
    }
}
