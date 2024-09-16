using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gyrojumprestrict : MonoBehaviour
{
    public Rigidbody rb;
    public float jumpforce = 7f;
    private bool jumpkeypressed = true;

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
        if (jumpkeypressed && Input.GetKeyUp(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpforce, ForceMode.VelocityChange);
        }
    }
    public void Update()
    {
        JumpPlayer();
    }
    
    
}
