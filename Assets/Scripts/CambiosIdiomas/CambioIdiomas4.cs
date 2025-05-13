using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using System.Runtime.InteropServices.WindowsRuntime;

//poner el valor del cambio de idiomas 1 al 2, para cuando se cambie el idioma en las opciones, se cambie en todas las pantallas (escenas)
public class CambioIdiomas4 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public TextMeshProUGUI tituloteclas;
    public TextMeshProUGUI tituloatacar;
    public TextMeshProUGUI titulomoverse;
    public TextMeshProUGUI tituloderecha;
    public TextMeshProUGUI tituloizquierda;
    public TextMeshProUGUI tituloabajo;
    public TextMeshProUGUI tituloagachar;
    public TextMeshProUGUI titulosaltar;
    public TextMeshProUGUI titulocorrer;
    public TextMeshProUGUI tituloabririnventario;
    public TextMeshProUGUI titulorecarga;
    public TextMeshProUGUI titulointeracionentonrno;
    public TextMeshProUGUI titulocubrirse;
    public TextMeshProUGUI titulover;

    public int i = 0;


    string[,] matrizIdiomas = new string[3, 14]
    {
        {"Teclas","Atacar","Adelante","Derecha","Izquierda", "Atrás","Agachar","Saltar","Correr","Abrir Inventario","Recarga de arma/habilidad","Abrir/Recoger (Interacción con el entorno)", "Cubrirse", "Ver elementos/enemigos ocultos cercanos"},
        {"Keys","Attack","Forward","Right","Left","Behind","Crouch","Jump","Run","Open inventory","Weapon/Skill Reload", "Open/Pick up (Interaction with the environment)", "Cover up", "View nearby hidden items/enemies"},
        {"Teclas","Ataque","Diante","Dereita","Ezquerda","Atrás","Pato","Salto","Correr","Abrir Inventario","Recarga arma/habilidade", "Abrir/Recoller (interacción co ambente)", "Poñerse a cuberto", "Ver obxectos/inimigos ocultos próximos"}
    };

    
    //organizado de 0 al 13 del orden que lo puse en public
    void Start()
    {
        int i = PlayerPrefs.GetInt("Idioma", 0);

        tituloteclas.text = matrizIdiomas[i,0];
        tituloatacar.text = matrizIdiomas[i, 1];
        titulomoverse.text = matrizIdiomas[i, 2];
        tituloderecha.text = matrizIdiomas[i, 3];
        tituloizquierda.text = matrizIdiomas[i, 4];
        tituloabajo.text = matrizIdiomas[i,5];
        tituloagachar.text = matrizIdiomas[i, 6];
        titulosaltar.text= matrizIdiomas[i,7];
        titulocorrer.text = matrizIdiomas[i,8];
        tituloabririnventario.text = matrizIdiomas[i,9];
        titulorecarga.text = matrizIdiomas[i,10];
        titulointeracionentonrno.text = matrizIdiomas[i,11];
        titulocubrirse.text = matrizIdiomas[i,12];
        titulover.text = matrizIdiomas[i,13];

    }


    void Update()
    {
        
    }

    void ActualizarTextos()
    {
        tituloteclas.text = matrizIdiomas[i, 0];
        tituloatacar.text = matrizIdiomas[i, 1];
        titulomoverse.text = matrizIdiomas[i, 2];
        tituloderecha.text = matrizIdiomas[i, 3];
        tituloizquierda.text = matrizIdiomas[i, 4];
        tituloabajo.text = matrizIdiomas[i, 5];
        tituloagachar.text = matrizIdiomas[i, 6];
        titulosaltar.text = matrizIdiomas[i, 7];
        titulocorrer.text = matrizIdiomas[i, 8];
        tituloabririnventario.text = matrizIdiomas[i, 9];
        titulorecarga.text = matrizIdiomas[i, 10];
        titulointeracionentonrno.text = matrizIdiomas[i, 11];
        titulocubrirse.text = matrizIdiomas[i, 12];
        titulover.text = matrizIdiomas[i, 13];

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
