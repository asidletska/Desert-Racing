using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform Car;
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        transform.position = Car.position + offset;
    }
}
