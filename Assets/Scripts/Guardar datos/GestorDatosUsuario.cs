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
    public InputField campotextousuariore;
    private string textoguardadousuariore;
    public InputField campotextocorreore;
    private string textocorreore;
    public InputField campotextocontrasenain;
    private string textocontrasenain;
    public InputField campotextocontrasenare;
    private string textocontrasenare;
    public Button botonjugarin;
    public Button botonjugarre;
    public GameObject panelAD;
    public GameObject panelre;
    public GameObject panelin;
    public GameObject panelsbf;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        panelAD.SetActive(false);
        botonjugarin.interactable=false;
        botonjugarre.interactable= false;
        panelre.SetActive(false);
        panelin.SetActive(false);
        panelsbf.SetActive(false);

        campotextousuarioin.onEndEdit.AddListener(GuardarT);
        campotextousuarioin.text = PlayerPrefs.GetString("Texto usuario guardado", textoguardadousuarioin);

        campotextousuariore.onEndEdit.AddListener (GuardarTRE);
        campotextousuariore.text = PlayerPrefs.GetString("Texto usuario guardado registro", textoguardadousuariore);

        campotextocorreore.onEndEdit.AddListener (GuardarT);
        campotextocorreore.text = PlayerPrefs.GetString("Texto correo guardado", textocorreore);

        campotextocontrasenain.onEndEdit.AddListener (GuardarT);
        campotextocontrasenain.text=PlayerPrefs.GetString("Texto contrasena guardado", textocontrasenain);

        campotextocontrasenare.onEndEdit.AddListener(GuardarT);
        campotextocontrasenare.text = PlayerPrefs.GetString("Texto contraseña", textocontrasenare);


    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void GuardarT(string texto)
    {
        string texto2 = textocontrasenain;
        textoguardadousuarioin = texto;
        PlayerPrefs.SetString("Texto usuario guardado", textoguardadousuarioin);
        PlayerPrefs.SetString("Texto contrasena guardado", textocontrasenain);

        if (texto == " ")
        {
            panelAD.SetActive(true);
            if (texto2 == " ")
            {
                panelAD.SetActive(true);
            }
        }
        else if (texto == "")
        {
            panelAD.SetActive(true);
            if (texto2 == "")
            {
                panelAD.SetActive(true);
            }
        }
        else if (texto == "  ")
        {
            panelAD.SetActive(true);
            if ( texto2 == "  ")
            {
                panelAD.SetActive(true);
            }
        }
        else
        {
            if (texto2 == " ")
            {
                panelAD.SetActive(true);
            }
            else if (texto2 == "")
            {
                panelAD.SetActive(true);
            }
            else if (texto2 == "  ")
            {
                panelAD.SetActive(true);
            }
            else
            {
                textoguardadousuarioin = texto;
                textocontrasenain = texto2;
                botonjugarin.interactable = true;
                Debug.Log("Funciona");
                GuardarCambios();
            }
                

        }

    }

    void GuardarTRE(string texto)
    {
        string texto3 = textocorreore;
        string texto2 = textocontrasenare;
        textoguardadousuariore = texto;
        PlayerPrefs.SetString("Texto usuario guardado registrado", textoguardadousuariore);
        PlayerPrefs.SetString("Texto contrasena guardado", textocontrasenare);
        PlayerPrefs.SetString("Texto correo guardado", textocorreore);

        if (texto == " ")
        {
            panelAD.SetActive(true);
            if (texto2 == " ")
            {
                panelAD.SetActive(true);
                if (texto3 == " ")
                {
                    panelAD.SetActive(true);
                }
            }
            else if (texto2 ==" ")
            {
                panelAD.SetActive(true);
                if (texto3 == " ")
                {
                    panelAD.SetActive(true);
                }
            }
        }
        else if (texto == "")
        {
            panelAD.SetActive(true);
            if (texto2 == "")
            {
                panelAD.SetActive(true);
            }
            if (texto3 == "")
            {
                panelAD.SetActive(true);
            }
        }
        else
        {
            if (texto2==" ")
            {
                panelAD.SetActive(true);
                if (texto3 == " ")
                {
                    panelAD.SetActive(true);
                }
            }
            else if (texto2 == "")
            {
                panelAD.SetActive(true);
                if (texto3 == "")
                {
                    panelAD.SetActive(true);
                }
            }
            else
            {
                if (texto3==" ")
                {
                    panelAD.SetActive(true);
                }
                else if (texto3 == "")
                {
                    panelAD.SetActive(true);
                }
                else
                {
                    textocontrasenare = texto2;
                    textoguardadousuariore = texto;
                    textocorreore = texto3;
                    botonjugarre.interactable = true;
                    GuardarCambios();
                }
                
            }
                
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
