using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Enemigos : MonoBehaviour
{
    public Rigidbody2D rb;
    public string nombreEnemigo;
    //vida
    public Image barraDeVida;
    public float vidaActual;
    public float vidaMaxima;

    public float speed;
    void Update()
    {
        barraDeVida.fillAmount = vidaActual / vidaMaxima;
    }
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();

    }
}
