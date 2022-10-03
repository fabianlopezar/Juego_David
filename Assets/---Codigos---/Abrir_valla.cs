using System.Collections;
using UnityEngine;
public class Abrir_valla : MonoBehaviour
{
    public Animator anim;
    public GameObject botonAbrir;
    public int num =2;
    public bool acti=false;
    private void Start()
    {
        botonAbrir.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            botonAbrir.SetActive(true);            
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        botonAbrir.SetActive(false);
    }
    public void BotonAbrir()
    {
        if (num %2==0)
        {
           anim.SetBool("activado", true);
            StartCoroutine(Espera());
                    
        }
        if (num % 2 != 0)
        {
            anim.SetBool("activado", false);
            StartCoroutine(Espera());
           
        }
    }
    IEnumerator Espera()
    {
        yield return new WaitForSeconds(1.5f);
        num++;
    }
}
    

