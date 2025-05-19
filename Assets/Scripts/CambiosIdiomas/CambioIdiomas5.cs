using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using System.Runtime.InteropServices.WindowsRuntime;

//poner el valor del cambio de idiomas 1 al 2, para cuando se cambie el idioma en las opciones, se cambie en todas las pantallas (escenas)
public class CambioIdiomas5 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public TextMeshProUGUI titulotutod;
    public TextMeshProUGUI titulotutoa;
    public TextMeshProUGUI titulotutos;
    public TextMeshProUGUI titulotutow;
    public TextMeshProUGUI textd;
    public TextMeshProUGUI texta;
    public TextMeshProUGUI texts;
    public TextMeshProUGUI textw;
    public TextMeshProUGUI titulorecompesa;
    public TextMeshProUGUI titulomision;
    public TextMeshProUGUI textmision;
    public TextMeshProUGUI textpuntos;
    

    public int i = 0;


    string[,] matrizIdiomas = new string[3, 9]
    {
        {"Tutoríal","Para ir hacia arriba, pulsa:", "Para ir a la derecha, pulsa: ", "Para ir a la izquierda, pulsa: ", "Para ir hacia abajo, pulsa: ", "Recompensa","Misión","Tienes que abrir la puerta antes de que te atrapen y mueras.","Puntos: "},
        {"Tutorial","To go up, press:", "To go right, press: ", "To go left, press: ", "To go down, press: ", "Reward","Mission","You have to open the door before they catch you and you die.","Points: "},
        {"Tutorial", "Para subir, preme:", "Para ir á dereita, preme:", "Para ir á esquerda, preme:", "Para baixar, preme:", "Recompensa", "Misión","Tes que abrir a porta antes de que te atrapen e morras.","Puntos: "}
    };

    
    //organizado de 0 al 13 del orden que lo puse en public
    void Start()
    {
        int i = PlayerPrefs.GetInt("Idioma", 0);
        titulotutoa.text = matrizIdiomas[i,0];
        titulotutod.text = matrizIdiomas[i, 0];
        titulotutos.text = matrizIdiomas[i, 0];
        titulotutow.text = matrizIdiomas[i, 0];

        textw.text = matrizIdiomas[i,1];
        textd.text = matrizIdiomas[i,2];
        texta.text = matrizIdiomas[i,3];
        texts.text = matrizIdiomas[i,4];

        titulorecompesa.text = matrizIdiomas[i, 5];
        titulomision.text = matrizIdiomas[i,6];
        textmision.text = matrizIdiomas[i,7];

        textpuntos.text = matrizIdiomas[i,8];
        
        

    }


    void Update()
    {
        
    }

    void ActualizarTextos()
    {
        titulotutoa.text = matrizIdiomas[i, 0];
        titulotutod.text = matrizIdiomas[i, 0];
        titulotutos.text = matrizIdiomas[i, 0];
        titulotutow.text = matrizIdiomas[i, 0];

        textw.text = matrizIdiomas[i, 1];
        textd.text = matrizIdiomas[i, 2];
        texta.text = matrizIdiomas[i, 3];
        texts.text = matrizIdiomas[i, 4];

        titulorecompesa.text = matrizIdiomas[i, 5];
        titulomision.text = matrizIdiomas[i, 6];
        textmision.text = matrizIdiomas[i, 7];

        textpuntos.text = matrizIdiomas[i, 8];
    }

    void GuardarDatos ()
    {
        PlayerPrefs.SetInt("Idioma", i);
        PlayerPrefs.Save();
    }

  

    public void Menu(int index)
    {
        switch (index)
        {
            case 0:
                i=0;
                break;
            case 1:
                i=1;
                break;
            case 2:
                i=2;
                break;
        }
    }
}
