using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoJugador : MonoBehaviour
{
    //Declaracion de variables
    [Range(1, 10)] public float velocidad;
    Rigidbody2D rb2d;
    SpriteRenderer spRd;

    private Animator animator;

    bool isJumping = false;
    [Range(1, 500)] public float potenciaSalto;
    //Variable para puntuacion para powerUp
    public int puntuacion;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        spRd = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        float movimientoH = Input.GetAxisRaw("Horizontal");
        rb2d.velocity = new Vector2(movimientoH * velocidad, rb2d.velocity.y);
        if (movimientoH > 0)
        {
            spRd.flipX = false;
        }else
        {
            if (movimientoH < 0)
            {
                spRd.flipX = true;
            }
        }


        if (movimientoH != 0)
        {
            animator.SetBool("IsWalking", true);
        }
        else
        {
            animator.SetBool("IsWalking", false);
        }
        if(Input.GetButton("Jump") && !isJumping)
        {
            rb2d.AddForce(Vector2.up * potenciaSalto);
            isJumping = true;
        }
       

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Suelo"))
        {
            isJumping=false;
            rb2d.velocity = new Vector2(rb2d.velocity.x, 0);
        }
    }
    public void IncrementarPuntos(int cantidad)
    {
        puntuacion += cantidad;
    }
}
