using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    private float timer = 0;
    private bool checkEnd = false;
    public Text timerText;

    void Start()
    {

    }

    public void endGame()
    {
        checkEnd = true;
    }

    void UpdateTime()
    {
        timer += Time.deltaTime;
        int minutes = (int)(timer / 60);
        int seconds = (int)(timer % 60);
        timerText.text = string.Format("Czas gry: {0:00}:{1:00}", minutes, seconds);
    }
    
    void Update()
    {
        if(checkEnd == false)
        {
            UpdateTime();
        }
    }
}
