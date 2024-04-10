using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Moviments : MonoBehaviour
{
    // Start is called before the first frame update

    public float velocity = 2.0f;
    public float rotation = 180.0f;

    public float Rigidbody;
    public float JumpForce;

    public LayerMask Layermask;
    public bool IsGrounded;
    public float GroundCheckSize;
    public Vector3 GroundCheckPosition;
    
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");

        transform.Translate(new Vector3(0, x, 0) * velocity * Time.deltaTime);

        var groundcheck = Physics.OverlapSphere(transform.position + GroundCheckPosition, GroundCheckSize, Layermask);
        
    }

    private void OnDrawGizmos()
    {
       Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position + GroundCheckPosition, GroundCheckSize);
    }
}
