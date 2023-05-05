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
        Debug.Log("Performed Tick in " + this + ".");
    }

    public void OnMove(ILocomotionContext context)
    {
        Debug.Log("Performed Move in " + this + ".");
    }

    public void OnStop(ILocomotionContext context)
    {
        Debug.Log("Performed Stop in " + this + ".");
        context.SetState(new IdleState());
    }
}
