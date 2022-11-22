// Using for Action, one of the built-in delegates available in this library.
using System;
using UnityEngine;

public class Soldier : MonoBehaviour
{
    /*
    Note 1: declaring the event as static to prevent observers from being too coupled to
    their subjects.
    Note 2: it's a good practice to name events with an On prefix.
    */
    public static event Action OnSoldierShoot;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) // M1
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        Debug.Log("Soldier fired his gun.");
        /*
        Checking if OnSoldierShoot has any subscribers (not null), as triggering it without
        any causes a NullReferenceException error.
        Note: This is a compact way of writing:
        if (OnSoldierShoot != null)
        {
            OnSoldierShoot.Invoke();
        }
        */
        OnSoldierShoot?.Invoke();
    }
}
