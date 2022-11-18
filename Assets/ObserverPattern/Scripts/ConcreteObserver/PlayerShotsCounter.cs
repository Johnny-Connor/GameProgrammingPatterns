using UnityEngine;

public class PlayerShotsCounter : MonoBehaviour
{
    private int _playerShotsCount;

    private void OnEnable()
    {
        // Subscribing to event.
        Player.OnPlayerShoot += IncrementPlayerShotsCount;
    }

    private void OnDisable()
    {
        // Unsubscribing from event.
        Player.OnPlayerShoot -= IncrementPlayerShotsCount;
    }

    private void IncrementPlayerShotsCount()
    {
        _playerShotsCount++;
        Debug.Log(nameof(_playerShotsCount) + ": " + _playerShotsCount);
    }
}
