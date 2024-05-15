using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vida : MonoBehaviour
{
    // Start is called before the first frame update

    private bool isTouch = false;

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if(isTouch == true) 
        {
            transform.Translate(gameObject.transform.position = new Vector3(0f, 0.5f, 0f));
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Trap"))
        {
            isTouch = true;
        }

        if(collision.gameObject.CompareTag("inimigo"))
        {
            isTouch = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.CompareTag("Trap"))
        {
            isTouch = false;
        }

         if(collision.gameObject.CompareTag("inimigo"))
        {
            isTouch = false;
        }
    }
}
