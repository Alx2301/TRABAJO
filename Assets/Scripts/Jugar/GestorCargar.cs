using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using System.Runtime.InteropServices.WindowsRuntime;

public class GestorCargar : MonoBehaviour
{
    [Header("Jugador1")]
    public TextMeshProUGUI nombrejugadortext;
    public TextMeshProUGUI puntostext;
    public TextMeshProUGUI niveltext;
    public TextMeshProUGUI dificultadtext;

    [Header("Invitado")]
    public Button panel1;
    public Button panel2;
    public Button panel3;

    private string textoguardadousuarioin;
    private string textoguardadousuariore;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string nombre1 = PlayerPrefs.GetString("Texto usuario guardado", textoguardadousuarioin);
        string nombre2 = PlayerPrefs.GetString("Texto usuario guardado registrado", textoguardadousuariore);
        int puntos = PlayerPrefs.GetInt("Puntos guardados", 0);
        int nivel = PlayerPrefs.GetInt("Nivel", 1);
        int dificultad = PlayerPrefs.GetInt("Dificultad", 0);

        puntostext.text = " " + puntos.ToString();
        niveltext.text = " " + nivel.ToString();
        dificultadtext.text =" " + dificultad.ToString();
        nombrejugadortext.text = " " + nombre1;
        ActualizarG();
    }

    // Update is called once per frame
    void Update()
    {
        ActualizarG();
    }

    void ActualizarG()
    {
        string nombre1 = PlayerPrefs.GetString("Texto usuario guardado", textoguardadousuarioin);
        string nombre2 = PlayerPrefs.GetString("Texto usuario guardado registrado", textoguardadousuariore);
        if (nombre1 == "")
        {
            if (nombre2 == "")
            {
                panel1.interactable = false;
                panel2.interactable = false;
                panel3.interactable = false;
            }
            else
            {
                panel1.interactable = true;
                panel2.interactable = true;
                panel3.interactable = true;
            }
        }
        else
        {
            if (nombre2 == "")
            {
                panel1.interactable = false;
                panel2.interactable = false;
                panel3.interactable = false;
            }
            else
            {
                panel1.interactable = true;
                panel2.interactable = true;
                panel3.interactable = true;
            }
        }
    }

    public void GuardarDatos()
    {
        string nombre1 = PlayerPrefs.GetString("Texto usuario guardado");
        int puntos = PlayerPrefs.GetInt("Puntos guardados", 0);
        int nivel = PlayerPrefs.GetInt("Nivel", 1);
        int dificultad = PlayerPrefs.GetInt("Dificultad", 0);

        puntostext.text = " " + puntos.ToString();
        niveltext.text = " " + nivel.ToString();
        dificultadtext.text = " " + dificultad.ToString();
        nombrejugadortext.text = " " + nombre1;
        ActualizarG();
    }
    public void CargarPartida()
    {
        string escena = PlayerPrefs.GetString("EscenaGuardada", "EscenaInicio");
        UnityEngine.SceneManagement.SceneManager.LoadScene(escena);
    }

}
