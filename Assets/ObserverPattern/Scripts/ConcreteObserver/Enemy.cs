using UnityEngine;

public class Enemy : MonoBehaviour
{
    private void OnEnable()
    {
        // Subscribing to event.
        Soldier.OnSoldierShoot += Soldier_OnSoldierShoot;
    }

    private void OnDisable()
    {
        // Unsubscribing from event.
        Soldier.OnSoldierShoot -= Soldier_OnSoldierShoot;
    }

    /*
    Note: it's a good practice to name subscription function/methods using the
    class_event format.
    */
    private void Soldier_OnSoldierShoot()
    {
        Debug.Log("The Enemy has noticed the Soldier.");
    }
}
