using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NPCSystem : MonoBehaviour

{
    public GameObject d_Template;
    public GameObject canva;

    private bool playerDetection = false;
    // Start is called before the first frame update
    void Start()
    {
        canva.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (playerDetection == true && Input.GetKeyDown(KeyCode.F))
        {
            canva.SetActive(true);
            NewDialogue("Ta funfando");
            canva.transform.GetChild(1).gameObject.SetActive(true);
        }
    }

    void NewDialogue(string text)
    {
        GameObject template_clone = Instantiate(d_Template, d_Template.transform); 
        template_clone.transform.parent = canva.transform;
        template_clone.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = text;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            playerDetection = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            playerDetection = false;
        }
              
    }
}
