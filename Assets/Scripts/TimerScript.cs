using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerScript : MonoBehaviour
{
    public int countDownFrom = 5;
    public TMP_Text timerUI;
    
    // Start is called before the first frame update
    void Start()
    {
        countDownTimer();
    }

    void countDownTimer()
    {
        if (countDownFrom > 0)
        {
            timerUI.text= "Time left: " + countDownFrom;
            countDownFrom--;
            Invoke("countDownTimer", 1.0f);
        }
        else
        {
            timerUI.text = "0";
            FindObjectOfType<GameManagerScript>().EndGame();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
