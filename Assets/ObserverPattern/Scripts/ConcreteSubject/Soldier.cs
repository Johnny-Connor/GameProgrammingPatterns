// Using for Action, one of the built-in delegates available in this library.
using System;
using UnityEngine;

public class Soldier : MonoBehaviour
{
    /*
    Static events are used to broadcast messages to any listener, regardless of where they
    are in the scene. They are particularly useful in scenarios where the subject and/or
    observer are isolated from each other or are independent objects, such as prefabs or
    plugins.
    Note: it is a good practice to name static events with an OnAny prefix.
    */
    public static event Action OnAnySoldierShoot;
    
    /*
    Non-static events are used for communications between closely related objects within
    the same gameObject hierarchy, such as between a parent and a child. They are not
    visible to other objects outside the hierarchy, making them useful for keeping the
    code isolated.
    Note: it is a good practice to name non-static events with an On prefix.
    */
    public event Action OnSoldierShoot;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) // M1
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        Debug.Log("The soldier fired his gun.");
        /*
        Checking if OnAnySoldierShoot and OnSoldierShoot have any subscribers (not null),
        as invoking (triggering) them without any causes a NullReferenceException error.
        */
        /*
        Note: This is a compact way of writing:
        if (OnSoldierShoot != null)
        {
            OnSoldierShoot.Invoke();
        }
        */
        OnAnySoldierShoot?.Invoke();

        OnSoldierShoot?.Invoke();
    }
}
