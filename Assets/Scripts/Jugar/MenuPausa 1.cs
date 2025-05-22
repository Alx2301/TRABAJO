using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class MenuPausa1 : MonoBehaviour
{
    
    public GameObject panels1;
    public GameObject panelg;
    public Button bortonsi1;
    public Button bortonsi2;
    public Button bortonno1;
    public Button bortonno2;
    public Button botonsalir;
    private int Po = 0;
    void Start()
    {
        panelg.SetActive(false);
        panels1.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Po == 0)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                bortonno1.onClick.Invoke();
            }
        }
        if (Po == 2)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                bortonno2.onClick.Invoke();
            }
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            botonsalir.onClick.Invoke();
        }

    }

    public void PanelSSalir()
    {
        Po = 1;
        panels1.SetActive(true);
    }
    public void PanelGSalir()
    {
        Po = 2;
        panelg.SetActive(true);
    }
    public void QuitarPanelG()
    {
        panelg.SetActive(false);
    }
    public void QuitarPanelS() 
    { 
        panels1.SetActive(false);
    } 
}
