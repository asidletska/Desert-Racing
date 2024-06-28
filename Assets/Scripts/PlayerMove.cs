using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Transform player;
    public float movementSpeed = 10;
    public float turningSpeed = 60;
    public float vertical, horizontal;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
           player.transform.position = Vector3.forward * movementSpeed;
        }
    }
}
