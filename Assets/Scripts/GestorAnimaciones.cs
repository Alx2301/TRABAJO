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
    private int estadoUPOpciones;
    private int seleccion;
    public Animator animator1;
    public Animator animator2;
    public Animator animator3;
    public Animator animator4;
    public Animator animator5;
    public Animator animator6;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        estadoOpciones = 0;
        seleccion = 0;
        estadoUPOpciones = 0;
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

    public void Multijugador()
    {
        seleccion=2;
        Estado() ;
    }
    public void Players2()
    {
        seleccion = 3;
        Estado() ;
    }
    public void Players3()
    {
        seleccion = 4;
        Estado();
    }
    public void Players4()
    {
        seleccion = 5;
        Estado() ;
    }

    private void AbrirOpciones1()
    {
        switch (estadoOpciones)
        {
            case 1:
                animator1.Play("Animacion Solitario");
                break;
            case 2:
                animator2.Play("Animacion Multijugador");
                break;
        }
    }

    private void AbrirOpciones2() 
    { 
        switch (estadoUPOpciones)
        {
            case 1:
                animator3.Play("Animacion 2 jugadores");
                break;
            case 2:
                animator4.Play("Animacion 3 jugadores");
                break;
            case 3:
                animator5.Play("Animacion 4 jugadores");
                break;
            case 4:
                animator6.Play("Animacion 5 jugadores");
                break;
        }
    }
    private void CerrarOpciones1()
    {
        switch (estadoOpciones)
        {
            case 1:
                animator1.Play("Animacion Solitario Salir");
                break;
            case 2:
                animator2.Play("Animacion Multijugador Salir");
                break;
        }
    }
    private void CerrarOpciones2() 
    {
        switch (estadoUPOpciones)
        {
            case 1:
                animator3.Play("Animacion 2 jugadores salir");
                break;
            case 2:
                animator4.Play("Animacion 3 jugadores salir");
                break;
            case 3:
                animator5.Play("Animacion 4 jugadores salir");
                break;
            case 4:
                animator6.Play("Animacion 5 jugadores salir");
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
    public void Estado2()
    {
        if (estadoUPOpciones > 2)
        {
            CerrarOpciones2();
            estadoUPOpciones = seleccion;
            AbrirOpciones2();
        }
        else
        {
            estadoUPOpciones=seleccion;
            AbrirOpciones2();
        }
    }



}
