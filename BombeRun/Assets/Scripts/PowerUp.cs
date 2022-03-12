using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public int cantidad;

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.CompareTag("Player")) {
            collision.gameObject.GetComponent<MovimientoJugador>().IncrementarPuntos(cantidad);
            Destroy(gameObject);
        }
    }
}
