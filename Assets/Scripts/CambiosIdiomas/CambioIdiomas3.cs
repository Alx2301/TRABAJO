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
    public TextMeshProUGUI botonsolitario;
    public TextMeshProUGUI boton2jug;
    public TextMeshProUGUI boton3jug;
    public TextMeshProUGUI boton4jug;

    public int i = 0;


    string[,] matrizIdiomas = new string[3, 9]
    {
        {"Nueva partida","Cargar partida","Configuración","Salida", "Créditos", "Solitario", "2 jugadores", "3 jugadores", "4 jugadores"},
        {"New party","Load party","Configuration","Exit", "Credits", "Solo", "2 players", "3 players", "4 players"},
        {"Nova partida","Cargar partida","Configuración","Saída", "Créditos", "Solitario", "2 xugadores", "3 xugadores", "4 xugadores"}
    };

    

    void Start()
    {
        int i = PlayerPrefs.GetInt("Idioma", 0);

        botonnuevapartidatext.text = matrizIdiomas[i,0];
        botoncargarpartidatext.text = matrizIdiomas[i, 1];
        botonconfiguraciontext.text = matrizIdiomas[i, 2];
        botonsalidatext.text = matrizIdiomas[i, 3];
        botoncreditostext.text = matrizIdiomas[i, 4];
        botonsolitario.text= matrizIdiomas[i,5];
        boton2jug.text=matrizIdiomas[i, 6];
        boton3jug.text = matrizIdiomas[i,7];
        boton4jug.text = matrizIdiomas [i,8];

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
        botonsolitario.text = matrizIdiomas[i, 5];
        boton2jug.text = matrizIdiomas[i, 6];
        boton3jug.text = matrizIdiomas[i, 7];
        boton4jug.text = matrizIdiomas[i, 8];
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
