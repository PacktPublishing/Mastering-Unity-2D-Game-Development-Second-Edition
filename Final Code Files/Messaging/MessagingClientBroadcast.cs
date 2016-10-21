using UnityEngine;

public class MessagingClientBroadcast : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D col)
    {
        MessagingManager.Instance.Broadcast();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        MessagingManager.Instance.Broadcast();
    }
}
