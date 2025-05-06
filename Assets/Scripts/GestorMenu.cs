using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GestorMenu : MonoBehaviour

{
    public void CambiarMenuP()
    {
        SceneManager.LoadScene("Menu Nueva Partida");
    }
    public void CambiarOpIdiomas()
    {
        SceneManager.LoadScene("Menu opciones idiomas");
    }
    public void CambiarOpSonido()
    {
        SceneManager.LoadScene("Menu opciones sonido");
    }
    public void CambiarOpTeclas()
    {
        SceneManager.LoadScene("Menu opciones teclas");
    }
    public void CambiarOpMando() 
    {
        SceneManager.LoadScene("Menu opciones mando");
    }
    public void CambiarOpGraficos()
    {
        SceneManager.LoadScene("Menu opciones graficos");
    }
    public void CambiarCarP()
    {
        SceneManager.LoadScene("Menu Cargar Partida");
    }
    public void CambiarCreditos()
    {
        SceneManager.LoadScene("Menu Creditos");
    }
    public void CambiarMenuPrincipal() 
    {
        SceneManager.LoadScene("Menu Principal");
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}