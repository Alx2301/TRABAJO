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
    public void CmMenuPausa()
    {
        SceneManager.LoadScene("Menu Pausa");
    }
    public void IrAConfiguracion()
    {
        // Guardamos el nombre de la escena actual
        PlayerPrefs.SetString("Menu Actual", UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
        PlayerPrefs.Save();

        // Cambiamos a la escena de Configuración
        UnityEngine.SceneManagement.SceneManager.LoadScene("Menu opciones idiomas");
    }
    public void VolverEscenaAnterior()
    {
        string escenaAnterior = PlayerPrefs.GetString("Menu Actual", "Menu Principal"); // valor por defecto

        UnityEngine.SceneManagement.SceneManager.LoadScene(escenaAnterior);
    }
    public void MenuGuardar()
    {
        SceneManager.LoadScene("Menu guardar partida");
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