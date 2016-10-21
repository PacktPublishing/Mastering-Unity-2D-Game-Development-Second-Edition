using UnityEngine;

public class CameraLookAt : MonoBehaviour
{
    public Vector3 cameraTarget = Vector3.zero;

    void Update()
    {
        transform.LookAt(cameraTarget);
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawLine(transform.position, cameraTarget);
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, cameraTarget);
    }
}
