using UnityEngine; // Using for Debug.Log("");

public class IdleState : ILocomotionState
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
        context.SetState(new WalkState());        
    }

    public void Stop(ILocomotionContext context)
    {
        Debug.Log(this + ":Stopped");
    }
}
