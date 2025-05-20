using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class OBJETOS : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other) //objeto recogido
    {
        if (other.CompareTag("Player"))
        {
            FindObjectOfType<Objetosrecogibles>().SumarObjeto();
            Destroy(gameObject);
        }
    }
}
