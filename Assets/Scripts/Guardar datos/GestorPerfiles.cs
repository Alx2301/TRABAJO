using UnityEngine;
using System.IO;

public class GestorPerfiles : MonoBehaviour
{
    public PerfilJugador perfilActual;
    private string rutaBase => Application.persistentDataPath + "/Perfiles/";

    public void CrearPerfil(string nombreJugador)
    {
        perfilActual = new PerfilJugador
        {
            nombre = nombreJugador,
            puntos = 0,
            nivel = 1,
            volumenMusica = 1f,
            
        };

        GuardarPerfil();
    }

    public void GuardarPerfil()
    {
        string json = JsonUtility.ToJson(perfilActual, true);
        File.WriteAllText(rutaBase + perfilActual.nombre + ".json", json);
        Debug.Log("Perfil guardado: " + perfilActual.nombre);
    }

    public bool CargarPerfil(string nombreJugador)
    {
        string ruta = rutaBase + nombreJugador + ".json";
        if (File.Exists(ruta))
        {
            string json = File.ReadAllText(ruta);
            perfilActual = JsonUtility.FromJson<PerfilJugador>(json);
            Debug.Log("Perfil cargado: " + perfilActual.nombre);
            return true;
        }
        else
        {
            Debug.LogWarning("❌ Perfil no encontrado: " + nombreJugador);
            return false;
        }
    }
}
