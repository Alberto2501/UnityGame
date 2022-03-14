using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovimientoJugador : MonoBehaviour
{
    //Declaracion de variables
    [Range(1, 20)] public float velocidad;
    Rigidbody2D rb2d;
    SpriteRenderer spRd;

    public Joystick joystick;

    public Canvas canvas;
    private ControlHUD hud;

    private GameManager gameManager;
    private Animator animator;
    private bool IsWalking;
    private bool isJumping;
    [Range(1, 1500)] public float potenciaSalto;
    //Variable para puntuacion para powerUp
    public int puntuacion;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        spRd = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();

        //Control de vidas con GameManager
        gameManager = FindObjectOfType<GameManager>();

        //Control canvas
        hud = canvas.GetComponent<ControlHUD>();

        //Vidas
        hud.setVidasTxt(gameManager.getVidas());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        //float movimientoH = Input.GetAxisRaw("Horizontal");
        float movimientoH;

        if ((joystick.Horizontal >= .2f) | (joystick.Horizontal <= -.2f))
        {
            movimientoH = joystick.Horizontal;
        }
        else
        {
            movimientoH = 0f;
        }

        rb2d.velocity = new Vector2(movimientoH * velocidad, rb2d.velocity.y);
        if (movimientoH > 0)
        {
            spRd.flipX = false;
        }
        else
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

        float movimientoV = joystick.Vertical;

        if (movimientoV >= .5f && !isJumping)
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
            animator.SetBool("isJumping", false);
            rb2d.velocity = new Vector2(rb2d.velocity.x, 0);
        }
        
    }
    public void IncrementarPuntos(int cantidad)
    {
        puntuacion += cantidad;
    }
    public void QuitarVida()
    {
        
        gameManager.decrementarVidas();
        hud.setVidasTxt(gameManager.getVidas());
        if (gameManager.getVidas() == 0)
        {
            //Fin juego
            gameManager.inicializarVidas();
            SceneManager.LoadScene("MenuInicio");
        }
        else {
            
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
            

    }
    public void accionBoton()
    {
        if (!isJumping)
        {
            rb2d.AddForce(Vector2.up * potenciaSalto);
            isJumping = true;
        }
    }
}
