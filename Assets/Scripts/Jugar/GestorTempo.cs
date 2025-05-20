using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class GestorTempo : MonoBehaviour
{
    [Header("Tutorial")]
    public GameObject[] paneles; // Paneles del tutorial
    public Animator[] animacionesPaneles;
    public GameObject panelMision;
    public GameObject panelre;
    public Animator fondo;
    public KeyCode[] teclas = { KeyCode.A, KeyCode.D, KeyCode.S, KeyCode.W };
    public string[] animacionesFondo = { "AnimacionIzquierda", "AnimacionDerecha", "AnimacionAbajo", "AnimacionArriba" };
    public string[] animacionesCerrar = { "AnimacionTAS", "AnimacionTDS", "AnimacionTSS", "AnimacionTWS" };

    private int pasoActual = 0;
    private bool puedeAvanzar = false;

    [Header("Temporizador")]
    public GameObject panelTempo;         // Se activa al terminar el tutorial
    public GameObject panelFinal;         // Se muestra al acabar el tiempo
    public AudioSource audioFinal;        // Sonido al terminar
    public Image barraTiempo;
    public GameObject panelPuntos;
    public TextMeshProUGUI textoTiempo;
    public Image barraVida;
    public Image barraEstamina;
    public float duracion = 10f;
    public GameObject paneljuegof;
    public Button botonpausa;
    public Animator anipanelmi;

    private float tiempoRestante;
    private bool temporizadorActivo = false;
    private int puntos;

    void Start()
    {
        puntos = PlayerPrefs.GetInt("Puntos guardados", 0);
        foreach (GameObject panel in paneles)
            panel.SetActive(false);

        if (panelTempo != null)
        {
            panelTempo.SetActive(false);
        }
            
        if (panelFinal != null)
        { 
            panelFinal.SetActive(false); 
        }

        if (panelMision != null)
        {
            panelMision.SetActive(false);
        }
        if (paneljuegof != null)
        {
            paneljuegof.SetActive(false);
        }

        if (panelPuntos != null)
        {
            if (puntos == 4000)
            {
                panelPuntos.SetActive(false);
                panelre.SetActive(true);
                paneljuegof.SetActive(true);
                panelFinal.SetActive(false) ;
            }
            else
            {
                panelPuntos.SetActive(false);
                panelre.SetActive(false);
            }

        }

        Invoke(nameof(MostrarPasoActual), 1f);
    }

    void Update()
    {
        // Tutorial paso a paso
        if (puedeAvanzar && Input.GetKeyDown(teclas[pasoActual]))
        {
            AvanzarTutorial();
        }

        // Temporizador activo
        if (temporizadorActivo)
        {
            ActualizarTemporizador();
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            botonpausa.onClick.Invoke();
        }
        RevisarPuntos();
    }

    public void MostrarPanelTiempo(float segundos)
    {
        StartCoroutine(MostrarTemporalmente(segundos));
    }

    private System.Collections.IEnumerator MostrarTemporalmente(float segundos)
    {
        panelMision.SetActive(true);
        yield return new WaitForSeconds(segundos);

        if (anipanelmi != null)
            anipanelmi.Play("SalidaMI");

        yield return new WaitForSeconds(1f); // Espera que termine la animación
        panelMision.SetActive(false);
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

            if (panelTempo != null)
                panelTempo.SetActive(true);

            if (panelMision != null)
            {
                panelMision.SetActive(true);
                MostrarPanelTiempo(3f);
            }

            if (panelPuntos != null)
            {   
                IniciarTemporizador();

                if (puntos >= 4000)
                {
                    panelPuntos.SetActive(false);
                    panelre.SetActive(true);
                    paneljuegof.SetActive(true);
                    RevisarPuntos();
                    puntos = PlayerPrefs.GetInt("Puntos guardados");
                    PlayerPrefs.Save();
                }
                else
                {
                    panelPuntos.SetActive(true);
                }
                
            }
            
        }
    }

    public void RestaurarPuntos()
    {
        puntos = 0;
        PlayerPrefs.DeleteKey("Puntos guardados"); //Elimina el valor guardado
        PlayerPrefs.Save();

        paneljuegof.SetActive(false);
        panelre.SetActive(false);
        panelPuntos.SetActive(false);

        Debug.Log("Puntos reiniciados.");
    }


    void IniciarTemporizador()
    {
        tiempoRestante = duracion;
        temporizadorActivo = true;

        if (barraTiempo != null)
        {
            barraTiempo.fillAmount = 1f;
        }
        if (barraVida != null)
        {
            barraVida.fillAmount = 1f;
        }
        if (barraEstamina != null)
        {
            barraEstamina.fillAmount = 1f;
        }
        if (textoTiempo != null)
        {
            textoTiempo.text = Mathf.CeilToInt(tiempoRestante).ToString();
        }
    }

    void ActualizarTemporizador()
    {
        if (tiempoRestante > 0)
        {
            tiempoRestante -= Time.deltaTime;
            float porcentaje = tiempoRestante / duracion;

            if (barraTiempo != null)
            {
                barraTiempo.fillAmount = porcentaje;
            }
                
            if (barraVida != null)
            {
                barraVida.fillAmount = porcentaje;
            }
            if (barraEstamina != null)
            {
                barraEstamina.fillAmount = porcentaje;
            }
            if (textoTiempo != null)
            {

            }

            if (tiempoRestante <= 3f)
            {
                if (barraTiempo != null) barraTiempo.color = Color.red;
                if (textoTiempo != null) textoTiempo.color = Color.red;
            }

            if (tiempoRestante <= 0)
            {
                tiempoRestante = 0;
                temporizadorActivo = false;
                TemporizadorFinalizado();
            }
             
        }
    }

    void TemporizadorFinalizado()
    {
        if (audioFinal != null)
        {
            audioFinal.Play();
        }
        if (panelFinal != null) 
        {
            panelFinal.SetActive(true);
        }

        if (puntos >= 4000)
        {
            panelre.SetActive(true);
            paneljuegof.SetActive(true);
            if (panelPuntos != null)
            {
                panelPuntos.SetActive(false);
            }
                
        }

    }

    void RevisarPuntos()
    {
        puntos = PlayerPrefs.GetInt("Puntos guardados", 0);

        if (puntos >= 4000)
        {
            panelPuntos?.SetActive(false);
            panelre?.SetActive(true);
            paneljuegof?.SetActive(true);
        }
    }

}

