using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private GameObject gameManager;
    public int vidasGlobal = 3;
    public int puntosGlobal = 0;
    public int puntosAcumulados = 0;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager");
        DontDestroyOnLoad(gameManager);
        SceneManager.LoadScene("PrimeraPantalla");
    }

    public void cambiarEscena(string siguienteScene)
    {
        SceneManager.LoadScene(siguienteScene);
    }
    public int getVidas()
    {
        return this.vidasGlobal;
    }
    public void decrementarVidas()
    {
        vidasGlobal--;
    }
    public void PerderPuntos() {
        puntosAcumulados = 0;
        puntosGlobal = 0;
    }
    public void inicializarVidas()
    {
        vidasGlobal=3;
    }
    public int getPuntos()
    {
        return this.puntosGlobal;
    }
    public void incrementarPuntos(int num)
    {
        puntosGlobal = puntosGlobal + num;
    }
    public void inicializarPuntos()
    {
        puntosGlobal = puntosAcumulados;
    }
    public void acumularPuntos() {
        puntosAcumulados = puntosGlobal;
    }
    public void terminarJuego(bool ganar)
    {
        cambiarEscena("Final");
    }
}
