using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class CambioIdiomas1 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [Header ("Textos a traducir")]
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

    public Button botonVolver;
    public Button botonIz;
    public Button botonDe;

    public int i = 0;

    string[,] matrizIdiomas = new string[3, 7]
    {
        {"Espa�ol","Ingl�s","Gallego","Idiomas", "Interfaz", "Di�logo","Volver"},
        {"Spanish","English","Galician","Lenguages", "Interface", "Dialogue","Back"},
        {"Espa�ol","Ingl�s","Galego","Idiomas", "Interface", "Di�logo","Atras"}
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
        GuardarDatos();
    }

    void GuardarDatos ()
    {
        PlayerPrefs.SetInt("Idioma", i);
        
        PlayerPrefs.Save();
    }

    public void Espanol()
    {
        i = 0;
        ActualizarTextos();
        GuardarDatos ();
    }
    public void Galego () 
    {
        i = 2;
        ActualizarTextos();
        GuardarDatos();
    }
    public void Ingles()
    {
        i = 1;
        GuardarDatos();
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
