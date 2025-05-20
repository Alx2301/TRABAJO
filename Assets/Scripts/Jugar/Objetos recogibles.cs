using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Objetosrecogibles : MonoBehaviour
{
   
    
     public TextMeshProUGUI textoContador; //texto en pantalla
     private int totalRecogidos = 0;

     void Start()
     {
        
        totalRecogidos = PlayerPrefs.GetInt("Objetos", 0);
        ActualizarContador();
    }

    public void SumarObjeto()
    {
        totalRecogidos++;
        ActualizarContador();
    }

    void ActualizarContador()
    {
        textoContador.text = " " + totalRecogidos;
    }
    
    public void SumarObjetos()
    {
        totalRecogidos++;
        PlayerPrefs.SetInt("Objetos", totalRecogidos);
        PlayerPrefs.Save();
        ActualizarContador();
    }



}
