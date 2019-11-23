using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Time : MonoBehaviour
{
    Text text;
    int time;
    
    Text mazeChangeText;
    int mazeChangeTime;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        mazeChangeText = transform.GetChild(0).GetComponent<Text>();
        text.text = "" + GameSystem.data.gameTimeSec;
        time = GameSystem.data.gameTimeSec;
        mazeChangeTime = GameSystem.data.changeMazeSec;
        InvokeRepeating("Timer", 0f, 1f);
    }
    void Timer()
    {
        time--;
        text.text = "Time: " + time;
        
        mazeChangeTime--;
        mazeChangeText.text = "" + mazeChangeTime;

        if (mazeChangeTime == 0)
        {
            mazeChangeTime = GameSystem.data.changeMazeSec;
        }
        if (time == 0)
        {
            GameSystem.data.bluePlayer.SetActive(false);
            GameSystem.data.redPlayer.SetActive(false);
            GameSystem.data.time.gameObject.SetActive(false);
            GameSystem.data.gameOver.gameObject.SetActive(true);

            GameSystem.CancelInvokes();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
