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
    
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        estadoOpciones = 0;
        seleccion = 0;
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
    

    private void AbrirOpciones1()
    {
        switch (estadoOpciones)
        {
            case 1:
                
                animator1.Play("Animacion Solitario");
                animator2.Play("Animacion Multijugador");
                break;
        }
    }
    private void CerrarOpciones1()
    {
        switch (estadoOpciones)
        {
            case 1:
                animator1.Play("Animacion Solitario Salir");
                animator2.Play("Animacion Multijugador Salir");
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
    


}
