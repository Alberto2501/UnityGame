using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private GameObject gameManager;
    public int vidasGlobal;

    public string mensajeFinal;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager");
        DontDestroyOnLoad(gameManager);
        SceneManager.LoadScene("MenuInicio");
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
    public void inicializarVidas()
    {
        vidasGlobal=3;
    }
    public void terminarJuego(bool ganar)
    {
        mensajeFinal = (ganar) ? "Felicidades has terminado el juego" : "Uuuuuuuhhh has perdido";
        cambiarEscena("Final");
    }
    public string getMensajeFinal()
    {
        return this.mensajeFinal;
    }
}
