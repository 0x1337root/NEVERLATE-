using UnityEngine;

public class CameraFollowScript : MonoBehaviour
{
    public Transform target;

    public Transform camTransform;

    private Vector3 offset;

    private float smoothTime = 0.2f;

    private Vector3 velocity = Vector3.zero;

    void Start()
    {
        offset = camTransform.position - target.position;
    }

    void LateUpdate()
    {
        Vector3 targetPos = target.position + offset;
        camTransform.position = Vector3.SmoothDamp(transform.position, targetPos, ref velocity, smoothTime);
    }
}
