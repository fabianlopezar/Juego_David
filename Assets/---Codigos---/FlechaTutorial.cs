using UnityEngine;
using UnityEngine.UI;
public class FlechaTutorial : MonoBehaviour
{
    public Transform flecha;
    public GameObject[] misiones;
    public int numeroMision;
    public Text misionesText;
    public int enemyDeadOso;
    public int enemyDeadLeon;
    private void Start()
    {
        numeroMision = PlayerPrefs.GetInt("nMision");
    }
    private void Update()
    {     
        Vector3 direction = flecha.position - misiones[numeroMision].transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, 5 * Time.deltaTime);
        Misionestext();    

        GameObject[] items = GameObject.FindGameObjectsWithTag("Enemy");

        if (items.Length <= enemyDeadOso && numeroMision==3)
        {
            numeroMision += 1; 
        }
        if (items.Length <= enemyDeadLeon && numeroMision == 4)
        { 
            numeroMision += 1; 
        }
       //Debug.Log("enemigos son = "+items.Length);
       
    }
    public void Misionestext()
    {
        PlayerPrefs.SetInt("nMision", numeroMision);
        if (numeroMision == 0)
        misionesText.text = "Te falta una oveja en el corral, tienes que ir a buscarla";
        if (numeroMision == 1)
            misionesText.text = "Debes llevar a las ovejas a pastar";
        if (numeroMision ==2)
            misionesText.text = "Guardar las ovejas en el corral";       
        if (numeroMision == 3)
            misionesText.text = "Derrotar osos";
        if (numeroMision == 4)
            misionesText.text = "Derrotar leones";
        // recolecta 15 tomates 15 chuletas 30 zanahorias
        if (numeroMision == 5)
            misionesText.text = "Debes llevar comida a tus hermanos";
        if (numeroMision == 6)
            misionesText.text = "Habla con el rey"; 
        if (numeroMision == 7)
            misionesText.text = "Derrotar a Goliat";
        if (numeroMision == 8)
            misionesText.text = "Derrotar Soldados";
    }

}
