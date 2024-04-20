using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timmer : MonoBehaviour
{
    public float totalTime = 30f;

    private Text timerText;
    private float timeRemaining;

    void Start()
    {
        timerText = GetComponent<Text>();
        timeRemaining = totalTime;
    }

    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            timerText.text ="Time :"+ Mathf.RoundToInt(timeRemaining).ToString();
        }
        else
        {
            // TODO: Show score or end game here
            timerText.text = "Time's up!";
            Time.timeScale = 0f;
        }
    }
}





