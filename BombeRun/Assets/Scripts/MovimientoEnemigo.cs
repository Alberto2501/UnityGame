using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoEnemigo : MonoBehaviour
{
    public float velocidad;
    public Vector3 posicionFin;
    private Vector3 posicionInicio;
    private bool moviendoAFin;
    private SpriteRenderer sPrd;
    public bool toFlip;

    // Start is called before the first frame update
    void Start()
    {
        posicionInicio = transform.position;
        moviendoAFin = true;
        sPrd = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        MoverEnemigo();
    }

    private void MoverEnemigo()
    {
        Vector3 posicionDestino = (moviendoAFin) ? posicionFin : posicionInicio;
        transform.position = Vector3.MoveTowards(transform.position, posicionDestino, velocidad * Time.deltaTime);
        
    }
    
    
}
