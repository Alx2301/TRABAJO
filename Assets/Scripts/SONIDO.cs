using UnityEngine;

public class SONIDO : MonoBehaviour
{
    
    public void ElegirAudio0() => MusicManager.instance.SeleccionarAudio(0);
    public void ElegirAudio1() => MusicManager.instance.SeleccionarAudio(1);
    public void ElegirAudio2() => MusicManager.instance.SeleccionarAudio(2);

// Start is called once before the first execution of Update after the MonoBehaviour is created
void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
