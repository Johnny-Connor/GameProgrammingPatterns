using UnityEngine;

public class WalkState : ILocomotionState
{
    public void OnEnter()
    {
        Debug.Log(this + ":Entered");        
    }

    public void OnTick()
    {
        Debug.Log(this + ":Ticked");
    }

    public void Move(ILocomotionContext context)
    {
        Debug.Log(this + ":Moved");
    }

    public void Stop(ILocomotionContext context)
    {
        Debug.Log(this + ":Stopped");
        context.SetState(new IdleState());
    }
}
