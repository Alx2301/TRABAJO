using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class MenuJugar : MonoBehaviour

{

    public GameObject inventario;
    public TextMeshProUGUI textopuntos;

    private int puntos = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        inventario.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void añadirpuntos(int cantidad)
    {
        puntos += cantidad;
        textopuntos.text= "Puntos: " + puntos;

    }
    public void ActivarInv()
    {
        inventario.SetActive(true);
    }
    public void salirInv()
    {
        inventario.SetActive(false);
    }
}
