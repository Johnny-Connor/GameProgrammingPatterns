using UnityEngine;

public class Zombie : MonoBehaviour
{
    private void OnEnable()
    {
        // Subscribing to event.
        Soldier.OnAnySoldierShoot += Soldier_OnAnySoldierShoot;
    }

    private void OnDisable()
    {
        // Unsubscribing from event.
        Soldier.OnAnySoldierShoot -= Soldier_OnAnySoldierShoot;
    }

    // Note: it is a good practice to name event handlers using the class_event format.
    private void Soldier_OnAnySoldierShoot()
    {
        Debug.Log("The Zombie has noticed the Soldier.");
    }
}
