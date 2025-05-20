using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;


public class GestorAnimaciones : MonoBehaviour
{
    private int estadoOpciones;
    private int seleccion;
    public Animator animator1;
    public Animator animator2;
    public Animator animator3;
    public Animator animator4;
    public Animator animator5;
    public GameObject panelU;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int selection = PlayerPrefs.GetInt("Jugadores", 0);
        panelU.SetActive(false);
        estadoOpciones = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    public void Solitario()
    {
        seleccion = 1;
        Estado();
    }
    public void Jugador2()
    {
        seleccion = 2;
        Estado();
    }
    public void Jugador3()
    {
        seleccion = 3;
        Estado();
    }

    public void Jugador4()
    {
        seleccion = 4;
        Estado();
    }

    private void AbrirOpciones1()
    {
        switch (estadoOpciones)
        {
            case 1:
                
                animator1.Play("Animacion Solitario");
                animator2.Play("Animacion2jug");
                animator3.Play("Animacion3jug");
                animator4.Play("Animacion4jug");
                break;
        }
    }
    private void CerrarOpciones1()
    {
        switch (estadoOpciones)
        {
            case 1:
                animator1.Play("Animacion Solitario Salir");
                animator2.Play("Animacion2jugS");
                animator3.Play("Animacion3jugS");
                animator4.Play("Animacion4jugS");
                break;
        }
    }

    public void Estado()
    {
        if (estadoOpciones > 0)
        {
            CerrarOpciones1();
            estadoOpciones = seleccion;
            AbrirOpciones1();
        }
        else
        {
            estadoOpciones = seleccion;
            AbrirOpciones1();
        }
    }
    
    public void MenuU()
    {
        panelU.SetActive(true);
        animator5.Play("AnimacionPanelU");
    }
    public void MenuUS()
    {
        panelU.SetActive(false);
    }
}
