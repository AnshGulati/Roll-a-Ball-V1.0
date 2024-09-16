using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gyro : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 2.5f;
    public Transform player;
    public Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        // Check if the gyroscope is available on the device
        if (SystemInfo.supportsGyroscope)
        {
            Input.gyro.enabled = true; // Enable the gyroscope
        }
        else
        {
            Debug.LogError("Gyroscope not supported on this device.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Use gyroscope input for movement
        float xMove = Input.gyro.attitude.x;
        float zMove = Input.gyro.attitude.y;

        Vector3 movement = new Vector3(xMove, 0.0f, zMove);
        rb.AddForce(movement * speed);

        // Adjust the camera position based on the gyroscope input
        transform.position = player.position + offset;
    }
}