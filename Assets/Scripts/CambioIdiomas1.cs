using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class CambioIdiomas1 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public TextMeshProUGUI botonEspanoltext;
    public TextMeshProUGUI botonInglestext;
    public TextMeshProUGUI botonGallegotext;
    public TextMeshProUGUI tituloidiomastext;
    public TextMeshProUGUI titulointerfaztext;
    public TextMeshProUGUI botondiaEspanoltext;
    public TextMeshProUGUI botondiaInglestext;
    public TextMeshProUGUI botondiaGallegotext;
    public TextMeshProUGUI titulodialogotext;
    public TextMeshProUGUI botonvolvertext;


    public int i = 0;
    

    string[,] matrizIdiomas = new string[3, 7]
    {
        {"Español","Inglés","Gallego","Idiomas", "Interfaz", "Diálogo","Volver"},
        {"Spanish","English","Galician","Lenguages", "Interface", "Dialogue","Back"},
        {"Español","Inglés","Galego","Idiomas", "Interface", "Diálogo","Atras"}
    };
    void Start()
    {
        botonEspanoltext.text = matrizIdiomas[i, 0];
        botonInglestext.text = matrizIdiomas[i, 1];
        botonGallegotext.text = matrizIdiomas[i, 2];
        tituloidiomastext.text = matrizIdiomas[i, 3];
        titulointerfaztext.text = matrizIdiomas[i, 4];
        botondiaEspanoltext.text = matrizIdiomas[i, 0];
        botondiaInglestext.text = matrizIdiomas[i, 1];
        botondiaGallegotext.text = matrizIdiomas[i, 2];
        titulodialogotext.text = matrizIdiomas[i, 5];
        botonvolvertext.text = matrizIdiomas[i, 6];

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
        botonEspanoltext.text = matrizIdiomas[i, 0];
        botonInglestext.text = matrizIdiomas[i, 1];
        botonGallegotext.text = matrizIdiomas[i, 2];
        tituloidiomastext.text = matrizIdiomas[i, 3];
        titulointerfaztext.text = matrizIdiomas[i,4];
        botondiaEspanoltext.text = matrizIdiomas[i, 0];
        botondiaInglestext.text = matrizIdiomas[i, 1];
        botondiaGallegotext.text = matrizIdiomas[i, 2];
        titulodialogotext.text = matrizIdiomas[i, 5];
        botonvolvertext.text = matrizIdiomas[i, 6];

    }

    void GuardarDatos ()
    {
        PlayerPrefs.SetInt("Idioma", i);
        PlayerPrefs.Save();
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
