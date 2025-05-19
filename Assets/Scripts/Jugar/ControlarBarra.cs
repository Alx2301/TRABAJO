using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine.Rendering;

public class ControlarBarra : MonoBehaviour
{
    public Image barrafondovida;
    public Image barrafondoest;
    public Image barrafondomana;
    public float vidaMax = 100f;
    public float estaminaMax = 100f;
    public float manaMax = 100f;
    private float vidaactual;
    private float estaminaactual;
    private float manaactual;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        vidaactual = vidaMax;
        estaminaactual = estaminaMax;
        manaactual = manaMax;
        ActualizarBarra();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RecibirDaño(float daño)
    {
        vidaactual -= daño;
        if (vidaactual < 0)
        {
            vidaactual = 0;
            ActualizarBarra();
            GuardarDatos();
        }
        GuardarDatos();
        ActualizarBarra();
    }
    public void correr(float sprint)
    {
        estaminaactual -= sprint;
        if (estaminaactual < 0)
        {
            estaminaactual = 0;
            ActualizarBarra();
            GuardarDatos();
        }
        GuardarDatos();
        ActualizarBarra();
    }
    public void atacar(float magia)
    {
        manaactual -= magia;
        if (manaactual < 0)
        {
            manaactual = 0;
            ActualizarBarra();
            GuardarDatos();
        }
        GuardarDatos();
        ActualizarBarra() ;
    }
    public void Curar(float cantidad)
    {
        vidaactual += cantidad;
        if (vidaactual > vidaMax)
        {
            vidaactual = vidaMax;
            ActualizarBarra();
            GuardarDatos();
        }
        ActualizarBarra();
        GuardarDatos();
    }
    public void recuperarE(float cantidad2)
    {
        estaminaactual += cantidad2;
        if (estaminaactual > estaminaMax)
        {
            estaminaactual = estaminaMax;
            ActualizarBarra();
            GuardarDatos();

        }
        ActualizarBarra();
        GuardarDatos();
    }
    public void recuperarM(float cantidad3)
    {
        manaactual += cantidad3;
        if (manaactual > manaMax)
        {
            manaactual = manaMax;
            ActualizarBarra();
            GuardarDatos();
        }
        ActualizarBarra();
        GuardarDatos();
    }

    void ActualizarBarra()
    {
        barrafondovida.fillAmount = vidaactual/vidaMax;
        barrafondoest.fillAmount=estaminaactual/estaminaMax;
    }
    void GuardarDatos()
    {
        PlayerPrefs.SetFloat("Vida jugador", vidaactual);
        PlayerPrefs.SetFloat("Mana jugador", manaactual);
        PlayerPrefs.SetFloat("Estamina jugador", estaminaactual);
        PlayerPrefs.Save();
    }

}
