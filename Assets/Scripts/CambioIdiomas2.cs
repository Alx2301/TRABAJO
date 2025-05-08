using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

//poner el valor del cambio de idiomas 1 al 2, para cuando se cambie el idioma en las opciones, se cambie en todas las pantallas (escenas)
public class CambioIdiomas2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public TextMeshProUGUI titulovolumentext;
    public TextMeshProUGUI titulomusicatext;
    public TextMeshProUGUI titulodialogostext;
    public TextMeshProUGUI tituloefectostext;

    public int i = 0;


    string[,] matrizIdiomas = new string[3, 5]
    {
        {"Volumen","Música","Diálogo","Efectos","Volver"},
        {"Volumen","Music","Dialogue","Efects","Back"},
        {"Volumen","Música","Diálogo","Efectos","Atras"}
    };
    void Start()
    {
        titulovolumentext.text = matrizIdiomas[i,0];
        titulomusicatext.text = matrizIdiomas[i, 1];
        titulodialogostext.text = matrizIdiomas[i, 2];
        tituloefectostext.text = matrizIdiomas[i, 3];

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
        titulovolumentext.text = matrizIdiomas[i, 0];
        titulomusicatext.text = matrizIdiomas[i, 1];
        titulodialogostext.text = matrizIdiomas[i, 2];
        tituloefectostext.text = matrizIdiomas[i, 3];
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
