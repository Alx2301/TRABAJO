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

    [Header("Flechas y volver")]
    public Button botonVolver;
    public Button botonDe;
    public Button botonIz;

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

        GuardarDatosJugador();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            botonVolver.onClick.Invoke();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            botonDe.onClick.Invoke();
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            botonDe.onClick.Invoke();
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            botonIz.onClick.Invoke();
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            botonIz.onClick.Invoke();
        }
    }

    void GuardarValorMusica(float valor)
    {
        valorguardadomusica = valor;
        PlayerPrefs.SetFloat("ValorMusica", valorguardadomusica);
        GuardarDatosJugador();
    }

    void GuardarValorDialogo(float valor)
    {
        valorguardadodialogo = valor;
        PlayerPrefs.SetFloat("ValorDialogo", valorguardadodialogo);
        GuardarDatosJugador();
    }

    void GuardarValorAnimaciones(float valor)
    {
        valorguardadoanimaciones = valor;
        PlayerPrefs.SetFloat("ValorAnimaciones", valorguardadoanimaciones);
        GuardarDatosJugador();
    }

    void GuardarValorEfectos(float valor)
    {
        valorguardadoefectos = valor;
        PlayerPrefs.SetFloat("ValorEfectos", valorguardadoefectos);
        GuardarDatosJugador();
    }

    void GuardarValorH(float valor)
    {
        valorguardadohabilidades = valor;
        PlayerPrefs.SetFloat("ValorH", valorguardadohabilidades);
        GuardarDatosJugador();
    }

    void GuardarValorEntorno(float valor)
    {
        valorguardadoentorno = valor;
        PlayerPrefs.SetFloat("ValorE", valorguardadoentorno);
        GuardarDatosJugador();
    }

    void GuardarDatosJugador()
    {
        PlayerPrefs.Save();
        Debug.Log("Valor Guardado");
    }


}
