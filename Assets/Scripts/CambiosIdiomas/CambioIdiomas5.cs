using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using System.Runtime.InteropServices.WindowsRuntime;

//poner el valor del cambio de idiomas 1 al 2, para cuando se cambie el idioma en las opciones, se cambie en todas las pantallas (escenas)
public class CambioIdiomas5 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public TextMeshProUGUI titulotutod;
    public TextMeshProUGUI titulotutoa;
    public TextMeshProUGUI titulotutos;
    public TextMeshProUGUI titulow;
    public TextMeshProUGUI textd;
    public TextMeshProUGUI texta;
    public TextMeshProUGUI texts;
    public TextMeshProUGUI textw;
    public TextMeshProUGUI titulocorrer;
    public TextMeshProUGUI tituloabririnventario;
    public TextMeshProUGUI titulorecarga;
    public TextMeshProUGUI titulointeracionentonrno;
    public TextMeshProUGUI titulocubrirse;
    

    public int i = 0;


    string[,] matrizIdiomas = new string[3, 13]
    {
        {"Teclas","Atacar","Adelante","Derecha","Izquierda", "Atrás","Agachar","Saltar","Correr","Abrir Inventario","Recarga de arma/habilidad","Abrir/Recoger (Interacción con el entorno)", "Cubrirse"},
        {"Keys","Attack","Forward","Right","Left","Behind","Crouch","Jump","Run","Open inventory","Weapon/Skill Reload", "Open/Pick up (Interaction with the environment)", "Cover up"},
        {"Teclas","Ataque","Diante","Dereita","Ezquerda","Atrás","Pato","Salto","Correr","Abrir Inventario","Recarga arma/habilidade", "Abrir/Recoller (interacción co ambente)", "Poñerse a cuberto"}
    };

    
    //organizado de 0 al 13 del orden que lo puse en public
    void Start()
    {
        int i = PlayerPrefs.GetInt("Idioma", 0);

        
        

    }


    void Update()
    {
        
    }

    void ActualizarTextos()
    {
        tituloteclas.text = matrizIdiomas[i, 0];
        
        

    }

    void GuardarDatos ()
    {
        PlayerPrefs.SetInt("Idioma", i);
        PlayerPrefs.Save();
    }

  

    public void Menu(int index)
    {
        switch (index)
        {
            case 0:
                i=0;
                break;
            case 1:
                i=1;
                break;
            case 2:
                i=2;
                break;
        }
    }
}
