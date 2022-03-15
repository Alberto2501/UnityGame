using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlMenu : MonoBehaviour
{
    //GameManager gameManager;
    public void OnButtonJugar()
    {
        //Vuelve a poner el número de vidas en 3
        //gameManager = FindObjectOfType<GameManager>();
        //gameManager.inicializarVidas();

        SceneManager.LoadScene("Level1");
    }

    public void OnButtonAjustes()
    {
        SceneManager.LoadScene("MenuAjustes");
    }

    public void OnButtonSalir()
    {
        Application.Quit();
    }

    public void OnButtonMenu()
    {
        SceneManager.LoadScene("MenuInicio");
    }
}
