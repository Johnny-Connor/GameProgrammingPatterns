using UnityEngine;

// This component was also inserted in 'Player'.
public class PlayerControls : MonoBehaviour
{
    LocomotionStateMachine _locomotionStateMachine;

    private void Start() {
        _locomotionStateMachine = GetComponent<LocomotionStateMachine>();
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1")) // M1
        {
            Debug.Log("Fire1"); // Print working.
            _locomotionStateMachine.Crouch();
        }
        if (Input.GetButtonDown("Fire2")) // M2
        {
            Debug.Log("Fire2"); // Print working.
            _locomotionStateMachine.Jump();
        }
        if (Input.GetButtonDown("Fire3")) // M3
        {
            Debug.Log("Fire3"); // Print working.
            _locomotionStateMachine.Fall();
        }
        if (Input.GetButtonDown("Jump")) // Space
        {
            Debug.Log("Jump"); // Print working.
            _locomotionStateMachine.Land();
        }
    }
}