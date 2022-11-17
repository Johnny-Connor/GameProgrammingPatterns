using UnityEngine; // Using for Debug.Log.

public class IdleState : ILocomotionState
{
    public void OnEnter()
    {
        Debug.Log("Entered " + this + ".");        
    }

    public void OnTick()
    {
        Debug.Log("A tick from " + this + ".");
    }

    public void Move(ILocomotionContext context)
    {
        Debug.Log("Called Move in " + this + ".");
        context.SetState(new WalkState());        
    }

    public void Stop(ILocomotionContext context)
    {
        Debug.Log("Called Stop in " + this + ".");
    }
}
