using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;

public class GestorDatosUsuario : MonoBehaviour
{
    public InputField campotexto;
    private string textoguardado;
    public Button pruebausuario;
    public Animator animatorad;
    public GameObject panelAD;
    public Animator anipanel;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        panelAD.SetActive(false);
        pruebausuario.interactable=false;
        campotexto.onEndEdit.AddListener(GuardarT);
        campotexto.text = PlayerPrefs.GetString("Texto usuario guardado", " ");
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void GuardarT(string texto)
    {
        textoguardado = texto;
        PlayerPrefs.SetString("Texto usuario guardado", textoguardado);
        
        if (texto == " ")
        {
            ad();
        }
        else
        {
            textoguardado=texto;
            pruebausuario.interactable = true;
            Debug.Log("Funciona");
            GuardarCambios();

        }
        
    }
    public void GuardarCambios()
    {
        PlayerPrefs.Save();
    }

    public void ad()
    {
        panelAD.SetActive(true);
        animatorad.Play("AnimacionesAD");
    }
    public void closead()
    {
        animatorad.Play("AnimacionesADS");
    }
    public void closeinicio()
    {
        anipanel.Play("AnimacionPanelUS");
    }
}
