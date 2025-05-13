using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using System.Runtime.InteropServices.WindowsRuntime;

//poner el valor del cambio de idiomas 1 al 2, para cuando se cambie el idioma en las opciones, se cambie en todas las pantallas (escenas)
public class CambioIdiomas2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public TextMeshProUGUI titulovolumentext;
    public TextMeshProUGUI titulomusicatext;
    public TextMeshProUGUI titulodialogostext;
    public TextMeshProUGUI tituloefectostext;
    public TextMeshProUGUI botonvolvertext;
    public TextMeshProUGUI tituloanimacionestext;
    public TextMeshProUGUI titulohabilidadestext;
    public TextMeshProUGUI tituloentornotext;

    public int i = 0;


    string[,] matrizIdiomas = new string[3, 8]
    {
        {"Volumen","Música","Diálogos","Efectos VX","Volver", "Animaciones","Habilidades", "Entorno"},
        {"Volumen","Music","Dialogue","Efects VX","Back", "Animations","Habilitys", "Ambient"},
        {"Volumen","Música","Diálogos","Efectos VX","Atras", "Animaciones", "Habilidades", "Ambiente"}
    };

    

    void Start()
    {
        int i = PlayerPrefs.GetInt("Idioma", 0);

        titulovolumentext.text = matrizIdiomas[i,0];
        titulomusicatext.text = matrizIdiomas[i, 1];
        titulodialogostext.text = matrizIdiomas[i, 2];
        tituloefectostext.text = matrizIdiomas[i, 3];
        botonvolvertext.text = matrizIdiomas[i, 4];
        tituloanimacionestext.text = matrizIdiomas[i,5];
        titulohabilidadestext.text = matrizIdiomas[i,6];
        tituloentornotext.text = matrizIdiomas[i, 7];

    }


    void Update()
    {
        
    }

    void ActualizarTextos()
    {
        titulovolumentext.text = matrizIdiomas[i, 0];
        titulomusicatext.text = matrizIdiomas[i, 1];
        titulodialogostext.text = matrizIdiomas[i, 2];
        tituloefectostext.text = matrizIdiomas[i, 3];
        botonvolvertext.text = matrizIdiomas[i,4];
        tituloanimacionestext.text = matrizIdiomas[i, 5];
        titulohabilidadestext.text = matrizIdiomas[i, 6];
        tituloentornotext.text = matrizIdiomas[i, 7];
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
