 using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    private Vector3 offset;
    public float smoothspeed = 0.03f;
    void Start()
    {
        offset = transform.position - target.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 desiredPosition = Vector3.Lerp(transform.position, target.position + offset, smoothspeed);
        transform.position = desiredPosition;
    }
}
