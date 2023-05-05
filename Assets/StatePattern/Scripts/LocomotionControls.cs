using UnityEngine;

public class LocomotionControls : MonoBehaviour
{
    private LocomotionStateMachine _locomotionStateMachine;

    private void Awake() => _locomotionStateMachine = new LocomotionStateMachine(new WalkState());

    private void Update()
    {
        _locomotionStateMachine.Tick();

        if (Input.GetMouseButtonDown(0)) // M1
        {
            _locomotionStateMachine.Move();
        }
        
        if (Input.GetMouseButtonDown(1)) // M2
        {
            _locomotionStateMachine.Stop();
        }
    }
}
