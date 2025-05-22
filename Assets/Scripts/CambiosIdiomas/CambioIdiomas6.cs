using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using System.Runtime.InteropServices.WindowsRuntime;

//poner el valor del cambio de idiomas 1 al 2, para cuando se cambie el idioma en las opciones, se cambie en todas las pantallas (escenas)
public class CambioIdiomas6 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [Header("Idiomas")]
    public TextMeshProUGUI tituloGraficos;
    public TextMeshProUGUI tituloTam;
    public TextMeshProUGUI botonayudatext;
    public TextMeshProUGUI botonvolvertext;
    public TextMeshProUGUI botonguardartext;
    public TextMeshProUGUI botonquitartext;
    public TextMeshProUGUI botonquitartext2;
    public TextMeshProUGUI botonquitartext3;
    public TextMeshProUGUI botonreproducirtext;

    public int i;

    string[,] matrizIdiomas = new string[3, 8]
    {
        {"Gráficos","Tamaño de pantalla","Ayuda","Volver","Guardar","Quitar","Quitar video","Reproducir vídeo"},
        {"Grafics","Screen Size","Help", "Back", "Save","Remove","Remove video","Play video"},
        {"Gráficos","Tamaño da pantalla","Axuda", "Atras", "Gardar","Quitar","Quitar video","Reproducir video"}
    };
    [Header("Botones y paneles")]
    public GameObject panelayuda;
    public Button botonvolver;
    public Button botonguardar;
    public Button botonquitar;
    public Button botonquitar2;
    public Button botonquitar3;
    public Button botonreproducir;
    public GameObject panelvideo1;
    public GameObject panelvideo2;
    private int po;
    void Start()
    {
        i = PlayerPrefs.GetInt("Idioma", 0);
        po = i;
        tituloGraficos.text= matrizIdiomas[i,0];
        tituloTam.text = matrizIdiomas[i, 1];
        botonayudatext.text = matrizIdiomas[i,2];
        botonvolvertext.text = matrizIdiomas[i, 3];
        botonguardartext.text = matrizIdiomas[i, 4];
        botonquitartext.text = matrizIdiomas [i, 5];
        botonquitartext2.text = matrizIdiomas[i, 6];
        botonquitartext3.text = matrizIdiomas[i,7];
        botonreproducirtext.text = matrizIdiomas[i, 7];
        ActualizarTextos();

        panelayuda.SetActive(false);
        panelvideo1.SetActive(false);
        panelvideo2.SetActive(false);

    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            botonvolver.onClick.Invoke();

            if (panelayuda)
            {
                if (Input.GetKeyDown(KeyCode.Escape))
                {
                    botonquitar.onClick.Invoke();
                }
                if (panelvideo1)
                {
                    if (Input.GetKeyDown(KeyCode.Escape))
                    {
                        botonquitar2.onClick.Invoke();
                    }
                }
                if (panelvideo2)
                {
                    if (Input.GetKeyDown(KeyCode.Escape))
                    {
                        botonquitar3.onClick.Invoke();
                    }
                }
            }
        }
        

    }

    public void ActivarAyuda()
    {
        panelayuda.SetActive(true);
    }
    public void QuitarA()
    {
        panelayuda.SetActive(false);
    }
    public void ActivarVideo()
    {
        if (po == 0)
        {
            panelvideo1.SetActive(true);
        }
        else if (po== 1)
        {
            panelvideo2.SetActive(true);
        }
        else if (po ==2)
        {
            panelvideo1.SetActive(true);
        }
     
    }
    public void QuitarVideo()
    {
        panelvideo1.SetActive(false);
        panelvideo2.SetActive(false);
    }


    void ActualizarTextos()
    {
        tituloGraficos.text = matrizIdiomas[i, 0];
        tituloTam.text = matrizIdiomas[i, 1];
        botonayudatext.text = matrizIdiomas[i, 2];
        botonvolvertext.text = matrizIdiomas[i, 3];
        botonguardartext.text = matrizIdiomas[i, 4];
        botonquitartext.text = matrizIdiomas[i, 5];
        botonquitartext2.text = matrizIdiomas[i, 6];
        botonquitartext3.text = matrizIdiomas[i, 6];
        botonreproducirtext.text = matrizIdiomas[i, 7];
        
    }



    public void Menu(int index)
    {
        switch (index)
        {
            case 0:
                i=0;
                po = 0;
                break;
            case 1:
                i=1;
                po = 1;
                break;
            case 2:
                i=2;
                po = 2;
                break;
        }
    }
}
