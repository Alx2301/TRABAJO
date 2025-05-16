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
    public InputField campotextousuarioin;
    private string textoguardadousuarioin;
    public Button botonjugarin;
    public GameObject panelAD;
    public GameObject panelre;
    public GameObject panelin;
    public GameObject panelsbf;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        panelAD.SetActive(false);
        botonjugarin.interactable=false;
        panelre.SetActive(false);
        panelin.SetActive(false);
        panelsbf.SetActive(false);
        campotextousuarioin.onEndEdit.AddListener(GuardarT);
        campotextousuarioin.text = PlayerPrefs.GetString("Texto usuario guardado", " ");
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void GuardarT(string texto)
    {
        textoguardadousuarioin = texto;
        PlayerPrefs.SetString("Texto usuario guardado", textoguardadousuarioin);

        if (texto == " ")
        {
            panelAD.SetActive(true);
        }
        else if (texto == "")
        {
            panelAD.SetActive(true);
        }
        else if (texto == "  ")
        {
            panelAD.SetActive(true);
        }
        else
        {// no se activa el boton
            textoguardadousuarioin = texto;
            botonjugarin.interactable = true;
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
    }
    public void closead()
    {
        panelAD.SetActive(false);
    }
    
    public void abrirre()
    {
        panelre.SetActive(true);
    }
    public void cerrarre()
    {
        panelre.SetActive(false);
    }
    public void abririn()
    {
        panelin.SetActive(true);
    }
    public void cerrarin()
    {
        panelin.SetActive(false);
    }
    public void abrirsfr()
    {
        panelsbf.SetActive(true);
    }
    public void cerrarsbf()
    {
        panelsbf.SetActive(false);
    }
}
