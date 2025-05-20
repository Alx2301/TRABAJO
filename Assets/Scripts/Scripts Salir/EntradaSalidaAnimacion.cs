using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class EntradaSalidaAnimacion : MonoBehaviour
{
    public Animator animator;
    public GameObject panelSalir;
    public void ReproducirEntrada() 
    {
        panelSalir.SetActive(true);
    }
    public void ReproducirSalida() 
    {
        animator.Play("PANEL SALIR 2");
        panelSalir.SetActive(false);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        panelSalir.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
     
    }
}
