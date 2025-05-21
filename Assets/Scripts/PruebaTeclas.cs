using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class PruebaTeclas : MonoBehaviour
{
    
    public TextMeshProUGUI textospace;       // Texto que muestra la tecla actual
    public string nombreAccion = "Saltar";   // Nombre para PlayerPrefs
    private KeyCode teclaspace = KeyCode.Space; // Tecla por defecto
    private bool esperandoNuevaTecla = false;

    public TextMeshProUGUI textow;
    public string Adelante = "Adelante";
    private KeyCode teclaw = KeyCode.W;
    private bool esperandoparaad = false;

    public TextMeshProUGUI textos;
    public string Atras = "Atras";
    private KeyCode teclas = KeyCode.S;
    private bool esperandoparas = false;

    public TextMeshProUGUI textoa;
    public string Izquierda = "Izquierda";
    private KeyCode teclaa = KeyCode.A;
    private bool esperandoparaa;

    public TextMeshProUGUI textod;
    public string Derecha = "Derecha";
    private KeyCode teclad = KeyCode.D;
    private bool esperandoparad;

    public TextMeshProUGUI textoSHIFT;
    public string Agachar = "Agachar";
    private KeyCode teclaShitf = KeyCode.LeftShift;
    private bool esperandoparaaga;

    public TextMeshProUGUI textoCONTROL;
    public string Correr = "Correr";
    private KeyCode teclaControl = KeyCode.LeftControl;
    private bool esperandoparacorrer;

    public TextMeshProUGUI textoE;
    public string Inventario = "Abrir Inventario";
    private KeyCode teclaE = KeyCode.E;
    private bool esperandoparaINV;

    public TextMeshProUGUI textoR;
    public string Recarga = "Recargar arma";
    private KeyCode teclaR = KeyCode.R;
    private bool esperandoparaRE;

    public TextMeshProUGUI textoF;
    public string InteraccionE = "Interaccion con el entorno";
    private KeyCode teclaF = KeyCode.F;
    private bool esperandoparaIE;

    public TextMeshProUGUI textoCLICKI;
    public string Atacar = "Atacar";
    private KeyCode teclaClickI = KeyCode.Mouse0;
    private bool esperandoparaLeft;

    public TextMeshProUGUI textoCLICKD;
    public string Cubrir = "Cubrir";
    private KeyCode teclaClickD = KeyCode.Mouse1;
    private bool esperandoparaRight;

    public int i = 0;
    public Button botonderecha;
    public Button botoniz;
    public Button botonVolver;
    void Start()
    {
        // Cargar tecla guardada (si existe)
        i = PlayerPrefs.GetInt("Idioma", 0);

        if (PlayerPrefs.HasKey(nombreAccion))
        {
            teclaspace = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString(nombreAccion));
        }

        if (PlayerPrefs.HasKey(Adelante))
        {
            teclaw = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString(Adelante));
        }

        if (PlayerPrefs.HasKey(Atras))
        {
            teclas = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString(Atras));
        }
        if (PlayerPrefs.HasKey(Izquierda))
        {
            teclaa = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString(Izquierda));
        }
        if (PlayerPrefs.HasKey(Derecha))
        {
            teclad = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString(Derecha));
        }
        if(PlayerPrefs.HasKey(Agachar))
        {
            teclaShitf = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString(Agachar));
        }
        if (PlayerPrefs.HasKey(Correr))
        {
            teclaControl = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString(Correr));
        }
        if (PlayerPrefs.HasKey(Inventario))
        {
            teclaE = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString(Inventario));
        }
        if (PlayerPrefs.HasKey(Recarga))
        {
            teclaR = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString(Recarga));
        }
        if (PlayerPrefs.HasKey(InteraccionE))
        {
            teclaF = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString(InteraccionE));
        }
        if (PlayerPrefs.HasKey(Atacar))
        {
            teclaClickI = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString(Atacar));
        }
        if (PlayerPrefs.HasKey(Cubrir))
        {
            teclaClickD = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString(Cubrir));
        }

        ActualizarTexto();
        Up();
    }

    void Update()
    {
        Up();
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            botonVolver.onClick.Invoke();
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            botonVolver.onClick.Invoke();
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            botonderecha.onClick.Invoke();
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            botoniz.onClick.Invoke();
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            botonderecha.onClick.Invoke();
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            botoniz.onClick.Invoke();
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            botonVolver.onClick.Invoke();
        }
    }

    void Up()
    {
        if (esperandoNuevaTecla)
        {
            // Captura cualquier tecla presionada
            foreach (KeyCode tecla in System.Enum.GetValues(typeof(KeyCode)))
            {
                if (Input.GetKeyDown(tecla))
                {
                    teclaspace = tecla;
                    PlayerPrefs.SetString(nombreAccion, tecla.ToString());
                    PlayerPrefs.Save();

                    esperandoNuevaTecla = false;
                    ActualizarTexto();
                    break;
                }
            }
        }


        if (esperandoparaad)
        {
            foreach(KeyCode tecla in System.Enum.GetValues(typeof(KeyCode)))
            {
                if (Input.GetKeyDown(tecla))
                {
                    teclaw = tecla;
                    PlayerPrefs.SetString(Adelante, tecla.ToString());
                    PlayerPrefs.Save();

                    esperandoparaad = false;
                    ActualizarTexto();
                    break;
                }
            }
        }

        if (esperandoparas)
        {
            foreach (KeyCode tecla in System.Enum.GetValues(typeof(KeyCode)))
            {
                if (Input.GetKeyDown(tecla))
                {
                    teclas = tecla;
                    PlayerPrefs.SetString(Atras, tecla.ToString());
                    PlayerPrefs.Save();

                    esperandoparas = false;
                    ActualizarTexto();
                    break;
                }
            }
        }
        if (esperandoparaa)
        {
            foreach (KeyCode tecla in System.Enum.GetValues(typeof(KeyCode)))
            {
                if (Input.GetKeyDown(tecla))
                {
                    teclaa = tecla;
                    PlayerPrefs.SetString(Izquierda, tecla.ToString());
                    PlayerPrefs.Save();

                    esperandoparaa = false;
                    ActualizarTexto();
                    break;
                }
            }
        }
        if (esperandoparad)
        {
            foreach (KeyCode tecla in System.Enum.GetValues(typeof(KeyCode)))
            {
                if (Input.GetKeyDown(tecla))
                {
                    teclad = tecla;
                    PlayerPrefs.SetString(Derecha, tecla.ToString());
                    PlayerPrefs.Save();

                    esperandoparad = false;
                    ActualizarTexto();
                    break;
                }
            }
        }
        if (esperandoparaaga)
        {
            foreach (KeyCode tecla in System.Enum.GetValues(typeof(KeyCode)))
            {
                if (Input.GetKeyDown(tecla))
                {
                    teclaShitf = tecla;
                    PlayerPrefs.SetString(Agachar, tecla.ToString());
                    PlayerPrefs.Save();

                    esperandoparaaga = false;
                    ActualizarTexto();
                    break;
                }
            }
        }
        if (esperandoparacorrer)
        {
            foreach (KeyCode tecla in System.Enum.GetValues(typeof(KeyCode)))
            {
                if (Input.GetKeyDown(tecla))
                {
                    teclaControl = tecla;
                    PlayerPrefs.SetString(Correr, tecla.ToString());
                    PlayerPrefs.Save();

                    esperandoparacorrer = false;
                    ActualizarTexto();
                    break;
                }
            }
        }
        if (esperandoparaINV)
        {
            foreach (KeyCode tecla in System.Enum.GetValues(typeof(KeyCode)))
            {
                if (Input.GetKeyDown(tecla))
                {
                    teclaE= tecla;
                    PlayerPrefs.SetString(Inventario, tecla.ToString());
                    PlayerPrefs.Save();

                    esperandoparaINV = false;
                    ActualizarTexto();
                    break;
                }
            }
        }
        if (esperandoparaRE)
        {
            foreach (KeyCode tecla in System.Enum.GetValues(typeof(KeyCode)))
            {
                if (Input.GetKeyDown(tecla))
                {
                    teclaR = tecla;
                    PlayerPrefs.SetString(Recarga, tecla.ToString());
                    PlayerPrefs.Save();

                    esperandoparaRE = false;
                    ActualizarTexto();
                    break;
                }
            }
        }
        if (esperandoparaIE)
        {
            foreach (KeyCode tecla in System.Enum.GetValues(typeof(KeyCode)))
            {
                if (Input.GetKeyDown(tecla))
                {
                    teclaF = tecla;
                    PlayerPrefs.SetString(InteraccionE, tecla.ToString());
                    PlayerPrefs.Save();

                    esperandoparaIE = false;
                    ActualizarTexto();
                    break;
                }
            }
        }
        if (esperandoparaLeft)
        {
            foreach (KeyCode tecla in System.Enum.GetValues(typeof(KeyCode)))
            {
                if (Input.GetKeyDown(tecla))
                {
                    teclaClickI = tecla;
                    PlayerPrefs.SetString(Atacar, tecla.ToString());
                    PlayerPrefs.Save();

                    esperandoparaLeft = false;
                    ActualizarTexto();
                    break;
                }
            }
        }
        if (esperandoparaRight)
        {
            foreach (KeyCode tecla in System.Enum.GetValues(typeof(KeyCode)))
            {
                if (Input.GetKeyDown(tecla))
                {
                    teclaClickD = tecla;
                    PlayerPrefs.SetString(Cubrir, tecla.ToString());
                    PlayerPrefs.Save();

                    esperandoparaRight = false;
                    ActualizarTexto();
                    break;
                }
            }
        }
    }

    public void EsperarNuevaTecla()
    {
        
        esperandoNuevaTecla = true;
        if (i == 0)
        {
            textospace.text = "Presiona una tecla...";
        }
        else if (i == 1)
        {
            textospace.text = "Press a key...";
        }
        else if (i == 2)
        {
            textospace.text = "Preme unha tecla...";
        }
    }
    public void W()
    {   
        
        esperandoparaad = true;
        if (i == 0)
        {
            textow.text = "Presiona una tecla...";
        }
        else if (i == 1)
        {
            textow.text = "Press a key...";
        }
        else if (i == 2)
        {
            textow.text = "Preme unha tecla...";
        }
        
    }
    public void S()
    {
        
        esperandoparas = true;
        if (i == 0)
        {
            textos.text = "Presiona una tecla...";
        }
        else if (i == 1)
        {
            textos.text = "Press a key...";
        }
        else if (i == 2)
        {
            textos.text = "Preme unha tecla...";
        }
    }
    public void A()
    {
        esperandoparaa = true;
        if (i == 0)
        {
            textoa.text = "Presiona una tecla...";
        }
        else if (i == 1)
        {
            textoa.text = "Press a key...";
        }
        else if (i == 2)
        {
            textoa.text = "Preme unha tecla...";
        }
    }
    public void D()
    {
        
        esperandoparad = true;
        if (i == 0)
        {
            textod.text = "Presiona una tecla...";
        }
        else if (i == 1)
        {
            textod.text = "Press a key...";
        }
        else if (i == 2)
        {
            textod.text = "Preme unha tecla...";
        }
    }
    public void Shift()
    {
        esperandoparaaga = true;
        if (i == 0)
        {
            textoSHIFT.text = "Presiona una tecla...";
        }
        else if (i == 1)
        {
            textoSHIFT.text = "Press a key...";
        }
        else if (i == 2)
        {
            textoSHIFT.text = "Preme unha tecla...";
        }
    }
    public void Control()
    {
        esperandoparacorrer = true;
        if (i == 0)
        {
            textoCONTROL.text = "Presiona una tecla...";
        }
        else if (i == 1)
        {
            textoCONTROL.text = "Press a key...";
        }
        else if (i == 2)
        {
            textoCONTROL.text = "Preme unha tecla...";
        }
    }
    public void E()
    {
        esperandoparaINV = true;
        if (i == 0)
        {
            textoE.text = "Presiona una tecla...";
        }
        else if (i == 1)
        {
            textoE.text = "Press a key...";
        }
        else if (i == 2)
        {
            textoE.text = "Preme unha tecla...";
        }
    }
    public void R()
    {
        esperandoparaRE = true;
        if (i == 0)
        {
            textoR.text = "Presiona una tecla...";
        }
        else if (i == 1)
        {
            textoR.text = "Press a key...";
        }
        else if (i == 2)
        {
            textoR.text = "Preme unha tecla...";
        }
    }
    public void F()
    {
        esperandoparaIE = true;
        if (i == 0)
        {
            textoF.text = "Presiona una tecla...";
        }
        else if (i == 1)
        {
            textoF.text = "Press a key...";
        }
        else if (i == 2)
        {
            textoF.text = "Preme unha tecla...";
        }
    }
    public void ClickI()
    {
        esperandoparaLeft = true;
        if (i == 0)
        {
            textoCLICKI.text = "Presiona una tecla...";
        }
        else if (i == 1)
        {
            textoCLICKI.text = "Press a key...";
        }
        else if (i == 2)
        {
            textoCLICKI.text = "Preme unha tecla...";
        }
    }
    public void ClickD()
    {
        esperandoparaRight = true;
        if (i == 0)
        {
            textoCLICKD.text = "Presiona una tecla...";
        }
        else if (i == 1)
        {
            textoCLICKD.text = "Press a key...";
        }
        else if (i == 2)
        {
            textoCLICKD.text = "Preme unha tecla...";
        }
    }

    void ActualizarTexto()
    {
        textospace.text = teclaspace.ToString();
        textow.text = teclaw.ToString();
        textos.text = teclas.ToString();
        textoa.text = teclaa.ToString();
        textod.text = teclad.ToString();
        textoSHIFT.text = teclaShitf.ToString();
        textoCONTROL.text = teclaControl.ToString();
        textoE.text = teclaE.ToString();
        textoR.text = teclaR.ToString();
        textoF.text = teclaF.ToString();
        textoCLICKI.text = teclaClickI.ToString();
        textoCLICKD.text = teclaClickD.ToString();
    }
}
