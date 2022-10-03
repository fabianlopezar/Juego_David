using UnityEngine;
public class ContarOveja : MonoBehaviour
{
    public float numeroOvejas=0;
   // private FlechaTutorial a;
    public int ovejasNeed;
    private void Start()
    {
//        a = FindObjectOfType<FlechaTutorial>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Oveja"))
        {
            numeroOvejas++;
        //    if (numeroOvejas == ovejasNeed && a.numeroMision==0)
        ////        a.numeroMision++;            
            
        //    if (numeroOvejas == ovejasNeed && a.numeroMision==1)            
        //  //      a.numeroMision++;
            
        //    if (numeroOvejas == ovejasNeed && a.numeroMision==2)
        //    //    a.numeroMision++;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Oveja"))
        { numeroOvejas--; }
    }
   
}
