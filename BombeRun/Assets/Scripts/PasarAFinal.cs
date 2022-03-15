using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PasarAFinal : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<MovimientoJugador>().inicializarVidas();
            collision.gameObject.GetComponent<MovimientoJugador>().perderTodosLosPuntos();
            SceneManager.LoadScene("FinalVictoria");

        }
    }
}
