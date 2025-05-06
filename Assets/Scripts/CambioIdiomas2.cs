using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class CambioIdiomas1 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public TextMeshProUGUI botonnuevopartidatext;
    public TextMeshProUGUI botoncargarpartidatext;
    public TextMeshProUGUI botonconfiguraciontext;
    public TextMeshProUGUI botonsalidatext;
    public TextMeshProUGUI botoncreditostext;

    public int i = 0;
    private int estadoOpciones;
    private int seleccion;


    string[,] matrizIdiomas = new string[3, 5]
    {
        {"Nueva Partida","Cargar Partida","Configuración","Salida","Créditos"},
        {"New game","Load game","Configuration","Exit", "Credits"},
        {"Nova Partida","Xogo de carga","Configuración","Saida", "Créditos"}
    };
    void Start()
    {
        botonnuevopartidatext.text = matrizIdiomas[i,0];
        botoncargarpartidatext.text = matrizIdiomas[i,2];
        botonInglestext.text = matrizIdiomas[i,1];
        tituloidiomastext.text = matrizIdiomas[i,3];

        if (PlayerPrefs.HasKey("Idioma"))
        {
            i = PlayerPrefs.GetInt("Idioma");
        }
        else
        {
            i = 0;
        }

        ActualizarTextos();
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    void ActualizarTextos()
    {
        botonnuevopartidatext.text = matrizIdiomas[i, 0];
        botonInglestext.text = matrizIdiomas[i, 1];
        botonGallegotext.text = matrizIdiomas[i, 2];
        tituloidiomastext.text = matrizIdiomas[i, 3];
    }

    public void Espanol()
    {
        i = 0;
        PlayerPrefs.SetInt("Idioma", i);
        PlayerPrefs.Save();
        ActualizarTextos();

    }
    public void Galego () 
    {
        i = 2;
        PlayerPrefs.SetInt("Idioma", i);
        PlayerPrefs.Save();
        ActualizarTextos();
    }
    public void Ingles()
    {
        i = 1;
        PlayerPrefs.SetInt("Idioma", i);
        PlayerPrefs.Save();
        ActualizarTextos();
    }

    public void MenuDropDown(int index)
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
