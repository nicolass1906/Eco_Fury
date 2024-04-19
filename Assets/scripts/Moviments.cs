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
    
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");

        transform.Translate(new Vector3(x, 0, 0) * velocity * Time.deltaTime);
    }
}
