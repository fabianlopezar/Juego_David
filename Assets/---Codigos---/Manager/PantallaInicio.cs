using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PantallaInicio : MonoBehaviour
{
    public GameObject panelPantallaInicial;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Jugar()
    {
        panelPantallaInicial.SetActive(false);
    }
}
