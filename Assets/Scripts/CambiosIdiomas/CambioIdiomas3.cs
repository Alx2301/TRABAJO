using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine.Rendering;

//poner el valor del cambio de idiomas 1 al 2, para cuando se cambie el idioma en las opciones, se cambie en todas las pantallas (escenas)
public class CambioIdiomas3 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public TextMeshProUGUI botonnuevapartidatext;
    public TextMeshProUGUI botoncargarpartidatext;
    public TextMeshProUGUI botonconfiguraciontext;
    public TextMeshProUGUI botonsalidatext;
    public TextMeshProUGUI botoncreditostext;
    public TextMeshProUGUI botonsolitario;
    public TextMeshProUGUI boton2jug;
    public TextMeshProUGUI boton3jug;
    public TextMeshProUGUI boton4jug;
    public TextMeshProUGUI titulocuenta;
    public TextMeshProUGUI botonin;
    public TextMeshProUGUI botonre;
    public TextMeshProUGUI botonjugarcinv;
    public TextMeshProUGUI botonjugarinv;
    public TextMeshProUGUI botonatras;
    public TextMeshProUGUI botonatrasin;
    public TextMeshProUGUI botonatrasre;
    public TextMeshProUGUI botonatrasad;
    public TextMeshProUGUI botonatrasadin;
    public TextMeshProUGUI tituloiniciar;
    public TextMeshProUGUI titulore;
    public TextMeshProUGUI titulousuario;
    public TextMeshProUGUI titulocontrasena;
    public InputField titulointroduceusu;
    public InputField titulointroducecon;
    public TextMeshProUGUI titulousuariore;
    public TextMeshProUGUI titulocontrasenare;
    public InputField titulointroduceusure;
    public InputField titulointroduceconre;
    public TextMeshProUGUI botonguardar;
    public TextMeshProUGUI botonjugar;
    public TextMeshProUGUI botonguardarre;
    public TextMeshProUGUI botonjugarre;
    public TextMeshProUGUI titulocorreo;
    public InputField introducecorreo;
    public TextMeshProUGUI tituloadvertenciainv;
    public TextMeshProUGUI textoadinv;
    public TextMeshProUGUI tituload;
    public TextMeshProUGUI textoad;
    public TextMeshProUGUI botonsi;
    public TextMeshProUGUI textosalir;

    public int i = 0;


    string[,] matrizIdiomas = new string[3, 27]
    {
        {"Nueva partida","Cargar partida","Configuración","Salida", "Créditos", "Solitario", "2 jugadores", "3 jugadores", "4 jugadores", "Cuenta de usuario", "Iniciar sesión","Registrar","Jugador invitado","Volver","Usuario","Contraseña","Introduce el nombre de usuario", "Introduce una contraseña","Jugar","Guardar","Correo","Advertencia","Necesitas iniciar sesión para jugar.","Al acceder como invitado debes saber que tus datos y juegos no serán guardados.","Introduce tu correo","Si","¿Estás seguro que quieres salir?"},
        {"New party","Load party","Configuration","Exit", "Credits", "Solo", "2 players", "3 players", "4 players", "User account", "Login","Register","Guest player","Back","User","Password","Enter username","Entre password", "Play","Save", "Email","Warning","You need to log in to play.","When accessing as a guest, you should know that your data and games will not be saved.", "Enter your email", "Yes","Are you sure you want to exit the game?"},
        {"Nova partida","Cargar partida","Configuración","Saída", "Créditos", "Solitario", "2 xugadores", "3 xugadores", "4 xugadores","Conta de usuario", "Iniacio de sesión","Rexistro","Xogador convidado","Atras", "Usuario","Contrasinal","Introduce o nome de usuario","Introduce un contrasinal","Xogar","Gardar","Correo","Aviso","Necesitas iniciar sesión para xogar.","Ao acceder como convidado, debes saber que os teus datos e xogos non se gardarán.", "Introduce o teu correo electrónico", "Si","Seguro que queres saír do xogo?"}
    };

    

    void Start()
    {
        int i = PlayerPrefs.GetInt("Idioma", 0);

        botonnuevapartidatext.text = matrizIdiomas[i,0];
        botoncargarpartidatext.text = matrizIdiomas[i, 1];
        botonconfiguraciontext.text = matrizIdiomas[i, 2];
        botonsalidatext.text = matrizIdiomas[i, 3];
        botoncreditostext.text = matrizIdiomas[i, 4];
        botonsolitario.text= matrizIdiomas[i,5];
        boton2jug.text=matrizIdiomas[i, 6];
        boton3jug.text = matrizIdiomas[i,7];
        boton4jug.text = matrizIdiomas [i,8];
        titulocuenta.text = matrizIdiomas[i,9];
        tituloiniciar.text= matrizIdiomas[i,10];
        botonin.text = matrizIdiomas[i, 10];
        titulore.text = matrizIdiomas[i, 11];
        botonre.text = matrizIdiomas[i, 11];
        botonjugarcinv.text = matrizIdiomas[i, 12];
        botonatras.text = matrizIdiomas[i, 13];
        botonatrasad.text = matrizIdiomas[i, 13];
        botonatrasadin.text = matrizIdiomas[i, 13];
        botonatrasin.text = matrizIdiomas[i, 13];
        botonatrasre.text = matrizIdiomas[i, 13];
        titulousuario.text = matrizIdiomas[i, 14];
        titulousuariore.text = matrizIdiomas[i, 14];
        titulocontrasena.text = matrizIdiomas[i, 15];
        titulocontrasenare.text = matrizIdiomas[i, 15];
        titulointroduceusu.placeholder.GetComponent<Text>().text = matrizIdiomas[i, 16];
        titulointroduceusure.placeholder.GetComponent<Text>().text = matrizIdiomas[i, 16];
        titulointroducecon.placeholder.GetComponent<Text>().text = matrizIdiomas[i,17];
        titulointroduceconre.placeholder.GetComponent<Text>().text = matrizIdiomas[i, 17];
        botonjugar.text = matrizIdiomas[i, 18];
        botonjugarinv.text = matrizIdiomas[i, 18];
        botonjugarre.text = matrizIdiomas[i, 18];
        botonguardar.text = matrizIdiomas[i, 19];
        botonguardarre.text = matrizIdiomas[i,19];
        titulocorreo.text = matrizIdiomas[i,20];
        introducecorreo.placeholder.GetComponent<Text>().text = matrizIdiomas[i, 24];
        tituload.text = matrizIdiomas[i, 21];
        tituloadvertenciainv.text = matrizIdiomas[i, 21];
        textoad.text = matrizIdiomas[i, 22];
        textoadinv.text = matrizIdiomas[i, 23];
        botonsi.text = matrizIdiomas[i, 25];
        textosalir.text = matrizIdiomas[i,26];

    }


    void Update()
    {
        
    }

    void ActualizarTextos()
    {
        botonnuevapartidatext.text = matrizIdiomas[i, 0];
        botoncargarpartidatext.text = matrizIdiomas[i, 1];
        botonconfiguraciontext.text = matrizIdiomas[i, 2];
        botonsalidatext.text = matrizIdiomas[i, 3];
        botoncreditostext.text = matrizIdiomas[i, 4];
        botonsolitario.text = matrizIdiomas[i, 5];
        boton2jug.text = matrizIdiomas[i, 6];
        boton3jug.text = matrizIdiomas[i, 7];
        boton4jug.text = matrizIdiomas[i, 8];
        titulocuenta.text = matrizIdiomas[i, 9];
        tituloiniciar.text = matrizIdiomas[i, 10];
        botonin.text = matrizIdiomas[i, 10];
        titulore.text = matrizIdiomas[i, 11];
        botonre.text = matrizIdiomas[i, 11];
        botonjugarinv.text = matrizIdiomas[i, 12];
        botonatras.text = matrizIdiomas[i, 13];
        botonatrasad.text = matrizIdiomas[i, 13];
        botonatrasadin.text = matrizIdiomas[i, 13];
        botonatrasin.text = matrizIdiomas[i, 13];
        botonatrasre.text = matrizIdiomas[i, 13];
        titulousuario.text = matrizIdiomas[i, 14];
        titulousuariore.text = matrizIdiomas[i, 14];
        titulocontrasena.text = matrizIdiomas[i, 15];
        titulocontrasenare.text = matrizIdiomas[i, 15];
        titulointroduceusu.text = matrizIdiomas[i, 16];
        titulointroduceusure.text = matrizIdiomas[i, 16];
        titulointroducecon.text = matrizIdiomas[i, 17];
        titulointroduceconre.text = matrizIdiomas[i, 17];
        botonjugar.text = matrizIdiomas[i, 18];
        botonjugarinv.text = matrizIdiomas[i, 18];
        botonjugarre.text = matrizIdiomas[i, 18];
        botonguardar.text = matrizIdiomas[i, 19];
        botonguardarre.text = matrizIdiomas[i, 19];
        titulocorreo.text = matrizIdiomas[i, 20];
        introducecorreo.text = matrizIdiomas[i, 24];
        tituload.text = matrizIdiomas[i, 21];
        tituloadvertenciainv.text = matrizIdiomas[i, 21];
        textoad.text = matrizIdiomas[i, 22];
        textoadinv.text = matrizIdiomas[i, 23];
        botonsi.text = matrizIdiomas[i, 25];
        textosalir.text = matrizIdiomas[i, 26];
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
