using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class MenuPausa : MonoBehaviour
{
    public Animator panels;
    public GameObject panels1;
    public GameObject panelg;
    public Button bortonsi1;
    public Button bortonsi2;
    public int Op = 0;
    void Start()
    {
        panelg.SetActive(false);
        panels1.SetActive(false);
        Op = PlayerPrefs.GetInt("Opciones", 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PanelSSalir()
    {
        panels1.SetActive(true);
    }
    public void PanelGSalir()
    {
        panelg.SetActive(true);
    }
    public void QuitarPanel()
    {
        panelg.SetActive(false);
        panels1.SetActive(false);
    } 
}
