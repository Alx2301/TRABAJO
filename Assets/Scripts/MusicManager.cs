using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public AudioSource[] audios; // Aquí arrastras los 3 AudioSource (1 por audio)
    public static MusicManager instance;

    void Awake()
    {
        // Hacer persistente entre escenas
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            IniciarAudioGuardado();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void IniciarAudioGuardado()
    {
        int audioElegido = PlayerPrefs.GetInt("AudioSeleccionado", 0); // Por defecto el 0

        // Apaga todos los audios primero
        foreach (AudioSource audio in audios)
            audio.Stop();

        // Enciende solo el seleccionado
        if (audioElegido >= 0 && audioElegido < audios.Length)
            audios[audioElegido].Play();
    }

    public void SeleccionarAudio(int indice)
    {
        // Apaga todos

        for (int i = 0; i < audios.Length; i++)
        {
            if (audios[i].isPlaying)
            {
                audios[i].Stop();
            }
            
        }

        // Reproduce el elegido
        if (indice >= 0 && indice < audios.Length)
        {
            audios[indice].Play();
            PlayerPrefs.SetInt("AudioSeleccionado", indice);
            PlayerPrefs.Save();
        }
    }
}

