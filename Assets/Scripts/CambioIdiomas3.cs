using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using System.Runtime.InteropServices.WindowsRuntime;

//poner el valor del cambio de idiomas 1 al 2, para cuando se cambie el idioma en las opciones, se cambie en todas las pantallas (escenas)
public class CambioIdiomas3 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public TextMeshProUGUI botonnuevapartidatext;
    public TextMeshProUGUI botoncargarpartidatext;
    public TextMeshProUGUI botonconfiguraciontext;
    public TextMeshProUGUI botonsalidatext;
    public TextMeshProUGUI botoncreditostext;

    public int i = 0;


    string[,] matrizIdiomas = new string[3, 5]
    {
        {"Nueva Partida","Cargar Partida","Configuración","Salida", "Créditos"},
        {"New Party","Load Party","Configuration","Exit", "Credits"},
        {"Nova Partida","Cargar Partida","Configuración","Saída", "Créditos"}
    };

    

    void Start()
    {
        int i = PlayerPrefs.GetInt("Idioma", 0);

        botonnuevapartidatext.text = matrizIdiomas[i,0];
        botoncargarpartidatext.text = matrizIdiomas[i, 1];
        botonconfiguraciontext.text = matrizIdiomas[i, 2];
        botonsalidatext.text = matrizIdiomas[i, 3];
        botoncreditostext.text = matrizIdiomas[i, 4];

    }


    void Update()
    {
        
    }

    void ActualizarTextos()
    {
        botonnuevapartidatext.text = matrizIdiomas[i, 0];
        botoncargarpartidatext.text = matrizIdiomas[i, 1];
        botonconfiguraciontext.text = matrizIdiomas[i, 2];
        botonsalidatext.text = matrizIdiomas[i, 3];
        botoncreditostext.text = matrizIdiomas[i, 4];
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
