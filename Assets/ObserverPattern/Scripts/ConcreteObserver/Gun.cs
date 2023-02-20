using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] private Soldier _soldier;

    private void OnEnable()
    {
        // Subscribing to event.
        _soldier.OnSoldierShoot += Soldier_OnSoldierShoot;
    }

    private void OnDisable()
    {
        // Unsubscribing from event.
        _soldier.OnSoldierShoot -= Soldier_OnSoldierShoot;
    }

    /*
    Note: it is a good practice to name subscription function/methods using the
    class_event format.
    */
    private void Soldier_OnSoldierShoot()
    {
        Debug.Log("Playing imaginary Gun animation.");
    }
}
