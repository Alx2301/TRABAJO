using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using System.Runtime.InteropServices.WindowsRuntime;


public class CambioIdiomas8 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [Header("Textos a traducir")]
    public TextMeshProUGUI tituloGUARDAR;
    public TextMeshProUGUI tituloUsuario;
    public TextMeshProUGUI titulopuntos;
    public TextMeshProUGUI titulonivel;
    public TextMeshProUGUI titulodificultad;
    public TextMeshProUGUI tituloUsuario2;
    public TextMeshProUGUI titulopuntos2;
    public TextMeshProUGUI titulonivel2;
    public TextMeshProUGUI titulodificultad2;
    public TextMeshProUGUI tituloUsuario3;
    public TextMeshProUGUI titulopuntos3;
    public TextMeshProUGUI titulonivel3;
    public TextMeshProUGUI titulodificultad3;
    public TextMeshProUGUI botonvolvertext;
    public TextMeshProUGUI titulono;

    [Header("Botones arrow y ad")]
    public Button botonVolver;
    public Button panel1;
    public Button panel2;
    public Button panel3;

    public int i;

    string[,] matrizIdiomas = new string[3, 7]
    {
        {"Nombre de usuario","Puntos:","Nivel:","Dificultad","Ir al menú","CARGAR PARTIDA","No tienes nada guardado"},
        {"Username","Points:","Level:","Difficulty","Back to menu","LOAD PARTY", "You don't have any party"},
        {"Nome de usuario","Puntos:","Nivel:","Dificultade","Volver a menú","CARGAR PARTIDA", "Non tenes nada gardado"}
    };


    void Start()
    {
        i = PlayerPrefs.GetInt("Idioma", 0);
        tituloUsuario.text = matrizIdiomas[i, 0];
        tituloUsuario2.text = matrizIdiomas[i, 0];
        tituloUsuario3.text = matrizIdiomas[i, 0];
        titulopuntos.text = matrizIdiomas[i, 1];
        titulopuntos2.text = matrizIdiomas[i, 1];
        titulopuntos3.text = matrizIdiomas[i, 1];
        titulonivel.text = matrizIdiomas[i, 2];
        titulonivel2.text = matrizIdiomas[i, 2];
        titulonivel3.text = matrizIdiomas[i, 2];
        titulodificultad.text = matrizIdiomas[i, 3];
        titulodificultad2.text = matrizIdiomas[i, 3];
        titulodificultad3.text = matrizIdiomas[i, 3];
        botonvolvertext.text = matrizIdiomas[i, 4];
        tituloGUARDAR.text = matrizIdiomas[i, 5];
        titulono.text= matrizIdiomas[i,6];
        ActualizarTextos();
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            botonVolver.onClick.Invoke();
        }
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            panel1.onClick.Invoke();
        }
        if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            panel2.onClick.Invoke();
        }
        if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            panel3.onClick.Invoke();
        }
    }

    void ActualizarTextos()
    {
        i = PlayerPrefs.GetInt("Idioma", 0);
        tituloUsuario.text = matrizIdiomas[i, 0];
        tituloUsuario2.text = matrizIdiomas[i, 0];
        tituloUsuario3.text = matrizIdiomas[i, 0];
        titulopuntos.text = matrizIdiomas[i, 1];
        titulopuntos2.text=matrizIdiomas[i, 1];
        titulopuntos3.text =matrizIdiomas[i, 1];
        titulonivel.text = matrizIdiomas[i, 2];
        titulonivel2.text =matrizIdiomas[i, 2];
        titulonivel3.text = matrizIdiomas[i,2];
        titulodificultad.text = matrizIdiomas[i, 3];
        titulodificultad2.text = matrizIdiomas[i, 3];
        titulodificultad3.text = matrizIdiomas[i, 3];
        botonvolvertext.text = matrizIdiomas[i, 4];
        tituloGUARDAR.text = matrizIdiomas[i, 5];
        titulono.text = matrizIdiomas[i,6];
        GuardarDatos();
    }

    void GuardarDatos ()
    {
        PlayerPrefs.SetInt("Idioma", i);
        
        PlayerPrefs.Save();
    }

    public void MenuMando(int index)
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
