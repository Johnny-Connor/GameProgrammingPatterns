using UnityEngine;

public class SoldierShotsCounter : MonoBehaviour
{
    private int _SoldierShotsCount;

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
    Note: it is a good practice to name subscription function/methods using the
    class_event format.
    */
    private void Soldier_OnSoldierShoot()
    {
        _SoldierShotsCount++;
        Debug.Log("Soldier shots count: " + _SoldierShotsCount + ".");
    }
}
