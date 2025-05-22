using UnityEngine;
using TMPro;
using System.Collections.Generic;

public class ConfiguracionResolucion : MonoBehaviour
{
    [Header("Referencia al TMP_Dropdown")]
    public TMP_Dropdown dropdown;

    // Dos resoluciones fijas: [0] = 1920×1080, [1] = 1020×1020
    private readonly (int w, int h)[] resoluciones =
    {
        (1920, 1080),
        (1020, 1020)    
    };

    void Start()
    {
        // Cargar opciones en el dropdown
        dropdown.ClearOptions();
        dropdown.AddOptions(new List<string>
        {
            "1920 x 1080 (16:9)",
            "1020 x 1020 (1:1)"
        });

        // Seleccionar la opción guardada o la 0 por defecto
        int indiceGuardado = PlayerPrefs.GetInt("ResolucionSel", 0);
        if (indiceGuardado < 0 || indiceGuardado >= resoluciones.Length) indiceGuardado = 0;

        dropdown.value = indiceGuardado;
        dropdown.RefreshShownValue();
        AplicarResolucion(indiceGuardado);
        dropdown.onValueChanged.AddListener(AplicarResolucion);
    }

    private void AplicarResolucion(int indice)
    {
        var res = resoluciones[indice];
        // Usa el mismo modo de pantalla que el jugador tenga (pantalla completa o ventana)
        Screen.SetResolution(res.w, res.h, Screen.fullScreen);

        PlayerPrefs.SetInt("ResolucionSel", indice);
        PlayerPrefs.Save();

        Debug.Log($"Resolución aplicada: {res.w}x{res.h}");
    }

    public void GuardarDatosResolucion()
    {
        PlayerPrefs.GetInt("ResolucionIndex");
        PlayerPrefs.Save();
    }

}



