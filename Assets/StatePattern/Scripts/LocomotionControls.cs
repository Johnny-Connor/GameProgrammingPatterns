using UnityEngine;

public class LocomotionControls : MonoBehaviour
{
    LocomotionStateMachine _locomotionStateMachine;

    private void Start() {
        _locomotionStateMachine = GetComponent<LocomotionStateMachine>();
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1")) // M1
        {
            _locomotionStateMachine.Move();
        }
        if (Input.GetButtonDown("Fire2")) // M2
        {
            _locomotionStateMachine.Stop();
        }
    }
}
