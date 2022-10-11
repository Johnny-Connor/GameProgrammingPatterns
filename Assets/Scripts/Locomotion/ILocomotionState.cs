public interface ILocomotionState
{
    void OnEnter();
    void OnTick();
    void Move(ILocomotionContext context);
    void Stop(ILocomotionContext context);
}
