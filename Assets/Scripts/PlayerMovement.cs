using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public float jumpforce = 7f;
    public Rigidbody rb;
    private bool jumpkeypressed=true;
    private float zMove;
    private float xMove;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        xMove = Input.GetAxis("Vertical");
        zMove = Input.GetAxis("Horizontal") * (-1); 


        if (jumpkeypressed && Input.GetKeyUp(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpforce, ForceMode.VelocityChange);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            jumpkeypressed = false;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            jumpkeypressed = true;
        }
        
    }

    public void JumpPlayer()
    {       
            rb.AddForce(Vector3.up * jumpforce, ForceMode.VelocityChange);
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector3(xMove * speed, rb.velocity.y, zMove * speed);

        if (rb.position.y < -1f) 
        {
            // This will call the function EndGame of GameManager script. 
            FindObjectOfType<GameManager>().EndGame();
        }
    }

}
