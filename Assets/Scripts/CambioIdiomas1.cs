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
    public int i = 0;

    string[,] matrizIdiomas = new string[3, 4]
    {
        {"Español","Inglés","Gallego","Idiomas" },
        {"Spanish","English","Galician","Lenguages"},
        {"Español","Inglés","Galego","Idiomas"}
    };
    void Start()
    {
        botonEspanoltext.text = matrizIdiomas[i,0];
        botonGallegotext.text = matrizIdiomas[i,2];
        botonInglestext.text = matrizIdiomas[i,1];
    }

    // Update is called once per frame
    void Update()
    {
        botonEspanoltext.text = matrizIdiomas[i, 0];
        botonGallegotext.text = matrizIdiomas[i, 2];
        botonInglestext.text = matrizIdiomas[i, 1];
    }

    public void Espanol()
    {
        i = 0;
    }
    public void Galego () 
    {
        i = 2;
    }
    public void Ingles()
    {
        i = 1;
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
