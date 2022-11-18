using UnityEngine;

public class Enemy : MonoBehaviour
{
    private void OnEnable()
    {
        // Subscribing to event.
        Player.OnPlayerShoot += NoticePlayer;
    }

    private void OnDisable()
    {
        // Unsubscribing from event.
        Player.OnPlayerShoot -= NoticePlayer;
    }

    private void NoticePlayer()
    {
        Debug.Log("The Enemy has noticed the Player.");
    }
}
