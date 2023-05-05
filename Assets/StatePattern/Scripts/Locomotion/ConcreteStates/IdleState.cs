// Using for Debug.Log.
using UnityEngine;

public class IdleState : ILocomotionState
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
        context.SetState(new WalkState());        
    }

    public void OnStop(ILocomotionContext context)
    {
        Debug.Log("Performed Stop in " + this + ".");
    }
}
