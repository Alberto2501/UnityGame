using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ControlHUD : MonoBehaviour
{
    public TextMeshProUGUI vidasTxt;
    public TextMeshProUGUI powerUpsTxt;

    public void setVidasTxt(int vidas)
    {
        vidasTxt.text = vidas.ToString();
    }
    public void setPowerUpsTxt(int cuantos)
    {
        powerUpsTxt.text = cuantos.ToString();
    }
}
