using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Inimigo : MonoBehaviour
{
    public float velocity = 4.0f;
    private Rigidbody inimigoRb;
    private GameObject player;
    private Transform playerPosition;
    private bool onRange = false;
    public float range = 10.0f;
    private bool touchPlayer = false;
    // Start is called before the first frame update
    void Start()
    {
        inimigoRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
        playerPosition = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        onRange = Vector3.Distance(transform.position, playerPosition.position) < range;


        if (onRange == true)
        {
            inimigoRb.AddForce((player.transform.position - transform.position).normalized * velocity);
        }
        else onRange = false;


        if(touchPlayer == true)
        {
            gameObject.transform.position = new Vector3(21.0f, 1.0f, 0f);
        }
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            touchPlayer = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            touchPlayer = false;
        }
    }
}
