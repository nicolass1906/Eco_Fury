using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    //variavel que determina a velocidade do player
    public float velocity = 5f;
    public float velocityRun = 7f;
    public float rotation = 180.0f;

    //variavel que determina se esta ou não tocando o chão
    bool isGrounded = false;
    //variavel que determina a força do pulo
    public float jumpforce = 5.0f;
    //variavel que determina a massa do personagem
    public float mass = 5.0f;
    //variavel da classe de rigidbody
    private Rigidbody rigidbody;
    void Start()
    {
        //a variavel de rigidbody recebe o rigidbody do player
        rigidbody = GetComponent<Rigidbody>();
        rigidbody.mass = mass;
    }

    // Update is called once per frame
    void Update()
    {
        //variaveis que determina as teclas e a direção do player
        float x = Input.GetAxis("Vertical");
        float y = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(x, 0, y) * velocity * Time.deltaTime);

        //verifica se a tecla "Shift esquerdo" foi acionada, se for acionada, a velocidade do player aumenta
        if (Input.GetKey(KeyCode.LeftShift))
        {
            transform.Translate(new Vector3(x, 0, y) * velocity * 1.2f * Time.deltaTime); 
        }

        //verifica se o player tem condição de pular, sendo elas, pressionar a tecla de pulo e estar no chão
        if (!Input.GetKeyDown(KeyCode.Space) || !isGrounded)
        {
            return;
        }

        //adicona uma força pra cima no rigidbody do player
        rigidbody.AddForce(Vector3.up * jumpforce, ForceMode.Impulse);
        new Vector3(0, 0, 0);
    }

    private void OnCollisionEnter(Collision collision)
    {
        //verifica se o player teve contato com o objeto "ground"
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
