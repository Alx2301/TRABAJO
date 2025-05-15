using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using System.Runtime.InteropServices.WindowsRuntime;

public class GestorDatosUsuario : MonoBehaviour
{
    public TMP_InputField campotexto;
    private string textoguardado;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
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
        PlayerPrefs.Save();
    }



}
