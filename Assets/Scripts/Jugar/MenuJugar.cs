using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEditor;

public class MenuJugar : MonoBehaviour

{
    public GameObject panelinv;
    public GameObject panelRecompensas;
    public GameObject panelpuerta;

    public TextMeshProUGUI textopuntos;
    private int puntos = 0;

    void Start()
    {
        
        panelinv.SetActive(false);
        textopuntos.text = ": " + puntos;
        panelRecompensas.SetActive(false);
    }

    public void añadirpuntos(int cantidad)
    {
        puntos += cantidad;
        textopuntos.text = " " + puntos;
        GuardarPuntos();
    }

    public void GuardarPuntos()
    {
        PlayerPrefs.SetInt("Puntos guardados", puntos);
        PlayerPrefs.Save();
        PlayerPrefs.DeleteKey("Puntos guardados");

        Debug.Log("Puntos guardados manualmente.");
    }

    public void AbrirInven()
    {
        panelinv.SetActive(true);
    }
    public void CerrarInven()
    {
        panelinv.SetActive(false);
    }
}
