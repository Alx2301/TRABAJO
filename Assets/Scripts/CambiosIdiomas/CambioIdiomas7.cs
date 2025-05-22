using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class CambioIdiomas7 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [Header("Textos a traducir")]
    public TextMeshProUGUI titulomando;
    public TextMeshProUGUI titulonods;
    public TextMeshProUGUI botonvolvertext;
    [Header("Botones arrow y ad")]
    public Button botonVolver;
    public Button botonIz;
    public Button botonDe;

    public int i;

    string[,] matrizIdiomas = new string[3, 3]
    {
        {"Mando","No tenemos disponible la configuración ni jugar con este tipo de dispositivo","Volver"},
        {"Controller","We don't have the configuration available, don't play with this type of device","Back"},
        {"Controlador","Non temos a configuración dispoñible, non xogue con este tipo de dispositivo","Volver"}
    };


    void Start()
    {
        i = PlayerPrefs.GetInt("Idioma", 0); 
        titulomando.text = matrizIdiomas[i, 0];
        titulonods.text = matrizIdiomas[i, 1];
        botonvolvertext.text = matrizIdiomas[i, 2];
        ActualizarTextos();
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            botonVolver.onClick.Invoke();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            botonDe.onClick.Invoke();
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            botonDe.onClick.Invoke();
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            botonIz.onClick.Invoke();
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            botonIz.onClick.Invoke();
        }
    }

    void ActualizarTextos()
    {
        i = PlayerPrefs.GetInt("Idioma", 0);
        titulomando.text = matrizIdiomas[i, 0];
        titulonods.text = matrizIdiomas[i, 1];
        botonvolvertext.text = matrizIdiomas[i, 2];
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
