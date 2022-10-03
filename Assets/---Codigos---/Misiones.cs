using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class Misiones : MonoBehaviour
{
   // public int numeroMision = 0;

    public GameObject panelMisiones;
    public GameObject botonRecibir;
    public GameObject btnAurora;
    public Text misionesText;
    public Animator animator;
    public ContarOveja nOvejas;
    public GameObject varaBtn;
    private void Start()
    {
        panelMisiones.SetActive(false);
        btnAurora.SetActive(false);
        varaBtn.SetActive(false);
        botonRecibir.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("papa"))
        {
            panelMisiones.SetActive(true);
            //     0. comprobar si ya se hizo mision si es verdadero leer"que dia tan bonito esta hoy" "¿aparece boton nececitas ayuda?". de lo contrario
            if (nOvejas.numeroOvejas >= 6)
            {
                misionesText.text = "¡Hola!, Que dia tan bonito esta hoy";
                botonRecibir.SetActive(true);
            }
            //     1. activar bloque de texto " guarda las ovejas entre mas ovejas guardadas tendras mayor fe".
           else
            misionesText.text = "¡Hola!, Guarda las ovejas entre mas ovejas guardadas tendras mayor fe";
            varaBtn.SetActive(true);
            //     2. mostrar tutorial.
            //     3. dar el icono de vara. 
        }
        if (collision.CompareTag("mama"))
        {
            //      0. comprobar si ya trajo comida si es verdadero"3." de lo contrario"1."
            //      1. activar bloque de texto "traeme 15 zanahorias 15 tomates y 15 chuletas".
            panelMisiones.SetActive(true);
            misionesText.text = "¡Hola!, traeme 15 zanahorias 15 tomates y 15 chuletas";
            //      2. activar bloque "dar comida" restar comida.
            //      3. cambia bloque por "llevale comida  a tus hermanos".
            //      4. dar mapa y tutorial de donde estan
        }
        if (collision.CompareTag("Player"))
        {
            //      0. comprobar si colisionaron con los hermanos
            //      1. mostrar texto "ve ha hablar con el rey"
        }
        if (collision.CompareTag("Player"))
        {
            //     0. comprobar si collisiono con el rey y no a derrotado a goliat
            //     1. activar bloque "Derrota a goliat"
            //     2. activar bloque "eres el Rey"
        }
        if (collision.CompareTag("aurora"))
        {
            btnAurora.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        btnAurora.SetActive(false);
        panelMisiones.SetActive(false);
    }
    public void BtnAurora()
    {
        animator.SetBool("orando",true);
        StartCoroutine(Espera());
    }

    IEnumerator Espera()
    {
        yield return new WaitForSeconds(1.3f);
        animator.SetBool("orando", false);
    }
    public void SeleccionarBoton(int v)
    {
        switch (v)
        {
            case 0:
                Debug.Log("deberia funcionar");
                //mision papa
                //subir de fe
                break;
            case 1:
                //mision mama 1
                break;
            case 2:
                //mision mama 2
                break;
            case 3:
                //mision mama 3
                break;
            case 4:
                //mision llevar comida
                break;
            case 5:
                //goliat derrotato
                break;
        }
    }
   
}
