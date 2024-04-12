using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    // Start is called before the first frame update

    public Rigidbody playerRigidbody;
    private Moviments moviment;
    
    public bool isGrounded;
    public float jumpForce = 5f;
    float Space = Input.GetAxis("vertical");
    void Start()
    {
        moviment = GetComponent<Moviments>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        jumpingforce();
    }

    private void jumpingforce()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            isGrounded = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            isGrounded = false;
        }
    }
}
