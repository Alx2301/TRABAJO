using UnityEngine;
using UnityEngine.UI;

public class SubirBajarEstamina : MonoBehaviour
{
    public Slider barraEstamina;
    public float estaminaActual = 100f;
    public float estaminaMaxima = 100f;
    public float velocidadRecuperacion = 10f;

    void Start()
    {
        barraEstamina.maxValue = estaminaMaxima;
        barraEstamina.value = estaminaActual;
    }

    void Update()
    {
        if (estaminaActual < estaminaMaxima)
        {
            estaminaActual += velocidadRecuperacion * Time.deltaTime;
            estaminaActual = Mathf.Clamp(estaminaActual, 0, estaminaMaxima);
            barraEstamina.value = estaminaActual;
        }
    }

    // ESTE MÉTODO ES EL QUE DEBE ASIGNARSE AL BOTÓN
    public void BajarEstamina(float cantidad)
    {
        estaminaActual = Mathf.Clamp(estaminaActual - cantidad, 0, estaminaMaxima);
        barraEstamina.value = estaminaActual;
        Debug.Log("Estamina bajada en: " + cantidad);
    }
}
