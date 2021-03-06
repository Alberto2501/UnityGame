using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuerteCaida : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<MovimientoJugador>().reiniciarPuntos();
            collision.gameObject.GetComponent<MovimientoJugador>().QuitarVida();
        }
    }

}
