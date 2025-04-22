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
    public void CambiarOp()
    {
        SceneManager.LoadScene("Menu Opciones");
    }
    public void CambiarCarP()
    {
        SceneManager.LoadScene("Menu Cargar Partida");
    }
    public void CambiarCre()
    {
        SceneManager.LoadScene("Menu Creditos");
    }
    public void CambiarMenu() 
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