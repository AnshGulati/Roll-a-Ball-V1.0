using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Gyroscope = UnityEngine.Gyroscope;

public class gyromove : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 10f;
    Gyroscope Gyro;
    // Start is called before the first frame update
    void Start()
    {
        Gyro = Input.gyro;
        Gyro.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3(Input.acceleration.y,0f,-Input.acceleration.x);
        rb.AddForce(movement*speed);
    }

    private void FixedUpdate()
    {
        if (rb.position.y < -1f)
        {
            // This will call the function EndGame of GameManager script. 
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
