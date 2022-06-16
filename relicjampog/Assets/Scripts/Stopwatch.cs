using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stopwatch : MonoBehaviour
{
    public Text timerText;
    private float startTime;
    private bool finished = false;
    public GameObject TIME;
    public static string minutesfinal;
    public static string secondsfinal;


    void Start()
    {
        startTime = Time.time;
    }

    void Update()
    {
        if (finished)
            return;

        float t = Time.time - startTime;

        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("F3");

        timerText.text = minutes + ":" + seconds;
        minutesfinal = minutes;
        secondsfinal = seconds;

    }

    void finish()
    {
        finished = true;
        timerText.color = Color.yellow;
    }
}
