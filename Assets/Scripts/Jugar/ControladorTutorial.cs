using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class ControladorTutorial : MonoBehaviour
{
    public GameObject[] paneles; // Paneles del tutorial
    public Animator[] animacionesPaneles;
    public Animator fondo;
    public Animator anipanelmi;
    public GameObject panelMision; // Panel mision tras el tutorial
    public GameObject panelTemporal;
    public GameObject panelPuntos;
    public Button botonpausa;

    public KeyCode[] teclas = { KeyCode.A, KeyCode.D, KeyCode.S, KeyCode.W };
    public string[] animacionesFondo = { "AnimacionIzquierda", "AnimacionDerecha", "AnimacionAbajo", "AnimacionArriba" };
    public string[] animacionesCerrar = { "AnimacionTAS", "AnimacionTDS", "AnimacionTSS", "AnimacionTWS" };

    private int pasoActual = 0;
    private bool puedeAvanzar = false;
    private int puntos;

    void Start()
    {
        puntos = PlayerPrefs.GetInt("Puntos guardados");
        foreach (GameObject panel in paneles)
            panel.SetActive(false);

        if (panelMision != null)
        {
            panelMision.SetActive(false);
        }
        if(panelPuntos != null)
        {
            if (puntos == 4000)
            {
                panelPuntos.SetActive(false);
            }
            else
            {
                panelPuntos.SetActive(false);
            }
            
        }


        Invoke(nameof(MostrarPasoActual), 1f);

    }

    void Update()
    {
        if (!puedeAvanzar) return;

        if (Input.GetKeyDown(teclas[pasoActual]))
        {
            AvanzarTutorial();
        }
        
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            botonpausa.onClick.Invoke();
        }

    }

    void MostrarPasoActual()
    {
        paneles[pasoActual].SetActive(true);
        puedeAvanzar = true;
    }

    void AvanzarTutorial()
    {
        puedeAvanzar = false;
        animacionesPaneles[pasoActual].Play(animacionesCerrar[pasoActual]);
        fondo.Play(animacionesFondo[pasoActual]);
        StartCoroutine(SiguientePaso());
    }

    public void MostrarPanelPorTiempo(float segundos)
    {
        StartCoroutine(MostrarTemporalmente(segundos));
    }

    private System.Collections.IEnumerator MostrarTemporalmente(float segundos)
    {
        panelTemporal.SetActive(true);
        yield return new WaitForSeconds(segundos);
        anipanelmi.Play("SalidaMI");
    }

    IEnumerator SiguientePaso()
    {
        yield return new WaitForSeconds(1f);

        paneles[pasoActual].SetActive(false);
        pasoActual++;

        if (pasoActual < paneles.Length)
        {
            MostrarPasoActual();
        }
        else
        {
            Debug.Log("Tutorial completado");

            if (panelMision != null)
            {
                panelMision.SetActive(true);
                MostrarPanelPorTiempo(3f);
            }
            if (panelPuntos!= null)
            {
                panelPuntos.SetActive(true);
            }
            

        }
    }
    public void Pausa()
    {
        SceneManager.LoadScene("Menu Pausa");
    }

}

