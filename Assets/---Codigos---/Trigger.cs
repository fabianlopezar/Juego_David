using UnityEngine;
public class Trigger : MonoBehaviour
{
            //  ACTIVA LA BATALLA
    public GameObject[] batalla;
    public GameObject campo;
    public GameObject panel;
    public bool act=true;
    public int index;
    private void Start()
    {
        for (int i = 0; i < batalla.Length; i++)
        {
            batalla[i].SetActive(false);
        }
        
        panel.SetActive(false);
    }
    void Update()
    {
        salirBatalla(); 
    }
    void salirBatalla()
    {//no borrar esto mata al jefe
        if (act == false)
        {
            Salir();
            act = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            panel.SetActive(true);
        //    Debug.Log(""+ index);
        }
    
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        panel.SetActive(false);
    }
    public void Entrar()
    {
      batalla[index].SetActive(true);
        campo.SetActive(false);
    }
    public void Salir()
    {
        batalla[index].SetActive(false);
        campo.SetActive(true);
    }
}
