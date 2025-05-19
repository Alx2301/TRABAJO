using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class PanelTutorialS : MonoBehaviour
{
   
    public GameObject paneltutod;
    public GameObject paneltutoa;
    public GameObject paneltutos;
    public GameObject paneltutow;
    public Animator fondo;
    public Animator apaneltutod;
    public Animator apaneltutoa;
    public Animator apaneltutos;
    public Animator apaneltutow;
    public KeyCode teclaParaCerrar = KeyCode.Escape;
    public KeyCode teclacerrar2 = KeyCode.D;
    public KeyCode teclacerrar3 = KeyCode.A;
    public KeyCode teclascerrar4 = KeyCode.S;
    public KeyCode teclacerrar5 = KeyCode.W;
    public float tiempoMinimo = 1f;
    private bool puedecerrar =false;

    void Start()
    {
        paneltutod.SetActive(false);
        paneltutoa.SetActive(false);
        paneltutos.SetActive(false);
        paneltutow.SetActive(false);
        
        Invoke("MostrarTutorial", 1f);
        
    }
    void Update()
    {
        if (puedecerrar && Input.GetKeyDown(teclaParaCerrar))
        {
            apaneltutod.Play("AnimacionTDS");
            puedecerrar = false;
        }
        else if (puedecerrar && Input.GetKeyDown(teclacerrar2))
        {
            apaneltutod.Play("AnimacionTDS");
            puedecerrar = false;
            fondo.Play("AnimacionDerecha");
        }
        else if (puedecerrar && Input.GetKeyDown(teclacerrar3))
        {
            apaneltutoa.Play("AnimacionTAS");
            puedecerrar = false;
            fondo.Play("AnimacionIzquierda");
        }
        else if (puedecerrar && Input.GetKeyDown(teclascerrar4))
        {
            apaneltutos.Play("AnimacionTSS");
            puedecerrar = false;
            fondo.Play("AnimacionAbajo");
        }
        else if (puedecerrar && Input.GetKeyDown(teclacerrar5))
        {
            apaneltutow.Play("AnimacionTWS");
            puedecerrar = false;
            fondo.Play("AnimacionArriba");
        }

    }
    void MostrarTutorial()
    {
        paneltutod.SetActive(true);
        paneltutoa.SetActive(true);
        paneltutos.SetActive(true);
        paneltutow.SetActive(true) ;
        puedecerrar = true;
    }
    
}
