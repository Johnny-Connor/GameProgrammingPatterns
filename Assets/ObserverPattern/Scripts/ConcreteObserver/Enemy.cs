using UnityEngine;

public class Enemy : MonoBehaviour
{
    private void OnEnable()
    {
        // Subscribing to event.
        Soldier.OnSoldierShoot += NoticeSoldier;
    }

    private void OnDisable()
    {
        // Unsubscribing from event.
        Soldier.OnSoldierShoot -= NoticeSoldier;
    }

    private void NoticeSoldier()
    {
        Debug.Log("The Enemy has noticed the Soldier.");
    }
}
