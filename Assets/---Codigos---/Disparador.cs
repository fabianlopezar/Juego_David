using UnityEngine;
using System.Collections;
public class Disparador : MonoBehaviour
{
    public GameObject ammunition;
    public Transform firePort;
    public float recargarRoca;
    bool isFiring;
    bool stopFiring;


    // Use this for initialization
    void Start()
    {

    }

    public void pointerDown()
    {
        stopFiring = false;
        makeFireVariableTrue();
    }

    public void pointerUp()
    {
        isFiring = false;
        stopFiring = true;
    }

    void makeFireVariableTrue()
    {
        isFiring = true;
    }

    void makeFireVariableFalse()
    {
        isFiring = false;
        if (stopFiring == false)
        {
            Invoke("makeFireVariableTrue", recargarRoca);
        }
    }

    // Update is called once per frame
    void Update()
    {

        if (isFiring)
        {
            makeFireVariableFalse();
            Instantiate(ammunition, firePort.position, firePort.rotation);
        }

    }
}
