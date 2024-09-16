using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gyroscope1 : MonoBehaviour
{
    public float speed = 5.0f;
    private Rigidbody rb;
    private Vector3 movement;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        Input.gyro.enabled = true;
    }

    void Update()
    {
        float moveHorizontal = Input.gyro.attitude.x;
        float moveVertical = Input.gyro.attitude.y;
        movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement * speed);
    }
}