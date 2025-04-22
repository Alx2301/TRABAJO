using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class CambioIdiomas : MonoBehaviour
{
    public TextMeshProUGUI botonFuegoText;
    public TextMeshProUGUI botonAguaText;
    public TextMeshProUGUI botonTierraText;
    public int i = 0;

    string[,] matrizIdiomas = new string[3, 3]
    {
        {"Fuego", "Agua", "Tierra"},
        {"Lume","Auga", "Terra" },
        { "Fire","Water","Land" }
    };
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //botonFuegoText.text = matrizIdiomas[i,0];
        //botonAguaText.text= matrizIdiomas[i, 1];
        //botonTierra.text = matrizIdiomas[i, 2];
    }

    // PONER EL NOMBRE DEL BOTON CON EL QUE SE CAMBIARA EL TEXTO o lo donde se cambie el texto
    void Update()
    {
        //botonFuegoText.text = matrizIdiomas[i, 0];
        //botonAguaText.text = matrizIdiomas[i, 1];
        //botonTierra.text = matrizIdiomas[i, 2];
    } 

    public void Espanol()
    { 
        i=0;
    }
    public void Galego()
    {
        i = 1;
    }
    public void English() 
    {
        i = 2;
    }

    public void MenuDropDrown(int index) 
    {
        switch (index) 
        {
            case 0:
                i = 0;
                break;
            case 1:
                i = 1;
                break;
            case 2:
                i = 2;
                break;
        }
    }

}
