using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    // Start is called before the first frame update

    bool  isGrounded = false;
    public float jumpforce = 5.0f;

    public float mass = 5.0f;

    private Rigidbody rigidbody;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        rigidbody.mass = mass;
    }

    // Update is called once per frame
    void Update()
    {
        if(!Input.GetKeyDown(KeyCode.Space) || !isGrounded)
        {
            return;
        }


            rigidbody.AddForce(Vector3.up * jumpforce, ForceMode.Impulse);
            new Vector3(0,0,0);
            
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("ground")) 
        {
            isGrounded = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.CompareTag("ground")) 
        {
            isGrounded = false;
        }
    }
}
