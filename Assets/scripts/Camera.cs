using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform characterBody;
    public Transform characterHead;

    float rotationX = 0;
    float rotationY = 0;

    void Start()
    {
        
    }

    private void LateUpdate()
    {
        transform.position = characterHead.position;
    }

    void Update()
    {
        float vertical = Input.GetAxisRaw("Mouse Y");
        float horizontal = Input.GetAxisRaw("Mouse X");

        rotationX += horizontal;
        rotationY += vertical;

        characterBody.localEulerAngles = new Vector3(0, rotationX, 0);

        transform.localEulerAngles =new Vector3(rotationY, rotationX, 0);
    }
}
