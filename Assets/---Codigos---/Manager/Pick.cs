using UnityEngine;
public class Pick : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("chuleta"))
        {  
            Destroy(collision.gameObject);
            GameManager.instance.chuleta++;
            GameManager.instance.guardarInt();
        }
        if (collision.gameObject.CompareTag("zanahoria"))
        {
            Destroy(collision.gameObject);
            GameManager.instance.zanahoria++;
            GameManager.instance.guardarInt();
        }
        if (collision.gameObject.CompareTag("tomate"))
        {
            Destroy(collision.gameObject);
            GameManager.instance.tomate++;
            GameManager.instance.guardarInt();
        }
    }
}

