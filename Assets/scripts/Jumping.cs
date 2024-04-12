using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumping : MonoBehaviour
{
    // Start is called before the first frame update

    public bool isGrounded;
    public float jumpForce = 5f;

    public Rigidbody rb;
    public float space = Input.GetAxis("vertical");


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        jumping();
        if(Input.GetKey(KeyCode.Space))
        {

        }
    }

    void jumping()
    {
        Input.GetKey(KeyCode.Space);

        if (Input.GetKey(KeyCode.Space))
        {
            transform.position = Vector3()
        }
    }
}
