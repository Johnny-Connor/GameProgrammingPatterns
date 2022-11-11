using UnityEngine;

public class LocomotionControls : MonoBehaviour
{
    LocomotionStateMachine _locomotionStateMachine;

    private void Start() {
        _locomotionStateMachine = GetComponent<LocomotionStateMachine>();
    }

    private void Update()
    {
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
