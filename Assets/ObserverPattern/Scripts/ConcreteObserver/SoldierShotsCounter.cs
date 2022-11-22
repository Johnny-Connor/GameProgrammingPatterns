using UnityEngine;

public class SoldierShotsCounter : MonoBehaviour
{
    private int _SoldierShotsCount;

    private void OnEnable()
    {
        // Subscribing to event.
        Soldier.OnSoldierShoot += IncrementSoldierShotsCount;
    }

    private void OnDisable()
    {
        // Unsubscribing from event.
        Soldier.OnSoldierShoot -= IncrementSoldierShotsCount;
    }

    private void IncrementSoldierShotsCount()
    {
        _SoldierShotsCount++;
        Debug.Log("Soldier shots count: " + _SoldierShotsCount + ".");
    }
}
