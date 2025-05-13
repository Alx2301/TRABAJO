using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class EntradaSalidaAnimacion : MonoBehaviour
{
    public Animator animator;
    public void ReproducirEntrada() 
    {
        animator.Play("PANEL SALIR");
    }
    public void ReproducirSalida() 
    {
        animator.Play("PANEL SALIR 2");
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
