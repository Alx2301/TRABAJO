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

    [Header ("Tiene que seguir funcionando, pase lo pase")]
    public GameObject paneljuegof;
    public Button botonpausa;
    public Animator anipanelmi;
    public Button reiniciar;
    public GameObject panelMAPA;

    public GameObject panelinv;

    private float tiempoRestante;
    private bool temporizadorActivo = false;
    public TextMeshProUGUI textopuntos;
    private int puntos = 0;

    void Start()
    {
        puntos = PlayerPrefs.GetInt("Puntos guardados", 0);

        foreach (GameObject panel in paneles)
            panel.SetActive(false);

        if (panelMAPA != null)
        {
            panelMAPA.SetActive(false);
        }

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
            if (puntos >= 4000)
            {
                if (Input.GetButton("BOTON RE"))
                {
                    RestaurarPuntos();
                }
                if (Input.GetButton("BOTON R"))
                {
                    RestaurarPuntos();
                }

            }
            else
            {
                panelPuntos.SetActive(false);
                panelre.SetActive(false);
                panelMAPA.SetActive(false);
                panelTempo.SetActive(false);
                paneljuegof.SetActive(false);
                panelMision.SetActive(false);
            }

            
            ;

        }
        panelinv.SetActive(false);
        ActualizarTexto();
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
            ActualizarTemporizador();
        }
        RevisarPuntos();

        if (Input.GetButtonDown("BOTON RE"))
        {
            RestaurarPuntos();
        }
        if (Input.GetButtonDown("BOTON R"))
        {
            RestaurarPuntos();
        }
    }
    public void añadirpuntos(int cantidad)
    {
        puntos += cantidad;
        ActualizarTexto();
        GuardarPuntos();
    }

    public void GuardarPuntos()
    {
        PlayerPrefs.SetInt("Puntos guardados", puntos);
        PlayerPrefs.Save();
        Debug.Log("Puntos guardados manualmente: " + puntos);
    }

    private void ActualizarTexto()
    {
        if (textopuntos != null)
            textopuntos.text = " " + puntos;
    }

    public void AbrirInven()
    {
        panelinv?.SetActive(true);
    }

    public void CerrarInven()
    {
        panelinv?.SetActive(false);
    }

    public void ActivarMApa()
    {
        panelMAPA.SetActive(true);
    }

    public void DesactivarMapa()
    {
        panelMAPA.SetActive(false);
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
                    RevisarPuntos();
                }
                else
                {
                    panelPuntos.SetActive(true);
                    RevisarPuntos();

                    if (Input.GetButton("BOTON CERRAR MAPA"))
                    {
                        ActualizarTemporizador();
                        RevisarPuntos();
                        PlayerPrefs.Save();
                    }
                }
                
            }
            
        }
    }

    public void RestaurarPuntos()
    {
        puntos = 0;
        PlayerPrefs.SetInt("Puntos guardados", puntos);
        PlayerPrefs.Save();
        paneljuegof.SetActive(false);
        panelre.SetActive(false);
        panelPuntos.SetActive(true);
        panelFinal.SetActive(false);

        IniciarTemporizador();
        ActualizarTexto();
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
            if (panelPuntos != null)
            {
                panelre.SetActive(true);
                panelPuntos.SetActive(false);
            }
                
        }

    }

    void RevisarPuntos()
    {
        puntos = PlayerPrefs.GetInt("Puntos guardados", 0);

        if (puntos >= 4000)
        {
            panelPuntos.SetActive(false);
            panelre.SetActive(true);
            paneljuegof.SetActive(true);
            PlayerPrefs.Save();

            if (Input.GetButton("BOTON RE"))
            {
                RestaurarPuntos();
                Debug.Log("Puntos reiniciardos a mano");
                PlayerPrefs.Save();
            }
            if (Input.GetButton("BOTON R"))
            {
                RestaurarPuntos();
                Debug.Log("Puntos reiniciardos a mano");
                PlayerPrefs.Save();
            }
        }
    }

}

