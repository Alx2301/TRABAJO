using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class CambiaImagen : MonoBehaviour
{
    public Image imagenUI;
    public Sprite nuevaImagen;

    public void CambiarImagen()
    {
        imagenUI.sprite = nuevaImagen;
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
