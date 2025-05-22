using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class GestorCargarP : MonoBehaviour
{
    public Button quitar1;
    public Button quitar2;
    public Button quitar3;
    public GameObject quitar4;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        quitar4.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            quitar1.onClick.Invoke();
        }
    }

    public void Quitar()
    {
        quitar4.SetActive(true);
    }
}
