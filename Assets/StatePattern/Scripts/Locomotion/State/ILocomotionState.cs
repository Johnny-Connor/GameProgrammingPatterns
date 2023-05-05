public interface ILocomotionState
{
    void OnEnter();
    void OnTick();
    void OnMove(ILocomotionContext context);
    void OnStop(ILocomotionContext context);
}
