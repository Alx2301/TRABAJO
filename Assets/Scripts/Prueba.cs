
using UnityEngine;
public class Prueba : MonoBehaviour
{
    public int vidas; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        vidas = 3;
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
public void Sumar()
{
        // vidas = vidas + 1;
        vidas++;
        Debug.Log(vidas); 
}
}
