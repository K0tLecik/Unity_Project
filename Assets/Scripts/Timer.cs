using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timerText;
    private float timeElapsed;

    void Update()
    {
        timeElapsed += Time.deltaTime;

        string minutes = Mathf.Floor(timeElapsed / 60).ToString("00");
        string seconds = (timeElapsed % 60).ToString("00");
        string milliseconds = ((timeElapsed * 1000) % 1000).ToString("000");

        timerText.text = minutes + ":" + seconds + ":" + milliseconds;
    }
}
