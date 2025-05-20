using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class gestorimagen : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public Image imagenObjetivo;       // La imagen que cambiará
    public Sprite[] sprites;           // Lista de imágenes a mostrar
    private int indiceActual = 0;

    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    public void CambiarImagen()
    {
                        // Avanza al siguiente sprite
        indiceActual++;
        if (indiceActual >= sprites.Length)
        {
            indiceActual = 0;
        }
                // Reinicia si llega al final
         imagenObjetivo.sprite = sprites[indiceActual];
    }
}
