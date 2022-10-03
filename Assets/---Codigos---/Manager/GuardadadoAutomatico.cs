using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GuardadadoAutomatico : MonoBehaviour
{
    public int clicks = 0;
    public float timer = 0;
    public bool saveGame=false;
    public float timeCheck = 100;
    void Start()
    {
        LoadGameFunc();
    }

    // Update is called once per frame
    void Update()
    {
        timer = timer + 1 * Time.deltaTime;
        if (timer >= timeCheck)
        {
            saveGame = true;
        }
        if (timer == timeCheck)
        {
            SaveGameFunc();
            LoadGameFunc();
            timer = 0;
        }
    }
    public void ClickMe()
    {
        clicks += 1;
    }
    public void SaveGameFunc()
    {
        PlayerPrefs.SetInt("ClickSave", clicks);
    }
    public void LoadGameFunc()
    {
        clicks = PlayerPrefs.GetInt("ClicksSave");
    }
}
