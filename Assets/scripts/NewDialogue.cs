using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewDialogue : MonoBehaviour
{
    int index = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F) && transform.childCount > 1)
        {
            transform.GetChild(index).gameObject.SetActive(true);
            index += 1;
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
}
