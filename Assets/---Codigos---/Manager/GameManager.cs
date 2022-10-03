using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    //https://www.youtube.com/watch?v=8Q9prb7PH9g&list=PLeWwtNsNObD2Pv7e7q8D0OZaz62PSR-va
    //https://www.youtube.com/watch?v=V9LV0Uaqgj4
    public static GameManager instance;
    public bool isPaused;
    public int chuleta, zanahoria, tomate;
    public Text chuletaText, zanahoriaText, tomateText;


    //public float posX;
    //public float posY;
    //public GameObject playerPos;
    private void Awake()
    {
        chuleta = PlayerPrefs.GetInt("chuletapre");
        zanahoria = PlayerPrefs.GetInt("zanahoriapre");
        tomate = PlayerPrefs.GetInt("tomatepre");
        PlayerprebsTextGui();


        // playerPos.transform.position = new Vector2(posX, posY);

        //posX = PlayerPrefs.GetFloat("guardaPosX");
        //posY = PlayerPrefs.GetFloat("guardaPosY");

        if (instance == null)
        {
            instance = this;
        }
        else
        {
            if (instance != this)
            {
                Destroy(gameObject);
            }
        }
        DontDestroyOnLoad(gameObject);
    }
    public void guardarInt()
    {
        PlayerprebsTextGui();
        PlayerPrefs.SetInt("chuletapre",chuleta);
        PlayerPrefs.SetInt("zanahoriapre", zanahoria);
        PlayerPrefs.SetInt("tomatepre", tomate);
    }
    public void GuardarPos()
    {
        //PlayerPrefs.SetFloat("guardaPosX",posX);
        //PlayerPrefs.SetFloat("guardaPosY", posY);
    }
    void OnGUI()
    {
        //Delete all of the PlayerPrefs settings by pressing this Button
        if (GUI.Button(new Rect(100, 200, 200, 60), "Delete"))
        {
            PlayerPrefs.DeleteAll();
        }
    }
    public void PlayerprebsTextGui()
    {
        chuletaText.text = chuleta.ToString();
        zanahoriaText.text = zanahoria.ToString();
        tomateText.text = tomate.ToString();
    }
}
