using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using System.Runtime.InteropServices.WindowsRuntime;

public class GestorDatosVoliumen : MonoBehaviour
{

    public Slider Volumenmusicavalor;
    public Slider Volumendialogovalor;
    public Slider Volumenanimaciones;
    public Slider Volumenefectos;
    public Slider Volumenhabilidades;
    public Slider Volumenentorno;

    private float valorguardadomusica;
    private float valorguardadodialogo;
    private float valorguardadoanimaciones;
    private float valorguardadoefectos;
    private float valorguardadohabilidades;
    private float valorguardadoentorno;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        valorguardadomusica=PlayerPrefs.GetFloat("ValorMusica", Volumenmusicavalor.minValue);
        Volumenmusicavalor.value = valorguardadomusica;
        Volumenmusicavalor.onValueChanged.AddListener(GuardarValorMusica);

        valorguardadodialogo = PlayerPrefs.GetFloat("ValorDialogo", Volumendialogovalor.minValue);
        Volumendialogovalor.value = valorguardadodialogo;
        Volumendialogovalor.onValueChanged.AddListener(GuardarValorDialogo);

        valorguardadoanimaciones=PlayerPrefs.GetFloat("ValorAnimaciones", Volumenanimaciones.minValue);
        Volumenanimaciones.value = valorguardadoanimaciones;
        Volumenanimaciones.onValueChanged.AddListener(GuardarValorAnimaciones);

        valorguardadoefectos=PlayerPrefs.GetFloat("ValorEfectos",Volumenefectos.minValue);
        Volumenefectos.value = valorguardadoefectos;
        Volumenefectos.onValueChanged.AddListener(GuardarValorEfectos);

        valorguardadohabilidades=PlayerPrefs.GetFloat("ValorH",Volumenhabilidades.minValue);
        Volumenhabilidades.value=valorguardadohabilidades;
        Volumenhabilidades.onValueChanged.AddListener(GuardarValorH);

        valorguardadoentorno=PlayerPrefs.GetFloat("ValorE", Volumenentorno.minValue);
        Volumenentorno.value=valorguardadoentorno;
        Volumenentorno.onValueChanged.AddListener(GuardarValorH);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GuardarValorMusica(float valor)
    {
        valorguardadomusica = valor;
        PlayerPrefs.SetFloat("ValorMusica", valorguardadomusica);
        PlayerPrefs.Save();
        Debug.Log("Valor Musica Guardado: " + valorguardadomusica);
    }

    void GuardarValorDialogo(float valor)
    {
        valorguardadodialogo = valor;
        PlayerPrefs.SetFloat("ValorDialogo", valorguardadodialogo);
        PlayerPrefs.Save();
        Debug.Log("Valor Dialogo Guardado: " + valorguardadodialogo);
    }

    void GuardarValorAnimaciones(float valor)
    {
        valorguardadoanimaciones = valor;
        PlayerPrefs.SetFloat("ValorAnimaciones", valorguardadoanimaciones);
        PlayerPrefs.Save();
        Debug.Log("Valor Anim Guardado: " + valorguardadoanimaciones);
    }

    void GuardarValorEfectos(float valor)
    {
        valorguardadoefectos = valor;
        PlayerPrefs.SetFloat("ValorEfectos", valorguardadoefectos);
        PlayerPrefs.Save();
        Debug.Log("Valor VX Guardado: " + valorguardadoefectos);
    }

    void GuardarValorH(float valor)
    {
        valorguardadohabilidades = valor;
        PlayerPrefs.SetFloat("ValorH", valorguardadohabilidades);
        PlayerPrefs.Save();
        Debug.Log("Valor Habilidades Guardado: "+ valorguardadohabilidades);
    }

    void GuardarValorEntorno(float valor)
    {
        valorguardadoentorno = valor;
        PlayerPrefs.SetFloat("ValorE", valorguardadoentorno);
        PlayerPrefs.Save();
        Debug.Log("Valor Entorno Guardado: " + valorguardadoentorno);
    }


}
